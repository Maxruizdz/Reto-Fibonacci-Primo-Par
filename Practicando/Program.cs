// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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