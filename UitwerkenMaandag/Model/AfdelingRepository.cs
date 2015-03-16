using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UitwerkenMaandag.Model
{
    public class AfdelingRepository
    {
        public Afdeling GetAfdelingById(int id)
        {
            return new Afdeling
            {
                Naam = "Zuivel",
                Producten = new List<Product>()
                {
                    new Product{ Name = "Melk" , Price = 1.20 },
                    new Product{ Name = "Kaas" , Price = 2.20 },
                }
            };
        }
    }
}
