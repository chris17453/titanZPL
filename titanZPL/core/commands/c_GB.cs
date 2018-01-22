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
using System.Drawing.Drawing2D;

namespace titanZPL.commands  {
    public class zpl_cmd_c_GB : zpl_command{   //Graphic Box
        public    int box_width                                                    = 0;
        public    int box_height                                                   = 0;
        public    int border_thickness                                             = 0;
        public string line_color                                                   = String.Empty;
        public    int degree_of_corner                                             = 0;
                                        
        public zpl_cmd_c_GB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^GB";                   
            description="Graphic Box";                   
            data_format="w,h,t,c,r ";                   
            example    ="";                   
            box_width                                                   =(   int)argument(0,data,"i","0-32000" ,""," ");
            box_height                                                  =(   int)argument(1,data,"i","0-32000" ,""," ");
            border_thickness                                            =(   int)argument(2,data,"i","0-32000" ,"","1");
            line_color                                                  =(string)argument(3,data,"s","B,W"     ,"","B");
            degree_of_corner                                            =   (int)argument(4,data,"i","1-8"     ,"","0");
                                    
  /*************************************************  
	
w =box_width //value of t to 32000  //value used for thickness (t) or 1 
	
h =box_height //value of t to 32000  //value used for thickness (t) or 1 
	
t =border_thickness //1 to 32000  //1 
	
c =line_color //
B = black W = white  //B 
	
r =degree_of_corner //0 (no rounding) to 8 (heaviest rounding)  //0  ZPL Commands ^GB 184 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^GB – Graphic Box "+ 
			"The ^GB command is used to draw boxes and lines as part of a label format. Boxes and lines are "+ 
			"used to highlight important information, divide labels into distinct areas, or to improve the "+ 
			"appearance of a label. The same format command is used for drawing either boxes or lines. "+ 
			"Format: ^GBw,h,t,c,r "+ 
			"For the "+ 
			"w and h parameters, keep in mind that printers have a default of 6, 8, 12, or "+ 
			"24 dots/millimeter. This comes out to 153, 203, 300, or 600 dots per inch. To determine the values "+ 
			"for w and h, calculate the dimensions in millimeters and multiply by 6, 8, 12, or 24. "+ 
			"If the width and height are not specified, you get a solid box with its width and height as specified by "+ 
			"value "+ 
			"t. "+ 
			"The roundness-index is used to determine a rounding-radius for each box. Formula: "+ 
			"rounding-radius = (rounding-index / 8) * (shorter side / 2) "+ 
			"where the shorter side is the lesser of the width and height (after adjusting for minimum and default "+ 
			"values). "+ 
			"Parameters Details "+ 
			"w = box width (in "+ 
			"dots) "+ 
			"Values: value of t to 32000 "+ 
			"Default: value used for thickness (t) or 1 "+ 
			"h = box height (in "+ 
			"dots) "+ 
			"Values: value of t to 32000 "+ 
			"Default: value used for thickness (t) or 1 "+ 
			"t = border thickness "+ 
			"(in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: 1 "+ 
			"c = line color "+ 
			"Values: "+ 
			"B = black "+ 
			"W = white "+ 
			"Default: B "+ 
			"r = degree of corner- "+ 
			"rounding "+ 
			"Values: 0 (no rounding) to 8 (heaviest rounding) "+ 
			"Default: 0 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^GB "+ 
			"184 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Examples: Here are a few examples of graphic boxes: "+ 
			"Width: 1.5 inch; Height: 1 inch; Thickness: 10; Color: default; Rounding: default "+ 
			"Width: 0 inch; Height: 1 inch; Thickness: 20; Color: default; Rounding: default: "+ 
			"Width: 1 inch; Height: 0 inch; Thickness: 30; Color: default; Rounding: default "+ 
			"Width: 1.5 inch; Height: 1 inch; Thickness: 10; Color: default; Rounding: 5 "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^GB300,200,10^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^GB0,203,20^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^GB203,0,20^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^GB300,200,10,,5^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"185 "+ 
			"ZPL Commands "+ 
			"^GC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      


         public override void draw() {
            //w/h/t/c/r/
            int width       =0;
            int height      =0;
            int thickness   =0;
            int color       =0;
            int radius      =0;

            string[] tokens=data.Split(',');
            if(tokens.Length>=1) Int32.TryParse(tokens[0],out width);
            if(tokens.Length>=2) Int32.TryParse(tokens[1],out height);
            if(tokens.Length>=3) Int32.TryParse(tokens[2],out thickness);
            if(tokens.Length>=4) Int32.TryParse(tokens[3],out color);
            if(tokens.Length>=5) Int32.TryParse(tokens[4],out radius);
            Rectangle bounds=new Rectangle();
            if(thickness>height) {
                bounds.Height=thickness;
            } else {
                bounds.Height=height;
            }
            if(thickness>width) {
                bounds.Width=thickness;
            } else {
                bounds.Width=height;
            }
            bounds.Width=width;
            if(bounds.Width>0 && bounds.Height>0) {
                Bitmap box=new Bitmap(bounds.Width,bounds.Height);
                FillRoundedRectangle(box,brush,bounds, radius);
                this._internal.image=(Bitmap)box;
                this._internal.baseline=box.Height;
                this._internal.width =width;
                this._internal.height=height;
            } else {
                this._internal.error=true;
            }
        }
        public GraphicsPath RoundedRect(Rectangle bounds, int radius){
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();
            if (radius == 0){
                path.AddRectangle(bounds);
                return path;
            }
            path.AddArc(arc, 180, 90);                              // top left arc  
            arc.X = bounds.Right - diameter;                        // top right arc  
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;                       // bottom right arc  
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;                                    // bottom left arc 
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

         public void DrawRoundedRectangle(Bitmap image, Pen pen, Rectangle bounds, int cornerRadius){
            Graphics g=Graphics.FromImage(image);
            if (g   == null)    throw new ArgumentNullException("graphics");
            if (pen == null)    throw new ArgumentNullException("pen");
            using (GraphicsPath path = RoundedRect(bounds, cornerRadius)){
                g.DrawPath(pen, path);
            }
        }

        public void FillRoundedRectangle(Bitmap image, Brush brush, Rectangle bounds, int cornerRadius){
            Graphics g=Graphics.FromImage(image);
            if (g        == null || brush    == null)    return;
            using (GraphicsPath path = RoundedRect(bounds, cornerRadius)){
                g.FillPath(brush, path);
            }
        }
    }//end class                                  
}//end namespace                                  
