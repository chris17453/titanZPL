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
    public class zpl_cmd_t_DU : zpl_command{   //Download Unbounded TrueType Font
        public string font_location                                                = String.Empty;
        public string font                                                         = String.Empty;
        public string extension_format                                             = String.Empty;
        public string s                                                            = String.Empty;
        public string data                                                         = String.Empty;
                                        
        public zpl_cmd_t_DU(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~DU";                   
            description="Download Unbounded TrueType Font";                   
            data_format="d,o,x,s,data ";                   
            example    ="";                   
            font_location                                               =(string)argument(0,data,"s","                   ",""," ");
            font                                                        =(string)argument(1,data,"s","                   ",""," ");
            extension_format                                            =(string)argument(2,data,"s","                   ",""," ");
            s                                                           =(string)argument(3,data,"s","                   ",""," ");
            data                                                        =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =font_location //R:, E:, B:, and A:  //R: 
	
o =font_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Format //the number of memory bytes required to hold the Zebra-downloadable format of the font  //if no data is entered, the command is ignored dat
	ta =data_string //a string of ASCII hexadecimal values (two hexadecimal digits/byte). The total number of two-digit values must match parameter s.  //if no data is entered, the command is ignore
                                       
  **************************************************/ 
            manual=""+ 
			"~DU – Download Unbounded TrueType Font "+ 
			"Some international fonts, such as Asian fonts, have more than "+ 
			"256 printable characters. These fonts are supported as large TrueType fonts and are downloaded to "+ 
			"the printer with the "+ 
			"~DU command. Use ZTools to convert the large TrueType fonts to a Zebra- "+ 
			"downloadable format. "+ 
			"The Field Block ( "+ 
			"^FB) command cannot support the large TrueType fonts. "+ 
			"Format: ~DUd:o.x,s,data "+ 
			"For similar commands, see ~DS on page 153, ~DT on page 154, and ~DY on page 156. "+ 
			"Parameters Details "+ 
			"d = font location "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = font name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Format: .FNT "+ 
			"s = font size "+ 
			"Values: the number of memory bytes required to hold the Zebra-downloadable "+ 
			"format of the font "+ 
			"Default: if no data is entered, the command is ignored "+ 
			"data = data string "+ 
			"Values: a string of ASCII hexadecimal values (two hexadecimal digits/byte). The "+ 
			"total number of two-digit values must match parameter s. "+ 
			"Default: if no data is entered, the command is ignored "+ 
			"Example: This is an example of how to download an unbounded true type font: "+ 
			"~DUR:KANJI,86753,60CA017B0CE7... "+ 
			"(86753 two-digit hexadecimal values) "+ 
			" "+ 
			"ZPL Commands "+ 
			"~DY "+ 
			"156 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
