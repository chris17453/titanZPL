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
    public class zpl_cmd_c_SQ : zpl_command{   //Halt ZebraNet Alert
        public string condition_type                                               = String.Empty;
        public string b                                                            = String.Empty;
        public string c                                                            = String.Empty;
                                        
        public zpl_cmd_c_SQ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SQ";                   
            description="Halt ZebraNet Alert";                   
            data_format="a,b,c ";                   
            example    ="";                   
            condition_type                                              =(string)argument(0,data,"s","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
            c                                                           =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =condition_type //
A = paper out B = ribbon out C = printhead over-temp D = printhead under-temp E = head open F = power supply over-temp G = ribbon-in warning (Direct Thermal Mode) H = rewind full I = cut error J = printer paused K = PQ job completed L = label ready M = head element out N = ZBI (Zebra BASIC Interpreter) runtime error O = ZBI (Zebra BASIC Interpreter) forced error Q = clean printhead R = media low S = ribbon low T = replace head U = battery low V = RFID error (in RFID printers only) W = all errors (in RFID printers only) * = all errors (in non-RFID printers) b = destination Values: A = serial port B = parallel port C = e-mail address D = TCP/IP E = UDP/IP F = SNMP trap * = wild card to stop alerts for all destinations c = halt messages Values: Y = halt messages N = start messages  //
Y  317 ZPL Commands ^SR 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^SQ – Halt ZebraNet Alert "+ 
			"The ^SQ command is used to stop the ZebraNet Alert option. "+ 
			"Format: ^SQa,b,c "+ 
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
			"Q = clean printhead "+ 
			"R = media low "+ 
			"S = ribbon low "+ 
			"T = replace head "+ 
			"U = battery low "+ 
			"V = RFID error (in RFID printers only) "+ 
			"W = all errors (in RFID printers only) "+ 
			"* = all errors (in non-RFID printers) "+ 
			"b = destination "+ 
			"Values: "+ 
			"A = serial port "+ 
			"B = parallel port "+ 
			"C = e-mail address "+ 
			"D = TCP/IP "+ 
			"E = UDP/IP "+ 
			"F = SNMP trap "+ 
			"* = wild card to stop alerts for all destinations "+ 
			"c = halt messages "+ 
			"Values: "+ 
			"Y = halt messages "+ 
			"N = start messages "+ 
			"Default: "+ 
			"Y "+ 
			" "+ 
			"317 "+ 
			"ZPL Commands "+ 
			"^SR "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
