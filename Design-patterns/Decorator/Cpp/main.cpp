#include <iostream>
#include "character.h"
#include "attributes_decorator.h"

void print_character_attributes(character& character)
{
	std::cout << "Max health: " << character.get_attributes()->get_max_health() << std::endl;
	std::cout << "Max mana: " << character.get_attributes()->get_max_mana() << std::endl;
	std::cout << "Attack: " << character.get_attributes()->get_attack() << std::endl;
	std::cout << "Defense: " << character.get_attributes()->get_defense() << std::endl;
	std::cout << "Critical: " << character.get_attributes()->get_critical() << std::endl;
}

int main()
{
	character character(std::make_shared<base_attributes>(100, 50, 10, 5, 1));
	std::cout << "Initial attributes:" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	std::shared_ptr<level_decorator> level_decorator = std::make_shared<::level_decorator>(character.get_base_attributes(), character.get_attributes(), 1);
	character.set_attributes(level_decorator);
	std::cout << "Level decorator (Lv" << level_decorator->level << "):" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	level_decorator->level += 1;
	std::cout << "Level decorator (Lv" << level_decorator->level << "):" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	level_decorator->level += 1;
	std::cout << "Level decorator (Lv" << level_decorator->level << "):" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	std::shared_ptr<fairy_gun_i_decorator> gun_decorator = std::make_shared<fairy_gun_i_decorator>(character.get_base_attributes(), character.get_attributes(), 1);
	character.set_attributes(gun_decorator);
	std::cout << "Gun decorator (Lv" << gun_decorator->level << "):" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	gun_decorator->level += 1;
	std::cout << "Gun decorator (Lv" << gun_decorator->level << "):" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	gun_decorator->level += 1;
	std::cout << "Gun decorator (Lv" << gun_decorator->level << "):" << std::endl;
	print_character_attributes(character);
	std::cout << "=========================" << std::endl;

	return 0;
}
