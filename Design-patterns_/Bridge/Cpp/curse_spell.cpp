#include <iostream>
#include <string>
#include "spell.h"

curse_spell::curse_spell(int power, int speed, int cost) : spell(power, speed, cost)
{

}

void curse_spell::cast()
{
	std::cout << "Casts a curse spell with power " + std::to_string(power) + " and speed " + std::to_string(speed) + ". Shows dark flame effect and keeps damage health of enemy for 10 seconds. Applies curse effect to every enemies who collide with the target enemy." << std::endl;
}