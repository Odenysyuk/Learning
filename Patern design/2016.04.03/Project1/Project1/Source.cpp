#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Component
{
public:
	virtual void Show(int spaces) = 0;
};


class ConcreteControl : public Component
{
	string name;

public:
	ConcreteControl(string name)
	{
		this->name = name;

	}

	virtual void Show(int spaces = 0) override
	{
		for (int i = 0; i<spaces; ++i)
		{
			cout << "\t";
		}
		cout << name << endl;
	}

};

class Composite : public Component
{
	vector<Component*> list_file;
	string name;


public:
	Composite()	{}
	Composite(string name)
	{
		this->name = name;
	}
	void add(Component *c)
	{
		list_file.push_back(c);
	}

	virtual void Show(int spaces = 0) override
	{
		for (int i = 0; i<spaces; ++i)
		{
			cout << "\t";
		}
		cout << name << endl;
		for (int i = 0; i < list_file.size(); ++i)
		{
			list_file[i]->Show(spaces + 1);
		}
	}
};


class Decorator : public Component
{
	Component* c;
public:
	Decorator(Component *c)
	{
		this->c = c;
	}
	virtual void Show(int spaces = 0) override
	{
		c->Show(spaces);
	}
};

class EndlTextDecorator : public Decorator
{
public:
	EndlTextDecorator(Component *c) :Decorator(c)
	{}
	virtual void Show(int spaces = 0) override
	{
		Decorator::Show(spaces);
		cout << endl;
	}
};

class TabbedTextDecorator : public Decorator
{
public:
	TabbedTextDecorator(Component *c) :Decorator(c)
	{}
	virtual void Show(int spaces = 0) override
	{
		cout << "********\t";
		Decorator::Show(spaces);
	}
};


int main()
{   

	
	ConcreteControl *eleveth = new ConcreteControl("eleveth");
	ConcreteControl *twelth = new ConcreteControl("twelth");
	Composite *first = new Composite("first");
	first->add(eleveth);
	first->add(twelth);

	
	ConcreteControl *twenty_second = new ConcreteControl("twenty_second");
	Composite *second = new Composite("second");
	second->add(twenty_second);


	ConcreteControl *third = new ConcreteControl("third");
	
	Composite *Main = new Composite("Main");
	Main->add(first);
	Main->add(second);
	Main->add(third);


	Main->Show();
	
	Component *newlist = new TabbedTextDecorator(new TabbedTextDecorator(Main));
	newlist->Show(0);
	
	system("pause");

	return 0;
}