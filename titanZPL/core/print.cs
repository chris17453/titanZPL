using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL {
    public partial class titanZPL {
        public void print_zpl(string zpl) {
            printer_render.post(zpl,true);
        }
    }
}
