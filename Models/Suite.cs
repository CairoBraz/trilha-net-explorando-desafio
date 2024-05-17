namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public static Suite SetSuite()
        {
            Console.Write("Informe o tipo da suíte: ");
            //suite.TipoSuite = Console.ReadLine();
            string tipoSuite = Console.ReadLine();

            Console.Write("Informe a capacidade da suíte: ");
            int.TryParse(Console.ReadLine(), out int parseCapacidade);
            //suite.Capacidade = capacidade;
            int capacidade = parseCapacidade;


            Console.Write("Informe o valor da diária: ");
            decimal.TryParse(Console.ReadLine(), out decimal parseValorDiaria);
            //suite.ValorDiaria = valorDiaria;
            decimal valorDiaria = parseValorDiaria;

            Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);
            return suite;

        }
    }
}
