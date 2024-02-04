#pragma once

#ifndef ATTRIBUTES_H
#define ATTRIBUTES_H

#include <memory>

class i_attributes
{
public:
	virtual int get_health() = 0;
	virtual int get_mana() = 0;
	virtual int get_attack() = 0;
	virtual int get_magical_attack() = 0;
	virtual int get_defense() = 0;
	virtual int get_magical_defense() = 0;
};

class attributes : public i_attributes
{
public:
	attributes() = default;
	attributes(std::shared_ptr<i_attributes> init_attributes);
	~attributes() = default;
	int get_health() override;
	int get_mana() override;
	int get_attack() override;
	int get_magical_attack() override;
	int get_defense() override;
	int get_magical_defense() override;
	void set_health(int health);
	void set_mana(int mana);
	void set_attack(int attack);
	void set_magical_attack(int magical_attack);
	void set_defense(int defense);
	void set_magical_defense(int magical_defense);
protected:
	int health_;
	int mana_;
	int attack_;
	int magical_attack_;
	int defense_;
	int magical_defense_;
};

#endif