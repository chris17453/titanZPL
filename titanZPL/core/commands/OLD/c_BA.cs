using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_BA : zpl_command {      //Code 93 Bar Code
public string orientation                          = String.Empty;
		public string check_digit                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
        public zpl_cmd_c_BA(string data) {
			cmd = "^BA";
			description = "Code 93 Bar Code";
			data_format = "o,h,f,g,e";
          	orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			bar_code_height                      =    (int)argument(1, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(2, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(3, data, "c", "Y,N"     , "", "N");
		    check_digit                          = (string)argument(4, data, "c", "Y,N"     , "", "Y");
            example="^XA^FO100,75^BY3^BAN,100,Y,N,N^FD12345ABCDE^FS^XZ";
		}//end init function
	}//end class
    /*
     ^BA – Code 93 Bar Code
The ^BA command creates a variable length, continuous symbology. The Code 93 bar code is used
in many of the same applications as Code 39. It uses the full 128-character ASCII set. ZPL II,
however, does not support ASCII control codes or escape sequences. It uses the substitute
characters shown below.

Control Code

ZPL II Substitute

Ctrl $

&

Ctrl %

‘

Ctrl /

(

Ctrl +

)

Each character in the Code 93 bar code is composed of six elements: three bars and three spaces.
Although invoked differently, the human-readable interpretation line prints as though the control
code has been used.
• ^BA supports a fixed print ratio.
• Field data (^FD) is limited to the width (or length, if rotated) of the label.

Important • If additional information about the Code 93 bar code is required, go to
www.aimglobal.org.
Format:

^BAo,h,f,g,e

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

e = print check digit

Values:

N = no
Y = yes

Default: N

11/21/16

Zebra Programming Guide

P1012728-011

65

66

ZPL Commands
^BA

Example: This is an example of a Code 93 bar code:

ZPL II CODE

CODE 93 BAR CODE

^XA
^FO100,75^BY3
^BAN,100,Y,N,N
^FD12345ABCDE^FS
^XZ

CODE 93 BAR CODE CHARACTERS
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
&
’ (
)
SPACE
Denotes an internal start/stop character that must precede and follow
every bar code message.

Comments All control codes are used in pairs. Code 93 is also capable of encoding the full
128-character ASCII set.

Full ASCII Mode for Code 93
Code 93 can generate the full 128-character ASCII set using paired characters as shown in the
following tables.

P1012728-011

Zebra Programming Guide

11/21/16

ZPL Commands
^BA

Table 5 •

ASCII
NUL
SOH
STX
ETX
EOT
ENQ
ACK
BEL
BS
HT
LF
VT
FF
CR
SO
SI
DLE
DC1
DC2
DC3
DC4
NAK
SYN
ETB
CAN
EM
SUB
ESC
FS
FS
RS
US

11/21/16

Code 93

ASCII

‘U
&A
&B
&C
&D
&E
&F
&G
&H
&I
&J
&K
&L
&M
&N
&O
&P
&Q
&R
&S
&T
&U
&V
&W
&X
&Y
&Z
‘A
‘B
‘C
‘D
‘E

Zebra Programming Guide

SP
!
“
#
$
%
&
‘
(
)
*
++
,
.
/
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
:
;
<
=
>
?

Code 93
Space
(A
(B
(C
(D
(E
(F
(G
(H
(I
(J
++
(L
.
/
O
1
2
3
4
5
6
7
8
9
(Z
‘F
‘G
‘H
‘I
‘J

P1012728-011

67

68

ZPL Commands
^BA

Table 6 •

P1012728-011

ASCII

Code 93

ASCII

Code 93

@
A
B
C
D
E
F
G
H
I
J
K
L
M
N
O
P
Q
R
S
T
U
V
W
X
Y
Z
[
\
]
^
_

‘V
A
B
C
D
E
F
G
H
I
J
K
L
M
N
O
P
Q
R
S
T
U
V
W
X
Y
Z
‘K
‘L
‘M
‘N
‘O

‘
a
b
c
d
e
f
g
h
I
j
k
l
m
n
o
p
q
r
s
t
u
v
w
x
y
z
{
|
}
~
DEL

‘W
)A
)B
)C
)D
)E
)F
)G
)H
)I
)J
)K
)L
)M
)N
)O
)P
)Q
)R
)S
)T
)U
)V
)W
)X
)Y
)Z
‘P
‘Q
‘R
‘S
‘T

     */
	
}//end namespace