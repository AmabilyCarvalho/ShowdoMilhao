using ShowdoMilhao;

namespace ShowdoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestao = new List<Questao>();
    List<Questao> ListaTodasQuestoesRespondidas = new List<Questao>();
    public Questao questaoCorrente;

    Label labelPontuacao;
    Label labelNivel;
    int Pontuacao;

    public int Pontuação { get; private set; }
    int NivelAtual = 1;

    public Questao GetQuestaoCorrente()
    {
        return questaoCorrente;
    }

    void Inicializar()
    {

        labelPontuacao.Text = "Pontuacao: R$" + Pontuacao.ToString();
        labelNivel.Text = "Nivel: " + NivelAtual.ToString();
        Pontuação = 0;
        NivelAtual = 1;
        ListaTodasQuestoesRespondidas.Clear();
        ProximaPergunta();
    }
    public Gerenciador(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5, Label labelPont, Label labelNivel)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        labelPontuacao = labelPont;
        this.labelNivel = labelNivel;
    }

    public async void VerificaCorreto(int resposta)
    {
        if (questaoCorrente!.VerifiicarResposta(resposta))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaPergunta();
            labelPontuacao.Text = "Pontuação: R$" + Pontuacao.ToString();
            labelNivel.Text = "Nivel: " + NivelAtual.ToString();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("fim de jogo", "você é ruim de mais pra continuar", "Deseja tentar Novamente?");
            Inicializar();
        }
    }


    void AdicionaPontuacao(int CriaPontuacao)
    {
        if (CriaPontuacao == 1)
            Pontuacao = 1000;
        else if (CriaPontuacao == 2)
            Pontuacao = 2000;
        else if (CriaPontuacao == 3)
            Pontuacao = 5000;
        else if (CriaPontuacao == 4)
            Pontuacao = 10000;
        else if (CriaPontuacao == 5)
            Pontuacao = 20000;
        else if (CriaPontuacao == 6)
            Pontuacao = 50000;
        else if (CriaPontuacao == 7)
            Pontuacao = 100000;
        else if (CriaPontuacao == 8)
            Pontuacao = 200000;
        else if (CriaPontuacao == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;
    }

    public void ProximaPergunta()
    {
        var ListaQuestoes = ListaQuestao.Where(d => d.Nivel == NivelAtual).ToList();
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);

        questaoCorrente = ListaQuestoes[numRandomico];

        while (ListaTodasQuestoesRespondidas.Contains(questaoCorrente))
        {
            numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            questaoCorrente = ListaQuestoes[numRandomico];
        }

        ListaTodasQuestoesRespondidas.Add(questaoCorrente);

        questaoCorrente.Desenhar();
    }


    void CriarQuestoes(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        var Q1 = new Questao();
        Q1.Nivel = 1;
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

        var Q2 = new Questao();
        Q2.Nivel = 1;
        Q2.pergunta = "Qual elemento é associado a Diluc?";
        Q2.resposta1 = "Hydro";
        Q2.resposta2 = "Electro";
        Q2.resposta3 = "Cryo";
        Q2.resposta4 = "Dendro";
        Q2.resposta5 = "Pyro";
        Q2.respostaCorreta = 5;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q2);

        var Q3 = new Questao();
        Q3.Nivel = 1;
        Q3.pergunta = "Qual é a região conhecida como a terra do conhecimento?";
        Q3.resposta1 = "Liyue";
        Q3.resposta2 = "Mondstadt";
        Q3.resposta3 = "Inazuma";
        Q3.resposta4 = "Sumeru";
        Q3.resposta5 = "Natlan";
        Q3.respostaCorreta = 4;
        Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q3);

        var Q4 = new Questao();
        Q4.Nivel = 1;
        Q4.pergunta = "Em qual região se encontra a sede dos Fatui?";
        Q4.resposta1 = "Snezhnaya";
        Q4.resposta2 = "Mondstadt";
        Q4.resposta3 = "Liyue";
        Q4.resposta4 = "Inazuma";
        Q4.resposta5 = "Sumeru";
        Q4.respostaCorreta = 1;
        Q4.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q4);

        var Q5 = new Questao();
        Q5.Nivel = 1;
        Q5.pergunta = "Quem é a deusa da Eternidade em Genshin Impact?";
        Q5.resposta1 = "Barbatos";
        Q5.resposta2 = "Raiden Shogun";
        Q5.resposta3 = "Nahida";
        Q5.resposta4 = "Morax";
        Q5.resposta5 = "Kusanali";
        Q5.respostaCorreta = 2;
        Q5.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q5);

        var Q6 = new Questao();
        Q6.Nivel = 1;
        Q6.pergunta = "Qual personagem é um usuária de Dendro?";
        Q6.resposta1 = "Hu Tao";
        Q6.resposta2 = "Ganyu";
        Q6.resposta3 = "Tighnari";
        Q6.resposta4 = "Xiangling";
        Q6.resposta5 = "Beidou";
        Q6.respostaCorreta = 3;
        Q6.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q6);

        var Q7 = new Questao();
        Q7.Nivel = 1;
        Q7.pergunta = "Qual é o nome do Arconte de Liyue?";
        Q7.resposta1 = "Venti";
        Q7.resposta2 = "Zhongli";
        Q7.resposta3 = "Raiden Shogun";
        Q7.resposta4 = "Mavuika";
        Q7.resposta5 = "Xiao";
        Q7.respostaCorreta = 2;
        Q7.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q7);

        var Q8 = new Questao();
        Q8.Nivel = 1;
        Q8.pergunta = "Qual personagem é conhecido por ser um alquimista em Mondstadt?";
        Q8.resposta1 = "Kaeya";
        Q8.resposta2 = "Albedo";
        Q8.resposta3 = "Diona";
        Q8.resposta4 = "Sucrose";
        Q8.resposta5 = "Lisa";
        Q8.respostaCorreta = 2;
        Q8.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q8);

        var Q9 = new Questao();
        Q9.Nivel = 1;
        Q9.pergunta = "Quem é o atual chefe dos Cavaleiros de Favonius?";
        Q9.resposta1 = "Kaeya";
        Q9.resposta2 = "Lisa";
        Q9.resposta3 = "Barbara";
        Q9.resposta4 = "Jean";
        Q9.resposta5 = "Ningguang";
        Q9.respostaCorreta = 4;
        Q9.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q9);

        var Q10 = new Questao();
        Q10.Nivel = 1;
        Q10.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
        Q10.resposta1 = "Liyue";
        Q10.resposta2 = "Mondstadt";
        Q10.resposta3 = "Inazuma";
        Q10.resposta4 = "Sumeru";
        Q10.resposta5 = "Snezhnaya";
        Q10.respostaCorreta = 1;
        Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q10);

        var Q11 = new Questao();
        Q11.Nivel = 2;
        Q11.pergunta = "Oque a Alice é da Klee?";
        Q11.resposta1 = "Mãe";
        Q11.resposta2 = "Avó";
        Q11.resposta3 = "Amiga";
        Q11.resposta4 = "Conhecida";
        Q11.resposta5 = "Tia";
        Q11.respostaCorreta = 1;
        Q11.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q11);

        var Q12 = new Questao();
        Q12.Nivel = 2;
        Q12.pergunta = "Quem é o irmão da Lumine??";
        Q12.resposta1 = "Dainsleif";
        Q12.resposta2 = "Ayato";
        Q12.resposta3 = "Cyno";
        Q12.resposta4 = "Aether";
        Q12.resposta5 = "pulcinella";
        Q12.respostaCorreta = 4;
        Q12.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q12);

        var Q13 = new Questao();
        Q13.Nivel = 2;
        Q13.pergunta = "Qual cidade é conhecida como a cidade da liberdade?";
        Q13.resposta1 = "Liyue";
        Q13.resposta2 = "Mondstadt";
        Q13.resposta3 = "Inazuma";
        Q13.resposta4 = "Sumeru";
        Q13.resposta5 = "Snezhnaya";
        Q13.respostaCorreta = 2;
        Q13.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q13);

        var Q14 = new Questao();
        Q14.Nivel = 2;
        Q14.pergunta = "Qual é o nome do protagonista masculino em Genshin Impact?";
        Q14.resposta1 = "Kinich";
        Q14.resposta2 = "Aether";
        Q14.resposta3 = "Xiao";
        Q14.resposta4 = "Kazuha";
        Q14.resposta5 = "Diluc";
        Q14.respostaCorreta = 2;
        Q14.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q14);

        var Q15 = new Questao();
        Q15.Nivel = 2;
        Q15.pergunta = "Qual elemento é associado a Pyro?";
        Q15.resposta1 = "Terra";
        Q15.resposta2 = "Vento";
        Q15.resposta3 = "Água";
        Q15.resposta4 = "Gelo";
        Q15.resposta5 = "Fogo";
        Q15.respostaCorreta = 5;
        Q15.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q15);

        var Q16 = new Questao();
        Q16.Nivel = 2;
        Q16.pergunta = "Qual é o nome da região que foi lançada após Mondstadt e Liyue?";
        Q16.resposta1 = "Liyue";
        Q16.resposta2 = "Mondstadt";
        Q16.resposta3 = "Inazuma";
        Q16.resposta4 = "Sumeru";
        Q16.resposta5 = "Snezhnaya";
        Q16.respostaCorreta = 3;
        Q16.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q16);

        var Q17 = new Questao();
        Q17.Nivel = 2;
        Q17.pergunta = "Quem é o líder dos Fatui?";
        Q17.resposta1 = "Scaramouche";
        Q17.resposta2 = "Pantalone";
        Q17.resposta3 = "Tartaglia";
        Q17.resposta4 = "Signora";
        Q17.resposta5 = "Pierro";
        Q17.respostaCorreta = 5;
        Q17.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q17);

        var Q18 = new Questao();
        Q18.Nivel = 2;
        Q18.pergunta = "Qual é o nome do local onde os viajantes começam sua jornada?";
        Q18.resposta1 = "Liyue";
        Q18.resposta2 = "Mondstadt";
        Q18.resposta3 = "Inazuma";
        Q18.resposta4 = "Sumeru";
        Q18.resposta5 = "Snezhnaya";
        Q18.respostaCorreta = 2;
        Q18.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q18);

        var Q19 = new Questao();
        Q19.Nivel = 2;
        Q19.pergunta = "Qual é a relação de Paimon com o protagonista?";
        Q19.resposta1 = "Rival";
        Q19.resposta2 = "Irmã";
        Q19.resposta3 = "Inimiga";
        Q19.resposta4 = "Guia";
        Q19.resposta5 = "Comida de emergencia";
        Q19.respostaCorreta = 4;
        Q19.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q19);

        var Q20 = new Questao();
        Q20.Nivel = 2;
        Q20.pergunta = "Qual é o nome da cidade onde mora a personagem Qiqi?";
        Q20.resposta1 = "Liyue";
        Q20.resposta2 = "Mondstadt";
        Q20.resposta3 = "Inazuma";
        Q20.resposta4 = "Sumeru";
        Q20.resposta5 = "Snezhnaya";
        Q20.respostaCorreta = 1;
        Q20.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q20);

        var Q21 = new Questao();
        Q21.Nivel = 3;
        Q21.pergunta = "Qual o lema da guilda dos avemtureiros?";
        Q21.resposta1 = "Butter in butter";
        Q21.resposta2 = "To infinity and beyond";
        Q21.resposta3 = "money above all";
        Q21.resposta4 = "I Always Come Back";
        Q21.resposta5 = "Ad Astra Abyssosque";
        Q21.respostaCorreta = 5;
        Q21.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q21);

        var Q22 = new Questao();
        Q22.Nivel = 3;
        Q22.pergunta = "Oque significa Ad Astra Abyssosque?";
        Q22.resposta1 = "Para as estrelas e o abismo";
        Q22.resposta2 = "Ao infinito e além";
        Q22.resposta3 = "dinheiro acima de tudo";
        Q22.resposta4 = "Eu sempre volto";
        Q22.resposta5 = "manteiga na manteiga";
        Q22.respostaCorreta = 1;
        Q22.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q22);

        var Q23 = new Questao();
        Q23.Nivel = 3;
        Q23.pergunta = "Quem é o deus que governa Liyue?";
        Q23.resposta1 = "Barbatos";
        Q23.resposta2 = "Morax";
        Q23.resposta3 = "Kusanali";
        Q23.resposta4 = "Baal";
        Q23.resposta5 = "Focalors";
        Q23.respostaCorreta = 2;
        Q23.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q23);

        var Q24 = new Questao();
        Q24.Nivel = 3;
        Q24.pergunta = "Qual é o nome do dragão que aparece no inicio do jogo?";
        Q24.resposta1 = "Dvalin";
        Q24.resposta2 = "Neuvillette";
        Q24.resposta3 = "Orobashi";
        Q24.resposta4 = "Apep";
        Q24.resposta5 = "Azhdaha";
        Q24.respostaCorreta = 1;
        Q24.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q24);

        var Q25 = new Questao();
        Q25.Nivel = 3;
        Q25.pergunta = "Qual é o nome da associação de viajantes em Teyvat?";
        Q25.resposta1 = "Os Cavaleiros de Favonius";
        Q25.resposta2 = "A Confraria da Luz";
        Q25.resposta3 = "A Guilda dos Aventureiros";
        Q25.resposta4 = "Exploradores";
        Q25.resposta5 = "A Ordem dos Guardiões";
        Q25.respostaCorreta = 3;
        Q25.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q25);

        var Q26 = new Questao();
        Q26.Nivel = 3;
        Q26.pergunta = "Qual personagem é conhecido por sua habilidade em Culinária?";
        Q26.resposta1 = "Kokomi";
        Q26.resposta2 = "Raiden Shogun";
        Q26.resposta3 = "Amber";
        Q26.resposta4 = "Xiangling ";
        Q26.resposta5 = "Albedo";
        Q26.respostaCorreta = 4;
        Q26.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q26);

        var Q27 = new Questao();
        Q27.Nivel = 3;
        Q27.pergunta = "Qual é o elemento do Alhaitham?";
        Q27.resposta1 = "Dendro";
        Q27.resposta2 = "Anemom";
        Q27.resposta3 = "Electro";
        Q27.resposta4 = "Cryo";
        Q27.resposta5 = "Geo";
        Q27.respostaCorreta = 1;
        Q27.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q27);

        var Q28 = new Questao();
        Q28.Nivel = 3;
        Q28.pergunta = "Quem é o Agente Fatui que aparece em Mondstadt?";
        Q28.resposta1 = "Columbina";
        Q28.resposta2 = "Scaramouche";
        Q28.resposta3 = "Dottore";
        Q28.resposta4 = "Capitano";
        Q28.resposta5 = "Signora";
        Q28.respostaCorreta = 5;
        Q28.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q28);

        var Q29 = new Questao();
        Q29.Nivel = 3;
        Q29.pergunta = "Qual é a cidade onde os comerciantes mais ricos se reúnem?";
        Q29.resposta1 = "Mondstadt";
        Q29.resposta2 = "Liyue";
        Q29.resposta3 = "Inazuma";
        Q29.resposta4 = "Sumeru";
        Q29.resposta5 = "Fontaine";
        Q29.respostaCorreta = 2;
        Q29.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q29);

        var Q30 = new Questao();
        Q30.Nivel = 4;
        Q30.pergunta = "Qual é a cor do cabelo de Lisa?";
        Q30.resposta1 = "Roxo";
        Q30.resposta2 = "Loiro";
        Q30.resposta3 = "Castanho";
        Q30.resposta4 = "Verde";
        Q30.resposta5 = "Preto";
        Q30.respostaCorreta = 3;
        Q30.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q30);

        var Q31 = new Questao();
        Q31.Nivel = 4;
        Q31.pergunta = "Qual é o nome do pet de Klee?";
        Q31.resposta1 = "Dodoco";
        Q31.resposta2 = "Lupus Boreas";
        Q31.resposta3 = "Oz";
        Q31.resposta4 = "Kaeya";
        Q31.resposta5 = "Paimon";
        Q31.respostaCorreta = 1;
        Q31.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q31);

        var Q32 = new Questao();
        Q32.Nivel = 4;
        Q32.pergunta = "Qual é a cidade que tem um festival de lanternas?";
        Q32.resposta1 = "Sumeru";
        Q32.resposta2 = "Inazuma";
        Q32.resposta3 = "Liyue";
        Q32.resposta4 = "Mondstadt";
        Q32.resposta5 = "Fontaine";
        Q32.respostaCorreta = 3;
        Q32.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q32);

        var Q33 = new Questao();
        Q33.Nivel = 4;
        Q33.pergunta = "Qual personagem tem um estilo de luta baseado em danças?";
        Q33.resposta1 = "Dori";
        Q33.resposta2 = "Amber";
        Q33.resposta3 = "Lynette";
        Q33.resposta4 = "Nilou";
        Q33.resposta5 = "Kuki Shinobu";
        Q33.respostaCorreta = 4;
        Q33.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q33);

        var Q34 = new Questao();
        Q34.Nivel = 4;
        Q34.pergunta = "Qual é o tipo de arma que utiliza o personagem Childe?";
        Q34.resposta1 = "Lança";
        Q34.resposta2 = "Adaga";
        Q34.resposta3 = "Arco";
        Q34.resposta4 = "Espada";
        Q34.resposta5 = "manteiga na manteiga";
        Q34.respostaCorreta = 3;
        Q34.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q34);

        var Q35 = new Questao();
        Q35.Nivel = 4;
        Q35.pergunta = "Quem é o líder da gangue Arataki?";
        Q35.resposta1 = "Itto";
        Q35.resposta2 = "Kuki Shinobu";
        Q35.resposta3 = "Ayato";
        Q35.resposta4 = "Gorou";
        Q35.resposta5 = "Yae Miko";
        Q35.respostaCorreta = 1;
        Q35.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q35);

        var Q36 = new Questao();
        Q36.Nivel = 4;
        Q36.pergunta = "Qual é a cidade famosa por sua música?";
        Q36.resposta1 = "Natlan";
        Q36.resposta2 = "Inazuma";
        Q36.resposta3 = "Sumeru";
        Q36.resposta4 = "Mondstad";
        Q36.resposta5 = "Fontaine";
        Q36.respostaCorreta = 4;
        Q36.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q36);

        var Q37 = new Questao();
        Q37.Nivel = 4;
        Q37.pergunta = "Qual é o tipo de arma que utiliza a personagem Yae Miko?";
        Q37.resposta1 = "Espadão";
        Q37.resposta2 = "Lança";
        Q37.resposta3 = "Espada";
        Q37.resposta4 = "Arco";
        Q37.resposta5 = "Catalisador ";
        Q37.respostaCorreta = 5;
        Q37.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q37);

        var Q38 = new Questao();
        Q38.Nivel = 4;
        Q38.pergunta = "Qual o nome da habilidade elemental da Yelan";
        Q38.resposta1 = "Rede da Vida Salvadora";
        Q38.resposta2 = "Tempestade do Mar";
        Q38.resposta3 = "Dança do Gelo";
        Q38.resposta4 = "Golpe de Cristal";
        Q38.resposta5 = "Sopro do Oceano";
        Q38.respostaCorreta = 1;
        Q38.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q38);

        var Q39 = new Questao();
        Q39.Nivel = 4;
        Q39.pergunta = "Qual o nome da habilidade elemental da Qiqi";
        Q39.resposta1 = "Tempestade do Raio";
        Q39.resposta2 = "Arte do Adeptus: Arauto da Floresta";
        Q39.resposta3 = "Dança do Gelo";
        Q39.resposta4 = "Chamas do Destino";
        Q39.resposta5 = "Barreira Flamejante";
        Q39.respostaCorreta = 2;
        Q39.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q39);

        var Q40 = new Questao();
        Q40.Nivel = 5;
        Q40.pergunta = "Qual é o papel de Hu Tao na equipe?";
        Q40.resposta1 = "Buffer";
        Q40.resposta2 = "Suporte";
        Q40.resposta3 = "DPS";
        Q40.resposta4 = "Tank";
        Q40.resposta5 = "Curandeira";
        Q40.respostaCorreta = 3;
        Q40.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q40);

        var Q41 = new Questao();
        Q41.Nivel = 5;
        Q41.pergunta = "Qual personagem pode criar escudos?";
        Q41.resposta1 = "Layla";
        Q41.resposta2 = "Beidou";
        Q41.resposta3 = "Noele";
        Q41.resposta4 = "Diona";
        Q41.resposta5 = "Todos os acima";
        Q41.respostaCorreta = 5;
        Q41.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q41);

        var Q42 = new Questao();
        Q42.Nivel = 5;
        Q42.pergunta = "Quem é conhecido por deixar os cavaleiros de favonius?";
        Q42.resposta1 = "Kaeya";
        Q42.resposta2 = "Noele";
        Q42.resposta3 = "Diluc";
        Q42.resposta4 = "Albedo";
        Q42.resposta5 = "Amber";
        Q42.respostaCorreta = 3;
        Q42.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q42);

        var Q43 = new Questao();
        Q43.Nivel = 5;
        Q43.pergunta = "Qual personagem é um explorador do deserto?";
        Q43.resposta1 = "Nilou";
        Q43.resposta2 = "Cyno";
        Q43.resposta3 = "Wanderer";
        Q43.resposta4 = "Sucrose";
        Q43.resposta5 = "Xinyan";
        Q43.respostaCorreta = 2;
        Q43.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q43);

        var Q44 = new Questao();
        Q44.Nivel = 5;
        Q44.pergunta = "Qual personagem usa um arco e é um membro da Ordem de Favonius?";
        Q44.resposta1 = "Fischl";
        Q44.resposta2 = "Kaeya";
        Q44.resposta3 = "Klee";
        Q44.resposta4 = "Beidou";
        Q44.resposta5 = "Amber";
        Q44.respostaCorreta = 5;
        Q44.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q44);

        var Q45 = new Questao();
        Q45.Nivel = 5;
        Q45.pergunta = "Qual é o papel de Barbara na equipe?";
        Q45.resposta1 = "DPS";
        Q45.resposta2 = "Suporte";
        Q45.resposta3 = "Tank";
        Q45.resposta4 = "Curador";
        Q45.resposta5 = "Sub DPS";
        Q45.respostaCorreta = 4;
        Q45.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q45);

        var Q46 = new Questao();
        Q46.Nivel = 5;
        Q46.pergunta = "Quem é o personagem que usa uma besta?";
        Q46.resposta1 = "Heizou";
        Q46.resposta2 = "Mika";
        Q46.resposta3 = "Dori";
        Q46.resposta4 = "Collei";
        Q46.resposta5 = "Chiori";
        Q46.respostaCorreta = 2;
        Q46.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q46);

        var Q47 = new Questao();
        Q47.Nivel = 5;
        Q47.pergunta = "Qual é o nome da cidade em que Kazuha cresceu?";
        Q47.resposta1 = "Inazuma";
        Q47.resposta2 = "Fontaine";
        Q47.resposta3 = "Liyue";
        Q47.resposta4 = "Natlan";
        Q47.resposta5 = "Mondstad";
        Q47.respostaCorreta = 1;
        Q47.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q47);

        var Q48 = new Questao();
        Q48.Nivel = 5;
        Q48.pergunta = "Qual é a arma usada por Diona?";
        Q48.resposta1 = "Espadão";
        Q48.resposta2 = "Lança";
        Q48.resposta3 = "Catalizador";
        Q48.resposta4 = "Arco";
        Q48.resposta5 = "Espada";
        Q48.respostaCorreta = 4;
        Q48.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q48);

        var Q49 = new Questao();
        Q49.Nivel = 5;
        Q49.pergunta = "Qual o nome do ataque normal da nilou?";
        Q49.resposta1 = "Espada do Caminho Radiante";
        Q49.resposta2 = "Noites Solenes";
        Q49.resposta3 = "Origem";
        Q49.resposta4 = "Dança da Meia-Lua";
        Q49.resposta5 = "Desejos Incontados";
        Q49.respostaCorreta = 4;
        Q49.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q49);

        var Q50 = new Questao();
        Q50.Nivel = 5;
        Q50.pergunta = "Qual o nome do ataque normal da Layla?";
        Q50.resposta1 = "Espada do Caminho Radiante";
        Q50.resposta2 = "Sinais de Sonho Sombrio";
        Q50.resposta3 = "Dança dos Sete Reinos";
        Q50.resposta4 = "Corte das Pétalas Dançantes";
        Q50.resposta5 = "Milagre: Luz Maligna";
        Q50.respostaCorreta = 1;
        Q50.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q50);

        var Q51 = new Questao();
        Q51.Nivel = 6;
        Q51.pergunta = "Qual é a visão de Tighnari?";
        Q51.resposta1 = "Geo";
        Q51.resposta2 = "Dendro";
        Q51.resposta3 = "Cryo";
        Q51.resposta4 = "Electro";
        Q51.resposta5 = "Pyro";
        Q51.respostaCorreta = 2;
        Q51.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q51);

        var Q52 = new Questao();
        Q52.Nivel = 6;
        Q52.pergunta = "Quem é o personagem que possui uma abilidade de cura?";
        Q52.resposta1 = "Hu Tao";
        Q52.resposta2 = "Lisa";
        Q52.resposta3 = "Qiqi";
        Q52.resposta4 = "Sucrose";
        Q52.resposta5 = "Mona";
        Q52.respostaCorreta = 3;
        Q52.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q52);

        var Q53 = new Questao();
        Q53.Nivel = 6;
        Q53.pergunta = "Qual é a moeda principal do jogo?";
        Q53.resposta1 = "Euro";
        Q53.resposta2 = "Dolar";
        Q53.resposta3 = "Real";
        Q53.resposta4 = "Primogems";
        Q53.resposta5 = "Mora";
        Q53.respostaCorreta = 5;
        Q53.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q53);

        var Q54 = new Questao();
        Q54.Nivel = 6;
        Q54.pergunta = "Qual nome da arma assinatura furina?";
        Q54.resposta1 = "Báculo de Homa";
        Q54.resposta2 = "Maremoto da Lua de Futsu";
        Q54.resposta3 = "Esplendor das Águas Paradas";
        Q54.resposta4 = "Espada Celestial";
        Q54.resposta5 = "Orgulho Celestial";
        Q54.respostaCorreta = 3;
        Q54.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q54);

        var Q55 = new Questao();
        Q55.Nivel = 6;
        Q55.pergunta = "Qual o nome da arma assinatura do Xiao?";
        Q55.resposta1 = "Túmulo do lobo";
        Q55.resposta2 = "Lança de Jade Primordial";
        Q55.resposta3 = "Harpa Celestial";
        Q55.resposta4 = "Espada Celestial";
        Q55.resposta5 = "Arcana original";
        Q55.respostaCorreta = 2;
        Q55.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q55);

        var Q56 = new Questao();
        Q56.Nivel = 6;
        Q56.pergunta = "Qual é a cidade que abriga o Shogunato?";
        Q56.resposta1 = "Sumeru";
        Q56.resposta2 = "Mondstad";
        Q56.resposta3 = "Liyue";
        Q56.resposta4 = "Natlan";
        Q56.resposta5 = "Inazuma";
        Q56.respostaCorreta = 5;
        Q56.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q56);

        var Q57 = new Questao();
        Q57.Nivel = 6;
        Q57.pergunta = "Qual é o nome do barco de Beidou?";
        Q57.resposta1 = "Perola negra";
        Q57.resposta2 = "Thousand sunny";
        Q57.resposta3 = "Moby dick";
        Q57.resposta4 = "Going merry";
        Q57.resposta5 = "Frota Crux";
        Q57.respostaCorreta = 5;
        Q57.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q57);

        var Q58 = new Questao();
        Q58.Nivel = 6;
        Q58.pergunta = "Qual é a habilidade de suporte de Diona?";
        Q58.resposta1 = "Frosted Network";
        Q58.resposta2 = "Icy Paws";
        Q58.resposta3 = "Signature Mix";
        Q58.resposta4 = "Cat's Tail";
        Q58.resposta5 = "Crystalize";
        Q58.respostaCorreta = 3;
        Q58.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q58);

        var Q59 = new Questao();
        Q59.Nivel = 6;
        Q59.pergunta = "Qual é o nome do mundo em Genshin Impact?";
        Q59.resposta1 = "Tevat";
        Q59.resposta2 = "Deyva";
        Q59.resposta3 = "Teyvat";
        Q59.resposta4 = "Taivat";
        Q59.resposta5 = "Eyvat";
        Q59.respostaCorreta = 3;
        Q59.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q59);

        var Q60 = new Questao();
        Q60.Nivel = 6;
        Q60.pergunta = "Qual Nome do supremo do Bhaizu?";
        Q60.resposta1 = "Ritual Secreto: Travessia Abissal";
        Q60.resposta2 = "Ritual Sagrado: Agilidade Lupina";
        Q60.resposta3 = "Arte Secreta: Musou Shinsetsu";
        Q60.resposta4 = "Dança da Lótus: Nascente Longínqua Onírica";
        Q60.resposta5 = "Cura Holística";
        Q60.respostaCorreta = 5;
        Q60.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q60);

        var Q61 = new Questao();
        Q61.Nivel = 7;
        Q61.pergunta = "Qual Nome do supremo do Xiao?";
        Q61.resposta1 = "Vento Lemniscático";
        Q61.resposta2 = "Dança da Meia-Lua";
        Q61.resposta3 = "Dança Nuo da Conquista do Mal";
        Q61.resposta4 = "Dança da Lótus: Nascente Longínqua Onírica";
        Q61.resposta5 = "Dança dos Sete Reinos";
        Q61.respostaCorreta = 3;
        Q61.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q61);

        var Q62 = new Questao();
        Q62.Nivel = 7;
        Q62.pergunta = "Quem é o responsável pela loja de flores em Mondstadt?";
        Q62.resposta1 = "Flora";
        Q62.resposta2 = "Diona";
        Q62.resposta3 = "Mona";
        Q62.resposta4 = "Lisa";
        Q62.resposta5 = "Barbara";
        Q62.respostaCorreta = 1;
        Q62.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q62);

        var Q63 = new Questao();
        Q63.Nivel = 7;
        Q63.pergunta = "Qual é a habilidade suprema de Beidou?";
        Q63.resposta1 = "Retribuição";
        Q63.resposta2 = "Tormenta Elétrica";
        Q63.resposta3 = "Quebrador de Tempestades";
        Q63.resposta4 = "Invocadora da Maré";
        Q63.resposta5 = "Conquista do Oceano";
        Q63.respostaCorreta = 3;
        Q63.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q63);

        var Q64 = new Questao();
        Q64.Nivel = 7;
        Q64.pergunta = "Qual é o papel de Tighnari na floresta de Sumeru?";
        Q64.resposta1 = "Chef";
        Q64.resposta2 = "Guardião da floresta";
        Q64.resposta3 = "Vigia";
        Q64.resposta4 = "Alquimista";
        Q64.resposta5 = "Músico";
        Q64.respostaCorreta = 2;
        Q64.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q64);

        var Q65 = new Questao();
        Q65.Nivel = 7;
        Q65.pergunta = "Qual é o papel de Lisa na Guilda dos Aventureiros?";
        Q65.resposta1 = "Líder";
        Q65.resposta2 = "Escritor";
        Q65.resposta3 = "Caçadora";
        Q65.resposta4 = "Bibliotecária";
        Q65.resposta5 = "Guia espiritual";
        Q65.respostaCorreta = 4;
        Q65.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q65);

        var Q66 = new Questao();
        Q66.Nivel = 7;
        Q66.pergunta = "Qual animail o Oz é ";
        Q66.resposta1 = "Urso";
        Q66.resposta2 = "Cachorro";
        Q66.resposta3 = "Gato";
        Q66.resposta4 = "Coelho";
        Q66.resposta5 = "Corvo";
        Q66.respostaCorreta = 3;
        Q66.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q66);

        var Q67 = new Questao();
        Q67.Nivel = 7;
        Q67.pergunta = "Qual é o título de Childe?";
        Q67.resposta1 = "O Príncipe";
        Q67.resposta2 = "Comerciante";
        Q67.resposta3 = "O 11º dos Fatui";
        Q67.resposta4 = "O Mercenário";
        Q67.resposta5 = "O Eleito";
        Q67.respostaCorreta = 3;
        Q67.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q67);

        var Q68 = new Questao();
        Q68.Nivel = 7;
        Q68.pergunta = "Qual a cidade destruida pelos arcontes?";
        Q68.resposta1 = "Texas";
        Q68.resposta2 = "Khaenri'ah";
        Q68.resposta3 = "Pintópolis";
        Q68.resposta4 = "Kannazuka";
        Q68.resposta5 = "Enkanomiya";
        Q68.respostaCorreta = 2;
        Q68.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q68);

        var Q69 = new Questao();
        Q69.Nivel = 7;
        Q69.pergunta = "Qual o fatui q morreu em Inazuma";
        Q69.resposta1 = "Capitano";
        Q69.resposta2 = "Pierro";
        Q69.resposta3 = "Pantalone";
        Q69.resposta4 = "Columbina";
        Q69.resposta5 = "Signora";
        Q69.respostaCorreta = 1;
        Q69.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q69);

        var Q70 = new Questao();
        Q70.Nivel = 8;
        Q70.pergunta = "Qual é a relação entre Ayaka e Kamisato Ayato?";
        Q70.resposta1 = "Mentor e aprendiz";
        Q70.resposta2 = "Colegas";
        Q70.resposta3 = "Rivais";
        Q70.resposta4 = "Amigos";
        Q70.resposta5 = "Irmãos ";
        Q70.respostaCorreta = 5;
        Q70.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q70);

        var Q71 = new Questao();
        Q71.Nivel = 8;
        Q71.pergunta = "Qual é a cidade natal de Ayato?";
        Q71.resposta1 = "Mondstadt";
        Q71.resposta2 = "Inazuma";
        Q71.resposta3 = "Sumeru";
        Q71.resposta4 = "Fontaine";
        Q71.resposta5 = "Liyue";
        Q71.respostaCorreta = 2;
        Q71.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q71);

        var Q72 = new Questao();
        Q72.Nivel = 8;
        Q72.pergunta = "Qual é o animal que voa na ult do Diluc?";
        Q72.resposta1 = "Papagaio";
        Q72.resposta2 = "Coruja";
        Q72.resposta3 = "Fenix";
        Q72.resposta4 = "Corvo";
        Q72.resposta5 = "Águia";
        Q72.respostaCorreta = 2;
        Q72.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q72);

        var Q73 = new Questao();
        Q73.Nivel = 8;
        Q73.pergunta = "Em qual tipo de monstro os arcontes são inspirados?";
        Q73.resposta1 = "Dragartos";
        Q73.resposta2 = "Cogumelos";
        Q73.resposta3 = "Slimes";
        Q73.resposta4 = "Flor gigante";
        Q73.resposta5 = "Foquinha Rotunda";
        Q73.respostaCorreta = 3;
        Q73.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q73);

        var Q74 = new Questao();
        Q74.Nivel = 8;
        Q74.pergunta = "Qual é a cidade natal de Diona?";
        Q74.resposta1 = "Sumeru";
        Q74.resposta2 = "Liyue";
        Q74.resposta3 = "Inazuma";
        Q74.resposta4 = "Mondstadt ";
        Q74.resposta5 = "Fontaine";
        Q74.respostaCorreta = 4;
        Q74.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q74);

        var Q75 = new Questao();
        Q75.Nivel = 8;
        Q75.pergunta = "Qual os insetos que o Itto usa em suas rinhas";
        Q75.resposta1 = "Bosouros";
        Q75.resposta2 = "Baratas";
        Q75.resposta3 = "Joaninhas";
        Q75.resposta4 = "Borboletas";
        Q75.resposta5 = "Grilos";
        Q75.respostaCorreta = 1;
        Q75.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q75);

        var Q76 = new Questao();
        Q76.Nivel = 8;
        Q76.pergunta = "Qual o nome dos besouros do itto";
        Q76.resposta1 = "Kamai Kenji";
        Q76.resposta2 = "Onikuma";
        Q76.resposta3 = "Escaravelho";
        Q76.resposta4 = "Scaramouche";
        Q76.resposta5 = "Onikabuto";
        Q76.respostaCorreta = 5;
        Q76.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q76);

        var Q77 = new Questao();
        Q77.Nivel = 8;
        Q77.pergunta = "Em qual região inazuma foi inspirada?";
        Q77.resposta1 = "Canadá";
        Q77.resposta2 = "México";
        Q77.resposta3 = "Russia";
        Q77.resposta4 = "Japão";
        Q77.resposta5 = "China";
        Q77.respostaCorreta = 4;
        Q77.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q77);

        var Q78 = new Questao();
        Q78.Nivel = 8;
        Q78.pergunta = "Em qual região Liyue foi inspirada?";
        Q78.resposta1 = "China";
        Q78.resposta2 = "Coréia";
        Q78.resposta3 = "Turquia";
        Q78.resposta4 = "Brasil";
        Q78.resposta5 = "Espanha";
        Q78.respostaCorreta = 1;
        Q78.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q78);

        var Q79 = new Questao();
        Q79.Nivel = 8;
        Q79.pergunta = "Em qual região Fontaine foi inspirada?";
        Q79.resposta1 = "Noruega";
        Q79.resposta2 = "França";
        Q79.resposta3 = "Argentina";
        Q79.resposta4 = "Puru";
        Q79.resposta5 = "Bolivia";
        Q79.respostaCorreta = 2;
        Q79.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q79);

        var Q80 = new Questao();
        Q80.Nivel = 8;
        Q80.pergunta = "Em qual região Mondstadt foi inspirada?";
        Q80.resposta1 = "Austrália";
        Q80.resposta2 = "Irlanda";
        Q80.resposta3 = "Venezuela";
        Q80.resposta4 = "Alemanha";
        Q80.resposta5 = "Irã";
        Q80.respostaCorreta = 4;
        Q80.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q80);

        var Q81 = new Questao();
        Q81.Nivel = 9;
        Q81.pergunta = "Qual é a relação entre Kazuha e Beidou?";
        Q81.resposta1 = "Mestre e aprendiz";
        Q81.resposta2 = "Rivais";
        Q81.resposta3 = "Amigos";
        Q81.resposta4 = "Companheiros de viagem";
        Q81.resposta5 = "Irmãos";
        Q81.respostaCorreta = 3;
        Q81.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q81);

        var Q82 = new Questao();
        Q82.Nivel = 9;
        Q82.pergunta = "Em qual região Sumeru foi inspirada?";
        Q82.resposta1 = "Namíbia";
        Q82.resposta2 = "Índia";
        Q82.resposta3 = "Jamaica";
        Q82.resposta4 = "Afeganistão";
        Q82.resposta5 = "Haiti";
        Q82.respostaCorreta = 2;
        Q82.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q82);

        var Q83 = new Questao();
        Q83.Nivel = 9;
        Q83.pergunta = "Qual é a habilidade suprema de Ganyu?";
        Q83.resposta1 = "Celestial Bow";
        Q83.resposta2 = "Frosted Barrage";
        Q83.resposta3 = "Lullaby of Frost";
        Q83.resposta4 = "Ice Spirit";
        Q83.resposta5 = "Cryo Nova";
        Q83.respostaCorreta = 1;
        Q83.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q83);

        var Q84 = new Questao();
        Q84.Nivel = 9;
        Q84.pergunta = "Qual é a cidade de origem de Lumine?";
        Q84.resposta1 = "Mondstadt";
        Q84.resposta2 = "Sumeru";
        Q84.resposta3 = "Liyue";
        Q84.resposta4 = "Inazuma";
        Q84.resposta5 = "Desconhecida";
        Q84.respostaCorreta = 5;
        Q84.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q84);

        var Q85 = new Questao();
        Q85.Nivel = 9;
        Q85.pergunta = "Qual é o título de Hu Tao?";
        Q85.resposta1 = "A Dama da Morte";
        Q85.resposta2 = "A Guardiã da Luz";
        Q85.resposta3 = "A Diretora da Casa de Guías**(Resposta correta)**";
        Q85.resposta4 = "A Sombra do Vento";
        Q85.resposta5 = "A Caçadora";
        Q85.respostaCorreta = 3;
        Q85.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q85);

        var Q86 = new Questao();
        Q86.Nivel = 9;
        Q86.pergunta = "Qual é a arma de Eula?";
        Q86.resposta1 = "Espada grande **(Resposta correta)**";
        Q86.resposta2 = "Lança";
        Q86.resposta3 = "Arco";
        Q86.resposta4 = "Catalisador";
        Q86.resposta5 = "Espada";
        Q86.respostaCorreta = 1;
        Q86.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q86);

        var Q87 = new Questao();
        Q87.Nivel = 9;
        Q87.pergunta = "Quem é a Arconte de Inazuma?";
        Q87.resposta1 = "Raiden Shogun **(Resposta correta)**";
        Q87.resposta2 = "Venti";
        Q87.resposta3 = "Zhongli";
        Q87.resposta4 = "Albedo";
        Q87.resposta5 = "Yae Miko";
        Q87.respostaCorreta = 1;
        Q87.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q87);

        var Q88 = new Questao();
        Q88.Nivel = 9;
        Q88.pergunta = "Qual é a especialidade de Thoma?";
        Q88.resposta1 = "Curry **(Resposta correta)**";
        Q88.resposta2 = "Pizza";
        Q88.resposta3 = "Frutos do mar";
        Q88.resposta4 = "Sopa";
        Q88.resposta5 = "Salada";
        Q88.respostaCorreta = 1;
        Q88.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q88);

        var Q89 = new Questao();
        Q89.Nivel = 9;
        Q89.pergunta = "Qual é a habilidade elemental de Ningguang?";
        Q89.resposta1 = "Jade Screen";
        Q89.resposta2 = "Stonewall";
        Q89.resposta3 = "Geo Shield **(Resposta correta)**";
        Q89.resposta4 = "Crystal Shield";
        Q89.resposta5 = "Earth Wall";
        Q89.respostaCorreta = 1;
        Q89.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q89);

        var Q90 = new Questao();
        Q90.Nivel = 9;
        Q90.pergunta = "Qual é a habilidade suprema de Ayaka?";
        Q90.resposta1 = "Kamisato Art: Soumetsu **(Resposta correta)**";
        Q90.resposta2 = "Kamisato Art: Hyouka";
        Q90.resposta3 = "Kamisato Art: Hyouka";
        Q90.resposta4 = "Kamisato Art: Kamifune";
        Q90.resposta5 = "Kamisato Art: Shirou";
        Q90.respostaCorreta = 1;
        Q90.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q90);

        var Q91 = new Questao();
        Q91.Nivel = 10;
        Q91.pergunta = "Qual é o título de Mona?";
        Q91.resposta1 = "A Astróloga **(Resposta correta)**";
        Q91.resposta2 = "A Guerreira";
        Q91.resposta3 = "A Curandeira";
        Q91.resposta4 = "A Arqueóloga";
        Q91.resposta5 = "A Mística";
        Q91.respostaCorreta = 1;
        Q91.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q91);

        var Q92 = new Questao();
        Q92.Nivel = 10;
        Q92.pergunta = "Qual é o papel de Alhaitham na história?";
        Q92.resposta1 = "Místico";
        Q92.resposta2 = "Defensor";
        Q92.resposta3 = "Alquimista";
        Q92.resposta4 = "Escritor **(Resposta correta)**";
        Q92.resposta5 = "Chef";
        Q92.respostaCorreta = 4;
        Q92.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q92);

        var Q93 = new Questao();
        Q93.Nivel = 10;
        Q93.pergunta = "Quem é o deus da liberdade?";
        Q93.resposta1 = "Zhongli";
        Q93.resposta2 = "Venti **(Resposta correta)**";
        Q93.resposta3 = "Raiden Shogun";
        Q93.resposta4 = "Albedo";
        Q93.resposta5 = "Nahida";
        Q93.respostaCorreta = 2;
        Q93.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q93);

        var Q94 = new Questao();
        Q94.Nivel = 10;
        Q94.pergunta = "Qual é a habilidade elemental de Fischl?";
        Q94.resposta1 = "Ravenswings";
        Q94.resposta2 = "Lightning Rose **(Resposta correta)**";
        Q94.resposta3 = "Thunderbolt";
        Q94.resposta4 = "Odin's Call";
        Q94.resposta5 = "Shadow Strike";
        Q94.respostaCorreta = 2;
        Q94.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q94);

        var Q95 = new Questao();
        Q95.Nivel = 10;
        Q95.pergunta = "Qual é a especialidade de Diona?";
        Q95.resposta1 = "Culinária de frutos do mar";
        Q95.resposta2 = "Drinks";
        Q95.resposta3 = "Sopas";
        Q95.resposta4 = "Pães";
        Q95.resposta5 = "Sobremesas";
        Q95.respostaCorreta = 2;
        Q95.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q95);

        var Q96 = new Questao();
        Q96.Nivel = 10;
        Q96.pergunta = "Qual é o papel de Keqing na administração de Liyue?";
        Q96.resposta1 = "Representante do comércio";
        Q96.resposta2 = "Arconte";
        Q96.resposta3 = "Protetora **(Resposta correta)**";
        Q96.resposta4 = "Alquimista";
        Q96.resposta5 = "Chef";
        Q96.respostaCorreta = 3;
        Q96.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q96);

        var Q97 = new Questao();
        Q97.Nivel = 10;
        Q97.pergunta = "Qual é a arma usada por Yae Miko?";
        Q97.resposta1 = "Catalisador **(Resposta correta)**";
        Q97.resposta2 = "Espada";
        Q97.resposta3 = "Arco";
        Q97.resposta4 = "Lança";
        Q97.resposta5 = "Grande espada";
        Q97.respostaCorreta = 1;
        Q97.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q97);

        var Q98 = new Questao();
        Q98.Nivel = 10;
        Q98.pergunta = "Qual é o elemento de Xiangling?";
        Q98.resposta1 = "Cryo";
        Q98.resposta2 = "Geo";
        Q98.resposta3 = "Electro";
        Q98.resposta4 = "Pyro **(Resposta correta)**";
        Q98.resposta5 = "Anemo";
        Q98.respostaCorreta = 4;
        Q98.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q98);

        var Q99 = new Questao();
        Q99.Nivel = 10;
        Q99.pergunta = "Qual é a habilidade suprema de Albedo?";
        Q99.resposta1 = "Chalk Prince **(Resposta correta)**";
        Q99.resposta2 = "Flower of Eden";
        Q99.resposta3 = "Geo Pulse";
        Q99.resposta4 = "Divine Garden";
        Q99.resposta5 = "Crystal Blast";
        Q99.respostaCorreta = 1;
        Q99.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q99);

        var Q100 = new Questao();
        Q100.Nivel = 10;
        Q100.pergunta = "Quem é conhecido como o 'Príncipe da Casa de Guías'?";
        Q100.resposta1 = "Zhongli";
        Q100.resposta2 = "Albedo";
        Q100.resposta3 = "Tartaglia";
        Q100.resposta4 = "Diluc";
        Q100.resposta5 = "Kaeya";
        Q100.respostaCorreta = 2;
        Q100.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q100);

        ProximaPergunta();

    }


}