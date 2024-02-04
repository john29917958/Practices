#pragma once

#ifndef VECTOR_H
#define VECTOR_H

struct vector
{
public:	
	float x;
	float y;
	float z;

	vector();
	vector(float x, float y, float z);
	~vector() = default;

	static vector front();
};

#endif