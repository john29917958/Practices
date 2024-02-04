#include "spell.h"
#include <stdexcept>
#include <iostream>

float spell::get_cool_down_counter()
{
	return cool_down_counter_;
}

void spell::set_validator(std::shared_ptr<spell_casting_validator> validator)
{
	if (validator == nullptr)
	{
		throw std::invalid_argument("Validator is set to nullptr");
	}

	validator_ = validator;
}

void spell::cast()
{
	if (validator_ == nullptr || validator_->is_castable())
	{
		std::cout << "Casts spell" << std::endl;
	}
}
