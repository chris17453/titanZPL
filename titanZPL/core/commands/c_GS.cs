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
    public class zpl_cmd_c_GS : zpl_command{   //Graphic Symbol
        public string orientation                                                  = String.Empty;
        public    int character_height                                             = 0;
        public    int character_width                                              = 0;
                                        
        public zpl_cmd_c_GS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^GS";                   
            description="Graphic Symbol";                   
            data_format="o,h,w ";                   
            example    ="^XA^CFD"+
			            "^FO50,50"+
			            "^FDZEBRA PROGRAMMING^FS"+
			            "^FO50,75"+
			            "^FDLANGUAGE II (ZPL II )^FS"+
			            "^FO280,75"+
			            "^GS^FDC^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            character_height                                            =(   int)argument(1,data,"i","                   ",""," ");
            character_width                                             =(   int)argument(2,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
o =field_orientation //
N = normal R = rotate 90 degrees clockwise I = inverted 180 degrees B = bottom-up, 270 degrees  //N or last ^FW value 
	
h =character_height_proportional_to_width //0 to 32000  //last ^CF value 
	
w =character_width_proportional_to_height //0 to 32000  //last ^CF valu
                                       
  **************************************************/ 
            manual=""+ 
			"^GS – Graphic Symbol "+ 
			"The ^GS command enables you to generate the registered trademark, copyright symbol, and other "+ 
			"symbols. "+ 
			"Format: ^GSo,h,w "+ 
			"Parameters Details "+ 
			"o = field orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotate 90 degrees clockwise "+ 
			"I = inverted 180 degrees "+ 
			"B = bottom-up, 270 degrees "+ 
			"Default: N or last ^FW value "+ 
			"h = character height "+ 
			"proportional to "+ 
			"width (in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Default: last ^CF value "+ 
			"w = character width "+ 
			"proportional to "+ 
			"height (in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Default: last ^CF value "+ 
			"Example: Use the ^GS command followed by ^FD and the appropriate character (A through E) "+ 
			"within the field data to generate the desired character: "+ 
			"^XA^CFD "+ 
			"^FO50,50 "+ 
			"^FDZEBRA PROGRAMMING^FS "+ 
			"^FO50,75 "+ 
			"^FDLANGUAGE II (ZPL II )^FS "+ 
			"^FO280,75 "+ 
			"^GS^FDC^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"191 "+ 
			"ZPL Commands "+ 
			"~HB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
