﻿namespace JogodoQuiz;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
	int PularClicado=0;
	int Vezes=2;

	public MainPage()
	{
		InitializeComponent();

		gerenciador =new Gerenciador(Perguntas, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, LabelPont, LabelNivel);
	}

	void Resposta01Clicado(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(1);
	}

	void Resposta02Clicado(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(2);
	}

	void Resposta03Clicado(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(3);
	}

	void Resposta04Clicado(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(4);
	}

	void Resposta05Clicado(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(5);
	}

	void AjudaTirarClicado(object s, EventArgs e)
	{
		var ajuda=new RetiraErradas();
		ajuda.ConfiguraDesenho(Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
		(s as Button).IsVisible=false;
	}

	void AjudaPularClicado(object s, EventArgs e)
	{
		if (PularClicado==2)
			(s as Button).IsVisible=false;
		else
		{
			gerenciador.ProximaQuestao();
			PularClicado++;
		}

		Ajuda01.Text="Pular "+Vezes.ToString()+"x";
		Vezes--;
	}


	void AjudaUniversitariosClicado(object s, EventArgs e)
	{
		var ajuda=new Universitarios();
		ajuda.ConfiguraDesenho(Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
		(s as Button).IsVisible=false;
	}
}

