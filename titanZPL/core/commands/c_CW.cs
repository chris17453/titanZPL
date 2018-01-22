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
    public class zpl_cmd_c_CW : zpl_command{   //Font Identifier
        public string letter_of_existing_font_to_be_substituted                    = String.Empty;
        public string device_to_store_font_in                                      = String.Empty;
        public string name_of_the_downloaded_font_to_be_substituted_for_the_built  = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_CW(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^CW";                   
            description="Font Identifier";                   
            data_format="a,d,o,x ";                   
            example    ="^XA"+
			            "^CWA,R:MYFONT.FNT"+
			            "^XZ";                   
            letter_of_existing_font_to_be_substituted                   =(string)argument(0,data,"s","                   ",""," ");
            device_to_store_font_in                                     =(string)argument(1,data,"s","                   ",""," ");
            name_of_the_downloaded_font_to_be_substituted_for_the_built =(string)argument(2,data,"s","                   ",""," ");
            extension                                                   =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =letter_of_existing_font_to_be_substituted //A through Z and 0 to 9  //a one-character entry is required 
	
d =device_to_store_font_in //R:, E:, B:, and A:  //R: 
	
o =name_of_the_downloaded_font_to_be_substituted_for_the_built //any name up to 8 characters  //if a name is not specified, UNKNOWN is used 
	
x =extension // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^CW – Font Identifier "+ 
			"All built-in fonts are referenced using a one-character identifier. The ^CW command assigns a single "+ 
			"alphanumeric character to a font stored in DRAM, memory card, EPROM, or Flash. "+ 
			"If the assigned character is the same as that of a built-in font, the downloaded font is used in place of "+ 
			"the built-in font. The new font is printed on the label wherever the format calls for the built-in font. If "+ 
			"used in place of a built-in font, the change is in effect only until power is turned off. "+ 
			"If the assigned character is different, the downloaded font is used as an additional font. The "+ 
			"assignment remains in effect until a new command is issued or the printer is turned off. "+ 
			"Format: ^CWa,d:o.x "+ 
			"Parameters Details "+ 
			"a = letter of "+ 
			"existing font to "+ 
			"be substituted, "+ 
			"or new font to "+ 
			"be added "+ 
			"Values: A through Z and 0 to 9 "+ 
			"Default: a one-character entry is required "+ 
			"d = device to store "+ 
			"font in "+ 
			"(optional) "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = name of the "+ 
			"downloaded font "+ 
			"to be "+ 
			"substituted for "+ 
			"the built-in, or "+ 
			"as an additional "+ 
			"font "+ 
			"Values: any name up to 8 characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			".TTE "+ 
			"is only supported in "+ 
			"firmware version V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			"Values: "+ 
			".FNT = Font "+ 
			".TTF = TrueType Font "+ 
			".TTE = TrueType Extension "+ 
			" "+ 
			"143 "+ 
			"ZPL Commands "+ 
			"^CW "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example: These examples show how to use: "+ 
			"• MYFONT.FNT stored in DRAM whenever a format calls for Font A: "+ 
			"^XA "+ 
			"^CWA,R:MYFONT.FNT "+ 
			"^XZ "+ 
			"• MYFONT.FNT stored in DRAM additionally as Font Q: "+ 
			"^XA "+ 
			"^CWQ,R:MYFONT.FNT "+ 
			"^XZ "+ 
			"• NEWFONT.FNT stored in DRAM whenever a format calls for font F: "+ 
			"^XA "+ 
			"^CWF,R:NEWFONT.FNT "+ 
			"^XZ "+ 
			"Label Listing Before Assignment Label Listing After Assignment "+ 
			" "+ 
			"ZPL Commands "+ 
			"~DB "+ 
			"144 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
