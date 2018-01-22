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
    public class zpl_cmd_c_FC : zpl_command{   //Field Clock
        public string primary_clock_indicator_character                            = String.Empty;
        public string secondary_clock_indicator_character                          = String.Empty;
        public string third_clock_indicator_character                              = String.Empty;
                                        
        public zpl_cmd_c_FC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FC";                   
            description="Field Clock";                   
            data_format="a,b,c ";                   
            example    ="^XA"+
			            "^FO10,100^A0N,50,50"+
			            "^FC%,{,#"+
			            "^FDPrimary: %m/%d/%y^FS"+
			            "^FO10,200^A0N,50,50"+
			            "^FC%,{,#"+
			            "^FDSecondary: {m/{d/{y^FS"+
			            "^FO10,300^A0N,50,50"+
			            "^FC%,{,#"+
			            "^FDThird: #m/#d/#y^FS"+
			            "^XZ";                   
            primary_clock_indicator_character                           =(string)argument(0,data,"s","                   ",""," ");
            secondary_clock_indicator_character                         =(string)argument(1,data,"s","                   ",""," ");
            third_clock_indicator_character                             =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =primary_clock_indicator_character //any ASCII character  //% 
	
b =secondary_clock_indicator_character //any ASCII character  //none—this value cannot be the same as a or c 
	
c =third_clock_indicator_character //any ASCII character  //none—this value cannot be the same as a or 
                                       
  **************************************************/ 
            manual=""+ 
			"^FC – Field Clock "+ 
			"The ^FC command is used to set the clock-indicators (delimiters) and the clock mode for use with "+ 
			"the Real-Time Clock hardware. This command must be included within each label field command "+ 
			"string each time the Real-Time Clock values are required within the field. "+ 
			"Format: ^FCa,b,c "+ 
			"Comments The ^FC command is ignored if the Real Time Clock hardware is not present. As "+ 
			"of V60.13.0.10, ( "+ 
			"^SN) functions with (^FC) capabilities. "+ 
			"For more details on the Real Time Clock, see Real Time Clock on page 1325. "+ 
			"Parameters Details "+ 
			"a = primary clock "+ 
			"indicator "+ 
			"character "+ 
			"Values: any ASCII character "+ 
			"Default: % "+ 
			"b = secondary clock "+ 
			"indicator "+ 
			"character "+ 
			"Values: any ASCII character "+ 
			"Default: none—this value cannot be the same as a or c "+ 
			"c = third clock "+ 
			"indicator "+ 
			"character "+ 
			"Values: any ASCII character "+ 
			"Default: none—this value cannot be the same as a or b "+ 
			"Example: Entering these ZPL commands sets the primary clock indicator to %, the secondary clock "+ 
			"indicator to {, and the third clock indicator to #. The results are printed on a label with Primary, "+ 
			"Secondary, and Third as field data. "+ 
			"^XA "+ 
			"^FO10,100^A0N,50,50 "+ 
			"^FC%,{,# "+ 
			"^FDPrimary: %m/%d/%y^FS "+ 
			"^FO10,200^A0N,50,50 "+ 
			"^FC%,{,# "+ 
			"^FDSecondary: {m/{d/{y^FS "+ 
			"^FO10,300^A0N,50,50 "+ 
			"^FC%,{,# "+ 
			"^FDThird: #m/#d/#y^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FD "+ 
			"164 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
