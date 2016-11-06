#include<iostream>
#include <Windows.h>

using namespace std;

class InfoImplementator;
class ConsoleInfo;
class ColourInfo;

class Unit
{

protected:
	int healthy;
	int damage;

public:
	Unit() {}

	Unit(int h, int d) {
		healthy = h;
		damage = d;
	}

	Unit(const Unit &obj) {}; 
	virtual void Show()= 0;
};

class Marine : public Unit
{

public:
	Marine(int h, int d) :Unit(h, d) {}

	Marine(const Marine &obj) {
		cout << "Copy" << endl;
		healthy = obj.healthy;
		damage = obj.damage;
	}

	void Show() { cout << "Healty = " << healthy << " Damage = " << damage << endl; };
};

class CrazyScientist : public Unit
{

public:
	CrazyScientist(int h, int d) :Unit(h, d) {}

	CrazyScientist(const CrazyScientist &obj) {
		cout << "Copy" << endl;
		healthy = obj.healthy;
		damage = obj.damage;
	}

	void Show() { cout << "Healty = " << healthy << " Damage = " << damage << endl; };
};


class MilitaryDoctor : public Unit
{

public:
	MilitaryDoctor(int h, int d) :Unit(h, d) {}

	MilitaryDoctor(const MilitaryDoctor &obj) {
		cout << "Copy" << endl;
		healthy = obj.healthy;
		damage = obj.damage;
	}
	virtual void Show()
	{
		cout << "Healty = " << healthy << " Damage = " << damage << endl;
	};
};


class Barrack
{
public:
	int healty;
	int damage;
	Unit *obj;
	InfoImplementator *imp;

	virtual Unit *CreateBarrack() = 0;

	Barrack() {}
	Barrack(int h, int d) {
		healty = h;
		damage = d;

	};

	void setInfoImplementator(InfoImplementator *imp) { this->imp = imp; }

	Barrack(const Barrack &obj) {}


	void ShowNew() {
		imp->Show();
	}

	void Show_Old() {
		obj = CreateBarrack();
		obj->Show();
	}

};


class MilitaryBarrack : public Barrack
{
public:
	MilitaryBarrack(int h, int d) : Barrack(h, d) {}
	virtual Unit *CreateBarrack() override {

		return new Marine(healty, damage);
	}

	MilitaryBarrack(const MilitaryBarrack &obj) {
		cout << "Copy" << endl;
		healty = obj.healty;
		damage = obj.damage;
	}
};

class ScientificyBarrack : public Barrack
{
public:
	ScientificyBarrack(int h, int d) : Barrack(h, d) {}
	virtual Unit *CreateBarrack() override {

		return new CrazyScientist(healty, damage);
	}

	ScientificyBarrack(const ScientificyBarrack &obj) {
		cout << "Copy" << endl;
		healty = obj.healty;
		damage = obj.damage;
	}
};

class MedicalBarrack : public Barrack
{
public:
	MedicalBarrack(int h, int d): Barrack(h, d) {}
	virtual Unit *CreateBarrack() override {

		return new MilitaryDoctor(healty, damage);
	}

	MedicalBarrack(const MedicalBarrack &obj) {
		cout << "Copy" << endl;
		healty = obj.healty;
		damage = obj.damage;
	}
};


class InfoImplementator
{
protected:
	Barrack *obj;
public:
	InfoImplementator(Barrack *o) :obj(o) {}
	virtual void Show() = 0;
};



class ConsoleInfo : public InfoImplementator
{
public:
	ConsoleInfo(Barrack *o) :InfoImplementator(o)
	{

	}
	virtual void Show()
	{
		obj->ShowNew();
	}
};

class ColourInfo : public InfoImplementator
{
public:
	ColourInfo(Barrack *o) :InfoImplementator(o)
	{

	}
	virtual void Show()
	{
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10);
		obj->ShowNew();
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7);
	}
};



int main() {



	Barrack *Obj;
	Obj = new MilitaryBarrack(100, 10);
	Obj->setInfoImplementator(new ConsoleInfo(Obj));
	Obj->ShowNew();


	Barrack *Obj1;
	Obj = new ScientificyBarrack(100, 50);
	Obj->setInfoImplementator(new ConsoleInfo(Obj));
	Obj->ShowNew();


	Obj1 = Obj;
	Obj1->ShowNew();

	system("pause");
	return 0;

}