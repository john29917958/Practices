#include <iostream>
#include <string>
#include "spell.h"

ice_spell::ice_spell(int power, int speed, int cost) : spell(power, speed, cost)
{

}

void ice_spell::cast()
{
	std::cout << "Casts a ice spell with power " + std::to_string(power) + " and speed " + std::to_string(speed) + ". Freezes the enemy 3 seconds." << std::endl;
}