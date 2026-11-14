namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    // O objeto que guarda os dados digitados na tela.
    Evento evento = new Evento();

    public MainPage()
    {
        InitializeComponent();

        // BindingContext liga a tela ao objeto: os campos {Binding ...} do XAML
        // leem e gravam as propriedades de "evento".
        BindingContext = evento;
    }

    // Executa quando clica no botão "Cadastrar".
    async void OnCadastrar(object? sender, EventArgs e)
    {
        // Validações simples antes de seguir.
        if (string.IsNullOrWhiteSpace(evento.Nome))
        {
            await DisplayAlert("Atenção", "Informe o nome do evento.", "OK");
            return;
        }

        if (evento.DataTermino < evento.DataInicio)
        {
            await DisplayAlert("Atenção", "A data de término não pode ser anterior à de início.", "OK");
            return;
        }

        // Abre a página de resumo, passando o evento cadastrado.
        await Navigation.PushAsync(new ResumoPage(evento));
    }
}
