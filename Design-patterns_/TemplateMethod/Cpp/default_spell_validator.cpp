#include "spell_casting_validator.h"
#include "game.h"

default_spell_validator::default_spell_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell) : spell_casting_validator(character, spell)
{
	
}

bool default_spell_validator::is_resource_enouth()
{
	// No HP or MP restriction for default spell.
	return true;
}

bool default_spell_validator::is_skill_cooling()
{
	// No cooling time for default spell.
	return false;
}

bool default_spell_validator::is_any_target_in_attack_range()
{
	// Checks any character in melee range.
	vector front = vector::front();
	front.z = 1;

	std::unique_ptr<character> target = game::ray_cast_character(character_->position, front);

	if (target == nullptr)
	{
		return false;
	}
	else
	{
		return true;
	}
}
