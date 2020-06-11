using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OopLabs.MyForms;

namespace OopLabs
{
    public abstract class Creator
    {        public abstract Form Create(MainForm.UpdateMethod method, object obj, int index);
    }

    class BicycleCreator : Creator
    {
        public override Form Create(MainForm.UpdateMethod method, object obj, int index)
        {
            return new BicycleForm(method, obj, index);
        }
    }

    class TrailerCreator : Creator
    {
        public override Form Create(MainForm.UpdateMethod method, object obj, int index)
        {
            return new TrailerForm(method, obj, index);
        }
    }

    class LightCarCreator : Creator
    {
        public override Form Create(MainForm.UpdateMethod method, object obj, int index)
        {
            return new LightCarForm(method, obj, index);
        }
    }

    class TrackCreator : Creator
    {
        public override Form Create(MainForm.UpdateMethod method, object obj, int index)
        {
            return new TrackForm(method, obj, index);
        }
    }

    class MotorcycleCreator : Creator
    {
        public override Form Create(MainForm.UpdateMethod method, object obj, int index)
        {
            return new MotorcycleForm(method, obj, index);
        }
    }
}
