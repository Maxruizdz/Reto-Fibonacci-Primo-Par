using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Par_Fibo_impar
{
    public static class Reto_Calculos
    {

        public static string Comprobacion_Par_Fibo_Primo(int numero) 
        {
            string resultado = "";
            if (numero > 1) {
                for (int i = 2; i < numero; i++) {

                    if (numero%i==0) {

                        resultado += $" El numero {numero} no es primo,";
                        break;
                    
                    }
                }
                if (string.IsNullOrEmpty(resultado)) {

                    resultado += $" El numero {numero} es primo";


                } }



            if (numero % 2 == 0)
            {

                resultado += " es par ";

            }
            else resultado += " es impar ";



            if (is_perfect_squared(5 * numero * numero * 4) || is_perfect_squared(5 * numero * numero - 4))
            {

                resultado += "y es Fibonacci";


            }
            else resultado += "y no es fibonacci";


            return resultado;





        }


        public static Boolean is_perfect_squared(int numeros) {

            int sqrt = (int)Math.Sqrt(numeros);



            return sqrt * sqrt == numeros;
        
        
        
        }

    }
}
