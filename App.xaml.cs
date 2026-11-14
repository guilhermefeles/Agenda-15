using System.Globalization;

namespace CadastroEventos;

public partial class App : Application
{
	public App()
	{
		// Usa o padrão brasileiro para formatar moeda (R$ 1.500,00) e números.
		var brasil = new CultureInfo("pt-BR");
		CultureInfo.DefaultThreadCurrentCulture = brasil;
		CultureInfo.CurrentCulture = brasil;

		InitializeComponent();

		MainPage = new AppShell();
	}
}
