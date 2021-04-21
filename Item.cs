using System;

  public class Item{

    public string Nome;
    public string Desc;
    public string Categoria;
    public int Valor;
    public int Quantidade;
    

    public Item(string nome, string desc, int valor, int quantidade, string categoria){
      this.Nome = nome;
      this.Desc = desc;
      this.Valor = valor;
      this.Quantidade = quantidade;
      this.Categoria = categoria;
    }

    public void ImprimirItem(){
      Console.WriteLine("Nome:\t\t{0}", this.Nome);
      Console.WriteLine("Categoria:\t{0}", this.Categoria);
      Console.WriteLine("Valor:\t\t{0}", this.Valor);
      Console.WriteLine("Quantidade:\t{0}", this.Quantidade);
      Console.WriteLine("Descrição:\t{0}", this.Desc);
      
      Console.WriteLine("-----------------------------------------");

    }

  }