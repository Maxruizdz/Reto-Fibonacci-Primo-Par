

for (int i = 1; i <= 100; i++) {
    string resultado = "";
    if (i % 3 == 0) {


        resultado += "Fizz";
    
    
    }
    if (i % 5 == 0) {

        resultado += "Buzz";


    }

    if (string.IsNullOrWhiteSpace(resultado)) {
    
    resultado = i.ToString();
    
    }


    Console.WriteLine(resultado);

}