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
    public class zpl_cmd_c_B1 : zpl_command{   //Code 11 Bar Code
        public string orientation                                                  = String.Empty;
        public string check_digit                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_B1(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B1";                   
            description="Code 11 Bar Code";                   
            data_format="o,e,h,f,g ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^B1N,N,150,Y,N"+
			            "^FD123456^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            check_digit                                                 =(string)argument(1,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(2,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(3,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //
current ^FW value 
	
e =check_digit //
Y = 1 digit N = 2 digits  //N 
	
h =bar_code_height //1 to 32000  //Value set by ^BY 
	
f =print_interpretation_line //
Y = yes N = no  //Y 
	
g =print_interpretation_line_above_code //
Y = yes N = no  //N  ZPL Commands ^B1 46 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^B1 – Code 11 Bar Code "+ 
			"The ^B1 command produces the Code 11 bar code, also known as USD-8 code. In a Code 11 bar "+ 
			"code, each character is composed of three bars and two spaces, and the character set includes 10 "+ 
			"digits and the hyphen (-). "+ 
			"• "+ 
			"^B1 supports print ratios of 2.0:1 to 3.0:1. "+ 
			"• Field data ( "+ 
			"^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^B1o,e,h,f,g "+ 
			"Important • If additional information about the Code 11 bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: "+ 
			"current "+ 
			"^FW "+ 
			"value "+ 
			"e = check digit "+ 
			"Values: "+ 
			"Y = 1 digit "+ 
			"N = 2 digits "+ 
			"Default: N "+ 
			"h = bar code height "+ 
			"(in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: Value set by ^BY "+ 
			"f = print "+ 
			"interpretation "+ 
			"line "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: Y "+ 
			"g = print "+ 
			"interpretation "+ 
			"line above code "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: N "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B1 "+ 
			"46 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of the Code 11 bar code: "+ 
			"CODE 11 BAR CODE "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^B1N,N,150,Y,N "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			"CODE 11 BAR CODE CHARACTERS "+ 
			"0123456789- "+ 
			"Internal Start/Stop Character: "+ 
			"ZPL II CODE "+ 
			"is used with 1 check digit "+ 
			"is used with 2 check digits "+ 
			"When used as a stop character: "+ 
			" "+ 
			"47 "+ 
			"ZPL Commands "+ 
			"^B2 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
