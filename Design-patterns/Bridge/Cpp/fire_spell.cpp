#include <iostream>
#include <string>
#include "spell.h"

fire_spell::fire_spell(int power, int speed, int cost) : spell(power, speed, cost)
{

}

void fire_spell::cast()
{
	std::cout << "Casts a fire spell with power " + std::to_string(power) + " and speed " + std::to_string(speed) + ". Applies burning effect." << std::endl;
}