#include <Windows.h>
#include <string>
#include <vector>
#include <fstream>
#include "resource.h"

using std::wstring;
using std::vector;
using std::fstream;

class Workers
{
	wstring name;
	wstring surname;
	wstring salary;
	wstring department;
	wstring nameSurname;
public:
	Workers(wstring name,
	wstring surname,
	wstring salary,
	wstring department)
	{
		this->name=name;
		this->surname=surname;
		this->salary = salary;
		this->department = department;
		nameSurname = wstring(name+L", "+surname + L", " + salary + L", " + department);
	}
	void SetSalary(wchar_t* s)
	{
		salary = wstring(s);
	}
	wchar_t* GetSalary()
	{
		return const_cast<wchar_t*>(salary.c_str());
	}
	void SetDepartament(wchar_t* dp)
	{
		department = wstring(dp);
	}
	wchar_t* GetDepartament()
	{
		return const_cast<wchar_t*>(department.c_str());
	}

	wchar_t* GetNameSurname()
	{
		
		return const_cast<wchar_t*>(nameSurname.c_str());
	}
};

vector<Workers> records;

BOOL CALLBACK DlgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	
	switch (uMsg)
	{

	case WM_INITDIALOG:
		for(int i=0; i<records.size(); ++i)
		{
			SendDlgItemMessage(hWnd, IDC_LIST1, LB_ADDSTRING, 0, (LPARAM)records[i].GetNameSurname());
		}

		return 1;

	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDC_ADD:
		{
			wchar_t name[32], surname[32], salary[32], department[32];
			GetDlgItemText(hWnd, IDC_NAME, name, 32);
			GetDlgItemText(hWnd, IDC_SURNAME, surname, 32);
			GetDlgItemText(hWnd, IDC_SALARY, salary, 32);
			GetDlgItemText(hWnd, IDC_DEPARTMENT, department, 32);

			Workers temp = Workers(name, surname, salary, department);
			records.push_back(temp);
			SendDlgItemMessage(hWnd, IDC_LIST1, LB_ADDSTRING, 0, (LPARAM)temp.GetNameSurname());
		}
		break;
		case IDC_DELETE:
		{
			wchar_t buff[32];

			int index = SendDlgItemMessage(hWnd, IDC_LIST1, LB_GETCURSEL, 0, 0);
			SendDlgItemMessage(hWnd, IDC_LIST1, LB_GETTEXT, index, (LPARAM)buff);
			for (int i = 0; i<records.size(); ++i)
			{
				if (!wcsncmp(records[i].GetNameSurname(), buff, 32))
				{
					records.erase(records.begin() + i);
					break;
				}
			}
		}
		SendDlgItemMessage(hWnd, IDC_LIST1, LB_RESETCONTENT, 0, 0);

		for (int i = 0; i<records.size(); ++i)
		{
			SendDlgItemMessage(hWnd, IDC_LIST1, LB_ADDSTRING, 0, (LPARAM)records[i].GetNameSurname());
		}

		break;
		}
		return 0;

	case WM_CLOSE:
		EndDialog(hWnd, 1);
		return 0;
	}

	return 0;
}


INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR sStr, int nCmd)
{

	records.push_back(Workers(L"Name33", L"Surname3", L"15 000", L"HR managment"));
	records.push_back(Workers(L"Name41", L"Surname4", L"3 000", L"worker"));
	records.push_back(Workers(L"Name15", L"Surname1", L"10 000", L"developer"));
	records.push_back(Workers(L"Name21", L"Surname2", L"11 000", L"worker"));

	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);

	return 0;
}