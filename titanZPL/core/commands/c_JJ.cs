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
    public class zpl_cmd_c_JJ : zpl_command{   //Set Auxiliary Port
        public string auxiliary_port_mode                                          = String.Empty;
        public string application_mode                                             = String.Empty;
        public string application_mode_start_signal_print                          = String.Empty;
        public string application_label_error_mode                                 = String.Empty;
        public string reprint_mode                                                 = String.Empty;
        public string ribbon_low_mode                                              = String.Empty;
                                        
        public zpl_cmd_c_JJ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JJ";                   
            description="Set Auxiliary Port";                   
            data_format="a,b,c,d,e,f ";                   
            example    ="";                   
            auxiliary_port_mode                                         =(string)argument(0,data,"s","                   ",""," ");
            application_mode                                            =(string)argument(1,data,"s","                   ",""," ");
            application_mode_start_signal_print                         =(string)argument(2,data,"s","                   ",""," ");
            application_label_error_mode                                =(string)argument(3,data,"s","                   ",""," ");
            reprint_mode                                                =(string)argument(4,data,"s","                   ",""," ");
            ribbon_low_mode                                             =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =operational_mode_for_auxiliary_port //
0 = off 1 = reprint on error—the printer stops on a label with a verification error. When PAUSE is pressed, the label reprints (if ^JZ is set to reprint). If a bar code is near the upper edge of a label, the label feeds out far enough for the bar code to be verified and then backfeeds to allow the next label to be printed and verified. 2 = maximum throughput—the printer stops when a verification error is detected. The printer starts printing the next label while the verifier is still checking the previous label. This mode provides maximum throughput, but does not allow the printer to stop immediately on a label with a verification error.  //0 
	
b =application_mode //
0 = off 1 = End Print signal normally high, and low only when the printer is moving the label forward. 2 = End Print signal normally low, and high only when the printer is moving the label forward. 3 = End Print signal normally high, and low for 20 ms when a label has been printed and positioned. 4 = End Print signal normally low, and high for 20 ms when a label has been printed and positioned.  //0 Note • The Set/Get/Do command device.applicator.end_print on page 617 controls the same setting as the b parameter. 
	
c =application_mode_start_signal_print //
p = Pulse Mode – Start Print signal must be de-asserted before it can be asserted for the next label. l = Level Mode – Start Print signal does not need to be de-asserted to print the next label. As long as the Start Print signal is low and a label is formatted, a label prints.  //0 
	
d =application_label_error_mode //
e = error mode—the printer asserts the Service Required signal (svce_req - pin 10) on the application port, enters into Pause Mode, and displays an error message on the LCD. f = Feed Mode—a blank label prints when the web is not found where expected to sync the printer to the media.  //f  235 ZPL Commands ^JJ 11/21/16 Zebra Programming Guide P1012728-011 
	
e =reprint_mode //
e = enabled—the last label reprints after the signal is asserted. If a label is canceled, the label to be reprinted is also canceled. This mode consumes more memory because the last printed label is not released until it reprints. d = disabled—printer ignores the Reprint signal.  //d 
	
f =ribbon_low_mode //
e = enabled – printer warning issued when ribbon low. d = disabled – printer warning not issued when ribbon low.  //e Parameters Details  ZPL Commands ~JL 236 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^JJ – Set Auxiliary Port "+ 
			"The ^JJ command allows you to control an online verifier or applicator device. "+ 
			"Format: ^JJa,b,c,d,e,f "+ 
			"Parameters Details "+ 
			"a = operational mode "+ 
			"for auxiliary "+ 
			"port "+ 
			"Values: "+ 
			"0 = off "+ 
			"1 = reprint on error—the printer stops on a label with a verification error. "+ 
			"When "+ 
			"PAUSE is pressed, the label reprints (if ^JZ is set to reprint). "+ 
			"If a bar code is near the upper edge of a label, the label feeds out far "+ 
			"enough for the bar code to be verified and then backfeeds to allow "+ 
			"the next label to be printed and verified. "+ 
			"2 = maximum throughput—the printer stops when a verification error is "+ 
			"detected. The printer starts printing the next label while the verifier "+ 
			"is still checking the previous label. This mode provides maximum "+ 
			"throughput, but does not allow the printer to stop immediately on a "+ 
			"label with a verification error. "+ 
			"Default: 0 "+ 
			"b = application mode "+ 
			"Values: "+ 
			"0 = off "+ 
			"1 = End Print signal normally high, and low only when the printer is "+ 
			"moving the label forward. "+ 
			"2 = End Print signal normally low, and high only when the printer is "+ 
			"moving the label forward. "+ 
			"3 = End Print signal normally high, and low for 20 ms when a label has "+ 
			"been printed and positioned. "+ 
			"4 = End Print signal normally low, and high for 20 ms when a label has "+ 
			"been printed and positioned. "+ 
			"Default: 0 "+ 
			"Note • The Set/Get/Do command device.applicator.end_print on page 617 "+ 
			"controls the same setting as the b parameter. "+ 
			"c = application mode "+ 
			"start signal "+ 
			"print "+ 
			"Values: "+ 
			"p = Pulse Mode – Start Print signal must be de-asserted before it can be "+ 
			"asserted for the next label. "+ 
			"l = Level Mode – Start Print signal does not need to be de-asserted to "+ 
			"print the next label. As long as the Start Print signal is low and a "+ 
			"label is formatted, a label prints. "+ 
			"Default: 0 "+ 
			"d = application label "+ 
			"error mode "+ 
			"Values: "+ 
			"e = error mode—the printer asserts the Service Required signal (svce_req "+ 
			"- pin 10) on the application port, enters into Pause Mode, and "+ 
			"displays an error message on the LCD. "+ 
			"f = Feed Mode—a blank label prints when the web is not found where "+ 
			"expected to sync the printer to the media. "+ 
			"Default: f "+ 
			" "+ 
			"235 "+ 
			"ZPL Commands "+ 
			"^JJ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"e = reprint mode "+ 
			"Values: "+ 
			"e = enabled—the last label reprints after the signal is asserted. If a label "+ 
			"is canceled, the label to be reprinted is also canceled. This mode "+ 
			"consumes more memory because the last printed label is not "+ 
			"released until it reprints. "+ 
			"d = disabled—printer ignores the Reprint signal. "+ 
			"Default: d "+ 
			"f = ribbon low mode "+ 
			"Values: "+ 
			"e = enabled – printer warning issued when ribbon low. "+ 
			"d = disabled – printer warning not issued when ribbon low. "+ 
			"Default: e "+ 
			"Parameters Details "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JL "+ 
			"236 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
