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
    public class zpl_cmd_c_SX : zpl_command{   //Set ZebraNet Alert
        public string condition_type                                               = String.Empty;
        public string destination_for_route_alert                                  = String.Empty;
        public string set_alert                                                    = String.Empty;
        public string d                                                            = String.Empty;
        public string e                                                            = String.Empty;
        public string f                                                            = String.Empty;
                                        
        public zpl_cmd_c_SX(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SX";                   
            description="Set ZebraNet Alert";                   
            data_format="a,b,c,d,e,f ";                   
            example    ="";                   
            condition_type                                              =(string)argument(0,data,"s","                   ",""," ");
            destination_for_route_alert                                 =(string)argument(1,data,"s","                   ",""," ");
            set_alert                                                   =(string)argument(2,data,"s","                   ",""," ");
            d                                                           =(string)argument(3,data,"s","                   ",""," ");
            e                                                           =(string)argument(4,data,"s","                   ",""," ");
            f                                                           =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =condition_type //
A = paper out B = ribbon out C = printhead over-temp D = printhead under-temp E = head open F = power supply over-temp G = ribbon-in warning (Direct Thermal Mode) H = rewind full I = cut error J = printer paused K = PQ job completed L = label ready M = head element out N = ZBI (Zebra BASIC Interpreter) runtime error O = ZBI (Zebra BASIC Interpreter) forced error P = power on Q = clean printhead R = media low S = ribbon low T = replace head U = battery low V = RFID error (in RFID printers only) * = all errors  //if the parameter is missing or invalid, the command is ignored 
	
b =destination_for_route_alert //
A = serial port B* = parallel port C = e-mail address D = TCP/IP E = UDP/IP F = SNMP trap  //If this parameter is missing or invalid, the command is ignored. * Requires bidirectional communication. 
	
c =enable_condition_set_alert_to_this_destination // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^SX – Set ZebraNet Alert "+ 
			"The ^SX command is used to configure the ZebraNet Alert System. "+ 
			"Format: ^SXa,b,c,d,e,f "+ 
			"Note • The values in this table apply to firmware version V48.12.4 or later. "+ 
			"Parameters Details "+ 
			"a = condition type "+ 
			"Values: "+ 
			"A = paper out "+ 
			"B = ribbon out "+ 
			"C = printhead over-temp "+ 
			"D = printhead under-temp "+ 
			"E = head open "+ 
			"F = power supply over-temp "+ 
			"G = ribbon-in warning (Direct Thermal Mode) "+ 
			"H = rewind full "+ 
			"I = cut error "+ 
			"J = printer paused "+ 
			"K = PQ job completed "+ 
			"L = label ready "+ 
			"M = head element out "+ 
			"N = ZBI (Zebra BASIC Interpreter) runtime error "+ 
			"O = ZBI (Zebra BASIC Interpreter) forced error "+ 
			"P = power on "+ 
			"Q = clean printhead "+ 
			"R = media low "+ 
			"S = ribbon low "+ 
			"T = replace head "+ 
			"U = battery low "+ 
			"V = RFID error (in RFID printers only) "+ 
			"* = all errors "+ 
			"Default: if the parameter is missing or invalid, the command is ignored "+ 
			"b = destination for "+ 
			"route alert "+ 
			"Values: "+ 
			"A = serial port "+ 
			"B* = parallel port "+ 
			"C = e-mail address "+ 
			"D = TCP/IP "+ 
			"E = UDP/IP "+ 
			"F = SNMP trap "+ 
			"Default: If this parameter is missing or invalid, the command is ignored. "+ 
			"* Requires bidirectional communication. "+ 
			"c = enable condition "+ 
			"set alert to "+ 
			"this destination "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Values: "+ 
			"Y or previously configured value "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SX "+ 
			"322 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments In the example above for SNMP Trap, entering 255.255.255.255 broadcasts the "+ 
			"notification to every SNMP manager on the network. To route the device to a single SNMP "+ 
			"manager, enter a specific address (123.45.67.89). "+ 
			"d = enable condition "+ 
			"clear alert to "+ 
			"this destination "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Values: "+ 
			"N or previously configured value "+ 
			"Parameters e and f are sub-options based on destination. If the sub-options are "+ 
			"missing or invalid, these parameters are ignored. "+ 
			"e = destination "+ 
			"setting "+ 
			"Values: "+ 
			"Internet e-mail address (e.g. user@company.com) "+ 
			"IP address (for example, 10.1.2.123) "+ 
			"SNMP trap "+ 
			"IP or IPX addresses "+ 
			"f = port number "+ 
			"Values: "+ 
			"TCP port # ( "+ 
			"0 to 65535) "+ 
			"UPD port # ( "+ 
			"0 to 65535) "+ 
			"Parameters Details "+ 
			"Example: This is an example of the different (b) destinations that you can send for the condition "+ 
			"type (a): "+ 
			"Serial: "+ 
			"^SXA,A,Y,Y "+ 
			"Parallel: ^SXA,B,Y,Y "+ 
			"E-Mail: ^SXA,C,Y,Y,admin@company.com "+ 
			"TCP: ^SXA,D,Y,Y,123.45.67.89,1234 "+ 
			"UDP: ^SXA,E,Y,Y,123.45.67.89,1234 "+ 
			"SNMP Trap: ^SXA,F,Y,Y,255.255.255.255 "+ 
			" "+ 
			"323 "+ 
			"ZPL Commands "+ 
			"^SZ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
