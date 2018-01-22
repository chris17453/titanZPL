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
    public class zpl_cmd_c_XA : zpl_command{   //Start Format
                                        
        public zpl_cmd_c_XA(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^XA";                   
            description="Start Format";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^XA – Start Format "+ 
			"The ^XA command is used at the beginning of ZPL II code. It is the opening bracket and indicates "+ 
			"the start of a new label format. This command is substituted with a single ASCII control character "+ 
			"STX (control-B, hexadecimal 02). "+ 
			"Format: ^XA "+ 
			"Comments Valid ZPL II format requires that label formats should start with the ^XA "+ 
			"command and end with the "+ 
			"^XZ command. "+ 
			" "+ 
			"337 "+ 
			"ZPL Commands "+ 
			"^XB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
