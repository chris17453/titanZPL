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
    public class zpl_cmd_t_HB : zpl_command{   //Battery Status
                                        
        public zpl_cmd_t_HB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~HB";                   
            description="Battery Status";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
	X> =ASCII_start // //-
                                       
  **************************************************/ 
            manual=""+ 
			"~HB – Battery Status "+ 
			"When the ~HB command is sent to the printer, a data string is sent back to the host. The string starts "+ 
			"with an <STX> control code sequence and terminates by an <ETX><CR><LF> control code "+ 
			"sequence. "+ 
			"Format: ~HB "+ 
			"Parameters: when the printer receives the command, it returns: "+ 
			"<STX>bb.bb,hh.hh,bt<ETX><CR><LF> "+ 
			"Comments This command is used for the power-supply battery of the printer and should "+ 
			"not be confused with the battery backed-up RAM. "+ 
			"Important • This command only responds to mobile printers. "+ 
			"<STX> = ASCII start-of-text character "+ 
			"bb.bb = current battery voltage reading to the nearest 1/4 volt "+ 
			"hh.hh = current head voltage reading to the nearest 1/4 volt "+ 
			"bt = battery temperature in Celsius "+ 
			"<ETX> = ASCII end-of-text character "+ 
			"<CR> = ASCII carriage return "+ 
			"<LF> = ASCII line feed character "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HD "+ 
			"192 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
