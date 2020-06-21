using System.Collections.Generic;
using apitest.Models;

namespace apitest.Data{
    public interface IComidaRepository
    {
        IEnumerable<Comida> GetComida();
        Comida GetComidaById(int id);
        double  SumaDeCalorias();
    }
}