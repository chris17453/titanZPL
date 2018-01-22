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
    public class zpl_cmd_t_NC : zpl_command{   //Network Connect
        public    int number                                                       = 0;
                                        
        public zpl_cmd_t_NC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~NC";                   
            description="Network Connect";                   
            data_format="### ";                   
            example    ="";                   
            number                                                      =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	## =network_ID_number_assigned //001 to 999  //000 (none)  ZPL Commands ^ND 282 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"~NC – Network Connect "+ 
			"The ~NC command is used to connect a particular printer to a network by calling up the printer’s "+ 
			"network ID number. "+ 
			"Format: ~NC### "+ 
			"Comments Use this command at the beginning of any label format to specify which printer "+ 
			"on the network is going to be used. Once the printer is established, it continues to be used "+ 
			"until it is changed by another "+ 
			"~NC command. This command must be included in the label "+ 
			"format to wake up the printer. "+ 
			"The commands ^MW, ~NC, ^NI, ~NR, and ~NT are used only with RS-422/485 printer "+ 
			"communications. "+ 
			"Parameters Details "+ 
			"### = network ID "+ 
			"number assigned "+ 
			"(must be a "+ 
			"three-digit "+ 
			"entry) "+ 
			"Values: 001 to 999 "+ 
			"Default: 000 (none) "+ 
			" "+ 
			"ZPL Commands "+ 
			"^ND "+ 
			"282 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
