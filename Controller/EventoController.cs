using ATIVIDADE_MVC.Model;
using ATIVIDADE_MVC.View;

namespace ATIVIDADE_MVC.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventoView view = new EventoView();

        public void ListarEventos()
        {
            List<Evento> eventos = evento.LerEventos();

            view.Listar(eventos);
        }

        public void CadastrarEvento()
        {
            Evento novoEvento = view.Cadastrar();

            evento.Inserir(novoEvento);
        }


    }
}