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
    public class zpl_cmd_c_IM : zpl_command{   //Image Move
        public string location_of_stored_object                                    = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_IM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^IM";                   
            description="Image Move";                   
            data_format="d,o,x ";                   
            example    ="^XA"+
			            "^FO100,100^IMR:SAMPLE.GRF^FS"+
			            "^FO100,200^IMR:SAMPLE.GRF^FS"+
			            "^FO100,300^IMR:SAMPLE.GRF^FS"+
			            "^FO100,400^IMR:SAMPLE.GRF^FS"+
			            "^FO100,500^IMR:SAMPLE.GRF^FS"+
			            "^XZ";                   
            location_of_stored_object                                   =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_stored_object //R:, E:, B:, and A:  //search priority 
	
o =object_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^IM – Image Move "+ 
			"The ^IM command performs a direct move of an image from storage area into the bitmap. The "+ 
			"command is identical to the ^XG command (Recall Graphic), except there are no sizing parameters. "+ 
			"Format: ^IMd:o.x "+ 
			"Comments By using the ^FO command, the graphic image can be positioned anywhere on "+ 
			"the label. "+ 
			"The difference between ^IM and ^XG: ^IM does not have magnification, and therefore might require "+ 
			"less formatting time. However, to take advantage of this, the image must be at a 8-, 16-, or 32-bit "+ 
			"boundary. "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"stored object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: search priority "+ 
			"o = object name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Fixed Value: .GRF, .PNG "+ 
			"Example: This example moves the image SAMPLE.GRF from DRAM and prints it in several "+ 
			"locations in its original size. "+ 
			"^XA "+ 
			"^FO100,100^IMR:SAMPLE.GRF^FS "+ 
			"^FO100,200^IMR:SAMPLE.GRF^FS "+ 
			"^FO100,300^IMR:SAMPLE.GRF^FS "+ 
			"^FO100,400^IMR:SAMPLE.GRF^FS "+ 
			"^FO100,500^IMR:SAMPLE.GRF^FS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^IS "+ 
			"218 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
