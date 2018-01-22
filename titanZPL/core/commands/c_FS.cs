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
    public class zpl_cmd_c_FS : zpl_command{   //Field Separator
                                        
        public zpl_cmd_c_FS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FS";                   
            description="Field Separator";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^FS – Field Separator "+ 
			"The ^FS command denotes the end of the field definition. Alternatively, ^FS command can also be "+ 
			"issued as a single ASCII control code SI (Control-O, hexadecimal 0F). "+ 
			"Format: ^FS "+ 
			" "+ 
			"177 "+ 
			"ZPL Commands "+ 
			"^FT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
