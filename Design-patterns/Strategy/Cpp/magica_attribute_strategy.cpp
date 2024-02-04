#include "attribute_strategy.h"

int magica_attribute_strategy::get_health()
{
	return properties_->level * properties_->strength;
}

int magica_attribute_strategy::get_mana()
{
	return properties_->level * properties_->wisdom * 5;
}

int magica_attribute_strategy::get_attack()
{
	return properties_->level + properties_->strength;
}

int magica_attribute_strategy::get_magical_attack()
{
	return properties_->level + properties_->wisdom * 10;
}

int magica_attribute_strategy::get_defense()
{
	return properties_->level + properties_->strength;
}

int magica_attribute_strategy::get_magical_defense()
{
	return properties_->level + properties_->wisdom * 5;
}
