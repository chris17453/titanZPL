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
    public class zpl_cmd_t_SD : zpl_command{   //Set Darkness
        public string darkness_setting                                             = String.Empty;
                                        
        public zpl_cmd_t_SD(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~SD";                   
            description="Set Darkness";                   
            data_format="## ";                   
            example    ="";                   
            darkness_setting                                            =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	## =desired_darkness_setting //00 to 30  //last permanently saved value Important • The darkness setting range for the XiIIIPlus, Xi4, and RXi4 is 0 to 30 in increments of 0.1. The firmware is setup so that the ^MD and ~SD commands (ZPL darkness commands) accept that range of settings
                                       
  **************************************************/ 
            manual=""+ 
			"~SD – Set Darkness "+ 
			"The ~SD command allows you to set the darkness of printing. ~SD is the equivalent of the darkness "+ 
			"setting parameter on the control panel display. "+ 
			"Format: ~SD## "+ 
			"Comments The ^MD command value, if applicable, is added to the ~SD command. "+ 
			"Parameters Details "+ 
			"## = desired darkness "+ 
			"setting (two- "+ 
			"digit number) "+ 
			"Values: 00 to 30 "+ 
			"Default: last permanently saved value "+ 
			"Important • The darkness setting range for the XiIIIPlus, Xi4, and RXi4 is 0 to 30 in "+ 
			"increments of 0.1. The firmware is setup so that the "+ 
			"^MD and ~SD commands (ZPL darkness "+ 
			"commands) accept that range of settings. "+ 
			"Example: These are examples of the XiIIIPlus, Xi4, and RXi4 Darkness Setting: "+ 
			"^MD8.3 "+ 
			"~SD8.3 "+ 
			" "+ 
			"305 "+ 
			"ZPL Commands "+ 
			"^SE "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
