
List<int> lista_numeros = new List<int>() {77, 1,2,3,4,55,66,21,6};







for (int i = 0; i < lista_numeros.Count-1; i++)
{

    for (int j = 0; j < lista_numeros.Count -1; j++) {



        if (lista_numeros[j] > lista_numeros[j+1]) {

            int numero_mayor = lista_numeros[j];
            lista_numeros[j] = lista_numeros[j+1];
            lista_numeros[j+1]=numero_mayor;
        
        
        
        }
    
    
    }


}

foreach (var num in lista_numeros) {
    Console.WriteLine(num);
}

