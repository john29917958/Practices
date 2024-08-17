#include <iostream>
#include <fstream>
#include <sstream>

#include "functions.hpp"
#include "Minner.hpp"
#include "Transaction.hpp"

using namespace std;

void parse_tranfsaction_file(string filePath, Transaction **transArray, int &transArraySize)
{
    // use dynamic array to store transactions from transction file    
    // --------------------- student code ---------------------

    ifstream settingFile(filePath);

    string id, buyer, seller;
    double fee, coinAmount, usDollar;
    vector<Transaction> transactions;
    int numberOfTransaction = 0;

	while (settingFile >> id >> fee >> buyer >> seller >> coinAmount >> usDollar)
	{
        Transaction transaction;
        transaction.id = id;
        transaction.fee = fee;
        transaction.buyer = buyer;
        transaction.seller = seller;
        transaction.coinAmount = coinAmount;
        transaction.usDollar = usDollar;
        transactions.push_back(transaction);
        numberOfTransaction += 1;
	}

    transArraySize = numberOfTransaction;
    *transArray = new Transaction[transArraySize];    
	for (int i = 0; i < numberOfTransaction; i++)
	{
        (*transArray)[i].id = transactions.at(i).id;
        (*transArray)[i].fee = transactions.at(i).fee;
        (*transArray)[i].buyer = transactions.at(i).buyer;
        (*transArray)[i].seller = transactions.at(i).seller;
        (*transArray)[i].coinAmount = transactions.at(i).coinAmount;
        (*transArray)[i].usDollar = transactions.at(i).usDollar;
	}
    
    settingFile.close();
	
    // ===================== student code =====================
}

void parse_minner_file(string filePath, Minner **minnerArray, int &minnerArraySize)
{
    // use dynamic array to store miners from miner file
    // --------------------- student code ---------------------

    ifstream settingFile(filePath);

    int id, workType, computingPower;
    vector<Minner*> minners;
    int numberOfMinner = 0;    

    while (settingFile >> id >> workType >> computingPower)
    {
        Minner* minner = new Minner();
        minner->id = id;
        minner->workType = workType == 1 ? true : false;
        minner->computingPower = computingPower;
        minners.push_back(minner);
        numberOfMinner += 1;
    }

    minnerArraySize = numberOfMinner;
    *minnerArray = new Minner[minnerArraySize];

	for (int i = 0; i < minnerArraySize; i++)
	{
        (*minnerArray)[i].id = minners.at(i)->id;
        (*minnerArray)[i].workType = minners.at(i)->workType;
        (*minnerArray)[i].computingPower = minners.at(i)->computingPower;		
	}

    settingFile.close();
	
    // ===================== student code =====================
}


void get_minner_revenue(Minner *minner)
{
    // hint: this function can directly access private member of Miner class.
    cout << "Miner " << minner->id << "'s revenue: " << minner->revenue << endl;
}