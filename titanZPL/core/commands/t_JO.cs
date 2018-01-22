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
    public class zpl_cmd_t_JO : zpl_command{   //Head Test Non-Fatal
                                        
        public zpl_cmd_t_JO(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JO";                   
            description="Head Test Non-Fatal";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JO – Head Test Non-Fatal "+ 
			"The ~JO command configures the printer to run the head test with error reporting enabled. When "+ 
			"~JO "+ 
			"is used an error will be displayed and printing will stop if the head test fails. The user can push "+ 
			"the PAUSE button on the printer to bypass the error. This command differs from the "+ 
			"~JN (Head Test "+ 
			"Fatal) command in that a power cycle is not required in the event of a head test failure. "+ 
			"~JO is the default print head test condition. This setting is changed when the printer receives a ~JN "+ 
			"(Head Test Fatal) command. "+ 
			"Format: ~JO "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JP "+ 
			"240 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
