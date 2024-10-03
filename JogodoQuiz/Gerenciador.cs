namespace JogodoQuiz;

public class Gerenciador
{
    public int Pontuacao { get; private set; }
    int NivelAtual = 1;
    List<Questao> ListaTodasQuestoes = new List<Questao>();
    List<Questao> ListaTodasQuestoesRespondidas = new List<Questao>();
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
Q1.pergunta = "Quanto é 3 + 2?";
Q1.resposta1 = "2";
Q1.resposta2 = "30";
Q1.resposta3 = "7";
Q1.resposta4 = "5";
Q1.resposta5 = "Sim";
Q1.respostacorreta = 04;
ListaTodasQuestoes.Add(Q1);

var Q2 = new Questao();
Q2.nivelpergunta = 1;
Q2.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q2.pergunta = "Qual a capital do Brasil?";
Q2.resposta1 = "São Paulo";
Q2.resposta2 = "Brasília";
Q2.resposta3 = "Rio de Janeiro";
Q2.resposta4 = "Salvador";
Q2.resposta5 = "Fortaleza";
Q2.respostacorreta = 02;
ListaTodasQuestoes.Add(Q2);

var Q3 = new Questao();
Q3.nivelpergunta = 1;
Q3.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q3.pergunta = "Qual o continente onde se encontra o Egito?";
Q3.resposta1 = "África";
Q3.resposta2 = "Ásia";
Q3.resposta3 = "América";
Q3.resposta4 = "Europa";
Q3.resposta5 = "Oceania";
Q3.respostacorreta = 01;
ListaTodasQuestoes.Add(Q3);

var Q4 = new Questao();
Q4.nivelpergunta = 1;
Q4.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q4.pergunta = "Quantas cores tem o arco-íris?";
Q4.resposta1 = "5";
Q4.resposta2 = "6";
Q4.resposta3 = "7";
Q4.resposta4 = "8";
Q4.resposta5 = "9";
Q4.respostacorreta = 03;
ListaTodasQuestoes.Add(Q4);

var Q5 = new Questao();
Q5.nivelpergunta = 1;
Q5.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q5.pergunta = "Qual é a capital da França?";
Q5.resposta1 = "Londres";
Q5.resposta2 = "Paris";
Q5.resposta3 = "Berlim";
Q5.resposta4 = "Madrid";
Q5.resposta5 = "Roma";
Q5.respostacorreta = 02;
ListaTodasQuestoes.Add(Q5);

var Q6 = new Questao();
Q6.nivelpergunta = 1;
Q6.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q6.pergunta = "Qual animal é conhecido como o 'rei da selva'?";
Q6.resposta1 = "Elefante";
Q6.resposta2 = "Leão";
Q6.resposta3 = "Tigre";
Q6.resposta4 = "Urso";
Q6.resposta5 = "Crocodilo";
Q6.respostacorreta = 02;
ListaTodasQuestoes.Add(Q6);

var Q7 = new Questao();
Q7.nivelpergunta = 1;
Q7.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q7.pergunta = "Quantos dedos tem uma mão?";
Q7.resposta1 = "4";
Q7.resposta2 = "5";
Q7.resposta3 = "6";
Q7.resposta4 = "7";
Q7.resposta5 = "8";
Q7.respostacorreta = 02;
ListaTodasQuestoes.Add(Q7);

var Q8 = new Questao();
Q8.nivelpergunta = 1;
Q8.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q8.pergunta = "Qual é a cor do céu em um dia limpo?";
Q8.resposta1 = "Verde";
Q8.resposta2 = "Azul";
Q8.resposta3 = "Vermelho";
Q8.resposta4 = "Amarelo";
Q8.resposta5 = "Cinza";
Q8.respostacorreta = 02;
ListaTodasQuestoes.Add(Q8);

var Q9 = new Questao();
Q9.nivelpergunta = 1;
Q9.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q9.pergunta = "Qual é a capital do Brasil?";
Q9.resposta1 = "São Paulo";
Q9.resposta2 = "Brasília";
Q9.resposta3 = "Rio de Janeiro";
Q9.resposta4 = "Salvador";
Q9.resposta5 = "Fortaleza";
Q9.respostacorreta = 02;
ListaTodasQuestoes.Add(Q9);

var Q10 = new Questao();
Q10.nivelpergunta = 1;
Q10.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q10.pergunta = "Qual é a cor da grama?";
Q10.resposta1 = "Verde";
Q10.resposta2 = "Amarelo";
Q10.resposta3 = "Azul";
Q10.resposta4 = "Vermelho";
Q10.resposta5 = "Branco";
Q10.respostacorreta = 01;
ListaTodasQuestoes.Add(Q10);

var Q11 = new Questao();
Q11.nivelpergunta = 2;
Q11.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q11.pergunta = "Qual é o maior planeta do sistema solar?";
Q11.resposta1 = "Terra";
Q11.resposta2 = "Marte";
Q11.resposta3 = "Júpiter";
Q11.resposta4 = "Saturno";
Q11.resposta5 = "Netuno";
Q11.respostacorreta = 03;
ListaTodasQuestoes.Add(Q11);

var Q12 = new Questao();
Q12.nivelpergunta = 2;
Q12.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q12.pergunta = "Qual é o símbolo químico do Oxigênio?";
Q12.resposta1 = "O";
Q12.resposta2 = "Ox";
Q12.resposta3 = "O2";
Q12.resposta4 = "O3";
Q12.resposta5 = "H2O";
Q12.respostacorreta = 01;
ListaTodasQuestoes.Add(Q12);

var Q13 = new Questao();
Q13.nivelpergunta = 2;
Q13.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q13.pergunta = "Qual o planeta mais próximo do sol?";
Q13.resposta1 = "Mercúrio";
Q13.resposta2 = "Vênus";
Q13.resposta3 = "Terra";
Q13.resposta4 = "Marte";
Q13.resposta5 = "Júpiter";
Q13.respostacorreta = 01;
ListaTodasQuestoes.Add(Q13);

var Q14 = new Questao();
Q14.nivelpergunta = 2;
Q14.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q14.pergunta = "Quantos estados tem o Brasil?";
Q14.resposta1 = "24";
Q14.resposta2 = "25";
Q14.resposta3 = "26";
Q14.resposta4 = "27";
Q14.resposta5 = "28";
Q14.respostacorreta = 04;
ListaTodasQuestoes.Add(Q14);

var Q15 = new Questao();
Q15.nivelpergunta = 2;
Q15.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q15.pergunta = "Quantos planetas existem no sistema solar?";
Q15.resposta1 = "7";
Q15.resposta2 = "8";
Q15.resposta3 = "9";
Q15.resposta4 = "10";
Q15.resposta5 = "11";
Q15.respostacorreta = 02;
ListaTodasQuestoes.Add(Q15);

var Q16 = new Questao();
Q16.nivelpergunta = 2;
Q16.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q16.pergunta = "Qual é o maior animal terrestre?";
Q16.resposta1 = "Rinoceronte";
Q16.resposta2 = "Elefante";
Q16.resposta3 = "Girafa";
Q16.resposta4 = "Hipopótamo";
Q16.resposta5 = "Urso";
Q16.respostacorreta = 02;
ListaTodasQuestoes.Add(Q16);

var Q17 = new Questao();
Q17.nivelpergunta = 2;
Q17.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q17.pergunta = "Qual é a capital do Egito?";
Q17.resposta1 = "Cairo";
Q17.resposta2 = "Alexandria";
Q17.resposta3 = "Lúxor";
Q17.resposta4 = "Aswan";
Q17.resposta5 = "Porto Saíd";
Q17.respostacorreta = 01;
ListaTodasQuestoes.Add(Q17);

var Q18 = new Questao();
Q18.nivelpergunta = 2;
Q18.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q18.pergunta = "Qual é a cor da bandeira do Brasil?";
Q18.resposta1 = "Azul";
Q18.resposta2 = "Verde";
Q18.resposta3 = "Amarelo";
Q18.resposta4 = "Branco";
Q18.resposta5 = "Vermelho";
Q18.respostacorreta = 02;
ListaTodasQuestoes.Add(Q18);

var Q19 = new Questao();
Q19.nivelpergunta = 2;
Q19.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q19.pergunta = "Qual é a capital da Argentina?";
Q19.resposta1 = "Buenos Aires";
Q19.resposta2 = "Santiago";
Q19.resposta3 = "Lima";
Q19.resposta4 = "Montevidéu";
Q19.resposta5 = "Assunção";
Q19.respostacorreta = 01;
ListaTodasQuestoes.Add(Q19);

var Q20 = new Questao();
Q20.nivelpergunta = 2;
Q20.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q20.pergunta = "Qual é a capital da Rússia?";
Q20.resposta1 = "Moscovo";
Q20.resposta2 = "São Petersburgo";
Q20.resposta3 = "Kazan";
Q20.resposta4 = "Nizhny Novgorod";
Q20.resposta5 = "Novosibirsk";
Q20.respostacorreta = 01;
ListaTodasQuestoes.Add(Q20);

var Q21 = new Questao();
Q21.nivelpergunta = 3;
Q21.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q21.pergunta = "Quem escreveu 'Dom Casmurro'?";
Q21.resposta1 = "Machado de Assis";
Q21.resposta2 = "Jorge Amado";
Q21.resposta3 = "José de Alencar";
Q21.resposta4 = "Clarice Lispector";
Q21.resposta5 = "Guimarães Rosa";
Q21.respostacorreta = 01;
ListaTodasQuestoes.Add(Q21);

var Q22 = new Questao();
Q22.nivelpergunta = 3;
Q22.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q22.pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
Q22.resposta1 = "1965";
Q22.resposta2 = "1969";
Q22.resposta3 = "1971";
Q22.resposta4 = "1980";
Q22.resposta5 = "1990";
Q22.respostacorreta = 02;
ListaTodasQuestoes.Add(Q22);

var Q23 = new Questao();
Q23.nivelpergunta = 3;
Q23.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q23.pergunta = "Quem foi o autor de 'O Alquimista'?";
Q23.resposta1 = "Paulo Coelho";
Q23.resposta2 = "J.K. Rowling";
Q23.resposta3 = "George Orwell";
Q23.resposta4 = "Gabriel García Márquez";
Q23.resposta5 = "Ernest Hemingway";
Q23.respostacorreta = 01;
ListaTodasQuestoes.Add(Q23);

var Q24 = new Questao();
Q24.nivelpergunta = 3;
Q24.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q24.pergunta = "Qual é a capital do Japão?";
Q24.resposta1 = "Tóquio";
Q24.resposta2 = "Pequim";
Q24.resposta3 = "Seul";
Q24.resposta4 = "Bangkok";
Q24.resposta5 = "Hanoi";
Q24.respostacorreta = 01;
ListaTodasQuestoes.Add(Q24);

var Q25 = new Questao();
Q25.nivelpergunta = 3;
Q25.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q25.pergunta = "Qual é o maior mamífero do mundo?";
Q25.resposta1 = "Elefante";
Q25.resposta2 = "Baleia Azul";
Q25.resposta3 = "Girafa";
Q25.resposta4 = "Tubarão";
Q25.resposta5 = "Hipopótamo";
Q25.respostacorreta = 02;
ListaTodasQuestoes.Add(Q25);

var Q26 = new Questao();
Q26.nivelpergunta = 3;
Q26.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q26.pergunta = "Qual é a capital do Canadá?";
Q26.resposta1 = "Toronto";
Q26.resposta2 = "Vancouver";
Q26.resposta3 = "Ottawa";
Q26.resposta4 = "Montreal";
Q26.resposta5 = "Calgary";
Q26.respostacorreta = 03;
ListaTodasQuestoes.Add(Q26);

var Q27 = new Questao();
Q27.nivelpergunta = 3;
Q27.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q27.pergunta = "Qual é o nome do famoso castelo na Escócia?";
Q27.resposta1 = "Castelo de Edimburgo";
Q27.resposta2 = "Castelo de Windsor";
Q27.resposta3 = "Castelo de Neuschwanstein";
Q27.resposta4 = "Castelo de Versalhes";
Q27.resposta5 = "Castelo de Dublin";
Q27.respostacorreta = 01;
ListaTodasQuestoes.Add(Q27);

var Q28 = new Questao();
Q28.nivelpergunta = 3;
Q28.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q28.pergunta = "Qual é o idioma oficial da Espanha?";
Q28.resposta1 = "Francês";
Q28.resposta2 = "Alemão";
Q28.resposta3 = "Espanhol";
Q28.resposta4 = "Italiano";
Q28.resposta5 = "Português";
Q28.respostacorreta = 03;
ListaTodasQuestoes.Add(Q28);

var Q29 = new Questao();
Q29.nivelpergunta = 3;
Q29.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q29.pergunta = "Qual é o animal símbolo da Austrália?";
Q29.resposta1 = "Canguru";
Q29.resposta2 = "Coala";
Q29.resposta3 = "Kiwi";
Q29.resposta4 = "Panda";
Q29.resposta5 = "Lobo";
Q29.respostacorreta = 01;
ListaTodasQuestoes.Add(Q29);

var Q30 = new Questao();
Q30.nivelpergunta = 3;
Q30.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q30.pergunta = "Qual é a moeda oficial do Japão?";
Q30.resposta1 = "Yuan";
Q30.resposta2 = "Won";
Q30.resposta3 = "Dólar";
Q30.resposta4 = "Iene";
Q30.resposta5 = "Rupia";
Q30.respostacorreta = 04;
ListaTodasQuestoes.Add(Q30);

var Q31 = new Questao();
Q31.nivelpergunta = 4;
Q31.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q31.pergunta = "Qual é a fórmula da água?";
Q31.resposta1 = "CO2";
Q31.resposta2 = "H2O";
Q31.resposta3 = "O2";
Q31.resposta4 = "N2";
Q31.resposta5 = "CH4";
Q31.respostacorreta = 02;
ListaTodasQuestoes.Add(Q31);

var Q32 = new Questao();
Q32.nivelpergunta = 4;
Q32.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q32.pergunta = "Qual o maior oceano do mundo?";
Q32.resposta1 = "Atlântico";
Q32.resposta2 = "Índico";
Q32.resposta3 = "Ártico";
Q32.resposta4 = "Pacífico";
Q32.resposta5 = "Antártico";
Q32.respostacorreta = 04;
ListaTodasQuestoes.Add(Q32);

var Q33 = new Questao();
Q33.nivelpergunta = 4;
Q33.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q33.pergunta = "Qual é o maior continente do mundo?";
Q33.resposta1 = "África";
Q33.resposta2 = "América do Norte";
Q33.resposta3 = "Ásia";
Q33.resposta4 = "Europa";
Q33.resposta5 = "Oceania";
Q33.respostacorreta = 03;
ListaTodasQuestoes.Add(Q33);

var Q34 = new Questao();
Q34.nivelpergunta = 4;
Q34.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q34.pergunta = "Qual é o menor país do mundo?";
Q34.resposta1 = "Mônaco";
Q34.resposta2 = "Nauru";
Q34.resposta3 = "Vaticano";
Q34.resposta4 = "San Marino";
Q34.resposta5 = "Malta";
Q34.respostacorreta = 03;
ListaTodasQuestoes.Add(Q34);

var Q35 = new Questao();
Q35.nivelpergunta = 4;
Q35.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q35.pergunta = "Em que continente está localizado o Brasil?";
Q35.resposta1 = "África";
Q35.resposta2 = "América do Sul";
Q35.resposta3 = "Ásia";
Q35.resposta4 = "Europa";
Q35.resposta5 = "Oceania";
Q35.respostacorreta = 02;
ListaTodasQuestoes.Add(Q35);

var Q36 = new Questao();
Q36.nivelpergunta = 4;
Q36.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q36.pergunta = "Qual é a moeda oficial do Japão?";
Q36.resposta1 = "Yuan";
Q36.resposta2 = "Won";
Q36.resposta3 = "Dólar";
Q36.resposta4 = "Iene";
Q36.resposta5 = "Euro";
Q36.respostacorreta = 04;
ListaTodasQuestoes.Add(Q36);

var Q37 = new Questao();
Q37.nivelpergunta = 4;
Q37.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q37.pergunta = "Quem é o autor de '1984'?";
Q37.resposta1 = "Aldous Huxley";
Q37.resposta2 = "Ray Bradbury";
Q37.resposta3 = "George Orwell";
Q37.resposta4 = "Fahrenheit";
Q37.resposta5 = "Mark Twain";
Q37.respostacorreta = 03;
ListaTodasQuestoes.Add(Q37);

var Q38 = new Questao();
Q38.nivelpergunta = 4;
Q38.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q38.pergunta = "Qual é a unidade de medida de temperatura no sistema métrico?";
Q38.resposta1 = "Celsius";
Q38.resposta2 = "Fahrenheit";
Q38.resposta3 = "Kelvin";
Q38.resposta4 = "Rankine";
Q38.resposta5 = "Reaumur";
Q38.respostacorreta = 01;
ListaTodasQuestoes.Add(Q38);

var Q39 = new Questao();
Q39.nivelpergunta = 4;
Q39.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q39.pergunta = "Qual é a capital da Itália?";
Q39.resposta1 = "Roma";
Q39.resposta2 = "Milão";
Q39.resposta3 = "Nápoles";
Q39.resposta4 = "Florença";
Q39.resposta5 = "Veneza";
Q39.respostacorreta = 01;
ListaTodasQuestoes.Add(Q39);

var Q40 = new Questao();
Q40.nivelpergunta = 4;
Q40.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q40.pergunta = "Qual é o planeta conhecido como 'Planeta Vermelho'?";
Q40.resposta1 = "Marte";
Q40.resposta2 = "Vênus";
Q40.resposta3 = "Saturno";
Q40.resposta4 = "Mercúrio";
Q40.resposta5 = "Júpiter";
Q40.respostacorreta = 01;
ListaTodasQuestoes.Add(Q40);

// Nível 5
var Q44 = new Questao();
Q44.nivelpergunta = 5;
Q44.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q44.pergunta = "Qual é o elemento químico com o símbolo 'Fe'?";
Q44.resposta1 = "Ferro";
Q44.resposta2 = "Fósforo";
Q44.resposta3 = "Flúor";
Q44.resposta4 = "Estanho";
Q44.resposta5 = "Zinco";
Q44.respostacorreta = 01;
ListaTodasQuestoes.Add(Q44);

// Nível 6
var Q43 = new Questao();
Q43.nivelpergunta = 6;
Q43.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q43.pergunta = "Quem pintou a Mona Lisa?";
Q43.resposta1 = "Vincent van Gogh";
Q43.resposta2 = "Pablo Picasso";
Q43.resposta3 = "Leonardo da Vinci";
Q43.resposta4 = "Claude Monet";
Q43.resposta5 = "Salvador Dalí";
Q43.respostacorreta = 03;
ListaTodasQuestoes.Add(Q43);

// Nível 7
var Q45 = new Questao();
Q45.nivelpergunta = 7;
Q45.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q45.pergunta = "Qual é a moeda do Japão?";
Q45.resposta1 = "Yuan";
Q45.resposta2 = "Won";
Q45.resposta3 = "Dólar";
Q45.resposta4 = "Iene";
Q45.resposta5 = "Peso";
Q45.respostacorreta = 04;
ListaTodasQuestoes.Add(Q45);

// Nível 8
var Q52 = new Questao();
Q52.nivelpergunta = 8;
Q52.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q52.pergunta = "Qual é a montanha mais alta do mundo?";
Q52.resposta1 = "K2";
Q52.resposta2 = "Kilimanjaro";
Q52.resposta3 = "Monte Everest";
Q52.resposta4 = "Aconcágua";
Q52.resposta5 = "Makalu";
Q52.respostacorreta = 03;
ListaTodasQuestoes.Add(Q52);

// Nível 9
var Q10 = new Questao();
Q10.nivelpergunta = 9;
Q10.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q10.pergunta = "Qual foi a primeira civilização da história?";
Q10.resposta1 = "Egípcia";
Q10.resposta2 = "Mesopotâmica";
Q10.resposta3 = "Grega";
Q10.resposta4 = "Romana";
Q10.resposta5 = "Chinesa";
Q10.respostacorreta = 02;
ListaTodasQuestoes.Add(Q10);

// Nível 10
var Q11 = new Questao();
Q11.nivelpergunta = 10;
Q11.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q11.pergunta = "Quem foi Albert Einstein?";
Q11.resposta1 = "Um físico";
Q11.resposta2 = "Um químico";
Q11.resposta3 = "Um matemático";
Q11.resposta4 = "Um biólogo";
Q11.resposta5 = "Um filósofo";
Q11.respostacorreta = 01;
ListaTodasQuestoes.Add(Q11);

// Nível 5 (continuação)
var Q16 = new Questao();
Q16.nivelpergunta = 5;
Q16.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q16.pergunta = "Qual é o nome do famoso detetive criado por Arthur Conan Doyle?";
Q16.resposta1 = "Hercule Poirot";
Q16.resposta2 = "Sherlock Holmes";
Q16.resposta3 = "Miss Marple";
Q16.resposta4 = "Philip Marlowe";
Q16.resposta5 = "Sam Spade";
Q16.respostacorreta = 02;
ListaTodasQuestoes.Add(Q16);

// Nível 6 (continuação)
var Q17 = new Questao();
Q17.nivelpergunta = 6;
Q17.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q17.pergunta = "Qual o autor de 'Cem Anos de Solidão'?";
Q17.resposta1 = "Jorge Luis Borges";
Q17.resposta2 = "Gabriel García Márquez";
Q17.resposta3 = "Mario Vargas Llosa";
Q17.resposta4 = "Julio Cortázar";
Q17.resposta5 = "Pablo Neruda";
Q17.respostacorreta = 02;
ListaTodasQuestoes.Add(Q17);

// Nível 7 (continuação)
var Q18 = new Questao();
Q18.nivelpergunta = 7;
Q18.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q18.pergunta = "Quem foi o primeiro presidente do Brasil?";
Q18.resposta1 = "Getúlio Vargas";
Q18.resposta2 = "Deodoro da Fonseca";
Q18.resposta3 = "Juscelino Kubitschek";
Q18.resposta4 = "Washington Luís";
Q18.resposta5 = "Tancredo Neves";
Q18.respostacorreta = 02;
ListaTodasQuestoes.Add(Q18);

// Nível 8 (continuação)
var Q19 = new Questao();
Q19.nivelpergunta = 8;
Q19.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q19.pergunta = "Qual é a fórmula do gás carbônico?";
Q19.resposta1 = "CO2";
Q19.resposta2 = "C2O";
Q19.resposta3 = "CO";
Q19.resposta4 = "C2O4";
Q19.resposta5 = "C3O";
Q19.respostacorreta = 01;
ListaTodasQuestoes.Add(Q19);

// Nível 9 (continuação)
var Q20 = new Questao();
Q20.nivelpergunta = 9;
Q20.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q20.pergunta = "Qual é o sistema político em que o povo exerce o poder?";
Q20.resposta1 = "Monarquia";
Q20.resposta2 = "Oligarquia";
Q20.resposta3 = "Democracia";
Q20.resposta4 = "Autocracia";
Q20.resposta5 = "Teocracia";
Q20.respostacorreta = 03;
ListaTodasQuestoes.Add(Q20);

// Nível 10 (continuação)
var Q21 = new Questao();
Q21.nivelpergunta = 10;
Q21.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q21.pergunta = "Qual foi a teoria proposta por Darwin?";
Q21.resposta1 = "Teoria da Relatividade";
Q21.resposta2 = "Teoria da Evolução";
Q21.resposta3 = "Teoria da Gravidade";
Q21.resposta4 = "Teoria dos Jogos";
Q21.resposta5 = "Teoria da Fusão";
Q21.respostacorreta = 02;
ListaTodasQuestoes.Add(Q21);

// Nível 5
var Q30 = new Questao();
Q30.nivelpergunta = 5;
Q30.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q30.pergunta = "Qual é o autor de '1984'?";
Q30.resposta1 = "Aldous Huxley";
Q30.resposta2 = "George Orwell";
Q30.resposta3 = "Ray Bradbury";
Q30.resposta4 = "H.G. Wells";
Q30.resposta5 = "Isaac Asimov";
Q30.respostacorreta = 02;
ListaTodasQuestoes.Add(Q30);

var Q31 = new Questao();
Q31.nivelpergunta = 5;
Q31.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q31.pergunta = "Qual é o maior rio do mundo?";
Q31.resposta1 = "Amazonas";
Q31.resposta2 = "Nilo";
Q31.resposta3 = "Yangtze";
Q31.resposta4 = "Mississippi";
Q31.resposta5 = "Ganges";
Q31.respostacorreta = 01;
ListaTodasQuestoes.Add(Q31);

// Nível 6
var Q32 = new Questao();
Q32.nivelpergunta = 6;
Q32.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q32.pergunta = "Qual é o nome do processo de transformar luz solar em energia?";
Q32.resposta1 = "Fotossíntese";
Q32.resposta2 = "Respiração";
Q32.resposta3 = "Evaporação";
Q32.resposta4 = "Condensação";
Q32.resposta5 = "Transpiração";
Q32.respostacorreta = 01;
ListaTodasQuestoes.Add(Q32);

var Q33 = new Questao();
Q33.nivelpergunta = 6;
Q33.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q33.pergunta = "Qual é a capital da Alemanha?";
Q33.resposta1 = "Berlim";
Q33.resposta2 = "Munique";
Q33.resposta3 = "Frankfurt";
Q33.resposta4 = "Hamburgo";
Q33.resposta5 = "Colônia";
Q33.respostacorreta = 01;
ListaTodasQuestoes.Add(Q33);

// Nível 7
var Q34 = new Questao();
Q34.nivelpergunta = 7;
Q34.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q34.pergunta = "Qual é o elemento químico com o símbolo 'Au'?";
Q34.resposta1 = "Prata";
Q34.resposta2 = "Ouro";
Q34.resposta3 = "Alumínio";
Q34.resposta4 = "Cobre";
Q34.resposta5 = "Argônio";
Q34.respostacorreta = 02;
ListaTodasQuestoes.Add(Q34);

var Q35 = new Questao();
Q35.nivelpergunta = 7;
Q35.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q35.pergunta = "Qual é o nome do maior deserto do mundo?";
Q35.resposta1 = "Sahara";
Q35.resposta2 = "Gobi";
Q35.resposta3 = "Antártica";
Q35.resposta4 = "Kalahari";
Q35.resposta5 = "Arábia";
Q35.respostacorreta = 03;
ListaTodasQuestoes.Add(Q35);

// Nível 8
var Q36 = new Questao();
Q36.nivelpergunta = 8;
Q36.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q36.pergunta = "Quem foi o primeiro homem a realizar uma viagem ao espaço?";
Q36.resposta1 = "Yuri Gagarin";
Q36.resposta2 = "Neil Armstrong";
Q36.resposta3 = "Buzz Aldrin";
Q36.resposta4 = "John Glenn";
Q36.resposta5 = "Valentina Tereshkova";
Q36.respostacorreta = 01;
ListaTodasQuestoes.Add(Q36);

var Q37 = new Questao();
Q37.nivelpergunta = 8;
Q37.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q37.pergunta = "Qual é a capital da Itália?";
Q37.resposta1 = "Veneza";
Q37.resposta2 = "Milão";
Q37.resposta3 = "Roma";
Q37.resposta4 = "Florença";
Q37.resposta5 = "Nápoles";
Q37.respostacorreta = 03;
ListaTodasQuestoes.Add(Q37);

// Nível 9
var Q38 = new Questao();
Q38.nivelpergunta = 9;
Q38.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q38.pergunta = "Qual é a principal religião na Índia?";
Q38.resposta1 = "Cristianismo";
Q38.resposta2 = "Hinduísmo";
Q38.resposta3 = "Islamismo";
Q38.resposta4 = "Budismo";
Q38.resposta5 = "Judaísmo";
Q38.respostacorreta = 02;
ListaTodasQuestoes.Add(Q38);

var Q39 = new Questao();
Q39.nivelpergunta = 9;
Q39.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q39.pergunta = "Quem escreveu 'A Divina Comédia'?";
Q39.resposta1 = "Miguel de Cervantes";
Q39.resposta2 = "Dante Alighieri";
Q39.resposta3 = "William Shakespeare";
Q39.resposta4 = "Johann Goethe";
Q39.resposta5 = "Victor Hugo";
Q39.respostacorreta = 02;
ListaTodasQuestoes.Add(Q39);

// Nível 10
var Q42 = new Questao();
Q42.nivelpergunta = 10;
Q42.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q42.pergunta = "Qual é a fórmula do ácido sulfúrico?";
Q42.resposta1 = "H2SO4";
Q42.resposta2 = "HCl";
Q42.resposta3 = "H2CO3";
Q42.resposta4 = "NaCl";
Q42.resposta5 = "HNO3";
Q42.respostacorreta = 01;
ListaTodasQuestoes.Add(Q42);

var Q41 = new Questao();
Q41.nivelpergunta = 10;
Q41.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q41.pergunta = "Quem descobriu a penicilina?";
Q41.resposta1 = "Louis Pasteur";
Q41.resposta2 = "Alexander Fleming";
Q41.resposta3 = "Marie Curie";
Q41.resposta4 = "Isaac Newton";
Q41.resposta5 = "Albert Einstein";
Q41.respostacorreta = 02;
ListaTodasQuestoes.Add(Q41);

// Nível 5
var Q46 = new Questao();
Q46.nivelpergunta = 5;
Q46.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q46.pergunta = "Qual é o nome da dança típica do Brasil?";
Q46.resposta1 = "Samba";
Q46.resposta2 = "Ballet";
Q46.resposta3 = "Flamenco";
Q46.resposta4 = "Tango";
Q46.resposta5 = "Hip Hop";
Q46.respostacorreta = 01;
ListaTodasQuestoes.Add(Q46);

// Nível 6
var Q47 = new Questao();
Q47.nivelpergunta = 6;
Q47.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q47.pergunta = "Qual é o nome do principal deus do panteão grego?";
Q47.resposta1 = "Zeus";
Q47.resposta2 = "Hera";
Q47.resposta3 = "Poseidon";
Q47.resposta4 = "Ares";
Q47.resposta5 = "Hades";
Q47.respostacorreta = 01;
ListaTodasQuestoes.Add(Q47);

// Nível 7
var Q48 = new Questao();
Q48.nivelpergunta = 7;
Q48.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q48.pergunta = "Qual é a capital da Rússia?";
Q48.resposta1 = "Moscovo";
Q48.resposta2 = "São Petersburgo";
Q48.resposta3 = "Kiev";
Q48.resposta4 = "Minsk";
Q48.resposta5 = "Tallinn";
Q48.respostacorreta = 01;
ListaTodasQuestoes.Add(Q48);

// Nível 8
var Q49 = new Questao();
Q49.nivelpergunta = 8;
Q49.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q49.pergunta = "Qual é a capital da Austrália?";
Q49.resposta1 = "Sydney";
Q49.resposta2 = "Melbourne";
Q49.resposta3 = "Canberra";
Q49.resposta4 = "Brisbane";
Q49.resposta5 = "Perth";
Q49.respostacorreta = 03;
ListaTodasQuestoes.Add(Q49);

// Nível 9
var Q50 = new Questao();
Q50.nivelpergunta = 9;
Q50.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q50.pergunta = "Qual é o nome do famoso cientista que desenvolveu a teoria da relatividade?";
Q50.resposta1 = "Isaac Newton";
Q50.resposta2 = "Niels Bohr";
Q50.resposta3 = "Albert Einstein";
Q50.resposta4 = "Galileu Galilei";
Q50.resposta5 = "Stephen Hawking";
Q50.respostacorreta = 03;
ListaTodasQuestoes.Add(Q50);

// Nível 10
var Q51 = new Questao();
Q51.nivelpergunta = 10;
Q51.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q51.pergunta = "Qual é o nome do fenômeno em que um corpo se desloca mais rápido que a velocidade do som?";
Q51.resposta1 = "Superação";
Q51.resposta2 = "Supersônico";
Q51.resposta3 = "Subsonico";
Q51.resposta4 = "Hipersônico";
Q51.resposta5 = "Mach";
Q51.respostacorreta = 02;
ListaTodasQuestoes.Add(Q51);

// Nível 5
var Q56 = new Questao();
Q56.nivelpergunta = 5;
Q56.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q56.pergunta = "Qual o nome do artista que pintou a Mona Lisa?";
Q56.resposta1 = "Pablo Picasso";
Q56.resposta2 = "Vincent van Gogh";
Q56.resposta3 = "Leonardo da Vinci";
Q56.resposta4 = "Claude Monet";
Q56.resposta5 = "Michelangelo";
Q56.respostacorreta = 03;
ListaTodasQuestoes.Add(Q56);

// Nível 6
var Q57 = new Questao();
Q57.nivelpergunta = 6;
Q57.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q57.pergunta = "Qual é o nome do primeiro presidente dos Estados Unidos?";
Q57.resposta1 = "Thomas Jefferson";
Q57.resposta2 = "George Washington";
Q57.resposta3 = "Abraham Lincoln";
Q57.resposta4 = "John Adams";
Q57.resposta5 = "Franklin D. Roosevelt";
Q57.respostacorreta = 02;
ListaTodasQuestoes.Add(Q57);

// Nível 7
var Q58 = new Questao();
Q58.nivelpergunta = 7;
Q58.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q58.pergunta = "Qual é o nome do processo pelo qual as plantas produzem seu alimento?";
Q58.resposta1 = "Transpiração";
Q58.resposta2 = "Respiração";
Q58.resposta3 = "Fotossíntese";
Q58.resposta4 = "Evaporação";
Q58.resposta5 = "Permeação";
Q58.respostacorreta = 03;
ListaTodasQuestoes.Add(Q58);

// Nível 8
var Q59 = new Questao();
Q59.nivelpergunta = 8;
Q59.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q59.pergunta = "Qual o nome do físico que desenvolveu a teoria da gravidade?";
Q59.resposta1 = "Isaac Newton";
Q59.resposta2 = "Albert Einstein";
Q59.resposta3 = "Galileu Galilei";
Q59.resposta4 = "Stephen Hawking";
Q59.resposta5 = "Niels Bohr";
Q59.respostacorreta = 01;
ListaTodasQuestoes.Add(Q59);

// Nível 9
var Q60 = new Questao();
Q60.nivelpergunta = 9;
Q60.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q60.pergunta = "Qual é a capital da África do Sul?";
Q60.resposta1 = "Pretória";
Q60.resposta2 = "Cidade do Cabo";
Q60.resposta3 = "Joanesburgo";
Q60.resposta4 = "Durban";
Q60.resposta5 = "Bloemfontein";
Q60.respostacorreta = 01;
ListaTodasQuestoes.Add(Q60);

// Nível 10
var Q61 = new Questao();
Q61.nivelpergunta = 10;
Q61.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q61.pergunta = "Qual é o nome do primeiro satélite artificial enviado ao espaço?";
Q61.resposta1 = "Apollo 11";
Q61.resposta2 = "Sputnik 1";
Q61.resposta3 = "Explorer 1";
Q61.resposta4 = "Hubble";
Q61.resposta5 = "Voyager 1";
Q61.respostacorreta = 02;
ListaTodasQuestoes.Add(Q61);

// Nível 5
var Q66 = new Questao();
Q66.nivelpergunta = 5;
Q66.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q66.pergunta = "Qual é o nome da maior floresta do mundo?";
Q66.resposta1 = "Floresta Amazônica";
Q66.resposta2 = "Floresta Negra";
Q66.resposta3 = "Floresta de Sherwood";
Q66.resposta4 = "Floresta do Congo";
Q66.resposta5 = "Floresta Boreal";
Q66.respostacorreta = 01;
ListaTodasQuestoes.Add(Q66);

// Nível 6
var Q67 = new Questao();
Q67.nivelpergunta = 6;
Q67.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q67.pergunta = "Qual é a fórmula química da água?";
Q67.resposta1 = "H2O";
Q67.resposta2 = "CO2";
Q67.resposta3 = "NaCl";
Q67.resposta4 = "O2";
Q67.resposta5 = "CH4";
Q67.respostacorreta = 01;
ListaTodasQuestoes.Add(Q67);

// Nível 7
var Q68 = new Questao();
Q68.nivelpergunta = 7;
Q68.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q68.pergunta = "Qual é o maior continente do mundo?";
Q68.resposta1 = "África";
Q68.resposta2 = "Ásia";
Q68.resposta3 = "América do Norte";
Q68.resposta4 = "Europa";
Q68.resposta5 = "Antártida";
Q68.respostacorreta = 02;
ListaTodasQuestoes.Add(Q68);

// Nível 8
var Q69 = new Questao();
Q69.nivelpergunta = 8;
Q69.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q69.pergunta = "Qual é o nome do autor de 'O Senhor dos Anéis'?";
Q69.resposta1 = "J.K. Rowling";
Q69.resposta2 = "George R.R. Martin";
Q69.resposta3 = "J.R.R. Tolkien";
Q69.resposta4 = "C.S. Lewis";
Q69.resposta5 = "Philip Pullman";
Q69.respostacorreta = 03;
ListaTodasQuestoes.Add(Q69);

// Nível 9
var Q70 = new Questao();
Q70.nivelpergunta = 9;
Q70.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q70.pergunta = "Qual é o maior oceano do mundo?";
Q70.resposta1 = "Atlântico";
Q70.resposta2 = "Índico";
Q70.resposta3 = "Pacífico";
Q70.resposta4 = "Ártico";
Q70.resposta5 = "Antártico";
Q70.respostacorreta = 03;
ListaTodasQuestoes.Add(Q70);

// Nível 10
var Q71 = new Questao();
Q71.nivelpergunta = 10;
Q71.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q71.pergunta = "Qual é a capital da Alemanha?";
Q71.resposta1 = "Berlim";
Q71.resposta2 = "Munique";
Q71.resposta3 = "Frankfurt";
Q71.resposta4 = "Hamburgo";
Q71.resposta5 = "Colônia";
Q71.respostacorreta = 01;
ListaTodasQuestoes.Add(Q71);

// Nível 5
var Q76 = new Questao();
Q76.nivelpergunta = 5;
Q76.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q76.pergunta = "Qual é a capital da França?";
Q76.resposta1 = "Londres";
Q76.resposta2 = "Paris";
Q76.resposta3 = "Madri";
Q76.resposta4 = "Berlim";
Q76.resposta5 = "Lisboa";
Q76.respostacorreta = 02;
ListaTodasQuestoes.Add(Q76);

// Nível 6
var Q77 = new Questao();
Q77.nivelpergunta = 6;
Q77.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q77.pergunta = "Qual é a principal língua falada no Brasil?";
Q77.resposta1 = "Espanhol";
Q77.resposta2 = "Português";
Q77.resposta3 = "Inglês";
Q77.resposta4 = "Francês";
Q77.resposta5 = "Italiano";
Q77.respostacorreta = 02;
ListaTodasQuestoes.Add(Q77);

// Nível 7
var Q78 = new Questao();
Q78.nivelpergunta = 7;
Q78.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q78.pergunta = "Qual é o planeta mais próximo do sol?";
Q78.resposta1 = "Marte";
Q78.resposta2 = "Vênus";
Q78.resposta3 = "Terra";
Q78.resposta4 = "Mercúrio";
Q78.resposta5 = "Júpiter";
Q78.respostacorreta = 04;
ListaTodasQuestoes.Add(Q78);

// Nível 8
var Q79 = new Questao();
Q79.nivelpergunta = 8;
Q79.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q79.pergunta = "Qual é a principal religião do Brasil?";
Q79.resposta1 = "Cristianismo";
Q79.resposta2 = "Islamismo";
Q79.resposta3 = "Budismo";
Q79.resposta4 = "Hinduísmo";
Q79.resposta5 = "Ateísmo";
Q79.respostacorreta = 01;
ListaTodasQuestoes.Add(Q79);

// Nível 9
var Q80 = new Questao();
Q80.nivelpergunta = 9;
Q80.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q80.pergunta = "Qual é o símbolo químico do oxigênio?";
Q80.resposta1 = "O";
Q80.resposta2 = "H";
Q80.resposta3 = "C";
Q80.resposta4 = "N";
Q80.resposta5 = "S";
Q80.respostacorreta = 01;
ListaTodasQuestoes.Add(Q80);

// Nível 10
var Q81 = new Questao();
Q81.nivelpergunta = 10;
Q81.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q81.pergunta = "Quem desenvolveu a teoria da relatividade?";
Q81.resposta1 = "Isaac Newton";
Q81.resposta2 = "Albert Einstein";
Q81.resposta3 = "Galileu Galilei";
Q81.resposta4 = "Niels Bohr";
Q81.resposta5 = "Stephen Hawking";
Q81.respostacorreta = 02;
ListaTodasQuestoes.Add(Q81);

// Nível 5
var Q86 = new Questao();
Q86.nivelpergunta = 5;
Q86.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q86.pergunta = "Qual é o nome do continente onde está a Antártica?";
Q86.resposta1 = "Ásia";
Q86.resposta2 = "África";
Q86.resposta3 = "América";
Q86.resposta4 = "Oceania";
Q86.resposta5 = "Antártica";
Q86.respostacorreta = 05;
ListaTodasQuestoes.Add(Q86);

// Nível 6
var Q87 = new Questao();
Q87.nivelpergunta = 6;
Q87.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q87.pergunta = "Qual é o resultado de 10 x 10?";
Q87.resposta1 = "100";
Q87.resposta2 = "10";
Q87.resposta3 = "50";
Q87.resposta4 = "25";
Q87.resposta5 = "200";
Q87.respostacorreta = 01;
ListaTodasQuestoes.Add(Q87);

// Nível 7
var Q88 = new Questao();
Q88.nivelpergunta = 7;
Q88.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q88.pergunta = "Quantas patas tem uma aranha?";
Q88.resposta1 = "6";
Q88.resposta2 = "8";
Q88.resposta3 = "10";
Q88.resposta4 = "4";
Q88.resposta5 = "12";
Q88.respostacorreta = 02;
ListaTodasQuestoes.Add(Q88);

// Nível 8
var Q89 = new Questao();
Q89.nivelpergunta = 8;
Q89.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q89.pergunta = "Qual é o símbolo químico do hidrogênio?";
Q89.resposta1 = "H";
Q89.resposta2 = "O";
Q89.resposta3 = "C";
Q89.resposta4 = "N";
Q89.resposta5 = "S";
Q89.respostacorreta = 01;
ListaTodasQuestoes.Add(Q89);

// Nível 9
var Q90 = new Questao();
Q90.nivelpergunta = 9;
Q90.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q90.pergunta = "Qual é a velocidade da luz?";
Q90.resposta1 = "300.000 km/s";
Q90.resposta2 = "150.000 km/s";
Q90.resposta3 = "75.000 km/s";
Q90.resposta4 = "1.000 km/s";
Q90.resposta5 = "600.000 km/s";
Q90.respostacorreta = 01;
ListaTodasQuestoes.Add(Q90);

// Nível 10
var Q91 = new Questao();
Q91.nivelpergunta = 10;
Q91.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q91.pergunta = "Qual é a maior estrela conhecida?";
Q91.resposta1 = "Sol";
Q91.resposta2 = "Sirius";
Q91.resposta3 = "Betelgeuse";
Q91.resposta4 = "Antares";
Q91.resposta5 = "VY Canis Majoris";
Q91.respostacorreta = 05;
ListaTodasQuestoes.Add(Q91);

        ProximaQuestao();
    }

    public Questao GetQuestaoAtual()
    {
        return QuestaoAtual;
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

    public void ProximaQuestao()
    {
        var listaQuestoes=ListaTodasQuestoes.Where(d=>d.nivelpergunta==NivelAtual).ToList();
        var numRand = Random.Shared.Next(0, listaQuestoes.Count-1);
        var novaQuestao=listaQuestoes[numRand];
        while (ListaTodasQuestoesRespondidas.Contains(novaQuestao))
        {
            numRand = Random.Shared.Next(0, listaQuestoes.Count-1);
            novaQuestao=listaQuestoes[numRand];
        }
        ListaTodasQuestoesRespondidas.Add(novaQuestao);
        QuestaoAtual=novaQuestao;
        QuestaoAtual.desenhar();
    }

    void Inicializar()
    {
        ListaTodasQuestoesRespondidas.Clear();
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

