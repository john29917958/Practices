#pragma once

#ifndef EQUIPMENT_H
#define EQUIPMENT_H
#include <string>

class equipment_visitor;

class equipment : std::enable_shared_from_this<equipment>
{
public:
	virtual ~equipment() = 0;
	std::string get_name();
	int get_loading();
	virtual void run_visitor(std::shared_ptr<equipment_visitor> visitor) = 0;
protected:
	equipment(std::string name, int loading);
	std::string name_;
	int loading_;
};

class weapon : public equipment
{
public:
	weapon(std::string name, int loading);
	~weapon() = default;
	void run_visitor(std::shared_ptr<equipment_visitor> visitor) override;
	void attack();
};

class armor : public equipment
{
public:
	armor(std::string name, int loading, int endurance);
	~armor() = default;
	int get_endurance();
	void run_visitor(std::shared_ptr<equipment_visitor> visitor) override;
	void take_damage();
protected:
	int endurance_;
};

#endif