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
    public class zpl_cmd_c_JW : zpl_command{   //Set Ribbon Tension
        public string tension                                                      = String.Empty;
                                        
        public zpl_cmd_c_JW(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JW";                   
            description="Set Ribbon Tension";                   
            data_format="t ";                   
            example    ="";                   
            tension                                                     =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
t =tension //
L = low M = medium H = high  //a value must be specified  ZPL Commands ~JX 248 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^JW – Set Ribbon Tension "+ 
			"^JW sets the ribbon tension for the printer it is sent to. "+ 
			"Format: ^JWt "+ 
			"Comments ^JW is used only for PAX series printers. "+ 
			"Parameters Details "+ 
			"t = tension "+ 
			"Values: "+ 
			"L = low "+ 
			"M = medium "+ 
			"H = high "+ 
			"Default: a value must be specified "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JX "+ 
			"248 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
