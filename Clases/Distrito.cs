using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Distrito
    {
        private string id;
        private string name;
        private string idregion;
        private string idprovince;

        public Distrito()
        {

        }


        public Distrito(string id, string name, string idregion, string idprovince)
        {
            this.Id = id;
            this.Name = name;
            this.Idregion = idregion;
            this.Idprovince = idprovince;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Idregion { get => idregion; set => idregion = value; }
        public string Idprovince { get => idprovince; set => idprovince = value; }
    }
}
