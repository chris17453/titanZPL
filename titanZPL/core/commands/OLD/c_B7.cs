using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B7 : zpl_command {      //PDF417 Bar Code
		public string orientation       = String.Empty;
		public int    bar_code_height   = 0;
		public int    security_level    = 0;
		public int    columns_to_encode = 0;
		public int    rows_to_encode    = 0;
		public string truncate_right    = String.Empty;
        
		public zpl_cmd_c_B7(string data) {
			cmd = "^B7";
			description = "PDF417 Bar Code";
			data_format = "o,h,s,c,r,t";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B"       , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-print_heght" , "", "");
			security_level                       =    (int)argument(2, data, "i", "1-8"           , "", "");   //by
			columns_to_encode                    =    (int)argument(3, data, "i", "1-30"          , "", "");   
			rows_to_encode                       =    (int)argument(4, data, "i", "3-90"          , "", "");   
            truncate_right                       = (string)argument(5, data, "c", "Y,N"           , "", "N");   
            example="^XA^FO50,50^BY3,3.0^B7N,8,5,7,21,N^FH_^FD[)>_1E06_1DP12345678_1DQ160_1D1JUN123456789A2B4C6D8E_1D20LA6-987_1D21L54321 ZES_1D15KG1155_1DBSC151208_1D7Q10GT_1E_04^FS^XZ";
        }//end init function
        /*
         
         ^B7 – PDF417 Bar Code
The ^B7 command produces the PDF417 bar code, a two-dimensional, multirow, continuous,
stacked symbology. PDF417 is capable of encoding over 1,000 characters per bar code. It is ideally
suited for applications requiring large amounts of information at the time the bar code is read.
The bar code consists of three to 90 stacked rows. Each row consists of start and stop patterns and
symbol characters called code-words. A code-word consists of four bars and four spaces. A three
code-word minimum is required per row.
The PDF417 bar code is also capable of using the structured append option (^FM), which allows you
to extend the field data limitations by printing multiple bar codes. For more information on using
structured append, see ^FM on page 169.

•

PDF417 has a fixed print ratio.

•

Field data (^FD) is limited to 3K of character data.

Format:

^B7o,h,s,c,r,t

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
for individual
rows (in dots)

Values: 1 to height of label

s = security level

Values: 1 to 8 (error detection and correction)

Default: value set by ^BY
This number multiplied by the module equals the height of the individual rows in
dots. If this number is not specified, the overall bar code height, divided by the
number of rows, equals the height of the individual rows in dots, where the
overall bar code height is defined by the ^BY command. 1 is not a
recommended value.
Default: 0 (error detection only)
This determines the number of error detection and correction code-words to be
generated for the symbol. The default level provides only error detection without
correction. Increasing the security level adds increasing levels of error correction
and increases the symbol size.

c = number of data
columns to
encode

Values: 1 to 30

r = number of rows to
encode

Values: 3 to 90

P1012728-011

Default: 1:2 (row-to-column aspect ratio)
You can specify the number of code-word columns giving control over the width
of the symbol.
Default: 1:2 (row-to-column aspect ratio)
You can specify the number of symbol rows giving control over the height of the
symbol. For example, with no row or column values entered, 72 code-words
would be encoded into a symbol of six columns and 12 rows. Depending on
code-words, the aspect ratio is not always exact.

Zebra Programming Guide

11/21/16

ZPL Commands
^B7

Parameters

Details

t = truncate right
row indicators
and stop pattern

Values:

N = no truncation
Y = perform truncation

Default: N

Example 1: This is an example of a PDF417 bar code:
ZPL II CODE

PDF417 BAR CODE

^XA
^BY2,3
^FO10,10^B7N,5,5,,83,N
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
in a timely manner.
^FS^XZ

Example 2: This is an example of a PDF417 without and with truncation selected:

11/21/16

Zebra Programming Guide

P1012728-011

59

60

ZPL Commands
^B7

Example 3: This example shows the ^B7 command used with field hex (^FH) characters:
ZPL II CODE

GENERATED LABEL

^XA
^FO50,50^BY3,3.0^B7N,8,5,7,21,N
^FH_^FD[)>_1E06_1DP12345678_1DQ160
_1D1JUN123456789A2B4C6D8E_1D20LA6-987
_1D21L54321 ZES_1D15KG1155
_1DBSC151208_1D7Q10GT_1E_04^FS
^XZ

Comments Noted in this bulleted list:
• If both columns and rows are specified, their product must be less than 928.
• No symbol is printed if the product of columns and rows is greater than 928.
• No symbol is printed if total code-words are greater than the product of columns and rows.
• Serialization is not allowed with this bar code.
• The truncation feature can be used in situations where label damage is not likely. The right row
indicators and stop pattern is reduced to a single module bar width. The difference between a
non truncated and a truncated bar code is shown in the previous examples.

Special Considerations for ^BY When Using PDF417
When used with ^B7, the parameters for the ^BY command are:

w

= module width (in dots)

Values: 2 to 10
Default: 2

r

= ratio

Fixed Value: 3 (ratio has no effect on PDF417)
h = height of bars (in dots)

Values: 1 to 32000
Default: 10

PDF417 uses this only when row height is not specified in the ^B7 h parameter.

Special Considerations for ^FD When Using PDF417
The character set sent to the printer with the ^FD command includes the full ASCII set, except for
those characters with special meaning to the printer.
See Zebra Code Page 850 — Latin Character Set on page 1265, ^CC ~CC on page 126, and ^CT
~CT on page 139.
• CR and LF are also valid characters for all ^FD statements. This scheme is used:

\& = carriage return/line feed
\\ = backslash (\)
• ^CI13 must be selected to print a backslash (\).

P1012728-011

Zebra Programming Guide
         */
	}//end class
	
}//end namespace