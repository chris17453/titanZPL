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
    public class zpl_cmd_t_PS : zpl_command{   //Print Start
                                        
        public zpl_cmd_t_PS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~PS";                   
            description="Print Start";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~PS – Print Start "+ 
			"The ~PS command causes a printer in Pause Mode to resume printing. The operation is identical to "+ 
			"pressing PAUSE on the control panel of the printer when the printer is already in Pause Mode. "+ 
			"Format: ~PS "+ 
			" "+ 
			"301 "+ 
			"ZPL Commands "+ 
			"^PW "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
