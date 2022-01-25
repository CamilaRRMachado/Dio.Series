using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    { 
        void IRepositorio<Series>.Atualiza(int id, Series entidade)
        {
            listaSeries[id] = entidade;
        }

        void IRepositorio<Series>.Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        void IRepositorio<Series>.Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        List<Series> IRepositorio<Series>.Lista()
        {
            return listaSerie;
        }

        int IRepositorio<Series>.ProximoId()
        {
            return listaSerie.Count;
        }

        Series IRepositorio<Series>.RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        internal void Atualiza(int indiceSerie, Series atualizaSerie)
        {
            throw new NotImplementedException();
        }

        internal object RetornaPorId(int indiceSerie)
        {
            throw new NotImplementedException();
        }
    }
}