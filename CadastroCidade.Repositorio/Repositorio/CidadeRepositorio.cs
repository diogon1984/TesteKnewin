using CadastroCidade.Dominio.Contratos;
using CadastroCidade.Dominio.Entidades;
using CadastroCidade.Dominio.Misc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CadastroCidade.Repositorio.Repositorio
{
    public class CidadeRepositorio : ICidadeRepositorio
    {
        public IEnumerable<Cidade> ObterTodos()
        {
            CriarDiretorio();

            var path = $@"{Constantes.DiretorioPrincipal}Cidade.json";
            var serializer = new JsonSerializer();
            var models = new List<Cidade>();

            if (File.Exists(path))
            {
                using (StreamReader file = File.OpenText(path))
                {
                    models = (List<Cidade>)serializer.Deserialize(file, typeof(List<Cidade>));
                }
            }

            return models;
        }

        public Cidade ObterPorId(int Id)
        {
            var models = ObterTodos();

            return models.Where(c => c.Id == Id).SingleOrDefault();
        }

        public decimal ObterSomaHabitantes(List<int> Ids)
        {
            var models = ObterTodos();

            return models.Where(c => Ids.Contains(c.Id)).Sum(c => c.QtdeHabitante);
        }

        public IEnumerable<Cidade> ObterFronteiras(int Id)
        {
            var model = ObterPorId(Id);
            var fronteiras = new List<Cidade>();
            model.ListFronteiraIds.ForEach( f =>
                fronteiras.Add(ObterPorId(f))
            ) ;

            return fronteiras;
        }

        public IEnumerable<Cidade> ObterRota(int OrigemId, int DestinoId)
        {
            var models = ObterTodos();

            return models;
        }

        public void AlterarCidade(Cidade cidade)
        {
            CriarDiretorio();

            var path = $@"{Constantes.DiretorioPrincipal}Cidade.json";
            var serializer = new JsonSerializer();

            var models = ObterTodos().ToList();
            var model = ObterPorId(cidade.Id);

            models.Remove(model);

            using (StreamWriter file = new StreamWriter(path, false))
            {
                models.Add(cidade);
                serializer.Serialize(file, models);
            }
        }

        private void CriarDiretorio()
        {
            var dir = Constantes.DiretorioPrincipal;

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
