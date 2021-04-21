using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Personagem personagem = new Personagem();
    int escolha = 0;
    string produto;
    List<Item> catalogo = new List<Item>();
    
    Item espada = new Item("Espada Carmesin", "espada com lamina avermelhada", 25, 5, "Espada");
    catalogo.Add(espada);    
    Item machado = new Item("Machado de Batalha", "Machado grande de duas mãos", 30, 2,"Machado de duas mãos");
    catalogo.Add(machado);
    Item livro = new Item("Livro de feitiços", "Livro para magos de níveis baixos", 20, 3, "Livros Mágicos");
    catalogo.Add(livro);
    Item pvida = new Item("Poção de vida", "Poção simples para restauração de pouca vida", 5, 25, "Poções");
    catalogo.Add(pvida);

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Vendedor: Seja bem vindo à minha loja!");
    Console.WriteLine("Vendedor: Qual o seu nome viajante ?");
    personagem.Nome = Console.ReadLine();

    Console.Write("\nVendedor Então, ");
    Console.Write(personagem.Nome);
    Console.WriteLine(" O que deseja ?");
    Console.WriteLine("-----------------------------------------");

  do{
    Console.WriteLine("[1] - Olhar Catálogo");
    Console.WriteLine("[2] - Comprar Item");
    Console.WriteLine("[3] - Olhar Inventário");
    Console.WriteLine("[0] - Sair");
    escolha = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-----------------------------------------");

    if( escolha == 1){
      foreach(var i in catalogo){
        i.ImprimirItem();
      }

    } else if(escolha == 2){
      Console.WriteLine("Digite o nome do produto que deseja: ");
      produto = Console.ReadLine();
      Console.WriteLine("-----------------------------------------");
        if(produto.Equals("Espada Carmesin", StringComparison.OrdinalIgnoreCase)){
          personagem.Comprar(espada);
        }
        if(produto.Equals("Machado de Batalha", StringComparison.OrdinalIgnoreCase)){
          personagem.Comprar(machado);
        }
        if(produto.Equals("Livro de feitiços", StringComparison.OrdinalIgnoreCase)){
          personagem.Comprar(livro);
        }
        if(produto.Equals("Poção de vida", StringComparison.OrdinalIgnoreCase)){
          personagem.Comprar(pvida);
        }
      

    }else if(escolha == 3){
      personagem.ImprimirPersonagem(); 

    }else if (escolha > 3){
      Console.WriteLine("\nOpção inválida!");
      Console.WriteLine("\n-----------------------------------------");
    }
  } while(escolha !=0);

  }
}