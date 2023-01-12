using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainToTraining.Model.SeedModel;
using TrainToTraining.Model.TreeModel;

namespace TrainToTraining.GrowEngine
{
    public interface ITreeFactory
    {

        Tree Create(Seed seed);


    }
}
