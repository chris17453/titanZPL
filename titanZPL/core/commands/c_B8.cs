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
    public class zpl_cmd_c_B8 : zpl_command{   //EAN-8 Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_B8(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B8";                   
            description="EAN-8 Bar Code";                   
            data_format="o,h,f,g ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^B8N,100,Y,N"+
			            "^FD1234567^FS"+
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
N = no Y = yes  //N  ZPL Commands ^B8 62 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^B8 – EAN-8 Bar Code "+ 
			"The ^B8 command is the shortened version of the EAN-13 bar code. EAN is an acronym for "+ 
			"European Article Numbering. Each character in the EAN-8 bar code is composed of four elements: "+ 
			"two bars and two spaces. "+ 
			"• "+ 
			"^B8 supports a fixed ratio. "+ 
			"•Field data ( "+ 
			"^FD) is limited to exactly seven characters. ZPL II automatically pads or truncates on "+ 
			"the left with zeros to achieve the required number of characters. "+ 
			"• When using JAN-8 (Japanese Article Numbering), a specialized application of EAN-8, the first "+ 
			"two non-zero digits sent to the printer are always 49. "+ 
			"Format: ^B8o,h,f,g "+ 
			"Important • If additional information about the EAN-8 bar code is required, go to "+ 
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
			"ZPL Commands "+ 
			"^B8 "+ 
			"62 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of an EAN-8 bar code: "+ 
			"EAN-8 BAR CODE "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^B8N,100,Y,N "+ 
			"^FD1234567^FS "+ 
			"^XZ "+ 
			"EAN-8 BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"ZPL II CODE "+ 
			" "+ 
			"63 "+ 
			"ZPL Commands "+ 
			"^B9 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
