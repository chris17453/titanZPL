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
    public class zpl_cmd_t_PR : zpl_command{   //Applicator Reprint
                                        
        public zpl_cmd_t_PR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~PR";                   
            description="Applicator Reprint";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~PR – Applicator Reprint "+ 
			"If the ~PR command is enabled (see ^JJ on page 234), the last label printed reprints, similar to the "+ 
			"applicator asserting the Reprint signal on the applicator port. This command is similar to "+ 
			"device.applicator.reprint on page 621. "+ 
			"Supported Devices "+ 
			"•ZE500 "+ 
			"• XiIIIPlus "+ 
			"• Xi4 with firmware V53.17.1Z or later "+ 
			"• PAX2, PAX4 "+ 
			"•S4M "+ 
			"• ZM400/ZM600 "+ 
			"Format: ~PR "+ 
			"Comments Pressing PREVIOUS on the control panel also causes the last label to reprint. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^PR "+ 
			"298 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
