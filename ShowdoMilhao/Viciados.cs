namespace ShowdoMilhao;
public class Viciados : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
var porcentagem = 100;
for (int i = 0; i< 5; i ++)
{
    int numRandomico = 0;
    if (porcentagem > 0)
    {
        numRandomico = Random.Shared.Next(0, porcentagem);
        porcentagem -= numRandomico;
    }
    switch (i)
    {
        case 0:
        buttonResposta1.Text += "-" + numRandomico.ToString() + "%";
        break;
        case 1:
        buttonResposta2.Text += "-" + numRandomico.ToString() + "%";
        break;
        case 2:
        buttonResposta3.Text += "-" + numRandomico.ToString() + "%";
        break;
        case 3:
        buttonResposta4.Text += "-" + numRandomico.ToString() + "%";
        break;
        case 4:
        buttonResposta5.Text += "-" + numRandomico.ToString() + "%";
        break;
     
    }
   }
  }
} 