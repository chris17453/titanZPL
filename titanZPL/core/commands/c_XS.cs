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
    public class zpl_cmd_c_XS : zpl_command{   //Set Dynamic Media Calibration
        public string length                                                       = String.Empty;
        public string threshold                                                    = String.Empty;
                                        
        public zpl_cmd_c_XS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^XS";                   
            description="Set Dynamic Media Calibration";                   
            data_format="length,threshold ";                   
            example    ="";                   
            length                                                      =(string)argument(0,data,"s","                   ",""," ");
            threshold                                                   =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	th =dynamic_length_calibration //
Y = enable N = disable  //Y threshol
	ld =dynamic_threshold_calibration //
Y = enable N = disable  //Y gai
	in =dynamic_gain_calibration //
Y = enable N = disable  //Y  341 ZPL Commands ^XZ 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^XS – Set Dynamic Media Calibration "+ 
			"The ^XS command controls whether dynamic media calibration is performed to compensate for "+ 
			"variations in label length, position, transmissivity, and/or reflectance after a printer is powered-up or "+ 
			"the printer has been opened (for example to change or check the media). "+ 
			"Supported Devices "+ 
			"•G-Series "+ 
			"Format: ^XSlength,threshold "+ 
			"Parameters Details "+ 
			"length = "+ 
			"dynamic "+ 
			"length calibration "+ 
			"Values: "+ 
			"Y = enable "+ 
			"N = disable "+ 
			"Default: Y "+ 
			"threshold = "+ 
			"dynamic threshold "+ 
			"calibration "+ 
			"Values: "+ 
			"Y = enable "+ 
			"N = disable "+ 
			"Default: Y "+ 
			"gain = dynamic gain "+ 
			"calibration "+ 
			"(to be in a future "+ 
			"implementation) "+ 
			"Values: "+ 
			"Y = enable "+ 
			"N = disable "+ 
			"Default: Y "+ 
			" "+ 
			"341 "+ 
			"ZPL Commands "+ 
			"^XZ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
