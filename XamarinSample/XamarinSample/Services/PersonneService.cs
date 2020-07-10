using System;
using System.Collections.Generic;
using System.Text;
using XamarinSample.Models;

namespace XamarinSample.Services
{
    public class PersonneService
    {
        private List<Personne> _liste;

        public List<Personne> Liste
        {
            get { return _liste; }
            
        }

        public PersonneService()
        {
            _liste = new List<Personne>();
            Liste.Add(new Personne { Nom = "Chuck", Email = "Chuck@god.com" });
            Liste.Add(new Personne { Nom = "Terminator", Email = "sarahconnor@skynet.com" });
        }

        public List<Personne> GetAll()
        {
            return Liste;
        }

        public void Add(Personne p)
        {
            Liste.Add(p);
        }
    }
}
