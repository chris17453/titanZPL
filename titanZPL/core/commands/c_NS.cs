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
    public class zpl_cmd_c_NS : zpl_command{   //Change Wired Networking Settings
        public string ip_resolution                                                = String.Empty;
        public string ip_address                                                   = String.Empty;
        public string c                                                            = String.Empty;
        public string d                                                            = String.Empty;
        public string e                                                            = String.Empty;
        public string f                                                            = String.Empty;
        public string timeout_value_time                                           = String.Empty;
        public string arp_broadcast_interval_time                                  = String.Empty;
        public string base_raw_port_number_the_port_number_that_the_printer_should_use_for_its_raw_data = String.Empty;
                                        
        public zpl_cmd_c_NS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^NS";                   
            description="Change Wired Networking Settings";                   
            data_format="a,b,c,d,e,f,g,h,i ";                   
            example    ="^XA"+
			            "^NSa,192.168.0.1,255.255.255.0,192.168.0.2"+
			            "^XZ";                   
            ip_resolution                                               =(string)argument(0,data,"s","                   ",""," ");
            ip_address                                                  =(string)argument(1,data,"s","                   ",""," ");
            c                                                           =(string)argument(2,data,"s","                   ",""," ");
            d                                                           =(string)argument(3,data,"s","                   ",""," ");
            e                                                           =(string)argument(4,data,"s","                   ",""," ");
            f                                                           =(string)argument(5,data,"s","                   ",""," ");
            timeout_value_time                                          =(string)argument(6,data,"s","                   ",""," ");
            arp_broadcast_interval_time                                 =(string)argument(7,data,"s","                   ",""," ");
            base_raw_port_number_the_port_number_that_the_printer_should_use_for_its_raw_data=(string)argument(8,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =IP_resolution //
A=ALL B=BOOTP C = DHCP AND BOOTP D= DHCP G = GLEANING ONLY R = RARP P=PERMANENT  //A Use of GLEANING ONLY is not recommended when the Wireless Print Server or Wireless Plus Print Server is installed. 
	
b =IP_address //Any properly formatted IP address in the xxx.xxx.xxx.xxx format. c = subnet mask Values: Any properly formatted subnet mask in the xxx.xxx.xxx.xxx format. d = default gateway Values: Any properly formatted gateway in the xxx.xxx.xxx.xxx format. e = WINS server address Values: Any properly formatted WINS server in the xxx.xxx.xxx.xxx format. f = connection timeout checking Values: Y = Yes N = No  //Y 
	
g =timeout_value_Time //0 through 9999  //300 
	
h =ARP_broadcast_interval_Time //0 through 30  //0 (no ARP sent) 
	
i =base_raw_port_number_The_port_number_that_the_printer_should_use_for_its_RAW_data //1 through 65535  //910
                                       
  **************************************************/ 
            manual=""+ 
			"^NS – Change Wired Networking Settings "+ 
			"Use this command to change the wired print server network settings. "+ 
			"Format: ^NSa,b,c,d,e,f,g,h,i "+ 
			"Comments For the Xi4, RXI4, ZM400/ZM600, and RZ400/RZ600 printers, Zebra recommends "+ 
			"that you use the "+ 
			"^ND command instead of the ^NS command. "+ 
			"Parameters Details "+ 
			"a = IP resolution "+ 
			"Values: "+ 
			"A=ALL "+ 
			"B=BOOTP "+ 
			"C = DHCP AND BOOTP "+ 
			"D= DHCP "+ 
			"G = GLEANING ONLY "+ 
			"R = RARP "+ 
			"P=PERMANENT "+ 
			"Default: A "+ 
			"Use of GLEANING ONLY is not recommended when the Wireless Print Server or "+ 
			"Wireless Plus Print Server is installed. "+ 
			"b = IP address "+ 
			"Values: Any properly formatted IP address in the xxx.xxx.xxx.xxx format. "+ 
			"c = subnet mask "+ 
			"Values: Any properly formatted subnet mask in the xxx.xxx.xxx.xxx format. "+ 
			"d = default gateway "+ 
			"Values: Any properly formatted gateway in the xxx.xxx.xxx.xxx format. "+ 
			"e = WINS server "+ 
			"address "+ 
			"Values: Any properly formatted WINS server in the xxx.xxx.xxx.xxx format. "+ 
			"f = connection "+ 
			"timeout checking "+ 
			"Values: "+ 
			"Y = Yes "+ 
			"N = No "+ 
			"Default: Y "+ 
			"g = timeout value "+ 
			"Time, in seconds, before the connection times out. "+ 
			"Values: 0 through 9999 "+ 
			"Default: 300 "+ 
			"h = ARP broadcast "+ 
			"interval "+ 
			"Time, in minutes, that the broadcast is sent to update the device’s ARP cache. "+ 
			"Values: 0 through 30 "+ 
			"Default: 0 (no ARP sent) "+ 
			"i = base raw port "+ 
			"number "+ 
			"The port number that the printer should use for its RAW data. "+ 
			"Values: 1 through 65535 "+ 
			"Default: 9100 "+ 
			"Example: "+ 
			"^XA "+ 
			"^NSa,192.168.0.1,255.255.255.0,192.168.0.2 "+ 
			"^XZ "+ 
			" "+ 
			"287 "+ 
			"ZPL Commands "+ 
			"~NT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
