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
    public class zpl_cmd_c_FT : zpl_command{   //Field Typeset
          public int x                = 0;
        public int y                = 0;
        public int justification    = 0;
                                        
       public zpl_cmd_c_FT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FT";                   
            description="Field Typeset";                   
            data_format="x,y,z ";                   
            example    ="";                   
            x                                               =(int)argument(0,data,"i","0-32000","","0");
            y                                               =(int)argument(1,data,"i","0-32000","","0");
            justification                                   =(int)argument(2,data,"i","0-2"    ,"","0"); 
                                    
  /*************************************************  
	
x =x //0 to 32000  //position after last formatted text field 
	
y =y //0 to 32000  //position after last formatted text field 
	
z =justification_The_z_parameter_is_only_supported_in_firmware_version_V60 //
0 = left justification 1 = right justification 2 = auto justification (script dependent)  //last accepted ^FW value or ^FW default The auto justification option may cause unexpected results if variable fields or bidirectional text are used with ^FT. For best results with bidirectional text and/or variable fields, use either the left of right justification options. Left Justified Text For examples, see Field Interactions on page 1319. Bar Codes Origin is base of bar code, at left edge Graphic Boxes Origin is bottom-left corner of the box Images Origin is bottom-left corner of the image area Right Justified Text For examples, see Field Interactions on page 1319. Bar Codes Origin is base of bar code, at right edge Graphic Boxes Origin is bottom-right corner of the box Images Origin is bottom-right corner of the image area  ZPL Commands ^FT 178 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^FT – Field Typeset "+ 
			"The ^FT command sets the field position, relative to the home position of the label designated by the "+ 
			"^LH command. The typesetting origin of the field is fixed with respect to the contents of the field and "+ 
			"does not change with rotation. "+ 
			"Format: ^FTx,y,z "+ 
			"Table 13 • Typeset Justification "+ 
			"Note • "+ 
			"The ^FT command is capable of concantination of fields. "+ 
			"Parameters Details "+ 
			"x = x-axis location "+ 
			"(in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Default: position after last formatted text field "+ 
			"y = y-axis location "+ 
			"(in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Default: position after last formatted text field "+ 
			"z = justification "+ 
			"The z parameter is only "+ 
			"supported in firmware "+ 
			"version V60.14.x, V50.14.x, "+ 
			"or later. "+ 
			"Values: "+ 
			"0 = left justification "+ 
			"1 = right justification "+ 
			"2 = auto justification (script dependent) "+ 
			"Default: last accepted ^FW value or ^FW default "+ 
			"The auto justification option may cause unexpected results if variable fields or "+ 
			"bidirectional text are used with "+ 
			"^FT. For best results with bidirectional text and/or "+ 
			"variable fields, use either the left of right justification options. "+ 
			"Left "+ 
			"Justified "+ 
			"Text For examples, see Field Interactions on page 1319. "+ 
			"Bar Codes Origin is base of bar code, at left edge "+ 
			"Graphic Boxes Origin is bottom-left corner of the box "+ 
			"Images Origin is bottom-left corner of the image area "+ 
			"Right "+ 
			"Justified "+ 
			"Text For examples, see Field Interactions on page 1319. "+ 
			"Bar Codes Origin is base of bar code, at right edge "+ 
			"Graphic Boxes Origin is bottom-right corner of the box "+ 
			"Images Origin is bottom-right corner of the image area "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FT "+ 
			"178 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of the ^FT command and concatenation: "+ 
			"When a coordinate is missing, the position following the last formatted field is assumed. This "+ 
			"remembering simplifies field positioning with respect to other fields. Once the first field is positioned, "+ 
			"other fields follow automatically. "+ 
			"There are several instances where using the "+ 
			"^FT command without specifying x and y parameters "+ 
			"is not recommended: "+ 
			"• when positioning the first field in a label format "+ 
			"• at any time with the "+ 
			"^FN (Field Number) command "+ 
			"• following an ^SN (Serialization Data) command "+ 
			"• variable data "+ 
			"• bidirectional text "+ 
			"The right typeset justified is available only for printers with firmware version V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			"This command interacts with the field direction parameters of ^FP and with the rotation parameter "+ 
			"of "+ 
			"^A. For output and code examples, see Field Interactions on page 1319 "+ 
			" "+ 
			"179 "+ 
			"ZPL Commands "+ 
			"^FV "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
