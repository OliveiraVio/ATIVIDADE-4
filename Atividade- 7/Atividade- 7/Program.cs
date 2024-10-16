using Atividade__7;
{
    ContaCorrente CONTA1 = new ContaCorrente
    {
        BANCO = "Nubank",
        AGENCIA = 6587,
        CONTA = 74589,
        SALDO = 750,
        LIMITE = 4500,
    };
    ContaCorrente CONTA2 = new ContaCorrente
    {
        BANCO = "Banco do Brasil",
        AGENCIA = 4567,
        CONTA = 99998,
        SALDO = 4000,
        LIMITE = 60000,
    };
    ContaCorrente CONTA3 = new ContaCorrente
    {
        BANCO = "BRADESCO",
        AGENCIA = 9876,
        CONTA = 41152,
        SALDO = 754,
        LIMITE = 1500,
    };

    Console.WriteLine($"\nSuas informações são: banco: {CONTA1.BANCO}, agencia: {CONTA1.AGENCIA}, conta : {CONTA1.CONTA}, você tem um saldo de: {CONTA1.SALDO}, seu limite é de: {CONTA1.LIMITE}.");
    CONTA1.DEPOISTAR(450);
    CONTA1.Sacar(1500);

    Console.WriteLine($"\nSuas informações são: banco: {CONTA2.BANCO}, agencia: {CONTA2.AGENCIA}, conta : {CONTA2.CONTA}, você tem um saldo de: {CONTA2.SALDO}, seu limite é de: {CONTA2.LIMITE}.");
    CONTA2.DEPOISTAR(450);
    CONTA2.Sacar(1500);

    Console.WriteLine($"\nSuas informações são: banco: {CONTA3.BANCO}, agencia: {CONTA3.AGENCIA}, conta : {CONTA3.CONTA}, você tem um saldo de: {CONTA3.SALDO}, seu limite é de: {CONTA3.LIMITE}.");
    CONTA3.DEPOISTAR(450);
    CONTA3.Sacar(1500);
}
Console.ReadKey();