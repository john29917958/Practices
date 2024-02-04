#pragma once

#ifndef ATTRIBUTES_H
#define ATTRIBUTES_H

class attributes
{
public:
	attributes() = default;
	virtual ~attributes() = 0;
	virtual int get_max_health();
	virtual int get_max_mana();
	virtual int get_attack();
	virtual int get_defense();
	virtual int get_critical();
protected:
	int max_health_;
	int max_mana_;
	int attack_;
	int defense_;
	int critical_;
};

class base_attributes : public attributes
{
public:
	base_attributes(int max_health, int max_mana, int attack, int defense, int critical);
	~base_attributes() override = default;
};

#endif
