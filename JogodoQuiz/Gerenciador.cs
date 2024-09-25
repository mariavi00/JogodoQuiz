namespace JogodoQuiz;

public class Gerenciador
{
    public int Pontuacao { get; private set; }
    int NivelAtual = 1;
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
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
        var Q1 = new Questao();
        Q1.nivelpergunta = 1;
        Q1.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q1.pergunta = "Quanto é 3+2?";
        Q1.resposta1 = "2";
        Q1.resposta2 = "30";
        Q1.resposta3 = "7";
        Q1.resposta4 = "5";
        Q1.resposta5 = "Sim";
        Q1.respostacorreta = 04;
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.nivelpergunta = 1;
        Q2.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q2.pergunta = "Quem descobriu o Brasil?";
        Q2.resposta1 = "Dom Pedro I";
        Q2.resposta2 = "Pedro Álvares Cabral";
        Q2.resposta3 = "Princesa Isabel";
        Q2.resposta4 = "Albert Einstein";
        Q2.resposta5 = "Marechal Deodoro";
        Q2.respostacorreta = 02;
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.nivelpergunta = 1;
        Q3.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q3.pergunta = "Qual a capital do Brasil?";
        Q3.resposta1 = "Rio de Janeiro";
        Q3.resposta2 = "São Paulo";
        Q3.resposta3 = "Brasília";
        Q3.resposta4 = "Salvador";
        Q3.resposta5 = "Belo Horizonte";
        Q3.respostacorreta = 03;
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.nivelpergunta = 1;
        Q4.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q4.pergunta = "Qual o maior planeta do sistema solar?";
        Q4.resposta1 = "Terra";
        Q4.resposta2 = "Marte";
        Q4.resposta3 = "Saturno";
        Q4.resposta4 = "Júpiter";
        Q4.resposta5 = "Urano";
        Q4.respostacorreta = 04;
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.nivelpergunta = 1;
        Q5.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q5.pergunta = "Quantos continentes existem no mundo?";
        Q5.resposta1 = "2";
        Q5.resposta2 = "30";
        Q5.resposta3 = "7";
        Q5.resposta4 = "3";
        Q5.resposta5 = "5";
        Q5.respostacorreta = 05;
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.nivelpergunta = 1;
        Q6.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q6.pergunta = "Qual o símbolo químico da água?";
        Q6.resposta1 = "O2";
        Q6.resposta2 = "H2O";
        Q6.resposta3 = "NaCl";
        Q6.resposta4 = "CO2";
        Q6.resposta5 = "HCl";
        Q6.respostacorreta = 02;
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.nivelpergunta = 1;
        Q7.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q7.pergunta = "Qual animal é conhecido como 'rei da selva'?";
        Q7.resposta1 = "Elefante";
        Q7.resposta2 = "Tigre";
        Q7.resposta3 = "Urso";
        Q7.resposta4 = "Leão";
        Q7.resposta5 = "Gorila";
        Q7.respostacorreta = 04;
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.nivelpergunta = 1;
        Q8.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q8.pergunta = "Qual é a moeda usada nos Estados Unidos?";
        Q8.resposta1 = "Real";
        Q8.resposta2 = "Dólar";
        Q8.resposta3 = "Euro";
        Q8.resposta4 = "Libra";
        Q8.resposta5 = "Iene";
        Q8.respostacorreta = 02;
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.nivelpergunta = 1;
        Q9.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q9.pergunta = "Qual é o maior osso do corpo humano?";
        Q9.resposta1 = "Úmero";
        Q9.resposta2 = "Tíbia";
        Q9.resposta3 = "Escápula";
        Q9.resposta4 = "Rádio";
        Q9.resposta5 = "Fêmur";
        Q9.respostacorreta = 05;
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.nivelpergunta = 1;
        Q10.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q10.pergunta = "Qual é o principal órgão do sistema circulatório?";
        Q10.resposta1 = "Coração";
        Q10.resposta2 = "Rim";
        Q10.resposta3 = "Pulmão";
        Q10.resposta4 = "Fígado";
        Q10.resposta5 = "Estômago";
        Q10.respostacorreta = 01;
        ListaQuestoes.Add(Q10);

