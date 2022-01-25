// See https://aka.ms/new-console-template for more information

namespace Dio.Series
{
    class Program 
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main (string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListaSerie();
                        break;    
                    case "2":
                        Inserirerie();
                        break; 
                    case "3":
                        AtualizarSerie();
                        break; 
                    case "4":
                        ExcluirSerie();
                        break;   
                    case "5":
                        VisualizarSerie();
                        break; 
                    case "C":
                        Console.Clear();
                        break;
                 
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();            
            }

            Console.WriteLine("Obrigada por utilizar nossos serviços");
            Console.ReadLine();
        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            var indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);       

        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);

        }



        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero), i,));
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a discrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Series series = new Series(id: indiceSerie,
                                                        genero: (Genero)entradaGenero,
                                                        titulo: entradaTitulo,
                                                        ano: entradaAno,
                                                        descricao: entradaDescricao);
            Series atualizaSerie = series; 
            repositorio.Atualiza(indiceSerie, atualizaSerie);






        }




        private static void ListarSeries()
        {
            Console.WriteLine("Listar série");
            var lista = repositorio.Lista();
            if (lista.Count -- 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }     
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                if(excluido) 
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
                } 
            }

        }

        private static void InserirSerie()
        {
          foreach (int i in Enum.GetValues(typeof(Genero)))
          {
              Console.WriteLine("{0} - {1}", i, Enum.GetName.(typeof(Genero),i));
          }      
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano Ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series (id: repositorio.ProximoId(),
                                                genero: (Genero)entradaGenero,
                                                titulo: entradaTitulo,
                                                ano: entradaAno,
                                                descricao: entradaDescricao);                     )
            object p = repositorio.Insere(novaSerie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Séries a seu dispor!!");
            Console.WriteLine("Programa em fase de teste by CRRM");
            Console.WriteLine("Infome a opção desejada");
            Console.WriteLine("1- Listar séries");      
            Console.WriteLine("2- Inserir nova série");   
            Console.WriteLine("3- Atualizar série");   
            Console.WriteLine("4- Excluir séries");   
            Console.WriteLine("5- Visualizar série");   
            Console.WriteLine("C- Limpar tela");  
            Console.WriteLine("X- Sair");    

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;  

        }

     }

}