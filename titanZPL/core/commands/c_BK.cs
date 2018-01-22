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
    public class zpl_cmd_c_BK : zpl_command{   //ANSI Codabar Bar Code
        public string orientation                                                  = String.Empty;
        public string check_digit_fixed_value_n                                    = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string designates_a_start_character                                 = String.Empty;
        public string designates_stop_character                                    = String.Empty;
                                        
        public zpl_cmd_c_BK(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BK";                   
            description="ANSI Codabar Bar Code";                   
            data_format="o,e,h,f,g,k,l ";                   
            example    ="^XA"+
			            "^FO100,100^BY3"+
			            "^BKN,N,150,Y,N,A,A"+
			            "^FD123456^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            check_digit_fixed_value_n                                   =(string)argument(1,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(2,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(3,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(4,data,"s","                   ",""," ");
            designates_a_start_character                                =(string)argument(5,data,"s","                   ",""," ");
            designates_stop_character                                   =(string)argument(6,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
e =check_digit_Fixed_Value_N //
  //
 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
N = no Y = yes  //Y 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //N 
	
k =designates_a_start_character //A,B, C, D  //A 
	
l =designates_stop_character //A,B, C, D  //A  ZPL Commands ^BK 94 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^BK – ANSI Codabar Bar Code "+ 
			"The ANSI Codabar bar code is used in a variety of information processing applications such as "+ 
			"libraries, the medical industry, and overnight package delivery companies. This bar code is also "+ 
			"known as USD-4 code, NW-7, and 2 of 7 code. It was originally developed for retail price labeling. "+ 
			"Each character in this code is composed of seven elements: four bars and three spaces. Codabar "+ 
			"bar codes use two character sets, numeric and control (start and stop) characters. "+ 
			"• ^BK supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^BKo,e,h,f,g,k,l "+ 
			"Important • If additional information about the ANSI Codabar bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"e = check digit Fixed Value: N "+ 
			"Values: "+ 
			" "+ 
			"Default: "+ 
			" "+ 
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
			"k = designates a "+ 
			"start character "+ 
			"Values: A,B, C, D "+ 
			"Default: A "+ 
			"l = designates stop "+ 
			"character "+ 
			"Values: A,B, C, D "+ 
			"Default: A "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BK "+ 
			"94 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of an ANSI Codabar bar code: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BKN,N,150,Y,N,A,A "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			"ANSI CODABAR BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"Control Characters "+ 
			"ZPL II CODE "+ 
			"-:.$/+ "+ 
			"Start/Stop Characters "+ 
			"ABCD "+ 
			"ANSI CODABAR BAR CODE "+ 
			" "+ 
			"95 "+ 
			"ZPL Commands "+ 
			"^BL "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
