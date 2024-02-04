#include "spell_casting_validator.h"

spell_casting_validator::spell_casting_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell)
{
	character_ = character;
	spell_ = spell;
}

spell_casting_validator::~spell_casting_validator() = default;

bool spell_casting_validator::is_castable()
{
	if (!is_resource_enouth()) return false;
	if (is_skill_cooling()) return false;
	if (!is_any_target_in_attack_range()) return false;

	return true;
}
