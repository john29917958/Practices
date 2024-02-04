#pragma once

#ifndef SPELL_CASTING_VALIDATOR_H
#define SPELL_CASTING_VALIDATOR_H
#include "spell.h"
#include "character.h"
#include <memory>

class spell;
class character;

class spell_casting_validator
{
public:
	spell_casting_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell);
	virtual ~spell_casting_validator() = 0;
	bool is_castable();
	virtual bool is_resource_enouth() = 0;
	virtual bool is_skill_cooling() = 0;
	virtual bool is_any_target_in_attack_range() = 0;
protected:
	std::shared_ptr<character> character_;
	std::shared_ptr<spell> spell_;
};

class default_spell_validator : public spell_casting_validator
{
public:
	default_spell_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell);
	~default_spell_validator() override = default;
	bool is_resource_enouth() override;
	bool is_skill_cooling() override;
	bool is_any_target_in_attack_range() override;
};

class lazer_spell_validator : public spell_casting_validator
{
public:
	lazer_spell_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell);
	~lazer_spell_validator() override = default;
	bool is_resource_enouth() override;
	bool is_skill_cooling() override;
	bool is_any_target_in_attack_range() override;
};

class circular_damage_spell_validator : public spell_casting_validator
{
public:
	circular_damage_spell_validator(std::shared_ptr<character> character, std::shared_ptr<spell> spell);
	~circular_damage_spell_validator() override = default;
	bool is_resource_enouth() override;
	bool is_skill_cooling() override;
	bool is_any_target_in_attack_range() override;
};

#endif
