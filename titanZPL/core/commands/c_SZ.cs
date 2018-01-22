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
    public class zpl_cmd_c_SZ : zpl_command{   //Set ZPL Mode
        public string zpl_version                                                  = String.Empty;
                                        
        public zpl_cmd_c_SZ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SZ";                   
            description="Set ZPL Mode";                   
            data_format="a ";                   
            example    ="";                   
            zpl_version                                                 =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =ZPL_version //
1 = ZPL 2 = ZPL II  //2  ZPL Commands ~TA 324 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^SZ – Set ZPL Mode "+ 
			"The ^SZ command is used to select the programming language used by the printer. This command "+ 
			"gives you the ability to print labels formatted in both ZPL and ZPL II. "+ 
			"This command remains active until another "+ 
			"^SZ command is sent to the printer or the printer is "+ 
			"turned off. "+ 
			"Format: ^SZa "+ 
			"Comments If the parameter is missing or invalid, the command is ignored. "+ 
			"Parameters Details "+ 
			"a = ZPL version "+ 
			"Values: "+ 
			"1 = ZPL "+ 
			"2 = ZPL II "+ 
			"Default: 2 "+ 
			" "+ 
			"ZPL Commands "+ 
			"~TA "+ 
			"324 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
