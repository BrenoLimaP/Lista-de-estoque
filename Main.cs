using System;
// Trabalho da faculdade - PTI
// Fazer o estoque de uma empresa com produtos de minhas escolha
// Declarar mais de 3 topicos para cada item, por ex: Livro= Autor, cor, e tema;


// Primeiro passo criar um menu de seleção:
// 1-Novo / 2-Listar Produtos / 3-Remover Produtos / 4-Entrada Estoque / 5-Saida Estoque / 0-Sair
// O menu precisa ser recursivo, ou seja, precisa aparecer até que seja teclado 0 ou sair


// Menu
class Program{
    static void Main(){
        Console.WriteLine("Escolha uma acao:");
        Console.WriteLine("1 - Novo Pedido");
        Menu();

        if (res == 1){
            Console.WriteLine("Descreva o pedido:");
            res2 = Convert.ToString(Console.ReadLine());
            
        }
        else {
            Console.WriteLine("caiu no else");
        }
    }
}
// Irei fazer o menu em uma função separada para poder reutili-zar
    static int Menu(res){
        Console.WriteLine("1 - Novo Pedido");
        int res = Convert.ToInt32(Console.ReadLine());

    }



    
