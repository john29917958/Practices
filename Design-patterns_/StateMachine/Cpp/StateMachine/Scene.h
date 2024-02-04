#pragma once

#ifndef SCENE_CONTROLLER_H
#define SCENE_CONTROLLER_H

class scene;

class scene_controller
{
public:
	scene_controller();
	~scene_controller() = default;
	void set_scene(scene* scene, bool deleteOldScene = false);
	void update() const;
private:
	scene* scene_;
};

#endif

#ifndef SCENE_H
#define SCENE_H
#include <iostream>

class scene_controller;

class scene
{
public:
	scene(scene_controller* controller);
	virtual ~scene() = 0;
	virtual void start() = 0;
	virtual void update() = 0;
	virtual void end() = 0;
protected:
	scene_controller* controller_;
};

class start_scene : public scene
{
public:
	start_scene(scene_controller* controller);
	~start_scene() override = default;

	void start() override;
	void update() override;
	void end() override;
};

class menu_scene : public scene
{
public:
	menu_scene(scene_controller* controller);
	~menu_scene() override = default;

	void start() override;
	void update() override;
	void end() override;
};

class battle_scene : public scene
{
public:
	battle_scene(scene_controller* controller);
	~battle_scene() override = default;
	void start() override;
	void update() override;
	void end() override;
};

#endif