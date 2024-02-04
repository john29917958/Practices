#pragma once
#ifndef MANAGER_H
#define MANAGER_H
#include "job.h"
#include "employee.h"

struct job;
class employee;
class customer_service;
class ui_ux_designer;
class programmer;

class manager
{
public:
	manager() = default;
	virtual ~manager() = 0;
	virtual void transfer_job(job job, employee* worker) = 0;
	void add_customer_service(customer_service* employee);
	void add_ui_ux_designer(ui_ux_designer* employee);
	void add_programmer(programmer* programmer);
	customer_service* get_any_customer_service();
	void do_jobs();
protected:
	std::vector<customer_service*> customer_services_;
	std::vector<ui_ux_designer*> ui_ux_designers_;
	std::vector<programmer*> programmers_;
};

class experienced_manager : public manager
{
public:
	experienced_manager() = default;
	~experienced_manager() override = default;
	void transfer_job(job job, employee* worker) override;
};

class spoiled_manager : public manager
{
public:
	spoiled_manager() = default;
	~spoiled_manager() override = default;
	void transfer_job(job job, employee* worker) override;
};

class do_nothing_manager : public manager
{
public:
	do_nothing_manager() = default;
	~do_nothing_manager() override = default;
	void transfer_job(job job, employee* worker) override;
};

#endif