#include <Windows.h>
//#include <tchar.h>
#include <wchar.h>
#include <vector>
#include <iostream>
#include "resource.h"
#include <stdio.h>

struct Operation
{
	bool add;
	bool minus;
	bool div;
	bool mult;

};

Operation op;

BOOL CALLBACK DlgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	static Operation op;


	switch (uMsg)
	{

	case WM_INITDIALOG:

		return 1;

	case WM_LBUTTONDOWN:
	{
		HWND hCalc = FindWindow(L"CalcFrame",L"Calculator");
		SetWindowText(hCalc, L"Copyright");
		SendMessage(hCalc, WM_CLOSE, 0, 0);
	}
	break;

	case WM_MOVE:
		break;

	case WM_COMMAND:
	{
		switch (wParam)
		{		
		case IDC_EQUALS:
		{
			int sec = SendDlgItemMessage(hWnd, IDCSECOND, EM_LINELENGTH, 0, 0);
			int first = SendDlgItemMessage(hWnd, IDC_FIRST, EM_LINELENGTH, 0, 0);
			int res = 0;
			

			if (op.add)
			{
				res = first + sec;
			}
			else if(op.minus)
			{
				res = first - sec;
			}
			else if (op.mult)
			{
				res = first * sec;
			}
			else if (op.div)
			{
				if (sec != 0)
				{
					res = first / sec;
				}
			}

			char buff[25];
			_itoa_s(res, buff, 10);

			SetDlgItemText(hWnd, IDC_RESULT, (wchar_t*)res);

		}
			break;
		case IDC_ADD:
			op.add = !op.add;
			break;
		case IDC_MNUS1:
			op.minus = !op.minus;
			break;
		case IDC_MULTIPLICATION:
			op.mult = !op.mult;
			break;
		case IDC_DIVISION:
			op.div = !op.div;
			break;



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

	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);

	return 0;
}