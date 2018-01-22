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
    public class zpl_cmd_c_PN : zpl_command{   //Present Now
        public string media_eject_length                                           = String.Empty;
                                        
        public zpl_cmd_c_PN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PN";                   
            description="Present Now";                   
            data_format="a ";                   
            example    ="";                   
            media_eject_length                                          =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =media_eject_length //
0-255 = additional mm of media to eject  //none The command is ignored if parameters are missing or invalid.  ZPL Commands ^PO 294 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^PN – Present Now "+ 
			"The ^PN command causes the printer to run a Presenter cycle. The parameter defines the amount "+ 
			"of media ejected. The total amount of media ejected when a ^PN is executed, then, is 50mm + ~PL "+ 
			"value + ^PN value. (See ~PL on page 291). "+ 
			"Supported Devices "+ 
			"•KR403 "+ 
			"Format: ^PNa "+ 
			"Parameters Details "+ 
			"a = media eject "+ 
			"length "+ 
			"Values: "+ 
			"0-255 = additional mm of media to eject "+ 
			"Default: none "+ 
			"The command is ignored if parameters are missing or invalid. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^PO "+ 
			"294 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
