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
using System.Collections.Generic;
namespace titanZPL.commands  {
    public class zpl_cmd_c_GE : zpl_command{   //Graphic Ellipse
        public    int ellipse_width                                                = 0;
        public    int ellipse_height                                               = 0;
        public    int border_thickness                                             = 0;
        public string line_color                                                   = String.Empty;
                                        
        public zpl_cmd_c_GE(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^GE";                   
            description="Graphic Ellipse";                   
            data_format="w,h,t,c ";                   
            example    ="^XA"+
			            "^FO100,100"+
			            "^GE300,100,10,B^FS"+
			            "^XZ";                   
            ellipse_width                                               =(   int)argument(0,data,"i","                   ",""," ");
            ellipse_height                                              =(   int)argument(1,data,"i","                   ",""," ");
            border_thickness                                            =(   int)argument(2,data,"i","                   ",""," ");
            line_color                                                  =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
w =ellipse_width //3 to 4095 (larger values are replaced with 4095)  //value used for thickness (t) or 1 
	
h =ellipse_height //3 to 4095  //value used for thickness (t) or 1 
	
t =border_thickness //2 to 4095  //1 
	
c =line_color //
B = black W = white  //
                                       
  **************************************************/ 
            manual=""+ 
			"^GE – Graphic Ellipse "+ 
			"The ^GE command produces an ellipse in the label format. "+ 
			"Format: ^GEw,h,t,c "+ 
			"Parameters Details "+ 
			"w = ellipse width (in "+ 
			"dots) "+ 
			"Values: 3 to 4095 (larger values are replaced with 4095) "+ 
			"Default: value used for thickness (t) or 1 "+ 
			"h = ellipse height "+ 
			"(in dots) "+ 
			"Values: 3 to 4095 "+ 
			"Default: value used for thickness (t) or 1 "+ 
			"t = border thickness "+ 
			"(in dots) "+ 
			"Values: 2 to 4095 "+ 
			"Default: 1 "+ 
			"c = line color "+ 
			"Values: "+ 
			"B = black "+ 
			"W = white "+ 
			"Default: B "+ 
			"Example: This is an example of how to create a ellipse on a printed label: "+ 
			"^XA "+ 
			"^FO100,100 "+ 
			"^GE300,100,10,B^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^GF "+ 
			"188 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
