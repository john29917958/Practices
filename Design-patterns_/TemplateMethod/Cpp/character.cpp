#include "character.h"

character::character()
{
	health_ = 100;
	mana_ = 100;
	position = vector(0, 0, 0);
}

int character::get_health()
{
	return health_;
}

int character::get_mana()
{
	return mana_;
}
