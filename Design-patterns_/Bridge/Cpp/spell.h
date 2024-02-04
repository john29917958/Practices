#pragma once
#ifndef SPELL_H
#define SPELL_H

class spell
{
public:
	int power;
	int speed;
	int cost;

	spell(int power, int speed, int cost);
	virtual void cast() = 0;
	virtual ~spell() = 0;
};

class default_spell : public spell
{
public:
	default_spell(int power, int speed, int cost);
	void cast() override;
};

class fire_spell : public spell
{
public:
	fire_spell(int power, int speed, int cost);
	void cast() override;
};

class ice_spell: public spell
{
public:
	ice_spell(int power, int speed, int cost);
	void cast() override;
};

class curse_spell : public spell
{
public:
	curse_spell(int power, int speed, int cost);
	void cast() override;
};

#endif