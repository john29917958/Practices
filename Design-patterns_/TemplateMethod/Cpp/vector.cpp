#include <limits>
#include "vector.h"

vector::vector()
{
	x = 0;
	y = 0;
	z = 0;
}

vector::vector(float x, float y, float z)
{
	this->x = x;
	this->y = y;
	this->z = z;
}

vector vector::front()
{
	return vector(0, 0, std::numeric_limits<float>::max());
}
