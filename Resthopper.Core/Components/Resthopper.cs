using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;
using Rhino.Geometry;
using Grasshopper.Kernel;
using Resthopper.Core.Properties;
using Resthopper.Core.Views;
using RhinoWindows;

namespace Resthopper.Core.Components
{
    public class Resthopper : GH_Component
    {
        public Resthopper() : base(Resources.Main_Name, Resources.Main_Label, Resources.Main_Desc, Resources.TabName, Resources.Category_Main)
        {

        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddBooleanParameter("Launch", ">", "Launch RESThopper", GH_ParamAccess.item, false);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {

        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            bool active = false;
            if (!DA.GetData(0, ref active)) return;

            if (!active) return;

            //Launch rh window
            var dialog = new MainPanelView();
            dialog.Show();

        }

        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("0bdec59e-6aef-4bfe-adfd-0ec84832935d"); }
        }
    }
}
