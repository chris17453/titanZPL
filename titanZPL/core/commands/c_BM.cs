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
    public class zpl_cmd_c_BM : zpl_command{   //MSI Bar Code
        public string orientation                                                  = String.Empty;
        public string check_digit_selection                                        = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string check_digit_into_the_interpretation_line                     = String.Empty;
                                        
        public zpl_cmd_c_BM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BM";                   
            description="MSI Bar Code";                   
            data_format="o,e,h,f,g,e2 ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^BMN,B,100,Y,N,N"+
			            "^FD123456^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            check_digit_selection                                       =(string)argument(1,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(2,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(3,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(4,data,"s","                   ",""," ");
            check_digit_into_the_interpretation_line                    =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
e =check_digit_selection //
A = no check digits B = 1 Mod 10 C = 2 Mod 10 D = 1 Mod 11 and 1 Mod 10  //B 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
N = no Y = yes  //Y 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //N e
	e2 =inserts_check_digit_into_the_interpretation_line //
N = no Y = yes  //N  ZPL Commands ^BM 98 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^BM – MSI Bar Code "+ 
			"The ^BM command is a pulse-width modulated, continuous, non-self- checking symbology. It is a "+ 
			"variant of the Plessey bar code (^BP). "+ 
			"Each character in the MSI bar code is composed of eight elements: four bars and four adjacent "+ 
			"spaces. "+ 
			"• ^BM supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• For the bar code to be valid, field data ( "+ 
			"^FD) is limited to 1 to 14 digits when "+ 
			"parameter "+ 
			"e is B, C, or D. ^FD is limited to 1 to 13 digits when parameter e is A, plus a "+ 
			"quiet zone. "+ 
			"Format: ^BMo,e,h,f,g,e2 "+ 
			"Important • If additional information about the MSI bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"e = check digit "+ 
			"selection "+ 
			"Values: "+ 
			"A = no check digits "+ 
			"B = 1 Mod 10 "+ 
			"C = 2 Mod 10 "+ 
			"D = 1 Mod 11 and 1 Mod 10 "+ 
			"Default: B "+ 
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
			"e2 = inserts check "+ 
			"digit into the "+ 
			"interpretation "+ 
			"line "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BM "+ 
			"98 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of a MSI bar code: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BMN,B,100,Y,N,N "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			"MSI BAR CODE CHARACTERS "+ 
			"ZPL II CODE "+ 
			"123456789 "+ 
			"MSI BAR CODE "+ 
			" "+ 
			"99 "+ 
			"ZPL Commands "+ 
			"^BO "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
