
f = open('sometext.txt', 'w')

f.write('Hello \n')
f.write("My name's Helen! \n")
f.write("Bye bye")

if f.closed == False:
    f.close()


f = open('sometext.txt')

line = f.readline()
print(line)
line = f.readline()
print(line)
line = f.readline()
print(line)


line = f.readline()
print(line)
while len(line) != 0:
    print(line)
    f.readline()

if f.closed == False:
    f.close()
