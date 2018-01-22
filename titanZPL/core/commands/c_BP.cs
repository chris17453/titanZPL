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
    public class zpl_cmd_c_BP : zpl_command{   //Plessey Bar Code
        public string orientation                                                  = String.Empty;
        public string print_check_digit                                            = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_BP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BP";                   
            description="Plessey Bar Code";                   
            data_format="o,e,h,f,g ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^BPN,N,100,Y,N"+
			            "^FD12345^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            print_check_digit                                           =(string)argument(1,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(2,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(3,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
e =print_check_digit //
N = no Y = yes  //N 
	
h =bar_code_height //
N = no Y = yes  //N 
	
f =print_interpretation_line //
N = no Y = yes  //Y 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //N  ZPL Commands ^BP 102 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^BP – Plessey Bar Code "+ 
			"The ^BP command is a pulse-width modulated, continuous, non-self- checking symbology. "+ 
			"Each character in the Plessey bar code is composed of eight elements: four bars and four adjacent "+ 
			"spaces. "+ 
			"• ^BP supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^BPo,e,h,f,g "+ 
			"Important • If additional information about the Plessey bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"e = print check digit "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"h = bar code height "+ 
			"(in dots) "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
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
			"ZPL Commands "+ 
			"^BP "+ 
			"102 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of a Plessey bar code: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BPN,N,100,Y,N "+ 
			"^FD12345^FS "+ 
			"^XZ "+ 
			"PLESSEY BAR CODE CHARACTERS "+ 
			"ZPL II CODE "+ 
			"0123456789 "+ 
			"ABCDEF "+ 
			"PLESSEY BAR CODE "+ 
			" "+ 
			"103 "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
