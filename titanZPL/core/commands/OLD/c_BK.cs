using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BK : zpl_command {      //ANSI Codabar Bar Code
		public string orientation                          = String.Empty;
		public string check_digit                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		public string start_character                      = String.Empty;
		public string stop_character                       = String.Empty;
		public zpl_cmd_c_BK(string data) {
			cmd = "^BK";
			description = "ANSI Codabar Bar Code";
			data_format = "o,e,h,f,g,k,l";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B"     , "", "N");  //fw
			check_digit                          = (string)argument(1, data, "c", "Y,N"         , "", "N");
			bar_code_height                      =    (int)argument(2, data, "i", "1-32000"     , "", "");
			print_interpretation_line            = (string)argument(3, data, "c", "Y,N"         , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(4, data, "c", "Y,N"         , "", "N");
			start_character                      = (string)argument(5, data, "c", "A,B,C,D"     , "", "A");  //BY
			stop_character                       = (string)argument(6, data, "c", "A,B,C,D"     , "", "A");
            example="^XA^FO100,100^BY3^BKN,N,150,Y,N,A,A^FD123456^FS^XZ";
		}//end init function
        /*^BK – ANSI Codabar Bar Code
The ANSI Codabar bar code is used in a variety of information processing applications such as
libraries, the medical industry, and overnight package delivery companies. This bar code is also
known as USD-4 code, NW-7, and 2 of 7 code. It was originally developed for retail price labeling.
Each character in this code is composed of seven elements: four bars and three spaces. Codabar
bar codes use two character sets, numeric and control (start and stop) characters.

•

^BK supports a print ratio of 2.0:1 to 3.0:1.

•

Field data (^FD) is limited to the width (or length, if rotated) of the label.

Important • If additional information about the ANSI Codabar bar code is required, go to
www.aimglobal.org.
Format:

^BKo,e,h,f,g,k,l

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

Fixed Value:

N

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

k = designates a
start character

Values: A,B, C, D

l = designates stop
character

Values: A,B, C, D

11/21/16

Default: A
Default: A

Zebra Programming Guide

P1012728-011

93

94

ZPL Commands
^BK

Example: This is an example of an ANSI Codabar bar code:

ZPL II CODE

ANSI CODABAR BAR CODE

^XA
^FO100,100^BY3
^BKN,N,150,Y,N,A,A
^FD123456^FS
^XZ

ANSI CODABAR BAR CODE CHARACTERS
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

Control Characters

-

:

.

$

/

+

Start/Stop Characters

A

P1012728-011

B

C

Zebra Programming Guide

D*/
	}//end class
}//end namespace