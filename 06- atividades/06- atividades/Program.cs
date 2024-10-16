using _06__atividades;

Gato gato1 = new Gato
{
    Especie = "Gato Siamês"
};

Porco porco1 = new Porco
{
    Especie = "Porco Doméstico"
};

Capivara capivara1 = new Capivara
{
    Especie = "Capivara"
};

gato1.EmitirSom();
Console.WriteLine($"Espécie: {gato1.Especie}");

porco1.EmitirSom();
Console.WriteLine($"Espécie: {porco1.Especie}");

capivara1.EmitirSom();
Console.WriteLine($"Espécie: {capivara1.Especie}");
Console.ReadKey();
