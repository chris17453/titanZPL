using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BJ : zpl_command {      //Standard 2 of 5 Bar Code
        public string orientation                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		public zpl_cmd_c_BJ(string data) {
			cmd = "^BJ";
			description = "Standard 2 of 5 Bar Code";
			data_format = "o,h,f,g";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");
            example="^XA^FO100,100^BY3^BJN,150,Y,N^FD123456^FS^XZ";
		}//end init function
	}//end class
	/*
^BJ – Standard 2 of 5 Bar Code
The ^BJ command is a discrete, self-checking, continuous numeric symbology.
With Standard 2 of 5, all of the information is contained in the bars. Two bar widths are employed in
this code, the wide bar measuring three times the width of the narrow bar.

•

^BJ supports a print ratio of 2.0:1 to 3.0:1.

•

Field data (^FD) is limited to the width (or length, if rotated) of the label.

Important • If additional information about the Standard 2 of 5 bar code is required, go to
www.aimglobal.org.
Format:

^BJo,h,f,g

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

Example: This is an example of a Standard 2 of 5 bar code:

ZPL II CODE

STANDARD 2 OF 5 BAR CODE

^XA
^FO100,100^BY3
^BJN,150,Y,N
^FD123456^FS
^XZ

STANDARD 2 OF 5 BAR CODE CHARACTERS
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

Start/Stop (automatic)

P1012728-011

Zebra Programming Guide

11/21/16

*/
}//end namespace