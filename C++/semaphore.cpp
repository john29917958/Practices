#include <semaphore>
#include <thread>
#include <iostream>

std::binary_semaphore semaphore_main_to_worker(0);
std::binary_semaphore semaphore_worker_to_main(0);

void worker()
{
    semaphore_main_to_worker.acquire();
    std::cout << "Worker got the signal" << std::endl;
    using namespace std::literals;
    std::this_thread::sleep_for(3s);
    std::cout << "Worker sends the signal" << std::endl;
    semaphore_worker_to_main.release();
}

int main()
{
    std::thread the_worker(worker);
    std::cout << "Main thread sends the signal" << std::endl;
    semaphore_main_to_worker.release();
    semaphore_worker_to_main.acquire();
    std::cout << "Main thread got the signal" << std::endl;
    the_worker.join();

    return 0;
}