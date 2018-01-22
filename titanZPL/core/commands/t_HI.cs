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
    public class zpl_cmd_t_HI : zpl_command{   //Host Identification
                                        
        public zpl_cmd_t_HI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~HI";                   
            description="Host Identification";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~HI – Host Identification "+ 
			"The ~HI command is designed to be sent from the host to the Zebra printer to retrieve information. "+ 
			"Upon receipt, the printer responds with information on the model, software version, dots-per- "+ 
			"millimeter setting, memory size, and any detected options. "+ 
			"Format: ~HI "+ 
			"When the printer receives this command, it returns: "+ 
			"XXXXXX,V1.0.0,dpm,000KB,X "+ 
			"XXXXXX = model of Zebra printer "+ 
			"V1.0.0 = version of software "+ 
			"dpm = dots/mm "+ 
			"6, 8, 12, or 24 dots/mm printheads "+ 
			"000KB = memory "+ 
			"512KB = 1/2 MB "+ 
			"1024KB = 1 MB "+ 
			"2048KB = 2 MB "+ 
			"4096KB = 4 MB "+ 
			"8192KB = 8 MB "+ 
			"x = recognizable options "+ 
			"only options specific to printer are shown (cutter, options, et cetera.) "+ 
			" "+ 
			"197 "+ 
			"ZPL Commands "+ 
			"~HM "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
