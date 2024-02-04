#include "attribute_strategy.h"

int warrior_attribute_strategy::get_health()
{
	return properties_->level * properties_->strength * 5;
}

int warrior_attribute_strategy::get_mana()
{
	return properties_->level * properties_->wisdom;
}

int warrior_attribute_strategy::get_attack()
{
	return properties_->level + properties_->strength * 10;
}

int warrior_attribute_strategy::get_magical_attack()
{
	return properties_->level + properties_->wisdom;
}

int warrior_attribute_strategy::get_defense()
{
	return properties_->level + properties_->strength * 5;
}

int warrior_attribute_strategy::get_magical_defense()
{
	return properties_->level + properties_->wisdom;
}
