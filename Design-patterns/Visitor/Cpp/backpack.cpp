#include "backpack.h"
#include "equipment_visitor.h"
#include <iostream>

backpack::backpack(int max_loading)
{
	max_loading_ = max_loading;
}

void backpack::add(std::shared_ptr<equipment> equipment)
{
	int equipment_loading = equipment->get_loading();
	int visitor_loading = get_loading();

	if (equipment->get_loading() + get_loading() > max_loading_)
	{
		std::cout << "Failed to add equipment " + equipment->get_name() + " (Run out of max loading)." << std::endl;
		return;
	}

	equipments_.push_back(equipment);
}

void backpack::remove(std::shared_ptr<equipment> equipment)
{
	auto iterator = std::find(equipments_.begin(), equipments_.end(), equipment);
	if (iterator != equipments_.end())
	{
		equipments_.erase(iterator);
	}
}

void backpack::run_visitor(std::shared_ptr<equipment_visitor> visitor)
{
	// Makes a copy of equipments to avoid out-of-range liked exception if visitor does remove element in equipments.
	std::vector<std::shared_ptr<equipment>> loop_equipments = equipments_;	

	for (std::shared_ptr<equipment> equipment : loop_equipments)
	{
		equipment->run_visitor(visitor);
	}
}

int backpack::get_loading()
{
	std::shared_ptr<get_loading_visitor> visitor = std::make_shared<get_loading_visitor>();
	run_visitor(visitor);
	return visitor->get_loading();
}
