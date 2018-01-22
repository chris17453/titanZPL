using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
    public class zpl_cmd_c_BI : zpl_command {      //Industrial 2 of 5 Bar Codes
        public string orientation                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		    public zpl_cmd_c_BI(string data) {
            cmd = "^BI";
            description = "Industrial 2 of 5 Bar Codes";
            data_format = "o,h,f,g";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");

            example ="^XA^FO100,100^BY3^BIN,150,Y,N^FD123456^FS^XZ";
        }//end init function
    }//end class
    /*^BI – Industrial 2 of 5 Bar Codes
The ^BI command is a discrete, self-checking, continuous numeric symbology. The Industrial 2 of 5
bar code has been in use the longest of the 2 of 5 family of bar codes. Of that family, the Standard 2
of 5 (^BJ) and Interleaved 2 of 5 (^B2) bar codes are also available in ZPL II.
With Industrial 2 of 5, all of the information is contained in the bars. Two bar widths are employed in
this code, the wide bar measuring three times the width of the narrow bar.

•

^BI supports a print ratio of 2.0:1 to 3.0:1.

•

Field data (^FD) is limited to the width (or length, if rotated) of the label.

Important • If additional information about the Industrial 2 of 5 bar code, go to
www.aimglobal.org.
Format:

^BIo,h,f,g

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
^BI

Example: This is an example of an Industrial 2 of 5 bar code:

INDUSTRIAL 2 OF 5 BAR CODE

ZPL II CODE
^XA
^FO100,100^BY3
^BIN,150,Y,N
^FD123456^FS
^XZ

INDUSTRIAL 2 OF 5 BAR CODE CHARACTERS
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

11/21/16

Zebra Programming Guide

P1012728-011

91

92
*/
	
}//end namespace