using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen.listas
{
    public class lista
    {
        public List<string> infovehiculo = new List<string>();
        public void addList(String value)
        {
            this.infovehiculo.Add(value);
        }

        public List<string> addList()
        {
            return this.infovehiculo;
        }
    }
}
