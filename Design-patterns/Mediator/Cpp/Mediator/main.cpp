#include <iostream>
#include "manager.h"

int main()
{
	manager* manager = new experienced_manager();
	manager->add_customer_service(new customer_service("Emily", manager));
	manager->add_customer_service(new customer_service("Laura", manager));
	manager->add_customer_service(new customer_service("Alice", manager));

	manager->add_ui_ux_designer(new ui_ux_designer("John", manager));
	manager->add_ui_ux_designer(new ui_ux_designer("Sarah", manager));
	manager->add_ui_ux_designer(new ui_ux_designer("Rebecca", manager));

	manager->add_programmer(new programmer("Jack", manager));
	manager->add_programmer(new lazy_programmer("I'm lazy", manager));
	manager->add_programmer(new programmer("George", manager));

	job job;
	job.id = 0;
	job.name = "Shopping web";
	job.phase = initial;

	manager->get_any_customer_service()->take_job(job);
	manager->do_jobs();

	return 0;
}
