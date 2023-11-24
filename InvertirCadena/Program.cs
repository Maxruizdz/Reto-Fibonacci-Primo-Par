/*Console.WriteLine("Ingrese una palabra");
string palabra = Console.ReadLine();
string palabra_invertida = "";
string palabra_invertida_met2 = "";





for (int i = palabra.Length-1; i >= 0; i--) {

    palabra_invertida += palabra[i];


}


Console.WriteLine("Palabra Invertida, Metodo 1: " +"\n" + palabra_invertida);



char[] chars = palabra.ToCharArray();
Array.Reverse(chars);
palabra_invertida_met2= new string(chars);
Console.WriteLine("Palabra Invertida, Metodo 2: " + "\n" + palabra_invertida_met2);


//Contar Palabras 
int contador_palabra = 0;

Console.WriteLine("Ingrese el caracter que desea saber cuantas veces se repite");
char a =char.Parse(Console.ReadLine());




foreach (var pala in palabra) {


    if (pala == a) {
        contador_palabra++;
    
    
    }



}



Console.WriteLine($"Las veces que se repite la letra {a} es : {contador_palabra} ");

//METODO 2
int contador_2= palabra.Where(x => x == a).Count();


Console.WriteLine($"Las veces que se repite la letra {a} es : {contador_2} ");*/



//Distancia de Hamming 
/*
Console.WriteLine("Ingrese la primer cadena");
string primer_palabra= Console.ReadLine();
Console.WriteLine("Ingrese la segunda cadena");
string segunda_palabra = Console.ReadLine();
if (primer_palabra.Length!= segunda_palabra.Length) {

    throw new Exception("La cantidad de longitudes varian entre las dos cadenas");



}

int distancia = 0;

for (int i = 0; i < primer_palabra.Length; i++)
{
    if (primer_palabra[i]!= segunda_palabra[i]) {
        distancia++;
    
    
    }
}




Console.WriteLine($"La distancia es de {distancia}");
*/

//Contador de palabras


using System.Text.RegularExpressions;
/*
string texto = "Holaaaa      Buenas mi nombre    es Maximiliano              ";
texto = texto.Trim();
var words =Regex.Replace(texto,@"\s+", " ").Split(' ');   

int numero_dePalabras=words.Length;
Console.WriteLine("Ingrese la palabra que quieres saber si se encuentra en el texto");
string palabra_existente=Console.ReadLine();
bool palabra_encontrada=false;


foreach (var palabra in words) {

    if (palabra_existente == palabra_existente) { 
        palabra_encontrada = true;
    
    } 


}

Console.WriteLine($"El numero de palabras es de {numero_dePalabras} ");




if (palabra_encontrada == true) {

    Console.WriteLine($"La palabra {palabra_existente} se encuentra en el texto");

}

*/


//Contador de numeros en una cadena



string texto = "asdaf5895sdfdf 65484564a";


string patron = @"[1-9]";

string patron2 = @"[A-Za-z]";



var regex= new Regex(patron);
var regex2 = new Regex(patron2);


int cantidad_numero= regex.Matches(texto).Count;

int cantidad_de_letras= regex2.Matches(texto).Count;



Console.WriteLine($"La Cantidad de letras es de: {cantidad_de_letras}");


Console.WriteLine($"La cantidad de numero es de: {cantidad_numero}");










