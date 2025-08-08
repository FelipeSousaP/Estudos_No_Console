namespace Personagem
{
    public class Personagem
    {
        private string Nome;
        private int HP;
        private int Mana;
        Classe classe;

        public string Nomear()
        {
            return Nome;
        }

        public float Andar(float veloz)
        {
            Console.WriteLine($"o{Nome} andou por {veloz}");
            return veloz;
        }


        public int Teletransporte(int gasto)
        {
            Console.WriteLine($"o{Nome} gastou {gasto}");
            return Mana -= gasto;
        }

        public bool Voar()
        {
            Console.WriteLine("To Voando");
            return true;
        }

        public bool Morto()
        {
            if (HP >= 0) 
            {
                Console.WriteLine($"o{Nome} morreru");
                return true;
            }
            return false;
        }
    }
}
