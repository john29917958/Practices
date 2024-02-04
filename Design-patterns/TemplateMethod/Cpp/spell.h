#pragma once

#ifndef SPELL_H
#define SPELL_H
#include <memory>
#include "spell_casting_validator.h"

class spell_casting_validator;

class spell
{
public:
	spell() = default;
	~spell() = default;
	float get_cool_down_counter();
	void set_validator(std::shared_ptr<spell_casting_validator> validator);
	void cast();
protected:
	float cool_down_counter_;
	std::shared_ptr<spell_casting_validator> validator_;
};

#endif