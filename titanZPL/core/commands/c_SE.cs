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
    public class zpl_cmd_c_SE : zpl_command{   //Select Encoding Table
        public string location_of_encoding_table                                   = String.Empty;
        public string name_of_encoding_table                                       = String.Empty;
        public string extension_fixed_value                                        = String.Empty;
                                        
        public zpl_cmd_c_SE(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SE";                   
            description="Select Encoding Table";                   
            data_format="d,o,x ";                   
            example    ="^XA^WD*:*.*^XZ";                   
            location_of_encoding_table                                  =(string)argument(0,data,"s","                   ",""," ");
            name_of_encoding_table                                      =(string)argument(1,data,"s","                   ",""," ");
            extension_fixed_value                                       =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_encoding_table //R:, E:, B:, and A:  //R: 
	
o =name_of_encoding_table //1 to 8 alphanumeric characters  //a value must be specified 
	
x =extension_Fixed_Value // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^SE – Select Encoding Table "+ 
			"The ^SE command is used to select the desired ZPL or ZPL II encoding table. "+ 
			"Format: ^SEd:o.x "+ 
			"The encoding tables are provided with the font card or downloaded in flash with the font. The "+ 
			"table appears as "+ 
			"XXXXXXX.DAT in a directory label printed by the ZPL commands. "+ 
			"The most active encoding table is indicated by the * on the directory label. "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"encoding table "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = name of encoding "+ 
			"table "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: a value must be specified "+ 
			"x = extension Fixed Value: .DAT "+ 
			"Example: "+ 
			"^XA^WD*:*.*^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SF "+ 
			"306 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
