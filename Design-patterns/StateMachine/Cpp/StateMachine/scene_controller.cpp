#include "scene.h"

scene_controller::scene_controller()
{
	scene_ = nullptr;
}

void scene_controller::set_scene(scene* scene, bool deleteOldScene)
{
	if (scene_ != nullptr)
	{
		scene_->end();

		if (deleteOldScene)
		{
			delete scene_;
		}
	}	

	scene_ = scene;
	scene_->start();
}

void scene_controller::update() const
{
	if (scene_ != nullptr)
	{
		scene_->update();
	}
}
