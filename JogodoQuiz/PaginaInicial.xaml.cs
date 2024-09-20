namespace JogodoQuiz;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();

	}

    void BotaoIniciarFoiClicado(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
}
