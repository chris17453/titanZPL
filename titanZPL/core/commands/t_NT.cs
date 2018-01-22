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
    public class zpl_cmd_t_NT : zpl_command{   //Set Currently Connected Printer Transparent
                                        
        public zpl_cmd_t_NT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~NT";                   
            description="Set Currently Connected Printer Transparent";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~NT – Set Currently Connected Printer Transparent "+ 
			"The ~NT command sets the currently connected network printer to be transparent. "+ 
			"Format: ~NT "+ 
			"Comments With Z Series "+ 
			"® "+ 
			"printers, the ~NT command functions the same as the ~NR "+ 
			"command. All Z Series printers on a network receive the transmission. "+ 
			"The commands ~NC, ^NI, ~NR, and ~NT are used only with RS-485 printer communications. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^PA "+ 
			"288 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
