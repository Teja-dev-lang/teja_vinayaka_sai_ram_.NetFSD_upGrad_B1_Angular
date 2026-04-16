class Vehicle{
    constructor(brand,speed){
        this.brand = brand
        this.speed = speed

    }
    start(){
        console.log(`Vehicle is Started`)
    }
}

class car extends Vehicle{

    constructor(brand,speed,fuelType){
        super(brand,speed)
        this.fuelType = fuelType
    }

    show_details(){
        console.log(`The New generation car of brand ${this.brand} has Maximum speed of ${this.speed} with ${this.fuelType} type Engine`)
    }
}

let c1 = new car("BMW","305","Petrol");
c1.show_details()