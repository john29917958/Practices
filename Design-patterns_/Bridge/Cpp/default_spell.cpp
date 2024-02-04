#include <iostream>
#include <string>
#include "spell.h"

default_spell::default_spell(int power, int speed, int cost) : spell(power, speed, cost)
{

}

void default_spell::cast()
{
	std::cout << "Casts a default air spell with power " + std::to_string(power) + " and speed " + std::to_string(speed) + "." << std::endl;
}