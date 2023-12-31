﻿//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.Write("inserisci il primo numero:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("inserisci il secondo numero:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"il numero piu' alto e' {num1}");
}
else if (num1 < num2)
{
    Console.WriteLine($"il numero piu' alto e' {num2}");
}
else
{
    Console.WriteLine("i numeri sono uguali");
}


//Snack 2 : L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.
Console.WriteLine();

Console.Write("inserisci la prima parola: ");
string word1 = Console.ReadLine();

Console.Write("inserisci la seconda parola: ");
string word2 = Console.ReadLine();

if (word1.Length < word2.Length)
{
    Console.WriteLine(word1 + " " + word2);
}
else if (word1.Length > word2.Length)
{
    Console.WriteLine(word2 + " " + word1);
}
else
{
    Console.WriteLine("Le due parole hanno la stessa lunghezza");
}


//Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.
Console.WriteLine();

int sumSnack3 = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("inserisci un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    sumSnack3 += num;
}

Console.WriteLine($"la somma dei numeri e': {sumSnack3}");


//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
Console.WriteLine();


int sumSnack4 = 0;
for (int i = 2; i <= 10; i++)
{
    sumSnack4 += i;
}

float mediaSnack4 = (float)sumSnack4 / 9;

Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sumSnack4}");
Console.WriteLine($"La media dei numeri da 2 a 10 è: {mediaSnack4}");


//Snack 5: Il software chiede all’utente di inserire un numero.
//Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.WriteLine();

Console.Write("Inserisci un numero: ");
int numSnack5 = Convert.ToInt32(Console.ReadLine());

if (numSnack5 % 2 == 0)
{
    Console.WriteLine($"{numSnack5}: è un numero pari");
}
else
{
    Console.WriteLine($"{numSnack5} è un numero dispari qundi voglio che diventi: {numSnack5 + 1}");
}

//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

Console.WriteLine();

string[] amiciDiGatsby = { "Diego", "Leonardo", "Josephine", "Franco", "Giuditta" };

bool[] invitati = { true, false, true, false, false };

Console.Write("Come ti chiami? ");
string persona = Console.ReadLine();

int index = Array.IndexOf(amiciDiGatsby, persona);
if (index != -1 && invitati[index])
{
    Console.WriteLine($"Benvenuto/a alla festa, {persona}! ");
}

else
{
    Console.WriteLine($"{persona}, non sei in lista...");
}

//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

Console.WriteLine();

List<int> arrayDaRiempire = new List<int>();

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine("inserisci un numero: ");
    int numSnack7 = Convert.ToInt32(Console.ReadLine());

    if (numSnack7 % 2 != 0)
    {
        arrayDaRiempire.Add(numSnack7);
    }
}

Console.Write("I numeri dispari sono: ");
foreach (int numSnack7 in arrayDaRiempire)
{
    Console.Write($"{numSnack7} ");
}


//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

Console.WriteLine();

int[] numSnack8 = { 10, 20, 30, 40, 50 };
int sumSnack8 = 0;

for (int i = 0; i < numSnack8.Length; i++)
{
    if (i % 2 != 0)
        sumSnack8 += numSnack8[i];
}

Console.WriteLine($"La somma degli elementi in posizione dispari è: {sumSnack8}");

//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

Console.WriteLine();

List<int> arrayDaRiempire2 = new List<int>();

int sumSnack9 = 0;

while (sumSnack9 < 50)
{
    Console.WriteLine("Inserisci un numero: ");

    int numSnack9 = Convert.ToInt32(Console.ReadLine());
    arrayDaRiempire2.Add(numSnack9);
    sumSnack9 += numSnack9;
}
if (sumSnack9 > 50)
{
    Console.WriteLine($"Hai sforato il numero 50 e la somma è {sumSnack9}");
}

else
{
    Console.Write("i numeri scelti sono: ");
    foreach (int num in arrayDaRiempire2)
    {
        Console.Write($"{num} ");
    }

    Console.WriteLine($"Ed il totale e' {sumSnack9}");
}

//Snack 10: Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine();

Console.WriteLine("Quanti array vuoi creare?: ");
int N = Convert.ToInt32(Console.ReadLine());

Random randomNum = new Random();

for (int i = 0; i < N; i++)
{
    //creo n array composti da 10 numeri casuali da 1 a 100
    int[] arrSnack10 = new int[10];
    for (int j = 0; j < arrSnack10.Length; j++)
    {
        arrSnack10[j] = randomNum.Next(1, 101);
    }

    //stampo a schermo la lista degli array
    Console.WriteLine("Array numero {0}: [{1}]", i + 1, string.Join(", ", arrSnack10));
}