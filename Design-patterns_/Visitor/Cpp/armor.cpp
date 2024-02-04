#include "equipment.h"
#include "equipment_visitor.h"

armor::armor(std::string name, int loading, int endurance) : equipment(name, loading)
{
	endurance_ = endurance;
}

int armor::get_endurance()
{
	return endurance_;
}


void armor::run_visitor(std::shared_ptr<equipment_visitor> visitor)
{
	visitor->visit_armor(std::shared_ptr<armor>(std::shared_ptr<armor>(), this));
}

void armor::take_damage()
{
	endurance_ -= 1;
	if (endurance_ < 0) endurance_ = 0;
}
