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
    public class zpl_cmd_c_ZZ : zpl_command{   //rinter Sleep
        public    int number_of_second                                             = 0;
        public string b                                                            = String.Empty;
                                        
        public zpl_cmd_c_ZZ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^ZZ";                   
            description="rinter Sleep";                   
            data_format="t,b ";                   
            example    ="";                   
            number_of_second                                            =(   int)argument(0,data,"i","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
t =number_of_second //0 to 999999 – setting 0 disables automatic shutdown  //last permanently saved value or 0 
                                       
  **************************************************/ 
            manual="^ZZ – Printer Sleep "+ 
			"The ^ZZ command places the printer in an idle or shutdown mode. "+ 
			"Format: ^ZZt,b "+ 
			"Comments The ^ZZ command is only valid on the PA400 and PT400 battery-powered "+ 
			"printers. "+ 
			"Parameters Details "+ 
			"t = number of second "+ 
			"(idle time) "+ 
			"prior to "+ 
			"shutdown "+ 
			"Values: 0 to 999999 – setting 0 disables automatic shutdown "+ 
			"Default: last permanently saved value or 0 "+ 
			"b = label status at "+ 
			"shutdown "+ 
			"Values: "+ 
			"Y = indicates to shutdown when labels are still queued "+ 
			"N = indicates all labels must be printed before shutting down "+ 
			"Default: "+ 
			"N";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
