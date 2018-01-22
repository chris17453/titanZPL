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
    public class zpl_cmd_c_NI : zpl_command{   //Network ID Number
        public    int number                                                       = 0;
                                        
        public zpl_cmd_c_NI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^NI";                   
            description="Network ID Number";                   
            data_format="### ";                   
            example    ="";                   
            number                                                      =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	## =network_ID_number_assigned //001 to 999  //000 (none)  285 ZPL Commands ~NR 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^NI – Network ID Number "+ 
			"The ^NI command is used to assign a network ID number to the printer. This must be done before "+ 
			"the printer can be used in a network. "+ 
			"Format: ^NI### "+ 
			"Comments The last network ID number set is the one recognized by the system. "+ 
			"The commands ~NC, ^NI, ~NR, and ~NT are used only with RS-485 printer communications. "+ 
			"Parameters Details "+ 
			"### = network ID "+ 
			"number assigned "+ 
			"(must be a "+ 
			"three-digit "+ 
			"entry) "+ 
			"Values: 001 to 999 "+ 
			"Default: 000 (none) "+ 
			" "+ 
			"285 "+ 
			"ZPL Commands "+ 
			"~NR "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
