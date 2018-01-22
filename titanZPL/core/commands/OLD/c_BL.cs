using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BL : zpl_command {      //LOGMARS Bar Code
		public string orientation                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line_above_code = String.Empty;
		public zpl_cmd_c_BL(string data) {
			cmd = "^BL";
			description = "LOGMARS Bar Code";
			data_format = "o,h,g";
            orientation                          = (string)argument(0, data, "c", "N,R,I,B"     , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000"     , "", "");
			print_interpretation_line_above_code = (string)argument(2, data, "c", "Y,N"         , "", "N");
			
            example ="^XA^FO100,75^BY3^BLN,100,N^FD12AB^FS^XZ";
		}//end init function
        /*
         
^BL – LOGMARS Bar Code
The ^BL command is a special application of Code 39 used by the Department of Defense.
LOGMARS is an acronym for Logistics Applications of Automated Marking and Reading Symbols.

•

^BL supports a print ratio of 2.0:1 to 3.0:1.

•

Field data (^FD) is limited to the width (or length, if rotated) of the label. Lowercase
letters in the ^FD string are converted to the supported uppercase LOGMARS
characters.

Important • If additional information about the LOGMARS bar code is required, go to
www.aimglobal.org.
Format:

^BLo,h,g

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

g = print
interpretation
line above code

Values:

Default: value set by ^BY

N = no
Y = yes

Default: N

Example: This is an example of a LOGMARS bar code:

ZPL II CODE

LOGMARS BAR CODE

^XA
^FO100,75^BY3
^BLN,100,N
^FD12AB^FS
^XZ

LOGMARS BAR CODE CHARACTERS
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
A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
.
$
/
+
%
SPACE

11/21/16

Zebra Programming Guide

P1012728-011

95

96

ZPL Commands
^BL

Comments The LOGMARS bar code produces a mandatory check digit using
Mod 43 calculations. For further information on the Mod 43 check digit, see
Mod 10 Check Digit on page 1299.

         */
	}//end class
	
}//end namespace