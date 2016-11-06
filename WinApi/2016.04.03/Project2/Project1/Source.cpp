#include <Windows.h>
#include <tchar.h>
#include <ctime>
#include <vector>
#include "resource.h"

BOOL CALLBACK DlgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	static bool change = true;
	switch (uMsg)
	{

	case WM_INITDIALOG:

		return 1;

	case WM_LBUTTONDOWN:
		{
			//HWND hCalc = FindWindow(L"CalcFrame",L"Calculator");
			//SetWindowText(hCalc, L"Copyright");
			//SendMessage(hCalc, WM_CLOSE, 0, 0);
		}
		break;

	case WM_MOVE:
		//MessageBox(hWnd, L"Got WM_MOVE message", L"", MB_OK);
		break;

	case WM_COMMAND:
		{
			switch (wParam)
			{
			case IDOK:
				{
				HWND hStatic = GetDlgItem(hWnd, IDC_STATIC1);
				SetWindowText(hStatic, L"Copyright");
				}
				return 1;
			case IDCANCEL:
				MessageBox(hWnd, L"CANCEL", L"INFO", MB_OK);
				EndDialog(hWnd, 1);
				return 1;

			case IDC_MYSUBUTTON:
				{
					//HWND hOK = GetDlgItem(hWnd, IDOK);
					//SetWindowText(hOK, L"Other text");
					SetDlgItemText(hWnd, IDOK, L"Other text");
				
				}		

				return 1;
			case IDC_BUTTON1:
				{
					wchar_t text[60];
					if(change==true)
					{
						GetDlgItemText(hWnd, IDC_STATIC1, text, 60);
						
						change=false;
					}
					else
					{
						GetDlgItemText(hWnd, IDOK, text, 60);
						change=true;
					}
					SetDlgItemText(hWnd, IDCANCEL, text);
				}
				return 1;
			}
		}
		break;

	case WM_CLOSE:
		EndDialog(hWnd, 0);
		return 1;
	}
	return 0;
}




int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR nCmd, int nCmdShow)
{

	int result = DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);
	if(result == 1)
	{
		MessageBox(NULL, L"Changes saved", L"Result", MB_OK);
	}

	return 0;
}