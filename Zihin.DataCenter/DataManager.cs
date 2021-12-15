using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zihin.Core;

namespace Zihin.DataCenter
{
    class ZihinBase
    {

    }
    internal class DataManager
    {
        private List<ZihinBase> _memory;
        public DataManager()
        {
            _memory = new List<ZihinBase>();
        }
        public void CreateList(Type model, string name)
        {
            
        }
    }
}
