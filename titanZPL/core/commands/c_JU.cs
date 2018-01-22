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
    public class zpl_cmd_c_JU : zpl_command{   //Configuration Update
        public string active_configuration                                         = String.Empty;
                                        
        public zpl_cmd_c_JU(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JU";                   
            description="Configuration Update";                   
            data_format="a ";                   
            example    ="";                   
            active_configuration                                        =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =active_configuration //
F = reload factory settings N = reload factory network settings These values are lost at power-off if not saved with ^JUS. R = recall last saved settings S = save current settings These values are used at power-on.  //a value must be specified  247 ZPL Commands ^JW 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^JU – Configuration Update "+ 
			"The ^JU command sets the active configuration for the printer. "+ 
			"Format: ^JUa "+ 
			"Parameters Details "+ 
			"a = active "+ 
			"configuration "+ 
			"Values: "+ 
			"F = reload factory settings "+ 
			"N = reload factory network settings "+ 
			"These values are lost at power-off if not saved with "+ 
			"^JUS. "+ 
			"R = recall last saved settings "+ 
			"S = save current settings "+ 
			"These values are used at power-on. "+ 
			"Default: a value must be specified "+ 
			" "+ 
			"247 "+ 
			"ZPL Commands "+ 
			"^JW "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
