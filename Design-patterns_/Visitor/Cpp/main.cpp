#include "equipment.h"
#include "backpack.h"
#include "equipment_visitor.h"

int main()
{
	std::shared_ptr<backpack> backpack = std::make_shared<::backpack>(10);
	std::shared_ptr<equipment> weapon = std::make_shared<::weapon>("Knife", 3);
	backpack->add(weapon);
	backpack->add(std::make_shared<armor>("Body armor", 3, 3));
	backpack->add(std::make_shared<armor>("Feet armor", 3, 0));
	backpack->add(std::make_shared<armor>("Shield", 3, 100));

	std::shared_ptr<equipment_visitor> visitor = std::make_shared<remove_broken_armor_visitor>(backpack);
	backpack->run_visitor(visitor);

	visitor = std::make_shared<drop_equipment_visitor>(weapon, backpack);
	backpack->run_visitor(visitor);

	return 0;
}
