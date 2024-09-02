using System;
// Trabalho da faculdade - PTI
// Fazer o estoque de uma empresa com produtos de minhas escolha
// Declarar mais de 3 topicos para cada item, por ex: Livro= Autor, cor, e tema;
// Primeiro passo criar um menu de seleção:
// 1-Novo / 2-Listar Produtos / 3-Remover Produtos / 4-Entrada Estoque / 5-Saida Estoque / 0-Sair
// O menu precisa ser recursivo, ou seja, precisa aparecer até que seja teclado 0 ou sair
// Menu
public class Program
{
    static Jogo[] jogos = new Jogo[10];
    static int contador = 0;
    public static void Main(){
          
        while(true){
            int opcao = Menuescolhas();
            if(opcao == 0) break;
            Escolher(opcao); // Passa a escolha para o método Escolher
        }
    }
    public static void Escolher(int escolha){
        switch (escolha)
        {
            //opções do menu
            case 1: // para poder adicionar um novo jogo
                Adicionar();
                break;
            case 2: // Listar jogos
                ListarJogos();
                break;
            case 3: // remover jogos da lista
                RemoverJogo();
            //int num3 = Convert.ToInt32(Console.ReadLine());
                break;
            case 4: // nova quantidade de pedidos no estoque
                EntradaEstoque();
            //int num4 = Convert.ToInt32(Console.ReadLine());
                break;
            case 5: // Pedido saindo do estoque
                SaidaEstoque();
            //nt num5 = Convert.ToInt32(Console.ReadLine());
                break;
            case 0: // sair do menu
                return;
            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;            
        }
    }
    public static int Menuescolhas()
    {
        Console.WriteLine(@" Menu de Opções: 
        1.Novo
        2.Listar Produtos
        3.Remover Produtos
        4.Entrada Estoque
        5.Saida Estoque
        0.Sair");
        int escolha = Convert.ToInt32(Console.ReadLine()); 
        return escolha;
    }
    public static void Adicionar()
    {
        Console.WriteLine("Quantos jogos deseja adicionar?");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < quantidade; i++)
        {
            if (contador >= jogos.Length)
            {
                ExpandirVetor(); // Expande o vetor se necessário
            }
            Jogo novoJogo = new Jogo();
            Console.WriteLine("Digite o nome do jogo:");
            novoJogo.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do jogo:");
            novoJogo.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque:");
            novoJogo.Estoque = Convert.ToInt32(Console.ReadLine());
            jogos[contador] = novoJogo;
            contador++;
            Console.WriteLine("Jogo adicionado com sucesso!");
        }
    }
    public static void ListarJogos()
    {
        if (contador > 0)
        {
            Console.WriteLine("Jogos cadastrados:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Nome: " + jogos[i].Nome + " Preço: " + jogos[i].Preco + " Estoque: " + jogos[i].Estoque);
            }
        }
        else
        {
            Console.WriteLine("Nenhum jogo cadastrado.");
        }
    }
    public static void RemoverJogo()
    {
        Console.WriteLine("Digite o nome do jogo a ser removido:");
        string nome = Console.ReadLine();
        int index = -1;
        for (int i = 0; i < contador; i++)
        {
            if (jogos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                index = i;
                break;
            }
        }
        if (index >= 0)
        {
            for (int i = index; i < contador - 1; i++)
            {
                jogos[i] = jogos[i + 1];
            }
            jogos[contador - 1] = null;
            contador--;
            Console.WriteLine("Jogo removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Jogo não encontrado.");
        }
    }
    public static void EntradaEstoque()
    {
        Console.WriteLine("Digite o nome do jogo para adicionar estoque:");
        string nome = Console.ReadLine();
        Jogo jogo = null;
        for (int i = 0; i < contador; i++)
        {
            if (jogos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                jogo = jogos[i];
                break;
            }
        }
        if (jogo != null)
        {
         Console.WriteLine("Digite a quantidade para adicionar ao estoque:");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            jogo.Estoque += quantidade;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Jogo não encontrado.");
        }   
    }
    public static void SaidaEstoque()
    {
        Console.WriteLine("Digite o nome do jogo para retirar do estoque:");
        string nome = Console.ReadLine();
        Jogo jogo = null;
        for (int i = 0; i < contador; i++)
        {
            if (jogos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                jogo = jogos[i];
                break;
            }
        }
        if (jogo != null)
        {
            Console.WriteLine("Digite a quantidade para retirar do estoque:");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            if (quantidade <= jogo.Estoque)
            {
                jogo.Estoque -= quantidade;
                Console.WriteLine("Estoque atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }
        else
        {
           Console.WriteLine("Jogo não encontrado.");
        }
    }
    public static void ExpandirVetor()
    {
        Jogo[] novoArray = new Jogo[jogos.Length * 2]; // Cria um novo vetor com o dobro do tamanho
        for (int i = 0; i < jogos.Length; i++)
        {
            novoArray[i] = jogos[i]; // Copia os elementos do vetor antigo para o novo
        }
        jogos = novoArray; // Substitui o vetor antigo pelo novo
        Console.WriteLine("Capacidade do vetor expandida.");
    }

    public class Jogo 
    {
        public string Nome { get; set; } // irá pedir o nome do jogo
        public double Preco { get; set;} // irá pedir o preço do jogo
        public int Estoque { get; set;}
    }

}