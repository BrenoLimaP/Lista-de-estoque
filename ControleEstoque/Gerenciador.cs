using System;


public class Gerenciador(Jogo jogo)
{
    static Jogo[] Adicionar (Jogo jogo)
    {
        Console.WriteLine("Quantos jogos deseja adicionar?");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        Jogo[] novo = new Jogo[jogos.Length + quantidade];
        
        for (int i = 0; i < jogos.Length; i++)
        {
            novo[i] = jogos[i];
                
        }
        for (int i = 0; i < quantidade; i++)
        {
            novo[jogos.Length + i] = jogo; // Adiciona o novo jogo
        }
        jogos = novo;
         return novo;
    }

        //public void Listar()
        //{
            //foreach(Jogo item in jogos)
            //{// para os jogos adicionados com mais informações
            //Console.WriteLine($"{item.Nome} - R$ {item.Preço}); - (Estoque: {item.Estoque})");// $ simbolo equivalente a concatenaçõa ou seja +s
            //}
        //}
}
