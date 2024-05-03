#pragma once
#include<stdexcept>
#include<string>
/**
 * Enum struct for door materials.
 */
enum struct DoorMaterial {
	Wood,
	Metal
};


/**
 * Enum struct for door sizes.
 */
enum struct DoorSize {
	Small,
	Medium,
	Large
};

std::string to_string(DoorMaterial e)
{
	using namespace std::string_literals;
	switch (e)
	{
	case DoorMaterial::Wood:
		return "Wood"s;
	case DoorMaterial::Metal:
		return "Metal"s;
	default:
		throw std::invalid_argument("unexpected DoorMaterial enum value");
	}
}

std::string to_string(DoorSize e)
{
	using namespace std::string_literals;
	switch (e)
	{
	case DoorSize::Small:
		return "Small"s;
	case DoorSize::Medium:
		return "Medium"s;
	case DoorSize::Large:
		return "Large"s;
	default:
		throw std::invalid_argument("unexpected DoorSize enum value");
	}
}

DoorMaterial to_DoorMaterial(std::string s)
{
	if (strcmp(s.c_str(), "Wood") == 0)
		return DoorMaterial::Wood;
	if (strcmp(s.c_str(), "Metal") == 0)
		return DoorMaterial::Metal;

	throw std::invalid_argument("no equivalent DoorMaterial enum value");
}

DoorSize to_DoorSize(std::string s)
{
	if (strcmp(s.c_str(), "Small") == 0)
		return DoorSize::Small;
	if (strcmp(s.c_str(), "Medium") == 0)
		return DoorSize::Medium;
	if (strcmp(s.c_str(), "Large") == 0)
		return DoorSize::Large;

	throw std::invalid_argument("no equivalent DoorSize enum value");
}