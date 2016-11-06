class Academy:
    def __init__(self):
        self.AllPerson = []

    def show_all(self):
        for item in Academy.AllPerson:
            item.ShowData()

    def add_person(self, person):
        self.AllPerson.append(person)


class Person(Academy):
    def __init__(self, name):
        self.Name = name;

    def ShowData(self):
        print('Person name: {0}'.format(self.Name))

class Student(Person):
    def __init__(self, name, education):
        Person.__init__(self, name);
        self.Education = education;
    def ShowData(self):
        print('Name: {0}, education: {1}'.format(self.Name, self.Education));

class Worker(Person):
    def __init__(self, name, workPlace):
        Person.__init__(self, name);
        self.WorkPlace = workPlace;
    def ShowData(self):
        print('Name: {0}, work place: {1}'.format(self.Name, self.WorkPlace));

BigAcademy = Academy();
Student1 = Student("Tim", "IT");
BigAcademy.add_person(Student1)

Student2 = Student("Jon", "HR");
BigAcademy.add_person(Student2)

Worker1 = Worker('Jim', 'Hight')
Academy.add_person(Worker1)

Academy.AllPerson()







