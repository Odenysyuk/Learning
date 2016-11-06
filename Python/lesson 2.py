print('a', 5)

def first_func():
    print('''It's first function''')

def func_with_param(a = 5, b = 15):
    print('{0} + {1} = {2}'.format(a, b, a+b))

def print_list(*numbers):
    for ell in numbers:
        print('el', ell)
    print('end')

first_func()
func_with_param()
func_with_param(10, 15)
print_list(2, 5, 10, 6)


import Module
Module.say_hi()

from Module import  say_hi
say_hi()
