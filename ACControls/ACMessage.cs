using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VaderConsulting.ACControls
{
    [Designer(typeof(VaderConsulting.ACControls.Designers.ACMessageDesigner))]
    public partial class ACMessage : UserControl
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

        private bool _Expanded = false;

        #endregion

        #region Properties

        #endregion

        #region Constructors

        public ACMessage()
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            //Width = Parent.Width;
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            DimMessage();
        }

        ~ACMessage()
        {
            Console.WriteLine("Message terminated");

            base.Dispose();
        }

        #endregion

        #region Event Handlers

        private void OK_Click(object sender, EventArgs e)
        {
            PerformOK();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            PerformCancel();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
            Close.ForeColor = SystemColors.ControlLight;
            Close.BackgroundImage = Properties.Resources.supervista_general_cross_16;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
            Close.ForeColor = SystemColors.ControlDark;
            Close.BackgroundImage = Properties.Resources.supervista_general_cross_bw_16;
        }

        private void Expand_Click(object sender, EventArgs e)
        {
            ExpandContract();
        }

        private void Expand_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
            Expand.BackgroundImage = Properties.Resources.supervista_general_v_16;
        }

        private void Expand_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
            Expand.BackgroundImage = Properties.Resources.supervista_general_v_bw_16;
        }

        private void ACMessage_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
        }

        private void ACMessage_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void tmrDim_Tick(object sender, EventArgs e)
        {
            DimMessage();
        }

        private void Logo_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
        }

        private void lblHeader_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
        }

        private void Message_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
        }

        private void OK_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
        }

        private void Cancel_MouseEnter(object sender, EventArgs e)
        {
            HighlightMessage();
        }

        private void Logo_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void lblHeader_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void Message_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void OK_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        private void Cancel_MouseLeave(object sender, EventArgs e)
        {
            tmrDim.Enabled = true;
        }

        #endregion

        #region Private Methods

        private void HighlightMessage()
        {
            tmrDim.Enabled = false;
            BackColor = SystemColors.Highlight;
            Close.Visible = true;
        }

        private void DimMessage()
        {
            BackColor = SystemColors.HotTrack;
            Close.Visible = false;
        }

        #endregion

        #region Public Methods

        public void Clear()
        {
            Console.WriteLine("Message cleared");

            base.Dispose();
        }

        public void PerformOK()
        {
        }

        public void PerformCancel()
        {
        }

        public void ExpandContract()
        {
            _Expanded = !_Expanded;

            if (_Expanded)
            {
                for (int i = 76; i < 119; i++)
                {
                    this.Height = i;
                }

            }
            else
            {
                for (int i = 118; i > 75; i--)
                {
                    this.Height = i;
                }
            }
        }

        #endregion

    }
}
