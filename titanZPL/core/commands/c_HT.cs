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
    public class zpl_cmd_c_HT : zpl_command{   //Host Linked Fonts List
                                        
        public zpl_cmd_c_HT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HT";                   
            description="Host Linked Fonts List";                   
            data_format="";                   
            example    ="^XA"+
			            "^FLE:ANMDJ.TTF,E:SWISS721.TTF,1^FS"+
			            "^FLE:MSGOTHIC.TTF,E:SWISS721.TTF,1^FS"+
			            "^XZ";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^HT – Host Linked Fonts List "+ 
			"The ^HT command receives the complete list of font links over a communication port. "+ 
			"This command is available only for printers with firmware version V60.14.x, V50.14.x, or "+ 
			"later. "+ 
			"Example: The SWISS.721.TTF is the base font, ANMDJ.TTF is the first linked font, and "+ 
			"MSGOTHIC.TTF is the second linked font: "+ 
			"This is the code that was used to establish the font links: "+ 
			"^XA "+ 
			"^FLE:ANMDJ.TTF,E:SWISS721.TTF,1^FS "+ 
			"^FLE:MSGOTHIC.TTF,E:SWISS721.TTF,1^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"DATA RETURNED "+ 
			"^XA "+ 
			"^HT "+ 
			"^XZ "+ 
			"LIST OF FONT LINKS "+ 
			"E:SWISS721.TTF "+ 
			"E:ANMDJ.TTF "+ 
			"E:MSGOTHIC.TTF "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HU "+ 
			"208 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
