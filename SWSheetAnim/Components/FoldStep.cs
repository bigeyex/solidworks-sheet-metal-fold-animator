using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    class FoldStep : IStep
    {
        public string Name { get; set; }
        public double Duration { get; set; } = 0.3;
        public double WaitTime { get; set; } = 0.3;
        public Fold Fold;
        public double StartValue { get; set; } = 0;
        public double EndValue { get; set; } = 90;
        public bool IsFoldBack { get; set; } = false; // 用来制作折痕
    }
}
