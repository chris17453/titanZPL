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
    public class zpl_cmd_c_SC : zpl_command{   //Set Serial Communications
        public string baud_rate                                                    = String.Empty;
        public string word_length                                                  = String.Empty;
        public string parity                                                       = String.Empty;
        public string stop_bits                                                    = String.Empty;
        public string protocol_mode                                                = String.Empty;
        public string zebra_protocol                                               = String.Empty;
                                        
        public zpl_cmd_c_SC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SC";                   
            description="Set Serial Communications";                   
            data_format="a,b,c,d,e,f ";                   
            example    ="";                   
            baud_rate                                                   =(string)argument(0,data,"s","                   ",""," ");
            word_length                                                 =(string)argument(1,data,"s","                   ",""," ");
            parity                                                      =(string)argument(2,data,"s","                   ",""," ");
            stop_bits                                                   =(string)argument(3,data,"s","                   ",""," ");
            protocol_mode                                               =(string)argument(4,data,"s","                   ",""," ");
            zebra_protocol                                              =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =baud_rate //110 y ; 300; 600; 1200; 2400; 4800; 9600; 14400; 19200; 28800; 38400; or 57600; 115200  //must be specified or the parameter is ignored 
	
b =word_length //7 or 8  //must be specified 
	
c =parity //N (none), E (even), or O (odd)  //must be specified 
	
d =stop_bits //1 or 2  //must be specified 
	
e =protocol_mode //
X = XON/XOFF D = DTR/DSR R = RTS M = DTR/DSR XON/XOFF z  //must be specified 
	
f =Zebra_protocol //
A = ACK/NAK N = none Z = Zebra  //must be specified y. This value is not supported on Xi4, RXi4, ZM400/ZM600, RZ400/RZ600, and S4M printers. z. This parameter is supported only on G-Series printers. Using the DTR/DSR XON/XOFF mode will cause the printer to respond to either DTR/DSR or XON/XOFF, depending on which method is first received from the host device.  ZPL Commands ~SD 304 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^SC – Set Serial Communications "+ 
			"The ^SC command allows you to change the serial communications parameters you are using. "+ 
			"Format: ^SCa,b,c,d,e,f "+ 
			"Comments If any of the parameters are missing, out of specification, not supported by a "+ 
			"particular printer, or have a ZPL-override DIP switch set, the command is ignored. "+ 
			"A ^JUS command causes the changes in Communications Mode to persist through power-up and "+ 
			"software resets. "+ 
			"Parameters Details "+ 
			"a = baud rate "+ 
			"Values: 110 "+ 
			"y "+ 
			"; 300; 600; 1200; 2400; 4800; 9600; 14400; 19200; 28800; 38400; or "+ 
			"57600; 115200 "+ 
			"Default: must be specified or the parameter is ignored "+ 
			"b = word length (in "+ 
			"data bits) "+ 
			"Values: 7 or 8 "+ 
			"Default: must be specified "+ 
			"c = parity "+ 
			"Values: N (none), E (even), or O (odd) "+ 
			"Default: must be specified "+ 
			"d = stop bits "+ 
			"Values: 1 or 2 "+ 
			"Default: must be specified "+ 
			"e = protocol mode "+ 
			"Values: "+ 
			"X = XON/XOFF "+ 
			"D = DTR/DSR "+ 
			"R = RTS "+ 
			"M = DTR/DSR XON/XOFF "+ 
			"z "+ 
			"Default: must be specified "+ 
			"f = Zebra protocol "+ 
			"Values: "+ 
			"A = ACK/NAK "+ 
			"N = none "+ 
			"Z = Zebra "+ 
			"Default: must be specified "+ 
			"y. This value is not supported on Xi4, RXi4, ZM400/ZM600, RZ400/RZ600, and S4M printers. "+ 
			"z. This parameter is supported only on G-Series printers. Using the DTR/DSR XON/XOFF mode will cause the printer to respond "+ 
			"to either DTR/DSR or XON/XOFF, depending on which method is first received from the host device. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~SD "+ 
			"304 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
