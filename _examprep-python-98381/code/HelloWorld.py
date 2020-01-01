print("Hello World")
# Python has 5 Data Types Categories
# =====================================
# Numeric Types
# =====================================
# int, float, long, complex
myInt = 618
print(myInt)

myFloat = 1.618
print(myFloat)

myLong = 9999999999999
print(myLong)

myComplex = 9
print(myComplex)

# =====================================
# String
# =====================================
str = "How are you?\n"
print(str)
print(str[0:3])
print(str * 4)

# =====================================
# List
# =====================================
list = ['Hello World', 150, 1.25, "My name is Ray", 100.25]
tinyList = [300, 'Ray']

print(list)
print(tinyList * 2)

# =====================================
# Tuple (are a readonly list)
# =====================================
myTuple = ('Hello Ray', 185, 3.14, 'Hi again', 150.23)
print(myTuple)
print(myTuple[0])

# =====================================
# Dictionary
# =====================================
dictionary = {}
dictionary['one'] = "1st element"
dictionary[2] = "2st element"

tiny_dictionary = {'name' : 'Ray', 'age': '33', 'id': 23456, 'job': 'mct'}

print(dictionary['one'])
print(dictionary[2])
print(tiny_dictionary)
print(tiny_dictionary.keys())
print(tiny_dictionary.values())


# =====================================
# DataType Conversion
# =====================================
print(int('20'))
print(int("20"))
print(float('20'))

# =====================================
# Conditional Statements
# =====================================
myInt = 5000

if(myInt == 1000):
    print("is 1K")
elif(myInt == 5000):
    print("is 5K")
else:
    print("not equal...")

# =====================================
# Iterations
# =====================================
i = 0
while(i < 5):
    if(i % 2 == 0):
        # print only event numbers (using modulus operator)
        print('even number is: ', i)
    i=i+1

names = ['one', 'two', 'three', 'four']
for name in names: 
    print(name)

for i in range(0, 5):
    print("value: ", i)

for i in range(0, names.__len__()):
    print(names[i])

# =====================================
# Arrays
# =====================================


# =====================================
# Functions
# =====================================
def SayHello(name, age):
    print('Hi', name, 'are you really', age, '?')
    return age + 10

value = SayHello('Ray', 25)
print(value)

# =====================================
# File Input/Output Modes
# r = reading
# w = writing, create if not found
# a = append
# r+ = both reading & writing
# w+ = both reading & writing, but wipes file if found
# a+ = both reading & writing, but creates if not found
# =====================================


# =====================================
# Writing Data
# =====================================
f = open("myFile.txt", "w")
print("File Name:", f.name)
print("It is ", f.closed)
print("It is ", f.mode)
f.write("Hello from Python")
f.close()

# =====================================
# Reading Data
# =====================================
f = open("myFile.txt", "r")
fileContents = f.read()
print(fileContents)
f.close()

# =====================================
# Pass By Ref
# =====================================
def changeIt(aList):
    aList.append([1, 5, 10, 15])
    print("Values inside the function: ", aList)
    print(id(aList))
    return

myList = [10, 20, 30]
changeIt(myList)
print("Values outside are now", myList)
print(id(myList))


def PassByRefTest(num1):
    num1 = num1 + 1;
    print("value within function is", num1)
    print(id(num1))
    return

myNum = 5
PassByRefTest(myNum)
print(myNum)
print(id(myNum))




