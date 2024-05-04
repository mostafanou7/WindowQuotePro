#pragma once
#include "Enums.h"
#include <Entities/Enums.h>
namespace
{

std::string utf8StringCpp(LPCTSTR str, size_t countChars)
{
	using namespace std::string_literals;
	if (nullptr == str || countChars <= 0)
		return ""s;

	const int length = (int)countChars;
	std::string ret;
	const int len = WideCharToMultiByte(CP_UTF8, 0, str, length, nullptr, 0, nullptr, nullptr);
	if (len > 0)
	{
		ret.resize((size_t)len);
		auto buff = const_cast<char*>(ret.data());
		WideCharToMultiByte(CP_UTF8, 0, str, length, buff, len, nullptr, nullptr);
	}
	return std::move(ret);
}

CStringA utf8String(LPCTSTR str)
{
	const int length = (int)wcsnlen_s(str, 2048);
	CStringA ret;
	const int len = WideCharToMultiByte(CP_UTF8, 0, str, length, nullptr, 0, nullptr, nullptr);
	if (len > 0)
	{
		char* const buff = ret.GetBufferSetLength(len + 1);
		WideCharToMultiByte(CP_UTF8, 0, str, length, buff, len, nullptr, nullptr);
		buff[len] = 0;
		ret.ReleaseBuffer(len);
	}
	return ret;
}

inline const char* cstr(const CStringA& str)
{
	return str;
}

inline const wchar_t* cstr(const CString& str)
{
	return str;
}


Interop::eDoorMaterial toInterop(DoorMaterial e)
{
	switch (e)
	{
	case DoorMaterial::Wood:
		return Interop::eDoorMaterial::Wood;
	case DoorMaterial::Metal:
		return Interop::eDoorMaterial::Metal;
	default:
		throw std::exception("unexpected DoorMaterial enum value");
	}
}

Interop::eDoorSize toInterop(DoorSize e)
{
	switch (e)
	{
	case DoorSize::Small:
		return Interop::eDoorSize::Small;
	case DoorSize::Medium:
		return Interop::eDoorSize::Medium;
	case DoorSize::Large:
		return Interop::eDoorSize::Large;
	default:
		throw std::exception("unexpected DoorSize enum value");
	}
}

DoorMaterial fromInterop(Interop::eDoorMaterial e)
{
	switch (e)
	{
	case Interop::eDoorMaterial::Wood:
		return DoorMaterial::Wood;
	case Interop::eDoorMaterial::Metal:
		return DoorMaterial::Metal;
	default:
		throw std::exception("unexpected eDoorMaterial enum value");
	}
}

DoorSize fromInterop(Interop::eDoorSize e)
{
	switch (e)
	{
	case Interop::eDoorSize::Small:
		return DoorSize::Small;
	case Interop::eDoorSize::Medium:
		return DoorSize::Medium;
	case Interop::eDoorSize::Large:
		return DoorSize::Large;
	default:
		throw std::exception("unexpected eDoorSize enum value");
	}
}

Interop::sQuote toInterop(const Quote& q)
{
	Interop::sQuote iq{};
	iq.quoteID = q.getQuoteID();
	CString quoteName(q.getQuoteName().c_str());
	CComBSTR bs{ quoteName };
	iq.quoteName = bs.Copy();
	CString customerName(q.getCustomerName().c_str());
	CComBSTR bs1{ customerName };
	iq.customerName = bs1.Copy();
	iq.doorMaterial = toInterop(q.getDoorMaterial());
	iq.doorSize = toInterop(q.getDoorSize());
	iq.price = q.getPrice();
	return iq;
}

Quote fromInterop(const Interop::sQuote& iq)
{
	Quote q{};
	q.setQuoteID(iq.quoteID);
	const CStringA& quoteName = utf8String(iq.quoteName);
	q.setQuoteName(quoteName);
	const CStringA& customerName = utf8String(iq.customerName);
	q.setCustomerName(customerName);
	q.setDoorMaterial(fromInterop(iq.doorMaterial));
	q.setDoorSize(fromInterop(iq.doorSize));
	q.setPrice(iq.price);
	return q;
}
}