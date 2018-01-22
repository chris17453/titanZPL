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
    public class zpl_cmd_c_BL : zpl_command{   //LOGMARS Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_BL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BL";                   
            description="LOGMARS Bar Code";                   
            data_format="o,h,g ";                   
            example    ="^XA"+
			            "^FO100,75^BY3"+
			            "^BLN,100,N"+
			            "^FD12AB^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //
                                       
  **************************************************/ 
            manual=""+ 
			"^BL – LOGMARS Bar Code "+ 
			"The ^BL command is a special application of Code 39 used by the Department of Defense. "+ 
			"LOGMARS is an acronym for Logistics Applications of Automated Marking and Reading Symbols. "+ 
			"• ^BL supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• Field data ( "+ 
			"^FD) is limited to the width (or length, if rotated) of the label. Lowercase "+ 
			"letters in the "+ 
			"^FD string are converted to the supported uppercase LOGMARS "+ 
			"characters. "+ 
			"Format: ^BLo,h,g "+ 
			"Important • If additional information about the LOGMARS bar code is required, go to "+ 
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
			"g = print "+ 
			"interpretation "+ 
			"line above code "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"Example: This is an example of a LOGMARS bar code: "+ 
			"^XA "+ 
			"^FO100,75^BY3 "+ 
			"^BLN,100,N "+ 
			"^FD12AB^FS "+ 
			"^XZ "+ 
			"LOGMARS BAR CODE CHARACTERS "+ 
			"ZPL II CODE "+ 
			"0123456789 "+ 
			"ABCDEFGHIJKLMNOPQRSTUVWXYZ "+ 
			"-.$/+% "+ 
			"SPACE "+ 
			"LOGMARS BAR CODE "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BL "+ 
			"96 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments The LOGMARS bar code produces a mandatory check digit using "+ 
			"Mod 43 calculations. For further information on the Mod 43 check digit, see "+ 
			"Mod 10 Check Digit on page 1299. "+ 
			" "+ 
			"97 "+ 
			"ZPL Commands "+ 
			"^BM "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
