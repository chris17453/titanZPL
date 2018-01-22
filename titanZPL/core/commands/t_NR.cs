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
    public class zpl_cmd_t_NR : zpl_command{   //Set All Network Printers Transparent
                                        
        public zpl_cmd_t_NR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~NR";                   
            description="Set All Network Printers Transparent";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~NR – Set All Network Printers Transparent "+ 
			"The ~NR command sets all printers in the network to be transparent, regardless of ID or current "+ 
			"mode. "+ 
			"Format: ~NR "+ 
			"Comments The commands ~NC, ^NI, ~NR, and ~NT are used only with RS-485 printer "+ 
			"communications. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^NS "+ 
			"286 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
