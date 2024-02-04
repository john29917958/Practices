#include "equipment_visitor.h"
#include <iostream>

remove_broken_armor_visitor::remove_broken_armor_visitor(std::shared_ptr<backpack> backpack)
{
	backpack_ = backpack;
}

void remove_broken_armor_visitor::visit_armor(std::shared_ptr<armor> armor)
{
	if (armor->get_endurance() == 0)
	{
		std::cout << "Armor \"" + armor->get_name() + "\" is broken, remove it." << std::endl;
		backpack_->remove(armor);		
	}
}
