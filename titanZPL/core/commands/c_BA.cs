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
    public class zpl_cmd_c_BA : zpl_command{   //Code 93 Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string print_check_digit                                            = String.Empty;
                                        
        public zpl_cmd_c_BA(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BA";                   
            description="Code 93 Bar Code";                   
            data_format="o,h,f,g,e ";                   
            example    ="^XA"+
			            "^FO100,75^BY3"+
			            "^BAN,100,Y,N,N"+
			            "^FD12345ABCDE^FS"+
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
N = no Y = yes  //N  ZPL Commands ^BA 66 P1012728-011 Zebra Programming Guide 11/21/16 Comments All control codes are used in pairs. Code 93 is also capable of encoding the full 128-character ASCII set. Full ASCII Mode for Code 93 Code 93 can generate the full 128-character ASCII set using paired characters as shown in the following tables
                                       
  **************************************************/ 
            manual=""+ 
			"^BA – Code 93 Bar Code "+ 
			"The ^BA command creates a variable length, continuous symbology. The Code 93 bar code is used "+ 
			"in many of the same applications as Code 39. It uses the full 128-character ASCII set. ZPL II, "+ 
			"however, does not support ASCII control codes or escape sequences. It uses the substitute "+ 
			"characters shown below. "+ 
			"Each character in the Code 93 bar code is composed of six elements: three bars and three spaces. "+ 
			"Although invoked differently, the human-readable interpretation line prints as though the control "+ 
			"code has been used. "+ 
			"• ^BA supports a fixed print ratio. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^BAo,h,f,g,e "+ 
			"Control Code ZPL II Substitute "+ 
			"Ctrl $ & "+ 
			"Ctrl % ‘ "+ 
			"Ctrl / ( "+ 
			"Ctrl + ) "+ 
			"Important • If additional information about the Code 93 bar code is required, go to "+ 
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
			"Default: N "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BA "+ 
			"66 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments All control codes are used in pairs. Code 93 is also capable of encoding the full "+ 
			"128-character ASCII set. "+ 
			"Full ASCII Mode for Code 93 "+ 
			"Code 93 can generate the full 128-character ASCII set using paired characters as shown in the "+ 
			"following tables. "+ 
			"Example: This is an example of a Code 93 bar code: "+ 
			"^XA "+ 
			"^FO100,75^BY3 "+ 
			"^BAN,100,Y,N,N "+ 
			"^FD12345ABCDE^FS "+ 
			"^XZ "+ 
			"CODE 93 BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"ABCDEFGHIJKLMNOPQRSTUVWXYZ "+ 
			"-.$/+%&’() "+ 
			"SPACE "+ 
			"ZPL II CODE "+ 
			"Denotes an internal start/stop character that must precede and follow "+ 
			"every bar code message. "+ 
			"CODE 93 BAR CODE "+ 
			" "+ 
			"67 "+ 
			"ZPL Commands "+ 
			"^BA "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Table 5 • "+ 
			"ASCII Code 93 "+ 
			"NUL "+ 
			"SOH "+ 
			"STX "+ 
			"ETX "+ 
			"EOT "+ 
			"ENQ "+ 
			"ACK "+ 
			"BEL "+ 
			"BS "+ 
			"HT "+ 
			"LF "+ 
			"VT "+ 
			"FF "+ 
			"CR "+ 
			"SO "+ 
			"SI "+ 
			"DLE "+ 
			"DC1 "+ 
			"DC2 "+ 
			"DC3 "+ 
			"DC4 "+ 
			"NAK "+ 
			"SYN "+ 
			"ETB "+ 
			"CAN "+ 
			"EM "+ 
			"SUB "+ 
			"ESC "+ 
			"FS "+ 
			"FS "+ 
			"RS "+ 
			"US "+ 
			"‘U "+ 
			"&A "+ 
			"B "+ 
			"C "+ 
			"D "+ 
			"E "+ 
			"F "+ 
			"G "+ 
			"H "+ 
			"I "+ 
			"J "+ 
			"K "+ 
			"L "+ 
			"M "+ 
			"N "+ 
			"P "+ 
			"Q "+ 
			"R "+ 
			"S "+ 
			"T "+ 
			"U "+ 
			"V "+ 
			"W "+ 
			"X "+ 
			"Y "+ 
			"Z "+ 
			"‘A "+ 
			"‘B "+ 
			"‘C "+ 
			"‘D "+ 
			"‘E "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"&O "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"& "+ 
			"ASCII Code 93 "+ 
			"SP "+ 
			"! "+ 
			"“ "+ 
			"# "+ 
			"$ "+ 
			"% "+ 
			"& "+ 
			"‘ "+ 
			"( "+ 
			") "+ 
			"* "+ 
			"++ "+ 
			", "+ 
			"- "+ 
			". "+ 
			"/ "+ 
			"0 "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"5 "+ 
			"6 "+ 
			"7 "+ 
			"8 "+ 
			"9 "+ 
			": "+ 
			"; "+ 
			"< "+ 
			"= "+ 
			"> "+ 
			"? "+ 
			"Space "+ 
			"(A "+ 
			"(B "+ 
			"C "+ 
			"D "+ 
			"E "+ 
			"F "+ 
			"G "+ 
			"H "+ 
			"I "+ 
			"J "+ 
			"++ "+ 
			"(L "+ 
			"- "+ 
			". "+ 
			"/ "+ 
			"O "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"5 "+ 
			"6 "+ 
			"7 "+ 
			"8 "+ 
			"9 "+ 
			"(Z "+ 
			"‘F "+ 
			"‘G "+ 
			"‘H "+ 
			"‘I "+ 
			"‘J "+ 
			"( "+ 
			"( "+ 
			"( "+ 
			"( "+ 
			"( "+ 
			"( "+ 
			"( "+ 
			"( "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BA "+ 
			"68 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Table 6 • "+ 
			"ASCII Code 93 "+ 
			"@ "+ 
			"A "+ 
			"B "+ 
			"C "+ 
			"D "+ 
			"E "+ 
			"F "+ 
			"G "+ 
			"H "+ 
			"I "+ 
			"J "+ 
			"K "+ 
			"L "+ 
			"M "+ 
			"N "+ 
			"O "+ 
			"P "+ 
			"Q "+ 
			"R "+ 
			"S "+ 
			"T "+ 
			"U "+ 
			"V "+ 
			"W "+ 
			"X "+ 
			"Y "+ 
			"Z "+ 
			"[ "+ 
			"\\ "+ 
			"] "+ 
			"^ "+ 
			"_ "+ 
			"‘V "+ 
			"A "+ 
			"B "+ 
			"C "+ 
			"D "+ 
			"E "+ 
			"F "+ 
			"G "+ 
			"H "+ 
			"I "+ 
			"J "+ 
			"K "+ 
			"L "+ 
			"M "+ 
			"N "+ 
			"O "+ 
			"P "+ 
			"Q "+ 
			"R "+ 
			"S "+ 
			"T "+ 
			"U "+ 
			"V "+ 
			"W "+ 
			"X "+ 
			"Y "+ 
			"Z "+ 
			"‘K "+ 
			"‘L "+ 
			"‘M "+ 
			"‘N "+ 
			"‘O "+ 
			"ASCII Code 93 "+ 
			"‘ "+ 
			"a "+ 
			"b "+ 
			"c "+ 
			"d "+ 
			"e "+ 
			"f "+ 
			"g "+ 
			"h "+ 
			"I "+ 
			"j "+ 
			"k "+ 
			"l "+ 
			"m "+ 
			"n "+ 
			"o "+ 
			"p "+ 
			"q "+ 
			"r "+ 
			"s "+ 
			"t "+ 
			"u "+ 
			"v "+ 
			"w "+ 
			"x "+ 
			"y "+ 
			"z "+ 
			"{ "+ 
			"| "+ 
			"} "+ 
			"~ "+ 
			"DEL "+ 
			"‘W "+ 
			")A "+ 
			")B "+ 
			"C "+ 
			"D "+ 
			"E "+ 
			"F "+ 
			"G "+ 
			"H "+ 
			"I "+ 
			"J "+ 
			"K "+ 
			"L "+ 
			"M "+ 
			"N "+ 
			"O "+ 
			"P "+ 
			"Q "+ 
			"R "+ 
			"S "+ 
			"T "+ 
			"U "+ 
			"V "+ 
			"W "+ 
			"X "+ 
			"Y "+ 
			"Z "+ 
			"‘P "+ 
			"‘Q "+ 
			"‘R "+ 
			"‘S "+ 
			"‘T "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			") "+ 
			" "+ 
			"69 "+ 
			"ZPL Commands "+ 
			"^BB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
