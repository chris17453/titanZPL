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
    public class zpl_cmd_c_PO : zpl_command{   //Print Orientation
        public string invert_label_180_degrees                                     = String.Empty;
                                        
        public zpl_cmd_c_PO(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PO";                   
            description="Print Orientation";                   
            data_format="a ";                   
            example    ="^XA^CFD"+
			            "^POI"+
			            "^LH330,10"+
			            "^FO50,50"+
			            "^FDZEBRA TECHNOLOGIES^FS"+
			            "^FO50,75"+
			            "^FDVernon Hills, IL^FS"+
			            "^XZ";                   
            invert_label_180_degrees                                    =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =invert_label_180_degrees //
N = normal I = invert  //
                                       
  **************************************************/ 
            manual=""+ 
			"^PO – Print Orientation "+ 
			"The ^PO command inverts the label format 180 degrees. The label appears to be printed upside "+ 
			"down. If the original label contains commands such as ^LL, ^LS, ^LT and ^PF, the inverted label "+ 
			"output is affected differently. "+ 
			"Format: ^POa "+ 
			"The "+ 
			"^POI command inverts the x, y coordinates. All image placement is relative to these inverted "+ 
			"coordinates. Therefore, a different "+ 
			"^LH (Label Home) can be used to move the print back onto the "+ 
			"label. "+ 
			"Comments If multiple ^PO commands are issued in the same label format, only the last "+ 
			"command sent to the printer is used. "+ 
			"Once the ^PO command is sent, the setting is retained until another ^PO command is received or the "+ 
			"printer is turned off. "+ 
			"The "+ 
			"N value for the a parameter is not supported on the HC100™ printer. "+ 
			"Parameters Details "+ 
			"a = invert label "+ 
			"180 degrees "+ 
			"Values: "+ 
			"N = normal "+ 
			"I = invert "+ 
			"Default: N "+ 
			"Example: This is an example of printing a label at 180 degrees: "+ 
			"^XA^CFD "+ 
			"^POI "+ 
			"^LH330,10 "+ 
			"^FO50,50 "+ 
			"^FDZEBRA TECHNOLOGIES^FS "+ 
			"^FO50,75 "+ 
			"^FDVernon Hills, IL^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"295 "+ 
			"ZPL Commands "+ 
			"^PP ~PP "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"^PP ~PP – Programmable Pause "+ 
			"The ~PP command stops printing after the current label is complete (if one is printing) and places the "+ 
			"printer in Pause Mode. "+ 
			"The "+ 
			"^PP command is not immediate. Therefore, several labels might print before a pause is "+ 
			"performed. This command pauses the printer after the current format prints. "+ 
			"The operation is identical to pressing "+ 
			"PAUSE on the control panel of the printer. The printer remains "+ 
			"paused until PAUSE is pressed or a ~PS (Print Start) command is sent to the printer. "+ 
			"Format: ^PP or ~PP "+ 
			" "+ 
			"ZPL Commands "+ 
			"^PQ "+ 
			"296 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
