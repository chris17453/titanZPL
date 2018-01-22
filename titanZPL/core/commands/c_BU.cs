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
    public class zpl_cmd_c_BU : zpl_command{   //UPC-A Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string print_check_digit                                            = String.Empty;
                                        
        public zpl_cmd_c_BU(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BU";                   
            description="UPC-A Bar Code";                   
            data_format="o,h,f,g,e ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^BUN,137"+
			            "^FD07000002198^FS"+
			            "^FO400,121"+
			            "^BSN,117"+
			            "^FD04414^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(3,data,"s","                   ",""," ");
            print_check_digit                                           =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 9999  //value set by ^BY 
	
f =print_interpretation_line //
N = no Y = yes  //Y 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //N 
	
e =print_check_digit //
N = no Y = yes  //Y Note • Zero is not allowed.  ZPL Commands ^BU 118 P1012728-011 Zebra Programming Guide 11/21/16 • 12 dot/mm printer: a modulus of 5 dots or greater prints with an OCR-B interpretation line; a modulus of 1, 2, 3, or 4 dots prints font A. • 24 dot/mm printer: a modulus of 9 dots or greater prints with an OCR-B interpretation line; a modulus of 1 to 8 dots prints font A. Comments The UPC-A bar code uses the Mod 10 check digit scheme for error checking. For further information on Mod 10, see Mod 10 Check Digit on page 1299
                                       
  **************************************************/ 
            manual=""+ 
			"^BU – UPC-A Bar Code "+ 
			"The ^BU command produces a fixed length, numeric symbology. It is primarily used in the retail "+ 
			"industry for labeling packages. The UPC-A bar code has 11 data characters. The 6 dot/mm, 12 "+ 
			"dot/mm, and 24 dot/mm printheads produce the UPC-A bar code (UPC/EAN symbologies) at 100 "+ 
			"percent size. However, an 8 dot/mm printhead produces the UPC/EAN symbologies at a "+ 
			"magnification factor of 77 percent. "+ 
			"• ^BU supports a fixed print ratio. "+ 
			"• Field data (^FD) is limited to exactly 11 characters. ZPL II automatically truncates or "+ 
			"pads on the left with zeros to achieve required number of characters. "+ 
			"Format: ^BUo,h,f,g,e "+ 
			"The font style of the interpretation line depends on the modulus (width of narrow bar) selected in "+ 
			"^BY: "+ 
			"• 6 dot/mm printer: a modulus of 2 dots or greater prints with an OCR-B interpretation line; a "+ 
			"modulus of 1 dot prints font A. "+ 
			"• 8 dot/mm printer: a modulus of 3 dots or greater prints with an OCR-B interpretation line; a "+ 
			"modulus of 1 or 2 dots prints font A. "+ 
			"Important • If additional information about the UPC-A bar code is required, go to "+ 
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
			"Values: 1 to 9999 "+ 
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
			"Note • Zero is not allowed. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BU "+ 
			"118 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"• 12 dot/mm printer: a modulus of 5 dots or greater prints with an OCR-B interpretation line; a "+ 
			"modulus of 1, 2, 3, or 4 dots prints font A. "+ 
			"• 24 dot/mm printer: a modulus of 9 dots or greater prints with an OCR-B interpretation line; a "+ 
			"modulus of 1 to 8 dots prints font A. "+ 
			"Comments The UPC-A bar code uses the Mod 10 check digit scheme for error checking. For "+ 
			"further information on Mod 10, see Mod 10 Check Digit on page 1299. "+ 
			"Example: This is an example of a UPC-A bar code with extension: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BUN,137 "+ 
			"^FD07000002198^FS "+ 
			"^FO400,121 "+ 
			"^BSN,117 "+ 
			"^FD04414^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"UPC-A BAR CODE WITH EXTENSION "+ 
			" "+ 
			"119 "+ 
			"ZPL Commands "+ 
			"^BX "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
