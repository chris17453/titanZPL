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
    public class zpl_cmd_t_DE : zpl_command{   //Download Encoding
        public string location_of_table                                            = String.Empty;
        public string name_of_table                                                = String.Empty;
        public string extension_format                                             = String.Empty;
        public string s                                                            = String.Empty;
        public string data                                                         = String.Empty;
                                        
        public zpl_cmd_t_DE(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~DE";                   
            description="Download Encoding";                   
            data_format="d,o,x,s,data ";                   
            example    ="";                   
            location_of_table                                           =(string)argument(0,data,"s","                   ",""," ");
            name_of_table                                               =(string)argument(1,data,"s","                   ",""," ");
            extension_format                                            =(string)argument(2,data,"s","                   ",""," ");
            s                                                           =(string)argument(3,data,"s","                   ",""," ");
            data                                                        =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_table //R:, E:, B:, and A:  //R: 
	
o =name_of_table //any valid name, up to 8 characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Format //the number of memory bytes required to hold the Zebra downloadable format of the font  //if an incorrect value or no value is entered, the command is ignored dat
	ta =data_string //a string of ASCII hexadecimal values  //if no data is entered, the command is ignore
                                       
  **************************************************/ 
            manual=""+ 
			"~DE – Download Encoding "+ 
			"The standard encoding for TrueType Windows® fonts is always Unicode. The ZPL II field data must "+ 
			"be converted from some other encoding to Unicode that the Zebra printer understands. The required "+ 
			"translation tables are provided with font packs. Some tables can be downloaded from "+ 
			"www.zebra.com. "+ 
			"Format: ~DEd:o.x,s,data "+ 
			"Comments For more information on ZTools or ZebraNet Bridge, see the program "+ 
			"documentation included with the software. "+ 
			"For assistance with editing or adding mappings to "+ 
			".DAT tables, ZebraNet Bridge includes a "+ 
			".DAT table editor in the font wizard. "+ 
			"Encoding scheme for the data sent to the printer is the second four character and the encoding "+ 
			"scheme for the font is the first four characters throughout the .DAT file. The data must be ordered by "+ 
			"the second four characters (the encoding table). "+ 
			"Parameters Details "+ 
			"d = location of table "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = name of table "+ 
			"Values: any valid name, up to 8 characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Format: .DAT "+ 
			"s = table size "+ 
			"Values: the number of memory bytes required to hold the Zebra downloadable "+ 
			"format of the font "+ 
			"Default: if an incorrect value or no value is entered, the command is ignored "+ 
			"data = data string "+ 
			"Values: a string of ASCII hexadecimal values "+ 
			"Default: if no data is entered, the command is ignored "+ 
			"Example: This is an example of how to download the required translation table: "+ 
			"~DER:JIS.DAT,27848,300021213001... "+ 
			"(27848 two-digit hexadecimal values) "+ 
			"Example: This is an example of a "+ 
			".DAT table. The table below the example identifies the elements: "+ 
			"~DEE:EXAMPLE.DAT,16, "+ 
			"00310041 "+ 
			"00320042 "+ 
			"00330043 "+ 
			"00340044 "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			" "+ 
			"147 "+ 
			"ZPL Commands "+ 
			"~DE "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Data must have 0041, 0042, 0043, and 0044 in order. Multiple pairs can be on the same line. "+ 
			"1 "+ 
			"Input stream with 0041 will be mapped to "+ 
			"0031. The printer prints '1'. "+ 
			"2 "+ 
			"Input stream with 0042 will be mapped to "+ 
			"0032. The printer prints '2'. "+ 
			"3 "+ 
			"Input stream with 0043 will be mapped to "+ 
			"0033. The printer prints '3'. "+ 
			"4 "+ 
			"Input stream with 0044 will be mapped to "+ 
			"0034. The printer prints '4'. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^DF "+ 
			"148 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
