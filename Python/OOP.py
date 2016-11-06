class Person:
    def __init__(self, name):
        self.name = name

    def printname(self):
        print(self.name)

class Worker(Person):
    def __init__(self, name, age):
        Person.__init__(self, name)
        self.age = age;

    def printname(self):
        print(self.name, self.age)





p = Worker("Jim", 15)
p.printname()

