using ATIVIDADE_MVC.Model;

namespace ATIVIDADE_MVC.View
{
    public class EventoView
    {
        public void Listar(List<Evento> eventos)
        {
            Console.Clear();
            foreach (var item in eventos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nNome do evento: {item.Nome}");
                Console.WriteLine($"Descricao: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}");
                Console.ResetColor();
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe a descricao do evento:");
            novoEvento.Descricao = Console.ReadLine();
            
            Console.WriteLine($"Informe a data do evento:");
            novoEvento.Data = Console.ReadLine();
            
            return novoEvento;
            
        }

    }
}