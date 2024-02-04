#include "character.h"

character::character(std::shared_ptr<base_attributes> base_attributes)
{
	base_attributes_ = base_attributes;
	attributes_ = base_attributes;
}

int character::get_x()
{
	return x_;
}

int character::get_y()
{
	return y_;
}

std::shared_ptr<base_attributes> character::get_base_attributes()
{
	return base_attributes_;
}

std::shared_ptr<attributes> character::get_attributes()
{
	return attributes_;
}

void character::set_attributes(std::shared_ptr<attributes> attributes)
{
	attributes_ = attributes;
}