using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands{
     public class zpl_internal{
            public Bitmap   image;   
            public int      x {get { return label_home_x+field_x+drag_x-drag_start_x; } set { } }
            public int      y {
            get {
                if(cooridinate_mode=="FT") return label_home_y+field_y+drag_y-drag_start_y-baseline;
                return label_home_y+field_y+drag_y-drag_start_y;
            } set { } }
            public int      width           =1;
            public int      height          =1;
            public bool     highlight       =false;
            public int      baseline        =0;
            public bool     drag            =false;
            public int      drag_start_x    =0;             //where the mouse was when it weas clicked
            public int      drag_start_y    =0;
            public int      drag_x          =0;             //where it is now
            public int      drag_y          =0;
            public bool     error           =false;
            public string   error_msg       =string.Empty;
            public string   cooridinate_mode=string.Empty;
            public int      field_x         =0;
            public int      field_y         =0;
            public int      label_home_x    =0;
            public int      label_home_y    =0;
            public string   field_data      =String.Empty;
            public string[] arguments;
            public int      argument_max    =0;
            public void transform_cooridinates(int label_x,int label_y,string mode) {
                cooridinate_mode=mode;
                field_x=label_x;
                field_y=label_y;
                //int x=0,y=0;
               /* if (cooridinate_mode=="FO") {
                    x=label_home_x+field_x;
                    y=label_home_y+field_y;
                }
                if(cooridinate_mode=="FT") {
                    x=label_home_x+field_x;
                    y=label_home_y+field_y-baseline;
                }*/
                if(null!=image) {
                    width =image.Width;
                    height=image.Height;
                } else {
                    width =1;
                    height=1;
                }
            }
    }
}
