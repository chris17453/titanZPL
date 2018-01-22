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
    public class zpl_cmd_c_CN : zpl_command{   //Cut Now
        public string cut_mode_override                                            = String.Empty;
                                        
        public zpl_cmd_c_CN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^CN";                   
            description="Cut Now";                   
            data_format="a ";                   
            example    ="";                   
            cut_mode_override                                           =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =Cut_Mode_Override //
0 = Use the “kiosk cut amount” setting from ^KV 1 = Ignore “kiosk cut amount” from ^KV and do a full cut  //none The command is ignored if parameters are missing or invalid.  ZPL Commands ^CO 136 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^CN – Cut Now "+ 
			"The ^CN causes the printer to cycle the media cutter. "+ 
			"Supported Devices "+ 
			"•KR403 "+ 
			"Format: ^CNa "+ 
			"Important • This command works only when the printer is in Print Mode Kiosk (^MMk). "+ 
			"If the printer is not in Print Mode Kiosk, then using this command has no effect. See ^MM "+ 
			"on page 272. "+ 
			"Parameters Details "+ 
			"a = Cut Mode Override "+ 
			"Values: "+ 
			"0 = Use the “kiosk cut amount” setting from ^KV "+ 
			"1 "+ 
			"= Ignore “kiosk cut amount” from ^KV and do a full cut "+ 
			"Default: none "+ 
			"The command is ignored if parameters are missing or invalid. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^CO "+ 
			"136 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
