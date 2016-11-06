#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Furnite
{
public:
	virtual void Show() = 0;
};


class Table: public Furnite
{
public:
	Table(int a, int h, int l = 4) :area(a),high(h),leg(l){};
	void Show() 
	{ 
		cout << "Table: area =" 
			<< area << ", high = " 
			<< high << ", legs =" 
			<< leg << endl; 
	}

private:
	int leg;
	int area;
	int high;

};

class Chair : public Furnite
{
public:
	Chair(int a, int h, int l = 4) :area(a), high(h), leg(l) {};
	void Show()
	{
		cout << "Chair: area ="
			<< area << ", high = "
			<< high << ", legs ="
			<< leg << endl;
	}

private:
	int leg;
	int area;
	int high;

};

class Computer: public Furnite
{
public:
	Computer(string n, string p) :name(n), processor(p) {};
	void Show()
	{
		cout << "Chair: name ="
			<< name << ", processor = "
			<< processor << endl;
	}

private:
	string name;
	string processor;

};

enum class ePart { Table, Chair, Computer};

class WorkPlace
{
	vector<Furnite*> furnites;
public:
	WorkPlace()	{}

	Furnite* GetFlyweight(ePart part, int a = 0, int h = 0, int l = 4, string name = "default", string proccesor = "default")
	{
		switch (part)
		{
		case ePart::Table:
			for (int i = 0; i<furnites.size(); ++i)
			{
				Table* table = dynamic_cast<Table*>(furnites[i]);
				if (table != nullptr)
				{
					return furnites[i];
				}
			}
			furnites.push_back(new Table(a, h, l));
			break;
		case ePart::Chair:
			for (int i = 0; i<furnites.size(); ++i)
			{
				Chair* chair = dynamic_cast<Chair*>(furnites[i]);
				if (chair != nullptr)
				{
					return furnites[i];
				}
			}
			furnites.push_back(new Chair(a, h, l));

			break;
		case ePart::Computer:
			for (int i = 0; i<furnites.size(); ++i)
			{
				Computer* copmuter = dynamic_cast<Computer*>(furnites[i]);
				if (copmuter != nullptr)
				{
					return furnites[i];
				}
			}
			furnites.push_back(new Computer(name, proccesor));

			break;
		}

		return furnites[furnites.size()-1];
	}


	~WorkPlace()
	{
		for (int i = 0; i<furnites.size(); ++i)
		{
			delete furnites[i];
		}
	}
};


int main()
{
	int counter = 5;


	WorkPlace * w = new WorkPlace();

	for (int i = 0; i < counter; i++)
	{
		Table* Table1 = (Table*)w->GetFlyweight(ePart::Table, 25, 30, 4);
		Chair* Chair1 = (Chair*)w->GetFlyweight(ePart::Chair, 100, 50, 1);
		Computer* Computer1 = (Computer*)w->GetFlyweight(ePart::Computer, 0, 0, 0, "Lenovo", "Core i5");
		cout << "-----------------------" << endl;
		Table1->Show();
		Chair1->Show();
		Computer1->Show();
	}


	delete w;
	system("pause");
	return 0;
}