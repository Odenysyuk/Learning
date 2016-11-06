#include <iostream>
#include <string>
#include <vector>
using namespace std;

enum class food { Ukrainian, Chinese, Italian };

class Cook
{
protected:
	Cook* NextCook;
	food FoodOfNatinality;
public:
	Cook(food f) { 
		FoodOfNatinality = f;
		NextCook = nullptr;
	};
	void SetSuccessor(Cook* Next)
	{
		NextCook = Next;
	}
	virtual void HandleRequest(food f) = 0;
};


class CookUkrainian: public Cook
{
public:
	CookUkrainian() :Cook(food::Ukrainian) {}
	void HandleRequest(food f) override
	{
		if (f == FoodOfNatinality)
			cout << "Cook give request! It is Ukrainian meal!! "<< endl;
		else if(NextCook != nullptr)
				NextCook->HandleRequest(f);
		else if (NextCook == nullptr)
			cout << "Not cook for giving request!!! " << endl;
	}

};

class CookChinese : public Cook
{
public:
	CookChinese() :Cook(food::Chinese) {}
	void HandleRequest(food f) override
	{
		if (f == FoodOfNatinality)
			cout << "Cook give request! It is Chinese meal!! " << endl;
		else if (NextCook != nullptr)
			NextCook->HandleRequest(f);
		else if(NextCook == nullptr)
			cout << "Not cook for giving request!!! " << endl;

	}
};


class CookItalian : public Cook
{
public:
	CookItalian() :Cook(food::Italian) {}
	void HandleRequest(food f) override
	{
		if (f == FoodOfNatinality)
			cout << "Cook give request! It is Italian meal!! " << endl;
		else if (NextCook != nullptr)
			NextCook->HandleRequest(f);
		else if (NextCook == nullptr)
			cout << "Not cook for giving request!!! " << endl;

	}
};

int main()
{
	CookItalian *CI = new CookItalian();
	CookChinese *CC = new CookChinese();
	CookUkrainian *CU = new CookUkrainian();

	CI->SetSuccessor(CC);
	CC->SetSuccessor(CU);


	food clients[] = { food::Chinese,  food::Ukrainian,  food::Italian };
	for (int i = 0; i<3; ++i)
		CI->HandleRequest(clients[i]);



	delete CI;
	delete CC;
	delete CU;
	system("pause");
	return 0;
}