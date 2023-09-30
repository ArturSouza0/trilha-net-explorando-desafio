namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool VerificarCapacidade = Suite.Capacidade >= hospedes.Count;
            Hospedes = VerificarCapacidade ? hospedes :
          throw new Exception("A quantidade de hóspedes não pode excerder a capacidade da suíte.");
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }
        public decimal CalcularValorDiaria()
        {
            decimal calculo = DiasReservados * Suite.ValorDiaria;
            decimal valor = DiasReservados >= 10 ? calculo - (calculo * 0.1M) : calculo;
            return valor;
        }
    }
}