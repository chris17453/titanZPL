using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using titanZPL.commands;
namespace titanZPL{
    public partial class titanZPL{
        /*  public zpl_cmd_c_FB last_fb;
          public zpl_cmd_c_FH last_fh;
          public zpl_cmd_c_A  last_a;
          public zpl_cmd_c_BY last_by;
          */
        List<zpl_command>   files=new List<zpl_command>();      //internally stored files. fonts/graphics

        public int x=0;
        public int y=0;
        public int justification=0;
        public string field_data=String.Empty;

        public string cooridinate_mode = "";

        //commands.zpl_command get_last(string cmd) {
        //    zpl_commands.i
       // }
        
        //This function runs the action on each command, and builds any graphics objects needed

        public SizeF calcuate_label_dimentions() {
            SizeF dimentions=new SizeF();
            int width=0;
            int height=0;
            int len=zpl_commands.Count;
            for(int index=0;index<len;index++) {
                zpl_command cmd=zpl_commands[index];
                if(cmd._internal.x+cmd._internal.width >width ) width =cmd._internal.x+cmd._internal.width;
                if(cmd._internal.y+cmd._internal.height>height) height=cmd._internal.y+cmd._internal.height;
            }
            dimentions.Width=width;
            dimentions.Height=height;
            return dimentions;
        }
        public void build() {                                   
            int len     =zpl_commands.Count;
            zpl_command last_visual_object=null;             //the last object we can draw
            files.Clear();
            field_data=String.Empty;
            x=0;
            y=0;
            cooridinate_mode ="";
    
            for(int index=0;index<len;index++) {
                zpl_command cmd=zpl_commands[index];
                
                switch(cmd.cmd) {
                    
                    //font selection
                    case "^A":  break;        
                    //sets barcode width/ratio
                    case "^BY": break;        
                    case "^CV": break;        
                    case "~DG": files.Add(cmd); break;        
                    case "^FB": break;        
                    //These 2 are the CORE of data. and drawing all text
                    case "^FD": field_data=((zpl_cmd_c_FD)cmd).field_data;  
                                if (null!=last_visual_object) process_last_object(last_visual_object);
                                else {
                                    cmd._internal.transform_cooridinates(x,y,cooridinate_mode);
                                    ((zpl_cmd_c_FD)cmd).draw();
                                }
                                break;
                    case "^FV": field_data=((zpl_cmd_c_FV)cmd).field_data;
                                
                                if (null!=last_visual_object) process_last_object(last_visual_object);
                                else {
                                    cmd._internal.transform_cooridinates(x,y,cooridinate_mode);
                                    ((zpl_cmd_c_FV)cmd).draw();
                                }
                                break;
                    case "^FH": break;
                    //field reverse print
                    case "^FR": 
                                    break;
                    //This is the CORE of positioning.
                    case "^FO": x=((zpl_cmd_c_FO)cmd).x; y=((zpl_cmd_c_FO)cmd).y; justification=((zpl_cmd_c_FO)cmd).justification; cooridinate_mode="FO"; break;
                    //this resets data per code block
                    case "^FS": field_data=""; x=0;y=0;  last_visual_object=null; break;        
                    //This is the CORE of positioning.
                    case "^FT": x=((zpl_cmd_c_FT)cmd).x; y=((zpl_cmd_c_FT)cmd).y; justification=((zpl_cmd_c_FT)cmd).justification; cooridinate_mode="FT"; break;
                    //barcodes
                    case "^B3": cmd._internal.transform_cooridinates(x,y,cooridinate_mode); last_visual_object=cmd; break;
                    case "^B7": cmd._internal.transform_cooridinates(x,y,cooridinate_mode); last_visual_object=cmd; break;
                    case "^BC": cmd._internal.transform_cooridinates(x,y,cooridinate_mode); last_visual_object=cmd; break;
                    case "^BD": cmd._internal.transform_cooridinates(x,y,cooridinate_mode); last_visual_object=cmd; break;
                    //graphic box
                    case "^GB": cmd._internal.transform_cooridinates(x,y,cooridinate_mode);((zpl_cmd_c_GB)cmd).draw(); break;
                    //graphic circle
                    case "^GC": cmd._internal.transform_cooridinates(x,y,cooridinate_mode);((zpl_cmd_c_GC)cmd).draw(); break;
                    //graphic diagnal line 
                    case "^GD": cmd._internal.transform_cooridinates(x,y,cooridinate_mode);((zpl_cmd_c_GD)cmd).draw(); break;
                    //graphic field
                    case "^GF": cmd._internal.transform_cooridinates(x,y,cooridinate_mode);((zpl_cmd_c_GF)cmd).draw(); break;
                    case "^XG": cmd._internal.transform_cooridinates(x,y,cooridinate_mode);((zpl_cmd_c_XG)cmd).files=files; ((zpl_cmd_c_XG)cmd).draw(); break;

                }
                //cooridinate_mode
            }
        }

        //this function processes objects that require data from objects further up stream. (almost all visual objects)
        public void process_last_object(zpl_command cmd) {
            if(null==cmd) return;
            cmd._internal.field_data=field_data;
            //cmd.draw();
            switch(cmd.cmd) {
                case "^B3": ((zpl_cmd_c_B3)cmd).draw(); break;
                case "^B7": ((zpl_cmd_c_B7)cmd).draw(); break;
                case "^BC": ((zpl_cmd_c_BC)cmd).draw(); break;
                case "^BD": ((zpl_cmd_c_BD)cmd).draw(); break;
                case "^FD": ((zpl_cmd_c_FD)cmd).draw(); break;
                case "^FV": ((zpl_cmd_c_FV)cmd).draw(); break;
            }
        }

        //this function displays the individual objects on the greater world.
        public void new_canvas() {
            if(null!=graphics) {
                graphics.Dispose();
                label.Dispose();
            }
            label       =new Bitmap(label_bounds.Width,label_bounds.Height);
            graphics    =Graphics.FromImage(label);
        }

        public void draw() {
            if(null==label) {
                new_canvas();    
            } else {
                if(label_bounds.Width!=label.Width || label_bounds.Height!=label.Height) {
                    new_canvas();
                }
            }
            if(null==label) return;
            graphics=Graphics.FromImage(label);
            graphics.Clear(Color.White);
            brush   =Brushes.Black;
            pen     =Pens.Black;
            foreach(zpl_command cmd in zpl_commands) {
                draw_object(cmd);
            }
        }
    }//end class
}//end namespace
