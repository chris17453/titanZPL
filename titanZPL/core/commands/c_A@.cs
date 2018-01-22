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
    public class zpl_cmd_c_A2 : zpl_command{   //Use Font Name to Call Font
        public string orientation                                                  = String.Empty;
        public    int height                                                       = 0;
        public    int width                                                        = 0;
        public string drive                                                        = String.Empty;
        public string font                                                         = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_A2(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^A@";                   
            description="Use Font Name to Call Font";                   
            data_format="o,h,w,d,f,x ";                   
            example    ="^XA"+
			            "2"+
			            "^A2N,50,50,B:CYRI_UB.FNT"+
			            "3"+
			            "^FO100,100"+
			            "4"+
			            "^FDZebra Printer Fonts^FS"+
			            "5"+
			            "^A2N,40,40"+
			            "6"+
			            "^F0100,150"+
			            "7"+
			            "^FDThis uses B:CYRI_UB.FNT^FS"+
			            "8"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            height                                                      =(   int)argument(1,data,"i","                   ",""," ");
            width                                                       =(   int)argument(2,data,"i","                   ",""," ");
            drive                                                       =(string)argument(3,data,"s","                   ",""," ");
            font                                                        =(string)argument(4,data,"s","                   ",""," ");
            extension                                                   =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =field_orientation //
N = normal R = rotates 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //N or the last ^FW value 
	
h =character_height //
1-32000  //
Specifies magnification by w (character width) or the last accepted ^CF value. Uses the base height if none is specified. • Scalable The value is the height in dots of the entire character block. Magnification factors are unnecessary, because characters are scaled. • Bitmapped The value is rounded to the nearest integer multiple of the font’s base height, then divided by the font’s base height to give a magnification nearest limit. 
	
w =width // //Specifies magnification by h (height) or the last accepted ^CF value. Specifies the base width is used if none is specified. • Scalable The value is the width in dots of the entire character block. Magnification factors are unnecessary, because characters are scaled. • Bitmapped The value rounds to the nearest integer multiple of the font’s base width, then divided by the font’s base width to give a magnification nearest limit. 
	
d =drive_location_of_font //R:, E:, B:, and A:  //R: 
	
f =font_name //any valid font  //if an invalid or no name is entered, the default set by ^CF is used If no font has been specified in ^CF, font A is used. The font named carries over on all subsequent ^A@ commands without a font name. 
	
x =extension // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^A@ – Use Font Name to Call Font "+ 
			"The ^A@ command uses the complete name of a font, rather than the character designation used in "+ 
			"^A. Once a value for ^A@ is defined, it represents that font until a new font name is specified by ^A@. "+ 
			"Format: ^A@o,h,w,d:f.x "+ 
			"Parameter Details "+ 
			"o = field orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotates 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: N or the last ^FW value "+ 
			"h = character height "+ 
			"(in dots) "+ 
			"Values: "+ 
			"1-32000 "+ 
			"Default: "+ 
			"Specifies magnification by "+ 
			"w (character width) or the last accepted ^CF value. Uses "+ 
			"the base height if none is specified. "+ 
			"• Scalable "+ 
			"The value is the height in dots of the entire character block. Magnification factors "+ 
			"are unnecessary, because characters are scaled. "+ 
			"• Bitmapped "+ 
			"The value is rounded to the nearest integer multiple of the font’s base height, "+ 
			"then divided by the font’s base height to give a magnification nearest limit. "+ 
			"w = width (in dots) "+ 
			"Default: Specifies magnification by h (height) or the last accepted ^CF value. "+ 
			"Specifies the base width is used if none is specified. "+ 
			"• Scalable "+ 
			"The value is the width in dots of the entire character block. Magnification factors "+ 
			"are unnecessary, because characters are scaled. "+ 
			"• Bitmapped "+ 
			"The value rounds to the nearest integer multiple of the font’s base width, then "+ 
			"divided by the font’s base width to give a magnification nearest limit. "+ 
			"d = drive location of "+ 
			"font "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"f = font name "+ 
			"Values: any valid font "+ 
			"Default: if an invalid or no name is entered, the default set by ^CF is used If no font "+ 
			"has been specified in ^CF, font A is used. "+ 
			"The font named carries over on all subsequent ^A@ commands "+ 
			"without a font name. "+ 
			"x = extension "+ 
			".TTE "+ 
			"is only supported in "+ 
			"firmware version V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			"Values: "+ 
			".FNT = font "+ 
			".TTF = TrueType Font "+ 
			".TTE = TrueType Extension "+ 
			" "+ 
			"ZPL Commands "+ 
			"^A@ "+ 
			"42 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"For reference, see Zebra Code Page 850 — Latin Character Set on page 1265, Fonts and Bar "+ 
			"Codes on page 1283, and ASCII on page 1279. "+ 
			"Example: This example identifies the purpose of each line of code for this label: "+ 
			"1 "+ 
			"Starts the label format. "+ 
			"2 "+ 
			"Searches non-volatile printer memory (B:) for CYRI_UB.FNT. When the "+ 
			"font is found, the "+ 
			"^A@ command sets the print orientation to normal and the "+ 
			"character size to 50 dots by 50 dots. "+ 
			"3 "+ 
			"Sets the field origin at 100,100. "+ 
			"4 "+ 
			"Prints the field data, Zebra Printer Fonts on the label. "+ 
			"5 "+ 
			"Calls the font again and character size is decreased to 40 dots by 40 dots. "+ 
			"6 "+ 
			"Sets the new field origin at 100,150. "+ 
			"7 "+ 
			"Prints the field data, This uses the B:CYRI_UB.FNT on the label. "+ 
			"8 "+ 
			"Ends the label format. "+ 
			"ZPL II Code Generated Label "+ 
			"1 "+ 
			"^XA "+ 
			"2 "+ 
			"^A2N,50,50,B:CYRI_UB.FNT "+ 
			"3 "+ 
			"^FO100,100 "+ 
			"4 "+ 
			"^FDZebra Printer Fonts^FS "+ 
			"5 "+ 
			"^A2N,40,40 "+ 
			"6 "+ 
			"^F0100,150 "+ 
			"7 "+ 
			"^FDThis uses B:CYRI_UB.FNT^FS "+ 
			"8 "+ 
			"^XZ "+ 
			" "+ 
			"43 "+ 
			"ZPL Commands "+ 
			"^B0 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
