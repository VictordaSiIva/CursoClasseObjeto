using System;
namespace CursoClasseObjeto
{
    public class Celular
    {
      public string cor;
      public double altura;
      public double largura;
      public string modelo;       

      public Celular(string cor, double altura, double largura, string modelo)
      {
        this.cor = cor;
        this.altura = altura;
        this.largura = largura;
        this.modelo = modelo;
      }

      public Celular(){

      }

      public Celular(string cor){
        this.cor = cor;
      }

      public void fazerChamada(int numero) {
          Console.WriteLine("fazendo chamada para o numero: " 
          + numero);
      }

      public virtual void dispararAlarme()
      {
        Console.WriteLine("Disparando alarme...");
      }

    }
}