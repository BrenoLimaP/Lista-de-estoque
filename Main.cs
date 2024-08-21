using System;
// Trabalho da faculdade - PTI
// Fazer o estoque de uma empresa com produtos de minhas escolha
// Declarar mais de 3 topicos para cada item, por ex: Livro= Autor, cor, e tema;


// Primeiro passo criar um menu de seleção:
// 1-Novo / 2-Listar Produtos / 3-Remover Produtos / 4-Entrada Estoque / 5-Saida Estoque / 0-Sair
// O menu precisa ser recursivo, ou seja, precisa aparecer até que seja teclado 0 ou sair

// Menu
class Program{  
    // Coleta de dados
    // Processamento de Dados
    // Saida de dados
    static void Main(){
        Console.WriteLine(@" Menu de Opções: 
        1.Novo
        2.Listar Produtos
        3.Remover Produtos
        4.Entrada Estoque
        5.Saida Estoque
        0.Sair");
        int escolha = Convert.ToInt32(Console.ReadLine()); 
        //int estoque = 0;

       switch (escolha){
            case 1:
                Console.WriteLine("Descreva Nome do produto: ");
                string produto = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Seu produto se chama: " + produto);
                break;
            
            case 2:
                Console.WriteLine("Lista de produtos");
                Console.WriteLine(produto);
                break;

            case 3:
                Console.WriteLine("Remova produtos");
                int num3 = Convert.ToInt32(Console.ReadLine());
                break;

            case 4:
                Console.WriteLine("entrada de estoque");
                int num4 = Convert.ToInt32(Console.ReadLine());
                break;

            case 5:
                Console.WriteLine("Saida do estoque");
                int num5 = Convert.ToInt32(Console.ReadLine());
                break;

            case 0:
                Console.WriteLine("Sair do menu");
                int num6 = Convert.ToInt32(Console.ReadLine());
                break;
       }

       //Console.WriteLine("Numero escolhido " + escolha);
    }
}
// Irei fazer o menu em uma função separada para poder reutili-zar




    
