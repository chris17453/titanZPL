/*****************************************************************************
*       ████████╗██╗████████╗ █████╗ ███╗   ██╗███████╗██████╗ ██╗           *
*       ╚══██╔══╝██║╚══██╔══╝██╔══██╗████╗  ██║╚══███╔╝██╔══██╗██║           *
*          ██║   ██║   ██║   ███████║██╔██╗ ██║  ███╔╝ ██████╔╝██║           *
*          ██║   ██║   ██║   ██╔══██║██║╚██╗██║ ███╔╝  ██╔═══╝ ██║           *
*          ██║   ██║   ██║   ██║  ██║██║ ╚████║███████╗██║     ███████╗      *
*          ╚═╝   ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝╚═╝     ╚══════╝      *
******************************************************************************
*      Created By: Charles Watkins                                           *
*      Date      : 2017-10-12                                                *
*****************************************************************************/
using System;
using System.Collections.Generic;
namespace titanZPL.commands  {
    public class zpl_cmd_c_BZ : zpl_command{   //POSTAL Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height                                              = 0;
        public string print_interpretation_line                                    = String.Empty;
        public string print_interpretation_line_above_code                         = String.Empty;
        public string postal_code_type                                             = String.Empty;
                                        
        public zpl_cmd_c_BZ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BZ";                   
            description="POSTAL Bar Code";                   
            data_format="o,h,f,g,t ";                   
            example    ="^XA"+
			            "^CC/"+
			            "/XZ"+
			            "The forward slash (/) is set at the new prefix. Note the /XZ ending tag uses the new designated"+
			            "prefix character (/)."+
			            "Example: This is an example of how to change the format prefix from ~ to a /:"+
			            "~CC/"+
			            "/XA/JUS/XZ"+
			            ""+
			            "127"+
			            "ZPL Commands"+
			            "^CD ~CD"+
			            "11/21/16 Zebra Programming Guide P1012728-011"+
			            "^CD ~CD – Change Delimiter"+
			            "The ^CD and ~CD commands are used to change the delimiter character. This character is used to"+
			            "separate parameter values associated with several ZPL II commands. The default delimiter is a"+
			            "comma (,)."+
			            "Format: ^CDa or ~CDa"+
			            "Parameters Details"+
			            "a = delimiter"+
			            "character change"+
			            "Values: any ASCII character"+
			            "Default: a parameter is required. If a parameter is not entered, the next character"+
			            "received is the new prefix character."+
			            "Example: This shows how to change the character delimiter to a semi-colon (;):"+
			            "^XA"+
			            "^FO10,10"+
			            "^GB10,10,3"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height                                             =(   int)argument(1,data,"i","                   ",""," ");
            print_interpretation_line                                   =(string)argument(2,data,"s","                   ",""," ");
            print_interpretation_line_above_code                        =(string)argument(3,data,"s","                   ",""," ");
            postal_code_type                                            =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
h =bar_code_height //1 to 32000  //value set by ^BY 
	
f =print_interpretation_line //
N = no Y = yes  //N 
	
g =print_interpretation_line_above_code //
N = no Y = yes  //N 
	
t =Postal_code_type //
0 = Postnet bar code 1 = Plant Bar Code 2 = Reserved 3 = USPS Intelligent Mail bar code  //0  125 ZPL Commands ^BZ 11/21/16 Zebra Programming Guide P1012728-01
                                       
  **************************************************/ 
            manual=""+ 
			"^BZ – POSTAL Bar Code "+ 
			"The POSTAL bar code is used to automate the handling of mail. POSTAL codes use a series of tall "+ 
			"and short bars to represent the digits. "+ 
			"• ^BZ supports a print ratio of 2.0:1 to 3.0:1. "+ 
			"• Field data ( "+ 
			"^FD) is limited to the width (or length, if rotated) of the label and by the "+ 
			"bar code specification. "+ 
			"Format: ^BZo,h,f,g,t "+ 
			"Important • If additional information about the POSTAL and PLANET bar code is required, go "+ 
			"to "+ 
			"www.aimglobal.org, or contact the United States Postal Service http://pe.usps.gov. If "+ 
			"additional information about the INTELLIGENT MAIL bar code is required, see: "+ 
			"http://ribbs.usps.gov/OneCodeSolution. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"h = bar code height "+ 
			"(in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: value set by ^BY "+ 
			"f = print "+ 
			"interpretation "+ 
			"line "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"g = print "+ 
			"interpretation "+ 
			"line above code "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"t = Postal code type "+ 
			"Values: "+ 
			"0 = Postnet bar code "+ 
			"1 = Plant Bar Code "+ 
			"2 = Reserved "+ 
			"3 = USPS Intelligent Mail bar code "+ 
			"Default: 0 "+ 
			" "+ 
			"125 "+ 
			"ZPL Commands "+ 
			"^BZ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example 1: This is an example of a POSTNET bar code: "+ 
			"Example 2: This is an example of a USPS Intelligent Mail bar code: "+ 
			"^XA "+ 
			"^FO100,100^BY3 "+ 
			"^BZN,40,Y,N "+ 
			"^FD12345^FS "+ 
			"^XZ "+ 
			"POSTNET BAR CODE CHARACTERS "+ 
			"ZPL II CODE "+ 
			"0123456789 "+ 
			"POSTNET BAR CODE "+ 
			"^XA "+ 
			"^FO100,040^BZ,40,,,3 "+ 
			"^FD00123123456123456789^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"USPS INTELLIGENT MAIL BAR CODE "+ 
			" "+ 
			"ZPL Commands "+ 
			"^CC ~CC "+ 
			"126 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"^CC ~CC – Change Caret "+ 
			"The ^CC command is used to change the format command prefix. The default prefix is the caret (^). "+ 
			"Format: ^CCx or ~CCx "+ 
			"Parameters Details "+ 
			"x = caret character "+ 
			"change "+ 
			"Values: any ASCII character "+ 
			"Default: a parameter is required. If a parameter is not entered, the next character "+ 
			"received is the new prefix character. "+ 
			"Example: This is an example of how to change the format prefix to / from a :: "+ 
			"^XA "+ 
			"^CC/ "+ 
			"/XZ "+ 
			"The forward slash (/) is set at the new prefix. Note the /XZ ending tag uses the new designated "+ 
			"prefix character (/). "+ 
			"Example: This is an example of how to change the format prefix from ~ to a /: "+ 
			"~CC/ "+ 
			"/XA/JUS/XZ "+ 
			" "+ 
			"127 "+ 
			"ZPL Commands "+ 
			"^CD ~CD "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"^CD ~CD – Change Delimiter "+ 
			"The ^CD and ~CD commands are used to change the delimiter character. This character is used to "+ 
			"separate parameter values associated with several ZPL II commands. The default delimiter is a "+ 
			"comma (,). "+ 
			"Format: ^CDa or ~CDa "+ 
			"Parameters Details "+ 
			"a = delimiter "+ 
			"character change "+ 
			"Values: any ASCII character "+ 
			"Default: a parameter is required. If a parameter is not entered, the next character "+ 
			"received is the new prefix character. "+ 
			"Example: This shows how to change the character delimiter to a semi-colon (;): "+ 
			"^XA "+ 
			"^FO10,10 "+ 
			"^GB10,10,3 "+ 
			"^XZ "+ 
			"^XA "+ 
			"^CD; "+ 
			"^FO10;10 "+ 
			"^GB10;10;3 "+ 
			"^XZ "+ 
			"• To save, the JUS command is required. Here is an example using JUS: "+ 
			"~CD; "+ 
			"^XA^JUS^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^CF "+ 
			"128 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
