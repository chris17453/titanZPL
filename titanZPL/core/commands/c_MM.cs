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
    public class zpl_cmd_c_MM : zpl_command{   //Print Mode
        public string r110pax4_print_engines_f                                     = String.Empty;
        public string b                                                            = String.Empty;
                                        
        public zpl_cmd_c_MM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MM";                   
            description="Print Mode";                   
            data_format="a,b ";                   
            example    ="";                   
            r110pax4_print_engines_f                                    =(string)argument(0,data,"s","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =desired_mode //
T = Tear -off n P = Peel-off (not available on S-300) n R = Rewind (depends on printer model) A = Applicator (depends on printer model) n C = Cutter (depends on printer model) D = Delayed cutter n F = RFID n L = Reserved n, o U = Reserved n, o K = Kiosk p  //
The values available for parameter a depend on the printer being used and whether it supports the option. For RFID printers: 
	
A =R110PAX4_print_engines_F //
N = no Y = yes  //
N The command is ignored if parameters are missing or invalid. The current value of the command remains unchanged. n. This value is not supported on the KR403 or ZD500R printer. o. This value is supported only on the ZM400 and ZM600 printers. p. This value is supported only the KR403 printer.  273 ZPL Commands ^MM 11/21/16 Zebra Programming Guide P1012728-011 • Rewind — the label and liner are rewound on an (optional) external rewind device. The next label is positioned under the printhead (no backfeed motion). • Applicator — when used with an application device, the label move far enough forward to be removed by the applicator and applied to an item. This applies only to printers that have applicator ports and that are being used in a print-and-apply system. • Cutter — after printing, the media feeds forward and is automatically cut into predetermined lengths. • Delayed cutter — When the printer is in the Delayed Cut PRINT MODE, it will cut the label when it receives the ~JK (Delayed Cut) command. To activate the ~JK command, the printer's PRINT MODE must be set to Delayed Cut and there must be a label waiting to be cut. When the printer is not in the Delayed Cut PRINT MODE, the printer will not cut the label when it receives the ~JK command. The Delayed Cut feature can be activated: • through PRINT MODE on the printer’s control panel •with a ^MMD command • RFID — increases throughput time when printing batches of RFID labels by eliminating backfeed between labels. • Kiosk — after printing, the media is moved in a presentation position, most applications maintain a loop of media in the printer. Comments Be sure to select the appropriate value for the print mode being used to avoid unexpected results. This command is ignored on the HC100™ printer. Note • Send ~JK in a separate file - it cannot be sent at the end of a set of commands.  ZPL Commands ^MN 274 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^MM – Print Mode "+ 
			"The ^MM command determines the action the printer takes after a label or group of labels has "+ 
			"printed. "+ 
			"Format: ^MMa,b "+ 
			"This list identifies the different modes of operation: "+ 
			"• Tear-off — after printing, the label advances so the web is over the tear bar. The label, with liner "+ 
			"attached, can be torn off manually. "+ 
			"• Peel-off — after printing, the label moves forward and activates a Label Available Sensor. "+ 
			"Printing stops until the label is manually removed from the printer. "+ 
			"Power Peel – liner automatically rewinds using an optional internal rewind spindle. "+ 
			"Value Peel – liner feeds down the front of the printer and is manually removed. "+ 
			"Prepeel – after each label is manually removed, the printer feeds the next label forward "+ 
			"to prepeel a small portion of the label away from the liner material. The printer then "+ 
			"backfeeds and prints the label. The prepeel feature assists in the proper peel operation of "+ 
			"some media types. "+ 
			"Note • "+ 
			"Refer to the User Guide for your printer to determine which print modes are supported by "+ 
			"your printer. "+ 
			"Parameters Details "+ 
			"a = desired mode "+ 
			"Values: "+ 
			"T = Tear -off "+ 
			"n "+ 
			"P = Peel-off (not available on S-300) "+ 
			"n "+ 
			"R = Rewind (depends on printer model) "+ 
			"A = Applicator (depends on printer model) "+ 
			"n "+ 
			"C = Cutter (depends on printer model) "+ 
			"D = Delayed cutter "+ 
			"n "+ 
			"F = RFID "+ 
			"n "+ 
			"L = Reserved "+ 
			"n, o "+ 
			"U = Reserved "+ 
			"n, o "+ 
			"K = Kiosk "+ 
			"p "+ 
			"Default: "+ 
			"The values available for parameter "+ 
			"a depend on the printer being used and "+ 
			"whether it supports the option. "+ 
			"For RFID printers: "+ 
			"A = R110PAX4 print engines "+ 
			"F = other RFID printers "+ 
			"b = prepeel select "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: "+ 
			"N "+ 
			"The command is ignored if parameters are missing or invalid. The current value "+ 
			"of the command remains unchanged. "+ 
			"n. This value is not supported on the KR403 or ZD500R printer. "+ 
			"o. This value is supported only on the ZM400 and ZM600 printers. "+ 
			"p. This value is supported only the KR403 printer. "+ 
			" "+ 
			"273 "+ 
			"ZPL Commands "+ 
			"^MM "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"• Rewind — the label and liner are rewound on an (optional) external rewind device. The next "+ 
			"label is positioned under the printhead (no backfeed motion). "+ 
			"• Applicator — when used with an application device, the label move far enough forward to be "+ 
			"removed by the applicator and applied to an item. This applies only to printers that have "+ 
			"applicator ports and that are being used in a print-and-apply system. "+ 
			"• Cutter — after printing, the media feeds forward and is automatically cut into predetermined "+ 
			"lengths. "+ 
			"• Delayed cutter — When the printer is in the Delayed Cut PRINT MODE, it will cut the label when "+ 
			"it receives the "+ 
			"~JK (Delayed Cut) command. To activate the ~JK command, the printer's PRINT "+ 
			"MODE must be set to Delayed Cut and there must be a label waiting to be cut. When the printer "+ 
			"is not in the Delayed Cut PRINT MODE, the printer will not cut the label when it receives the "+ 
			"~JK command. "+ 
			"The Delayed Cut feature can be activated: "+ 
			"• through PRINT MODE on the printer’s control panel "+ 
			"•with a "+ 
			"^MMD command "+ 
			"• RFID — increases throughput time when printing batches of RFID labels by eliminating "+ 
			"backfeed between labels. "+ 
			"• Kiosk — after printing, the media is moved in a presentation position, most applications "+ 
			"maintain a loop of media in the printer. "+ 
			"Comments Be sure to select the appropriate value for the print mode being used to avoid "+ 
			"unexpected results. "+ 
			"This command is ignored on the HC100™ printer. "+ 
			"Note • Send ~JK in a separate file - it cannot be sent at the end of a set of commands. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MN "+ 
			"274 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
