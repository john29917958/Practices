#pragma once
#ifndef EMPLOYEE_H
#define EMPLOYEE_H

#include <string>
#include <vector>
#include "job.h"
#include "manager.h"

struct job;
class manager;

enum moods { thrilled, good, normal, bad, angry };

class employee
{
public:
	employee(std::string name, manager* manager);
	virtual ~employee() = 0;
	std::string get_name() const;
	int get_health() const;
	moods get_mood() const;
	//get set jobs
	virtual bool take_job(job job, bool is_force_mode = false);
	virtual void do_job();
protected:
	std::string name_;
	int health_;
	moods mood_;
	std::vector<job> jobs_;
	manager* manager_;
};

class customer_service : public employee
{
public:
	customer_service(std::string name, manager* manager);
	~customer_service() = default;
	void negotiate(job job);
	void deliver(job job);
	bool take_job(job job, bool is_force_mode = false) override;
};

class ui_ux_designer : public employee
{
public:
	ui_ux_designer(std::string name, manager* manager);
	~ui_ux_designer() = default;
};

class programmer : public employee
{
public:
	programmer(std::string name, manager* manager);
	~programmer() = default;
};

class lazy_programmer : public programmer
{
public:
	lazy_programmer(std::string name, manager* manager);
	~lazy_programmer() = default;
	void do_job() override;
};

#endif
