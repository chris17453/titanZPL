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
    public class zpl_cmd_c_MU : zpl_command{   //Set Units of Measurement
        public string units                                                        = String.Empty;
        public string format_base_in_dots_per_inch                                 = String.Empty;
        public string desired_dots                                                 = String.Empty;
                                        
        public zpl_cmd_c_MU(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MU";                   
            description="Set Units of Measurement";                   
            data_format="a,b,c ";                   
            example    ="";                   
            units                                                       =(string)argument(0,data,"s","                   ",""," ");
            format_base_in_dots_per_inch                                =(string)argument(1,data,"s","                   ",""," ");
            desired_dots                                                =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =units //
D = dots I = inches M = millimeters  //D 
	
b =format_base_in_dots_per_inch //150, 200, 300  //a value must be entered or the command is ignored 
	
c =desired_dots //300, 600  //a value must be entered or the command is ignore
                                       
  **************************************************/ 
            manual=""+ 
			"^MU – Set Units of Measurement "+ 
			"The ^MU command sets the units of measurement the printer uses. ^MU works on a field-by-field "+ 
			"basis. Once the mode of units is set, it carries over from field to field until a new mode of units is "+ 
			"entered. "+ 
			"^MU also allows for printing at lower resolutions — 600 dpi printers are capable of printing at 300, "+ 
			"200, and 150 dpi; 300 dpi printers are capable of printing at 150 dpi. "+ 
			"Format: ^MUa,b,c "+ 
			"Parameters Details "+ 
			"a = units "+ 
			"Values: "+ 
			"D = dots "+ 
			"I = inches "+ 
			"M = millimeters "+ 
			"Default: D "+ 
			"b = format base in "+ 
			"dots per inch "+ 
			"Values: 150, 200, 300 "+ 
			"Default: a value must be entered or the command is ignored "+ 
			"c = desired dots-per- "+ 
			"inch conversion "+ 
			"Values: 300, 600 "+ 
			"Default: a value must be entered or the command is ignored "+ 
			"Example 1: This is an example of Setting Units: "+ 
			"Assume 8 dot/millimeter (203 dot/inch) printer. "+ 
			"Field based on dots: "+ 
			"^MUd^FO100,100^GB1024,128,128^FS "+ 
			"Field based on millimeters: "+ 
			"^MUm^FO12.5,12.5^GB128,16,16^FS "+ 
			"Field based on inches: "+ 
			"^MUi^FO.493,.493^GB5.044,.631,.631^FS "+ 
			"Example 2: This is an example of Converting dpi Values. "+ 
			"Convert a 150 dpi format to a 300 dpi format with a base in dots: "+ 
			"^MUd,150,300 "+ 
			"Convert a 150 dpi format to a 600 dpi format with a base in dots: "+ 
			"^MUd,150,600 "+ 
			"Convert a 200 dpi format to a 600 dpi format with a base in dots: "+ 
			"^MUd,200,600 "+ 
			"To reset the conversion factor to the original format, enter matching values for parameters b and "+ 
			"c: "+ 
			"^MUd,150,150 "+ 
			"^MUd,200,200 "+ 
			"^MUd,300,300 "+ 
			"^MUd,600,600 "+ 
			"Comments This command should appear at the beginning of the label format to be in "+ 
			"proper ZPL II format. To turn the conversion off, enter matching values for parameter "+ 
			"b and c. "+ 
			" "+ 
			"279 "+ 
			"ZPL Commands "+ 
			"^MW "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