        var Q11 = new Questao();
        Q11.nivelpergunta = 1;
        Q11.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q11.pergunta = "Qual é o menor país do mundo?";
        Q11.resposta1 = "Mônaco";
        Q11.resposta2 = "Vaticano";
        Q11.resposta3 = "Malta";
        Q11.resposta4 = "Liechtenstein";
        Q11.resposta5 = "San Marino";
        Q11.respostacorreta = 02;
        ListaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.nivelpergunta = 1;
        Q12.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q12.pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
        Q12.resposta1 = "1969";
        Q12.resposta2 = "1970";
        Q12.resposta3 = "1967";
        Q12.resposta4 = "1972";
        Q12.resposta5 = "1968";
        Q12.respostacorreta = 01;
        ListaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.nivelpergunta = 1;
        Q13.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q13.pergunta = "Qual o maior oceano do mundo?";
        Q13.resposta1 = "Atlântico";
        Q13.resposta2 = "Índico";
        Q13.resposta3 = "Pacífico";
        Q13.resposta4 = "Ártico";
        Q13.resposta5 = "Antártico";
        Q13.respostacorreta = 03;
        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.nivelpergunta = 1;
        Q14.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q14.pergunta = "Qual o país mais populoso do mundo?";
        Q14.resposta1 = "Estados Unidos";
        Q14.resposta2 = "Índia";
        Q14.resposta3 = "Rússia";
        Q14.resposta4 = "Brasil";
        Q14.resposta5 = "China";
        Q14.respostacorreta = 05;
        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.nivelpergunta = 1;
        Q15.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q15.pergunta = "Qual o idioma oficial do Brasil?";
        Q15.resposta1 = "Espanhol";
        Q15.resposta2 = "Inglês";
        Q15.resposta3 = "Português";
        Q15.resposta4 = "Francês";
        Q15.resposta5 = "Italiano";
        Q15.respostacorreta = 03;
        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.nivelpergunta = 1;
        Q16.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q16.pergunta = "Quantos minutos há em uma hora?";
        Q16.resposta1 = "60";
        Q16.resposta2 = "120";
        Q16.resposta3 = "90";
        Q16.resposta4 = "80";
        Q16.resposta5 = "50";
        Q16.respostacorreta = 01;
        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.nivelpergunta = 1;
        Q17.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q17.pergunta = "Qual é o número 5 em algarismos romanos?";
        Q17.resposta1 = "I";
        Q17.resposta2 = "X";
        Q17.resposta3 = "V";
        Q17.resposta4 = "IV";
        Q17.resposta5 = "VI";
        Q17.respostacorreta = 03;
        ListaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.nivelpergunta = 1;
        Q18.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q18.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q18.resposta1 = "Machado de Assis";
        Q18.resposta2 = "José de Alencar";
        Q18.resposta3 = "Clarice Lispector";
        Q18.resposta4 = "Carlos Drummond de Andrade";
        Q18.resposta5 = "Graciliano Ramos";
        Q18.respostacorreta = 01;
        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.nivelpergunta = 1;
        Q19.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q19.pergunta = "Quem pintou a Mona Lisa?";
        Q19.resposta1 = "Vincent Van Gogh";
        Q19.resposta2 = "Pablo Picasso";
        Q19.resposta3 = "Michelangelo";
        Q19.resposta4 = "Leonardo da Vinci";
        Q19.resposta5 = "Rembrandt";
        Q19.respostacorreta = 04;
        ListaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.nivelpergunta = 1;
        Q20.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q20.pergunta = "Qual o maior órgão do corpo humano?";
        Q20.resposta1 = "Coração";
        Q20.resposta2 = "Fígado";
        Q20.resposta3 = "Pele";
        Q20.resposta4 = "Cérebro";
        Q20.resposta5 = "Estômago";
        Q20.respostacorreta = 03;
        ListaQuestoes.Add(Q20);

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

        if (NivelAtual == 10)
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Você ganhou!!", "Ok");
            Inicializar();
        }

        LabelPont.Text = "Pontuação:R$" + Pontuacao.ToString();
        LabelNivel.Text = "Nível:" + NivelAtual.ToString();
    }

    void ProximaQuestao()
    {

        var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
            numAleat = Random.Shared.Next(0, ListaQuestoes.Count);

        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoAtual = ListaQuestoes[numAleat];
        QuestaoAtual.desenhar();
    }

    void Inicializar()
    {
        ListaQuestoesRespondidas.Clear();
        LabelPont.Text = "Pontuação:R$" + Pontuacao.ToString();
        LabelNivel.Text = "Nível:" + NivelAtual.ToString();
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if (n == 1)
            Pontuacao = 1000;
        else if (n == 2)
            Pontuacao = 2000;
        else if (n == 3)
            Pontuacao = 5000;
        else if (n == 4)
            Pontuacao = 10000;
        else if (n == 5)
            Pontuacao = 20000;
        else if (n == 6)
            Pontuacao = 50000;
        else if (n == 7)
            Pontuacao = 100000;
        else if (n == 8)
            Pontuacao = 200000;
        else if (n == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;

    }
}

