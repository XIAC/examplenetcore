using System.Collections.Generic;
using System.Linq;
using apitest.Models;

namespace apitest.Data{
    public class MockComidaRepository : IComidaRepository
    {
        public IEnumerable<Comida> GetComida()
        {
            var comidas= new List<Comida>{
                new Comida {Id=0, Nombre="Plato paceno", Tipo="Segundo", Calorias=900},
                new Comida {Id=1, Nombre="Fricase", Tipo="Caldo", Calorias=500},
                new Comida {Id=2, Nombre="Ceviche", Tipo="Segundo", Calorias=1900},
            };
            return comidas;
        }

        public Comida GetComidaById(int id)
        {
            return new Comida {Id=0, Nombre="Plato paceno", 
                                Tipo="Segundo", 
                                Calorias=900};
        }
        public double SumaDeCalorias()
        {
            var comidas= new List<Comida>{
                new Comida {Id=0, Nombre="Plato paceno", Tipo="Segundo", Calorias=900},
                new Comida {Id=1, Nombre="Fricase", Tipo="Caldo", Calorias=500},
                new Comida {Id=2, Nombre="Ceviche", Tipo="Segundo", Calorias=1900},
            };
            var result= comidas.Select(x=>x.Calorias).Sum();
            
            return 0.0;
        }
    }
}