using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainToTraining.Model
{
    public class Tree
    {

        public String Name { get; set; }
        public TreeType Type { get; set; }

        public TreeQuality Quality { get; set; }

        public TreeSize Size { get; set; }

        public TreeWidth Width { get; set; }

        public HealthCondition Condition { get; set; }

        public TreeAge Age { get; set; }



    }
}
