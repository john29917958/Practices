#include "equipment.h"

equipment::equipment(std::string name, int loading)
{
	name_ = name;
	loading_ = loading;
}

equipment::~equipment() = default;

std::string equipment::get_name()
{
	return name_;
}

int equipment::get_loading()
{
	return loading_;
}
