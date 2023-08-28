### Setup Instructions

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "ShapeTracker".
3. In the command line, run the command "dotnet run" to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
4. Optionally, you can run "dotnet build" to compile this console app without running it.



### class
a template for creating objects of a specific type. In this way, a class groups related functionality into one unit (a template or blueprint) that can be used again and again to create a specific type of object.

### namespace 

a grouping of related classes based on their importance or function.

ascii banner generator: https://manytools.org/hacker-tools/ascii-banner/


### Project Template
ProjectName.Solution/
  ├── ProjectName/
  │     ├── Models/
  |     |     ├── ClassName.cs
  |     |     ├── ClassName.cs
  │     │     └── ClassName.cs
  |     ├── UserInterfaceModels/
  |     |     └── ClassName.cs
  │     ├── ProjectName.csproj
  │     └── Program.cs
  ├── .gitignore
  └── README.md


function hideElement(elementID){
  document.getElement(elementID).setAttribute(class, hidden);
}

-> hideElement(div1);

//car 
 const name = "Volkswagon";
 const model = "jetta";
 const year = 2014;

console.log("your car's make and model is ", name, model);

function b(number){
  return number + 1;
}

let currentPosition = 50;

const afterDrivingPosition = drive(currentPosition);

console.log(
  " Your make is ${make} ... you started at ${current} and you drove to (afterDrivingPosition)"
);

class Volkswagon{
  constructor(make, model, year){
    this.make =make;
    this.model = model;
    this.year = year;
    this.currentPosition=0;
  }

  drive(){
    this.currentPosition++;
  }
}



const myCar = new Volkswagon("Scion", "xD", 2014);

myCar.drive();

myCar.currentPosition === 1 //true




 

const number;
const letter;

console.log(number);

Array vs List

Arrays -> array[4];


const myArray = ["dogs", "cats"];

myArray[1]; -> (memoryAddressofFirstElement + 1);



List<Triangle>

- all element are stored randomly


{
  data: "dogs",
  next: *node 
}



{ [][][][] }


{
  ["dog"]
  next: location of next element;
}


const myArr = ["DOG", "CATS"]

1. myArr[1] = "";

["DOG", ""];



memory location: dogHouse  

catHouse
{
  "cat",
  next: birdHouse;
}

birdHouse
{
  "bird",
  next: NULL
}

CAT -> BIRD

myAnimalsList.Length === 2


memory location: catHouse {"}









myArray[1] = '';

myArray = ["dogs", ''];




array[1] = '';




