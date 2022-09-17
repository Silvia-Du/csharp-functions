﻿// See https://aka.ms/new-console-template for more information
/*
 1- void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, 
    elemento 2, elemento 3, ...]“.

 2- int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

 3- int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. 
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

 4- int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

 5- Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, 
si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato 
(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati
  */


//1
using System;

int[] numberCollection = { 1, 3, 5, 8, 7, 8, 15, 18 };

void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length-1; i++)
    {
        
        Console.Write(array[i]+", ");
    }
        Console.Write(array[array.Length - 1]);
        Console.WriteLine("]");
}

//StampaArray(numberCollection);

//2
int exampleNumber = 10;

int Quadrato(int numero)
{
    return numero * numero;
}

//int result = Quadrato(exampleNumber);
//Console.WriteLine(result);

//3

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = (int[])array.Clone();
    for(int i=0; i< newArray.Length; i++)
    {
        newArray[i] = newArray[i] * newArray[i];
    }
    //StampaArray(newArray);
    return newArray;
}

//int[] solution = ElevaArrayAlQuadrato(numberCollection);
//Console.WriteLine(solution);

//4

int sommaElementiArray(int[] array)
{
    int sum = 0;
    foreach(int i in array)
    {
        sum += i;
    }
    return sum;
}

//int arraySum = sommaElementiArray(numberCollection);

//Console.WriteLine($"La somma degli elementi di arrayCollection è : {arraySum};");

//5 

int[] numArray = { 2, 6, 7, 5, 3, 9 };


//Stampare l’array di numeri fornito a video
void stampaAVideo(int[] array)
{

    Console.Write("Array di partenza:");
        StampaArray(array);

    int[] solution = ElevaArrayAlQuadrato(array);
    Console.Write("Array al quadrato:");
    StampaArray(solution);
    Console.Write("Verifica che il primo array sia immutato:");

    StampaArray(array);
    //Stampare la somma di tutti i numeri
    int arraySum = sommaElementiArray(array);

    Console.WriteLine($"La somma degli elementi di arrayCollection è : {arraySum};");
    //Stampare la somma di tutti i numeri elevati al quadrati
    Console.WriteLine($"La somma dei quadrati degli elementi dell'array è :{sommaElementiArray(solution)}");
}

stampaAVideo(numArray);



