#include "spell_casting_validator.h"
#include "game.h"

lazer_spell_validator::lazer_spell_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell) : spell_casting_validator(character, spell)
{
	
}

bool lazer_spell_validator::is_resource_enouth()
{
	if (character_->get_mana() >= 30)
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool lazer_spell_validator::is_skill_cooling()
{
	if (spell_->get_cool_down_counter() > 0)
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool lazer_spell_validator::is_any_target_in_attack_range()
{
	std::unique_ptr<character> target = game::ray_cast_character(character_->position, vector::front());

	if (target == nullptr)
	{
		return false;
	}
	else
	{
		return true;
	}
}
