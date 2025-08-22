namespace codigo
{
    public class Pessoa
    {
        #region Exemplo de propriedade
        private string Nome;
        private int idade;

        public Pessoa(string Nome,int idade)
        {
            NOME = Nome;
            IDADE = idade;
        }
        public string NOME
        {
            get => Nome;
            set => NOME = value;
        }

        public int IDADE
        {
            get => idade;
            set => IDADE = value;
        }
        //Usado para aplicações simples
        #endregion

        #region Modelo anterior
        /*//Citar os comportamentos de uma pessoa
        private string nome;
        private int CPF;
        private int RG;

        //Comportamento
        private bool Andando;
        private bool Pulando;
        private bool Dormindo;

        public string Name() => nome;
        public int Cpf() => CPF;
        public int Rg() => RG;

        public bool Andar() => Andando;
        public bool Pular() => Pulando;
        public bool Dormir() => Dormindo;*/
        #endregion
    }
}
