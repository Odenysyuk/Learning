#include <Windows.h>
//#include <tchar.h>
#include <wchar.h>
#include <vector>
#include <iostream>
#include "resource.h"
#include <stdio.h>




float GetDer(std::vector<char*> algoritm) {
	float res= 0;
	for (int i = 0; i < algoritm.size(); i++)
	{
		if (algoritm[i] == "+")
		{
			res = +atoi(algoritm[++i]);
		}
		else if (algoritm[i] == "-")
		{
			res = -atoi(algoritm[++i]);
		}
		else if (algoritm[i] == "*")
		{
			res = res * atoi(algoritm[++i]);
		}
		else if (algoritm[i] == "/")
		{
			res = res  / atoi(algoritm[++i]);
		}
		else 
		{
			return 0;

		}

	}
	
	return res;
};

BOOL CALLBACK DlgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	static wchar_t temp[255];
	static std::vector<char*>  algoritm;
	static float res = 0, temp_number=0;


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

		case IDC_ONE:
			res = res * 10 + 1;
			wcscat_s(temp, L"1");
			SetDlgItemText(hWnd, IDC_RESULT, temp);
			break;
		case IDC_TWO:
			res = res * 10 + 2;			
			wcscat_s(temp, L"2");
			SetDlgItemText(hWnd, IDC_RESULT, temp);
			break;
		case IDC_THREE:
			res = res * 10 + 3;
			wcscat_s(temp, L"3");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_FOUR:
			res = res * 10 + 4;
			wcscat_s(temp, L"4");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_FIVE:
			res = res * 10 + 5;
			wcscat_s(temp, L"5");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_SIX:
			res = res * 10 + 6;
			wcscat_s(temp, L"6");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_SEVEN:
			res = res * 10 + 7;
			wcscat_s(temp, L"7");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_EIGHT:
			res = res * 10 + 8;
			wcscat_s(temp, L"8");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_NINE:
			res = res * 10 + 9;
			wcscat_s(temp, L"9");
			SetDlgItemText(hWnd, IDC_RESULT, temp);

			break;
		case IDC_ZERO:
			if (res != 0)
			{
				res = res * 10;
				wcscat_s(temp, L"0");
				SetDlgItemText(hWnd, IDC_RESULT, temp);
			}

			break;
		case IDC_DIVISION:

		{
			char buff[25];
			_itoa_s(res, buff, 10);
			algoritm.push_back(buff);
			algoritm.push_back("/");
		}

		res = 0;
		wcscat_s(temp, L"/");
		SetDlgItemText(hWnd, IDC_RESULT, temp);
		break;
		case IDC_MULTIPLICATION:
		{
			char buff[25];
			_itoa_s(res, buff, 10);
			algoritm.push_back(buff);
			algoritm.push_back("*");
		}

		res = 0;
		wcscat_s(temp, L"*");
		SetDlgItemText(hWnd, IDC_RESULT, temp);
		break;
		case IDC_MINUS:
		{
			char buff[25];
			_itoa_s(res, buff, 10);
			algoritm.push_back(buff);
			algoritm.push_back("-");
		}

		res = 0;
		wcscat_s(temp, L"-");
		SetDlgItemText(hWnd, IDC_RESULT, temp);
		break;

		case IDC_PLUS:
		{
			char buff[25]; 
			_itoa_s(res, buff, 10);
			algoritm.push_back(buff);
			algoritm.push_back("+");
		}

		res = 0;
		wcscat_s(temp, L"+");
		SetDlgItemText(hWnd, IDC_RESULT, temp);
		break;

		case IDC_EQUAL: 
		{
		
			res = GetDer(algoritm);
			char buff[25];
			_itoa_s(res, buff, 10);
			wcscpy_s(temp, (wchar_t *)buff);
			SetDlgItemText(hWnd, IDC_RESULT, temp);

		}
			
			break;

		case IDC_ESC:
			res = 0;
			wcscpy_s(temp, L"");
			SetDlgItemText(hWnd, IDC_RESULT, L"0");
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