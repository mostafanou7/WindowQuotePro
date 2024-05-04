#include "pch.h"
#include "NativeQuoteManager.h"
#include "Impl/FakePricerService.h"
#include "Impl/SQLiteQuoteRepository.h"
#include "Utils.h"


HRESULT __stdcall Interop::NativeQuoteManager::createQuote(const wchar_t* quoteName, const wchar_t* customerName, eDoorMaterial material, eDoorSize size, sQuote& iQoute)
{
	auto quote = m_q.createQuote(cstr(utf8String(quoteName)), cstr(utf8String(customerName)), fromInterop(material), fromInterop(size));
	iQoute = toInterop(quote);
	return S_OK;
}

HRESULT __stdcall Interop::NativeQuoteManager::getQuote(int id, sQuote& iQoute)
{
	auto quote = m_q.getQuote(id);
	iQoute = toInterop(quote);
	return S_OK;
}

HRESULT __stdcall Interop::NativeQuoteManager::updateQuote(const sQuote& iQoute)
{
	bool success = m_q.updateQuote(fromInterop(iQoute));
	return success ? S_OK : S_FALSE;
}

HRESULT __stdcall Interop::NativeQuoteManager::deleteQuote(int id)
{
	bool success = m_q.deleteQuote(id);
	return success ? S_OK : S_FALSE;
}

HRESULT __stdcall Interop::NativeQuoteManager::getAllQuotes(pfnHaveQuotes pfnResult)
{
	auto vec = m_q.getAllQuotes();

	std::vector<sQuote> iVec(vec.size());

	for (size_t i = 0; i < vec.size(); i++)
	{
		iVec[i] = toInterop(vec[i]);
	}

	pfnResult((uint32_t)iVec.size(), iVec.data());

	return S_OK;
}

HRESULT __stdcall Interop::NativeQuoteManager::closedb()
{
	m_q.closedb();
	return S_OK;
}


HRESULT __stdcall CreateNativeQuoteManager(Interop::iQuoteManager** ppResult)
{
	if (nullptr == ppResult)
		return E_POINTER;

	CComPtr<CComObject<Interop::NativeQuoteManager>> res;
	createInstance<Interop::NativeQuoteManager>(res);
	*ppResult = res.Detach();
	return S_OK;
}