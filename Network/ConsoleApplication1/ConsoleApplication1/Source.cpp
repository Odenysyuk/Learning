#include<iostream>
#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <ctype.h>  

using namespace std;

int arr[10];
int sum(int, int = 10);
int main()
{
	//cout << sizeof(arr);

	cout<< sum(10);
	return 0;
}

int sum(int a, int b) {

	return a + b;
}
