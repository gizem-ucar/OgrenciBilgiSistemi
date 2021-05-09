using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ders:IEntity
    {
        public string DersId { get; set; }
        public string DersAdi { get; set; }
        public string Sube { get; set; }
    }
}
