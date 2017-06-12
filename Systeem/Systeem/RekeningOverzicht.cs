using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systeem
{
    public partial class RekeningOverzicht : Form
    {
        public int tafelId;

        public RekeningOverzicht(int tafelId)
        {
            InitializeComponent();
            this.tafelId = tafelId;
        }
    }
}
