#include <iostream>
#include <string>
#include <vector>


using namespace std;

class Words
{
private:
	string question;
	string answer;
public:
	Words(string q, string a) :question(q), answer(a) {}
	bool FindAnswer(string msg, string &ans) {

		if (question.find(msg) != string::npos)
		{
			ans = answer;
			return true;
		}


		return false;
	}
};


class Vocabulary
{
public:
	static vector<Words*> vocabulary;
	static void initializetion() {

		Vocabulary::vocabulary.push_back(new Words("Hi|Hello|Good day|Good morning|Good evining","Hello, I am Bot"));
		Vocabulary::vocabulary.push_back(new Words("How are you| HOW ARE U", "I am good, thanks, and you?"));
		Vocabulary::vocabulary.push_back(new Words("Good bye|bye|", "Good bye. Nice to meet you!"));
		Vocabulary::vocabulary.push_back(new Words("Bot", "Bot is cool"));
		Vocabulary::vocabulary.push_back(new Words("bad day", "Don't sad. Everything will be fine"));
		Vocabulary::vocabulary.push_back(new Words("beautiful day", "I happy. Everything will be fine"));
		Vocabulary::vocabulary.push_back(new Words("what weather today?", "The weather is great, today!"));
		Vocabulary::vocabulary.push_back(new Words("who are you?", "I am superman!"));
		Vocabulary::vocabulary.push_back(new Words("how are you doing at work?", "Nothing Else Matters !"));

	}
};


class Mediator;

class User
{
protected:
	Mediator* mediator;
public:
	virtual void SetMediator(Mediator* m)
	{
		mediator = m;
	}
	virtual void Get(string msg) = 0;
};

class Mediator
{
private:
	User* a;
	User *b;
public:
	Mediator(User *abonent, User *bot):a(abonent),b(bot){}
	void SendMsg(string msg, User* abonent);
	
};
	

class Bot : public User
{
public:
	Bot(){	}

	void Send(string msg)
	{
		mediator->SendMsg(msg, this);
	}

	virtual void Get(string msg) override
	{
		bool getanswer = false;
		string answer;

		for (int i = 0; i < Vocabulary::vocabulary.size(); ++i) 
		{
			getanswer = Vocabulary::vocabulary[i]->FindAnswer(msg, answer);
			if (getanswer == true)
			{
				cout << "Bot got: " << answer << endl;
				getanswer = false;
			}
		}

		if (answer.empty() == true)
		{
			cout << "Bot got: I am don't understand you! Sorry! ((((" << endl;
		}

		
	}
};

class Abonent : public User
{
public:
	Abonent()	{	}

	void Send(string msg)
	{
		mediator->SendMsg(msg, this);
	}
	virtual void Get(string msg) override
	{
		cout << "Abonent got: " << msg << endl;
	}
};


void Mediator::SendMsg(string msg, User* abonent)
{
	if (dynamic_cast<Bot*>(abonent) != nullptr)
	{
		b->Get(msg);
	}
	else
	{
		a->Get(msg);
	}
}

 vector<Words*> Vocabulary::vocabulary;

int main()

{

	Vocabulary::initializetion();

	Abonent *a = new Abonent;
	Bot *b = new Bot;
	Mediator *m = new Mediator(a, b);
	a->SetMediator(m);
	b->SetMediator(m);

	a->Send("Hello");
	b->Send("Hello");
	a->Send("How are you?");
	b->Send("How are you?");


	delete a;
	delete b;
	delete m;

	system("pause");
	return 0;
}