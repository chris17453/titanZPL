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
    public class zpl_cmd_c_PA : zpl_command{   //Advanced Text Properties
        public string default_glyph_this_determines_whether_the_default_glyph_is_a_space_character_or_the_default_glyph_of_the_base_font = String.Empty;
        public string bidirectional_text_layout_this_determines_whether_the_bidirectional_text_layout_is_turned_on_or_off = String.Empty;
        public string character_shaping_this_determines_whether_character_shaping_is_turned_on_or_off = String.Empty;
        public string opentype_table_support_this_determines_whether_the_opentype_support_is_turned_on_or_off = String.Empty;
                                        
        public zpl_cmd_c_PA(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PA";                   
            description="Advanced Text Properties";                   
            data_format="a,b,c,d ";                   
            example    ="";                   
            default_glyph_this_determines_whether_the_default_glyph_is_a_space_character_or_the_default_glyph_of_the_base_font=(string)argument(0,data,"s","                   ",""," ");
            bidirectional_text_layout_this_determines_whether_the_bidirectional_text_layout_is_turned_on_or_off=(string)argument(1,data,"s","                   ",""," ");
            character_shaping_this_determines_whether_character_shaping_is_turned_on_or_off=(string)argument(2,data,"s","                   ",""," ");
            opentype_table_support_this_determines_whether_the_opentype_support_is_turned_on_or_off=(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =default_glyph_This_determines_whether_the_default_glyph_is_a_space_character_or_the_default_glyph_of_the_base_font //
0 = off (space as default glyph) 1 = on (default glyph of font is used, often a hollow box, but depends on the font.)  //0 
	
b =bidirectional_text_layout_This_determines_whether_the_bidirectional_text_layout_is_turned_on_or_off //
0 = off 1 = on  //0 
	
c =character_shaping_This_determines_whether_character_shaping_is_turned_on_or_off //
0 = off 1 = on  //0 
	
d =OpenType_table_support_This_determines_whether_the_OpenType_support_is_turned_on_or_off //
0 = off 1 = on  //0  289 ZPL Commands ^PF 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^PA – Advanced Text Properties "+ 
			"The ^PA command is used to configure advanced text layout features. "+ 
			"Format: ^PAa,b,c,d "+ 
			"This command is available only for printers with firmware version V60.14.x, V50.14.x, or "+ 
			"later. "+ 
			"Parameters Details "+ 
			"a = default glyph "+ 
			"This determines whether the default glyph is a space character or the default glyph "+ 
			"of the base font, which is typically a hollow box. "+ 
			"Values: "+ 
			"0 = off (space as default glyph) "+ 
			"1 = on (default glyph of font is used, often a hollow box, but depends on "+ 
			"the font.) "+ 
			"Default: 0 "+ 
			"b = bidirectional "+ 
			"text layout "+ 
			"This determines whether the bidirectional text layout is turned on or off. "+ 
			"Values: "+ 
			"0 = off "+ 
			"1 = on "+ 
			"Default: 0 "+ 
			"c = character shaping "+ 
			"This determines whether character shaping is turned on or off. "+ 
			"Values: "+ 
			"0 = off "+ 
			"1 = on "+ 
			"Default: 0 "+ 
			"d = OpenType table "+ 
			"support "+ 
			"This determines whether the OpenType support is turned on or off. "+ 
			"Values: "+ 
			"0 = off "+ 
			"1 = on "+ 
			"Default: 0 "+ 
			" "+ 
			"289 "+ 
			"ZPL Commands "+ 
			"^PF "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
