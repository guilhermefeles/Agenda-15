namespace CadastroEventos;

// Model: guarda os dados do evento.
public class Evento
{
    public string Nome { get; set; } = "";
    public DateTime DataInicio { get; set; } = DateTime.Today;
    public DateTime DataTermino { get; set; } = DateTime.Today;
    public int NumeroParticipantes { get; set; }
    public string Local { get; set; } = "";
    public decimal CustoPorParticipante { get; set; }

    // Subtrair dois DateTime resulta em um TimeSpan (a diferença entre as datas).
    public TimeSpan Duracao => DataTermino - DataInicio;

    // Duração em dias (parte inteira da diferença).
    public int DuracaoEmDias => (int)Duracao.TotalDays;

    // Custo total = participantes x custo de cada um.
    public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
}

