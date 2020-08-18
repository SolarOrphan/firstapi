using System;
using System.Collections.Generic;
using firstapi.Models;

namespace firstapi.Data
{
    public class Mockfirstapirepo : Ifirstapirepo
    {
        public IEnumerable<Howto> GetData()
        {
            var Howto = new List<Howto>
            {
                new Howto { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Howto { Id = 1, HowTo = "Boil an egg1", Line = "Boil water1", Platform = "Kettle & Pan1"},
                new Howto { Id = 2, HowTo = "Boil an egg2", Line = "Boil water2", Platform = "Kettle & Pan2"},
                new Howto { Id = 3, HowTo = "Boil an egg3", Line = "Boil water3", Platform = "Kettle & Pan3"}
            };
            return Howto;
        }

        public Howto getobject(int id)
        {
            return new Howto { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"};
    }
}
}