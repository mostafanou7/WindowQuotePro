// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

class CModule : public CAtlDllModuleT<CModule> { };

CModule _AtlModule;

BOOL APIENTRY DllMain( HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved )
{
#ifdef _DLL
	if( ul_reason_for_call == DLL_PROCESS_ATTACH )
		DisableThreadLibraryCalls( hModule );
#endif
	return _AtlModule.DllMain( ul_reason_for_call, lpReserved );
}

