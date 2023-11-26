// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Encontrar el numero mas alto de un grupo de numero
List<int> list = new List<int>();
list.Add(130);
list.Add(4);
list.Add(20);
list.Add(14);
list.Add(12);
list.Add(100);
int numero_mayor = 0;


foreach (int i in list) {


    if (i > numero_mayor)
    {
        numero_mayor = i;

    }


}

Console.WriteLine($"El numero mayor de la lista es {numero_mayor}");

 */

//Reversa una cadena 
/*
string palabra = "casa";

char[] chars = palabra.ToCharArray();

Array.Reverse(chars);

string palabra_inver= new string(chars);


Console.WriteLine(palabra_inver); 
*/
/*Ejercicio 3: Verificar Palíndromos

string palabra = "Neuquen";
palabra =palabra.Trim();
 char [] caracter = palabra.ToCharArray(); 
Array.Reverse(caracter);
string palabra2 = new string(caracter);


if (string.Compare(palabra, palabra2, StringComparison.OrdinalIgnoreCase)==0) {

    Console.WriteLine($"La palabra {palabra} es un palindromo");

}
else Console.WriteLine($"La palabra {palabra} no es palindromo");*/

List<int> listaConDuplicados = new List<int> { 3, 7, 9, 4, 6, 8, 2, 1, 5};
int cont = 0;
bool repetido=false;



foreach (var item in listaConDuplicados)
{

    int numero = listaConDuplicados.Where(p=> p==item).Count();

    if (numero >1) {
    repetido=true;
    
    
    }
   
}




if (repetido == true)
{

    Console.WriteLine("La lista tiene elementos repetidos");

}
else {
    Console.WriteLine("La lista no tiene elementos repetidos");

}