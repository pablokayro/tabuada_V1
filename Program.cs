//  Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número. //

using System;

class Tabuada{
    static void Main(string[]args){
        Console.Clear();
        int i;
        Console.Write("Digite um número e veja sua tabuada: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("  SOMA    SUBTRAÇÃO    MULTIPLICAÇÃO    DIVISÃO");
        for (i=0; i<10; i++){
            int soma = n1+(i+1);
            int sub = n1 - (i+1);
            int mult = n1 * (i+1);
            double div = n1/(i+1);
            
            Console.WriteLine($"  {n1}+{i+1}={soma}     {n1}-{i+1}={sub}       {n1}x{i+1}={mult}          {n1}/{i+1}={div}");
        }
        
        
    }
}
