using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUMTS
{
    public class ModelVirtualUltibot:IModel
    {
        private IView view;
        private IController controller;

        private int distance;
        private Random randomisierer = new Random();

        IView IModel.View
        {
            get { return view; }
            set { view = value; }
        }
        IController IModel.Controller
        {
            get { return controller; }
            set { controller = value; }
        }

        public int getDistance()
        {
            distance = randomisierer.Next(3,251);
            return distance;
        }
    }
}
