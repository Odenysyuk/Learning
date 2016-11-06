#include<Windows.h>
#include<iostream>

using namespace std;

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR nCmd, int nShow) {

	static UINT answer = IDNO;
	static int ans, begin = 0, end = 15;
	static bool quit = false;

	do
	{
		ans = rand() % (end) + begin;
		wchar_t buffer[3];
		wsprintfW(buffer, L"Your number is that %d ?", ans);
		answer = MessageBox(NULL, buffer, L"Game", MB_YESNOCANCEL);

		switch (answer)
		{
		case IDNO:
		{
			wsprintfW(buffer, L"Your number is less than %d ?", ans);
			UINT temp = MessageBox(NULL, buffer, L"Game", MB_YESNO);
			if (temp == IDYES) {
				end = ans;
			}
				
		}
			break;
		case IDCANCEL:
		{
			wsprintfW(buffer, L"Your number is more than %d ?", ans);
			UINT temp = MessageBox(NULL, buffer, L"Game", MB_YESNO);
			if (temp == IDYES)
			{
				end = 15 - ans;
				begin = ans;				
			}
		}
			break;

		case IDYES:
			quit = true;
			break;
		}


	} while (!quit);




	return 0;
}
