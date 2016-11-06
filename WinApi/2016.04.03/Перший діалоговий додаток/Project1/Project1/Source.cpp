#include <Windows.h>
#include <tchar.h>
#include <ctime>
#include <vector>
#include "resource.h"

BOOL CALLBACK DlgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	
	case WM_INITDIALOG:

		return 1;

	case WM_COMMAND:
		{
			switch (wParam)
			{
			case IDOK:
				MessageBox(hWnd, L"OK", L"INFO", MB_OK);
				return 1;
			case IDCANCEL:
				MessageBox(hWnd, L"CANCEL", L"INFO", MB_OK);
				return 1;
			}
		}
		break;

	case WM_CLOSE:
		EndDialog(hWnd, 1);
		return 1;
	}
	return 0;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR nCmd, int nCmdShow)
{
	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);
	return 0;
}