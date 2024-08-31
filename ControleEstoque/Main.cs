using System;
// Trabalho da faculdade - PTI
// Fazer o estoque de uma empresa com produtos de minhas escolha
// Declarar mais de 3 topicos para cada item, por ex: Livro= Autor, cor, e tema;
// Primeiro passo criar um menu de seleção:
// 1-Novo / 2-Listar Produtos / 3-Remover Produtos / 4-Entrada Estoque / 5-Saida Estoque / 0-Sair
// O menu precisa ser recursivo, ou seja, precisa aparecer até que seja teclado 0 ou sair
// Menu
public class Program{ 
    // Coleta de dados
    // Processamento de Dados
    // Saida de dados
    public static void Main(){
        while(true){
            int opcao = Menuescolhas();
            if(opcao == 0) break;
            Escolher(opcao); // Passa a escolha para o método Escolher
            Console.WriteLine("Deu certo, continue tentando");
        }
    }

    public static int Menuescolhas(){
        Console.WriteLine(@" Menu de Opções: 
        1.Novo
        2.Listar Produtos
        3.Remover Produtos
        4.Entrada Estoque
        5.Saida Estoque
        0.Sair");
        int escolha = Convert.ToInt32(Console.ReadLine()); 
        return escolha;
        //string jogo = "";
        //Escolha do menu 
        // para poder escrever o jogo
        //int estoque = 0;
    }

    public static void Escolher(int escolha){
        switch (escolha)
        {
            //opções do menu
            case 1: // para poder adicionar um novo jogo
                string jogo = Joguinho();
                break;
            case 2: // Listar jogos
                //if (!string.IsNullOrEmpty(game))
                //{
                Console.WriteLine("Produto cadastrado: ");
                //}
                //else
                //{
                //Console.WriteLine("Nenhum produto cadastrado.");
                //}
                break;
            case 3: // remover jogos da lista
                Console.WriteLine("Remova produtos");
                //int num3 = Convert.ToInt32(Console.ReadLine());
                break;

            case 4: // nova quantidade de pedidos no estoque
                Console.WriteLine("entrada de estoque");
                //int num4 = Convert.ToInt32(Console.ReadLine());
                break;

            case 5: // Pedido saindo do estoque
                Console.WriteLine("Saida do estoque");
                //nt num5 = Convert.ToInt32(Console.ReadLine());
                break;

            case 0: // sair do menu
                return;

            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;            
        }
        
    }
    public static string Joguinho (){
        Console.WriteLine("descreva o nome do jogo:");
        string game = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Seu jogo se chama: " + game);
        return game;
        //public string Nome { get; set; } // irá pedir o nome do jogo
        //public double Preco { get; set;} // irá pedir o preço do jogo
        //public int estoque { get; set;} //  irá pedir o numero em estoque do jogo
    }
}