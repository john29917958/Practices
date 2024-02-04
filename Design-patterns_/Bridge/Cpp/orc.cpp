#include "character.h"

orc::orc(int id, std::string name, int health, int mana) : character(id, name, health, mana)
{
	
}

void orc::take_damage(int value)
{
	value -= 3;
	if (value <= 0) value = 0;

	orc::take_damage(value);
}
