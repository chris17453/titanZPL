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
    public class zpl_cmd_c_HG : zpl_command{   //Host Graphic
        public string device_location                                              = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension_fixed_value                                        = String.Empty;
                                        
        public zpl_cmd_c_HG(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HG";                   
            description="Host Graphic";                   
            data_format="d,o,x ";                   
            example    ="";                   
            device_location                                             =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension_fixed_value                                       =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =device_location_of_object //R:, E:, B:, and A:  //search priority 
	
o =object_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Fixed_Value // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^HG – Host Graphic "+ 
			"The ^HG command is used to upload graphics to the host. The graphic image can be stored for "+ 
			"future use, or it can be downloaded to any Zebra printer. "+ 
			"Format: ^HGd:o.x "+ 
			"Comments For more information on uploading graphics, see ^HY on page 212. "+ 
			"Parameters Details "+ 
			"d = device "+ 
			"location of "+ 
			"object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: search priority "+ 
			"o = object name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension Fixed Value: .GRF "+ 
			" "+ 
			"195 "+ 
			"ZPL Commands "+ 
			"^HH "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
