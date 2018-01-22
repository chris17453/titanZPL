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
    public class zpl_cmd_c_IL : zpl_command{   //Image Load
        public string location_of_stored_object                                    = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension_fixed_value                                        = String.Empty;
                                        
        public zpl_cmd_c_IL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^IL";                   
            description="Image Load";                   
            data_format="d,o,x ";                   
            example    ="^XA"+
			            "^ILR:SAMPLE2.GRF^FS"+
			            "^CFD,36,20"+
			            "^FO15,210"+
			            "^FD900123^FS"+
			            "^FO218,210"+
			            "^FDLINE 12^FS"+
			            "^FO15,360^AD"+
			            "^FDZEBRA THERMAL^FS"+
			            "^FO15,400^AD"+
			            "^FDTRANSFER PRINTER^FS"+
			            "^FO15,540"+
			            "^FD54321^FS"+
			            "^FO220,530"+
			            "^FDZ58643^FS"+
			            "^FO15,670^A0,27,18"+
			            "^FDTesting Stored Graphic^FS"+
			            "^FO15,700^A0,27,18"+
			            "^FDLabel Formats!!^FS"+
			            "^XZ";                   
            location_of_stored_object                                   =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension_fixed_value                                       =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_stored_object //R:, E:, B:, and A:  //R: 
	
o =object_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Fixed_Value // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^IL – Image Load "+ 
			"The ^IL command is used at the beginning of a label format to load a stored image of a format and "+ 
			"merge it with additional data. The image is always positioned at ^FO0,0. "+ 
			"Using this technique to overlay the image of constant information with variable data greatly "+ 
			"increases the throughput of the label format. "+ 
			"Format: ^ILd:o.x "+ 
			"Important • See ^IS on page 218. "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"stored object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = object name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension Fixed Value: .GRF, .PNG "+ 
			"Example: This example recalls the stored image SAMPLE2.GRF from DRAM and overlays it with "+ 
			"the additional data. The graphic was stored using the ^IS command. For the stored label format, "+ 
			"see the ^IS on page 218 command. "+ 
			"^XA "+ 
			"^ILR:SAMPLE2.GRF^FS "+ 
			"^CFD,36,20 "+ 
			"^FO15,210 "+ 
			"^FD900123^FS "+ 
			"^FO218,210 "+ 
			"^FDLINE 12^FS "+ 
			"^FO15,360^AD "+ 
			"^FDZEBRA THERMAL^FS "+ 
			"^FO15,400^AD "+ 
			"^FDTRANSFER PRINTER^FS "+ 
			"^FO15,540 "+ 
			"^FD54321^FS "+ 
			"^FO220,530 "+ 
			"^FDZ58643^FS "+ 
			"^FO15,670^A0,27,18 "+ 
			"^FDTesting Stored Graphic^FS "+ 
			"^FO15,700^A0,27,18 "+ 
			"^FDLabel Formats!!^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"217 "+ 
			"ZPL Commands "+ 
			"^IM "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
