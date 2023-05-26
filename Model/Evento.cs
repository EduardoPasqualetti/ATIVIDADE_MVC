namespace ATIVIDADE_MVC.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
        public const string CAMINHO = "Database/Evento.csv";
        public Evento()
        {
            string novaPasta = CAMINHO.Split("/")[0];

            if (!Directory.Exists(novaPasta))
            {
                Directory.CreateDirectory(novaPasta);
            }
            if (!File.Exists(CAMINHO))
            {
                File.Create(CAMINHO);
            }
        }

        public List<Evento> LerEventos()
        {
            List<Evento> listaEventos = new List<Evento>();
            
            string[] eventos = File.ReadAllLines(CAMINHO);

            foreach (var item in eventos)
            {
                string[] infos = item.Split(";");

                Evento x = new Evento();

                x.Nome = infos[0];
                x.Descricao = infos[1];
                x.Data = infos[2];

                listaEventos.Add(x);
            }
            return listaEventos;
        }
        public string RedefinirLinhasCSV(Evento x)
        {
            return $"{x.Nome};{x.Descricao};{x.Data}";
        }
        public void Inserir(Evento x)
        {
            string[] linhasEvento = {RedefinirLinhasCSV(x)};

            File.AppendAllLines(CAMINHO, linhasEvento);

        }


    }
}





