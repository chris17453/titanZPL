using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
    public class zpl_cmd_c_A2 : zpl_command {      //Use Font Name to Call Font
        
        public string orientation       = String.Empty;
        public int    character_height  = 0;
        public int    character_width   = 0;
        public string drive_location    = String.Empty;
        public string font_name         = String.Empty;
        public string extension         = String.Empty;

        public zpl_cmd_c_A2(string data) {
            cmd = "^A@";
            description = "Use Font Name to Call Font";
            data_format = "o,h,w,d,f,x";
            orientation       = (string)argument(0, data, "c", "*N,R,I,B"      , "", "N");            //default N or ^FW value
            character_height  = (int)   argument(1, data, "i", ""              , "", "");             //CF
            character_width   = (int)   argument(2, data, "i", ""              , "", "");             //CF
            drive_location    = (string)argument(3, data, "s", "R:,E:,B:,A"    , "", "R:");
            font_name         = (string)argument(4, data, "s", ""              , "", "");
            extension         = (string)argument(5, data, "s", ".FNT,.TTF,.TTE", "", "");
            example="^XA^A2N,50,50,B:CYRI_UB.FNT^FO100,100^FDZebra Printer Fonts^FS^A2N,40,40^F0100,150^FDThis uses B:CYRI_UB.FNT^FS^XZ";
        }//end init function
        /*
         ^A. Once a value for ^A@ is defined, it represents that font until a new font name is specified by ^A@.
Format: ^A@o,h,w,d:f.x

Parameter

Details

o = field orientation

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
rotates 90 degrees (clockwise)
inverted 180 degrees
read from bottom up, 270 degrees

Default: N or the last ^FW value

h = character height
(in dots)

Default:
Specifies magnification by w (character width) or the last accepted ^CF value. Uses
the base height if none is specified.
• Scalable
The value is the height in dots of the entire character block. Magnification factors
are unnecessary, because characters are scaled.
• Bitmapped
The value is rounded to the nearest integer multiple of the font’s base height,
then divided by the font’s base height to give a magnification nearest limit.

w = width (in dots)

Default: Specifies magnification by h (height) or the last accepted ^CF value.
Specifies the base width is used if none is specified.
• Scalable
The value is the width in dots of the entire character block. Magnification factors
are unnecessary, because characters are scaled.
• Bitmapped
The value rounds to the nearest integer multiple of the font’s base width, then
divided by the font’s base width to give a magnification nearest limit.

d = drive location of
font

Values: R:, E:, B:, and A:

f = font name

Values: any valid font
Default: if an invalid or no name is entered, the default set by ^CF is used If no font
has been specified in ^CF, font A is used.

Default: R:

The font named carries over on all subsequent ^A@ commands
without a font name.
x = extension

Values:

.FNT = font
.TTF = TrueType Font
.TTE = TrueType Extension

.TTE is only supported in
firmware version V60.14.x,
V50.14.x, or later.

11/21/16

Zebra Programming Guide

P1012728-011

41

42

ZPL Commands
^A@

Example: This example identifies the purpose of each line of code for this label:

ZPL II Code
1
2
3
4
5
6
7
8

1
2
3
4
5
6
7
8

Generated Label

^XA
^A2N,50,50,B:CYRI_UB.FNT
^FO100,100
^FDZebra Printer Fonts^FS
^A2N,40,40
^F0100,150
^FDThis uses B:CYRI_UB.FNT^FS
^XZ

Starts the label format.
Searches non-volatile printer memory (B:) for CYRI_UB.FNT. When the
font is found, the ^A@ command sets the print orientation to normal and the
character size to 50 dots by 50 dots.
Sets the field origin at 100,100.
Prints the field data, Zebra Printer Fonts on the label.
Calls the font again and character size is decreased to 40 dots by 40 dots.
Sets the new field origin at 100,150.
Prints the field data, This uses the B:CYRI_UB.FNT on the label.
Ends the label format.

For reference, see Zebra Code Page 850 — Latin Character Set on page 1265, Fonts and Bar
Codes on page 1283, and ASCII on page 1279.

         */
    }//end class
}
