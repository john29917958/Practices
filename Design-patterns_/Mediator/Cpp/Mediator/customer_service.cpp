#include "employee.h"

customer_service::customer_service(std::string name, manager* manager) : employee(name, manager)
{

}

void customer_service::negotiate(job job)
{
	// Negotiates with customer.
}

void customer_service::deliver(job job)
{
	// Delivers job to customer.
}

bool customer_service::take_job(job job, bool is_force_mode)
{
	manager_->transfer_job(job, this);
	return true;
}
