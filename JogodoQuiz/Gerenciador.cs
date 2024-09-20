namespace JogodoQuiz;

public class Gerenciador
{
    List<Questao> ListaQuestoes=new List<Questao>();
    List<int> ListaQuestoesRespondidas=new List<int>();
    Questao QuestaoAtual;

    public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
    {
        CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    }

    void CriaPerguntas(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
    {
        var Q1=new Questao();
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
            ProximaQuestao();
        }
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
}

