#pragma once

namespace Interop
{
// Should match sQuote.cs on C# boundary of interop
struct sQuote
{
	int quoteID;
	BSTR quoteName;
	BSTR customerName;
	eDoorMaterial doorMaterial;
	eDoorSize doorSize;
	double price;
};
}