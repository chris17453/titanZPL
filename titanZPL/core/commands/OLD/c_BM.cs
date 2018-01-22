using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BM : zpl_command {      //MSI Bar Code
		public string o = String.Empty;
		public string e = String.Empty;
		public string h = String.Empty;
		public string f = String.Empty;
		public string g = String.Empty;
		public string e2 = String.Empty;
		public zpl_cmd_c_BM(string data) {
			cmd = "^BM";
			description = "MSI Bar Code";
			data_format = "o,e,h,f,g,e2";
			o = (string)argument(0, data, "", "", "", "");
			e = (string)argument(1, data, "", "", "", "");
			h = (string)argument(2, data, "", "", "", "");
			f = (string)argument(3, data, "", "", "", "");
			g = (string)argument(4, data, "", "", "", "");
			e2 = (string)argument(5, data, "", "", "", "");
            example="^XA^FO100,100^BY3^BMN,B,100,Y,N,N^FD123456^FS^XZ";
		}//end init function
        /*^BM – MSI Bar Code
The ^BM command is a pulse-width modulated, continuous, non-self- checking symbology. It is a
variant of the Plessey bar code (^BP).
Each character in the MSI bar code is composed of eight elements: four bars and four adjacent
spaces.

•

^BM supports a print ratio of 2.0:1 to 3.0:1.

•

For the bar code to be valid, field data (^FD) is limited to 1 to 14 digits when
parameter e is B, C, or D. ^FD is limited to 1 to 13 digits when parameter e is A, plus a
quiet zone.

Important • If additional information about the MSI bar code is required, go to
www.aimglobal.org.
Format:

^BMo,e,h,f,g,e2

Parameters

Details



no check digits
1 Mod 10
2 Mod 10
1 Mod 11 and 1 Mod 10

Default: B

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

e2 = inserts check
digit into the
interpretation
line

11/21/16

Values:

N = no
Y = yes

Default: N

Zebra Programming Guide

P1012728-011

97

98

ZPL Commands
^BM

Example: This is an example of a MSI bar code:

MSI BAR CODE

ZPL II CODE
^XA
^FO100,100^BY3
^BMN,B,100,Y,N,N
^FD123456^FS
^XZ

*/
	}//end class
	
}//end namespace