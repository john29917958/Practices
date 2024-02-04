#pragma once

#ifndef ATTRIBUTE_STRATEGY_H
#define ATTRIBUTE_STRATEGY_H

#include<memory>
#include "attributes.h"
#include "character.h"

class i_attributes;
struct character_properties;

class attribute_strategy : public i_attributes
{
public:
	attribute_strategy() = default;
	virtual ~attribute_strategy() = 0;
	virtual int get_health() override = 0;
	virtual int get_mana() override = 0;
	virtual int get_attack() override = 0;
	virtual int get_magical_attack() override = 0;
	virtual int get_defense() override = 0;
	virtual int get_magical_defense() override = 0;
	void set_character_properties(std::shared_ptr<character_properties> properties);
protected:
	std::shared_ptr<character_properties> properties_;
};

class warrior_attribute_strategy : public attribute_strategy
{
public:
	warrior_attribute_strategy() = default;
	~warrior_attribute_strategy() = default;

	int get_health() override;
	int get_mana() override;
	int get_attack() override;
	int get_magical_attack() override;
	int get_defense() override;
	int get_magical_defense() override;
};

class magica_attribute_strategy : public attribute_strategy
{
public:
	magica_attribute_strategy() = default;
	~magica_attribute_strategy() = default;

	int get_health() override;
	int get_mana() override;
	int get_attack() override;
	int get_magical_attack() override;
	int get_defense() override;
	int get_magical_defense() override;
};

#endif