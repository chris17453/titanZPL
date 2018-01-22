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
    public class zpl_cmd_t_JA : zpl_command{   //Cancel All
                                        
        public zpl_cmd_t_JA(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JA";                   
            description="Cancel All";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JA – Cancel All "+ 
			"The ~JA command cancels all format commands in the buffer. It also cancels any batches that are "+ 
			"printing. "+ 
			"The printer stops after the current label is finished printing. All internal buffers are cleared of data "+ 
			"and the "+ 
			"DATA LED turn off. "+ 
			"Submitting this command to the printer scans the buffer and deletes only the data before the "+ 
			"~JA in "+ 
			"the input buffer — it does not scan the remainder of the buffer for additional ~JA commands. "+ 
			"Format: ~JA "+ 
			" "+ 
			"221 "+ 
			"ZPL Commands "+ 
			"^JB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
