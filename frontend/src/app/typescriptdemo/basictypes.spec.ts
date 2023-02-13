describe('Declaring variables in TypeScript', () => {

    describe('Explicitely Typed Variables', () => {

        it('defining types', () => {
            let myName: string | number; // Union Type
            myName = "Jeff";
            expect(typeof myName).toEqual("string");
            expect(myName).toEqual("Jeff");
            myName = 1138;
            expect(typeof myName).toEqual("number");
            // let pet: Cat | Dog;
            // pet = { bark: () => "Woof Woof!" };
            // pet.bark();
            // pet = { meow: () => "Meowww!" };
            // pet.meow();
            // expect(typeof myName).toEqual("function");
        })

    });
    it('implicitely defined types', () => {
        let age = 52;
        let oldEnough = true;
        let name: string | number = 'Jeff';
        name = 'Sue';
        name = 1138;
    });

    describe('custom types', () => {
        it('can use types', () => {
            //type alias
            type ThingWithLettersAndStuff = string;
            let myName: ThingWithLettersAndStuff = 'Bob';

            let beer: Product = {
                sku: 'beerz',
                qty: 6,
                price: 11.99
            }
            let p2: SummaryProduct = {
                price: 8.99,
                description: 'some product'
            }
            let p3: SummaryProduct2 = {
                price: 8.99,
                description: 'stuff',
                qty: 2
            }
        });
        it('can use interfaces', () => {
            let bob: Customer = {
                name: 'Robert',
                creditLimit: 3000,
                middleName: 'M'
            }
        });
        it('can use classes', () => {
            let thisClass = new Course('Intro to Programming', 10);
            expect(thisClass.numberOfDays).toEqual(10);
            expect(thisClass.title).toEqual('Intro to Programming');

            expect(thisClass.getInfo()).toEqual('This course is Intro to Programming and is 10 days long');

            let someClass: Course;
            someClass = { //using class as data type, need all info or you get an error
                title: 'Some Title',
                numberOfDays: 18,
                getInfo: () => 'Long!'
            }
        });

    });

    describe('some literals', () => {
        it('string literals', () => {
            let name: string;
            name = "Jeff";
            expect(name).toEqual('Jeff');

            name = `Henry`;
            expect(name).toEqual('Henry');
            expect(name).toEqual("Henry");

            name = ` 
                    you can do multiline strings!
                    Like this with back ticks
                    `;

            let age = 11;
            name = 'Henry';
            expect(`The name is ${name} and he is ${age} years old`).toEqual('The name is Henry and he is 11 years old');
        });

    });
});

type Product = {
    sku: string;
    price: number;
    qty: number;
    description?: string; //allows description to be null
}

interface Customer {
    name: string;
    creditLimit: number;
}
interface Customer {
    middleName: string;
}

class Course {
    //one way to write this
    // title: string; backing fields
    // numberOfDays: number;
    // constructor(title:string, numberOfDays:number){
    //     this.title = title;
    //     this.numberOfDays = numberOfDays;
    // }
    constructor(public title: string, public numberOfDays: number) { }

    getInfo() {
        return `This course is ${this.title} and is ${this.numberOfDays} days long`;
    }
}

type SummaryProduct2 = Omit<Product, 'sku'>; //new type and it has everything except for sku
type SummaryProduct = Pick<Product, 'price' | 'description'>; // new type and it looks like product but only has price and description
//code above is the same as doing this below
// type SummaryProduct = {
//     price: number;
//     description? : string;
// }

// interface Cat {
//     meow: () => string;
// }

// interface Dog {
//     bark: () => string;
// }