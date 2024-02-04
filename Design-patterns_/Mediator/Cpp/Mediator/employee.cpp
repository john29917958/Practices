#include "employee.h"
#include <ctime>

employee::employee(std::string name, manager* manager)
{
	name_ = name;
	health_ = 100;
	mood_ = good;
	manager_ = manager;
}

employee::~employee()
{
	
}

std::string employee::get_name() const
{
	return name_;
}

int employee::get_health() const
{
	return health_;
}

moods employee::get_mood() const
{
	return mood_;
}

bool employee::take_job(job job, const bool is_force_mode)
{
	if (mood_ == angry && !is_force_mode) return false;

	jobs_.push_back(job);

	if (jobs_.size() <= 3)
	{
		mood_ = thrilled;
	}
	else if (jobs_.size() <= 5)
	{
		mood_ = good;
	}
	else if (jobs_.size() <= 7)
	{
		mood_ = normal;
	}
	else if (jobs_.size() <= 9)
	{
		mood_ = bad;
	}
	else
	{
		mood_ = angry;
	}

	return true;
}

void employee::do_job()
{
	if (jobs_.empty()) return;

	srand(time(nullptr));
	int index = rand() % jobs_.size();
	job completed_job = jobs_[index];
	jobs_.erase(jobs_.begin() + index);
	manager_->transfer_job(completed_job, this);
}
