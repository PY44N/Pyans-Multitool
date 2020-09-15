using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitool
{
    public partial class UpdateLog : Form
    {
        public UpdateLog()
        {
            InitializeComponent();
        }

        private void UpdateLog_Load(object sender, EventArgs e)
        {
            Text = Global.title + " | Update Log";
        }
    }
}
