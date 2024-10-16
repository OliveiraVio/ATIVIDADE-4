namespace Atividade__7
{
    public class ContaGenerica
    {
        public string BANCO { get; set; }
        public int AGENCIA { get; set; }
        public int CONTA { get; set; }
        public decimal SALDO { get; set; }

        public decimal VALOR { get; set; }

        public void DEPOISTAR(decimal valor)
        {
            if (valor > 0)
            {
                SALDO += valor;
                Console.WriteLine($"Seu depósito de R${valor} foi realizado com sucesso. Saldo atual: R${SALDO}");
            }
            else
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
            }
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= SALDO)
            {
                SALDO -= valor;
                Console.WriteLine($"Seu saque de R${valor} foi realizado com sucesso. Saldo atual: R${SALDO - valor}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

        }
    }
    class ContaCorrente : ContaGenerica
    {
        public decimal LIMITE { get; set; }

        public override void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= (SALDO + LIMITE))
            {
                SALDO -= valor;
                Console.WriteLine($"Seu saque de R${valor} foi realizado com sucesso. Saldo restante: R${SALDO}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}