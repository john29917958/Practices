#pragma once
#ifndef SINGLETON_H
#define SINGLETON_H

class singleton
{
public:
	static singleton* get_instance();
	void* get_data() const;
	void operation();
private:
	singleton();
	static singleton* instance_;
	void* data_ = nullptr;
};

#endif