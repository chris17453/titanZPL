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
    public class zpl_cmd_c_BQ : zpl_command{   //QR Code Bar Code
        public string orientation                                                  = String.Empty;
        public string b                                                            = String.Empty;
        public    int magnification_factor                                         = 0;
        public string error_correction                                             = String.Empty;
        public string e                                                            = String.Empty;
                                        
        public zpl_cmd_c_BQ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BQ";                   
            description="QR Code Bar Code";                   
            data_format="a,b,c,d,e ";                   
            example    ="^XA"+
			            "^FO,20,20^BQ,2,10"+
			            "^FDD03048F,LM,N0123456789,A12AABB,B0006qrcode^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
            magnification_factor                                        =(   int)argument(2,data,"i","                   ",""," ");
            error_correction                                            =(string)argument(3,data,"s","                   ",""," ");
            e                                                           =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =field_orientation //normal (^FW has no effect on rotation) b = model Values: 1 (original) and 2 (enhanced – recommended)  //2 
	
c =magnification_factor //1 to 10  //
1 on 150 dpi printers 2 on 200 dpi printers 3 on 300 dpi printers 6 on 600 dpi printers 
	
d =error_correction //
H = ultra-high reliability level Q = high reliability level M = standard level L = high density level  //

	
Q =if_empty_M //0 - 7  //7  ZPL Commands ^BQ 104 P1012728-011 Zebra Programming Guide 11/21/16 On the pages that follow are specific commands for formatting the ^BQ command with the ^FD statements that contain the information to be coded. QR Switches (formatted into the ^FD field data) There are 4 switch fields that are allowed, some with associated parameters and some without. Two of these fields are always present, one is optional, and one’s presence depends on the value of another. The switches are always placed in a fixed order. The four switches, in order are: Mixed mode <D>iijjxx,Optional (note that this switch ends with a comma “,”) Error correction level <H, Q, M, L>Mandatory Data input <A, M>,Mandatory (note that this switch ends with a comma “,”) Character Mode <N, A, Bdddd, K>Conditional (present if data input is M) Mixed mode (Optional)
	)
