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
    public class zpl_cmd_c_B2 : zpl_command{   //Interleaved 2 of 5 Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string calculate_and_print_mod_10_check_digit                       = String.Empty;
        public string j                                                            = String.Empty;
                                        
        public zpl_cmd_c_B2(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B2";                   
            description="Interleaved 2 of 5 Bar Code";                   
            data_format="o,h,f,g,e,j ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^B2N,150,Y,N,N"+
			            "^FD123456^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(3,data,"s","                   ",""," ");
            calculate_and_print_mod_10_check_digit                      =(string)argument(4,data,"s","                   ",""," ");
            j                                                           =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
Y = yes N = no  //Y 
	
g =print_interpretation_line_above_code //
Y = yes N = no  //N 
	
e =calculate_and_print_Mod_10_check_digit //
Y = yes N = no  //N  ZPL Commands ^B2 48 P1012728-011 Zebra Programming Guide 11/21/16 Comments The total number of digits in an Interleaved 2 of 5 bar code must be even. The printer automatically adds a leading 0 (zero) if an odd number of digits is received. The Interleaved 2 of 5 bar code uses the Mod 10 check-digit scheme for error checking. For more information on Mod 10 check digits, see Mod 10 Check Digit on page 1299
                                       
  **************************************************/ 
            manual=""+ 
			"^B2 – Interleaved 2 of 5 Bar Code "+ 
			"The ^B2 command produces the Interleaved 2 of 5 bar code, a high-density, self-checking, "+ 
			"continuous, numeric symbology. "+ 
			"Each data character for the Interleaved 2 of 5 bar code is composed of five elements: five bars or "+ 
			"five spaces. Of the five elements, two are wide and three are narrow. The bar code is formed by "+ 
			"interleaving characters formed with all spaces into characters formed with all bars. "+ 
			"• "+ 
			"^B2 supports print ratios of 2.0:1 to 3.0:1. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^B2o,h,f,g,e,j "+ 
			"Important • If additional information about the Interleaved 2 of 5 bar code is required, go to "+ 
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
			"e = calculate and "+ 
			"print Mod 10 "+ 
			"check digit "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: N "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B2 "+ 
			"48 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments The total number of digits in an Interleaved 2 of 5 bar code must be even. The "+ 
			"printer automatically adds a leading 0 (zero) if an odd number of digits is received. "+ 
			"The Interleaved 2 of 5 bar code uses the Mod 10 check-digit scheme for error checking. For more "+ 
			"information on Mod 10 check digits, see Mod 10 Check Digit on page 1299. "+ 
			"Example: This is an example of an Interleaved 2 of 5 bar code: "+ 
			"INTERLEAVED 2 OF 5 BAR CODE "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^B2N,150,Y,N,N "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			"INTERLEAVED 2 OF 5 BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"Start/Stop (internal) "+ 
			"ZPL II CODE "+ 
			" "+ 
			"49 "+ 
			"ZPL Commands "+ 
			"^B3 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
