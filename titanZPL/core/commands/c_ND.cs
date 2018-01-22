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
    public class zpl_cmd_c_ND : zpl_command{   //Change Network Settings
        public string device                                                       = String.Empty;
        public string b                                                            = String.Empty;
        public string ip_address                                                   = String.Empty;
        public string d                                                            = String.Empty;
        public string e                                                            = String.Empty;
        public string f                                                            = String.Empty;
        public string g                                                            = String.Empty;
        public string timeout_value_time                                           = String.Empty;
        public string arp_broadcast_interval_time                                  = String.Empty;
        public string base_raw_port_number_the_port_number_that_the_printer_should_use_for_its_raw_data = String.Empty;
                                        
        public zpl_cmd_c_ND(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^ND";                   
            description="Change Network Settings";                   
            data_format="a,b,c,d,e,f,g,h,i,j ";                   
            example    ="";                   
            device                                                      =(string)argument(0,data,"s","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
            ip_address                                                  =(string)argument(2,data,"s","                   ",""," ");
            d                                                           =(string)argument(3,data,"s","                   ",""," ");
            e                                                           =(string)argument(4,data,"s","                   ",""," ");
            f                                                           =(string)argument(5,data,"s","                   ",""," ");
            g                                                           =(string)argument(6,data,"s","                   ",""," ");
            timeout_value_time                                          =(string)argument(7,data,"s","                   ",""," ");
            arp_broadcast_interval_time                                 =(string)argument(8,data,"s","                   ",""," ");
            base_raw_port_number_the_port_number_that_the_printer_should_use_for_its_raw_data=(string)argument(9,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =the_device_that_is_being_modified //
1 = external wired 2 = internal wired 3 = wireless b = IP resolution Values: A =All B =BOOTP C = DHCP and BOOTP D =DHCP G = Gleaning only (Not recommended when the Wireless Print Server or Wireless Plus Print Server is installed.) R =RARP P =Permanent  //A 
	
c =IP_address //Any properly formatted IP address in the xxx.xxx.xxx.xxx format. d = subnet mask Values: Any properly formatted subnet mask in the xxx.xxx.xxx.xxx format. e = default gateway Values: Any properly formatted gateway in the xxx.xxx.xxx.xxx format. f = WINS server address Values: Any properly formatted WINS server in the xxx.xxx.xxx.xxx format. g = connection timeout checking Values: Y = yes N = no  //Y 
	
h =timeout_value_Time //0 through 9999  //300 
	
i =ARP_broadcast_interval_Time //0 through 30  //0 (no ARP sent)  283 ZPL Commands ^ND 11/21/16 Zebra Programming Guide P1012728-011 
	
j =base_raw_port_number_The_port_number_that_the_printer_should_use_for_its_RAW_data //1 through 65535  //9100 Parameters Details  ZPL Commands ^NI 284 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^ND – Change Network Settings "+ 
			"The ^ND command changes the network settings on supported printers. "+ 
			"For the external wired print server settings, the "+ 
			"^ND command is the same as the ^NS command. "+ 
			"For the wireless print server settings, the "+ 
			"^ND command is the same as the ^WI command. "+ 
			"Supported Devices "+ 
			"• Xi4 with firmware V53.17.1Z or later "+ 
			"•RXi4 "+ 
			"• RZ400/RZ600 with firmware R53.15.xZ or later "+ 
			"• ZM400/ZM600 with firmware V53.15.xZ or later "+ 
			"•G-Series "+ 
			"Format: ^NDa,b,c,d,e,f,g,h,i,j "+ 
			"Parameters Details "+ 
			"a = the device "+ 
			"that is being "+ 
			"modified "+ 
			"Values: "+ 
			"1 = external wired "+ 
			"2 = internal wired "+ 
			"3 = wireless "+ 
			"b = IP resolution "+ 
			"Values: "+ 
			"A =All "+ 
			"B =BOOTP "+ 
			"C = DHCP and BOOTP "+ 
			"D =DHCP "+ 
			"G = Gleaning only (Not recommended when the Wireless Print Server or "+ 
			"Wireless Plus Print Server is installed.) "+ 
			"R =RARP "+ 
			"P =Permanent "+ 
			"Default: A "+ 
			"c = IP address "+ 
			"Values: Any properly formatted IP address in the xxx.xxx.xxx.xxx format. "+ 
			"d = subnet mask "+ 
			"Values: Any properly formatted subnet mask in the xxx.xxx.xxx.xxx format. "+ 
			"e = default "+ 
			"gateway "+ 
			"Values: Any properly formatted gateway in the xxx.xxx.xxx.xxx format. "+ 
			"f = WINS server "+ 
			"address "+ 
			"Values: Any properly formatted WINS server in the xxx.xxx.xxx.xxx format. "+ 
			"g = connection "+ 
			"timeout "+ 
			"checking "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: Y "+ 
			"h = timeout value "+ 
			"Time, in seconds, before the connection times out. "+ 
			"Values: 0 through 9999 "+ 
			"Default: 300 "+ 
			"i = ARP broadcast "+ 
			"interval "+ 
			"Time, in minutes, that the broadcast is sent to update the device’s ARP cache. "+ 
			"Values: 0 through 30 "+ 
			"Default: 0 (no ARP sent) "+ 
			" "+ 
			"283 "+ 
			"ZPL Commands "+ 
			"^ND "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"j = base raw port "+ 
			"number "+ 
			"The port number that the printer should use for its RAW data. "+ 
			"Values: 1 through 65535 "+ 
			"Default: 9100 "+ 
			"Parameters Details "+ 
			" "+ 
			"ZPL Commands "+ 
			"^NI "+ 
			"284 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
