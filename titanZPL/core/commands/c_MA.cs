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
    public class zpl_cmd_c_MA : zpl_command{   //Set Maintenance Alerts
        public string type                                                         = String.Empty;
        public string print                                                        = String.Empty;
        public string printlabel_threshold                                         = String.Empty;
        public string frequency                                                    = String.Empty;
        public string units                                                        = String.Empty;
                                        
        public zpl_cmd_c_MA(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MA";                   
            description="Set Maintenance Alerts";                   
            data_format="type,print,printlabel_threshold,frequency,units ";                   
            example    ="^XA^MAC,Y,5,1^XZ";                   
            type                                                        =(string)argument(0,data,"s","                   ",""," ");
            print                                                       =(string)argument(1,data,"s","                   ",""," ");
            printlabel_threshold                                        =(string)argument(2,data,"s","                   ",""," ");
            frequency                                                   =(string)argument(3,data,"s","                   ",""," ");
            units                                                       =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	pe =type_of_alert //
R = head replacement C = head cleaning  //This parameter must be specified as R or C for print, printlabel_threshold, and frequency to be saved. However, units will always be set. prin
	nt =determines_if_the_alert_prints_a_label //
Y = print a label N = do not print label  //N printlabel thresho
	old=distance_where_the_first_alert_occurs //
R = head replacement (unit of measurement for head is km with a range of 0 to 150 km) C = clean head with a range of 100 to 2000 meters. 0 = off (when set to 0, the selected alert is disabled; otherwise it is enabled.  //
	 R =50_km // //0 (print on power-up).  ZPL Commands ^MA 266 P1012728-011 Zebra Programming Guide 11/21/16 For details resetting the units of measure, see the ~HQ examples on page 199. Comments Any values outside the specified range are ignored. The intent of this command is to cause a label to print when the defined threshold is reached. unit
	ts =odometer_and_printhead_maintenance_commands_The_units_parameter_reports_units_of_the_odometer_and_printhead_maintenance_commands //
C = centimeters (displays as: cm) I = inches (displays as: ') M = meters (displays as: M)  //I Parameters Detail
                                       
  **************************************************/ 
            manual=""+ 
			"^MA – Set Maintenance Alerts "+ 
			"The ^MA command controls how the printer issues printed maintenance alerts. Maintenance alerts "+ 
			"are labels that print with a warning that indicates the printhead needs to be cleaned or changed. "+ 
			"Supported Devices "+ 
			"• Xi4, RXi4 "+ 
			"• ZM400/ZM600, RZ400/RZ600 "+ 
			"• S4M with v53.15.5Z or later "+ 
			"•G-Series "+ 
			"Format: ^MAtype,print,printlabel_threshold,frequency,units "+ 
			"This command is available only for printers with firmware version V60.15.x, V50.15.x, or "+ 
			"later. "+ 
			"Important • "+ 
			"^MA settings do not impact or effect the functionality of the Xi4 Supplies "+ 
			"Warning system. "+ 
			"Parameters Details "+ 
			"type = type of "+ 
			"alert "+ 
			"Values: "+ 
			"R = head replacement "+ 
			"C = head cleaning "+ 
			"Default: This parameter must be specified as R or C for print, "+ 
			"printlabel_threshold, and frequency to be saved. However, units will always "+ 
			"be set. "+ 
			"print = determines "+ 
			"if the alert "+ 
			"prints a "+ 
			"label "+ 
			"Values: "+ 
			"Y = print a label "+ 
			"N = do not print label "+ 
			"Default: N "+ 
			"printlabel "+ 
			"threshold= "+ 
			"distance "+ 
			"where the "+ 
			"first alert "+ 
			"occurs "+ 
			"Values: "+ 
			"R = head replacement (unit of measurement for head is km with a range "+ 
			"of 0 to 150 km) "+ 
			"C = clean head with a range of 100 to 2000 meters. "+ 
			"0 = off (when set to 0, the selected alert is disabled; otherwise it is "+ 
			"enabled. "+ 
			"Default: R = 50 km (1,968,500 inches) and C = 0 (off). "+ 
			"frequency = "+ 
			"distance "+ 
			"before "+ 
			"reissuing the "+ 
			"alert "+ 
			"The unit of measurement is in meters. The range is 0 to 2000. The range for G- "+ 
			"Series printers is 0 or 5 to 2000 meters.When set to "+ 
			"0, the alert label is only printed "+ 
			"on power-up or when the printer is reset. "+ 
			"Default: 0 (print on power-up). "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MA "+ 
			"266 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"For details resetting the units of measure, see the ~HQ examples on page 199. "+ 
			"Comments Any values outside the specified range are ignored. "+ 
			"The intent of this command is to cause a label to print when the defined threshold is reached. "+ 
			"units = odometer "+ 
			"and printhead "+ 
			"maintenance "+ 
			"commands "+ 
			"The units parameter reports units of the odometer and printhead maintenance "+ 
			"commands, as follows: ~HQOD,~HQPH,~WQOD, ~WQPH. "+ 
			"Values: "+ 
			"C = centimeters (displays as: cm) "+ 
			"I = inches (displays as: ') "+ 
			"M = meters (displays as: M) "+ 
			"Default: I "+ 
			"Parameters Details "+ 
			"Example: This example sets the printed head cleaning message to print after five meters and to "+ 
			"repeat every one meter after that until a ~ROC command is issued. "+ 
			"The Early Warning Maintenance setting must be ON. To enable the maintenance alert system on the "+ 
			"G-Series™ printer the "+ 
			"^JH command is used; on other Zebra printers the front panel can also be "+ 
			"used. "+ 
			"1. To set ^MA to print out a label flagging the need to clean the head, type: "+ 
			"^XA^MAC,Y,5,1^XZ "+ 
			"When the threshold is met a label will print indicating that the head needs to be clean. "+ 
			"2. For this example, the message on the label looks like this: "+ 
			" "+ 
			"267 "+ 
			"ZPL Commands "+ 
			"^MC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
