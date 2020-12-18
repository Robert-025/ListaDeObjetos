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

            System.Threading.Thread.Sleep(7000);

            Console.WriteLine($"\nLista de cartões");

            List<Cartao> ct = new List<Cartao>();

            ct.Add(new Cartao("Robert Sena", 1234, "Visa", 123));
            ct.Add(new Cartao("Lucas Dias", 4321, "MasterCard", 321));

            foreach (Cartao item in ct)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Titular:{item.Titular} \nNúmero:{item.Numero} \nBandeira:{item.Bandeira} \nCVV:{item.Cvv}\n\n");
                
                Console.ResetColor();
            }
        }
    }
}
