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
    public class zpl_cmd_c_TB : zpl_command{   //Text Blocks
        public string block_rotation                                               = String.Empty;
        public    int block_width_in_dots                                          = 0;
        public    int block_height_in_dots                                         = 0;
                                        
        public zpl_cmd_c_TB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^TB";                   
            description="Text Blocks";                   
            data_format="a,b,c ";                   
            example    ="";                   
            block_rotation                                              =(string)argument(0,data,"s","                   ",""," ");
            block_width_in_dots                                         =(   int)argument(1,data,"i","                   ",""," ");
            block_height_in_dots                                        =(   int)argument(2,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
a =block_rotation //
N = normal R = rotate 90 degrees clockwise I = invert 180 degrees B = read from bottom up-270 degrees  //whatever was specified by the last ^A (which has the default of ^FW) 
	
b =block_width_in_dots //
1 to the width of the label in dots  //1 dot 
	
c =block_height_in_dots //
1 to the length of the label in dots  //1 dot  ZPL Commands ^TO 326 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^TB – Text Blocks "+ 
			"The ^TB command prints a text block with defined width and height. The text block has an automatic "+ 
			"word-wrap function. If the text exceeds the block height, the text is truncated. This command "+ 
			"supports complex text layout features. "+ 
			"Format: ^TBa,b,c "+ 
			"Comments Facts about the ^TB command: "+ 
			"• Justification of "+ 
			"^TB command comes from ^FO, ^FT, or ^FN command. If no "+ 
			"justification is determined then the default is auto justification. "+ 
			"• Data between < and > is processed as an escape sequence; for example, "+ 
			"<< > will print < . "+ 
			"•The "+ 
			"^TB command has an automatic word-wrap function. Soft hyphens do not print "+ 
			"and are not used as a line break position. "+ 
			"This command is available only for printers with firmware version V60.14.x, V50.14.x, or "+ 
			"later. "+ 
			"Note • "+ 
			"^TB is the preferred command for printing fields or blocks of text, instead of ^FB. "+ 
			"Parameters Details "+ 
			"a = block rotation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotate 90 degrees clockwise "+ 
			"I = invert 180 degrees "+ 
			"B = read from bottom up-270 degrees "+ 
			"Default: whatever was specified by the last ^A (which has the default of ^FW) "+ 
			"b = block width in "+ 
			"dots "+ 
			"Values: "+ 
			"1 to the width of the label in dots "+ 
			"Default: 1 dot "+ 
			"c = block height in "+ 
			"dots "+ 
			"Values: "+ 
			"1 to the length of the label in dots "+ 
			"Default: 1 dot "+ 
			" "+ 
			"ZPL Commands "+ 
			"^TO "+ 
			"326 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
