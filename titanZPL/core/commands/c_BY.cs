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
    public class zpl_cmd_c_BY : zpl_command{   //Bar Code Field Default
        public    int module_width                                                 = 0;
        public  float ratio                                                        = 0;
        public    int bar_code_height                                              = 0;
                                        
        public zpl_cmd_c_BY(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BY";                   
            description="Bar Code Field Default";                   
            data_format="w,r,h ";                   
            example    ="";                   
            module_width                                                =(   int)argument(0,data,"i","1-10"   ,"","6");
            ratio                                                       =( float)argument(1,data,"f","2-3"    ,"","3");
            bar_code_height                                             =(   int)argument(2,data,"i","1-32000","","10");
                                    
  /*************************************************  
	
w =module_width //1 to 10 Initial Value at Power Up: 2 r = wide bar to narrow bar width ratio Values: 2.0 to 3.0, in 0.1 increments This parameter has no effect on fixed-ratio bar codes.  //3.0 
	
h =bar_code_height // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^BY – Bar Code Field Default "+ 
			"The ^BY command is used to change the default values for the module width (in dots), the wide bar "+ 
			"to narrow bar width ratio and the bar code height (in dots). It can be used as often as necessary "+ 
			"within a label format. "+ 
			"Format: ^BYw,r,h "+ 
			"For parameter "+ 
			"r, the actual ratio generated is a function of the number of dots in parameter w, "+ 
			"module width. See Table 12 on page 123. Module width and height (w and h) can be changed at "+ 
			"anytime with the ^BY command, regardless of the symbology selected. "+ 
			"Table 12 • Shows Module Width Ratios in Dots "+ 
			"Comments Once a ^BY command is entered into a label format, it stays in effect until "+ 
			"another "+ 
			"^BY command is encountered. "+ 
			"Parameters Details "+ 
			"w = module width (in "+ 
			"dots) "+ 
			"Values: 1 to 10 "+ 
			"Initial Value at Power Up: 2 "+ 
			"r = wide bar to "+ 
			"narrow bar width "+ 
			"ratio "+ 
			"Values: 2.0 to 3.0, in 0.1 increments "+ 
			"This parameter has no effect on fixed-ratio bar codes. "+ 
			"Default: 3.0 "+ 
			"h = bar code height "+ 
			"(in dots) "+ 
			"Initial Value at Power Up: 10 "+ 
			"Example: Set module width (w) to 9 and the ratio (r) to 2.4. The width of the narrow bar is 9 dots "+ 
			"wide and the wide bar is 9 by 2.4, or 21.6 dots. However, since the printer rounds out to the nearest "+ 
			"dot, the wide bar is actually printed at 22 dots. This produces a bar code with a ratio of 2.44 (22 "+ 
			"divided by 9). This ratio is as close to 2.4 as possible, since only full dots are printed. "+ 
			"12345678910 "+ 
			"2.0 "+ 
			"2.1 "+ 
			"2.2 "+ 
			"2.3 "+ 
			"2.4 "+ 
			"2.5 "+ 
			"2.6 "+ 
			"2.7 "+ 
			"2.8 "+ 
			"2.9 "+ 
			"3.0 "+ 
			"2:1 2:1 2:1 2:1 2:1 2:1 2:1 2:1 2:1 2:1 "+ 
			"2:1 2:1 2:1 2:1 2:1 2:1 2:1 2:1 2:1 2.1:1 "+ 
			"2:1 2:1 2:1 2:1 2.2:1 2.16:1 2.1:1 2.12:1 2.1:1 2.2:1 "+ 
			"2:1 2:1 2.3:1 2.25:1 2.2:1 2.16:1 2.28:1 2.25:1 2.2:1 2.3:1 "+ 
			"2:1 2:1 2.3:1 2.25:1 2.4:1 2.3:1 2.28:1 2.37:1 2.3:1 2.4:1 "+ 
			"2:1 2.5:1 2.3:1 2.5:1 2.4:1 2.5:1 2.4:1 2.5:1 2.4:1 2.5:1 "+ 
			"2:1 2.5:1 2.3:1 2.5:1 2.6:1 2.5:1 2.57:1 2.5:1 2.5:1 2.6:1 "+ 
			"2:1 2.5:1 2.6:1 2.5:1 2.6:1 2.6:1 2.57:1 2.65:1 2.6:1 2.7:1 "+ 
			"2:1 2.5:1 2.6:1 2.75:1 2.8:1 2.6:1 2.7:1 2.75:1 2.7:1 2.8:1 "+ 
			"2:1 2.5:1 2.6:1 2.75:1 2.8:1 2.8:1 2.85:1 2.87:1 2.8:1 2.9:1 "+ 
			"3:1 3:1 3:1 3:1 3:1 3:1 3:1 3:1 3:1 3:1 "+ 
			"Module Width in Dots (w) "+ 
			"Ratio "+ 
			"Selected "+ 
			"(r) "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BZ "+ 
			"124 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
