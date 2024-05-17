using DesafioProjetoHospedagem.Models;

namespace trilha_net_explorando_desafio.Models
{
    public class Menu
    {
        public Menu()
        {
            Executar();
        }

        public static void Executar()
        {
            Console.WriteLine("Sistema de gerenciamento de hospedagens.");
            Reserva reserva = new Reserva();
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite sua opção");
                Console.WriteLine("1 - Cadastrar Suíte");
                Console.WriteLine("2 - Cadastrar Hospedes");
                Console.WriteLine("3 - Quantidade de hospedes");
                Console.WriteLine("4 - Encerrar reservas");
                Console.WriteLine("5 - Fechar programa.");

                switch (Console.ReadLine())
                {
                    case "1":
                        Suite suite = Suite.SetSuite();
                        reserva.CadastrarSuite(suite);
                        break;

                    case "2":
                        Hospedes hospedes = new Hospedes();
                        List<Pessoa> listaHospedes = hospedes.SetHospedes();
                        reserva.CadastrarHospedes(listaHospedes);
                        break;

                    case "3":
                        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                        break;

                    case "4":
                        Console.WriteLine("Para quantos dias de hospedagem? ");
                        int.TryParse(Console.ReadLine(), out int valor);
                        reserva.DiasReservados = valor;
                        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
                        break;


                    case "5":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();

            }

        }
    }
}
