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
    public class zpl_cmd_c_HY : zpl_command{   //Upload Graphics
        public string object_location                                              = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_HY(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HY";                   
            description="Upload Graphics";                   
            data_format="d,o,x ";                   
            example    ="";                   
            object_location                                             =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_object //R:, E:, B:, and A:  //search priority 
	
o =object_name //1 to 8 alphanumeric characters  //an object name must be specified 
	
x =extension //
G = .GRF (raw bitmap format) P = .PNG (compressed bitmap format)  //format of stored image  213 ZPL Commands ^HZ 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^HY – Upload Graphics "+ 
			"The ^HY command is an extension of the ^HG command. ^HY is used to upload graphic objects from "+ 
			"the printer in any supported format. "+ 
			"Format: ^HYd:o.x "+ 
			"Comments The image is uploaded in the form of a ~DY command. The data field of the "+ 
			"returned "+ 
			"~DY command is always encoded in the ZB64 format. "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: search priority "+ 
			"o = object name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: an object name must be specified "+ 
			"x = extension "+ 
			"Values: "+ 
			"G = .GRF (raw bitmap format) "+ 
			"P = .PNG (compressed bitmap format) "+ 
			"Default: format of stored image "+ 
			" "+ 
			"213 "+ 
			"ZPL Commands "+ 
			"^HZ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
