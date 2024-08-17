#ifndef _TRANSACTION
#define _TRANSACTION

#include <iostream>
#include <string>

using namespace std;

struct Transaction
{
    string id;
    double fee;
    string buyer;
    string seller;
    double coinAmount;
    double usDollar;
};

#endif