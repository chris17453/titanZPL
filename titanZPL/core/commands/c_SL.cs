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
    public class zpl_cmd_c_SL : zpl_command{   //Set Mode and Language (for Real-Time Clock)
        public string mode                                                         = String.Empty;
        public string b                                                            = String.Empty;
                                        
        public zpl_cmd_c_SL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SL";                   
            description="Set Mode and Language (for Real-Time Clock)";                   
            data_format="a,b ";                   
            example    ="";                   
            mode                                                        =(string)argument(0,data,"s","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =mode // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^SL – Set Mode and Language (for Real-Time Clock) "+ 
			"The ^SL command is used to specify the Real-Time Clock’s mode of operation and language for "+ 
			"printing information. "+ 
			"Comments These are some comments to be aware of: "+ 
			"• The ^SL command must be placed before the first ^FO command. "+ 
			"Important • "+ 
			"• Time is read when the image is created. If the image stays in the queue longer than the "+ 
			"specified time the image will be recreated with a new time. "+ 
			"• There are incidents when the same time or a larger space of time may be printed on labels. "+ 
			"This is due to the format complexity and print speed. "+ 
			"Format: ^SLa,b "+ 
			"Parameters Details "+ 
			"a = mode "+ 
			"Values: "+ 
			"S = Start Time Mode. This is the time that is read from the Real-Time "+ 
			"Clock when label formatting begins (when "+ 
			"^XA is received). The first "+ 
			"label has the same time placed on it as the last label. "+ 
			"T = Time Now Mode. This is the time that is read from the Real-Time "+ 
			"Clock when the label to be printed is placed in print queue. Time "+ 
			"Now is similar to a serialized time or date field. "+ 
			"Numeric Value = With the Enhanced Real Time Clock (V60.13.0.10 or "+ 
			"later) a time accuracy tolerance can be specified. Range = 1 to 999 "+ 
			"seconds, 0 = one second tolerance "+ 
			"Example: SL30,1 = Accuracy tolerance of 30 seconds and use English. "+ 
			"Default: S "+ 
			"b = language "+ 
			"Value 13 is only supported in "+ 
			"firmware versions V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			"Values: "+ 
			"1 = English "+ 
			"2 = Spanish "+ 
			"3 = French "+ 
			"4 = German "+ 
			"5 = Italian "+ 
			"6 = Norwegian "+ 
			"7 = Portuguese "+ 
			"8 = Swedish "+ 
			"9 = Danish "+ 
			"10 = Spanish 2 "+ 
			"11 = Dutch "+ 
			"12 = Finnish "+ 
			"1 "+ 
			"3 = Japanese "+ 
			"14 = Korean "+ 
			"aa "+ 
			"15 = Simplified Chinese "+ 
			"aa "+ 
			"16 = Traditional Chinese "+ 
			"aa "+ 
			"17 = Russian "+ 
			"aa "+ 
			"18 = Polish "+ 
			"aa "+ 
			"Default: the language selected with ^KL or the control panel "+ 
			"aa.These values are only supported on the Xi4, RXi4, ZM400/ZM600, and RZ400/RZ600 printers. "+ 
			" "+ 
			"311 "+ 
			"ZPL Commands "+ 
			"^SL "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"• As of V60.13.0.10 all supported printers have Enhanced Real Time Clock capabilities the RTC "+ 
			"will not print time fields that are more than sixty seconds old, rather it will update the time prior to "+ 
			"printing (^SLT or ^SL60). To control time with increments other than sixty seconds the ^SL "+ 
			"command can be used with a numeric value ( "+ 
			"^SL30). "+ 
			"^SLS can keep times longer than sixty seconds. "+ 
			"For more details on set mode and language with the Real-Time Clock, see Real Time Clock "+ 
			"on page 1325. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SN "+ 
			"312 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
