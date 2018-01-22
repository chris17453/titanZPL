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
using Bytescout.BarCode;
using System;
using System.Collections.Generic;using System.Drawing;

namespace titanZPL.commands  {
    public class zpl_cmd_c_B3 : zpl_command{   //Code 39 Bar Code
        public zpl_cmd_c_FH fh=null;
        public zpl_cmd_c_BY by=null;
        public string orientation                                                  = String.Empty;
        public string mod                                                          = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
                                        
        public zpl_cmd_c_B3(string data,List<zpl_command> commands):base(commands){                    
            fh=(zpl_cmd_c_FH)find_in_field("^FH");
            by=(zpl_cmd_c_BY)find_last    ("^BY");
            cmd        ="^B3";                   
            description="Code 39 Bar Code";                   
            data_format="o,e,h,f,g ";                   
            example    ="";                   
            orientation                                                 =(string)argument(0,data,"s","N,R,I,B" ,"","N");  //fw
            mod                                                         =(string)argument(1,data,"s","Y,N"     ,"","N");
            bar_code_height                                             =(   int)argument(2,data,"i","1-32000" ,"","1",by.bar_code_height.ToString());  //by
            print_interpretation_line                                   =(string)argument(3,data,"s","Y,N"     ,"","Y");
            print_interpretation_line_above_code                        =(string)argument(4,data,"s","Y,N"     ,"","N");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
e =Mod //
Y = yes N = no  //N 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
Y = yes N = no  //Y 
	
g =print_interpretation_line_above_code //
Y = yes N = no  //N  ZPL Commands ^B3 50 P1012728-011 Zebra Programming Guide 11/21/16 Comments Extended ASCII is a function of the scanner, not of the bar code. Your scanner must have extended ASCII enabled for this feature to work. To enable extended ASCII in the Code 39, you must first encode +$ in your ^FD statement. To disable extended ASCII, you must encode -$ in your ^FD statement. Full ASCII Mode for Code 39 Code 39 can generate the full 128-character ASCII set using paired characters as shown in these tables
                                       
  **************************************************/ 
            manual=""+ 
			"^B3 – Code 39 Bar Code "+ 
			"The Code 39 bar code is the standard for many industries, including the U.S. Department of "+ 
			"Defense. It is one of three symbologies identified in the American National Standards Institute "+ 
			"(ANSI) standard MH10.8M-1983. Code 39 is also known as USD-3 Code and 3 of 9 Code. "+ 
			"Each character in a Code 39 bar code is composed of nine elements: five bars, four spaces, and an "+ 
			"inter-character gap. Three of the nine elements are wide; the six remaining elements are narrow. "+ 
			"• "+ 
			"^B3 supports print ratios of 2.0:1 to 3.0:1. "+ 
			"• Field data (^FD) is limited to the width (or length, if rotated) of the label. "+ 
			"• Code 39 automatically generates the start and stop character (*). "+ 
			"• Asterisk (*) for start and stop character prints in the interpretation line, if the interpretation line is "+ 
			"turned on. "+ 
			"• Code 39 is capable of encoding the full 128-character ASCII set. "+ 
			"Format: ^B3o,e,h,f,g "+ 
			"Important • If additional information about the Code 39 bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"e = Mod-43 check "+ 
			"digit "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: N "+ 
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
			" "+ 
			"ZPL Commands "+ 
			"^B3 "+ 
			"50 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments Extended ASCII is a function of the scanner, not of the bar code. Your scanner "+ 
			"must have extended ASCII enabled for this feature to work. To enable extended ASCII in the "+ 
			"Code 39, you must first encode +$ in your "+ 
			"^FD statement. To disable extended ASCII, you "+ 
			"must encode -$ in your "+ 
			"^FD statement. "+ 
			"Full ASCII Mode for Code 39 "+ 
			"Code 39 can generate the full 128-character ASCII set using paired characters as shown in these "+ 
			"tables: "+ 
			"Example 1: This is an example of a Code 39 bar code: "+ 
			"Example 2: This example encodes a carriage return with line feed into a Code 39 bar code: "+ 
			"CODE 39 BAR CODE "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^B3N,N,100,Y,N "+ 
			"^FD123ABC^FS "+ 
			"^XZ "+ 
			"CODE 39 BAR CODE CHARACTERS "+ 
			"0123456789 "+ 
			"ABCDEFGHIJKLMNOPQRSTUVWXYZ "+ 
			"-.$/+%Space "+ 
			"ZPL II CODE "+ 
			"^XA "+ 
			"^FO20,20 "+ 
			"^B3N,N,100,Y "+ 
			"^FDTEST+$$M$J-$^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABELS "+ 
			" "+ 
			"51 "+ 
			"ZPL Commands "+ 
			"^B3 "+ 
			"Table 2 • "+ 
			"ASCII Code 39 "+ 
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
			"$A "+ 
			"$B "+ 
			"$C "+ 
			"$D "+ 
			"$E "+ 
			"$F "+ 
			"$G "+ 
			"$H "+ 
			"$I "+ 
			"$J "+ 
			"$K "+ 
			"$L "+ 
			"$M "+ 
			"$N "+ 
			"$O "+ 
			"$P "+ 
			"$Q "+ 
			"$R "+ 
			"$S "+ 
			"$T "+ 
			"$U "+ 
			"$V "+ 
			"$W "+ 
			"$X "+ 
			"$Y "+ 
			"$Z "+ 
			"%A "+ 
			"%B "+ 
			"%C "+ 
			"%D "+ 
			"%E "+ 
			"ASCII Code 39 "+ 
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
			"/A "+ 
			"/B "+ 
			"/C "+ 
			"/D "+ 
			"/E "+ 
			"/F "+ 
			"/G "+ 
			"/H "+ 
			"/I "+ 
			"/J "+ 
			"/K "+ 
			"/L "+ 
			"- "+ 
			". "+ 
			"/O "+ 
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
			"/Z "+ 
			"%F "+ 
			"%G "+ 
			"%H "+ 
			"%I "+ 
			"%J "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B3 "+ 
			"52 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Table 3 • "+ 
			"ASCII Code 39 "+ 
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
			"%V "+ 
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
			"%K "+ 
			"%L "+ 
			"%M "+ 
			"%N "+ 
			"%O "+ 
			"ASCII Code 39 "+ 
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
			"%W "+ 
			"+A "+ 
			"+B "+ 
			"+C "+ 
			"+D "+ 
			"+E "+ 
			"+F "+ 
			"+G "+ 
			"+H "+ 
			"+I "+ 
			"+J "+ 
			"+K "+ 
			"+L "+ 
			"+M "+ 
			"+N "+ 
			"+O "+ 
			"+P "+ 
			"+Q "+ 
			"+R "+ 
			"+S "+ 
			"+T "+ 
			"+U "+ 
			"+V "+ 
			"+W "+ 
			"+X "+ 
			"+Y "+ 
			"+Z "+ 
			"%P "+ 
			"%Q "+ 
			"%R "+ 
			"%S "+ 
			"%T, %X "+ 
			" "+ 
			"53 "+ 
			"ZPL Commands "+ 
			"^B4 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
        public override void draw() {
            string field_data=get_field_data(fh.hexadecimal_indicator[0]);
            
	        Barcode barcode = new Barcode();
			barcode.RegistrationName=bytescout_registrationName;
            barcode.RegistrationKey =bytescout_registrationKey;
            
			barcode.Symbology = SymbologyType.Code39;
			barcode.NarrowBarWidth  = by.module_width;
			barcode.Value = field_data;
            barcode.BarHeight=bar_code_height;
			
            Bitmap image=(Bitmap)barcode.GetImage();
			barcode.Dispose();


            _internal.image=image;
            _internal.baseline=image.Height;
            _internal.width =image.Width;
            _internal.height=image.Height;
        }
    }//end class                                  
}//end namespace                                  
