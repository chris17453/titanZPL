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
    public class zpl_cmd_c_HH : zpl_command{   //Configuration Label Return
                                        
        public zpl_cmd_c_HH(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HH";                   
            description="Configuration Label Return";                   
            data_format=" ";                   
            example    ="^XA^HH^XZ";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^HH – Configuration Label Return "+ 
			"The ^HH command echoes printer configuration back to the host, using a terminal emulator. "+ 
			"Format: ^HH "+ 
			"Example: This is an example of what is returned to the host when ^XA^HH^XZ is sent to the printer: "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HI "+ 
			"196 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
