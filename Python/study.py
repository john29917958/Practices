from enum import Flag, auto
from struct import *
from typing import Final
import threading
import time

# Primitive types

print("=========== Primitive types ===========")

# Type: int
var = 10
var_type = type(var)
print(var)
print(var_type)


# Type: str
var = '123'
var_type = type(var)
print(var)
print('String length is: ' + str(len(var)))
print(var_type)

multi_line_str = f"""sdfds
sdfds
sdfdsdfs
    sdfsdffds
sdfsdf"""
print(multi_line_str)

# Type: float
var = 0.1
var_type = type(var)
print(var)
print(var_type)

# Type: list
var = [1, 2, 3, 4, 5]
var_type = type(var)
print(f"Var ({var_type}) is: {var}, length is {len(var)}")

# Type: dict
var = {
    "title1": "python",
    "title2": "is",
    "title3": "awesome!"
}
var_type = type(var)
print(f"Var ({var_type}) is: {var}, length is {len(var)}")

# Type: enum (Python 3.8)
class Colors(Flag):
    RED = auto()
    GREEN = auto()
    BLUE = auto()

print(Colors)
print(Colors.RED)
var = Colors.GREEN
print(var == Colors.RED)
print(var == Colors.GREEN)

# Type: tuple
var = ('This', 'is', 'a', 'tuple')
var_type = type(var)
print(var_type)
print(var)

# Type: struct
var = pack('hhl', 1, 3, 2)
var_type = type(var)
print(var_type)
print(var)

# Type: type
var = type(var_type)
print(f"Type of type(operand) is: {var}")

var = 10
var_type = type(var)
print(var is int)
print(type(var) is int)
print(var_type is int)

# Type: list
var = [1, 2, 3, 4, 5]
print(var)

var.append(6)
print(var)

print(var.count(1))
print(var.index(1))
print(var.pop())
print(var)
var.insert(2, 99)
print(var)

var.remove(99)
print(var)
var.reverse()
print(var)
var.sort()
print(var)
var.extend([10, 11, 12])
print(var)
var.clear()
print(var)

var = [1, 3, 5]
for elem in var:
    print(elem)

# Type: dict
var = {
    "title1": "python",
    "title2": "is",
    "title3": "awesome!"
}

print(var['title1'])
print(var.get('title1'))
for key in var.keys():
    print(key)
var["title2"] = 'is definitely'
for val in var.values():
    print(val)
for (key, value) in var.items():
    print(f"\"{key}\": \"{value}\"")
print(type(range(1, len(var))))

# Constant

A_CONSTANT_VAL: Final[int] = 10
print(A_CONSTANT_VAL)

<<<<<<<< HEAD:language-syntax/study.py
# A_CONSTANT_VAL = 100 => Compile error
# print(A_CONSTANT_VAL)
========
A_CONSTANT_VAL = 100
print(A_CONSTANT_VAL)
>>>>>>>> f2dedf2 (Rename python script file):study.py

# Comments
# Python ignore string literals not assigned to any variable.
# So multiline comment can be used like following:
"""
sdfdsf
sdfdsf
"""

# While loop
var = 10
while var > 0:
    print(var)
    var -= 1

# For loop
print('=========== For loop ===========')
for i in range(3, 5):
    print(i)

# Try except
print('=========== Try catch ===========')
try:
    print(no_such_var)
except NameError as e:
    print(e)
except Exception as e:
    print(e)
else:
    print('No error')
finally:
    print('Finally')    

# Function
def func(var):
    var["prop1"] += 10
var = {
    "prop1": 0,
    "prop2": 1
}

print(var)
func(var)
print(var)

# Functions in Python can be assigned to variable just like JavaScript and C++ function pointer
func_pointer = func
func_pointer(var)

# Closure concept in JavaScript also exists in Python
print('=========== Closure ===========')

def func_outside():    
    num = None

    def func_inside():
        num = 10
        print(num)

    print(num)
    func_inside()
    print(num)

func_outside()

# Class

print('=========== Class ===========')

class Animal:
    """
    Represents an animal.
    """
    def __init__(self, name, size):
        """
        Creates an Apple instance.
        """
        self.__name = name
        self.__size = size
        
    def get_name(cls):
        """
        Gets the name of animal.
        """
        return cls.__name
    
    def set_name(cls, name):
        """
        Sets the name of animal.
        """
        cls.__name = name
    
    def get_size(cls):
        """
        Gets the size of animal
        """
        return cls.__size
    
    def set_size(cls, size):
        """
        Sets the size of animal
        """
        cls.__size = size
    
    def __str__(cls):
        """
        Gets the string that represents the current animal.
        """
        return f"Size of {cls.__name} is {cls.__size}"

class Human(Animal):
    """
    Represents a human.
    """
    def __init__(self, first_name, last_name, size):
        """
        Creates a human instance.
        """
        super().__init__(first_name, size)
        self.__last_name = last_name

    def __compose_description(cls):
        return f"Size of {cls.get_name()}, {cls.__last_name} is {cls.get_size()}"

    def __str__(cls):
        """
        Gets the string that represents the current human.
        """
        return cls.__compose_description()

animal = Animal('Lucky', 10)
print(animal)
animal = Human('Henry', "Link", 100)
print(animal)

try:
    animal.__compose_description()
except AttributeError as e:
    print("Unable to invoke private member - " + str(e))
    print(dir(animal))
else:
    print("This line of code should never be executed...")

class Struct:
    pass

s = Struct()
print(type((s)))

s.a = 10
s.b = 100
s.c = 1.0

print(type((s)))
print(s.a)

class Iteratable:
    def __init__(self, *args):
        self.data = []        

        for arg in args:
            self.data.append(arg)
        self.pointer = len(self.data)

    def __iter__(cls):
        return cls
        
    def __next__(cls):
        if cls.pointer == 0:
            raise StopIteration
        
        cls.pointer -= 1
        return cls.data[cls.pointer]

iteratable = Iteratable(1, 2, 3, 4, 5)

for num in iteratable:
    print(num)

def print_after(message, seconds):
    time.sleep(seconds)
    print(message)

<<<<<<<< HEAD:language-syntax/study.py
# deamon=true set it as a background thread and the thread is forced to end once main thread exits.
========
>>>>>>>> f2dedf2 (Rename python script file):study.py
thd = threading.Thread(target=print_after, args=("First thread", 1), daemon=True)
thd2 = threading.Thread(target=print_after, args=("Second thread", 2), daemon=True)
thd3 = threading.Thread(target=print_after, args=("Third thread", 3), daemon=True)
thd.start()
thd2.start()
thd3.start()
thd3.join()
