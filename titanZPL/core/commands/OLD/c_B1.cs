using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B1 : zpl_command {      //Code 11 Bar Code
		public string orientation                          = String.Empty;
		public string check_digit                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		public zpl_cmd_c_B1(string data) {
			cmd = "^B1";
			description = "Code 11 Bar Code";
			data_format = "o,e,h,f,g";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			check_digit                          = (string)argument(1, data, "c", "Y,N"     , "", "N");
			bar_code_height                      =    (int)argument(2, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(3, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(4, data, "c", "Y,N"     , "", "N");
            example="^XA^FO100,100^BY3^B1N,N,150,Y,N^FD123456^FS^XZ";
		}//end init function
        /*
         ^B1 – Code 11 Bar Code
The ^B1 command produces the Code 11 bar code, also known as USD-8 code. In a Code 11 bar
code, each character is composed of three bars and two spaces, and the character set includes 10
digits and the hyphen (-).
• ^B1 supports print ratios of 2.0:1 to 3.0:1.
• Field data (^FD) is limited to the width (or length, if rotated) of the label.

Important • If additional information about the Code 11 bar code is required, go to
www.aimglobal.org.
Format: ^B1o,e,h,f,g

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

e = check digit

Values:

Y = 1 digit
N = 2 digits
Default: N

h = bar code height
(in dots)

Values: 1 to 32000

f = print
interpretation
line

Values:

Default: Value set by ^BY

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

11/21/16

Zebra Programming Guide

P1012728-011

45

46

ZPL Commands
^B1

Example: This is an example of the Code 11 bar code:

ZPL II CODE

CODE 11 BAR CODE

^XA
^FO100,100^BY3
^B1N,N,150,Y,N
^FD123456^FS
^XZ

CODE 11 BAR CODE CHARACTERS
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

-

Internal Start/Stop Character:
When used as a stop character:
is used with 1 check digit
is used with 2 check digits
         
         */
	}//end class
	
}//end namespace