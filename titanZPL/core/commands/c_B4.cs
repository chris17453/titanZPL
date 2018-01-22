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
    public class zpl_cmd_c_B4 : zpl_command{   //Code 49 Bar Code
        public string orientation                                                  = String.Empty;
        public    int height_multiplier                                            = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string starting_mode                                                = String.Empty;
                                        
        public zpl_cmd_c_B4(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B4";                   
            description="Code 49 Bar Code";                   
            data_format="o,h,f,m ";                   
            example    ="";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            height_multiplier                                           =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            starting_mode                                               =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =height_multiplier_of_individual_rows //1 to height of label  //value set by ^BY This number multiplied by the module equals the height of the individual rows in dots. 1 is not a recommended value. 
	
f =print_interpretation_line //
N = no line printed A = print interpretation line above code B = print interpretation line below code  //N When the field data exceeds two rows, expect the interpretation line to extend beyond the right edge of the bar code symbol. 
	
m =starting_mode //
0 = Regular Alphanumeric Mode 1 = Multiple Read Alphanumeric 2 = Regular Numeric Mode 3 = Group Alphanumeric Mode 4 = Regular Alphanumeric Shift 1 5 = Regular Alphanumeric Shift 2 A = Automatic Mode. The printer determines the starting mode by analyzing the field data.  //A  ZPL Commands ^B4 54 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^B4 – Code 49 Bar Code "+ 
			"The ^B4 command creates a multi-row, continuous, variable-length symbology capable of encoding "+ 
			"the full 128-character ASCII set. It is ideally suited for applications requiring large amounts of data in "+ 
			"a small space. "+ 
			"The code consists of two to eight rows. A row consists of a leading quiet zone, four symbol "+ 
			"characters encoding eight code characters, a stop pattern, and a trailing quiet zone. A separator bar "+ 
			"with a height of one module separates each row. Each symbol character encodes two characters "+ 
			"from a set of Code 49 characters. "+ 
			"• "+ 
			"^B4 has a fixed print ratio. "+ 
			"• Rows can be scanned in any order. "+ 
			"Format: ^B4o,h,f,m "+ 
			"Important • For additional information about the Code 49 bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"h = height multiplier "+ 
			"of individual "+ 
			"rows "+ 
			"Values: 1 to height of label "+ 
			"Default: value set by ^BY "+ 
			"This number multiplied by the module equals the height of the individual rows in "+ 
			"dots. 1 is not a recommended value. "+ 
			"f = print "+ 
			"interpretation "+ 
			"line "+ 
			"Values: "+ 
			"N = no line printed "+ 
			"A = print interpretation line above code "+ 
			"B = print interpretation line below code "+ 
			"Default: N "+ 
			"When the field data exceeds two rows, expect the interpretation line to extend "+ 
			"beyond the right edge of the bar code symbol. "+ 
			"m = starting mode "+ 
			"Values: "+ 
			"0 = Regular Alphanumeric Mode "+ 
			"1 = Multiple Read Alphanumeric "+ 
			"2 = Regular Numeric Mode "+ 
			"3 = Group Alphanumeric Mode "+ 
			"4 = Regular Alphanumeric Shift 1 "+ 
			"5 = Regular Alphanumeric Shift 2 "+ 
			"A = Automatic Mode. The printer determines the starting mode by analyzing "+ 
			"the field data. "+ 
			"Default: A "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B4 "+ 
			"54 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example 1: This is an example of a Code 49 bar code: "+ 
			"CODE 49 BAR CODE "+ 
			"^XA "+ 
			"^FO150,100^BY3 "+ 
			"^B4N,20,A,A "+ 
			"^FD12345ABCDE^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			" "+ 
			"55 "+ 
			"ZPL Commands "+ 
			"^B4 "+ 
			"Code 49 Field Data Character Set "+ 
			"The ^FD data sent to the printer when using starting modes 0 to 5 is based on the "+ 
			"Code 49 Internal Character Set. This is shown in the first column of the Code 49 table on the "+ 
			"previous page. These characters are Code 49 control characters: "+ 
			": ; < = > ? "+ 
			"Valid field data must be supplied when using modes 0 to 5. Shifted characters are sent as a two- "+ 
			"character sequence of a shift character followed by a character in the unshifted character set. "+ 
			"Table 4 • "+ 
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
			"- "+ 
			". "+ 
			"SPACE "+ 
			"$ "+ 
			"/ "+ 
			"++ "+ 
			"% "+ 
			"< (Shift 1) "+ 
			"> (Shift 2) "+ 
			": (N.A.) "+ 
			"; (N.A.) "+ 
			"? (N.A.) "+ 
			"= (Numeric Shift) "+ 
			"Field Data "+ 
			"Set "+ 
			"Unshifted "+ 
			"Character Set "+ 
			"Shift 1 "+ 
			"Character Set "+ 
			"Shift 2 "+ 
			"Character Set "+ 
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
			"- "+ 
			". "+ 
			"SPACE "+ 
			"$ "+ 
			"/ "+ 
			"++ "+ 
			"% "+ 
			"’ "+ 
			"ESC "+ 
			"FS "+ 
			"GS "+ 
			"RS "+ 
			"US "+ 
			"! "+ 
			"“ "+ 
			"# "+ 
			"& "+ 
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
			"( "+ 
			") "+ 
			"Null "+ 
			"* "+ 
			", "+ 
			": "+ 
			"reserved "+ 
			"; "+ 
			"< "+ 
			"= "+ 
			"> "+ 
			"? "+ 
			"@ "+ 
			"[ "+ 
			"\\ "+ 
			"] "+ 
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
			"_ "+ 
			"‘ "+ 
			"DEL "+ 
			"{ "+ 
			"| "+ 
			"} "+ 
			"~ "+ 
			"Code 49 Shift 1 and 2 Character Substitutions "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B4 "+ 
			"56 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"If an invalid sequence is detected, the Code 49 formatter stops interpreting field data and prints a "+ 
			"symbol with the data up to the invalid sequence. These are examples of invalid sequences: "+ 
			"• Terminating numeric mode with any characters other than 0 to 9 or a Numeric Space. "+ 
			"• Starting in Mode 4 (Regular Alphanumeric Shift 1) and the first field data character is "+ 
			"not in the Shift 1 set. "+ 
			"• Starting in Mode 5 (Regular Alphanumeric Shift 2) and the first field data character is "+ 
			"not in the Shift 2 set. "+ 
			"• Sending Shift 1 followed by a character not in the Shift 1 set. "+ 
			"• Sending Shift 2 followed by a character not in the Shift 2 set. "+ 
			"• Sending two Shift 1 or Shift 2 control characters. "+ 
			"Advantages of Using the Code 49 Automatic Mode "+ 
			"Using the default (Automatic Mode) completely eliminates the need for selecting the starting mode "+ 
			"or manually performing character shifts. The Automatic Mode analyzes the incoming ASCII string, "+ 
			"determines the proper mode, performs all character shifts, and compacts the data for maximum "+ 
			"efficiency. "+ 
			"Numeric Mode is selected or shifted only when five or more continuous digits are found. Numeric "+ 
			"packaging provides no space advantage for numeric strings consisting of fewer than eight "+ 
			"characters. "+ 
			"Example 2: To encode a lowercase a, send a > (Shift 2) followed by an uppercase A. If "+ 
			"interpretation line printing is selected, a lowercase a prints in the interpretation line. This "+ 
			"reflects what the output from the scanner reads. Code 49 uses uppercase alphanumeric "+ 
			"characters only. "+ 
			" "+ 
			"57 "+ 
			"ZPL Commands "+ 
			"^B5 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
