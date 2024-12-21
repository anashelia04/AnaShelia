using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public abstract class GeographicEntity
    {
        public string Name { get; set; }
        public virtual double Area { get; set; }
        public virtual int Population { get; set; }
    }
}

