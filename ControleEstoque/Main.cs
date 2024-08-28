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
        // Tentativa de Menu com seleção:
        Console.WriteLine(@" Menu de Opções: 
        1.Novo
        2.Listar Produtos
        3.Remover Produtos
        4.Entrada Estoque
        5.Saida Estoque
        0.Sair");
        int escolha = Convert.ToInt32(Console.ReadLine()); //Escolha do menu
        string jogo = ""; // para poder escrever o jogo
        //Games games = new Games();
        //int estoque = 0;

       switch (escolha){ // opções do menu
            case 1: // para poder adicionar um novo jogo
                Console.WriteLine("Descreva Nome do produto: ");
                jogo = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Seu jogo se chama: " + jogo);
                //jogos.Adicionar(jogo1);
                break;
            case 2: // Listar jogos
                if (!string.IsNullOrEmpty(jogo))
                {
                    Console.WriteLine("Produto cadastrado: " + jogo);
                }
                else
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                break;

            case 3: // remover jogos da lista
                Console.WriteLine("Remova produtos");
                int num3 = Convert.ToInt32(Console.ReadLine());
                break;

            case 4: // nova quantidade de pedidos no estoque
                Console.WriteLine("entrada de estoque");
                int num4 = Convert.ToInt32(Console.ReadLine());
                break;

            case 5: // Pedido saindo do estoque
                Console.WriteLine("Saida do estoque");
                int num5 = Convert.ToInt32(Console.ReadLine());
                break;

            case 0: // sair do menu
                Console.WriteLine("Sai do menu");
                int num6 = Convert.ToInt32(Console.ReadLine());
                break;
       }

       //Console.WriteLine("Numero escolhido " + escolha);
    }
}
// Irei fazer o menu em uma função separada para poder reutili-zar




    
