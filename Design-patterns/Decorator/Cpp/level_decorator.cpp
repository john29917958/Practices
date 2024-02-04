#include "attributes_decorator.h"

level_decorator::level_decorator(std::shared_ptr<base_attributes> base_attributes, std::shared_ptr<attributes> parent_attributes, int level) : attributes_decorator(base_attributes, parent_attributes)
{
	this->level = level;
}

int level_decorator::get_max_health()
{
	return parent_attributes_->get_max_health() + (level - 1) * 10;
}

int level_decorator::get_max_mana()
{
	return parent_attributes_->get_max_mana() + (level - 1) * 5;
}

int level_decorator::get_attack()
{
	return parent_attributes_->get_attack() + int(base_attributes_->get_attack() * 0.2 * (level - 1));
}

int level_decorator::get_defense()
{
	return parent_attributes_->get_defense() + int(base_attributes_->get_defense() * 0.1 * (level - 1));
}

int level_decorator::get_critical()
{
	return parent_attributes_->get_critical() + int(base_attributes_->get_critical() * 0.01 * (level - 1));
}