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
    public class zpl_cmd_c_MW : zpl_command{   //Modify Head Cold Warning
        public string enable_head_cold_warning                                     = String.Empty;
                                        
        public zpl_cmd_c_MW(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MW";                   
            description="Modify Head Cold Warning";                   
            data_format="a ";                   
            example    ="";                   
            enable_head_cold_warning                                    =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =enable_head_cold_warning // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^MW – Modify Head Cold Warning "+ 
			"The ^MW command allows you to set the head cold warning indicator based on the operating "+ 
			"environment. "+ 
			"Format: ^MWa "+ 
			"Parameters Details "+ 
			"a = enable head cold "+ 
			"warning "+ 
			"Values: "+ 
			"Y = enable head cold warning "+ 
			"N = disable head cold warning "+ 
			"Important • When a parameter is not given, the instruction is ignored. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^NC "+ 
			"280 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