=D // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^BQ – QR Code Bar Code "+ 
			"The ^BQ command produces a matrix symbology consisting of an array of nominally square "+ 
			"modules arranged in an overall square pattern. A unique pattern at three of the symbol’s four "+ 
			"corners assists in determining bar code size, position, and inclination. "+ 
			"A wide range of symbol sizes is possible, along with four levels of error correction. User-specified "+ 
			"module dimensions provide a wide variety of symbol production techniques. "+ 
			"QR Code Model 1 is the original specification, while QR Code Model 2 is an enhanced form of the "+ 
			"symbology. Model 2 provides additional features and can be automatically differentiated from Model "+ 
			"1. "+ 
			"Model 2 is the recommended model and should normally be used. "+ 
			"This bar code is printed using field data specified in a subsequent "+ 
			"^FD string. "+ 
			"Encodable character sets include numeric data, alphanumeric data, 8-bit byte data, and Kanji "+ 
			"characters. "+ 
			"Format: ^BQa,b,c,d,e "+ 
			"Important • If additional information about the QR Code bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"a = field orientation "+ 
			"Values: normal (^FW has no effect on rotation) "+ 
			"b = model "+ 
			"Values: 1 (original) and 2 (enhanced – recommended) "+ 
			"Default: 2 "+ 
			"c = magnification "+ 
			"factor "+ 
			"Values: 1 to 10 "+ 
			"Default: "+ 
			"1 on 150 dpi printers "+ 
			"2 on 200 dpi printers "+ 
			"3 on 300 dpi printers "+ 
			"6 on 600 dpi printers "+ 
			"d = error correction "+ 
			"Values: "+ 
			"H = ultra-high reliability level "+ 
			"Q = high reliability level "+ 
			"M = standard level "+ 
			"L = high density level "+ 
			"Default: "+ 
			"Q = if empty "+ 
			"M = invalid values "+ 
			"e = mask value "+ 
			"Values: 0 - 7 "+ 
			"Default: 7 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"104 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"On the pages that follow are specific commands for formatting the ^BQ command with the ^FD "+ 
			"statements that contain the information to be coded. "+ 
			"QR Switches (formatted into the ^FD field data) "+ 
			"There are 4 switch fields that are allowed, some with associated parameters and some without. Two "+ 
			"of these fields are always present, one is optional, and one’s presence depends on the value of "+ 
			"another. The switches are always placed in a fixed order. The four switches, in order are: "+ 
			"Mixed mode <D>iijjxx,Optional (note that this switch ends with a comma “,”) "+ 
			"Error correction level <H, Q, M, L>Mandatory "+ 
			"Data input <A, M>,Mandatory (note that this switch ends with a comma “,”) "+ 
			"Character Mode <N, A, Bdddd, K>Conditional (present if data input is M) "+ 
			"Mixed mode (Optional) "+ 
			"= D - allows mixing of different types of character modes in one code. "+ 
			"ii = code No. – a 2 digit number in the range 01 to 16 "+ 
			"Value = subtracted from the Nth number of the divided code (must be two digits). "+ 
			"jj = No. of divisions – a 2 digit number in the range 02 to 16 "+ 
			"Number of divisions (must be two digits). "+ 
			"xx = parity data – a 2 digit hexadecimal character in the range 00 to FF "+ 
			"Parity data value is obtained by calculating at the input data (the original input data before "+ 
			"divided byte-by-byte through the EX-OR operation). "+ 
			", = the mixed mode switch, when present, is terminated with a comma "+ 
			"Error correction level (Required) "+ 
			"= H, Q, M, or L "+ 
			"H = ultra-high reliability level "+ 
			"Q = high reliability level "+ 
			"M = standard level (default) "+ 
			"L = high density level "+ 
			"Example 1: This is an example of a QR Code bar code: "+ 
			"^XA "+ 
			"^FO100,100 "+ 
			"^BQN,2,10 "+ 
			"^FDMM,AAC-42^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"QR CODE BAR CODE "+ 
			" "+ 
			"105 "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Data input (Required) "+ 
			"= A or M followed by a comma "+ 
			"A = Automatic Input (default). Character Mode is not specified. "+ 
			"Data character string JIS8 unit, Shift JIS. When the input mode is Automatic Input, the binary codes "+ 
			"of 0x80 to 0x9F and 0xE0 to 0xFF cannot be set. "+ 
			"M = Manual Input. Character Mode must be specified. "+ 
			"Two types of data input mode exist: Automatic (A) and Manual (M). If A is specified, the "+ 
			"character mode does not need to be specified. If M is specified, the character mode must be "+ 
			"specified. "+ 
			"Character Mode (Required when data input = M) "+ 
			"= N, A, Bxxxx, or K "+ 
			"N = numeric: digits 0 – 9 "+ 
			"A = alphanumeric: digits 0 – 9, upper case letters A – Z, space, and $%*+-./:) (45 characters) "+ 
			"Bxxxx = 8-bit byte mode. The ‘xxxx’ is the number of characters and must be exactly 4 decimal "+ 
			"digits. "+ 
			"This handles the 8-bit Latin/Kana character set in accordance with JIS X 0201 (character values "+ 
			"0x00 to 0xFF). "+ 
			"K = Kanji — handles only Kanji characters in accordance with the Shift JIS system based on JIS X "+ 
			"0208. This means that all parameters after the character mode K should be 16-bit characters. If "+ 
			"there are any 8-bit characters (such as ASCII code), an error occurs. "+ 
			"The data to be encoded follows immediately after the last switch. "+ 
			"Considerations for ^FD When Using the QR Code: "+ 
			"QR Switches (formatted into the "+ 
			"^FD field data) "+ 
			"mixed mode <D> "+ 
			"D = allows mixing of different types of character modes in one code. "+ 
			"code No. <01 16> "+ 
			"Value "+ 
			"= subtracted from the Nth number of the divided code (must be two digits). "+ 
			"No. of divisions <02 16> "+ 
			"Number of divisions (must be two digits). "+ 
			"parity data <1 byte> "+ 
			"Parity data value is obtained by calculating at the input data (the original input data "+ 
			"before divided byte-by-byte through the EX-OR operation). "+ 
			"error correction level <H, Q, M, L> "+ 
			"H = ultra-high reliability level "+ 
			"Q = high reliability level "+ 
			"M = standard level (default) "+ 
			"L = high density level "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"106 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"character Mode <N, A, B, K> "+ 
			"N = numeric "+ 
			"A = alphanumeric "+ 
			"Bxxxx = 8-bit byte mode. This handles the 8-bit Latin/Kana character set in accordance "+ 
			"with JIS X 0201 (character values 0x00 to 0xFF). "+ 
			"xxxx "+ 
			"= number of data characters is represented by two bytes of BCD code. "+ 
			"K = Kanji — handles only Kanji characters in accordance with the Shift JIS system based "+ 
			"on JIS X 0208. This means that all parameters after the character mode K should be 16-bit "+ 
			"characters. If there are any 8-bit characters (such as ASCII code), an error occurs. "+ 
			"data character string <Data> "+ 
			"Follows character mode or it is the last switch in the ^FD statement. "+ 
			"data input <A, M> "+ 
			"A = Automatic Input (default). Data character string JIS8 unit, Shift JIS. When the input "+ 
			"mode is Automatic Input, the binary codes of 0x80 to 0x9F and 0xE0 to 0xFF cannot be "+ 
			"set. "+ 
			"M = Manual Input "+ 
			"Two types of data input mode exist: Automatic (A) and Manual (M). If A is specified, the character "+ 
			"mode does not need to be specified. If M is specified, the character mode must be specified. "+ 
			"^FD Field Data (Normal Mode) "+ 
			"Automatic Data Input (A) with Switches "+ 
			"^FD "+ 
			"<error correction level>A, "+ 
			"<data character string> "+ 
			"^FS "+ 
			"Manual Data Input (M) with Switches "+ 
			"^FD "+ 
			"<error correction level>M, "+ 
			"<character mode><data character string> "+ 
			"^FS "+ 
			"Example 1: QR Code, normal mode with automatic data input. "+ 
			"1 "+ 
			"Q = "+ 
			"error correction level "+ 
			"2 "+ 
			"A, = "+ 
			"automatic setting "+ 
			"3 "+ 
			"data string character "+ 
			"^XA "+ 
			"^FO20,20^BQ,2,10^FDQA,0123456789ABCD 2D code^FS "+ 
			"^XZ "+ 
			"31 "+ 
			"2 "+ 
			" "+ 
			"107 "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example 1: QR Code, normal mode with manual data input: "+ 
			"1 "+ 
			"H = "+ 
			"error correction level (ultra-high reliability level "+ 
			"2 "+ 
			"M, = "+ 
			"input mode (manual input) "+ 
			"3 "+ 
			"N = "+ 
			"character mode (numeric data) "+ 
			"4 "+ 
			"data character string "+ 
			"Example 2: QR Code, normal mode with standard reliability and manual data input: "+ 
			"1 "+ 
			"M = "+ 
			"error correction level (standard-high reliability level "+ 
			"2 "+ 
			"M, = "+ 
			"manual input "+ 
			"3 "+ 
			"A = "+ 
			"alphanumeric data "+ 
			"4 "+ 
			"AC-42 = "+ 
			"data character string "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO20,20^BQ,2,10 "+ 
			"^FDHM,N123456789012345^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"1 "+ 
			"2 "+ 
			"4 "+ 
			"3 "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO20,20^BQ,2,10^FDMM,AAC-42^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"1 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"108 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"^FD Field Data (Mixed Mode – requires more switches) "+ 
			"Automatic Data Input (A) with Switches "+ 
			"^FD "+ 
			"<D><code No.> <No. of divisions> <parity data>, "+ 
			"<error correction level> A, "+ 
			"<data character string>, "+ 
			"<data character string>, "+ 
			"< : >, "+ 
			"<data character string n*} "+ 
			"^FS "+ 
			"Manual Data Input (M) with Switches "+ 
			"^FD "+ 
			"<code No.> <No. of divisions> <parity data>, "+ 
			"<error correction level> M, "+ 
			"<character mode 1> <data character string 1>, "+ 
			"<character mode 2> <data character string 2>, "+ 
			"< : > < : >, "+ 
			"<character mode n> <data character string n*} "+ 
			"^FS "+ 
			"n** up to 200 in mixed mode "+ 
			"Example: QR Code, mixed mode with manual data input: "+ 
			"<mixed mode identifier> "+ 
			"D (mixed) "+ 
			"<code No.> "+ 
			"M (code number) "+ 
			"<No. of divisions> "+ 
			"D (divisions) "+ 
			"<parity data> "+ 
			"M (0x0C) "+ 
			"‘ "+ 
			"<error correction level> "+ 
			"L (high-density level) "+ 
			"<input mode> "+ 
			"M (manual input) "+ 
			"‘ "+ 
			"<character mode> "+ 
			"N (numeric data) "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO,20,20^BQ,2,10 "+ 
			"^FDD03048F,LM,N0123456789,A12AABB,B0006qrcode^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			" "+ 
			"109 "+ 
			"ZPL Commands "+ 
			"^BQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"<data character string> "+ 
			"0123456789 "+ 
			"‘ "+ 
			"<character mode> "+ 
			"A (alphanumeric data) "+ 
			"<data character string> "+ 
			"12AABB "+ 
			"‘ "+ 
			"<character mode> "+ 
			"B (8-bit byte data) "+ 
			"0006 (number of bytes) "+ 
			"<data character string> "+ 
			"qrcode "+ 
			"Example: This is an example of QR Code, mixed mode with automatic data input: "+ 
			"^XA "+ 
			"^FO20,20^BQ,2,10 "+ 
			"^FDD03040C,LA,012345678912AABBqrcode^FS "+ 
			"^XZ "+ 
			"<mixed mode identifier> "+ 
			"D D (mixed) "+ 
			"<code No.> "+ 
			"M 03 (code number) "+ 
			"<No. of divisions> "+ 
			"D 04 (divisions) "+ 
			"<parity data> "+ 
			"M 0C (0x0C) "+ 
			"<error correction level> "+ 
			"L L (high-density level) "+ 
			"<input mode> "+ 
			"A A (automatic input) "+ 
			"<data character string> "+ 
			"012345678912AABBqrcode "+ 
			"For proper functionality, when encoding Kanji characters in ^CI28-30 (Unicode) be sure "+ 
			"the "+ 
			"JIS.DAT table is loaded on the printer and specified. "+ 
			"Example: This is a Unicode example: "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BR "+ 
			"110 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
