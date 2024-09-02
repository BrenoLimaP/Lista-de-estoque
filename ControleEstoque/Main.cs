using System;
using ControleEstoque.csproj;
// Trabalho da faculdade - PTI
// Fazer o estoque de uma empresa com produtos de minhas escolha
// Declarar mais de 3 topicos para cada item, por ex: Livro= Autor, cor, e tema;
// Primeiro passo criar um menu de seleção:
// 1-Novo / 2-Listar Produtos / 3-Remover Produtos / 4-Entrada Estoque / 5-Saida Estoque / 0-Sair
// O menu precisa ser recursivo, ou seja, precisa aparecer até que seja teclado 0 ou sair
// Menu
public class Program
{   
    public static void Main(){
        Gerenciador gerenciador = new Gerenciador();    
        while(true){
            int opcao = Menuescolhas();
            if(opcao == 0) break;
            Gerenciador.Escolher(opcao); // Passa a escolha para o método Escolher
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
}