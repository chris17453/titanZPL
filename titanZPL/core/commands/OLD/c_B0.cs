using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
    public class zpl_cmd_c_B0 : zpl_command {      //Aztec Bar Code Parameters
        public string orientation       = String.Empty;
        public string magnification     = String.Empty;
        public string extended_channel  = String.Empty;
        public string error_control     = String.Empty;
        public string menu_symbol       = String.Empty;
        public string number_of_symbols = String.Empty;
        public string optional_ID       = String.Empty;
        public zpl_cmd_c_B0(string data) {
            cmd = "^B0";
            description = "Aztec Bar Code Parameters";
            data_format = "a,b,c,d,e,f,g";
            orientation       = (string)argument(0, data, "c", "N,R,I,B"                    , "", "N"); //FW
            magnification     = (string)argument(1, data, "i", "1-10"                       , "", "");  //1 on 150 dpi printers 2 on 200 dpi printers 3 on 300 dpi printers 6 on 600 dpi printers 
            extended_channel  = (string)argument(2, data, "c", "Y/N"                        , "", "N");
            error_control     = (string)argument(3, data, "i", "0,01-99,101-104,201-232,300", "", "0");
            menu_symbol       = (string)argument(4, data, "c", "Y/N"                        , "", "");
            number_of_symbols = (string)argument(5, data, "i", "1-26"                       , "", "");
            optional_ID       = (string)argument(6, data, "s", ""                           , "", "");  //max len 24
            example="^XA^B0R,7,N,0,N,1,0^FD 7. This is testing label 7^FS^XZ";
        }//end init function
        /*
         
^B0 – Aztec Bar Code Parameters
The ^B0 command creates a two-dimensional matrix symbology made up of square modules
arranged around a bulls-eye pattern at the center.

Note • The Aztec bar code works with firmware version V60.13.0.11A and V50.13.2 or later.
Format:

^B0a,b,c,d,e,f,g

Parameters

Details

a = orientation

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

b = magnification
factor

Values: 1 to 10

c = extended channel
interpretation
code indicator

Values:

Default:
1 on 150 dpi printers
2 on 200 dpi printers
3 on 300 dpi printers
6 on 600 dpi printers

Y = if data contains ECICs
N = if data does not contain ECICs
Default: N

d = error control and
symbol size/type
indicator

Values:

0 = default error correction level
01 to 99 = error correction percentage (minimum)
101 to 104 = 1 to 4-layer compact symbol
201 to 232 = 1 to 32-layer full-range symbol
300 = a simple Aztec “Rune”
Default: 0

e = menu symbol
indicator

Values:

Y = if this symbol is to be a menu (bar code reader initialization) symbol
N = if it is not a menu symbol
Default: N

f = number of symbols
for structured
append

Values: 1 through 26

g = optional ID field
for structured
append

The ID field is a text string with 24-character maximum

11/21/16

Default: 1

Default: no ID

Zebra Programming Guide

P1012728-011

43

44

ZPL Commands
^B0

Example: This is an example of the ^B0 command:

ZPL II CODE

GENERATED LABEL

^XA
^B0R,7,N,0,N,1,0
^FD 7. This is testing label 7^FS
^XZ

         */
    }//end class
}
