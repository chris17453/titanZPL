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
    public class zpl_cmd_c_GC : zpl_command{   //Graphic Circle
        public    int circle_diameter                                              = 0;
        public    int border_thickness                                             = 0;
        public string line_color                                                   = String.Empty;
                                        
        public zpl_cmd_c_GC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^GC";                   
            description="Graphic Circle";                   
            data_format="d,t,c ";                   
            example    ="^XA"+
			            "^FO50,50"+
			            "^GC250,10,B^FS"+
			            "^XZ";                   
            circle_diameter                                             =(   int)argument(0,data,"i","3-4095","","3");
            border_thickness                                            =(   int)argument(1,data,"i","2-4095","","2");
            line_color                                                  =(string)argument(2,data,"s","B,W"   ,"","B");
                                    
  /*************************************************  
	
d =circle_diameter //3 to 4095 (larger values are replaced with 4095)  //3 
	
t =border_thickness //2 to 4095  //1 
	
c =line_color //
B = black W = white  //
                                       
  **************************************************/ 
            manual=""+ 
			"^GC – Graphic Circle "+ 
			"The ^GC command produces a circle on the printed label. The command parameters specify the "+ 
			"diameter (width) of the circle, outline thickness, and color. Thickness extends inward from the "+ 
			"outline. "+ 
			"Format: ^GCd,t,c "+ 
			"Parameters Details "+ 
			"d = circle diameter "+ 
			"(in dots) "+ 
			"Values: 3 to 4095 (larger values are replaced with 4095) "+ 
			"Default: 3 "+ 
			"t = border thickness "+ 
			"(in dots) "+ 
			"Values: 2 to 4095 "+ 
			"Default: 1 "+ 
			"c = line color "+ 
			"Values: "+ 
			"B = black "+ 
			"W = white "+ 
			"Default: B "+ 
			"Example: This is an example of how to create a circle on the printed label: "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^GC250,10,B^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^GD "+ 
			"186 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function          
        public override void draw() {
            if(circle_diameter>4095) circle_diameter=4095;
            //border_thickness>4095
            //line_color           
            Bitmap image=new Bitmap(circle_diameter,circle_diameter);
            Graphics image_g=Graphics.FromImage(image);
            int intensity=0;
            if (line_color=="B") intensity=0; else intensity=255;
            Pen graphic_pen= new Pen(Color.FromArgb(255, intensity,intensity,intensity), border_thickness);

            image_g.DrawEllipse(graphic_pen,border_thickness,border_thickness,circle_diameter-border_thickness*2,circle_diameter-border_thickness*2);
            _internal.image=image;
            _internal.baseline=image.Height;
            _internal.width =image.Width;
            _internal.height=image.Height;
        }            

            }//end class                                  
}//end namespace                                  
