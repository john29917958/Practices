#include "character.h"

character::character(std::shared_ptr<character_properties> properties, std::shared_ptr<::attribute_strategy> attribute_strategy)
{
	properties_ = properties;
	attribute_strategy_ = attribute_strategy;
	attribute_strategy_->set_character_properties(properties);
}

void character::set_attribute_strategy(std::shared_ptr<attribute_strategy> attribute_strategy)
{
	attribute_strategy_ = attribute_strategy;
	attribute_strategy_->set_character_properties(properties_);
}

std::shared_ptr<i_attributes> character::get_attributes()
{
	std::shared_ptr<attributes> attributes = std::make_shared<::attributes>();
	
	attributes->set_health(attribute_strategy_->get_health());
	attributes->set_mana(attribute_strategy_->get_mana());
	attributes->set_attack(attribute_strategy_->get_attack());
	attributes->set_magical_attack(attribute_strategy_->get_magical_attack());
	attributes->set_defense(attribute_strategy_->get_defense());
	attributes->set_magical_defense(attribute_strategy_->get_magical_defense());

	return attributes;
}
