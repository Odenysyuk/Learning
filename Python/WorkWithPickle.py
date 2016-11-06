import pickle

nameFile = 'object.data'

listOfFruit = ['apple', 'orange', 'lemon', 'pear'];
listOfVegatable = ['onian', 'tomato', 'carrot', 'cucumber'];
f = open(nameFile, 'wb')
pickle.dump(listOfFruit, f)
pickle.dump(listOfVegatable, f)
f.close()

f = open(nameFile, 'rb')
print(pickle.load(f))
print(pickle.load(f))
f.close()

