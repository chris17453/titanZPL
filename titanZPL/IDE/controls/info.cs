using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace titanZPL.IDE.controls {
    public partial class info : Form {
        
        public info(string data) {
            InitializeComponent();
            info_box.Text=data;
        }
    }
}
