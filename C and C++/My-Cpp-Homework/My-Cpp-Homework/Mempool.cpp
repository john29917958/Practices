#include "Mempool.hpp"
#include "Transaction.hpp"

bool compareTransactions(Transaction *t1, Transaction *t2)
{
    return t1->fee < t2->fee;
}

Mempool::Mempool(){}

Mempool::~Mempool()
{
    // --------------------- student code ---------------------

    // ===================== student code =====================
}

Mempool::Mempool(Transaction **transArray, int transArraySize, Minner **minnerArray, int minnerArraySize)
{
    this->transArray = transArray;
    this->transArraySize = transArraySize;
    this->minnerArray = minnerArray;
    this->minnerArraySize = minnerArraySize;    

    // initialize each local transaction array (array's size is LOCAL_TRANSVEC_SIZE variable) of each miner
    // --------------------- student code ---------------------
    
    for (int i = 0; i < this->minnerArraySize; i++)
    {
        (*this->minnerArray)[i].set_new_localTransArr(*this->transArray, this->transArraySize);        
    }
	
    // ===================== student code =====================
   
}

void Mempool::delete_specific_transections(Transaction *completedTransArray, int completedTransArraySize)
{
    // delete completed transaction records in Mempool
    // hint: can use deep copy method to replace old transArray
    // --------------------- student code ---------------------

    vector<Transaction> transactions;

	for (int i = 0; i < this->transArraySize; i++)
	{
        transactions.push_back((*this->transArray)[i]);
	}

	for (int i = 0; i < completedTransArraySize; i++)
	{
        int counter = 0;
		
        for (vector<Transaction>::iterator it = transactions.begin(); it != transactions.end(); ++it)
        {
            if ((*it).id == completedTransArray[i].id)
            {
                transactions.erase(it);
                break;
            }
        }
	}

    delete[] * this->transArray;
    this->transArraySize = transactions.size();    
    *this->transArray = new Transaction[this->transArraySize];

	for (int i = 0; i < this->transArraySize; i++)
	{
        Transaction tt = transactions.at(i);
        (*this->transArray)[i] = transactions.at(i);
	}

    // ===================== student code =====================
}


void Mempool::notify_other_minners(Minner *finishedMinner)
{
    /*
     * notify other miners, 
       stop miners that mine completed transactions 
       and delete completed transactions in mempool
     */   
    // --------------------- student code ---------------------

    vector<Minner*> stoppedMinners;

    Transaction* finishedTransactions = new Transaction[finishedMinner->LOCAL_TRANSVEC_SIZE];
    for (int i = 0; i < finishedMinner->LOCAL_TRANSVEC_SIZE; i++)
    {
        finishedTransactions[i] = finishedMinner->localTransArr[i];
    }
	
    for (int i = 0; i < this->minnerArraySize; i++)
    {
        Minner* minner = &(*this->minnerArray)[i];
        if (minner->check_transactions_in_localTransArr(finishedMinner->localTransArr, finishedMinner->LOCAL_TRANSVEC_SIZE))
        {
            stoppedMinners.push_back(minner);
            minner->clear_localTransArr(!minner->workType);
        }
    }

    this->delete_specific_transections(finishedTransactions, finishedMinner->LOCAL_TRANSVEC_SIZE);
	
    for (int i = 0; i < stoppedMinners.size(); i++)
    {
        stoppedMinners.at(i)->set_new_localTransArr(*this->transArray, this->transArraySize);
    }

    // ===================== student code =====================
}


void Mempool::update_block_chain()
{   
    // update all miners and check if any miner need to get new local transaction array
    // --------------------- student code ---------------------

	for (int i = 0; i < this->minnerArraySize; i++)
	{
        Minner *minner = &(*this->minnerArray)[i];
        
        if (!minner->update_mining_process())
        {
	        continue;
        }

        minner->get_mining_process_reward();
        this->notify_other_minners(minner);
	}

    // ===================== student code =====================
}