namespace ExemploSingleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Bola em jogo!");
                }

                return instance;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
