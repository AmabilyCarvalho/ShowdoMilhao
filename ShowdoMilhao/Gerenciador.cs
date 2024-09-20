using ShowdoMilhao;

namespace ShowdoMilhao;

public class Gerenciador
{
    List <Questao> ListaQuestao = new List<Questao>();
    List <int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;
    public Gerenciador (Label labelPergunta,Button buttonResposta1,Button buttonResposta2,Button buttonResposta3,Button buttonResposta4,Button buttonResposta5)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    }

    public void ProximaPergunta()
    {
        var numRandomico = Random.Shared.Next(0,ListaQuestao.Count -1);
        while(ListaQuestoesRespondidas.Contains(numRandomico))
        numRandomico = Random.Shared.Next(0,ListaQuestoesRespondidas.Count -1);
        ListaQuestoesRespondidas.Add (numRandomico);
        questaoCorrente = ListaQuestao[numRandomico];
        questaoCorrente.Desenhar();
    }
    public async void VerificaCorreto(int resposta)
    {
        if (questaoCorrente!.VerifiicarResposta(resposta))
        {
            await Task.Delay(1500);
            ProximaPergunta();
        }
    }
    void CriarQuestoes (Label labelPergunta,Button buttonResposta1,Button buttonResposta2,Button buttonResposta3,Button buttonResposta4,Button buttonResposta5)
{
    var Q1 = new Questao ();
    Q1.pergunta = "Qual é o nome do Arconte de Mondstadt?";
    Q1.resposta1 = "Zhongli";
    Q1.resposta1 = "Raiden Shogun";
    Q1.resposta2 = "Nahida";
    Q1.resposta3 = "Klee";
    Q1.resposta4 = "Venti";
    Q1.resposta5 = "Mavuika";
    Q1.respostaCorreta = 4;
    Q1.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q1);

    var Q2 = new Questao ();
    Q2.pergunta = "Qual elemento é associado a Diluc?";
    Q2.resposta1 = "Hydro";
    Q2.resposta2 = "Electro";
    Q2.resposta3 = "Cryo";
    Q2.resposta4 = "Dendro";
    Q2.resposta5 = "Pyro";
    Q2.respostaCorreta = 5;
    Q2.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q2);

    var Q3 = new Questao ();
    Q3.pergunta = "Qual é a região conhecida como a terra do conhecimento?";
    Q3.resposta1 = "Liyue";
    Q3.resposta2 = "Mondstadt";
    Q3.resposta3 = "Inazuma";
    Q3.resposta4 = "Sumeru";
    Q3.resposta5 = "Natlan";
    Q3.respostaCorreta = 4;
    Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q3);

    var Q4 = new Questao ();
    Q4.pergunta = "Em qual região se encontra a sede dos Fatui?";
    Q4.resposta1 = "Snezhnaya";
    Q4.resposta2 = "Mondstadt";
    Q4.resposta3 = "Liyue";
    Q4.resposta4 = "Inazuma";
    Q4.resposta5 = "Sumeru";
    Q4.respostaCorreta = 1;
    Q4.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q4);

    var Q5 = new Questao ();
    Q5.pergunta = "Quem é a deusa da Eternidade em Genshin Impact?";
    Q5.resposta1 = "Barbatos";
    Q5.resposta2 = "Raiden Shogun";
    Q5.resposta3 = "Nahida";
    Q5.resposta4 = "Morax";
    Q5.resposta5 = "Kusanali";
    Q5.respostaCorreta = 2;
    Q5.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q5);

    var Q6 = new Questao ();
    Q6.pergunta = "Qual personagem é uma usuária de Dendro?";
    Q6.resposta1 = "Hu Tao";
    Q6.resposta2 = "Ganyu";
    Q6.resposta3 = "Tighnari";
    Q6.resposta4 = "Xiangling";
    Q6.resposta5 = "Beidou";
    Q6.respostaCorreta = 3;
    Q6.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q6);

    var Q7 = new Questao ();
    Q7.pergunta = "Qual é o nome do Arconte de Liyue?";
    Q7.resposta1 = "Venti";
    Q7.resposta2 = "Zhongli";
    Q7.resposta3 = "Raiden Shogun";
    Q7.resposta4 = "Mavuika";
    Q7.resposta5 = "Xiao";
    Q7.respostaCorreta = 2;
    Q7.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q7);

    var Q8 = new Questao ();
    Q8.pergunta = "Qual personagem é conhecido por ser um alquimista em Mondstadt?";
    Q8.resposta1 = "Mercador";
    Q8.resposta2 = "Alquimista";
    Q8.resposta3 = "Chefe da Guarda";
    Q8.resposta4 = "Cavaleiro";
    Q8.resposta5 = "Artista";
    Q8.respostaCorreta = 2;
    Q8.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q8);

    var Q9 = new Questao ();
    Q9.pergunta = "Qual personagem é a líder dos Knights of Favonius?";
    Q9.resposta1 = "Kaeya";
    Q9.resposta2 = "Lisa";
    Q9.resposta3 = "Barbara";
    Q9.resposta4 = "Jean";
    Q9.resposta5 = "Ningguang";
    Q9.respostaCorreta = 4;
    Q9.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q9);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

    var Q11 = new Questao ();
    Q11.pergunta = "Oque a Alice é da Klee?";
    Q11.resposta1 = "Mãe";
    Q11.resposta2 = "Avó";
    Q11.resposta3 = "Amiga";
    Q11.resposta4 = "Conhecida";
    Q11.resposta5 = "Tia";
    Q11.respostaCorreta = 1;
    Q11.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q11);

    var Q12 = new Questao ();
    Q12.pergunta = "Quem é o irmão da Lumine??";
    Q12.resposta1 = "Dainsleif";
    Q12.resposta2 = "Ayato";
    Q12.resposta3 = "Cyno";
    Q12.resposta4 = "Aether";
    Q12.resposta5 = "pulcinella";
    Q12.respostaCorreta = 4;
    Q12.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q12);

    var Q13 = new Questao ();
    Q13.pergunta = "Qual cidade é conhecida como a cidade da liberdade?";
    Q13.resposta1 = "Liyue";
    Q13.resposta2 = "Mondstadt";
    Q13.resposta3 = "Inazuma";
    Q13.resposta4 = "Sumeru";
    Q13.resposta5 = "Snezhnaya";
    Q13.respostaCorreta = 2;
    Q13.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q13);
    
    var Q14 = new Questao ();
    Q14.pergunta = "*";
    Q14.resposta = "*";
    Q14.resposta2 = "*";
    Q14.resposta3 = "*";
    Q14.resposta4 = "*";
    Q14.resposta5 = "*";
    Q14.respostaCorreta = 1;
    Q14.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q14);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

    var Q10 = new Questao ();
    Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
    Q10.resposta1 = "Liyue";
    Q10.resposta2 = "Mondstadt";
    Q10.resposta3 = "Inazuma";
    Q10.resposta4 = "Sumeru";
    Q10.resposta5 = "Snezhnaya";
    Q10.respostaCorreta = 1;
    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaQuestao.Add(Q10);

}

}