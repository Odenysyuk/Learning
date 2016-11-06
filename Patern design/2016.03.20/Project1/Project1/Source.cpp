#include<iostream>
using namespace std;

class Unit
{

protected:
	int healthy;
	int damage;

public:
	Unit(int h, int d) {
		healthy = h;
		damage = d;
	}

	virtual void Show() = 0;
};

class Marine : public Unit
{

public:
	Marine(int h, int d) :Unit(h, d) {}

	void Show() { cout << "Healty = " << healthy << " Damage = " << damage << endl; };
};

class CrazyScientist : public Unit
{

public:
	CrazyScientist(int h, int d) :Unit(h, d) {}

	void Show() { cout << "Healty = " << healthy << " Damage = " << damage << endl; };
};


class MilitaryDoctor : public Unit
{

public:
	MilitaryDoctor(int h, int d) :Unit(h, d) {}

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

	virtual Unit *CreateBarrack() = 0;

	Barrack(int h, int d) {
		healty = h;
		damage = d;

	};
	void Show() {
		Unit *obj;
		obj = CreateBarrack();
		obj->Show();
		delete obj;
	}

};


class MilitaryBarrack : public Barrack
{
public:
	MilitaryBarrack(int h, int d) : Barrack(h, d) {}
	virtual Unit *CreateBarrack() override {

		return new Marine(healty, damage);
	}
};

class ScientificyBarrack : public Barrack
{
public:
	ScientificyBarrack(int h, int d) : Barrack(h, d) {}
	virtual Unit *CreateBarrack() override {

		return new CrazyScientist(healty, damage);
	}
};

class MedicalBarrack : public Barrack
{
public:
	MedicalBarrack(int h, int d) : Barrack(h, d) {}
	virtual Unit *CreateBarrack() override {

		return new MilitaryDoctor(healty, damage);
	}
};



int main() {

	Barrack *Obj;
	Obj = new MilitaryBarrack(100, 10);
	Obj->Show();

	Obj = new ScientificyBarrack(300, 9);
	Obj->Show();

	Obj = new MedicalBarrack(456, 12);
	Obj->Show();

	system("pause");
	return 0;

}