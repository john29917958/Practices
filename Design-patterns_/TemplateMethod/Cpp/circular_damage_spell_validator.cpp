#include "spell_casting_validator.h"
#include "game.h"

circular_damage_spell_validator::circular_damage_spell_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell) : spell_casting_validator(character, spell)
{
	
}

bool circular_damage_spell_validator::is_resource_enouth()
{
	if (character_->get_health() >= 10 && character_->get_mana() >= 90)
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool circular_damage_spell_validator::is_skill_cooling()
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

bool circular_damage_spell_validator::is_any_target_in_attack_range()
{
	std::unique_ptr<character> target = game::ray_cast_character(character_->position, 5);

	if (target == nullptr)
	{
		return false;
	}
	else
	{
		return true;
	}
}
