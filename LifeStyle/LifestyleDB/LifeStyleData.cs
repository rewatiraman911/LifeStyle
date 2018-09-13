using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifestyleDB
{
    public class LifeStyleData
    {
        public DairyHubEntities LsLib;//Entity class ka object
        public LifeStyleData()
        {
            LsLib = new DairyHubEntities();
        }

    }
}
