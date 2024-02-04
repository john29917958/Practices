#include "equipment_visitor.h"

void get_loading_visitor::visit_equipment(std::shared_ptr<equipment> equipment)
{
	loading_ += equipment->get_loading();
}

void get_loading_visitor::visit_weapon(std::shared_ptr<weapon> weapon)
{
	visit_equipment(weapon);
}

void get_loading_visitor::visit_armor(std::shared_ptr<armor> armor)
{
	visit_equipment(armor);
}

int get_loading_visitor::get_loading()
{
	return loading_;
}
