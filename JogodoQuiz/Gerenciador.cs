namespace JogodoQuiz;

public class Gerenciador
{
    public int Pontuacao { get; private set; }
    int NivelAtual=1;
    List<Questao> ListaQuestoes=new List<Questao>();
    List<int> ListaQuestoesRespondidas=new List<int>();
    Questao QuestaoAtual;
    Label LabelPont;
    Label LabelNivel;

    public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05, Label labelPont, Label labelNivel)
    {
        LabelPont = labelPont;
        LabelNivel = labelNivel;
        CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        
    }

    void CriaPerguntas(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
    {
        var Q1=new Questao();
        Q1.nivelpergunta=1;
        Q1.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q1.pergunta="Quanto é 3+2?";
        Q1.resposta1="2";
        Q1.resposta2="30";
        Q1.resposta3="7";
        Q1.resposta4="5";
        Q1.resposta5="Sim";
        Q1.respostacorreta=04;
        ListaQuestoes.Add(Q1);

        var Q2=new Questao();
        Q2.nivelpergunta=1;
        Q2.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q2.pergunta="Quem descobriu o Brasil?";
        Q2.resposta1="Dom Pedro I";
        Q2.resposta2="Pedro Álvares Cabral";
        Q2.resposta3="Princesa Isabel";
        Q2.resposta4="Albert Einstein";
        Q2.resposta5="Marechal Deodoro";
        Q2.respostacorreta=02;
        ListaQuestoes.Add(Q2);

        ProximaQuestao();
    }

    public async void VerificaResposta(int RR)
    {
        
        if (QuestaoAtual.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await Task.Delay(1000);

            await App.Current.MainPage.DisplayAlert("Fim", "Você errou", "Ok");
            Inicializar();
        }
        LabelPont.Text="Pontuação:R$"+Pontuacao.ToString();
        LabelNivel.Text="Nível:"+NivelAtual.ToString();
    }

    void ProximaQuestao()
    {
        
        var numAleat=Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
            numAleat=Random.Shared.Next(0, ListaQuestoes.Count);

        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoAtual=ListaQuestoes[numAleat];
        QuestaoAtual.desenhar();
    }

    void Inicializar()
    {
        LabelPont.Text="Pontuação:R$"+Pontuacao.ToString();
        LabelNivel.Text="Nível:"+NivelAtual.ToString();
        Pontuacao=0;
        NivelAtual=1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if(n==1)
            Pontuacao=1000;
        else if(n==2)
            Pontuacao=2000;
        else if(n==3)
            Pontuacao=5000;
        else if(n==4)
            Pontuacao=10000;
        else if(n==5)
            Pontuacao=20000;
        else if(n==6)
            Pontuacao=50000;
        else if(n==7)
            Pontuacao=100000;
        else if(n==8)
            Pontuacao=200000;
        else if(n==9)
            Pontuacao=500000;
        else 
            Pontuacao=1000000;
        
    }
}

