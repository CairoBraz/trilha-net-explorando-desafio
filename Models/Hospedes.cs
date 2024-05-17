using DesafioProjetoHospedagem.Models;

namespace trilha_net_explorando_desafio.Models
{
    public class Hospedes
    {
        public List<Pessoa> listaHospedes { get; set; }

        public Hospedes()
        {
            listaHospedes = new List<Pessoa>();
        }

        public List<Pessoa> SetHospedes()
        {
            bool adicionarMaisPessoa = true;
            do
            {
                Pessoa pessoa = new Pessoa();

                Console.WriteLine("Informe o nome do hospede: ");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Informe o sobrenome do hospede: ");
                pessoa.Sobrenome = Console.ReadLine();

                listaHospedes.Add(pessoa);

                bool respostaValida = true;
                string resposta;
                do
                {
                    Console.WriteLine("Adicionar mais um hospede? S/N: ");
                    resposta = Console.ReadLine().ToUpper();

                    respostaValida = resposta == "S" || resposta == "N";

                    if (!respostaValida)
                    {
                        Console.WriteLine("Opção inválida! Digite 'S' para sim ou 'N' para não.");
                    }

                } while (!respostaValida);

                adicionarMaisPessoa = resposta == "S";

            } while (adicionarMaisPessoa);

            return listaHospedes;
        }
    }
}
