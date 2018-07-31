using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    public interface IStep
    {
        string Name { get; set; }
        double Duration { get; set; }
        double WaitTime { get; set; }
    }
}
