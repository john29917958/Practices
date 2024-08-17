#include <iostream>
#include <string>

using namespace std;

class animal
{
public:
    animal(const animal &other)
    {
        this->name = other.name;
        cout << "Copy constructor (const version) of animal " << other.name << " is called!" << endl;
    }

    animal(animal &other)
    {
        this->name = other.name;
        cout << "Copy constructor of animal \"" << other.name << "\" is called!" << endl;
    }

    animal(animal &&other)
    {
        this->name = other.name;
        cout << "Move constructor of animal \"" << other.name << "\" is called!" << endl;
    }

    animal(const animal &&other)
    {
        this->name = other.name;
        cout << "Move constructor (const version) of animal \"" << other.name << "\" is called!" << endl;
    }

    animal(string name)
    {
        cout << "Constructor of animal is called to instantiate a cat named \"" << name << '"' << endl;
        this->name = name;
    }

    ~animal()
    {
        cout << "Destructor of " + this->name + " is called!" << endl;
    }

    string name;
};

/**
 * @brief Changes name of an animal.
 * Copy constructor is called while entering the function.
 * Move constructor is called before exiting the function.
 * Destructor is then called after function exits.
 */
animal change_name(animal a, string new_name)
{
    a.name = new_name;
    cout << "Address of animal \"" << a.name << "\" in change_name() function is: " << &a << endl;
    return a;
}

/**
 * @brief Changes name of an animal.
 * Copy constructor is called right before function exits.
 */
animal change_name_by_ref(animal &a, string new_name)
{
    a.name = new_name;
    cout << "Address of animal \"" << a.name << "\" in change_name_by_ref() function is: " << &a << endl;
    return a;
}

animal get_animal(string name)
{
    animal a(name);
    cout << "Address of animal \"" << a.name << "\" in get_animal() function is: " << &a << endl;
    return a;
}

animal get_animal2(string name)
{
    return animal(name);
}

int main(int argc, char *argv[])
{
    animal cat("Cat");
    cout << "Address of animal \"" << cat.name << "\" in main.cpp is: " << &cat << endl;
    
    animal cute_cat = change_name(cat, "Cute Cat");
    cout << "Address of animal \"" << cute_cat.name << "\" in main.cpp is: " << &cute_cat << endl;

    animal happy_cat = change_name_by_ref(cat, "Happy Cat");
    cout << "Address of animal \"" << happy_cat.name << "\" in main.cpp is: " << &happy_cat << endl;

    /* cool_cat in main() and a in get_animal() occupy the same memory address space.
    This is called NRVO, named return value optimization. */
    animal cool_cat = get_animal("Cool Cat");
    cout << "Address of animal \"" << cool_cat.name << "\" in main.cpp is: " << &cool_cat << endl;

    /* The nameless temporary object in get_animal2() is moved or copied
    to destination memory address space where cat4 occupies.
    This is called RVO, return value optimization. */
    animal beautiful_cat = get_animal2("Beautiful Cat");
    cout << "Address of animal \"" << beautiful_cat.name << "\" in main.cpp is: " << &beautiful_cat << endl;

    return 0;
}
