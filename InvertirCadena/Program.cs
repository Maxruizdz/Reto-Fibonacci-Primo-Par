Console.WriteLine("Ingrese una palabra");
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


Console.WriteLine($"Las veces que se repite la letra {a} es : {contador_2} ");



