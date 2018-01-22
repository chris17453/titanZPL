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
    public class zpl_cmd_t_DT : zpl_command{   //Download Bounded TrueType Font
        public string font_location                                                = String.Empty;
        public string font                                                         = String.Empty;
        public string extension_fixed_value                                        = String.Empty;
        public string s                                                            = String.Empty;
        public string data                                                         = String.Empty;
                                        
        public zpl_cmd_t_DT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~DT";                   
            description="Download Bounded TrueType Font";                   
            data_format="d,o,x,s,data ";                   
            example    ="";                   
            font_location                                               =(string)argument(0,data,"s","                   ",""," ");
            font                                                        =(string)argument(1,data,"s","                   ",""," ");
            extension_fixed_value                                       =(string)argument(2,data,"s","                   ",""," ");
            s                                                           =(string)argument(3,data,"s","                   ",""," ");
            data                                                        =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =font_location //R:, E:, B:, and A:  //R: 
	
o =font_name //any valid TrueType name, up to 8 characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Fixed_Value //the number of memory bytes required to hold the Zebra-downloadable format of the font  //if an incorrect value or no value is entered, the command is ignored dat
	ta =data_string //a string of ASCII hexadecimal values (two hexadecimal digits/byte). The total number of two-digit values must match parameter s.  //if no data is entered, the command is ignore
                                       
  **************************************************/ 
            manual=""+ 
			"~DT – Download Bounded TrueType Font "+ 
			"Use ZTools to convert a TrueType font to a Zebra-downloadable format. that has less than 256 "+ 
			"characters in it. To convert a font that has more than 256 characters, see ~DU on page 155. ZTools "+ 
			"creates a downloadable file that includes a "+ 
			"~DT command. For information on converting and "+ 
			"downloading Intellifont information, see ~DS on page 153. "+ 
			"Format: ~DTd:o.x,s,data "+ 
			"Parameters Details "+ 
			"d = font location "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = font name "+ 
			"Values: any valid TrueType name, up to 8 characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension Fixed Value: .DAT "+ 
			"s = font size "+ 
			"Values: the number of memory bytes required to hold the Zebra-downloadable "+ 
			"format of the font "+ 
			"Default: if an incorrect value or no value is entered, the command is ignored "+ 
			"data = data string "+ 
			"Values: a string of ASCII hexadecimal values (two hexadecimal digits/byte). The "+ 
			"total number of two-digit values must match parameter s. "+ 
			"Default: if no data is entered, the command is ignored "+ 
			"Example: This is an example of how to download a true type font: "+ 
			"~DTR:FONT,52010,00AF01B0C65E... "+ 
			"(52010 two-digit hexadecimal values) "+ 
			" "+ 
			"155 "+ 
			"ZPL Commands "+ 
			"~DU "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
