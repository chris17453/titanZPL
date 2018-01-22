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
    public class zpl_cmd_t_JQ : zpl_command{   //Terminate Zebra BASIC Interpreter
                                        
        public zpl_cmd_t_JQ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JQ";                   
            description="Terminate Zebra BASIC Interpreter";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JQ – Terminate Zebra BASIC Interpreter "+ 
			"The ~JQ command is used when Zebra BASIC Interpreter is active. Sending ~JQ to the printer "+ 
			"terminates the ZBI session. "+ 
			"Format: ~JQ "+ 
			"Comments Entering ZPL at the command prompt also terminates a ZBI session. "+ 
			"Identifies features that are available in printers with firmware version V60.16.2Z, V53.16.2Z, "+ 
			"or later. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JR "+ 
			"242 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
