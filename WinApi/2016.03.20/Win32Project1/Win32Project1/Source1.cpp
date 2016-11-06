#include <Windows.h>
#include <tchar.h>

LRESULT CALLBACK WndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	static int counter = 0;
	TCHAR buff[32];
	HDC hDC;
	PAINTSTRUCT ps;
	switch (uMsg)
	{
	
	case WM_LBUTTONDOWN:
		SetClassLong(hWnd, GCL_HBRBACKGROUND, (LONG)CreateSolidBrush(RGB(rand() % 255, rand() % 255, rand() % 255)));
		++counter;
		_itot_s(counter, buff, 10);
		MessageBox(NULL, buff , L"Counter", MB_OK);
		InvalidateRect(hWnd, NULL, true);
		break;

	case WM_RBUTTONDOWN:
		++counter;
		_itot_s(counter, buff, 10);
		MessageBox(NULL, buff, L"Counter", MB_OK);
		break;

	case WM_MBUTTONDOWN:
		
		++counter;
		_itot_s(counter, buff, 10);
		MessageBox(NULL, buff, L"Counter", MB_OK);
		break;

	case WM_CLOSE:
		DestroyWindow(hWnd);
		break;

	case WM_DESTROY:
		PostQuitMessage(0);
		break;

	default: return DefWindowProc(hWnd, uMsg, wParam, lParam);
	}
	return 0;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR nCmd, int nCmdShow)
{

	WNDCLASSEX wc;
	TCHAR className[] = _T("MyWindowClass");
	wc.cbSize = sizeof(wc);
	wc.style = CS_HREDRAW | CS_VREDRAW;
	wc.lpfnWndProc = WndProc;
	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hInstance = hInstance;
	wc.hIcon = LoadIcon(hInstance, IDI_APPLICATION);
	wc.hCursor = LoadCursor(hInstance, IDC_ARROW);
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wc.lpszMenuName = NULL;
	wc.lpszClassName = className;
	wc.hIconSm = LoadIcon(hInstance, IDI_APPLICATION);

	if (!RegisterClassEx(&wc))
	{
		MessageBox(NULL, _T("Can`t register class. Abort"), _T("Error"), MB_OK | MB_ICONERROR);
		return 0;
	}

	HWND hMainWnd = CreateWindowEx(WS_EX_CLIENTEDGE, className, _T("MyWindow"), WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, NULL, NULL, hInstance, NULL);

	if (!hMainWnd)
	{
		MessageBox(NULL, _T("Can`t create window. Abort"), _T("Error"), MB_OK | MB_ICONERROR);
		return 0;
	}

	ShowWindow(hMainWnd, SW_SHOW);

	MSG msg;

	while (GetMessage(&msg, NULL, 0, 0))
	{
		DispatchMessage(&msg);
	}

	return 0;
}