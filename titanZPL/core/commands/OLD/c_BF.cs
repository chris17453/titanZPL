using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BF : zpl_command {      //MicroPDF417 Bar Code
		public string orentation     = String.Empty;
		public int    barcode_height = 0;
		public int    mode           = 0;
		public zpl_cmd_c_BF(string data) {
			cmd = "^BF";
			description = "MicroPDF417 Bar Code";
			data_format = "o,h,m";
			orentation      = (string)argument(0, data, "c", "N,R,I,B"  , "", "N");
			barcode_height  =    (int)argument(1, data, "i", "1-32000"  , "", "");
			mode            =    (int)argument(2, data, "i", "0-33"     , "", "0");
            example="^XA^FO100,100^BY6^BFN,8,3^FDABCDEFGHIJKLMNOPQRSTUV^FS^XZ";
		}//end init function
	}//end class
	/*
     
^BF – MicroPDF417 Bar Code
The ^BF command creates a two-dimensional, multi-row, continuous, stacked symbology identical
to PDF417, except it replaces the 17-module-wide start and stop patterns and left/right row
indicators with a unique set of 10-module-wide row address patterns. These reduce overall symbol
width and allow linear scanning at row heights as low as 2X.
MicroPDF417 is designed for applications with a need for improved area efficiency but without the
requirement for PDF417’s maximum data capacity. It can be printed only in specific combinations of
rows and columns up to a maximum of four data columns by 44 rows.
Field data (^FD) and field hexadecimal (^FH) are limited to:
• 250 7-bit characters
• 150 8-bit characters
• 366 4-bit numeric characters
Format:

^BFo,h,m

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

Values: 1 to 9999

m = mode

Values: 0 to 33 (see Table 10, MicroPDF417 Mode on page 89)

Default: value set by ^BY or 10 (if no ^BY value exists).
Default: 0 (see Table 10)

Example: This is an example of a MicroPDF417 bar code:

ZPL II CODE

MICRO-PDF417 BAR CODE

^XA
^FO100,100^BY6
^BFN,8,3
^FDABCDEFGHIJKLMNOPQRSTUV^FS
^XZ

To encode data into a MicroPDF417 bar code, complete these steps:
1. Determine the type of data to be encoded (for example, ASCII characters, numbers, 8-bit

data, or a combination).
2. Determine the maximum amount of data to be encoded within the bar code (for

example, number of ASCII characters, quantity of numbers, or quantity of 8-bit data
characters).

P1012728-011

Zebra Programming Guide

11/21/16

ZPL Commands
^BF

3. Determine the percentage of check digits that are used within the bar code. The higher

the percentage of check digits that are used, the more resistant the bar code is to
damage — however, the size of the bar code increases.
4. Use Table 10 with the information gathered from the questions above to select the mode

of the bar code.

Table 10 • MicroPDF417 Mode
Mode
(M)

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
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33

11/21/16

Number Number
of Data of Data
Columns Rows

1
1
1
1
1
1
2
2
2
2
2
2
2
3
3
3
3
3
3
3
3
3
3
4
4
4
4
4
4
4
4
4
4
4

11
14
17
20
24
28
8
11
14
17
20
23
26
6
8
10
12
15
20
26
32
38
44
6
8
10
12
15
20
26
32
38
44
4

Zebra Programming Guide

% of
Max
Cws for
Alpha
EC
Characters

64
50
41
40
33
29
50
41
32
29
28
28
29
67
58
53
50
47
43
41
40
39
38
50
44
40
38
35
33
31
30
29
28
50

6
12
18
22
30
38
14
24
36
46
56
64
72
10
18
26
34
46
66
90
114
138
162
22
34
46
58
76
106
142
178
214
250
14

Max
Digits

8
17
26
32
44
55
20
35
52
67
82
93
105
14
26
38
49
67
96
132
167
202
237
32
49
67
85
111
155
208
261
313
366
20

P1012728-011

89
     */
}//end namespace