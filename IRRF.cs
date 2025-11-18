public class FaixaIRRF
{
    public double BaseMin { get; set; }
    public double BaseMax { get; set; }
    public double Aliquota { get; set; }
    public double Deducao { get; set; }

    public bool EstaNaFaixa(double valor)
    {
        return valor >= BaseMin && valor <= BaseMax;
    }
}
