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
    public class zpl_cmd_c_HF : zpl_command{   //Host Format
        public string device_to_recall_image                                       = String.Empty;
        public string image_name                                                   = String.Empty;
        public string extension_fixed_value                                        = String.Empty;
                                        
        public zpl_cmd_c_HF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HF";                   
            description="Host Format";                   
            data_format="d,o,x ";                   
            example    ="^XA"+
			            "^DFB:FILE1.ZPL"+
			            "^FO100,100^A0,100"+
			            "^FDTEST^FS"+
			            "^XZ";                   
            device_to_recall_image                                      =(string)argument(0,data,"s","                   ",""," ");
            image_name                                                  =(string)argument(1,data,"s","                   ",""," ");
            extension_fixed_value                                       =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =device_to_recall_image //R:, E:, B:, and A:  //R: 
	
o =image_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Fixed_Value // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^HF – Host Format "+ 
			"The ^HF command sends stored formats to the host. "+ 
			"Format: ^HFd,o,x "+ 
			"Parameters Details "+ 
			"d = device to recall "+ 
			"image "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = image name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension Fixed Value: .ZPL "+ 
			"Example: This example shows the sequence and results. "+ 
			"Using a terminal emulator, you download this code to the printer: "+ 
			"^XA "+ 
			"^DFB:FILE1.ZPL "+ 
			"^FO100,100^A0,100 "+ 
			"^FDTEST^FS "+ 
			"^XZ "+ 
			"Then you send this code to the printer: "+ 
			"^XA "+ 
			"^HFB:FILE1.ZPL "+ 
			"^XZ "+ 
			"The terminal emulator returns this code: "+ 
			"^XA^DFFILE1, "+ 
			"^FO100,100^A0,100^FDTEST^FS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^HG "+ 
			"194 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
