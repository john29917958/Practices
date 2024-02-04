#include <iostream>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <thread>

struct sockaddr_in;
bool is_ended = false;

void error(const char *msg)
{
    perror(msg);
    exit(1);
}

void run_server(int port)
{
    int sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if (sockfd < 0)
    {
        error("Error opening socket");
    }

    sockaddr_in serv_addr;
    bzero((char *)&serv_addr, sizeof(serv_addr));

    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = INADDR_ANY;
    serv_addr.sin_port = htons(port);
    if (bind(sockfd, (struct sockaddr *)&serv_addr, sizeof(serv_addr)) < 0)
    {
        error("Error on binding");
    }

    listen(sockfd, 5);
    sockaddr_in cli_addr;
    socklen_t clilen = sizeof(cli_addr);

    int newsockfd;

    while (!is_ended)
    {
        int newsockfd = accept(sockfd, (struct sockaddr *)&cli_addr, &clilen);
        if (newsockfd < 0)
        {
            error("Error on accept");
        }

        send(newsockfd, "Hello, world!\n", 13, 0);
        char buffer[256];
        bzero(buffer, 256);
        int n = read(newsockfd, buffer, 255);
        if (n < 0)
        {
            error("ERROR reading from socket");
        }

        std::cout << "got connection from " << inet_ntoa(cli_addr.sin_addr)
                  << " at port " << ntohs(cli_addr.sin_port)
                  << ": " << buffer << std::endl;
        std::cout << "Press any key to leave C++ socket server..." << std::endl;
    }

    if (newsockfd > 0)
    {
        close(newsockfd);
    }

    if (sockfd > 0)
    {
        close(sockfd);
    }
}

int main(int argc, char *argv[])
{
    int port = atoi(argv[1]);

    std::string input;
    std::thread server_t(run_server, port);
    std::cout << "Press any key to leave C++ socket server..." << std::endl;
    std::getline(std::cin, input);

    is_ended = true;

    return 0;
}
