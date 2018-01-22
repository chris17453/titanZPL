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
    public class zpl_cmd_c_FL : zpl_command{   //Font Linking
        public string ext                                                          = String.Empty;
        public string base_name                                                    = String.Empty;
        public string link                                                         = String.Empty;
                                        
        public zpl_cmd_c_FL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FL";                   
            description="Font Linking";                   
            data_format=" ext , base , link  ";                   
            example    ="";                   
            ext                                                         =(string)argument(0,data,"s","                   ",""," ");
            base_name                                                   =(string)argument(1,data,"s","                   ",""," ");
            link                                                        =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
0 =ext_is_to_be_unlinked // //must be an accepted value or it is ignored  ZPL Commands ^FL 168 P1012728-011 Zebra Programming Guide 11/21/16 Font Linking In the font linking example, this code is sent down to link the ANMDJ.TTF font to SWISS721.TTF font: ^XA ^FLE:ANMDJ.TTF,E:SWISS721.TTF,1^FS ^XZ When the label reprints, the Asian characters are printed using the ANMDJ.TTF font, rather than the SWISS721.TTF font
                                       
  **************************************************/ 
            manual=""+ 
			"^FL – Font Linking "+ 
			"The ^FL command provides the ability to link any TrueType font, including private character fonts, to "+ 
			"associated fonts. "+ 
			"If the base font does not have a glyph for the required character, the printer looks to the linked fonts "+ 
			"for the glyph. The font links are user-definable. The font linking remains until the link is broken or the "+ 
			"printer is turned off. To permanently save the font linking, use the ^JUS command. "+ 
			"Format: ^FL<ext>,<base>,<link> "+ 
			"Comments A font can have up to five fonts linked to it. The printer resident font, 0.FNT is "+ 
			"always the last font in the list of font links, but is not included in the five link maximum. It can "+ 
			"also be placed anywhere in the font links list. "+ 
			"The default glyph prints when a glyph cannot be found in any of the fonts in the link list. The "+ 
			"advanced layout command "+ 
			"^PA determines if the default glyph is a space character or the default "+ 
			"glyph of the base font, which is typically a hollow box. "+ 
			"The list of font links can be printed by using the "+ 
			"^LF command or retrieved with the ^HT command. "+ 
			"Note • For assistance in setting up the font links, use the font wizard in ZebraNet Bridge. "+ 
			"Parameters Details "+ 
			"<ext> "+ 
			"This is the fully-qualified filename of the extension. This file name does not accept "+ 
			"wildcards. "+ 
			"The supported extensions for this parameter are: "+ 
			".TTF and .TTE. The format for "+ 
			"this parameter is the memory device followed by the font name with the extension, "+ 
			"as follows: "+ 
			"E:SWISS721.TTF "+ 
			"<base> "+ 
			"This is the filename of the base font(s). The base font can be any of the following "+ 
			"types: "+ 
			".FNT "+ 
			".TTF or "+ 
			".TTE "+ 
			"From these font types you can only link to a .TTF or .TTE. "+ 
			"The name of the base font can be expressed as a wild card; doing so will define "+ 
			"multiple base fonts. The result will be that all base font files so defined will be linked "+ 
			"to the file defined in the <ext> parameter. "+ 
			"The filename does not have to match a file that is currently defined on the printer. A "+ 
			"specification of "+ 
			"*.TTF results in all *.TTF font files loaded on the printer currently "+ 
			"or in the future to be linked with the specified "+ 
			"<ext> font extension. "+ 
			"<link> "+ 
			"This is an indicator that determines if the extension is to be linked with the base, or "+ 
			"unlinked from the base, as follows: "+ 
			"Values: "+ 
			"0 = <ext> is to be unlinked (disassociated) from the file(s) specified in "+ 
			"<base> "+ 
			"1 = <ext> is to be linked (associated) with the file(s) specified by <base> "+ 
			"Default: must be an accepted value or it is ignored "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FL "+ 
			"168 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Font Linking "+ 
			"In the font linking example, this code is sent down to link the ANMDJ.TTF font to "+ 
			"SWISS721.TTF font: "+ 
			"^XA "+ 
			"^FLE:ANMDJ.TTF,E:SWISS721.TTF,1^FS "+ 
			"^XZ "+ 
			"When the label reprints, the Asian characters are printed using the ANMDJ.TTF font, rather than "+ 
			"the SWISS721.TTF font. "+ 
			"Examples: These examples show the code and output for no font linking and for font linking: "+ 
			"No Font Linking "+ 
			"In the no font linking example, the Swiss721 font does not have the Asian glyphs, which is why "+ 
			"Asian glyphs do not print. "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"169 "+ 
			"ZPL Commands "+ 
			"^FM "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
