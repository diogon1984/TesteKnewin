using CadastroCidade.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCidade.Dominio.Contratos
{
    public interface ICidadeRepositorio
    {
        IEnumerable<Cidade> ObterTodos();

        Cidade ObterPorId(int Id);

        IEnumerable<Cidade> ObterFronteiras(int Id);

        decimal ObterSomaHabitantes(List<int> Ids);

        IEnumerable<Cidade> ObterRota(int OrigemId, int DestinoId);

        void AlterarCidade(Cidade cidade);
    }
}
