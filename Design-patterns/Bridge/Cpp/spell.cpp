#include "spell.h"

spell::spell(int power, int speed, int cost)
{
	this->power = power;
	this->speed = speed;
	this->cost = cost;
}

spell::~spell() = default;
