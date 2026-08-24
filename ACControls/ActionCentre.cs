using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace VaderConsulting.ACControls
{
    [Designer(typeof(VaderConsulting.ACControls.Designers.ActionCentreDesigner), typeof (IRootDesigner))]
    public partial class ActionCentre : UserControl
    {
        #region Constants

        #endregion

        #region Events

        #endregion

        #region Enums

        #endregion

        #region DLL Imports

        #endregion

        #region Fields

        private List<ACMessageGroup> _Groups = new List<ACMessageGroup>();

        #endregion

        #region Properties

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<ACMessageGroup> Groups
        {
            get
            {
                return _Groups;
            }
            set
            {
                _Groups = value;
            }
        }

        #endregion

        #region Constructors

        public ActionCentre()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            Invalidate();

            Trace.WriteLine("Constructor - No Parent");
        }

        public ActionCentre(Form ParentForm)
        {
            InitializeComponent();

            Parent = ParentForm;

            Left = 0;
            Top = 0;
            Width = Parent.ClientSize.Width;
            Height = Parent.ClientSize.Height;

            Invalidate();

            Trace.WriteLine("Constructor - With Parent");
        }

        #endregion

        #region Event Handlers

        private void ClearAll_MouseEnter(object sender, EventArgs e)
        {
            ClearAll.ForeColor = SystemColors.ControlLight;
        }

        private void ClearAll_MouseLeave(object sender, EventArgs e)
        {
            ClearAll.ForeColor = SystemColors.ControlDark;
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllMessages();
        }

        private void ActionCentre_ParentChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("Parent Changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACMessageGroup Group = new ACMessageGroup();

            Group.Width = Panel.ClientSize.Width;

            Groups.Add(Group);

            Panel.Controls.Add(Group);
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        public void AddGroup(ACMessageGroup Group)
        {
            SuspendLayout();

            Group.Width = this.ClientSize.Width;
            Group.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            Groups.Add(Group);

            ResumeLayout();
        }

        public void ClearAllMessages()
        {
            Trace.WriteLine("All Messages cleared");

            foreach (ACMessageGroup Group in Groups)
            {
                Group.Clear();
            }
        }

        #endregion

    }
}
