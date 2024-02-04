#include "equipment_visitor.h"

equipment_visitor::~equipment_visitor() = default;

void equipment_visitor::visit_equipment(std::shared_ptr<equipment> equipment)
{

}

void equipment_visitor::visit_weapon(std::shared_ptr<weapon> weapon)
{
	
}


void equipment_visitor::visit_armor(std::shared_ptr<armor> armor)
{
	
}
