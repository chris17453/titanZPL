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
    public class zpl_cmd_t_JR : zpl_command{   //Power On Reset
                                        
        public zpl_cmd_t_JR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JR";                   
            description="Power On Reset";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JR – Power On Reset "+ 
			"The ~JR command resets all of the printer’s internal software, performs a power-on self-test "+ 
			"(POST), clears the buffer and DRAM, and resets communication parameters and default values. "+ 
			"Issuing a "+ 
			"~JR command performs the same function as a manual power-on reset. "+ 
			"Format: ~JR "+ 
			" "+ 
			"243 "+ 
			"ZPL Commands "+ 
			"^JS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
