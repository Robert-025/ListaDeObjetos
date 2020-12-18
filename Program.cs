using System;
using System.Collections.Generic;
using ListaDeObjetos.Classes;

namespace ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando lista
            List<Produto> produtos = new List<Produto>();

            //Adicionamos produtos a lista pelas instâncias com construtores
            produtos.Add(new Produto(1, "Apple Watch", 3552.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Samsung A30", 2532.78f));
            produtos.Add(new Produto(5, "Motorola G8", 1924.43f));

            //Mostrando os itens da lista
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}");
            }

            //Removendo item da lista por índice
            produtos.RemoveAt(3);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"\nRemovendo itens da lista por índice\n");

            Console.ResetColor();
            
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}");
            }

            //Removendo item da lista por atributo
            produtos.RemoveAll(x => x.Nome == "Motorola G8");
            
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"\nRemovendo itens da lista por atributo (nome, no caso)\n");
            
            Console.ResetColor();

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}");
            }
        }
    }
}
