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
    public class zpl_cmd_c_XZ : zpl_command{   //End Format
                                        
        public zpl_cmd_c_XZ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^XZ";                   
            description="End Format";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^XZ – End Format "+ 
			"The ^XZ command is the ending (closing) bracket. It indicates the end of a label format. When this "+ 
			"command is received, a label prints. This command can also be issued as a single ASCII control "+ 
			"character ETX (Control-C, hexadecimal 03). "+ 
			"Format: ^XZ "+ 
			"Comments Label formats must start with the ^XA command and end with the ^XZ "+ 
			"command to be in valid ZPL II format. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^ZZ "+ 
			"342 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
