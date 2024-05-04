#pragma once
#include "iQuoteManager.h"
#include "../Main/QuoteManager.h"
#include "../PricerService/Impl/FakePricerService.h"
#include "../WindowQuoteProDataAccess/Impl/SQLiteQuoteRepository.h"
#include "ComRoot.h"

namespace Interop
{

class NativeQuoteManager : public ComRoot<iQuoteManager>
{
	QuoteManager m_q;
public:
	NativeQuoteManager() : m_q(new FakePricerService(), new SQLiteQuoteRepository("test.db")){}
	HRESULT __stdcall createQuote(const wchar_t* quoteName, const wchar_t* customerName, eDoorMaterial material, eDoorSize size, sQuote& qoute);
	HRESULT __stdcall getQuote(int id, sQuote& qoute);
	HRESULT __stdcall updateQuote(const sQuote& qoute);
	HRESULT __stdcall deleteQuote(int id);
	HRESULT __stdcall getAllQuotes(pfnHaveQuotes pfnResult);
};
}