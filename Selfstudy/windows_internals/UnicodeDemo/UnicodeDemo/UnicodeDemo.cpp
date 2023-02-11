#include "stdafx.h"

int _tmain(int argc, _TCHAR* argv[])
{
	// ===========================================================================
	// NOTE:
	//		CreateFile<W|A> is actually not a function, 
	//		it's a macro that allows you to choose between Unicode and ASCII.
	// 
	// Which one to use?
	//		Use Unicode.
	// ===========================================================================

	// CreateFileW for Unicode version (and must use the 'L' as shown)
	HANDLE hFileW = CreateFileW(L"data_unicode.txt", GENERIC_WRITE, 0, nullptr, CREATE_ALWAYS, 0, 0);
	CloseHandle(hFileW);

	// CreateFileA for ASCII vesion (essentially same as 'Multi-Byte Character Set)
	HANDLE hFileA = CreateFileA("data_ascii.txt", GENERIC_WRITE, 0, nullptr, CREATE_ALWAYS, 0, 0);
	CloseHandle(hFileA);
	
	return 0;
}