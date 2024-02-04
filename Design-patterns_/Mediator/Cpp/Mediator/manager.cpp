#include <ctime>
#include "manager.h"

manager::~manager()
{

}

void manager::add_customer_service(customer_service* employee)
{
	customer_services_.push_back(employee);
}

void manager::add_ui_ux_designer(ui_ux_designer* employee)
{
	ui_ux_designers_.push_back(employee);
}

void manager::add_programmer(programmer* programmer)
{
	programmers_.push_back(programmer);
}

void manager::do_jobs()
{
	for (ui_ux_designer* designer : ui_ux_designers_)
	{
		designer->do_job();
	}

	for (programmer* programmer : programmers_)
	{
		programmer->do_job();
	}
}


customer_service* manager::get_any_customer_service()
{
	if (customer_services_.empty()) return nullptr;

	srand(time(nullptr));
	int id = rand() % customer_services_.size();

	return customer_services_[id];
}

void experienced_manager::transfer_job(job job, employee* worker)
{
	if (job.phase == initial)
	{
		job.phase = ui_ux;

		for (ui_ux_designer* designer : ui_ux_designers_)
		{
			if (designer->get_mood() != angry && designer->get_mood() != bad && designer->get_health() >= 50)
			{
				designer->take_job(job);
			}
		}

		// No appropriate worker found. Negotiate with customer.
		srand(time(nullptr));
		int customer_service_id = rand() % customer_services_.size();
		customer_services_[customer_service_id]->negotiate(job);
	}
	else if (job.phase == ui_ux)
	{
		job.phase = code;

		for (programmer* programmer : programmers_)
		{
			if (programmer->get_mood() != angry && programmer->get_mood() != bad && programmer->get_health() >= 50)
			{
				programmer->take_job(job);
			}
		}

		// No appropriate worker found. Negotiate with customer.
		srand(time(nullptr));
		int customer_service_id = rand() % customer_services_.size();
		customer_services_[customer_service_id]->negotiate(job);
	}
	else
	{
		// Job's done, deliver to customer.
		srand(time(nullptr));
		int customer_service_id = rand() % customer_services_.size();
		customer_services_[customer_service_id]->deliver(job);
	}
}

void spoiled_manager::transfer_job(job job, employee* worker)
{
	if (job.phase == initial)
	{
		job.phase = ui_ux;

		for (ui_ux_designer* designer : ui_ux_designers_)
		{
			designer->take_job(job, true);
		}
	}
	else if (job.phase == ui_ux)
	{
		job.phase = code;

		for (programmer* programmer : programmers_)
		{
			programmer->take_job(job, true);
		}
	}
	else
	{
		srand(time(nullptr));
		int customer_service_id = rand() % customer_services_.size();
		customer_services_[customer_service_id]->deliver(job);
	}
}

void do_nothing_manager::transfer_job(job job, employee* worker)
{
	// Just do nothing...
}
