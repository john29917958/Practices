#include <thread>
#include <mutex>
#include <iostream>

std::mutex mutext_lock;

void run_code_with_critical_section(int id)
{
    mutext_lock.lock();
    std::cout << "Worker " << id << " started." << std::endl;
    for (int i = 0; i < 100; i++)
    {
        std::cout << "Worker " << id << " prints number " << i << std::endl;
    }
    mutext_lock.unlock();
}

int main()
{
    std::thread thread1(run_code_with_critical_section, 0);
    std::thread thread2(run_code_with_critical_section, 1);

    thread1.join();
    thread2.join();

    return 0;
}