class BankAccount{
    constructor(acc_holder,bal){
        this.acc_holder = acc_holder
        this.bal = bal
    }
    deposit(amt){
        if (amt > 0){
            this.bal += amt
        }
        else{
            console.log(`Please Enter the Vaild Amount`)
        }
    }

    Withdraw(amt){
        if (this.bal > amt){
            this.bal -= amt
        }
        else{
            console.log(`Amount is Insufficient`)
        }
    }

    checkBalance(){
        console.log(`Your Balance is : ${this.bal}`)
    }
}

let Acc1 = new BankAccount("teja", 2000);
Acc1.deposit(1000);
Acc1.checkBalance();
Acc1.Withdraw(1000);
Acc1.checkBalance();
