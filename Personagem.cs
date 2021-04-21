using System;
using System.Collections.Generic;

public class Personagem {
   public string Nome;
   public int Moedas;
   public List<Item> Inventario;
   public int pedido;
   public int custo;
   public int confirmar;

   public Personagem(){
     this.Moedas = 100;
     this.Inventario = new List<Item>();
   }

   public void ImprimirPersonagem(){
     Console.WriteLine("Nome:\t\t{0}", this.Nome);
     Console.WriteLine("Moedas:\t\t{0}", this.Moedas);

     Console.Write("Inventário:\t [", this.Inventario);
     foreach(var item in Inventario){
       Console.Write("{0}\t", item.Nome);
     }
     Console.WriteLine("]");

     Console.WriteLine("-----------------------------------------");

   }

   public void Comprar(Item item){
     Console.WriteLine("Quantos(as) você quer ?");
      pedido = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("-----------------------------------------");
    if(item.Quantidade >= this.pedido){
          this.custo = item.Valor * this.pedido;

          Console.Write("Ira custar ");
          Console.Write(this.custo);
          Console.WriteLine(" moedas de ouro, vai querer ?");
          Console.WriteLine("[1] - Sim");
          Console.WriteLine("[2] - Não");
          confirmar = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("-----------------------------------------");

          if(confirmar == 1){
      
      if(this.Moedas >= this.custo){
        this.Moedas = this.Moedas - this.custo;
        item.Quantidade = item.Quantidade - this.pedido;

        while(this.pedido > 0){
        this.Inventario.Add(item);
         this.pedido -=1;
        }
        Console.WriteLine("obrigado! Vai querer mais alguma coisa ?");
        Console.WriteLine("-----------------------------------------");
      }
      else{
       Console.WriteLine("Você não tem dinheiro suficiente!!");
       Console.WriteLine("-----------------------------------------");
      }
     
    }else if(confirmar == 2){
      Console.WriteLine("o que deseja então ?");
      Console.WriteLine("-----------------------------------------");
    }

    else if(confirmar > 2){
      Console.WriteLine("Não temos essa opção");
      Console.WriteLine("-----------------------------------------");
    }

    }
    else{
      Console.WriteLine("Não temos no estoque, me desculpe.");
      Console.WriteLine("-----------------------------------------");
    }

   }


}