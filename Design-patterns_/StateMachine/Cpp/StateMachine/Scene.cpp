#include "scene.h"

scene::scene(scene_controller* controller)
{
	controller_ = controller;
}

scene::~scene()
{
	controller_ = nullptr;
}
