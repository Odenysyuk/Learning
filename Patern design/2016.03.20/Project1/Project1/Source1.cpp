#include<iostream>
#include<string>

using namespace std;

class LoginForm
{

	string login;
	string password;
	static LoginForm *obj;
	LoginForm() {};
	LoginForm(const LoginForm &obj) {};
	void operator=(LoginForm &obj) {};
	~LoginForm() { if (obj != nullptr) delete obj; };

public:
	bool MakeLogin() {
		string temp;
		cout << "Enter login" << endl;
		cin >> temp;
		if (obj->login != temp) return false;

		cout << "Enter password" << endl;
		cin >> temp;
		if (obj->password != temp) return false;

		return true;
	}

	void Show() {
		cout << "Login:" << login << "; Password:" << password;
	}

	static LoginForm *AddLogin() {
		 if (obj != nullptr) {
			 cout << "" <<endl;
			 return obj; 
		 }
		 LoginForm::obj = new LoginForm;

		string temp;

		cout << "Enter login" << endl;
		cin >> temp;
		obj->login = temp;

		cout << "Enter password" << endl;
		cin >> temp;
		obj->password = temp;

		return obj;
	}

};

LoginForm *LoginForm::obj = nullptr;

int main() {

	LoginForm *log = LoginForm::AddLogin();
	log->Show();

	cout << "Lod in: \n";
	if (log->MakeLogin())
	{
		cout << "Login is succesesfull" << endl;
	}
	else
	{
		cout << "Unsuccesfull" << endl;
	}

	system("pause");
	return 0;
}