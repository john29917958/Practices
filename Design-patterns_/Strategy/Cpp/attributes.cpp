#include "attributes.h"

attributes::attributes(std::shared_ptr<i_attributes> init_attributes)
{
	health_ = init_attributes->get_health();
	mana_ = init_attributes->get_mana();
	attack_ = init_attributes->get_attack();
	magical_attack_ = init_attributes->get_magical_attack();
	defense_ = init_attributes->get_defense();
	magical_defense_ = init_attributes->get_magical_defense();
}

int attributes::get_health()
{
	return health_;
}

int attributes::get_mana()
{
	return mana_;
}

int attributes::get_attack()
{
	return attack_;
}

int attributes::get_magical_attack()
{
	return magical_attack_;
}

int attributes::get_defense()
{
	return defense_;
}

int attributes::get_magical_defense()
{
	return magical_defense_;
}

void attributes::set_health(int health)
{
	health_ = health;
}

void attributes::set_mana(int mana)
{
	mana_ = mana;
}

void attributes::set_attack(int attack)
{
	attack_ = attack;
}

void attributes::set_magical_attack(int magical_attack)
{
	magical_attack_ = magical_attack;
}

void attributes::set_defense(int defense)
{
	defense_ = defense;
}

void attributes::set_magical_defense(int magical_defense)
{
	magical_defense_ = magical_defense;
}
