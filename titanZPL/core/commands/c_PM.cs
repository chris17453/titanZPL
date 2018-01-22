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
    public class zpl_cmd_c_PM : zpl_command{   //Printing Mirror Image of Label
        public string print_mirror_image_of_entire_label                           = String.Empty;
                                        
        public zpl_cmd_c_PM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PM";                   
            description="Printing Mirror Image of Label";                   
            data_format="a ";                   
            example    ="^XA^PMY"+
			            "^FO100,100"+
			            "^CFG"+
			            "^FDMIRROR^FS"+
			            "^FO100,160"+
			            "^FDIMAGE^FS"+
			            "^XZ";                   
            print_mirror_image_of_entire_label                          =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =print_mirror_image_of_entire_label //
N = no Y = yes  //
                                       
  **************************************************/ 
            manual=""+ 
			"^PM – Printing Mirror Image of Label "+ 
			"The ^PM command prints the entire printable area of the label as a mirror image. This command flips "+ 
			"the image from left to right. "+ 
			"Format: ^PMa "+ 
			"Comments If the parameter is missing or invalid, the command is ignored. Once entered, "+ 
			"the "+ 
			"^PM command remains active until ^PMN is received or the printer is turned off. "+ 
			"Parameters Details "+ 
			"a = print mirror "+ 
			"image of entire "+ 
			"label "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"Example: This is an example of printing a mirror image on a label: "+ 
			"^XA^PMY "+ 
			"^FO100,100 "+ 
			"^CFG "+ 
			"^FDMIRROR^FS "+ 
			"^FO100,160 "+ 
			"^FDIMAGE^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"293 "+ 
			"ZPL Commands "+ 
			"^PN "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
