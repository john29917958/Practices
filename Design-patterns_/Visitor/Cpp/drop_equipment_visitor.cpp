#include "equipment_visitor.h"
#include <iostream>
#include "game_system.h"

drop_equipment_visitor::drop_equipment_visitor(std::shared_ptr<equipment> equipment, std::shared_ptr<backpack> backpack)
{
	equipment_ = equipment;
	backpack_ = backpack;
}

void drop_equipment_visitor::visit_equipment(std::shared_ptr<equipment> equipment)
{
	if (equipment == equipment_)
	{
		std::cout << "Drops equipment \"" + equipment->get_name() + "\"." << std::endl;
		backpack_->remove(equipment);
		game_system::instantiate(equipment.get());
	}
}

void drop_equipment_visitor::visit_weapon(std::shared_ptr<weapon> weapon)
{
	if (weapon == equipment_)
	{
		std::cout << "Drops weapon \"" + weapon->get_name() + "\". Creates slash effect." << std::endl;
		backpack_->remove(weapon);
		game_system::instantiate(weapon.get());
	}
}

void drop_equipment_visitor::visit_armor(std::shared_ptr<armor> armor)
{
	if (armor == equipment_)
	{
		std::cout << "Drops equipment \"" + armor->get_name() + "\". Creates flash effect." << std::endl;
		backpack_->remove(armor);
		game_system::instantiate(armor.get());
	}
}
