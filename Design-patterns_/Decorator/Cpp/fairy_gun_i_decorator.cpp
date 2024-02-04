#include "attributes_decorator.h"

fairy_gun_i_decorator::fairy_gun_i_decorator(std::shared_ptr<base_attributes> base_attributes, std::shared_ptr<attributes> parent_attributes, int level) : attributes_decorator(base_attributes, parent_attributes)
{
	this->level = level;
}

int fairy_gun_i_decorator::get_attack()
{
	return parent_attributes_->get_attack() + 10 * level;
}

int fairy_gun_i_decorator::get_critical()
{
	return parent_attributes_->get_critical() + 9 * level;
}