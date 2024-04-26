using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares */

            int n, maxpar = 0, minimp = 0, par, imp, b = 0, bi = 0; 
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese un numero");
                 n = int.Parse(Console.ReadLine());
                if( 0 == n % 2){
                    par = n; 
                    if(b == 1){
                        if(par > maxpar){
                            maxpar = par;
                        }
                    }else{
                        maxpar = par;
                        b = 1;
                    }
                }else{
                    imp = n;
                    if(bi == 1){
                        if(imp < minimp){
                            minimp = imp;
                        }
                    }else{
                        minimp = imp;
                        bi = 1;
                    }
                }
            }
            Console.WriteLine("El maximo par es " + maxpar + " y el minimo impar es " + minimp);
        }
    }
}
