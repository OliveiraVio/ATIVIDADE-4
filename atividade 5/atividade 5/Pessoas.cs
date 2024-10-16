using atividade_5;

namespace atividade_5
{
    public  class Pessoas
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Envelhecer(int anos)
        {
            Idade += anos;
        }

        public void Rejuvenecer(int anos)
        {
            Idade -= anos;
        }
    }
}

public class Funcionario : Pessoas
{

}