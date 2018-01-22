using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B8 : zpl_command {      //EAN-8 Bar Code
		public string orientation                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		public zpl_cmd_c_B8(string data) {
			cmd = "^B8";
			description = "EAN-8 Bar Code";
			data_format = "o,h,f,g";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");
            example="^XA^FO100,100^BY3^B8N,100,Y,N^FD1234567^FS^XZ";
        }//end init function
        /*
         
^B8 – EAN-8 Bar Code
The ^B8 command is the shortened version of the EAN-13 bar code. EAN is an acronym for
European Article Numbering. Each character in the EAN-8 bar code is composed of four elements:
two bars and two spaces.
• ^B8 supports a fixed ratio.
• Field data (^FD) is limited to exactly seven characters. ZPL II automatically pads or truncates on
the left with zeros to achieve the required number of characters.
• When using JAN-8 (Japanese Article Numbering), a specialized application of EAN-8, the first
two non-zero digits sent to the printer are always 49.

Important • If additional information about the EAN-8 bar code is required, go to
www.aimglobal.org.
Format: ^B8o,h,f,g

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

11/21/16

Zebra Programming Guide

P1012728-011

61

62

ZPL Commands
^B8

Example: This is an example of an EAN-8 bar code:

ZPL II CODE

EAN-8 BAR CODE

^XA
^FO100,100^BY3
^B8N,100,Y,N
^FD1234567^FS
^XZ

         */
	}//end class
	
}//end namespace