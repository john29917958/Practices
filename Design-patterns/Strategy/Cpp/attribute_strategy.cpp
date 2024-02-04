#include "attribute_strategy.h"

void attribute_strategy::set_character_properties(std::shared_ptr<character_properties> properties)
{
	properties_ = properties;
}

attribute_strategy::~attribute_strategy() = default;
