using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands{
    public class zpl_cmd_c_A : zpl_command {      //Scalable/Bitmapped Font
        public zpl_cmd_c_A(string data) {
            cmd = "^A";
            description = "Scalable/Bitmapped Font";
            data_format = "";
        }//end init function
    }//end class
}
