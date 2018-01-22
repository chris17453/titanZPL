using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BE : zpl_command {      //EAN-13 Bar Code
		public string orientation                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
        public zpl_cmd_c_BE(string data) {
			cmd = "^BE";
			description = "EAN-13 Bar Code";
			data_format = "o,h,f,g";
		    orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");

            example="^XA^FO100,100^BY3^BEN,100,Y,N^FD12345678^FS^XZ";
		}//end init function
        /*
         ^BE – EAN-13 Bar Code
The ^BE command is similar to the UPC-A bar code. It is widely used throughout Europe and Japan
in the retail marketplace.
The EAN-13 bar code has 12 data characters, one more data character than the UPC-A code. An
EAN-13 symbol contains the same number of bars as the UPC-A, but encodes a 13th digit into a
parity pattern of the left-hand six digits. This 13th digit, in combination with the 12th digit, represents
a country code.
• ^BE supports fixed print ratios.
• Field data (^FD) is limited to exactly 12 characters. ZPL II automatically truncates or pads on
the left with zeros to achieve the required number of characters.
• When using JAN-13 (Japanese Article Numbering), a specialized application of EAN-13, the
first two non-zero digits sent to the printer must be 49.

Note • Use Interleaved 2 of 5 for UCC and EAN 14.

Important • If additional information about the EAN-13 bar code is required, go to
www.aimglobal.org.
Format:

^BEo,h,f,g

Parameters

Details

o = orientation

Values:

N
R
I
B

=
=
=
=

normal
rotated 90 degrees (clockwise)
inverted 180 degrees
read from bottom up, 270 degrees

Default: current ^FW value

h = bar code height
(in dots)

Values: 1 to 32000

f = print
interpretation
line

Values:

Default: value set by ^BY

N = no
Y = yes

Default: Y

g = print
interpretation
line above code

Values:

N = no
Y = yes

Default: N

P1012728-011

Zebra Programming Guide

11/21/16

ZPL Commands
^BE

Example: This is an example of an EAN-13 bar code:

EAN-13 BAR CODE

ZPL II CODE
^XA
^FO100,100^BY3
^BEN,100,Y,N
^FD12345678^FS
^XZ

EAN-13 BAR CODE CHARACTERS

        Comments The EAN-13 bar code uses the Mod 10 check-digit scheme for error checking.
For more information on Mod 10, see Mod 10 Check Digit on page 1299.

         
         */
	}//end class
	
}//end namespace