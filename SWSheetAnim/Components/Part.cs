using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    [Serializable()]
    public class Part
    {
        public string Name { get; set; }

        public Part(string name)
        {
            Name = name;
        }
    }
}
