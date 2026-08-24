using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace VaderConsulting.ACControls.Designers
{
    [ToolboxItemFilter("VaderConsulting.ACControls.ACMessageGroup", ToolboxItemFilterType.Require)]
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ActionCentreDesigner : DocumentDesigner
    {
        public ActionCentreDesigner()
        {
            Trace.WriteLine("ActionCentreDesigner ctor");
        }

        protected override void PreFilterProperties(System.Collections.IDictionary properties)
        {
            // Add or remove items here

            base.PreFilterProperties(properties); // Must be called first

            //if (properties.Contains("Dock"))
            //    properties.Remove("Dock");

        }

        protected override void PostFilterProperties(System.Collections.IDictionary properties)
        {
            // Modify items here;
            

            base.PostFilterProperties(properties); // must be called last
        }
    }
}
