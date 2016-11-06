shoplist = [1,2,5,6]
print('Lenght of list is',len(shoplist))

def printlist():
    global shoplist
    for el in shoplist:
        print(el, end = ' ')
    print()

printlist()

shoplist.sort()
printlist()

shoplist.append(13)


del shoplist[0]
printlist()

shoplist.append(0)
printlist()

shoplist.clear()
printlist()

zoo = ( 'a', 'b', 'c')
print('Len tuple is ', len(zoo))
print('Count tuple is ', zoo.count(2))

#	'ab'	is	short	for	'a'ddress'b'ook
ab	=	{
    'Swaroop':	'swaroop@swaroopch.com',
    'Larry':	'larry@wall.org',
    'Matsumoto':	'matz@ruby-lang.org',
    'Spammer':	'spammer@hotmail.com'
}
print("Swaroop's	address	is",	ab['Swaroop'])

#	Deleting	a	key-value	pair del	ab['Spammer']
print('\nThere	are	{}	contacts	in	the	address-book\n'.format(len(ab)))

for	name,	address	in	ab.items():
    print('Contact	{}	at	{}'.format(name,	address))
#	Adding	a	key-value	pair ab['Guido']	=	'guido@python.org'
if	'Guido'	in	ab:
    print("\nGuido's	address	is",	ab['Guido'])

mydict = {'a': 1, 'b': 2, 'c' : 3}
print(mydict['a'] + mydict['b'])

for letter, number in mydict.items():
    print('Letters ', letter, ' is number ', number)



