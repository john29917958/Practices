#pragma once

#ifndef CHARACTER_H
#define CHARACTER_H
#include "vector.h"

struct vector;

class character
{
public:
	vector position;	

	character();
	~character() = default;

	int get_health();
	int get_mana();
protected:
	int health_;
	int mana_;
};

#endif