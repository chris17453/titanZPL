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
    public class zpl_cmd_t_PL : zpl_command{   //Present Length Addition
        public string additional_eject_length                                      = String.Empty;
                                        
        public zpl_cmd_t_PL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~PL";                   
            description="Present Length Addition";                   
            data_format="a ";                   
            example    ="";                   
            additional_eject_length                                     =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =additional_eject_length //
000-255 = additional mm of media to eject  //000 The command is ignored if parameters are missing or invalid.  ZPL Commands ^PM 292 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"~PL – Present Length Addition "+ 
			"The ~PL command adds an additional amount to how far the paper is ejected during a present "+ 
			"cycle. A standard amount of 50mm is always added to clear the kiosk wall. This amount is added to "+ 
			"that 50mm. The total amount of media ejected when a ^PN is executed, then, is 50mm + ~PL value "+ 
			"+ ^PN value. "+ 
			"Supported Devices "+ 
			"•KR403 "+ 
			"Format: ^PLa "+ 
			"Parameters Details "+ 
			"a = additional eject length "+ 
			"Values: "+ 
			"000-255 = additional mm of media to eject "+ 
			"Default: 000 "+ 
			"The command is ignored if parameters are missing or invalid. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^PM "+ 
			"292 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
