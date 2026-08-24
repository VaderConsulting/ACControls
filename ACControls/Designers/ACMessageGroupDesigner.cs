using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace VaderConsulting.ACControls.Designers
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ACMessageGroupDesigner : ParentControlDesigner
    {
        public bool Visible
        {
            get
            {
                return (bool)ShadowProperties["Visible"];
            }
            set
            {
                this.ShadowProperties["Visible"] = value;
            }
        }


        protected override void PreFilterProperties(System.Collections.IDictionary properties)
        {
            base.PreFilterProperties(properties); // Must be called first

            // Add or remove items here

            properties["Visible"] = TypeDescriptor.CreateProperty(
            typeof(ACMessageGroupDesigner),(PropertyDescriptor)properties["Visible"],new Attribute[0]);

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
