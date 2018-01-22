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
    public class zpl_cmd_c_XB : zpl_command{   //Suppress Backfeed
                                        
        public zpl_cmd_c_XB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^XB";                   
            description="Suppress Backfeed";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^XB – Suppress Backfeed "+ 
			"The ^XB command suppresses forward feed of media to tear-off position depending on the current "+ 
			"printer mode. Because no forward feed occurs, a backfeed before printing of the next label is not "+ 
			"necessary; this improves throughput. When printing a batch of labels, the last label should not "+ 
			"contain this command. "+ 
			"Format: ^XB "+ 
			"^XB in the Tear-off Mode "+ 
			"Normal Operation: backfeed, print, and feed to rest "+ 
			"^XB Operation: print (Rewind Mode) "+ 
			"^XB in Peel-off Mode "+ 
			"Normal Operation: backfeed, print, and feed to rest "+ 
			"^XB Operation: print (Rewind Mode) "+ 
			"Note • "+ 
			"To prevent jamming in cutter mode, ^XB suppresses backfeed and cutting. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^XF "+ 
			"338 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
