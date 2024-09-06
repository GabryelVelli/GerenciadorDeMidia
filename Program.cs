using System.Collections;

namespace ListaDeFilmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Filme> filmes = new List<Filme>();
            List<Serie> series = new List<Serie>();

            int escolha = 0;
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1- Adicionar Filme");
                Console.WriteLine("2- Adicionar Serie");
                Console.WriteLine("3- Remover Filme");
                Console.WriteLine("4- Remover Série");
                Console.WriteLine("5- Ver lista de Filmes");
                Console.WriteLine("6- Ver lista de Series");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma Opção: ");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite os Dados do Filme: ");
                        Console.Write("Titulo: ");
                        string titulo = Console.ReadLine().ToUpper();
                        Console.Write("Genero: ");
                        string genero = Console.ReadLine().ToUpper();
                        Console.Write("Ano: ");
                        int ano = int.Parse(Console.ReadLine());
                        filmes.Add(new Filme(titulo, genero, ano));
                        break;
                    case 2:
                        Console.WriteLine("Digite os Dados da Serie: ");
                        Console.Write("Titulo: ");
                        string tituloserie = Console.ReadLine().ToUpper();
                        Console.Write("Ano: ");
                        int anoserie = int.Parse(Console.ReadLine());
                        Console.Write("Temporadas: ");
                        int temporadas = int.Parse(Console.ReadLine());
                        series.Add(new Serie(tituloserie, anoserie, temporadas));
                        break;
                    case 3:
                        Console.Write("Qual Filme deseja Remover: ");
                        string removerFilme = Console.ReadLine().ToUpper();
                        Boolean removed = filmes.RemoveAll(f => f.ToString().Contains(removerFilme)) > 0;
                        if (removed)
                        {
                            Console.WriteLine("FIlme Removido com Sucesso!!!");
                        } else
                        {
                            Console.WriteLine("Filme não Encontrado!!!");
                        }
                        break;
                    case 4:
                        Console.Write("Qual Serie deseja Remover: ");
                        string removerSerie = Console.ReadLine().ToUpper();
                        Boolean removedSerie = series.RemoveAll(s => s.ToString().Contains(removerSerie)) > 0;
                        if (removedSerie)
                        {
                            Console.WriteLine("Serie Removido com Sucesso!!!");
                        }
                        else
                        {
                            Console.WriteLine("Serie não Encontrado!!!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Lista de Filmes:");
                        if(filmes.Count == 0) {
                            Console.WriteLine("Nenhum Filme na lista!!!");
                        } else {
                            foreach(Filme f in filmes)
                            {
                                Console.WriteLine(f);
                            }
                        }
                        break;
                     case 6:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Lista de Series:");
                        if(series.Count == 0)
                        {
                            Console.WriteLine("Nenhuma Serie na Lista");
                        }
                        else
                        {
                            foreach (Serie s in series) 
                            {
                                Console.WriteLine(s);
                            }
                        }
                        break;
                     case 7:
                        Console.WriteLine("Programa Encerrado");
                        break;
                     default:
                        Console.WriteLine("Opção Invalida Tente Novamente!!!!");
                        break ;
                }
            } while (escolha != 7);
        }
    }
}
