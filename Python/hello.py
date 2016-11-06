print("first row")
print('second row')
str = '''1 row
2 row'''
print(str)
print(2)
print(2.59E5)
print('0:.3f', 1.0/3)
print('{0:_^11}'.format("hello"))
print('{name}'.format(name = "hello"))
print('a', end=' ')
print('a', end=' ')

print("what's your name?")
print('\twhat\'s your name? \n My name\' Jack')
print(r"what\'s your name? \n My name\' Jack")
print(R"what\'s your name? \n My name\' Jack")
var = 3 + 5
print(var)

if var == 8 and var%3 == 2:
    print('var == 8')
    print('var %3 = 2')
elif var == 0:
    print('0')
else:
    print('Something')


for i in range(1,5):
    print(i)
else:
    print('it is over')