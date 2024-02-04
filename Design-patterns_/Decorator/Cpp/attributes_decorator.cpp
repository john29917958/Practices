#include "attributes_decorator.h"

attributes_decorator::attributes_decorator(std::shared_ptr<base_attributes> base_attributes, std::shared_ptr<attributes> parent_attributes)
{
	base_attributes_ = base_attributes;
	parent_attributes_ = parent_attributes;
}

attributes_decorator::~attributes_decorator() = default;

int attributes_decorator::get_max_health()
{
	return parent_attributes_->get_max_health();
}

int attributes_decorator::get_max_mana()
{
	return parent_attributes_->get_max_mana();
}

int attributes_decorator::get_attack()
{
	return parent_attributes_->get_attack();
}

int attributes_decorator::get_defense()
{
	return parent_attributes_->get_defense();
}

int attributes_decorator::get_critical()
{
	return parent_attributes_->get_critical();
}
