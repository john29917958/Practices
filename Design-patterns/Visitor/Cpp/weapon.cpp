#include <iostream>
#include "equipment.h"
#include "equipment_visitor.h"

weapon::weapon(std::string name, int loading) : equipment(name, loading)
{

}

void weapon::run_visitor(std::shared_ptr<equipment_visitor> visitor)
{
	visitor->visit_weapon(std::shared_ptr<weapon>(std::shared_ptr<weapon>(), this));
}

void weapon::attack()
{
	std::cout << "Weapon " + name_ + " attacks." << std::endl;
}