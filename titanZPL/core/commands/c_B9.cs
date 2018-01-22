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
    public class zpl_cmd_c_B9 : zpl_command{   //UPC-E Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string print_check_digit                                            = String.Empty;
                                        
        public zpl_cmd_c_B9(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B9";                   
            description="UPC-E Bar Code";                   
            data_format="o,h,f,g,e ";                   
            example    ="^XA"+
			            "^FO150,100^BY3"+
			            "^B9N,100,Y,N,Y"+
			            "^FD1230000045^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(3,data,"s","                   ",""," ");
            print_check_digit                                           =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
N = no Y = yes  //Y 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //N 
	
e =print_check_digit //
N = no Y = yes  //Y  ZPL Commands ^B9 64 P1012728-011 Zebra Programming Guide 11/21/16 Rules for Proper Product Code Numbers • If the last three digits in the manufacturer’s number are 000, 100, or 200, valid product code numbers are 00000 to 00999. • If the last three digits in the manufacturer’s number are 300, 400, 500, 600, 700, 800, or 900, valid product code numbers are 00000 to 00099. • If the last two digits in the manufacturer’s number are 10, 20, 30, 40, 50, 60, 70, 80, or 90, valid product code numbers are 00000 to 00009. • If the manufacturer’s number does not end in zero (0), valid product code numbers are 00005 to 00009
                                       
  **************************************************/ 
            manual=""+ 
			"^B9 – UPC-E Bar Code "+ 
			"The ^B9 command produces a variation of the UPC symbology used for number system 0. It is a "+ 
			"shortened version of the UPC-A bar code, where zeros are suppressed, resulting in codes that "+ 
			"require less printing space. The 6 dot/mm, 12 dot/mm, and 24 dot/mm printheads produce the UPC "+ 
			"and EAN symbologies at 100 percent of their size. However, an 8 dot/mm printhead produces the "+ 
			"UPC and EAN symbologies at a magnification factor of 77 percent. "+ 
			"Each character in a UPC-E bar code is composed of four elements: two bars and two spaces. The "+ 
			"^BY command must be used to specify the width of the narrow bar. "+ 
			"• ^B9 supports a fixed ratio. "+ 
			"• Field data (^FD) is limited to exactly 10 characters, requiring a five-digit manufacturer’s code "+ 
			"and five-digit product code. "+ 
			"• When using the zero-suppressed versions of UPC, you must enter the full "+ 
			"10-character sequence. ZPL II calculates and prints the shortened version. "+ 
			"Format: ^B9o,h,f,g,e "+ 
			"Important • If additional information about the UPC-E bar code is required, go to "+ 
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
			"e = print check digit "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: Y "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B9 "+ 
			"64 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Rules for Proper Product Code Numbers "+ 
			"• If the last three digits in the manufacturer’s number are 000, 100, or 200, valid product code "+ 
			"numbers are 00000 to 00999. "+ 
			"• If the last three digits in the manufacturer’s number are 300, 400, 500, 600, 700, 800, or 900, "+ 
			"valid product code numbers are 00000 to 00099. "+ 
			"• If the last two digits in the manufacturer’s number are 10, 20, 30, 40, 50, 60, 70, 80, or 90, valid "+ 
			"product code numbers are 00000 to 00009. "+ 
			"• If the manufacturer’s number does not end in zero (0), valid product code numbers are 00005 to "+ 
			"00009. "+ 
			"Example: This is an example of a UPC-E bar code: "+ 
			"UPC-E BAR CODE "+ 
			"^XA "+ 
			"^FO150,100^BY3 "+ 
			"^B9N,100,Y,N,Y "+ 
			"^FD1230000045^FS "+ 
			"^XZ "+ 
			"UPC-E BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"ZPL II CODE "+ 
			" "+ 
			"65 "+ 
			"ZPL Commands "+ 
			"^BA "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
