using System;
namespace CursoClasseObjeto
{
    public class Calculadora
    {
        public int valor1;
        public int valor2;
        public int total;

        public void inserirDados()
        {
            Console.WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void mostrarResultado(){
            Console.WriteLine("O total da operação é: " + total);
        }
        
        public int somar(int valor01, int valor02)
        {
            return total = valor01 + valor02;
        }

        public void subtrair()
        {
            total = valor1 - valor2;
        }

        public void dividir()
        {
            total = valor1 / valor2;
        }

          public void multiplicar()
        {
            total = valor1 * valor2;
        }
        
    }
}