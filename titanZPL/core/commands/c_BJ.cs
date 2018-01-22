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
    public class zpl_cmd_c_BJ : zpl_command{   //Standard 2 of 5 Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_BJ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BJ";                   
            description="Standard 2 of 5 Bar Code";                   
            data_format="o,h,f,g ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^BJN,150,Y,N"+
			            "^FD123456^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
N = no Y = yes  //Y 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //
                                       
  **************************************************/ 
            manual=""+ 
			"^BJ – Standard 2 of 5 Bar Code "+ 
			"The ^BJ command is a discrete, self-checking, continuous numeric symbology. "+ 
			"With Standard 2 of 5, all of the information is contained in the bars. Two bar widths are employed in "+ 
			"this code, the wide bar measuring three times the width of the narrow bar. "+ 
			"• ^BJ supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^BJo,h,f,g "+ 
			"Important • If additional information about the Standard 2 of 5 bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"h = bar code height "+ 
			"(in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: value set by ^BY "+ 
			"f = print "+ 
			"interpretation "+ 
			"line "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: Y "+ 
			"g = print "+ 
			"interpretation "+ 
			"line above code "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"Example: This is an example of a Standard 2 of 5 bar code: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BJN,150,Y,N "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			"STANDARD 2 OF 5 BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"Start/Stop (automatic) "+ 
			"ZPL II CODE "+ 
			"STANDARD 2 OF 5 BAR CODE "+ 
			" "+ 
			"93 "+ 
			"ZPL Commands "+ 
			"^BK "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
