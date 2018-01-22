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
    public class zpl_cmd_c_BI : zpl_command{   //Industrial 2 of 5 Bar Codes
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_BI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BI";                   
            description="Industrial 2 of 5 Bar Codes";                   
            data_format="o,h,f,g ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^BIN,150,Y,N"+
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
N = no Y = yes  //N  91 ZPL Commands ^BI 11/21/16 Zebra Programming Guide P1012728-01
                                       
  **************************************************/ 
            manual=""+ 
			"^BI – Industrial 2 of 5 Bar Codes "+ 
			"The ^BI command is a discrete, self-checking, continuous numeric symbology. The Industrial 2 of 5 "+ 
			"bar code has been in use the longest of the 2 of 5 family of bar codes. Of that family, the Standard 2 "+ 
			"of 5 ( "+ 
			"^BJ) and Interleaved 2 of 5 (^B2) bar codes are also available in ZPL II. "+ 
			"With Industrial 2 of 5, all of the information is contained in the bars. Two bar widths are employed in "+ 
			"this code, the wide bar measuring three times the width of the narrow bar. "+ 
			"• ^BI supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^BIo,h,f,g "+ 
			"Important • If additional information about the Industrial 2 of 5 bar code, go to "+ 
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
			" "+ 
			"91 "+ 
			"ZPL Commands "+ 
			"^BI "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example: This is an example of an Industrial 2 of 5 bar code: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BIN,150,Y,N "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			"INDUSTRIAL 2 OF 5 BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"Start/Stop (internal) "+ 
			"ZPL II CODE "+ 
			"INDUSTRIAL 2 OF 5 BAR CODE "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BJ "+ 
			"92 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
