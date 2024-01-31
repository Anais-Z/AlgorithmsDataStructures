// See https://aka.ms/new-console-template for more information
using AlgorithmsDataStructures.ADT;

Console.WriteLine("Hello, World!");

Pokemon squirtle = new Pokemon();

//Inserting at the End of an Array

int[] intArray = new int[10];

//ake a variable to keep the length because .Length is based of capacity and doesn't track the actual index
int length = 0;

//this adds data for us 
for(int i = 0; i < 8 ; i++)
{
    //1 is optional
    intArray[length] = i + 1;
    length++;
}

//intArray[length] = 8;
//length++;

//Inserting at the start of an array

//for(int i = 3; i >=0; i--)
//{
//    //this is moving over all the values
//    intArray[i + 1] = intArray[i];
//}

//intArray[0] = 20;

//Insert anywehre in the array
for(int i = 4; i >=2; i--)
{
    //Shift each element one position to the right
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;


//Deleting from the end of array

int[] arr = new int[9];

int theLength = 0;

for(int i = 0; i < 6; i++)
{
    arr[theLength] = i;
    theLength++;
}

//deleting from anywhere in the array
for(int i = 4; i < theLength; i++)
{
    arr[i - 1] = arr[i];
}

theLength--;

for (int i = 0; i < theLength; i++)
{
    Console.WriteLine(arr[i]);
}


//theLength--;

//deleting from beggining of an array
//for(int i =1; i < theLength; i++)
//{
//    arr[i - 1] = arr[i];
//}
//theLength--;


