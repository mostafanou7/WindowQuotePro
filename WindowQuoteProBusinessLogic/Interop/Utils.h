#pragma once
#include "Enums.h"
#include <Entities/Enums.h>
namespace
{
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
	iq.quoteName = CString(q.getQuoteName().c_str()).AllocSysString();
	iq.customerName = CString(q.getCustomerName().c_str()).AllocSysString();
	iq.doorMaterial = toInterop(q.getDoorMaterial());
	iq.doorSize = toInterop(q.getDoorSize());
	iq.price = q.getPrice();
	return iq;
}

Quote fromInterop(const Interop::sQuote& iq)
{
	Quote q{};
	q.setQuoteID(iq.quoteID);
	q.setQuoteName(CString(iq.quoteName).GetBuffer());
	q.setCustomerName(CString(iq.customerName).GetBuffer());
	q.setDoorMaterial(fromInterop(iq.doorMaterial));
	q.setDoorSize(fromInterop(iq.doorSize));
	q.setPrice(iq.price);
	return q;
}
}