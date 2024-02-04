#pragma once

#ifndef EQUIPMENT_VISITOR_H
#define EQUIPMENT_VISITOR_H
#include "equipment.h"
#include "backpack.h"

class equipment_visitor
{
public:
	equipment_visitor() = default;
	virtual ~equipment_visitor() = 0;
	virtual void visit_equipment(std::shared_ptr<equipment> equipment);
	virtual void visit_weapon(std::shared_ptr<weapon> weapon);
	virtual void visit_armor(std::shared_ptr<armor> armor);	
};

class get_loading_visitor : public equipment_visitor
{
public:
	get_loading_visitor() = default;
	~get_loading_visitor() override = default;
	void visit_equipment(std::shared_ptr<equipment> equipment) override;
	void visit_weapon(std::shared_ptr<weapon> weapon) override;
	void visit_armor(std::shared_ptr<armor> armor) override;
	int get_loading();
private:
	int loading_;
};

class remove_broken_armor_visitor : public equipment_visitor
{
public:
	remove_broken_armor_visitor(std::shared_ptr<backpack> backpack);
	~remove_broken_armor_visitor() override = default;
	void visit_armor(std::shared_ptr<armor> armor) override;
private:
	std::shared_ptr<backpack> backpack_;
};

class drop_equipment_visitor : public equipment_visitor
{
public:
	drop_equipment_visitor(std::shared_ptr<equipment> equipment, std::shared_ptr<backpack> backpack);
	~drop_equipment_visitor() override = default;
	void visit_equipment(std::shared_ptr<equipment> equipment) override;
	void visit_weapon(std::shared_ptr<weapon> weapon) override;
	void visit_armor(std::shared_ptr<armor> armor) override;
private:
	std::shared_ptr<equipment> equipment_;
	std::shared_ptr<backpack> backpack_;
};

#endif
