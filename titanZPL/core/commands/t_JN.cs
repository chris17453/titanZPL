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
    public class zpl_cmd_t_JN : zpl_command{   //Head Test Fatal
                                        
        public zpl_cmd_t_JN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JN";                   
            description="Head Test Fatal";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JN – Head Test Fatal "+ 
			"The ~JN command turns on the head test option. When activated, ~JN causes the printer to halt "+ 
			"when a head test failure is encountered. "+ 
			"Once an error is encountered the printer remains in error mode until the head test is turned off ( "+ 
			"~JO) "+ 
			"or power is cycled. "+ 
			"Format: ~JN "+ 
			"Comments If the communications buffer is full, the printer is not able to receive data. In "+ 
			"this condition, the "+ 
			"~JO command is not received by the printer. "+ 
			" "+ 
			"239 "+ 
			"ZPL Commands "+ 
			"~JO "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
