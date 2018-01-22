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
    public class zpl_cmd_t_DN : zpl_command{   //Abort Download Graphic
                                        
        public zpl_cmd_t_DN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~DN";                   
            description="Abort Download Graphic";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~DN – Abort Download Graphic "+ 
			"After decoding and printing the number of bytes in parameter t of the ~DG command, the printer "+ 
			"returns to normal Print Mode. Graphics Mode can be aborted and normal printer operation resumed "+ 
			"by using the "+ 
			"~DN command. "+ 
			"Format: ~DN "+ 
			"Comments If you need to stop a graphic from downloading, you should abort the "+ 
			"transmission from the host device. To clear the "+ 
			"~DG command, however, you must send a ~DN "+ 
			"command. "+ 
			" "+ 
			"153 "+ 
			"ZPL Commands "+ 
			"~DS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
