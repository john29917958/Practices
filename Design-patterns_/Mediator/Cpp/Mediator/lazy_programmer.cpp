#include <ctime>
#include "employee.h"

lazy_programmer::lazy_programmer(std::string name, manager* manager) : programmer(name, manager)
{

}

void lazy_programmer::do_job()
{
	if (jobs_.empty()) return;
	if (mood_ == angry || mood_ == bad || mood_ == normal || mood_ == good) return;

	srand(time(nullptr));
	int index = rand() % jobs_.size();
	job completed_job = jobs_[index];
	jobs_.erase(jobs_.begin() + index);
	manager_->transfer_job(completed_job, this);
}
