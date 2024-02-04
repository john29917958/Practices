#include "character.h"
#include "spell.h"

int main()
{
	std::shared_ptr<character> character = std::make_shared<::character>();
	std::shared_ptr<spell> spell = std::make_shared<::spell>();

	spell->set_validator(std::make_shared<default_spell_validator>(character, spell));
	spell->cast();

	spell->set_validator(std::make_shared<circular_damage_spell_validator>(character, spell));
	spell->cast();

	spell->set_validator(std::make_shared<lazer_spell_validator>(character, spell));
	spell->cast();

	return 0;
}
