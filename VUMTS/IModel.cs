using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VUMTS
{
    public interface IModel
    {
        IView View {
            get;
            set;
        }
        IController Controller
        {
            get;
            set;
        }

        int getDistance();
    }
}
