using System.Collections.Generic;

namespace DIO.SeriesList.Interfaces
{
    public interface IReposiroty<T>
    {
         List<T> Lista();
         T RetornaPorId (int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}