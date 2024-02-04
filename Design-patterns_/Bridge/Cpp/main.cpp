#include "character.h"

int main()
{
	std::unique_ptr<character> character = std::make_unique<human>(0, "Jack", 100, 100);
	character->cast_spell();
	character->set_spell(std::make_shared<fire_spell>(30, 100, 20));
	character->cast_spell();
	character->set_spell(std::make_shared<ice_spell>(30, 50, 20));
	character->cast_spell();
	character->set_spell(std::make_shared<curse_spell>(40, 60, 20));
	character->cast_spell();

	character = std::make_unique<orc>(1, "Gary", 100, 100);
	character->cast_spell();
	character->set_spell(std::make_shared<fire_spell>(30, 100, 20));
	character->cast_spell();
	character->set_spell(std::make_shared<ice_spell>(30, 50, 20));
	character->cast_spell();
	character->set_spell(std::make_shared<curse_spell>(40, 60, 20));
	character->cast_spell();

	character = std::make_unique<vampire>(3, "Prince", 100, 100);
	character->cast_spell();
	character->set_spell(std::make_shared<fire_spell>(30, 100, 20));
	character->cast_spell();
	character->set_spell(std::make_shared<ice_spell>(30, 50, 20));
	character->cast_spell();
	character->set_spell(std::make_shared<curse_spell>(40, 60, 20));
	character->cast_spell();

	return 0;
}