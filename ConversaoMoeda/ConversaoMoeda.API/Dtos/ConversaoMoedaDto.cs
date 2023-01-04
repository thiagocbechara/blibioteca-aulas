namespace ConversaoMoeda.API.Dtos;

public class ConversaoMoedaDto
{
    public string MoedaOrigem { get; set; } = default!;
    public string MoedaDestino { get; set; } = default!;
    public decimal Valor { get; set; }
}
