using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BB : zpl_command {      //CODABLOCK Bar Code
		public string orientation          = String.Empty;
		public int    bar_code_height      = 0;
		public int    security_level       = 0;
		public int    characters_per_row   = 0;
		public int    rows_to_encode       = 0;
		public string mode                 = String.Empty;
		public zpl_cmd_c_BB(string data) {
			cmd = "^BB";
			description = "CODABLOCK Bar Code";
			data_format = "o,h,s,c,r,m";
		
          	orientation                          = (string)argument(0, data, "c" ,"N,R,I,B"  , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i" ,"2-32000"  , "", "8");
            security_level                       =    (int)argument(2, data, "c" ,"Y,N"      , "", "");
            characters_per_row                   =    (int)argument(3, data, "i" ,"2-62"     , "", "");
            rows_to_encode                       =    (int)argument(4, data, "i" ,"1-22"     , "", "");  //1-22 if A 2-4 if E
            mode                                 = (string)argument(5, data, "c" ,"A,E,F"    , "", "F"); 
            example=@"  ^XA^BY2,3
                        ^FO10,10^BBN,30,,30,44,E
                        ^FDZebra Technologies
                        Corporation strives to be
                        the expert supplier of
                        innovative solutions to
                        speciality demand labeling
                        and ticketing problems of
                        business and government.
                        We will attract and retain
                        the best people who will
                        understand our customer's
                        needs and provide them with
                        systems, hardware, software,
                        consumables and service
                        offering the best value,
                        high quality, and reliable
                        performance, all delivered
                        in a timely manner.^FS^XZ";
		
		}//end init function
        /*
         ^BB – CODABLOCK Bar Code
The ^BB command produces a two-dimensional, multirow, stacked symbology. It is ideally suited for
applications that require large amounts of information.
Depending on the mode selected, the code consists of one to 44 stacked rows. Each row begins and
ends with a start and stop pattern.

CODABLOCK A supports variable print ratios.
CODABLOCK E and F support only fixed print ratios.

Important • If additional information about the CODABLOCK bar code is required, go to
www.aimglobal.org.
Format:

^BBo,h,s,c,r,m

Parameters

Details

o = orientation

Values:

N
1R
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

Default: N

h = bar code height
for individual
rows (in dots)

Values: 2 to 32000

s = security level

Values:

Default: 8
This number, multiplied by the module, equals the height of the individual row in
dots.

N = no
Y = yes

Default: Y
Security level determines whether symbol check-sums are generated and added
to the symbol. Check sums are never generated for single-row symbols. This
can be turned off only if parameter m is set to A.

c = number of
characters per
row (data
columns)

11/21/16

Values: 2 to 62 characters
This is used to encode a CODABLOCK symbol. It gives the you control over the
width of the symbol.

Zebra Programming Guide

P1012728-011

69

70

ZPL Commands
^BB

Parameters

Details

r = number of rows to
encode

Values:
for CODABLOCK A: 1 to 22
for CODABLOCK E and F: 2 to 4

•

If values for c and r are not specified, a single row is produced.

•

If a value for r is not specified, and c exceeds the maximum range, a
single row equal to the field data length is produced.

•

If a value for c is not specified, the number of characters per row is
derived by dividing the field data by the value of r.

•

If the s parameter is set to the default of Y, then the checksum
characters that are included count as two data characters .
For example, if c = 6, r is set to 3 and s is set to N, then up to 18
characters can be used (6 x 3). However, if s is set to Y, then only 16
character can be used.

•

m = mode

If the data field contains primarily numeric data, fewer than the
specified rows might be printed. If the field data contains several shift
and code-switch characters, more than the specified number of rows
might be printed.

Values: A, E, F
CODABLOCK A uses the Code 39 character set.
CODABLOCK F uses the Code 128 character set.
CODABLOCK E uses the Code 128 character set and automatically adds FNC1.
Default: F

P1012728-011

Zebra Programming Guide

11/21/16

ZPL Commands
^BB

Example: This is an example of a CODABLOCK bar code:

ZPL II CODE
^XA
^BY2,3
^FO10,10^BBN,30,,30,44,E
^FDZebra Technologies
Corporation strives to be
the expert supplier of
innovative solutions to
speciality demand labeling
and ticketing problems of
business and government.
We will attract and retain
the best people who will
understand our customer's
needs and provide them with
systems, hardware, software,
consumables and service
offering the best value,
high quality, and reliable
performance, all delivered
in a timely manner.^FS
^XZ

CODABLOCK BAR CODE

Special Considerations for the ^BY Command When Using ^BB
The parameters for the ^BYw,r,h command, when used with a ^BB code, are as follows:

w = module width (in dots)
Values: 2 to 10 (CODABLOCK A only)
Default: 2

r = ratio

Fixed Value: 3 (ratio has no effect on CODABLOCK E or F)
h = height of bars (in dots)
Values: 1 to 32,32000
Default: 10

CODABLOCK uses this as the overall symbol height only when the row height is not
specified in the ^BB h parameter.

Special Considerations for ^FD Character Set When Using ^BB
The character set sent to the printer depends on the mode selected in parameter m.

CODABLOCK A: CODABLOCK A uses the same character set as Code 39. If any other
character is used in the ^FD statement, either no bar code is printed or an error message
is printed (if ^CV is active).
CODABLOCK E: The Automatic Mode includes the full ASCII set except for those
characters with special meaning to the printer. Function codes or the
Code 128 Subset A <nul> character can be inserted using of the ^FH command.

<fnc1> = 80 hex
<fnc3> = 82 hex
<fnc2> = 81 hex
<fnc4> = 83 hex
<nul> = 84 hex

For any other character above 84 hex, either no bar code is printed or an error message is
printed (if ^CV is active).
CODABLOCK F: CODABLOCK F uses the full ASCII set, except for those characters with
special meaning to the printer. Function codes or the Code 128 Subset A <nul> character
can be inserted using of the ^FH command.
<fnc1> = 80 hex
<fnc3> = 82 hex
<fnc2> = 81 hex
<fnc4> = 83 hex
<nul> = 84 hex

         */
	}//end class
	
}//end namespace