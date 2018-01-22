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
    public class zpl_cmd_t_WC : zpl_command{   //Print Configuration Label
                                        
        public zpl_cmd_t_WC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~WC";                   
            description="Print Configuration Label";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~WC – Print Configuration Label "+ 
			"The ~WC command is used to generate a printer configuration label. The printer configuration label "+ 
			"contains information about the printer setup, such as sensor type, network ID, ZPL mode, firmware "+ 
			"version, and descriptive data on the "+ 
			"R:, E:, B:, and A: devices. "+ 
			"Format: ~WC "+ 
			"Comments This command works only when the printer is idle. "+ 
			" "+ 
			"329 "+ 
			"ZPL Commands "+ 
			"^WD "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
