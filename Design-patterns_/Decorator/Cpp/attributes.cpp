#include "attributes.h"

attributes::~attributes() = default;

int attributes::get_max_mana()
{
	return max_mana_;
}

int attributes::get_max_health()
{
	return max_health_;
}

int attributes::get_attack()
{
	return attack_;
}

int attributes::get_defense()
{
	return defense_;
}

int attributes::get_critical()
{
	return critical_;
}
