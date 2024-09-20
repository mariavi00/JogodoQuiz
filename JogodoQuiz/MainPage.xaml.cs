namespace JogodoQuiz;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();

		gerenciador =new Gerenciador(Perguntas, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
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
}

