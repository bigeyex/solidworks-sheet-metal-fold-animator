using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    [Serializable()]
    public class Fold
    {
        public string PartName;
        public string Name { get; set; }

        public Fold(string name, string partName)
        {
            PartName = partName;
            Name = name;
        }
    }
}
