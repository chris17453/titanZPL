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
    public class zpl_cmd_c_HZ : zpl_command{   //Display Description Information
        public string display_description_to_return                                = String.Empty;
                                        
        public zpl_cmd_c_HZ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HZ";                   
            description="Display Description Information";                   
            data_format="b ";                   
            example    ="^XA"+
			            "^HZO,R:SAMPLE.GRF"+
			            "^XZ";                   
            display_description_to_return                               =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
b =display_description_to_return //
a = display all information f = display printer format setting information l = display object directory listing information o = display individual object data information r = display printer status information  //if the value is missing or invalid, the command is ignored Parameters Details 
	
d =location_of_stored_object //R:, E:, B:, and A:  //R: 
	
o =object_name //1 to 8, or 1 to 16 alphanumeric characters based on parameter l.  //if a name is not specified, UNKNOWN is used. 
	
x =extension_Supported_extensions_for_objects //
Y = Yes If Y, the object data stores the filename as 16 characters. The data is only compatible with firmware version V60.13.0.5, or later. N = No If N, the object data stores the filename as 8 characters. The data is forward and backward compatible with all versions of firmware.  //
                                       
  **************************************************/ 
            manual=""+ 
			"^HZ – Display Description Information "+ 
			"The ^HZ command is used for returning printer description information in XML format. The printer "+ 
			"returns information on format parameters, object directories, individual object data, and print status "+ 
			"information. "+ 
			"Format: ^HZb "+ 
			"Format: ^HZO,d:o.x,l "+ 
			"Parameters Details "+ 
			"b = display "+ 
			"description to "+ 
			"return "+ 
			"Values: "+ 
			"a = display all information "+ 
			"f = display printer format setting information "+ 
			"l = display object directory listing information "+ 
			"o = display individual object data information "+ 
			"r = display printer status information "+ 
			"Default: if the value is missing or invalid, the command is ignored "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"stored object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = object name "+ 
			"Values: 1 to 8, or 1 to 16 alphanumeric characters based on parameter l. "+ 
			"Default: if a name is not specified, UNKNOWN is used. "+ 
			"x = extension "+ 
			"Supported extensions for objects (parameter o) include: "+ 
			".FNT — font "+ 
			".GRF — graphic "+ 
			".PNG — compressed graphic "+ 
			".ZPL — stored format "+ 
			".DAT — encoding table "+ 
			".ZOB — downloadable object "+ 
			".STO — Alert data file "+ 
			"l = long filename "+ 
			"support "+ 
			"Values: "+ 
			"Y = Yes "+ 
			"If "+ 
			"Y, the object data stores the filename as 16 characters. The data is "+ 
			"only compatible with firmware version V60.13.0.5, or later. "+ 
			"N = No "+ 
			"If "+ 
			"N, the object data stores the filename as 8 characters. The data is "+ 
			"forward and backward compatible with all versions of firmware. "+ 
			"Default: N "+ 
			"Example: This example shows the object data information for the object SAMPLE.GRF located on "+ 
			"R:. "+ 
			"^XA "+ 
			"^HZO,R:SAMPLE.GRF "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^ID "+ 
			"214 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
