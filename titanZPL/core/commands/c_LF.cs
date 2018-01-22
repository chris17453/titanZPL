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
    public class zpl_cmd_c_LF : zpl_command{   //List Font Links
                                        
        public zpl_cmd_c_LF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^LF";                   
            description="List Font Links";                   
            data_format="";                   
            example    ="^XA"+
			            "^FLE:ANMDJ.TTF,E:SWISS721.TTF,1^FS"+
			            "^FLE:MSGOTHIC.TTF,E:SWISS721.TTF,1^FS"+
			            "^XZ";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^LF – List Font Links "+ 
			"The ^LF command prints out a list of the linked fonts. "+ 
			"This command is available only for printers with firmware version V60.14.x, V50.14.x, or "+ 
			"later. "+ 
			"Example: This example shows that SWISS721.TTF is the based font. ANMDJ.TTF is the first "+ 
			"linked font, and "+ 
			"MSGOTHIC.TTF is the second linked extension: "+ 
			"This is the code that established the font links: "+ 
			"^XA "+ 
			"^FLE:ANMDJ.TTF,E:SWISS721.TTF,1^FS "+ 
			"^FLE:MSGOTHIC.TTF,E:SWISS721.TTF,1^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^LF "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^LH "+ 
			"260 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
