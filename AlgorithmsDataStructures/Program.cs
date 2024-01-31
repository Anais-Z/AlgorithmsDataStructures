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