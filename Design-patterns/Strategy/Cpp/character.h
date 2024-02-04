#pragma once

#ifndef CHARACTER_PROPERTIES_H
#define CHARACTER_PROPERTIES_H

#include "attributes.h"
#include "attribute_strategy.h"

class i_attributes;
class attribute_strategy;

struct character_properties
{
public:
	int level;
	int strength;
	int wisdom;

	character_properties() = default;
	character_properties(int level, int strength, int wisdom)
	{
		this->level = level;
		this->strength = strength;
		this->wisdom = wisdom;
	}
};

class character
{
public:
	character(std::shared_ptr<character_properties> properties, std::shared_ptr<attribute_strategy> attribute_strategy);
	~character() = default;
	std::shared_ptr<i_attributes> get_attributes();
	void set_attribute_strategy(std::shared_ptr<attribute_strategy> attribute_strategy);
private:
	std::shared_ptr<character_properties> properties_;
	std::shared_ptr<attribute_strategy> attribute_strategy_;
};

#endif