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
    public class zpl_cmd_t_KB : zpl_command{   //Kill Battery (Battery Discharge Mode)
                                        
        public zpl_cmd_t_KB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~KB";                   
            description="Kill Battery (Battery Discharge Mode)";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~KB – Kill Battery (Battery Discharge Mode) "+ 
			"To maintain performance of the rechargeable battery in the portable printers, the battery must be "+ 
			"fully discharged and recharged regularly. The ~KB command places the printer in battery discharge "+ 
			"mode. This allows the battery to be drained without actually printing. "+ 
			"Format: ~KB "+ 
			"Comments While the printer is in Discharge Mode, the green power LED flashes in groups "+ 
			"of three flashes. "+ 
			"Discharge Mode might be terminated by sending a printing format to the printer or by pressing either "+ 
			"of the control panel keys. "+ 
			"If the battery charger is plugged into the printer, the battery is automatically recharged once the "+ 
			"discharge process is completed. "+ 
			" "+ 
			"251 "+ 
			"ZPL Commands "+ 
			"^KD "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
