namespace ShowdoMilhao;

public class Questao : IEquatable<Questao>
{

    public string pergunta;

    public string resposta1;

    public string resposta2;

    public string resposta3;

    public string resposta4;

    public string resposta5;

    public int respostaCorreta;

    public int Nivel;

    Label labelPergunta;

    Button buttonResposta1;

    Button buttonResposta2;

    Button buttonResposta3;

    Button buttonResposta4;

    Button buttonResposta5;

    public void Desenhar()
    {
        labelPergunta.Text = pergunta;
        buttonResposta1.Text = resposta1;
        buttonResposta2.Text = resposta2;
        buttonResposta3.Text = resposta3;
        buttonResposta4.Text = resposta4;
        buttonResposta5.Text = resposta5;

        this.buttonResposta1!.BackgroundColor = Color.FromArgb("#ffe591");
        this.buttonResposta1!.TextColor = Color.FromArgb("#f8a23b");
        this.buttonResposta2!.BackgroundColor = Color.FromArgb("#ffe591");
        this.buttonResposta2!.TextColor = Color.FromArgb("#f8a23b");
        this.buttonResposta3!.BackgroundColor = Color.FromArgb("#ffe591");
        this.buttonResposta3!.TextColor = Color.FromArgb("#f8a23b");
        this.buttonResposta4!.BackgroundColor = Color.FromArgb("#ffe591");
        this.buttonResposta4!.TextColor = Color.FromArgb("#f8a23b");
        this.buttonResposta5!.BackgroundColor = Color.FromArgb("#ffe591");
        this.buttonResposta5!.TextColor = Color.FromArgb("#f8a23b");


    }
    public bool Equals(Questao q)
    {
        return this.Nivel == q.Nivel && this.pergunta == q.pergunta;
    }

    private Button buttonEscolhido(int respostaEscolhida)
    {
        if (respostaEscolhida == 1)
        return buttonResposta1;
        else if (respostaEscolhida == 2)
        return buttonResposta2;
        else if (respostaEscolhida == 3)
        return buttonResposta3;
        else if (respostaEscolhida == 4)
        return buttonResposta4;
        else if (respostaEscolhida == 5)
        return buttonResposta5;
        else
        return null;
    }

    public bool VerifiicarResposta(int respostaescolhida)
    {
        if (respostaCorreta == respostaescolhida)
        {
            var verificacao = buttonEscolhido(respostaescolhida);
            verificacao.BackgroundColor = Colors.Green;
            return true;
        }
        else
        {
            var verificacaoCorreto = buttonEscolhido(respostaCorreta);
            var verificacaoIncorreto = buttonEscolhido(respostaescolhida);
            verificacaoCorreto.BackgroundColor = Colors.Yellow;
            verificacaoIncorreto.BackgroundColor = Colors.Red;
            return false;
        }
    }
    
    public void ConfigurarEstruturaDesenho(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
    {
        labelPergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
    }

    public Questao()
    {

    }

    public Questao(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
    {
        labelPergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
    }

}