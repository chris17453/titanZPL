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
    public class zpl_cmd_t_JG : zpl_command{   //Graphing Sensor Calibration
                                        
        public zpl_cmd_t_JG(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JG";                   
            description="Graphing Sensor Calibration";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JG – Graphing Sensor Calibration "+ 
			"The ~JG command prints a graph (media sensor profile) of the sensor values. "+ 
			"Format: ~JG "+ 
			"Comments The HC100™ printer does not perform a calibration, but does print a sensor profile "+ 
			"label. "+ 
			"Example: Sending the "+ 
			"~JG command to a printer configured for thermal transfer produces a series "+ 
			"of labels resembling this image: "+ 
			"GENERATED LABELS "+ 
			" "+ 
			"ZPL Commands "+ 
			"^JH "+ 
			"228 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
