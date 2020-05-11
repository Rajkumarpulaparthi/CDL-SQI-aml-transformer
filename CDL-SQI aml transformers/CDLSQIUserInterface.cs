using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aml.Editor.Plugin
{
    public partial class CDLSQIUserInterface : UserControl
    {
        private CDLSQIController cDLSQIController;

        public CDLSQIUserInterface()
        {
            InitializeComponent();
        }

        public CDLSQIUserInterface(CDLSQIController cDLSQIController)
        {
            this.cDLSQIController = cDLSQIController;
            InitializeComponent();
        }
    }
}
