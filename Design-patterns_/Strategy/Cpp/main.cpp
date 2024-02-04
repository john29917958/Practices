#include <iostream>
#include "character.h"

void print_character(std::shared_ptr<character> character)
{
	std::cout << "Character attributes:" << std::endl
		<< "Health: " << character->get_attributes()->get_health() << std::endl
		<< "Mana: " << character->get_attributes()->get_mana() << std::endl
		<< "Attack: " << character->get_attributes()->get_attack() << std::endl
		<< "Defense: " << character->get_attributes()->get_defense() << std::endl
		<< "Magical attack: " << character->get_attributes()->get_magical_attack() << std::endl
		<< "Magical defense: " << character->get_attributes()->get_magical_defense() << std::endl;
}

int main()
{
    std::cout << "Warrior" << std::endl;
	std::shared_ptr<character> character = std::make_shared<::character>(std::make_shared<character_properties>(1, 10, 5), std::make_shared<warrior_attribute_strategy>());
	print_character(character);

	std::cout << std::endl << "Magica" << std::endl;
	character->set_attribute_strategy(std::make_shared<magica_attribute_strategy>());
	print_character(character);

	return 0;
}
