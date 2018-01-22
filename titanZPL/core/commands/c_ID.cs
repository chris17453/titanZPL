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
    public class zpl_cmd_c_ID : zpl_command{   //Object Delete
        public string location_of_stored_object                                    = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_ID(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^ID";                   
            description="Object Delete";                   
            data_format="d,o,x ";                   
            example    ="";                   
            location_of_stored_object                                   =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_stored_object //R:, E:, B:, and A:  //R: 
	
o =object_name //any 1 to 8 character name  //if a name is not specified, UNKNOWN is used 
	
x =extension //any extension conforming to Zebra conventions  //.GR
                                       
  **************************************************/ 
            manual=""+ 
			"^ID – Object Delete "+ 
			"The ^ID command deletes objects, graphics, fonts, and stored formats from storage areas. Objects "+ 
			"can be deleted selectively or in groups. This command can be used within a printing format to delete "+ 
			"objects before saving new ones, or in a stand-alone format to delete objects. "+ 
			"The image name and extension support the use of the asterisk ( "+ 
			"*) as a wild card. This allows you to "+ 
			"easily delete a selected groups of objects. "+ 
			"Format: ^IDd:o.x "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"stored object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = object name "+ 
			"Values: any 1 to 8 character name "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Values: any extension conforming to Zebra conventions "+ 
			"Default: .GRF "+ 
			"Example 1: To delete stored formats from DRAM: "+ 
			"^XA "+ 
			"^IDR:*.ZPL^FS "+ 
			"^XZ "+ 
			"Example 2: To delete formats and images named SAMPLE from DRAM, regardless of the "+ 
			"extension: "+ 
			"^XA "+ 
			"^IDR:SAMPLE.*^FS "+ 
			"^XZ "+ 
			"Example 3: To delete the image SAMPLE1.GRF prior to storing SAMPLE2.GRF: "+ 
			"^XA "+ 
			"^FO25,25^AD,18,10 "+ 
			"^FDDelete^FS "+ 
			"^FO25,45^AD,18,10 "+ 
			"^FDthen Save^FS "+ 
			"^IDR:SAMPLE1.GRF^FS "+ 
			"^ISR:SAMPLE2.GRF^FS^XZ "+ 
			"Example 4: In this the * is a wild card, indicating that all objects with the .GRF extension are "+ 
			"deleted: "+ 
			"^XA "+ 
			"^IDR:*.GRF^FS "+ 
			"^XZ "+ 
			" "+ 
			"215 "+ 
			"ZPL Commands "+ 
			"^ID "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments When an object is deleted from R:, the object can no longer be used and "+ 
			"memory is available for storage. This applies only to "+ 
			"R:memory. With the other memory "+ 
			"types ( "+ 
			"A:, B:, E:) the deleted object is no longer available. The memory space recovers when "+ 
			"an automatic defragmentation or initialization occurs. "+ 
			"The ^ID command also frees up the uncompressed version of the object in DRAM. "+ 
			"If the name is specified as "+ 
			"*.ZOB, all downloaded bar code fonts (or other objects) are deleted. "+ 
			"If the named downloadable object cannot be found in the "+ 
			"R:, E:, B:, and A: device, the ^ID "+ 
			"command is ignored. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^IL "+ 
			"216 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
