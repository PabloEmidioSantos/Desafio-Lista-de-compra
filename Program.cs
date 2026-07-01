// See https://aka.ms/new-console-template for more information

using System;
public class Program
{

//Sem essa porra nada funciona, não guilherme não usei IA, to com dor de cbç só de pensar em fazer os outros metodos
    class Item
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Valor { get; set; }
        }


//Colocar um novo item pq o imbecil do user é um imbecil 
    static void AdicionarItem(List<Item> lista)
        {
            Item item = new Item();

            Console.Write("Id: ");
            item.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            item.Nome = Console.ReadLine();

            Console.Write("Valor: ");
            item.Valor = double.Parse(Console.ReadLine());
                if (item.Valor < 0)
                {
                    Console.WriteLine("Valor inválido. O valor não pode ser negativo.");
                    return;
                }

            lista.Add(item);

            Console.WriteLine("Item adicionado com sucesso!");
        }

    static void ListarItens(List<Item> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }

            foreach (Item item in lista)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} - R$ {item.Valor}");
            }
        }

//Pra remover a porra do item pq o acéfalo do user é um imbecil
    static void RemoverItem(List<Item> lista)
        {
            Console.Write("Digite o Id do item: ");
            int id = int.Parse(Console.ReadLine());

            Item item = lista.Find(i => i.Id == id);

            if (item != null)
            {
                lista.Remove(item);
                Console.WriteLine("Item removido.");
            }
            else
            {
                Console.WriteLine("Item não encontrado.");
            }
        }

//Pq vc ta lendo isso?
//Essa parte calcula o total energumeno, se sou eu que to lendo saiba, VC É UM CORNOOOOOOOO HAHAHAHHAHAHAHAHHAHAHHAHAHAHHAHAHAHAHAHAHHAHAHAHAHHAHAHHAHAHAHHAHAHA
    static double CalcularTotal(List<Item> lista)
        {
            double total = 0;

            foreach (Item item in lista)
            {
                total += item.Valor;
            }

            return total;
        }

    static void EditarItem(List<Item> lista)
    {
        System.Console.WriteLine("Digite o ID do produto que desejar Editar");
        int id = int.Parse(Console.ReadLine());

        Item item = lista.Find(i => i.Id == id);
        if (item != null)
        {
            Console.Write("Novo Nome: ");
            item.Nome = Console.ReadLine();

            Console.Write("Novo Valor: ");
            item.Valor = double.Parse(Console.ReadLine());
                if (item.Valor < 0)
                {
                    Console.WriteLine("Valor inválido. O valor não pode ser negativo.");
                    return;
                }

            Console.WriteLine("Item editado com sucesso!");
        }
        else
        {
            Console.WriteLine("Item não encontrado.");
        }
        
    }










    public static void Main(string[] args)
    {
        List<Item> lista_compras = new List<Item>();
        string tipoProduto;
        bool eOadmin = false;

        Console.Write("Você é administrador? (s/n): ");
    string resposta = Console.ReadLine();

        if (resposta.ToLower() == "s")
        {
            eOadmin = true;
        }

    while (true)
    {
        Console.Clear();
        Console.WriteLine("===== MERCADINHO =====");

        Console.WriteLine("Você é o admin?");

        //Se for a porra do ADM do game ele pode fazer tudo, se for o user ele só pode ver os produtos e o valor total, pq o user é um imbecil q n pode fz nd
        if (eOadmin)
        {
            string senha_do_zika_do_adm = Environment.GetEnvironmentVariable("SENHA_DO_ZIKA_DO_ADM");

            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            
            Console.WriteLine("3 - Editar Produto");
            Console.WriteLine("4 - Remover Produto");
            Console.WriteLine("5 - Valor Total");
            Console.WriteLine("0 - Sair");
        }
        else
        {
            Console.WriteLine("1 - Ver Produtos");
            Console.WriteLine("2 - Valor Total");
            Console.WriteLine("3 - Adicionar ao Carrinho");
            Console.WriteLine("0 - Sair");
        }


        string opcao = Console.ReadLine();

        if (eOadmin)
        {
            switch (opcao)
            {
                case "1":
                    AdicionarItem(lista_compras);
                    break;

                case "2":
                    ListarItens(lista_compras);
                    break;

                case "3":
                    EditarItem(lista_compras);
                    break;

                case "4":
                    RemoverItem(lista_compras);
                    break;

                case "5":
                    Console.WriteLine($"Total: R$ {CalcularTotal(lista_compras):F2}");
                    break;

                case "0":
                    return;
            }
        }
        else
        {
            switch (opcao)
            {
                case "1":
                    ListarItens(lista_compras);
                    break;

                case "2":
                    Console.WriteLine($"Total: R$ {CalcularTotal(lista_compras):F2}");
                    break;

                case "0":
                    return;
            }
        }

                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();



        }
    }
}

