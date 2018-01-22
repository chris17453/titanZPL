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
    public class zpl_cmd_c_B5 : zpl_command{   //Planet Code bar code
        public string orientation_code                                             = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above                              = String.Empty;
                                        
        public zpl_cmd_c_B5(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B5";                   
            description="Planet Code bar code";                   
            data_format="o,h,f,g ";                   
            example    ="^XA"+
			            "^FO150,100^BY3"+
			            "^B5N,100,Y,N"+
			            "^FD12345678901^FS"+
			            "^XZ";                   
            orientation_code                                            =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            print_interpretation_line_above                             =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation_code //
N = normal R = rotated I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 9999  //value set by ^BY 
	
f =interpretation_line //
N = no Y = yes  //N 
	
g =determines_if_the_interpretation_line_is_printed_above_the_bar_code //
N = no Y = yes  //
                                       
  **************************************************/ 
            manual=""+ 
			"^B5 – Planet Code bar code "+ 
			"The ^B5 command is supported in all printers as a resident bar code. "+ 
			"Format: ^B5o,h,f,g "+ 
			"Note • Accepted bar code characters are 0 - 9. "+ 
			"Parameters Details "+ 
			"o = orientation code "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"h = bar code height "+ 
			"(in dots) "+ 
			"Values: 1 to 9999 "+ 
			"Default: value set by ^BY "+ 
			"f = interpretation "+ 
			"line "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"g = determines if the "+ 
			"interpretation "+ 
			"line is printed "+ 
			"above the bar "+ 
			"code "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"Example: This is an example of a Planet Code bar code: "+ 
			"^XA "+ 
			"^FO150,100^BY3 "+ 
			"^B5N,100,Y,N "+ 
			"^FD12345678901^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B7 "+ 
			"58 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
