// See https://aka.ms/new-console-template for more information

//esercizio 1

//string[] cibiPreferiti = { "Pizza", "Lasagne", "Sushi", "Involtini pesce spada", "Minestrone", "Patate al forno"};
//int cibiPreferitiLength = cibiPreferiti.Length;
//Console.WriteLine("La lunghezza della classifica è: " + cibiPreferitiLength);
//Console.WriteLine("Classifica:");
//for (int i=0; i<cibiPreferitiLength; i++){
//    Console.WriteLine(i+1 + ") " + cibiPreferiti[i]);
//}
//Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);
//Console.WriteLine("Il mio cibo meno preferito è: " + cibiPreferiti[cibiPreferitiLength - 1]);

//if (cibiPreferitiLength % 2 == 0){
//    Console.WriteLine("Il miei cibi di mezzo sono: " + cibiPreferiti[cibiPreferitiLength/2 - 1] + " e " + cibiPreferiti[cibiPreferitiLength/2]);
//} else{
//    Console.WriteLine("Il mio cibo di mezzo è: " + cibiPreferiti[(cibiPreferitiLength - 1)/2]);
//}

//esercizio 2
//snack1
//Console.WriteLine("Inserisci due numeri:");
//int numero1 = Convert.ToInt32(Console.ReadLine());
//int numero2 = Convert.ToInt32(Console.ReadLine());
//if(numero1 > numero2){
//    Console.WriteLine("Il numero maggiore è: " + numero1);
//} else if (numero1 < numero2) {
//    Console.WriteLine("Il numero maggiore è: " + numero2);
//}
//else {
//    Console.WriteLine("I due numeri sono uguali");
//}

//snack2
//Console.WriteLine("Inserisci due parole:");
//string parola1 = Console.ReadLine();
//string parola2 = Console.ReadLine();
//if (parola1.Length > parola2.Length)
//{
//    Console.WriteLine("La parola più lunga è: " + parola1);
//    Console.WriteLine("La parola più corta è: " + parola2);
//}
//else if (parola1.Length < parola2.Length)
//{
//    Console.WriteLine("La parola più lunga è: " + parola2);
//    Console.WriteLine("La parola più corta è: " + parola1);
//}
//else
//{
//    Console.WriteLine("Le parole sono lunghe uguali");
//}

//snack3
//int somma = 0;
//for(int i=0; i<10; i++){
//    Console.WriteLine("Inserisci un numero");
//    somma += Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("La somma dei numeri inseriti è: " + somma);

//snack4
//int somma = 0;
//for (int i = 2; i < 11; i++)
//{
//    somma += i;
//}
//Console.WriteLine("La somma e la media dei numeri da 2 a 10 è: " + somma + " - " + ((float)somma/9));

//sanck5
//Console.WriteLine("Inserisci un numero");
//int numero = Convert.ToInt32(Console.ReadLine());
//if(numero%2 == 0){
//    Console.WriteLine("Il numero è: " + numero);
//} else{
//    Console.WriteLine("Il numero è: " + (numero + 1));
//}

//snack6
//string[] nomiInvitati = { "Mario", "Luigi", "Andrea", "Elena" };
//Console.WriteLine("Inserisci il tuo nome");
//string nome = Console.ReadLine();
//bool invitato = false;
//for (int i=0; i<nomiInvitati.Length; i++)
//{
//    if(nome == nomiInvitati[i])
//    {
//        invitato = true;
//    }
//}
//if (invitato)
//{
//    Console.WriteLine("Puoi entrare alla festa");
//} else
//{
//    Console.WriteLine("Non puoi entrare alla festa");
//}

//snack7
//int[] numeriDispari = new int[6];
//int index = 0;
//for(int i=0; i<numeriDispari.Length; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    if(numero%2 != 0)
//    {
//        numeriDispari[index] = numero;
//        index++;
//    }
//}

//snack8
//int[] numeri = {1,2,3,4,5,6};
//int somma = 0;
//for (int i=1; i<numeri.Length; i+=2)
//{
//    somma += numeri[i];
//}
//Console.WriteLine("La somma è: " + somma);

//snack9
//int[] numeri = new int[50];
//int somma = 0;
//while (somma < 50)
//{
//    Console.WriteLine("Inserisci un numero");
//    somma += Convert.ToInt32(Console.ReadLine());
//}

//snack10
Console.WriteLine("Inserisci un numero");
int N = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
for (int i = 0; i < N; i++)
{
    int[] array = new int[10];
    Console.WriteLine("L'array numero" + (i + 1) + "è: ");
    for (int j = 0; j < 10; j++)
    {
        array[j] = random.Next(1, 100);
        Console.Write(array[j] + "  ");
    }
    Console.WriteLine();
}