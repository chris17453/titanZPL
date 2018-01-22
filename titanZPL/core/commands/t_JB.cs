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
    public class zpl_cmd_t_JB : zpl_command{   //Reset Optional Memory
                                        
        public zpl_cmd_t_JB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JB";                   
            description="Reset Optional Memory";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JB – Reset Optional Memory "+ 
			"The ~JB command is used for these conditions: "+ 
			"•The ~JB command must be sent to the printer if the battery supplying power to the battery "+ 
			"powered memory card fails and is replaced. A bad battery shows a battery dead condition on "+ 
			"the Printer Configuration Label. "+ 
			"•The ~JB command can also be used to intentionally clear (reinitialize) the B: memory card. The "+ 
			"card must not be write protected. "+ 
			"Format: ~JB "+ 
			"Comments If the battery is replaced and this command is not sent to the printer, the "+ 
			"memory card cannot function. "+ 
			" "+ 
			"223 "+ 
			"ZPL Commands "+ 
			"~JC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
