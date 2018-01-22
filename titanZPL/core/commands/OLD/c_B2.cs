using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B2 : zpl_command {      //Interleaved 2 of 5 Bar Code
		public string orientation                          = String.Empty;
		public int bar_code_height                         = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		public string check_digit                          = String.Empty;
		public string j                                    = String.Empty;              //missing from reference.. figure it out
		public zpl_cmd_c_B2(string data) {
			cmd = "^B2";
			description = "Interleaved 2 of 5 Bar Code";
			data_format = "o,h,f,g,e,j";
            orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");
		    check_digit                          = (string)argument(4, data, "c", "Y,N"     , "", "N");
			j                                    = (string)argument(5, data, "s", ""        , "", "");
            example="^XA^FO100,100^BY3^B2N,150,Y,N,N^FD123456^FS^XZ";

		}//end init function
        /*
         ^B2 – Interleaved 2 of 5 Bar Code
The ^B2 command produces the Interleaved 2 of 5 bar code, a high-density, self-checking,
continuous, numeric symbology.
Each data character for the Interleaved 2 of 5 bar code is composed of five elements: five bars or
five spaces. Of the five elements, two are wide and three are narrow. The bar code is formed by
interleaving characters formed with all spaces into characters formed with all bars.
• ^B2 supports print ratios of 2.0:1 to 3.0:1.
• Field data (^FD) is limited to the width (or length, if rotated) of the label.

Important • If additional information about the Interleaved 2 of 5 bar code is required, go to
www.aimglobal.org.
Format:

^B2o,h,f,g,e,j

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

Y = yes
N = no

Default: Y

g = print
interpretation
line above code

Values:

Y = yes
N = no

Default: N

e = calculate and
print Mod 10
check digit

Values:

Y = yes
N = no

Default: N

11/21/16

Zebra Programming Guide

P1012728-011

47

48

ZPL Commands
^B2

Example: This is an example of an Interleaved 2 of 5 bar code:

ZPL II CODE

INTERLEAVED 2 OF 5 BAR CODE

^XA
^FO100,100^BY3
^B2N,150,Y,N,N
^FD123456^FS
^XZ

INTERLEAVED 2 OF 5 BAR CODE CHARACTERS
0

1

2

3

4

5

6

7

8

9

Start/Stop (internal)

Comments The total number of digits in an Interleaved 2 of 5 bar code must be even. The
printer automatically adds a leading 0 (zero) if an odd number of digits is received.
The Interleaved 2 of 5 bar code uses the Mod 10 check-digit scheme for error checking. For more
information on Mod 10 check digits, see Mod 10 Check Digit on page 1299.

         */
	}//end class
	
}//end namespace