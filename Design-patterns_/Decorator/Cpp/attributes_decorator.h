#pragma once

#ifndef ATTRIBUTES_DECORATOR_H
#define ATTRIBUTES_DECORATOR_H
#include "attributes.h"
#include <memory>

class attributes_decorator : public attributes
{
public:
	attributes_decorator(std::shared_ptr<base_attributes> base_attributes, std::shared_ptr<attributes> parent_attributes);
	virtual ~attributes_decorator() override = 0;
	int get_max_health() override;
	int get_max_mana() override;
	int get_attack() override;
	int get_defense() override;
	int get_critical() override;
protected:
	std::shared_ptr<base_attributes> base_attributes_;
	std::shared_ptr<attributes> parent_attributes_;
};

class level_decorator : public attributes_decorator
{
public:
	level_decorator(std::shared_ptr<base_attributes> base_attributes, std::shared_ptr<attributes> parent_attributes, int level);
	~level_decorator() override = default;
	int level;
	int get_max_health() override;
	int get_max_mana() override;
	int get_attack() override;
	int get_defense() override;
	int get_critical() override;
};

class fairy_gun_i_decorator : public attributes_decorator
{
public:
	fairy_gun_i_decorator(std::shared_ptr<base_attributes> base_attributes, std::shared_ptr<attributes> parent_attributes, int level);
	~fairy_gun_i_decorator() override = default;
	int level;
	int get_attack() override;
	int get_critical() override;

};

#endif