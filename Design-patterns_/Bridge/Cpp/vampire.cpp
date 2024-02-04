#include <iostream>
#include "character.h"

vampire::vampire(int id, std::string name, int health, int mana) : character(id, name, health, mana)
{
	
}

void vampire::set_spell(std::shared_ptr<spell> spell)
{
	character::set_spell(spell);

	if (is_curse_spell(spell))
	{
		std::cout << "Increases power and speed of cursed spell for Vampire " + name_ << std::endl;
		spell->power += 10;
		spell->speed += 5;
		spell->cost -= 5;
	}
}

bool vampire::is_curse_spell(std::shared_ptr<spell> the_spell)
{
	return typeid(the_spell) == typeid(std::shared_ptr<spell>);
}
