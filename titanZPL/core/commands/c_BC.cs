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
using System.Collections.Generic;using System.Drawing;

namespace titanZPL.commands  {
    public class zpl_cmd_c_BC : zpl_command{   //Code 128 Bar Code (Subsets A, B, and C)
        public zpl_cmd_c_BY by;
        public zpl_cmd_c_FH fh;
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string ucc_check_digit                                              = String.Empty;
        public string mode                                                         = String.Empty;
                                                
        public zpl_cmd_c_BC(string data,List<zpl_command> commands):base(commands){                    
            fh=(zpl_cmd_c_FH)find_in_field("^FH");
            by=(zpl_cmd_c_BY)find_last    ("^BY");
            cmd        ="^BC";                   
            description="Code 128 Bar Code (Subsets A, B, and C)";                   
            data_format="o,h,f,g,e,m ";                   
            example    ="";                   
            orientation                                                 =(string)argument(0,data,"s","N,R,I,B"      ,"","N");
            bar_code_height                                             =(   int)argument(1,data,"i","1-32000"      ,"","10",by.bar_code_height.ToString());
            print_interpretation_line                                   =(string)argument(2,data,"s","Y,N"          ,"","Y");
            print_interpretation_line_above_code                        =(string)argument(3,data,"s","Y,N"          ,"","N");
            ucc_check_digit                                             =(string)argument(4,data,"s","Y,N"          ,"","N"); //??
            mode                                                        =(string)argument(5,data,"s","N,U,A,D"      ,"","N");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //Y (yes) or N (no)  //Y The interpretation line can be printed in any font by placing the font command before the bar code command. 
	
g =print_interpretation_line_above_code //Y (yes) or N (no)  //N 
	
e =UCC_check_digit //Y (turns on) or N (turns off) Mod 103 check digit is always there. It cannot be turned on or off. Mod 10 and 103 appear together with e turned on.  //N  ZPL Commands ^BC 74 P1012728-011 Zebra Programming Guide 11/21/16 Code 128 Subsets The Code 128 character subsets are referred to as Subset A, Subset B, and Subset C. A subset can be selected in these ways: • A special Invocation Code can be included in the field data (^FD) string associated with that bar code. • The desired Start Code can be placed at the beginning of the field data. If no Start Code is entered, Subset B are used. To change subsets within a bar code, place the Invocation Code at the appropriate points within the field data ( ^FD) string. The new subset stays in effect until changed with the Invocation Code. For example, in Subset C, >7 in the field data changes the Subset to A. Table 7 shows the Code 128 Invocation Codes and Start Characters for the three subsets. 
	
m =mode //
N = no selected mode U = UCC Case Mode • More than 19 digits in ^FD or ^SN are eliminated. • Fewer than 19 digits in ^FD or ^SN add zeros to the right to bring the count to 19. This produces an invalid interpretation line. A = Automatic Mode This analyzes the data sent and automatically determines the best packing method. The full ASCII character set can be used in the ^FD statement — the printer determines when to shift subsets. A string of four or more numeric digits causes an automatic shift to Subset C. D = UCC/EAN Mode (x.11.x and newer firmware) This allows dealing with UCC/EAN with and without chained application identifiers. The code starts in the appropriate subset followed by FNC1 to indicate a UCC/EAN 128 bar code. The printer automatically strips out parentheses and spaces for encoding, but prints them in the human-readable section. The printer automatically determines if a check digit is required, calculate it, and print it. Automatically sizes the human readable.  //N Parameters Detail
                                       
  **************************************************/ 
            manual=""+ 
			"^BC – Code 128 Bar Code (Subsets A, B, and C) "+ 
			"The ^BC command creates the Code 128 bar code, a high-density, variable length, continuous, "+ 
			"alphanumeric symbology. It was designed for complexly encoded product identification. "+ 
			"Code 128 has three subsets of characters. There are 106 encoded printing characters in each set, "+ 
			"and each character can have up to three different meanings, depending on the character subset "+ 
			"being used. Each Code 128 character consists of six elements: three bars and three spaces. "+ 
			"• "+ 
			"^BC supports a fixed print ratio. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"Format: ^BCo,h,f,g,e,m "+ 
			"Important • If additional information about the Code 128 bar code is required, go to "+ 
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
			"Values: Y (yes) or N (no) "+ 
			"Default: Y "+ 
			"The interpretation line can be printed in any font by placing the font command "+ 
			"before the bar code command. "+ 
			"g = print "+ 
			"interpretation "+ 
			"line above code "+ 
			"Values: Y (yes) or N (no) "+ 
			"Default: N "+ 
			"e = UCC check digit "+ 
			"Values: Y (turns on) or N (turns off) "+ 
			"Mod 103 check digit is always there. It cannot be turned on or off. Mod 10 "+ 
			"and 103 appear together with "+ 
			"e turned on. "+ 
			"Default: N "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"74 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Code 128 Subsets "+ 
			"The Code 128 character subsets are referred to as Subset A, Subset B, and Subset C. A subset can "+ 
			"be selected in these ways: "+ 
			"• A special Invocation Code can be included in the field data (^FD) string associated with that bar "+ 
			"code. "+ 
			"• The desired Start Code can be placed at the beginning of the field data. If no Start Code is "+ 
			"entered, Subset B are used. "+ 
			"To change subsets within a bar code, place the Invocation Code at the appropriate points within the "+ 
			"field data ( "+ 
			"^FD) string. The new subset stays in effect until changed with the Invocation Code. For "+ 
			"example, in Subset C, >7 in the field data changes the Subset to A. "+ 
			"Table 7 shows the Code 128 Invocation Codes and Start Characters for the three subsets. "+ 
			"m = mode "+ 
			"Values: "+ 
			"N = no selected mode "+ 
			"U = UCC Case Mode "+ 
			"• More than 19 digits in ^FD or ^SN are eliminated. "+ 
			"• Fewer than 19 digits in "+ 
			"^FD or ^SN add zeros to the right to bring the "+ 
			"count to 19. This produces an invalid interpretation line. "+ 
			"A = Automatic Mode "+ 
			"This analyzes the data sent and automatically determines the best "+ 
			"packing method. The full ASCII character set can be used in the "+ 
			"^FD "+ 
			"statement — the printer determines when to shift subsets. A string of "+ 
			"four or more numeric digits causes an automatic shift to Subset C. "+ 
			"D = UCC/EAN Mode (x.11.x and newer firmware) "+ 
			"This allows dealing with UCC/EAN with and without chained "+ 
			"application identifiers. The code starts in the appropriate subset "+ 
			"followed by FNC1 to indicate a UCC/EAN 128 bar code. The printer "+ 
			"automatically strips out parentheses and spaces for encoding, but "+ 
			"prints them in the human-readable section. The printer automatically "+ 
			"determines if a check digit is required, calculate it, and print it. "+ 
			"Automatically sizes the human readable. "+ 
			"Default: N "+ 
			"Parameters Details "+ 
			"Example 1: This is an example of a Code 128 bar code: "+ 
			"CODE 128 BAR CODE "+ 
			"ZPL II CODE "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BCN,100,Y,N,N "+ 
			"^FD123456^FS "+ 
			"^XZ "+ 
			" "+ 
			"75 "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Table 7 • Code 128 Invocation Characters "+ 
			"Table 8 shows the character sets for Code 128: "+ 
			">< "+ 
			">0 "+ 
			">= "+ 
			">1 "+ 
			">2 "+ 
			">3 "+ 
			">4 "+ 
			">5 "+ 
			">6 "+ 
			">7 "+ 
			">8 "+ 
			">9 "+ 
			">: "+ 
			">; "+ 
			"62 "+ 
			"30 "+ 
			"94 "+ 
			"95 "+ 
			"96 "+ 
			"97 "+ 
			"98 "+ 
			"99 "+ 
			"100 "+ 
			"101 "+ 
			"102 "+ 
			"103 "+ 
			"104 "+ 
			"105 "+ 
			"> "+ 
			"USQ "+ 
			"FNC 3 "+ 
			"FNC 2 "+ 
			"SHIFT "+ 
			"CODE C "+ 
			"CODE B "+ 
			"FNC 4 "+ 
			"FNC 1 "+ 
			"Start Code A "+ 
			"Start Code B "+ 
			"Start Code C "+ 
			"> "+ 
			"~ "+ 
			"DEL "+ 
			"FNC 3 "+ 
			"FNC 2 "+ 
			"SHIFT "+ 
			"CODE C "+ 
			"FNC 4 "+ 
			"CODE A "+ 
			"FNC 1 "+ 
			"(Numeric Pairs give Alpha/Numerics) "+ 
			"(Normal Alpha/Numeric) "+ 
			"(All numeric (00 - 99) "+ 
			"CODE B "+ 
			"CODE A "+ 
			"FNC 1 "+ 
			"Invocation "+ 
			"Code "+ 
			"Start Characters "+ 
			"Decimal "+ 
			"Value "+ 
			"Subset A "+ 
			"Character "+ 
			"Subset B "+ 
			"Character "+ 
			"Subset C "+ 
			"Character "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"76 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Table 8 • "+ 
			"Code A "+ 
			"SP "+ 
			"! "+ 
			"'' "+ 
			"# "+ 
			"$ "+ 
			"% "+ 
			"& "+ 
			"' "+ 
			"( "+ 
			") "+ 
			"* "+ 
			"+ "+ 
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
			"Code B "+ 
			"SP "+ 
			"! "+ 
			"'' "+ 
			"# "+ 
			"$ "+ 
			"% "+ 
			"& "+ 
			"' "+ 
			"( "+ 
			") "+ 
			"* "+ 
			"+ "+ 
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
			"Value "+ 
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
			"10 "+ 
			"11 "+ 
			"12 "+ 
			"13 "+ 
			"14 "+ 
			"15 "+ 
			"16 "+ 
			"17 "+ 
			"18 "+ 
			"19 "+ 
			"20 "+ 
			"21 "+ 
			"22 "+ 
			"23 "+ 
			"24 "+ 
			"25 "+ 
			"26 "+ 
			"27 "+ 
			"28 "+ 
			"29 "+ 
			"30 "+ 
			"31 "+ 
			"32 "+ 
			"33 "+ 
			"34 "+ 
			"35 "+ 
			"36 "+ 
			"37 "+ 
			"38 "+ 
			"39 "+ 
			"40 "+ 
			"41 "+ 
			"42 "+ 
			"43 "+ 
			"44 "+ 
			"45 "+ 
			"46 "+ 
			"47 "+ 
			"48 "+ 
			"49 "+ 
			"50 "+ 
			"51 "+ 
			"52 "+ 
			"Code C "+ 
			"00 "+ 
			"01 "+ 
			"02 "+ 
			"03 "+ 
			"04 "+ 
			"05 "+ 
			"06 "+ 
			"07 "+ 
			"08 "+ 
			"09 "+ 
			"10 "+ 
			"11 "+ 
			"12 "+ 
			"13 "+ 
			"14 "+ 
			"15 "+ 
			"16 "+ 
			"17 "+ 
			"18 "+ 
			"19 "+ 
			"20 "+ 
			"21 "+ 
			"22 "+ 
			"23 "+ 
			"24 "+ 
			"25 "+ 
			"26 "+ 
			"27 "+ 
			"28 "+ 
			"29 "+ 
			"30 "+ 
			"31 "+ 
			"32 "+ 
			"33 "+ 
			"34 "+ 
			"35 "+ 
			"36 "+ 
			"37 "+ 
			"38 "+ 
			"39 "+ 
			"40 "+ 
			"41 "+ 
			"42 "+ 
			"43 "+ 
			"44 "+ 
			"45 "+ 
			"46 "+ 
			"47 "+ 
			"48 "+ 
			"49 "+ 
			"50 "+ 
			"51 "+ 
			"52 "+ 
			"Value "+ 
			"53 "+ 
			"54 "+ 
			"55 "+ 
			"56 "+ 
			"57 "+ 
			"58 "+ 
			"59 "+ 
			"60 "+ 
			"61 "+ 
			"62 "+ 
			"63 "+ 
			"64 "+ 
			"65 "+ 
			"66 "+ 
			"67 "+ 
			"68 "+ 
			"69 "+ 
			"70 "+ 
			"71 "+ 
			"72 "+ 
			"73 "+ 
			"74 "+ 
			"75 "+ 
			"76 "+ 
			"77 "+ 
			"78 "+ 
			"79 "+ 
			"80 "+ 
			"81 "+ 
			"82 "+ 
			"83 "+ 
			"84 "+ 
			"85 "+ 
			"86 "+ 
			"87 "+ 
			"88 "+ 
			"89 "+ 
			"90 "+ 
			"91 "+ 
			"92 "+ 
			"93 "+ 
			"94 "+ 
			"95 "+ 
			"96 "+ 
			"97 "+ 
			"98 "+ 
			"99 "+ 
			"100 "+ 
			"101 "+ 
			"102 "+ 
			"103 "+ 
			"104 "+ 
			"105 "+ 
			"Code C "+ 
			"53 "+ 
			"54 "+ 
			"55 "+ 
			"56 "+ 
			"57 "+ 
			"58 "+ 
			"59 "+ 
			"60 "+ 
			"61 "+ 
			"62 "+ 
			"63 "+ 
			"64 "+ 
			"65 "+ 
			"66 "+ 
			"67 "+ 
			"68 "+ 
			"69 "+ 
			"70 "+ 
			"71 "+ 
			"72 "+ 
			"73 "+ 
			"74 "+ 
			"75 "+ 
			"76 "+ 
			"77 "+ 
			"78 "+ 
			"79 "+ 
			"80 "+ 
			"81 "+ 
			"82 "+ 
			"83 "+ 
			"84 "+ 
			"85 "+ 
			"86 "+ 
			"87 "+ 
			"88 "+ 
			"89 "+ 
			"90 "+ 
			"91 "+ 
			"92 "+ 
			"93 "+ 
			"94 "+ 
			"95 "+ 
			"96 "+ 
			"97 "+ 
			"98 "+ 
			"99 "+ 
			"Code B "+ 
			"Code A "+ 
			"FNC1 "+ 
			"Code B "+ 
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
			". "+ 
			"a "+ 
			"b "+ 
			"c "+ 
			"d "+ 
			"e "+ 
			"f "+ 
			"g "+ 
			"h "+ 
			"i "+ 
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
			"FNC3 "+ 
			"FNC2 "+ 
			"SHIFT "+ 
			"Code C "+ 
			"FNC4 "+ 
			"Code A "+ 
			"FNC1 "+ 
			"START (Code A) "+ 
			"START (Code B) "+ 
			"START (Code C) "+ 
			"Code A "+ 
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
			"GS "+ 
			"RS "+ 
			"US "+ 
			"FNC3 "+ 
			"FNC2 "+ 
			"SHIFT "+ 
			"Code C "+ 
			"Code B "+ 
			"FNC4 "+ 
			"FNC1 "+ 
			" "+ 
			"77 "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"How ^BC Works Within a ZPL II Script "+ 
			" ^XA – the first command starts the label format. "+ 
			"^FO100,75 – the second command sets the field origin at 100 dots across the x-axis and 75 dots "+ 
			"down the y-axis from the upper-left corner. "+ 
			"^BCN,100,Y,N,N – the third command calls for a Code 128 bar code to be printed with no rotation "+ 
			"(N) and a height of 100 dots. An interpretation line is printed (Y) below the bar code (N). No UCC "+ 
			"check digit is used (N). "+ 
			"^FDCODE128^FS (Figure A) ^FD>:CODE128^FS (Figure B) – the field data command specifies the "+ 
			"content of the bar code. "+ 
			" ^XZ – the last command ends the field data and indicates the end of the label. "+ 
			"The interpretation line prints below the code with the UCC check digit turned off. "+ 
			"The "+ 
			"^FD command for Figure A does not specify any subset, so Subset B is used. In Figure B, the "+ 
			"^FD command specifically calls Subset B with the >: Start Code. Although ZPL II defaults to Code B, "+ 
			"it is good practice to include the Invocation Codes in the command. "+ 
			"Example 2: Figures A and B are examples of identical bar codes, and Figure C is an example of "+ 
			"switching from Subset C to B to A, as follows: "+ 
			"Because Code 128 Subset B is the most commonly used subset, ZPL II defaults to Subset B if no "+ 
			"start character is specified in the data string. "+ 
			"^XA "+ 
			"^FO100,75 "+ 
			"^BCN,100,Y,N,N "+ 
			"^FDCODE128^FS "+ 
			"^XZ "+ 
			"Figure A: Subset B with no start character "+ 
			"^XA "+ 
			"^FO100,75 "+ 
			"^BCN,100,Y,N,N "+ 
			"^FD>:CODE128^FS "+ 
			"^XZ "+ 
			"Figure B: Subset B with start character "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^BY3^BCN,100,Y,N,N "+ 
			"^FD>;382436>6CODE128>752375152^FS "+ 
			"^XZ "+ 
			"Figure C: Switching from Subset C to B to A "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"78 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Code 128 – Subset B is programmed directly as ASCII text, except for values greater than 94 "+ 
			"decimal and a few special characters that must be programmed using the invocation codes. Those "+ 
			"characters are: "+ 
			"^ > ~ "+ 
			"The UCC/EAN-128 Symbology "+ 
			"The symbology specified for the representation of Application Identifier data is UCC/EAN-128, a "+ 
			"variant of Code 128, exclusively reserved to EAN International and the Uniform Code Council "+ 
			"(UCC). "+ 
			"Example 3: Code 128 – Subsets A and C "+ 
			"Code 128, Subsets A and C are programmed in pairs of digits, 00 to 99, in the field data string. For "+ 
			"details, see Table 7 on page 75. "+ 
			"In Subset A, each pair of digits results in a single character being encoded in the bar code; in Subset "+ 
			"C, characters are printed as entered. Figure E below is an example of Subset A (>9 is the Start Code "+ 
			"for Subset A). "+ 
			"Nonintegers programmed as the first character of a digit pair (D2) are ignored. However, nonintegers "+ 
			"programmed as the second character of a digit pair (2D) invalidate the entire digit pair, and the pair "+ 
			"is ignored. An extra unpaired digit in the field data string just before a code shift is also ignored. "+ 
			"Figure D and Figure E below are examples of Subset C. Notice that the bar codes are identical. In "+ 
			"the program code for Figure F, the D is ignored and the 2 is paired with the 4. "+ 
			"^XA "+ 
			"^FO100,75^BY3 "+ 
			"^BCN,100,Y,N,N "+ 
			"^FD>;382436^FS "+ 
			"^XZ "+ 
			"Figure D: Subset C with normal data "+ 
			"^XA "+ 
			"^FO100,75^BY3 "+ 
			"^BCN,100,Y,N,N "+ 
			"^FD>;38D2436^FS "+ 
			"^XZ "+ 
			"Figure E: Subset C with ignored alpha character "+ 
			"^XA "+ 
			"^FO100,75^BY3 "+ 
			"^BCN,100,Y,N,N "+ 
			"^FD>935473637171824^FS "+ 
			"^XZ "+ 
			"Figure F: Subset A "+ 
			"Note • It is not intended to be used for data to be scanned at the point of sales in retail outlets. "+ 
			" "+ 
			"79 "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"UCC/EAN-128 offers several advantages. It is one of the most complete, alphanumeric, one- "+ 
			"dimensional symbologies available today. The use of three different character sets (A, B and C), "+ 
			"facilitates the encoding of the full 128 ASCII character set. Code 128 is one of the most compact "+ 
			"linear bar code symbologies. Character set C enables numeric data to be represented in a double "+ 
			"density mode. In this mode, two digits are represented by only one symbol character saving valuable "+ 
			"space. The code is concatenated. That means that multiple AIs and their fields may be combined "+ 
			"into a single bar code. The code is also very reliable. Code 128 symbols use two independent self- "+ 
			"checking features which improves printing and scanning reliability. "+ 
			"UCC/EAN-128 bar codes always contain a special non-data character known as function 1 (FNC 1), "+ 
			"which follows the start character of the bar code. It enables scanners and processing software to "+ 
			"auto-discriminate between UCC/EAN-128 and other bar code symbologies, and subsequently only "+ 
			"process relevant data. "+ 
			"The UCC/EAN-128 bar code is made up of a leading quiet zone, a Code 128 start character A, B, or "+ 
			"C, a FNC 1 character, Data (Application Identifier plus data field), a symbol check character, a stop "+ 
			"character, and a trailing quiet zone. "+ 
			"UCC/EAN, UCC/128 are a couple of ways you'll hear someone refer to the code. This just indicates "+ 
			"that the code is structured as dictated by the application identifiers that are used. "+ 
			"SSCC (Serial Shipping Container Code) formatted following the data structure layout for Application "+ 
			"Identifier 00. See Table 9, UCC/EAN Application Identifier on page 82. It could be 00 which is the "+ 
			"SSCC code. The customer needs to let us know what application identifiers are used for their bar "+ 
			"code so we can help them. "+ 
			"There are several ways of writing the code to print the code to Application Identifier '00' structure. "+ 
			"Using N for the mode (m) parameter "+ 
			"• >;>8' sets it to subset C, function 1 "+ 
			"• '00' is the application identifier followed by '17 characters', the check digit is selected "+ 
			"using the 'Y' for the (e) parameter to automatically print the 20th character. "+ 
			"• you are not limited to 19 characters with mode set to N "+ 
			"Example 1: This example shows with application identifier 00 structure: "+ 
			"^XA "+ 
			"^FO90,200^BY4 "+ 
			"^BCN,256,Y,N,Y,N "+ 
			"^FD>;>80012345123451234512^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"N FOR THE M PARAMETER "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"80 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Using U for the mode (m) parameter "+ 
			"UCC Case Mode "+ 
			"• Choosing U selects UCC Case mode. You will have exactly 19 characters available in "+ 
			"^FD. "+ 
			"• Subset C using FNC1 values are automatically selected. "+ 
			"• Check digit is automatically inserted. "+ 
			"Using D for the mode (m) parameter "+ 
			"(0 at end of field data is a bogus character that is inserted as a place holder for the check digit the "+ 
			"printer will automatically insert. "+ 
			"• Subset C using FNC1 values are automatically selected. "+ 
			"• Parentheses and spaces can be in the field data. '00' application identifier, followed "+ 
			"by 17 characters, followed by bogus check digit place holder. "+ 
			"• Check digit is automatically inserted. The printer will automatically calculate the "+ 
			"check digit and put it into the bar code and interpretation line. "+ 
			"• The interpretation line will also show the parentheses and spaces but will strip them "+ 
			"out from the actual bar code. "+ 
			"Example 1: The example shows the application identifier 00 format: "+ 
			"^XA "+ 
			"^FO90,200 "+ 
			"^BY4^BC,256,Y,N,,U "+ 
			"^FD0012345123451234512^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"U FOR THE M PARAMETER "+ 
			"Example 1: This example shows application identifier 00 format ((x.11.x or later): "+ 
			"^XA "+ 
			"^FO50,200^BCN,150,Y,N,,D "+ 
			"^FD(00)10084423 7449200940^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"D FOR THE M PARAMETER "+ 
			" "+ 
			"81 "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Printing the Interpretation Line "+ 
			"The font command (^A0N,40,30) can be added and changed to alter the font and size of the "+ 
			"interpretation line. "+ 
			"With firmware version later than x.10.x "+ 
			"• A separate text field needs to be written. "+ 
			"• The interpretation line needs to be turned off. "+ 
			"• ^A0N,50,40 is the font and size selection for the separate text field. "+ 
			"• You have to make sure you enter the correct check digit in the text field. "+ 
			"• Creating a separate text field allows you to format the interpretation line with "+ 
			"parentheses and spaces. "+ 
			"Application Identifiers — UCC/EAN APPLICATION IDENTIFIER "+ 
			"An Application Identifier is a prefix code used to identify the meaning and the format of the data that "+ 
			"follows it (data field). "+ 
			"There are AIs for identification, traceability, dates, quantity, measurements, locations, and many "+ 
			"other types of information. "+ 
			"For example, the AI for batch number is 10, and the batch number AI is always followed by an "+ 
			"alphanumeric batch code not to exceed 20-characters. "+ 
			"The UCC/EAN Application Identifiers provide an open standard that can be used and understood by "+ 
			"all companies in the trading chain, regardless of the company that originally issued the codes. "+ 
			"Example 1: This example shows printing the interpretation in a different font with firmware "+ 
			"x.11.x or later: "+ 
			"^XA "+ 
			"^FO50,200 "+ 
			"^A0N,40,30^BCN,150,Y,N,Y "+ 
			"^FD>;>80012345123451234512^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"INTERPRETATION LINE "+ 
			"^XA "+ 
			"^FO25,25 "+ 
			"^BCN,150,N,N,Y "+ 
			"^FD>;>80012345123451234512^FS "+ 
			"^FO100,190 "+ 
			"^A0N,50,40 "+ 
			"^FD(00) 1 2345123 451234512 0^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"FIRMWARE OLDER THAN X.10.X "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"82 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"I "+ 
			"Table 9 • UCC/EAN Application Identifier "+ 
			"Data Content AI "+ 
			"Plus The Following Data "+ 
			"Structure "+ 
			"Serial Shipping Container Code (SSCC) "+ 
			"00 "+ 
			"exactly 18 digits "+ 
			"Shipping Container Code "+ 
			"01 "+ 
			"exactly 14 digits "+ 
			"Batch Numbers "+ 
			"10 "+ 
			"up to 20 alpha numerics "+ 
			"Production Date (YYMMDD) "+ 
			"11 "+ 
			"exactly 6 digits "+ 
			"Packaging Date (YYMMDD) "+ 
			"13 "+ 
			"exactly 6 digits "+ 
			"Sell By Date (YYMMDD) "+ 
			"15 "+ 
			"exactly 6 digits "+ 
			"Expiration Date (YYMMDD) "+ 
			"17 "+ 
			"exactly 6 digits "+ 
			"Product Variant "+ 
			"20 "+ 
			"exactly 2 digits "+ 
			"Serial Number "+ 
			"21 "+ 
			"up to 20 alpha numerics "+ 
			"HIBCC Quantity, Date, Batch and Link "+ 
			"22 "+ 
			"up to 29 alpha numerics "+ 
			"Lot Number "+ 
			"23 "+ 
			"a "+ 
			"up to 19 alpha numerics "+ 
			"Quantity Each "+ 
			"30 "+ 
			"Net Weight (Kilograms) "+ 
			"310 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Length, Meters "+ 
			"311 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Width or Diameter (Meters) "+ 
			"312 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Depths (Meters) "+ 
			"313 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Area (Sq. Meters) "+ 
			"314 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Volume (Liters) "+ 
			"315 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Volume (Cubic Meters) "+ 
			"316 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Net Weight (Pounds) "+ 
			"320 "+ 
			"b "+ 
			"exactly 6 digits "+ 
			"Customer PO Number "+ 
			"400 "+ 
			"up to 29 alpha numerics "+ 
			"Ship To (Deliver To) Location Code using EAN 13 or DUNS "+ 
			"Number with leading zeros "+ 
			"410 "+ 
			"exactly 13 digits "+ 
			"Bill To (Invoice To) Location Code using EAN 13 or DUNS "+ 
			"Number with leading zeros "+ 
			"411 "+ 
			"exactly 13 digits "+ 
			"Purchase from "+ 
			"412 "+ 
			"exactly 13 digits "+ 
			"Ship To (Deliver To) Postal Code within single postal authority "+ 
			"420 "+ 
			"up to 9 alpha numerics "+ 
			"Ship To (Deliver To) Postal Code with 3-digit ISO Country Code "+ 
			"Prefix "+ 
			"421 "+ 
			"3 digits plus up to 9 alpha numerics "+ 
			"Roll Products - width, length, core diameter, direction and splices "+ 
			"8001 "+ 
			"exactly 14 digits "+ 
			"Electronic Serial number for cellular mobile phone "+ 
			"8002 "+ 
			"up to 20 alpha numerics "+ 
			"a. Plus one digit for length indication. "+ 
			"b. Plus one digit for decimal point indication. "+ 
			"Note • Tab le 9 is a partial table showing the application identifiers. For more current and complete "+ 
			"information, search the Internet for UCC Application Identifier. "+ 
			" "+ 
			"83 "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"For date fields that only need to indicate a year and month, the day field is set to 00. "+ 
			"Chaining several application identifiers (firmware x.11.x or later) "+ 
			"The FNC1, which is invoked by >8, is inserted just before the AI's so that the scanners reading the "+ 
			"code sees the FNC1 and knows that an AI follows. "+ 
			"Example 1: This is an example with the mode parameter set to A (automatic): "+ 
			"^XA "+ 
			"^BY2,2.5,193 "+ 
			"^FO33,400 "+ 
			"^BCN,,N,N,N,A "+ 
			"^FD>;>80204017773003486100008535>8910001>837252^FS "+ 
			"^FT33,625^AEN,0,0^FD(02)04017773003486(10)0008535(91)0001(37)2 "+ 
			"52^FS "+ 
			"^XZ "+ 
			"Example 2: This is an example with the mode parameter set to "+ 
			"U: "+ 
			"^XA "+ 
			"^BY3,2.5,193 "+ 
			"^FO33,200 "+ 
			"^BCN,,N,N,N,U "+ 
			"^FD>;>80204017773003486>8100008535>8910001>837252^FS "+ 
			"^FT33,455^A0N,30,30^FD(02)04017773003486(10)0008535(91)0001(37 "+ 
			")252^FS "+ 
			"^XZ "+ 
			"Example 3: This is an example with the mode parameter set to D*: "+ 
			"^XA "+ 
			"^PON "+ 
			"^LH0,0 "+ 
			"^BY2,2.5,145 "+ 
			"^FO218,343 "+ 
			"^BCB,,Y,N,N,D "+ 
			"^FD(91)0005886>8(10)0000410549>8(99)05^FS "+ 
			"^XZ "+ 
			"D* — When trying to print the last Application Identifier with an odd number of characters, a problem "+ 
			"existed when printing EAN128 bar codes using Mode D. The problem was fixed in firmware version "+ 
			"V60.13.0.6. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BD "+ 
			"84 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
        public override void draw() {
            //string data=get_field_data(cmd);
            BarcodeLib.Barcode bc=new BarcodeLib.Barcode();
            bc.Height       =bar_code_height;
            if(null!=by) {
                bc.BarWidth     =by.module_width;
            }
            _internal.image=(Bitmap)bc.Encode(BarcodeLib.TYPE.CODE128,_internal.field_data);
            _internal.baseline=bar_code_height;
            _internal.width =_internal.image.Width;
            _internal.height=_internal.image.Height;
        }

    }//end class                                  
}//end namespace                                  
