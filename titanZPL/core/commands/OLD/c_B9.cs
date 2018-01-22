using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B9 : zpl_command {      //UPC-E Bar Code
	    public string orientation                          = String.Empty;
		public string check_digit                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
        public zpl_cmd_c_B9(string data) {
			cmd = "^B9";
			description = "UPC-E Bar Code";
			data_format = "o,h,f,g,e";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");
		    check_digit                          = (string)argument(4, data, "c", "Y,N"     , "", "Y");
            example="^XA^FO150,100^BY3^B9N,100,Y,N,Y^FD1230000045^FS^XZ";

		}//end init function
        /*
         
^B9 – UPC-E Bar Code
The ^B9 command produces a variation of the UPC symbology used for number system 0. It is a
shortened version of the UPC-A bar code, where zeros are suppressed, resulting in codes that
require less printing space. The 6 dot/mm, 12 dot/mm, and 24 dot/mm printheads produce the UPC
and EAN symbologies at 100 percent of their size. However, an 8 dot/mm printhead produces the
UPC and EAN symbologies at a magnification factor of 77 percent.
Each character in a UPC-E bar code is composed of four elements: two bars and two spaces. The

^BY command must be used to specify the width of the narrow bar.
• ^B9 supports a fixed ratio.
• Field data (^FD) is limited to exactly 10 characters, requiring a five-digit manufacturer’s code
and five-digit product code.
• When using the zero-suppressed versions of UPC, you must enter the full
10-character sequence. ZPL II calculates and prints the shortened version.

Important • If additional information about the UPC-E bar code is required, go to
www.aimglobal.org.
Format: ^B9,h,f,g,e

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

e = print check digit

Values:

N = no
Y = yes

Default: Y

11/21/16

Zebra Programming Guide

P1012728-011

63

64

ZPL Commands
^B9

Example: This is an example of a UPC-E bar code:

UPC-E BAR CODE

ZPL II CODE
^XA
^FO150,100^BY3
^B9N,100,Y,N,Y
^FD1230000045^FS
^XZ

Rules for Proper Product Code Numbers
• If the last three digits in the manufacturer’s number are 000, 100, or 200, valid product code
numbers are 00000 to 00999.
• If the last three digits in the manufacturer’s number are 300, 400, 500, 600, 700, 800, or 900,
valid product code numbers are 00000 to 00099.
• If the last two digits in the manufacturer’s number are 10, 20, 30, 40, 50, 60, 70, 80, or 90, valid
product code numbers are 00000 to 00009.
• If the manufacturer’s number does not end in zero (0), valid product code numbers are 00005 to
00009.

         
         */
	}//end class
	
}//end namespace