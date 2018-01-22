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
    public class zpl_cmd_c_BS : zpl_command{   //UPC/EAN Extensions
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_BS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BS";                   
            description="UPC/EAN Extensions";                   
            data_format="o,h,f,g ";                   
            example    ="";                   
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
N = no Y = yes  //Y  113 ZPL Commands ^BS 11/21/16 Zebra Programming Guide P1012728-011 Care should be taken in positioning the UPC/EAN extension with respect to the UPC-A or UPC-E code to ensure the resulting composite code is within the UPC specification. For UPC codes, with a module width of 2 (default), the field origin offsets for the extension are
                                       
  **************************************************/ 
            manual=""+ 
			"^BS – UPC/EAN Extensions "+ 
			"The ^BS command is the two-digit and five-digit add-on used primarily by publishers to create bar "+ 
			"codes for ISBNs (International Standard Book Numbers). These extensions are handled as separate "+ 
			"bar codes. "+ 
			"The "+ 
			"^BS command is designed to be used with the UPC-A bar code (^BU) and the UPC-E bar code "+ 
			"( "+ 
			"^B9). "+ 
			"• ^BS supports a fixed print ratio. "+ 
			"• Field data (^FD) is limited to exactly two or five characters. ZPL II automatically "+ 
			"truncates or pads on the left with zeros to achieve the required number of "+ 
			"characters. "+ 
			"Format: ^BSo,h,f,g "+ 
			"Important • If additional information about the UPC/EAN bar code is required, go to "+ 
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
			"Default: Y "+ 
			" "+ 
			"113 "+ 
			"ZPL Commands "+ 
			"^BS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Care should be taken in positioning the UPC/EAN extension with respect to the "+ 
			"UPC-A or UPC-E code to ensure the resulting composite code is within the UPC specification. "+ 
			"For UPC codes, with a module width of "+ 
			"2 (default), the field origin offsets for the extension are: "+ 
			"Example 1: This is an example of a UPC/EAN Two-digit bar code: "+ 
			"Example 2: This is an example of a UPC/EAN Five-digit bar code: "+ 
			"Example 3: This is an example of a UPC-A: "+ 
			"This is an example of a UPC-E: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BSN,100,Y,N "+ 
			"^FD12^FS "+ 
			"^XZ "+ 
			"UPC/EAN 2-DIGIT BAR CODE CHARACTERS "+ 
			"ZPL II CODE "+ 
			"0123456789 "+ 
			"UPC/EAN 2-DIGIT BAR CODE "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BSN,100,Y,N "+ 
			"^FD12345^FS "+ 
			"^XZ "+ 
			"UPC/EAN 5-DIGIT BAR CODE CHARACTERS "+ 
			"ZPL II CODE "+ 
			"0123456789 "+ 
			"UPC/EAN 5-DIGIT BAR CODE "+ 
			"Supplement Origin "+ 
			"X - Offset "+ 
			"209 Dots "+ 
			"0 "+ 
			"Normal "+ 
			"Rotated "+ 
			"Adjustment "+ 
			"Y - Offset "+ 
			"21 Dots "+ 
			"209 Dots "+ 
			"Supplement Origin "+ 
			"X - Offset "+ 
			"122 Dots "+ 
			"0 "+ 
			"Normal "+ 
			"Rotated "+ 
			"Adjustment "+ 
			"Y - Offset "+ 
			"21 Dots "+ 
			"122 Dots "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BS "+ 
			"114 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Additionally, the bar code height for the extension should be 27 dots (0.135 inches) shorter than that "+ 
			"of the primary code. A primary UPC code height of 183 dots (0.900 inches) requires an extension "+ 
			"height of 155 dots (0.765 inches). "+ 
			"Example 4: This example illustrates how to create a normal UPC-A bar code for the value "+ 
			"7000002198 with an extension equal to 04414: "+ 
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
			"115 "+ 
			"ZPL Commands "+ 
			"^BT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
