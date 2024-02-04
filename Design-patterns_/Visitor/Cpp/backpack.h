#pragma once

#ifndef BACKPACK_H
#define BACKPACK_H
#include <memory>
#include "equipment.h"
#include <vector>

class backpack
{
public:
	backpack(int max_loading);
	~backpack() = default;
	void add(std::shared_ptr<equipment> equipment);
	void remove(std::shared_ptr<equipment> equipment);
	void run_visitor(std::shared_ptr<equipment_visitor> visitor);
	int get_loading();
private:
	int max_loading_;
	std::vector<std::shared_ptr<equipment>> equipments_;
};

#endif