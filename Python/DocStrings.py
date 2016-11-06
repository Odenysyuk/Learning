def MaxOfTwoNumbers(a, b):
    ''' Return maximum numbers
    
        if they are equals - return one another'''
    if a > b:
        return a
    else:
        return b

print(MaxOfTwoNumbers(1, 10))
print(MaxOfTwoNumbers.__doc__)