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
    public class zpl_cmd_t_DB : zpl_command{   //Download Bitmap Font
        public string drive_to_store_font                                          = String.Empty;
        public string name_of_font                                                 = String.Empty;
        public string extension_format                                             = String.Empty;
        public string a                                                            = String.Empty;
        public    int h                                                            = 0;
        public    int maximum_width_of_cell                                        = 0;
        public string base_name                                                    = String.Empty;
        public string space                                                        = String.Empty;
        public    int number                                                       = 0;
        public string copyright_holder                                             = String.Empty;
        public string data                                                         = String.Empty;
                                        
        public zpl_cmd_t_DB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~DB";                   
            description="Download Bitmap Font";                   
            data_format="d,o,x,a,h,w,base,space,#char,©,data ";                   
            example    ="";                   
            drive_to_store_font                                         =(string)argument(0,data,"s","                   ",""," ");
            name_of_font                                                =(string)argument(1,data,"s","                   ",""," ");
            extension_format                                            =(string)argument(2,data,"s","                   ",""," ");
            a                                                           =(string)argument(3,data,"s","                   ",""," ");
            h                                                           =(   int)argument(4,data,"i","                   ",""," ");
            maximum_width_of_cell                                       =(   int)argument(5,data,"i","                   ",""," ");
            base_name                                                   =(string)argument(6,data,"s","                   ",""," ");
            space                                                       =(string)argument(7,data,"s","                   ",""," ");
            number                                                      =(   int)argument(8,data,"i","                   ",""," ");
            copyright_holder                                            =(string)argument(9,data,"s","                   ",""," ");
            data                                                        =(string)argument(10,data,"s","                  ",""," ");
                                    
  /*************************************************  
	
d =drive_to_store_font //R:, E:, B:, and A:  //R: 
	
o =name_of_font //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_Format //1 to 32000  //a value must be specified 
	
w =maximum_width_of_cell //1 to 32000  //a value must be specified bas
	se =dots_from_top_of_cell_to_character_baseline //1 to 32000  //a value must be specified spac
	ce =width_of_space_or_non //1 to 32000  //a value must be specified #cha
	ar =number_of_characters_in_font //1 to 256 (must match the characters being downloaded)  //a value must be specified 
	
© =copyright_holder //1 to 63 alphanumeric characters  //a value must be specified dat
	ta =structured // //-
                                       
  **************************************************/ 
            manual=""+ 
			"~DB – Download Bitmap Font "+ 
			"The ~DB command sets the printer to receive a downloaded bitmap font and defines native cell size, "+ 
			"baseline, space size, and copyright. "+ 
			"This command consists of two portions, a ZPL II command defining the font and a structured data "+ 
			"segment that defines each character of the font. "+ 
			"Format: ~DBd:o.x,a,h,w,base,space,#char,©,data "+ 
			"Parameters Details "+ 
			"d = drive to store "+ 
			"font "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = name of font "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Format: .FNT "+ 
			"a = orientation of "+ 
			"native font "+ 
			"Fixed Value: normal "+ 
			"h = maximum height of "+ 
			"cell (in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: a value must be specified "+ 
			"w = maximum width of "+ 
			"cell (in dots) "+ 
			"Values: 1 to 32000 "+ 
			"Default: a value must be specified "+ 
			"base = dots from top "+ 
			"of cell to "+ 
			"character "+ 
			"baseline "+ 
			"Values: 1 to 32000 "+ 
			"Default: a value must be specified "+ 
			"space = width of "+ 
			"space or "+ 
			"non-existent "+ 
			"characters "+ 
			"Values: 1 to 32000 "+ 
			"Default: a value must be specified "+ 
			"#char = number of "+ 
			"characters in "+ 
			"font "+ 
			"Values: 1 to 256 (must match the characters being downloaded) "+ 
			"Default: a value must be specified "+ 
			"© = copyright holder "+ 
			"Values: 1 to 63 alphanumeric characters "+ 
			"Default: a value must be specified "+ 
			"data = structured "+ 
			"ASCII data that "+ 
			"defines each "+ 
			"character in the "+ 
			"font "+ 
			"The # symbol signifies character code parameters, which are separated with "+ 
			"periods. The character code is from 1 to 4 characters to allow for large international "+ 
			"character sets to be downloaded to the printer. "+ 
			"The data structure is: "+ 
			"#xxxx.h.w.x.y.i.data "+ 
			"#xxxx = character code "+ 
			"h = bitmap height (in dot rows) "+ 
			"w = bitmap width (in dot rows) "+ 
			"x = x-offset (in dots) "+ 
			"y = y-offset (in dots) "+ 
			"i = typesetting motion displacement (width, including "+ 
			"inter character gap of a particular character in the font) "+ 
			"data = hexadecimal bitmap description "+ 
			" "+ 
			"145 "+ 
			"ZPL Commands "+ 
			"~DB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example: This is an example of how to use the ~DB command. It shows the first two characters of "+ 
			"a font being downloaded to DRAM. "+ 
			"~DBR:TIMES.FNT,N,5,24,3,10,2,ZEBRA 1992, "+ 
			"#0025.5.16.2.5.18. "+ 
			"OOFF "+ 
			"OOFF "+ 
			"FFOO "+ 
			"FFOO "+ 
			"FFFF "+ 
			"#0037.4.24.3.6.26. "+ 
			"OOFFOO "+ 
			"OFOOFO "+ 
			"OFOOFO "+ 
			"OOFFOO "+ 
			" "+ 
			"ZPL Commands "+ 
			"~DE "+ 
			"146 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
