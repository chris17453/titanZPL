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
    public class zpl_cmd_c_SI : zpl_command{   //Set Sensor Intensity
        public string indicates_the_setting_to_modify                              = String.Empty;
        public string the_value_to_use_for_the_sensor_being_configured_the_ranges_for_this_parameter_are_the_same_for_the_accepted_values_in_parameter_a = String.Empty;
                                        
        public zpl_cmd_c_SI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SI";                   
            description="Set Sensor Intensity";                   
            data_format="a,b ";                   
            example    ="";                   
            indicates_the_setting_to_modify                             =(string)argument(0,data,"s","                   ",""," ");
            the_value_to_use_for_the_sensor_being_configured_the_ranges_for_this_parameter_are_the_same_for_the_accepted_values_in_parameter_a=(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =indicates_the_setting_to_modify //
1 = transmissive sensor brightness setting 2 = transmissive sensor baseline setting  //must be an accepted value or the entire command is ignored 
	
b =the_value_to_use_for_the_sensor_being_configured_The_ranges_for_this_parameter_are_the_same_for_the_accepted_values_in_parameter_a //0 to 196  //must be an accepted value or the entire command is ignored  ZPL Commands ^SL 310 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^SI – Set Sensor Intensity "+ 
			"The ^SI command is used to change the values for the media sensors, which are also set during "+ 
			"the media calibration process. The media calibration process is described in your specific printer’s "+ 
			"user’s guide. "+ 
			"Supported Devices "+ 
			"• Xi4 with firmware V53.17.1Z or later "+ 
			"• RXi4 with firmware V53.17.7Z or later "+ 
			"• ZM400/ZM600 with firmware V53.15.xZ or later "+ 
			"• RZ400/RZ600 wtih firmware R53.15.xZ or later "+ 
			"Format: ^SIa,b "+ 
			"This command is available only for printers with firmware versions V53.15.x or later. "+ 
			"Parameters Details "+ 
			"a = indicates the "+ 
			"setting to "+ 
			"modify "+ 
			"Values: "+ 
			"1 = transmissive sensor brightness setting "+ 
			"2 = transmissive sensor baseline setting "+ 
			"Default: must be an accepted value or the entire command is ignored "+ 
			"b = the value to use "+ 
			"for the sensor "+ 
			"being configured "+ 
			"The ranges for this parameter are the same for the accepted values in parameter a. "+ 
			"Values: 0 to 196 "+ 
			"Default: must be an accepted value or the entire command is ignored "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SL "+ 
			"310 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
