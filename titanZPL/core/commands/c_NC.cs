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
    public class zpl_cmd_c_NC : zpl_command{   //Select the Primary Network Device
        public string primary_network_device                                       = String.Empty;
                                        
        public zpl_cmd_c_NC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^NC";                   
            description="Select the Primary Network Device";                   
            data_format="a ";                   
            example    ="";                   
            primary_network_device                                      =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =primary_network_device //
1 = wired primary 2 = wireless primary  //1 must be an accepted value or it is ignored  281 ZPL Commands ~NC 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^NC – Select the Primary Network Device "+ 
			"The ^NC command selects the wired or wireless print server as the primary network device. "+ 
			"Supported Devices "+ 
			"• Xi4, RXi4 "+ 
			"• ZM400/ZM600, RZ400/RZ600 "+ 
			"The Xi4, RXi4, ZM400/ZM600, and RZ400/RZ600 printers support the simultaneous installation of "+ 
			"an internal, external, and a wireless print server. Even though all three print servers may be installed, "+ 
			"only one is connected to the network and is the active print server. Table 1 6 outlines priorities and "+ 
			"identifies which device becomes the active print server when multiple print servers are installed. "+ 
			"Format: ^NCa "+ 
			"Table 16 • Effect of Primary Network Setting on Active Print Server "+ 
			"If the "+ 
			"Primary "+ 
			"Network is "+ 
			"set to: "+ 
			"Installed and Connected to "+ 
			"a Live Ethernet Network Then, the Active Print "+ 
			"Server will be: "+ 
			"Internal External Wireless "+ 
			"u "+ 
			"Wired "+ 
			"XX X Internal "+ 
			"XX External "+ 
			"X Wireless "+ 
			"Wireless "+ 
			"X X X Wireless "+ 
			"XX Internal "+ 
			"XExternal "+ 
			"u. A wireless option board must have an active radio that can properly associate to an access point. "+ 
			"Parameters Details "+ 
			"a = primary "+ 
			"network "+ 
			"device "+ 
			"Values: "+ 
			"1 = wired primary "+ 
			"2 = wireless primary "+ 
			"Default: 1 "+ 
			"must be an accepted value or it is ignored "+ 
			" "+ 
			"281 "+ 
			"ZPL Commands "+ 
			"~NC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
