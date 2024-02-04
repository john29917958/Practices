#include "attributes.h"

base_attributes::base_attributes(int max_health, int max_mana, int attack, int defense, int critical)
{
	max_health_ = max_health;
	max_mana_ = max_mana;
	attack_ = attack;
	defense_ = defense;
	critical_ = critical;
}
