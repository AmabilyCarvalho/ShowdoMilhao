using ShowdoMilhao;

namespace ShowdoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestao = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;
    
    Label labelPontuacao;
    Label labelNivel;
    int Pontuacao;

    public int Pontuação { get; private set; }
    int NivelAtual = 0;
    private Label labelPergunta;
    private Button buttonResposta1;
    private Button buttonResposta2;
    private Button buttonResposta3;
    private Button buttonResposta4;
    private Button buttonResposta5;

    void Inicializar()
    {
        Pontuação = 0;
        NivelAtual = 0;
        ProximaPergunta();
    }
    public Gerenciador(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5,Label labelPontuacao, Label labelNivel)

    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }

    public Gerenciador(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        this.labelPergunta = labelPergunta;
        this.buttonResposta1 = buttonResposta1;
        this.buttonResposta2 = buttonResposta2;
        this.buttonResposta3 = buttonResposta3;
        this.buttonResposta4 = buttonResposta4;
        this.buttonResposta5 = buttonResposta5;
    }

    public void ProximaPergunta()
    {
        var numRandomico = Random.Shared.Next(0, ListaQuestao.Count - 1);
        while (ListaQuestoesRespondidas.Contains(numRandomico))
            numRandomico = Random.Shared.Next(0, ListaQuestoesRespondidas.Count - 1);
        ListaQuestoesRespondidas.Add(numRandomico);
        questaoCorrente = ListaQuestao[numRandomico];
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
        Q19.resposta5 = "Companheira";
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
        Q40.pergunta = "Party System";
        Q40.resposta1 = "Tempestade do Raio";
        Q40.resposta2 = "Team Play";
        Q40.resposta3 = "Multiplayer";
        Q40.resposta4 = "Cooperative";
        Q40.resposta5 = "Humilhation";
        Q40.respostaCorreta = 3;
        Q40.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestao.Add(Q40);

    }

      public async void VerificaCorreto(int resposta)
    {
        if (questaoCorrente!.VerifiicarResposta(resposta))
        {
            await Task.Delay(1000);
            labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
            labelNivel.Text = "Nivel" + NivelAtual.ToString();
            AdicionarPontuacao(NivelAtual);
            NivelAtual++;
            ProximaPergunta();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("fim de jogo", "você é ruim de mais pra continuar", "Tentar Novamente");
            Inicializar();
        }
        void AdicionarPontuacao (int n)
        {

        }
    }


}