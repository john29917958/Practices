#include <iostream>
#include <mutex>
#include <string>
#include <thread>
#include "scene.h"

bool is_alive = true;
std::mutex lock;

void update(scene_controller* controller)
{
	while (is_alive)
	{
		lock.lock();
		controller->update();
		lock.unlock();
	}
}

int main()
{
	scene_controller* controller = new scene_controller();
	std::thread update_loop(&update, controller);

	scene* scene = new start_scene(controller);
	controller->set_scene(scene);

	std::this_thread::sleep_for(std::chrono::milliseconds(500));

	scene = new menu_scene(controller);
	lock.lock();
	controller->set_scene(scene, true);
	lock.unlock();

	std::this_thread::sleep_for(std::chrono::milliseconds(500));

	scene = new battle_scene(controller);
	lock.lock();
	controller->set_scene(scene, true);
	lock.unlock();

	std::this_thread::sleep_for(std::chrono::milliseconds(500));
	is_alive = false;

	// Waits until update job ended.
	if (update_loop.joinable())
	{
		update_loop.join();
	}

	std::string dummy_string;
	std::getline(std::cin, dummy_string);

	return 0;
}