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
    [Designer(typeof(VaderConsulting.ACControls.Designers.ACMessageGroupDesigner))]
    [Serializable]
    public partial class ACMessageGroup : UserControl
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

        private List<ACMessage> _Messages = new List<ACMessage>();

        #endregion

        #region Properties

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<ACMessage> Messages
        {
            get
            {
                return _Messages;
            }
            set
            {
                _Messages = value;
            }
        }

        #endregion

        #region Constructors

        public ACMessageGroup()
        {
            InitializeComponent();

            GroupName.Text = Name;

            Dock = DockStyle.Top;

            DimHeader();
        }

        #endregion

        #region Event Handlers

        private void ACMessageGroup_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.WriteLine("Control added to Group");

            //e.Control.Parent = this;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            HighlightHeader();
            Close.BackgroundImage = Properties.Resources.supervista_general_cross_16;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
            Close.BackgroundImage = Properties.Resources.supervista_general_cross_bw_16;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMessage(new ACMessage());
        }

        private void GroupName_MouseEnter(object sender, EventArgs e)
        {
            HighlightHeader();
        }

        private void GroupName_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void Header_MouseEnter(object sender, EventArgs e)
        {
            HighlightHeader();
        }

        private void Header_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void Image_MouseEnter(object sender, EventArgs e)
        {
            HighlightHeader();
        }

        private void Image_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void tmrDim_Tick(object sender, EventArgs e)
        {
            DimHeader();
        }

        #endregion

        #region Private Methods

        private void HighlightHeader()
        {
            tmrDim.Enabled = false;
            Header.BackColor = SystemColors.Highlight;
            Close.Visible = true;
        }

        private void DimHeader()
        {
            Header.BackColor = SystemColors.HotTrack;
            Close.Visible = false;
        }

        #endregion

        #region Public Methods

        public void AddMessage(ACMessage Message)
        {
            _Messages.Add(Message);

            Message.Width = Panel.ClientSize.Width + 2;

            Message.Dock = DockStyle.Top;

            Panel.Controls.Add(Message);
        }

        public void Clear()
        {
            Console.WriteLine("Group cleared");

            if (_Messages.Count > 0)
            {
                for (int Counter = 0; Counter < _Messages.Count; Counter++)
                {
                    if (_Messages[Counter] != null)
                    {
                        _Messages[Counter].Clear();

                        _Messages[Counter].Dispose();
                    }
                }
            }

            base.Dispose();
        }

        #endregion

    }
}
