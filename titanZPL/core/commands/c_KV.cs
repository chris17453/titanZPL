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
    public class zpl_cmd_c_KV : zpl_command{   //Kiosk Values
        public string kiosk_cut_amount                                             = String.Empty;
        public string kiosk_cut_margin                                             = String.Empty;
        public string c                                                            = String.Empty;
        public string kiosk_present_timeout                                        = String.Empty;
        public string presenter_loop_length                                        = String.Empty;
                                        
        public zpl_cmd_c_KV(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^KV";                   
            description="Kiosk Values";                   
            data_format="a,b,c,d,e ";                   
            example    ="";                   
            kiosk_cut_amount                                            =(string)argument(0,data,"s","                   ",""," ");
            kiosk_cut_margin                                            =(string)argument(1,data,"s","                   ",""," ");
            c                                                           =(string)argument(2,data,"s","                   ",""," ");
            kiosk_present_timeout                                       =(string)argument(3,data,"s","                   ",""," ");
            presenter_loop_length                                       =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =kiosk_cut_amount //
0 = normal cut 10-60 = partial cut, value = mm of media left uncut  //0 This parameter is ignored if it is missing or invalid. The current value of the parameter remains unchanged. 
	
b =kiosk_cut_margin //
2 - 9 = mm of distance  //

	
9 =mm_of_distance_This_parameter_is_ignored_if_it_is_missing_or_invalid //
0 = Eject page when new page is printed 1 = Retract page when new page is printed 2 = Do nothing when new page is printed  //0 This parameter is ignored if it is missing or invalid. The current value of the parameter remains unchanged. 
	
d =kiosk_present_timeout //
0–300 = If label is not taken, retract label when timeout expires. Timeout is in seconds. Zero (0) indicates that there is no timeout. The label will stay presented until removed manually or a new label is printed.  //0 This parameter is ignored if it is missing or invalid. The current value of the parameter remains unchanged. 
	
e =presenter_loop_length //
0 = paper is fed straight through the presenter 3-1023 = loop length in mm.  //400 4
	400=gives_a_loop_of_approximately_400mm // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^KV – Kiosk Values "+ 
			"The ^KV command sets several parameters that affect the printers operation when ^MM is set to K - "+ 
			"Kiosk mode "+ 
			"Supported Devices "+ 
			"•KR403 "+ 
			"Format: ^KVa,b,c,d,e "+ 
			"Parameters Details "+ 
			"a = kiosk cut amount "+ 
			"Values: "+ 
			"0 = normal cut "+ 
			"10-60 = partial cut, value = mm of media left uncut "+ 
			"Default: 0 "+ 
			"This parameter is ignored if it is missing or invalid. The current value of the "+ 
			"parameter remains unchanged. "+ 
			"b = kiosk cut margin "+ 
			"Values: "+ 
			"2 - 9 = mm of distance "+ 
			"Default: "+ 
			"9 = mm of distance "+ 
			"This parameter is ignored if it is missing or invalid. The current value of the "+ 
			"parameter remains unchanged. "+ 
			"c = kiosk present type "+ 
			"Values: "+ 
			"0 = Eject page when new page is printed "+ 
			"1 = Retract page when new page is printed "+ 
			"2 = Do nothing when new page is printed "+ 
			"Default: 0 "+ 
			"This parameter is ignored if it is missing or invalid. The current value of the "+ 
			"parameter remains unchanged. "+ 
			"d = kiosk present timeout "+ 
			"Values: "+ 
			"0–300 = If label is not taken, retract label when timeout expires. Timeout is in "+ 
			"seconds. Zero (0) indicates that there is no timeout. The label will stay presented "+ 
			"until removed manually or a new label is printed. "+ 
			"Default: 0 "+ 
			"This parameter is ignored if it is missing or invalid. The current value of the "+ 
			"parameter remains unchanged. "+ 
			"e = presenter loop length "+ 
			"Values: "+ 
			"0 = paper is fed straight through the presenter "+ 
			"3-1023 = loop length in mm. "+ 
			"Default: 400 "+ 
			"400= gives a loop of approximately 400mm "+ 
			"This parameter is ignored if it is missing or invalid. The current value of the "+ 
			"parameter remains unchanged. . If this is greater than loop_length_max (see "+ 
			"SGD media.present.loop_length_max) then it will be set equal to "+ 
			"loop_length_max. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^KV "+ 
			"256 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Kiosk Printing Examples "+ 
			"The following examples demonstrate the use of the ^KV, ^CN, ^PN and ^CP commands with 80mm "+ 
			"wide continuous media and the printer set to Kiosk Mode (^MMK). "+ 
			"Example 1: In this example, the ^KV command is set to the following: "+ 
			"• Cut - Full Cut "+ 
			"• Cut Margin - 9 mm "+ 
			"• Present Type - Eject page when the next page is printed "+ 
			"• Present Timeout - 6 seconds after printing, if the document is not taken, it will be retracted "+ 
			"• Presenter Loop Length - No loop "+ 
			"^XA "+ 
			"^MMK "+ 
			"^KV0,9,0,6,0 "+ 
			"^FO50,50^A0N,50,50^FDZebra Technologies^FS "+ 
			"^CN1 "+ 
			"^PN0 "+ 
			"^XZ "+ 
			"Note • "+ 
			"The ^CN1 command (Cut Now) is included to ensure that a full cut is done. The ^PN0 "+ 
			"(Present Now) command is included to ensure that the media is ejected when the user pulls on the "+ 
			"leading edge of the media. In this example, if the user does not pull on the leading edge of the "+ 
			"second document, it will be retracted. "+ 
			"Example 2: This example contains only one change from the Example 1 - the Presenter Loop "+ 
			"Length is now 100mm, and two documents will be printed instead of one. "+ 
			"^XA "+ 
			"^MMK "+ 
			"^KV0,9,2,6,100 "+ 
			"^FO50,50^A0N,50,50^FDZebra Technologies^FS "+ 
			"^CN1^PN0 "+ 
			"^PQ2 "+ 
			"^XZ "+ 
			"Example 3: In this example, two documents will be printed, each one will be ejected from the "+ 
			"printer. "+ 
			"^XA "+ 
			"^MMK "+ 
			"^KV0,9,2,6,100 "+ 
			"^FO50,50^A0N,50,50^FDZebra Technologies^FS "+ 
			"^CN1^CP0 "+ 
			"^PQ2 "+ 
			"^XZ "+ 
			" "+ 
			"257 "+ 
			"ZPL Commands "+ 
			"^KV "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example 4: In this example, two documents, with partial cuts, will be printed, and a third "+ 
			"document, with a full cut, will be printed. "+ 
			"^XA "+ 
			"^MMK "+ 
			"^KV50,9,0,0,0 "+ 
			"^FO50,50^A0N,50,50^FDPartial Cut^FS "+ 
			"^CN0^PN0 "+ 
			"^PQ2 "+ 
			"^XZ "+ 
			"^XA "+ 
			"^MMK "+ 
			"^KV0,9,2,6,0 "+ 
			"^FO50,50^A0N,50,50^FDFull Cut^FS "+ 
			"^CN1^CP0 "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^KV "+ 
			"258 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example 5: In this example, four documents will be printed – three with a partial cut and the "+ 
			"fourth with a full cut. Additionally, the document length is set to 406 dots and the Media "+ 
			"Tracking mode is set to 'Continuous Media, Variable Length'. The third document contains "+ 
			"fields that are positioned outside of the 406 dot length – however, because the printer is set "+ 
			"to “Continuous Media, Variable Length' Media Tracking mode, the printer will automatically "+ 
			"adjust the document length to compensate. "+ 
			"^XA "+ 
			"^MMK "+ 
			"^LL406 "+ 
			"^KV20,9,0,0,0 "+ 
			"^FO50,50^A0N,50,50^FDPartial Cut^FS "+ 
			"^CN0^PN0 "+ 
			"^PQ2 "+ 
			"^XZ "+ 
			"^XA "+ 
			"^MMK "+ 
			"^MNV "+ 
			"^KV20,9,0,0,0 "+ 
			"^FO50,50^A0N,50,50^FDPartial Cut^FS "+ 
			"^FO50,150^A0N,50,50^FDPrinting Line 1^FS "+ 
			"^FO50,250^A0N,50,50^FDPrinting Line 2^FS "+ 
			"^FO50,350^A0N,50,50^FDPrinting Line 3^FS "+ 
			"^FO50,450^A0N,50,50^FDPrinting Line 4^FS "+ 
			"^FO50,550^A0N,50,50^FDPrinting Line 5^FS "+ 
			"^FO50,650^A0N,50,50^FDPrinting Line 6^FS "+ 
			"^FO50,750^A0N,50,50^FDPrinting Line 7^FS "+ 
			"^FO50,850^A0N,50,50^FDPrinting Line 8^FS "+ 
			"^FO50,950^A0N,50,50^FDPrinting Line 9^FS "+ 
			"^FO50,1050^A0N,50,50^FDPrinting Line 10^FS "+ 
			"^FO50,1150^A0N,50,50^FDPrinting Line 11^FS "+ 
			"^FO50,1250^A0N,50,50^FDPrinting Line 12^FS "+ 
			"^FO50,1350^A0N,50,50^FDPrinting Line 13^FS "+ 
			"^FO50,1450^A0N,50,50^FDPrinting Line 14^FS "+ 
			"^FO50,1550^A0N,50,50^FDPrinting Line 15^FS "+ 
			"^CN0^PN0 "+ 
			"^XZ "+ 
			"^XA "+ 
			"^MMK "+ 
			"^KV0,9,0,0,0 "+ 
			"^FO50,50^A0N,50,50^FDFull Cut^FS "+ 
			"^CN0^PN1^CP0 "+ 
			"^PQ1 "+ 
			"^XZ "+ 
			" "+ 
			"259 "+ 
			"ZPL Commands "+ 
			"^LF "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
