#include <iostream>
#include "character.h"

character::character(int id, std::string name, int health, int mana)
{
	id_ = id;
	name_ = name;
	health_ = health;
	mana_ = mana;
	spell_ = std::make_shared<default_spell>(10, 10, 10);
}

character::~character() = default;

void character::set_spell(std::shared_ptr<spell> spell)
{
	if (spell == nullptr)
	{
		throw std::exception("Spell cannot be set to null");
	}

	spell_ = spell;
}

void character::cast_spell()
{
	if (spell_ == nullptr) return;
	if (mana_ < spell_->cost) return;

	std::cout << name_ + " casts a spell." << std::endl;
	spell_->cast();
	mana_ -= spell_->cost;
	if (mana_ < 0) mana_ = 0;
}

void character::take_damage(int value)
{
	health_ -= value;
	if (health_ < 0) health_ = 0;
	std::cout << name_ + " have " + std::to_string(health_) + " health points after taking " + std::to_string(value) + " damage points" << std::endl;
}
