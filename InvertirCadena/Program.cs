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


