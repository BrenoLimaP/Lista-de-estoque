namespace Controle {
    public class Games{ // classe para poder adicionar um jogo a mais na lista... pensar em add nos quadrados
    Jogo[] jogos = new Jogo[0]; //informando que a lista está em 0
    public void Adicionar(Jogo jogo){// adicionando mais elemento ou seja jogos na lista
        jogo[] novo = new Jogo[jogos.length; + 1]; // acrescenta mais um a lista

        for(int cont = 0; cont < jogos.length; cont++){ //mantem os valores anteriores 
            novo[cont] = jogos[cont]; // e soma mais uma casa para adicionar o jogo
        }
        novo[jogos.length] = jogo; // substituiu a tabela de listas anterior pela nova

        jogos = novo; // e fez a nova lista de numeros ser a padrão
    }

    public void Listar(){
        foreach(Jogo item in jogos){// para os jogos adicionados com mais informações
            Console.WriteLine($"{item.Nome} - R$ {item.Preço}); - (Estoque: {item.Estoque})");// $ simbolo equivalente a concatenaçõa ou seja +
        }
    }
}
}