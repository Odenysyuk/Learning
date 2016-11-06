#include <Windows.h>
#include "resource.h"
#include <tchar.h>


BOOL CALLBACK DlgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	static HMENU hMenu;
	static OPENFILENAME ofn;
	static wchar_t file[MAX_PATH];

	switch (uMsg)
	{
	case WM_COMMAND:
	{
		hMenu = LoadMenu(GetModuleHandle(NULL), MAKEINTRESOURCE(IDR_MENU2));
		SetMenu(hWnd, hMenu);
		EnableMenuItem(hMenu, ID_EDIT_PASTE40003, MF_BYCOMMAND | MF_GRAYED);


		ofn.lStructSize = sizeof(OPENFILENAME);
		ofn.hwndOwner = hWnd;
		ofn.lpstrFile = file;
		ofn.nMaxFile = MAX_PATH;

	}
	{
		switch (LOWORD(wParam))
		{
		case ID_FILE_CLOSE40008:
			EndDialog(hWnd, 1);
			return 0;
		case ID_FILE_SAVE40002:
		{
			bool success = GetSaveFileName(&ofn);

			if (success)
			{
				MessageBox(hWnd, ofn.lpstrFile, L"Success", MB_OK);
			}
			else
			{
				MessageBox(hWnd, L"Refuse", L"Refuse", MB_OK);
			}
		}
		break;
		break;
		case ID_EDIT_UNDO40004:
			SendDlgItemMessage(hWnd, IDC_EDIT1, WM_UNDO, 0, 0);
			SendMessage(hWnd, WM_CLOSE, 0, 0);
			break;
		case ID_EDIT_CUT40006:
			SendDlgItemMessage(hWnd, IDC_EDIT1, WM_CUT, 0, 0);
			EnableMenuItem(hMenu, ID_EDIT_PASTE40003, MF_BYCOMMAND | MF_ENABLED);
			break;
		case ID_EDIT_COPY40007:
			SendDlgItemMessage(hWnd, IDC_EDIT1, WM_COPY, 0, 0);
			EnableMenuItem(hMenu, ID_EDIT_PASTE40003, MF_BYCOMMAND | MF_ENABLED);
			break;
		case ID_EDIT_PASTE40003:
			SendDlgItemMessage(hWnd, IDC_EDIT1, WM_PASTE, 0, 0);
			EnableMenuItem(hMenu, ID_EDIT_PASTE40003, MF_BYCOMMAND | MF_GRAYED);
			break;
		case ID_FILE_NEW40001:
		{
			bool success = GetOpenFileName(&ofn);

			if (success)
			{
				MessageBox(hWnd, ofn.lpstrFile, L"Success", MB_OK);
			}
			else
			{
				MessageBox(hWnd, L"Refuse", L"Refuse", MB_OK);
			}			}
		break;
		case ID_EDIT_SELECTLINE:
		{
			int lineIndex = SendDlgItemMessage(hWnd, IDC_EDIT1, EM_LINEFROMCHAR, -1, 0);
			int start = SendDlgItemMessage(hWnd, IDC_EDIT1, EM_LINEINDEX, lineIndex, 0);
			int end = SendDlgItemMessage(hWnd, IDC_EDIT1, EM_LINELENGTH, start, 0);
			SendDlgItemMessage(hWnd, IDC_EDIT1, EM_SETSEL, start, start + end);
		}
		break;
		}
	}
	break;


	case WM_CLOSE:

		int answer = MessageBox(NULL, _T("Are you want to exit?"), _T("Quit"), MB_YESNO | MB_ICONQUESTION);
		if (answer == IDYES)
			EndDialog(hWnd, 1);
		return 0;
	}

	return 0;
}


INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR sStr, int nCmd)
{
	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);

	return 0;
}