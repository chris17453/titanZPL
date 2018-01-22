using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL.commands {
public class zpl_cmd_c_B3 : zpl_command {      //Code 39 Bar Code
		public string orientation                          = String.Empty;
		public string check_digit                          = String.Empty;
		public int    bar_code_height                      = 0;
		public string print_interpretation_line            = String.Empty;
		public string print_interpretation_line_above_code = String.Empty;
		public zpl_cmd_c_B3(string data) {
			cmd = "^B3";
			description = "Code 39 Bar Code";
			data_format = "o,e,h,f,g";
			orientation                          = (string)argument(0, data, "c", "N,R,I,B" , "", "N");  //fw
			check_digit                          = (string)argument(1, data, "c", "Y,N"     , "", "N");
			bar_code_height                      =    (int)argument(2, data, "i", "1-32000" , "", "");
			print_interpretation_line            = (string)argument(3, data, "c", "Y,N"     , "", "Y");  //BY
			print_interpretation_line_above_code = (string)argument(4, data, "c", "Y,N"     , "", "N");
            example="^XA^FO100,100^BY3^B3N,N,100,Y,N^FD123ABC^FS^XZ";
		}//end init function
        /*
         
^B3 – Code 39 Bar Code
The Code 39 bar code is the standard for many industries, including the U.S. Department of
Defense. It is one of three symbologies identified in the American National Standards Institute
(ANSI) standard MH10.8M-1983. Code 39 is also known as USD-3 Code and 3 of 9 Code.
Each character in a Code 39 bar code is composed of nine elements: five bars, four spaces, and an
inter-character gap. Three of the nine elements are wide; the six remaining elements are narrow.
• ^B3 supports print ratios of 2.0:1 to 3.0:1.
• Field data (^FD) is limited to the width (or length, if rotated) of the label.
• Code 39 automatically generates the start and stop character (*).
• Asterisk (*) for start and stop character prints in the interpretation line, if the interpretation line is
turned on.
• Code 39 is capable of encoding the full 128-character ASCII set.

Important • If additional information about the Code 39 bar code is required, go to
www.aimglobal.org.
Format:

^B3o,e,h,f,g

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

e = Mod-43 check
digit

Values:

Y = yes
N = no

Default: N

h = bar code height
(in dots)

Values: 1 to 32000

f = print
interpretation
line

Values:

Default: value set by ^BY

Y = yes
N = no

Default: Y

g = print
interpretation
line above code

Values:

Y = yes
N = no

Default: N

11/21/16

Zebra Programming Guide

P1012728-011

49

50

ZPL Commands
^B3

Example 1: This is an example of a Code 39 bar code:
ZPL II CODE

CODE 39 BAR CODE

^XA
^FO100,100^BY3
^B3N,N,100,Y,N
^FD123ABC^FS
^XZ

CODE 39 BAR CODE CHARACTERS
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
% Space

Comments Extended ASCII is a function of the scanner, not of the bar code. Your scanner
must have extended ASCII enabled for this feature to work. To enable extended ASCII in the
Code 39, you must first encode +$ in your ^FD statement. To disable extended ASCII, you
must encode -$ in your ^FD statement.
Example 2: This example encodes a carriage return with line feed into a Code 39 bar code:
ZPL II CODE

GENERATED LABELS

^XA
^FO20,20
^B3N,N,100,Y
^FDTEST+$$M$J-$^FS
^XZ

Full ASCII Mode for Code 39
Code 39 can generate the full 128-character ASCII set using paired characters as shown in these
tables:

P1012728-011

Zebra Programming Guide

11/21/16

ZPL Commands
^B3

Table 2 •
ASCII
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

Code 39
$A
$B
$C
$D
$E
$F
$G
$H
$I
$J
$K
$L
$M
$N
$O
$P
$Q
$R
$S
$T
$U
$V
$W
$X
$Y
$Z
%A
%B
%C
%D
%E

Zebra Programming Guide

ASCII
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

Code 39
Space
/A
/B
/C
/D
/E
/F
/G
/H
/I
/J
/K
/L
.
/O
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
/Z
%F
%G
%H
%I
%J

P1012728-011

51

52

ZPL Commands
^B3

Table 3 •

P1012728-011

ASCII

Code 39

ASCII

Code 39

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

%V
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
%K
%L
%M
%N
%O

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

%W
+A
+B
+C
+D
+E
+F
+G
+H
+I
+J
+K
+L
+M
+N
+O
+P
+Q
+R
+S
+T
+U
+V
+W
+X
+Y
+Z
%P
%Q
%R
%S
%T, %X

         */
	}//end class
	
}//end namespace