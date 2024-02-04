#pragma once
#pragma once
#ifndef JOB_H
#define JOB_H
#include <string>

enum phases { initial, ui_ux, code };

struct job
{
	int id;
	std::string name;
	phases phase;
};

#endif

