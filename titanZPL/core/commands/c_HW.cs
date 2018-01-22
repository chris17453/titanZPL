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
    public class zpl_cmd_c_HW : zpl_command{   //Host Directory List
        public string object_listing_location                                      = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_HW(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HW";                   
            description="Host Directory List";                   
            data_format="d,o,x ";                   
            example    ="^XA"+
			            "^HWR:*.*"+
			            "^XZ";                   
            object_listing_location                                     =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_to_retrieve_object_listing //R:, E:, B:, A:and Z:  //R: 
	
o =object_name //1 to 8 alphanumeric characters  //asterisk (*). A question mark (?) can also be used. 
	
x =extension //any extension conforming to Zebra conventions  //asterisk (*). A question mark (?) can also be used. 
	
f =format_The_f_parameter_is_only_supported_in_firmware_version_V60 //
c = column format d = default format  //
                                       
  **************************************************/ 
            manual=""+ 
			"^HW – Host Directory List "+ 
			"^HW is used to transmit a directory listing of objects in a specific memory area (storage device) back "+ 
			"to the host device. This command returns a formatted ASCII string of object names to the host. "+ 
			"Each object is listed on a line and has a fixed length. The total length of a line is also fixed. Each line "+ 
			"listing an object begins with the asterisk (*) followed by a blank space. There are eight spaces for the "+ 
			"object name, followed by a period and three spaces for the extension. The extension is followed by "+ 
			"two blank spaces, six spaces for the object size, two blank spaces, and three spaces for option flags "+ 
			"(reserved for future use). The format looks like this: "+ 
			"<STX><CR><LF> "+ 
			"DIR R: <CR><LF> "+ 
			"*Name.ext(2sp.)(6 obj. sz.)(2sp.)(3 option flags) "+ 
			"*Name.ext(2sp.)(6 obj. sz.)(2sp.)(3 option flags) "+ 
			"<CR><LF> "+ 
			"-xxxxxxx bytes free "+ 
			"<CR><LF> "+ 
			"<ETX> "+ 
			"<STX> = start of text "+ 
			"<CR><LR> = carriage return/line feed "+ 
			"<ETX> = end on text "+ 
			"The command might be used in a stand-alone file to be issued to the printer at any time. The printer "+ 
			"returns the directory listing as soon as possible, based on other tasks it might be performing when "+ 
			"the command is received. "+ 
			"This command, like all ^ (caret) commands, is processed in the order that it is received by the "+ 
			"printer. "+ 
			"Format: ^HWd:o.x "+ 
			"Parameters Details "+ 
			"d = location to "+ 
			"retrieve object "+ 
			"listing "+ 
			"Values: R:, E:, B:, A:and Z: "+ 
			"Default: R: "+ 
			"o = object name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: asterisk (*). A question mark (?) can also be used. "+ 
			"x = extension "+ 
			"Values: any extension conforming to Zebra conventions "+ 
			"Default: asterisk (*). A question mark (?) can also be used. "+ 
			"f = format "+ 
			"The f parameter is only "+ 
			"supported in firmware "+ 
			"version V60.16.0Z and "+ 
			"V53.16.0Z or later. "+ 
			"Values: "+ 
			"c = column format "+ 
			"d = default format "+ 
			"Default: d "+ 
			"Example: Listed is an example of the ^HW command to retrieve from information R: "+ 
			"^XA "+ 
			"^HWR:*.* "+ 
			"^XZ "+ 
			" "+ 
			"211 "+ 
			"ZPL Commands "+ 
			"^HW "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example: The printer returned this information as the Host Directory Listing:-DIR R:*.* "+ 
			"*R:ARIALN1.FNT 49140 "+ 
			"*R:ARIALN2.FNT 49140 "+ 
			"*R:ARIALN3.FNT 49140 "+ 
			"*R:ARIALN4.FNT 49140 "+ 
			"*R:ARIALN.FNT 49140 "+ 
			"*R:ZEBRA.GRF 8420 "+ 
			"-794292 bytes free R:RAM "+ 
			" "+ 
			"ZPL Commands "+ 
			"^HY "+ 
			"212 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
