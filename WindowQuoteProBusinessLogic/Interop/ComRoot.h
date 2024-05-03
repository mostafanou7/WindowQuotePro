#pragma once
#include <atlcoll.h>
#include <atlstr.h>
#include <atltypes.h>
#include <atlcom.h>
// A base class for IUnknown-derived objects used in the interop of the DLL.
// .NET code uses them from different threads. By default i.e. without type libraries, .NET assumes the objects implementing COM interfaces use apartment threading.
// We certainly don't want to mess with type libraries as they would dramatically complicate everything: need to register DLLs on install, xcopy deployment wouldn't work, also this C++ project would be way more complicated for no good reason.
// That's why this workaround instead. Because of this class, all objects implement IMarshal interface, and return the implementation created by CoCreateFreeThreadedMarshaler API
// https://docs.microsoft.com/en-us/windows/desktop/api/combaseapi/nf-combaseapi-cocreatefreethreadedmarshaler
// This instructs .NET runtime to call interfaces directly, on whatever thread a method was called, without any synchronization or marshaling.
template<class I>
class ComRoot : public CComObjectRootEx<CComMultiThreadModel>, public I
{
public:
	ComRoot() = default;
	virtual ~ComRoot() = default;

	BEGIN_COM_MAP( ComRoot )
		COM_INTERFACE_ENTRY( I )
		COM_INTERFACE_ENTRY_AGGREGATE( IID_IMarshal, m_ftm )
	END_COM_MAP()

	HRESULT FinalConstruct()
	{
		// https://stackoverflow.com/a/34978626/126995
		IUnknown* pUnk = GetUnknown();
		return CoCreateFreeThreadedMarshaler( pUnk, &m_ftm );
	}

private:

	CComPtr<IUnknown> m_ftm;
};

template<class CoClass>
inline HRESULT createInstance( CComPtr<CComObject<CoClass>>& p )
{
	p = nullptr;
	CComObject<CoClass>** pp = &p;
	CComObject<CoClass>::CreateInstance( pp );
	( *pp )->AddRef();	// Unlike CoCreateInstance, CComObject::CreateInstance creates an object with reference counter = 0
	return S_OK;
}