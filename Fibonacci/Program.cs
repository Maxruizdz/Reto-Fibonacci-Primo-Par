// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int primer_numero = 0;

int segundo_numero = 0;


string resultado = "";

Console.WriteLine("Ingresar un numero");

int numero_ingresado=int.Parse(Console.ReadLine());


for (int i = 0; i < numero_ingresado; i++) {


    if (i <= 1)
    {


        segundo_numero = 1;

    }
    
        int numero_anterior = segundo_numero;
        segundo_numero = segundo_numero + primer_numero;
        primer_numero = numero_anterior;
        if (segundo_numero>=numero_ingresado) {

            if (numero_ingresado == segundo_numero)
            {


                resultado = $"El numero {numero_ingresado} es Fibonacci";
        }
        
            else resultado = $"El numero {numero_ingresado} no es Fibonacci";



            i = numero_ingresado;

        }
        
    }




Console.WriteLine(resultado);
