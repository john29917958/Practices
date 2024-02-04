#include "scene.h"

menu_scene::menu_scene(scene_controller* controller) : scene(controller)
{
	
}

void menu_scene::start()
{
	std::cout << "Menu scene started" << std::endl;
}

void menu_scene::update()
{
	std::cout << "Menu scene updated" << std::endl;
}

void menu_scene::end()
{
	std::cout << "Menu scene ended" << std::endl;
}