#pragma once
#include <Unknwn.h>
#include "Enums.h"
#include "sQuote.h"

namespace Interop
{

using pfnHaveQuotes = void(__stdcall*)(uint32_t length, const sQuote* data);

__interface __declspec(uuid("98DA7DE7-7A0F-4DE5-881C-0CFDCFCC3221")) iQuoteManager : public IUnknown
{
	HRESULT __stdcall createQuote(const char* quoteName, const char* customerName, eDoorMaterial material, eDoorSize size, sQuote& qoute);
	HRESULT __stdcall getQuote(int id, sQuote& qoute);
	HRESULT __stdcall updateQuote(const sQuote& qoute);
	HRESULT __stdcall deleteQuote(int id);
	HRESULT __stdcall getAllQuotes(pfnHaveQuotes pfnResult);
};
}