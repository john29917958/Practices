// Singleton.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

#include "singleton.h"

int main()
{
    singleton* s = singleton::get_instance();
	s->operation();
	s = singleton::get_instance();
	std::cout << s->get_data() << std::endl;
}
