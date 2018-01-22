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
    public class zpl_cmd_c_FO : zpl_command{   //Field Origin
        public int x                = 0;
        public int y                = 0;
        public int justification    = 0;
                                        
        public zpl_cmd_c_FO(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FO";                   
            description="Field Origin";                   
            data_format="x,y,z ";                   
            example    ="";                   
            x                                               =(int)argument(0,data,"i","0-32000","","0");
            y                                               =(int)argument(1,data,"i","0-32000","","0");
            justification                                   =(int)argument(2,data,"i","0-2"    ,"","0"); 
                                    
  /*************************************************  
	
x =x //0 to 32000  //0 
	
y =y //0 to 32000  //0 
	
z =justification_The_z_parameter_is_only_supported_in_firmware_versions_V60 //
0 = left justification 1 = right justification 2 = auto justification (script dependent)  //last accepted ^FW value or ^FW default This command interacts with the field direction parameter of ^FP and with the rotation parameter of ^A. For output and examples, see Field Interactions on page 1319. The auto justification option might cause unexpected results if variable fields or bidirectional text are used with ^FO. For the best results with bidirectional text and/or variable fields, use either the left of right justification option.  ZPL Commands ^FP 174 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^FO – Field Origin "+ 
			"The ^FO command sets a field origin, relative to the label home (^LH) position. ^FO sets the upper- "+ 
			"left corner of the field area by defining points along the x-axis and y-axis independent of the rotation. "+ 
			"Format: ^FOx,y,z "+ 
			"Comments If the value entered for the x or y parameter is too high, it could position the "+ 
			"field origin completely off the label. "+ 
			"Parameters Details "+ 
			"x = x-axis location "+ 
			"(in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Default: 0 "+ 
			"y = y-axis location "+ 
			"(in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Default: 0 "+ 
			"z = justification "+ 
			"The z parameter is only "+ 
			"supported in firmware "+ 
			"versions V60.14.x, V50.14.x, "+ 
			"or later. "+ 
			"Values: "+ 
			"0 = left justification "+ 
			"1 = right justification "+ 
			"2 = auto justification (script dependent) "+ 
			"Default: last accepted ^FW value or ^FW default "+ 
			"This command interacts with the field direction parameter of ^FP and with the rotation parameter of "+ 
			"^A. For output and examples, see Field Interactions on page 1319. "+ 
			"The auto justification option might cause unexpected results if variable fields or "+ 
			"bidirectional text are used with "+ 
			"^FO. For the best results with bidirectional text and/or "+ 
			"variable fields, use either the left of right justification option. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FP "+ 
			"174 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
