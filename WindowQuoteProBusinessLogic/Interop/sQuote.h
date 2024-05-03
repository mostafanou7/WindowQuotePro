#pragma once

namespace Interop
{
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