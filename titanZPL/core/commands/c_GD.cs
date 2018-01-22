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
using System.Collections.Generic;using System.Drawing;

namespace titanZPL.commands  {
    public class zpl_cmd_c_GD : zpl_command{   //Graphic Diagonal Line
        public    int box_width                                                    = 0;
        public    int box_height                                                   = 0;
        public    int border_thickness                                             = 0;
        public string line_color                                                   = String.Empty;
        public string orientation                                                  = String.Empty;
                                        
        public zpl_cmd_c_GD(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^GD";                   
            description="Graphic Diagonal Line";                   
            data_format="w,h,t,c,o ";                   
            example    ="^XA"+
			            "^FO150,100"+
			            "^GB350,203,10^FS"+
			            "^FO155,110"+
			            "^GD330,183,10,,R^FS"+
			            "^XZ";                   
            box_width                                                   =(   int)argument(0,data,"i","3-32000","","3");
            box_height                                                  =(   int)argument(1,data,"i","3-32000","","3");
            border_thickness                                            =(   int)argument(2,data,"i","1-32000","","1");
            line_color                                                  =(string)argument(3,data,"s","B,W"    ,"","B");
            orientation                                                 =(string)argument(4,data,"s","R,L"    ,"","R");
                                    
  /*************************************************  
	
w =box_width //3 to 32000  //value of t (thickness) or 3 
	
h =box_height //3 to 32000  //value of t (thickness) or 3 
	
t =border_thickness //1 to 32000  //1 
	
c =line_color //
B = black W = white  //B 
	
o =orientation //
R (or /) = right-leaning diagonal L (or \\) = left-leaning diagonal  //
                                       
  **************************************************/ 
            manual=""+ 
			"^GD – Graphic Diagonal Line "+ 
			"The ^GD command produces a straight diagonal line on a label. This can be used in conjunction with "+ 
			"other graphic commands to create a more complex figure. "+ 
			"Format: ^GDw,h,t,c,o "+ 
			"Parameters Details "+ 
			"w = box width (in "+ 
			"dots) "+ 
			"Values: 3 to 32000 "+ 
			"Default: value of t (thickness) or 3 "+ 
			"h = box height (in "+ 
			"dots) "+ 
			"Values: 3 to 32000 "+ 
			"Default: value of t (thickness) or 3 "+ 
			"t = border thickness "+ 
			"(in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: 1 "+ 
			"c = line color "+ 
			"Values: "+ 
			"B = black "+ 
			"W = white "+ 
			"Default: B "+ 
			"o = orientation "+ 
			"(direction of "+ 
			"the diagonal) "+ 
			"Values: "+ 
			"R (or /) = right-leaning diagonal "+ 
			"L (or \\) "+ 
			"= left-leaning diagonal "+ 
			"Default: R "+ 
			"Example: This is an example of how to create a diagonal line connecting one corner with the "+ 
			"opposite corner of a box on a printed label: "+ 
			"^XA "+ 
			"^FO150,100 "+ 
			"^GB350,203,10^FS "+ 
			"^FO155,110 "+ 
			"^GD330,183,10,,R^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"187 "+ 
			"ZPL Commands "+ 
			"^GE "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function        
        public override void draw() {
            Bitmap image=new Bitmap(box_width,box_height);
            Graphics image_g=Graphics.FromImage(image);
            int intensity=0;
            if (line_color=="B") intensity=0; else intensity=255;
            Pen graphic_pen= new Pen(Color.FromArgb(255, intensity,intensity,intensity), border_thickness);

            if(orientation=="L") {
                image_g.DrawLine(graphic_pen,0,0,box_width,box_height);
            }
            if (orientation=="R") {
                image_g.DrawLine(graphic_pen,box_width,0,0,box_height);
            } 
            _internal.image=image;
            _internal.baseline=image.Height;   
            _internal.width =image.Width;
            _internal.height=image.Height;

        }
    }//end class                                  
}//end namespace                                  
