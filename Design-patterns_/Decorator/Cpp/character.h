#pragma once
#include <memory>
#include"attributes.h";

class attributes;
class base_attributes;

class character
{
public:
	character(std::shared_ptr<base_attributes> base_attributes);
	~character() = default;
	int get_x();
	int get_y();
	std::shared_ptr<base_attributes> get_base_attributes();
	std::shared_ptr<attributes> get_attributes();
	void set_attributes(std::shared_ptr<attributes> attributes);
protected:	
	int x_;
	int y_;
	std::shared_ptr<base_attributes> base_attributes_;
	std::shared_ptr<attributes> attributes_;	
};
