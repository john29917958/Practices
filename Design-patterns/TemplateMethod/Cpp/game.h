#pragma once

#ifndef GAME_H
#define GAME_H
#include <memory>
#include "character.h"
#include "vector.h"

struct vector;
class character;

class game
{
public:
	static std::unique_ptr<character> ray_cast_character(vector origin, vector end);
	static std::unique_ptr<character> ray_cast_character(vector origin, float radius);
};

#endif