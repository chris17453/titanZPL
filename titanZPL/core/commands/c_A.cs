/*****************************************************************************
*       ████████╗██╗████████╗ █████╗ ███╗   ██╗███████╗██████╗ ██╗           *
*       ╚══██╔══╝██║╚══██╔══╝██╔══██╗████╗  ██║╚══███╔╝██╔══██╗██║           *
*          ██║   ██║   ██║   ███████║██╔██╗ ██║  ███╔╝ ██████╔╝██║           *
*          ██║   ██║   ██║   ██╔══██║██║╚██╗██║ ███╔╝  ██╔═══╝ ██║           *
*          ██║   ██║   ██║   ██║  ██║██║ ╚████║███████╗██║     ███████╗      *
*          ╚═╝   ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝╚═╝     ╚══════╝      *
******************************************************************************
*      Created By: Charles Watkins                                           *
*      Date      : 2017-10-12                                                *
*****************************************************************************/
using System;
using System.Collections.Generic;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands{
    public class zpl_cmd_c_A : zpl_command {      //Scalable/Bitmapped Font
        public zpl_cmd_c_FR  fr          =null;
        public string font        = String.Empty;
        public string orientation = String.Empty;
        public    int font_height = 0;
        public    int font_width  = 0;
   
        public zpl_cmd_c_A(string data,List<zpl_command> commands):base(commands){   
            fr =(zpl_cmd_c_FR)find_in_field("^FR",true);
            
            cmd = "^A";
            description = "Scalable/Bitmapped Font";
            data_format = "fo,h,w";
            font        = (string)argument(0,data,"c" ,"A-H,0-9"         ,"0","0");
            orientation = (string)argument(0,data,"c" ,"N,R,I,B"         ,"1","N");  //^FW
            font_height = (   int)argument(1,data,"i" ,"2-32000"         ,"","0");    //^CF
            font_width  = (   int)argument(2,data,"i" ,"2-32000"         ,"","0");   //^CF   //width should be DPI*inches wide. or print_width
            example="";
            manual="";                         
            
            if(font_height==0 || font_width==0) {
                build_raster_fonts_from_printer.font_structure fs=new build_raster_fonts_from_printer.font_structure(font);
                font_height =fs.char_height;
                font_width  =fs.char_width;
            }

        }//end init function
    }//end class
}
