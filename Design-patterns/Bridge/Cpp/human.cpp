#include "character.h"

human::human(int id, std::string name, int health, int mana) : character(id, name, health, mana)
{

}

void human::set_spell(std::shared_ptr<spell> spell)
{
	character::set_spell(spell);
	spell_->cost -= 10;
	if (spell_->cost < 0) spell_->cost = 0;
}

void human::cast_spell()
{
	character::cast_spell();
	character::cast_spell();
}