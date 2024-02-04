#include "singleton.h"

#include <iostream>

singleton::singleton()
{
	data_ = new int(10);
}

/*
The declaration of a static data member in its class definition is not a definition and may be of an incomplete type other than cv-qualified void.
The definition for a static data member shall appear in a namespace scope enclosing the member’s class definition.
Link: https://www.ibm.com/docs/en/zos/2.1.0?topic=members-static-data
 */
singleton* singleton::instance_ = nullptr;

void singleton::operation()
{
	std::cout << "Singleton" << std::endl;
}

void* singleton::get_data() const
{
	return data_;
}

singleton* singleton::get_instance()
{
	if (instance_ == nullptr)
	{
		instance_ = new singleton();
	}

	return instance_;
}
