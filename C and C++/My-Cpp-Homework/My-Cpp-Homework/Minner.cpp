#include "Minner.hpp"
#include <algorithm>

bool compareTransactions(Transaction &t1, Transaction &t2)
{
    return t1.fee < t2.fee;
}

Minner::Minner()
{
    this->revenue = 0;
    this->localTransArr = NULL;

    this->miningProcessTimer = 0;
}

Minner::~Minner()
{
    // --------------------- student code ---------------------

    // ===================== student code =====================
}

void Minner::swap_transaction(Transaction *m1, Transaction *m2) {
    Transaction tmp; 
    tmp.id = m1->id;
    tmp.fee = m1->fee;
    tmp.buyer = m1->buyer;
    tmp.seller = m1->seller;
    tmp.coinAmount = m1->coinAmount;
    tmp.usDollar = m1->usDollar;

    m1->id = m2->id;
    m1->fee = m2->fee;
    m1->buyer = m2->buyer;
    m1->seller = m2->seller;
    m1->coinAmount = m2->coinAmount;
    m1->usDollar = m2->usDollar;

    m2->id = tmp.id;
    m2->fee = tmp.fee;
    m2->buyer = tmp.buyer;
    m2->seller = tmp.seller;
    m2->coinAmount = tmp.coinAmount;
    m2->usDollar = tmp.usDollar;
}

void Minner::set_new_localTransArr(Transaction *transVec, int transVecSize)
{   
    // copy two transactions (LOCAL_TRANSVEC_SIZE) to local transaction arrays according the work type
    // hint: use deep copy method
    
    // --------------------- student code ---------------------

    if (!this->localTransArr == NULL)
    {
        delete[] this->localTransArr;    	
    }

    localTransArr = new Transaction[this->LOCAL_TRANSVEC_SIZE];

    vector<Transaction> transactions;
    for (int i = 0; i < transVecSize; i++)
    {
        transactions.push_back(transVec[i]);
    }
    std::sort(transactions.begin(), transactions.end(), compareTransactions);

    if (this->workType)
    {
        // Copies transactions with lowest fee (struct is copied by value).
        this->localTransArr[0] = transactions.at(0);
        this->localTransArr[1] = transactions.at(1);
    }
    else
    {
        // Copies transactions with highest fee (struct is copied by value).
        this->localTransArr[0] = transactions.at(transactions.size() - 1);
        this->localTransArr[1] = transactions.at(transactions.size() - 2);
    }
	
    // ===================== student code =====================
}


bool Minner::check_transactions_in_localTransArr(Transaction *completedTransArr, int completedTransArrSize)
{

    if (this->localTransArr == NULL) {
        return false;
    }

    // check if any completed transactions is in local transaction array    
    /* return
     *   true: at least one completed transaction in local transaction array
     *   false: no completed transaction in local transaction array
     */
    // hint: compare transaction id

    // --------------------- student code ---------------------

	for (int i = 0; i < LOCAL_TRANSVEC_SIZE; i++)
	{
		for (int j = 0; j < completedTransArrSize; j++)
		{
			if (this->localTransArr[i].id == completedTransArr[j].id)
			{
                return true;
			}
		}
	}

    return false;

    // ===================== student code =====================
}


void Minner::clear_localTransArr(bool changeMinnerType)
{
    /* delete clear_localTransArr, reset mining process timer
     * and change work type if changeMinnerType == true
     */
    
    // --------------------- student code ---------------------

    delete[] this->localTransArr;
    this->localTransArr = NULL;
    this->miningProcessTimer = 0;
    this->workType = changeMinnerType;

    // ===================== student code =====================
}


void Minner::get_mining_process_reward()
{
    for (int i = 0; i < Minner::LOCAL_TRANSVEC_SIZE; i++) 
        revenue += localTransArr[i].fee;
}


bool Minner::update_mining_process()
{
    // check if mining process is completed in current timestamp
    /* return
     *   true: mining process has been finished.
     *   false: ining process is running.
     */

    // --------------------- student code ---------------------

    this->miningProcessTimer += 1;
	
    if (this->miningProcessTimer % (10 - this->computingPower) == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
	
    // ===================== student code =====================
}


void Minner::set_id(int id) { this->id = id;} 
void Minner::set_workType(int workType) { this->workType = workType; }
void Minner::set_computingPower(int computingPower) { this->computingPower = computingPower; }