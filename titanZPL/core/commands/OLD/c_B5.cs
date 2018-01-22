using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B5 : zpl_command {      //Planet Code bar code
		public string orientation                           = String.Empty;
		public int    bar_code_height                       = 0;
		public string print_interpretation_line             = String.Empty;
		public string print_interpretation_line_above_code  = String.Empty;
        public zpl_cmd_c_B5(string data) {
			cmd = "^B5";
			description = "Planet Code bar code";
			data_format = "o,h,f,g";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-9999"  , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "N");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");
            example="^XA^FO150,100^BY3^B5N,100,Y,N^FD12345678901^FS^XZ";
		}//end init function
        /*
         ^B5 – Planet Code bar code
The ^B5 command is supported in all printers as a resident bar code.

Note • Accepted bar code characters are 0 - 9.
Format:

^B5o,h,f,g

Parameters

Details

o = orientation code

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
rotated
inverted 180 degrees
read from bottom up, 270 degrees

Default: current ^FW value

h = bar code height
(in dots)

Values: 1 to 9999

f = interpretation
line

Values:

Default: value set by ^BY

N = no
Y = yes

Default: N

g = determines if the
interpretation
line is printed
above the bar
code

Values:

N = no
Y = yes

Default: N

Example: This is an example of a Planet Code bar code:

ZPL II CODE

GENERATED LABEL

^XA
^FO150,100^BY3
^B5N,100,Y,N
^FD12345678901^FS
^XZ
57

         */
	}//end class
	
}//end namespace