#include "scene.h"

battle_scene::battle_scene(scene_controller* controller) : scene(controller)
{
	
}

void battle_scene::start()
{
	std::cout << "Battle scene started" << std::endl;
}

void battle_scene::update()
{
	std::cout << "Battle scene updated" << std::endl;
}

void battle_scene::end()
{
	std::cout << "Battle scene ended" << std::endl;
}
