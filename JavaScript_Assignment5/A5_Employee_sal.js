class Employee {
    constructor(name, sal) {
        this.name = name
        this.sal = sal
    }

    getDetails() {
        console.log(`${this.name} is a Employee with Base Salary of ${this.sal}`);
    }
}

class Manager extends Employee {
    constructor(name, sal, bonus) {
        super(name, sal)
        this.bonus = bonus
    }

    getTotalSalary() {
        console.log(`The Total Salary is ${this.sal + this.bonus}`)
    }
}

class Director extends Manager{
    constructor(name,sal,bonus,stockOptions){
        super(name,sal,bonus)
        this.stockOptions = stockOptions
    }

    getFullCompensation(){
        console.log(`The Full Compenstion : Base Salary is ${this.sal} and with Bonus ${this.bonus} along with Stocks value of ${this.stockOptions}`)
    }
}

let emp1 = new Employee("Teja",20000);
emp1.getDetails();

let emp2 = new Director("Shivram",50000,2000,10000);
emp2.getDetails();
emp2.getFullCompensation()
emp2.getTotalSalary()