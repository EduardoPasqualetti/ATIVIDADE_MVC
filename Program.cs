using ATIVIDADE_MVC.Model;
using ATIVIDADE_MVC.Controller;

Evento evento = new Evento();


EventoController control = new EventoController();
string opcao;

do
{
    Console.WriteLine(@$"
================================
|     O que deseja fazer ?     |
|                              |
| 1 - Cadastrar eventos        |
| 2 - Listar eventos           |
| 0 - Sair                     |
================================
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            control.CadastrarEvento();
            break;
        case "2":
            control.ListarEventos();
            break;
        case "0":
            Console.WriteLine($"Saindo do sistema...");
            break;
        default:
            Console.WriteLine($"opcao invalida!");
            break;
    }
} while (opcao != "0");