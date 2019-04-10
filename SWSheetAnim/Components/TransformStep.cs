using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    [Serializable()]
    class TransformStep : IStep
    {
        public string Name { get; set; }
        public double Duration { get; set; } = 0.3;
        public double WaitTime { get; set; } = 0.3;
        public Part Part;
        public Transform StartTransform;
        public Transform EndTransform;
    }
}
