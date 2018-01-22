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
    public class zpl_cmd_t_WQ : zpl_command{   //Write Query
        public string query_type                                                   = String.Empty;
                                        
        public zpl_cmd_t_WQ(string data,List<zpl_command> commands):base(commands){          
            cmd        ="~WQ";                   
            description="Write Query";                   
            data_format="query-type ";                   
            example    ="";                   
            query_type                                                  =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~WQ – Write Query "+ 
			"The ~WQ command triggers the printer to print a label with odometer, maintenance or alert, and "+ 
			"printhead history information. "+ 
			"Supported Devices "+ 
			"• Xi4 with firmware V53.17.1Z or later "+ 
			"• RXi4 with firmware V53.17.7Z or later "+ 
			"• ZM400/ZM600 with firmware V53.15.xZ or later "+ 
			"• RZ400/RZ600 with firmware R53.15.xZ or later "+ 
			"• S4M with firmware V53.15.4Z or later "+ 
			"•G-Series "+ 
			"Format: ~WQquery-type "+ 
			"Parameter Details "+ 
			"query-type For detailed examples of these parameters, see ~WQ Examples on page 331. "+ 
			"Values: "+ 
			"ES = requests the printer’s status. For details see, Table 17 on page 330 "+ 
			"and Table 18 on page 331. "+ 
			"HA = hardware address of the internal wired print server "+ 
			"JT = requests a summary of the printer’s printhead test results "+ 
			"MA = maintenance alert settings "+ 
			"MI = maintenance information "+ 
			"OD = odometer "+ 
			"PH = printhead life history "+ 
			"PP = printer’s Plug and Play string "+ 
			"SN = printer’s serial number "+ 
			"UI = printer’s USB product ID and BCD release version "+ 
			"Default: must be an accepted value or the command is ignored "+ 
			"Table 17 • Error Flags (~WQES) "+ 
			"Error Flags Flag "+ 
			"Group 2 Group 1 (X = Value can be any hexadecimal number [0-9, A-F]) "+ 
			"Nibbles16-9 "+ 
			"Nibble "+ 
			"8 "+ 
			"Nibble "+ 
			"7 "+ 
			"Nibble "+ 
			"6 "+ 
			"Nibble "+ 
			"5 "+ 
			"Nibble "+ 
			"4 "+ 
			"Nibble "+ 
			"3 "+ 
			"Nibble "+ 
			"2 "+ 
			"Nibble "+ 
			"1 "+ 
			"No Error 00000000000000000 "+ 
			"Error Present 100000000XXXXXXXX "+ 
			"Printhead Thermistor Open100000000XXXXX2XX "+ 
			"Invalid Firmware Config. 100000000XXXXX1XX "+ 
			"Printhead Detection Error100000000XXXXXX8X "+ 
			"Bad Printhead Element 100000000XXXXXX4X "+ 
			"Motor Over Temperature100000000XXXXXX2X "+ 
			"Printhead Over Temperature100000000XXXXXX1X "+ 
			"Cutter Fault 100000000XXXXXXX8 "+ 
			"Head Open 100000000XXXXXXX4 "+ 
			"ab.This error flag is supported only on KR403 printers. "+ 
			" "+ 
			"331 "+ 
			"ZPL Commands "+ 
			"~WQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"~WQ Examples "+ 
			"This section provides detailed examples of all the available parameters. "+ 
			"Ribbon Out 100000000XXXXXXX2 "+ 
			"Media Out 100000000XXXXXXX1 "+ 
			"Clear Paper Path Failed "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000XXXX8 "+ 
			"ab "+ 
			"XXX "+ 
			"Paper Feed Error "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000XXXX4 "+ 
			"ab "+ 
			"XXX "+ 
			"Presenter Not Running "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000XXXX2 "+ 
			"ab "+ 
			"XXX "+ 
			"Paper Jam during Retract "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000XXXX1 "+ 
			"ab "+ 
			"XXX "+ 
			"Black Mark not Found "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000 X X X 8 "+ 
			"ab "+ 
			"XXXX "+ 
			"Black Mark Calabrate Error "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000 X X X 4 "+ 
			"ab "+ 
			"XXXX "+ 
			"Retract Function timed out "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000 X X X 2 "+ 
			"ab "+ 
			"XXXX "+ 
			"Paused "+ 
			"ab "+ 
			"1 "+ 
			"ab "+ 
			"00000000 X X X 1 "+ 
			"ab "+ 
			"XXXX "+ 
			"Table 17 • Error Flags (~WQES) (Continued) "+ 
			"Error Flags Flag "+ 
			"Group 2 Group 1 (X = Value can be any hexadecimal number [0-9, A-F]) "+ 
			"Nibbles16-9 "+ 
			"Nibble "+ 
			"8 "+ 
			"Nibble "+ 
			"7 "+ 
			"Nibble "+ 
			"6 "+ 
			"Nibble "+ 
			"5 "+ 
			"Nibble "+ 
			"4 "+ 
			"Nibble "+ 
			"3 "+ 
			"Nibble "+ 
			"2 "+ 
			"Nibble "+ 
			"1 "+ 
			"ab.This error flag is supported only on KR403 printers. "+ 
			"Table 18 • Warning Flags (~WQES) "+ 
			"Error Flags Flag "+ 
			"Group 2 Group 1 (X = Value can be any hexadecimal number [0-9, A-F]) "+ 
			"Nibbles16-9 "+ 
			"Nibble "+ 
			"8 "+ 
			"Nibble "+ 
			"7 "+ 
			"Nibble "+ 
			"6 "+ 
			"Nibble "+ 
			"5 "+ 
			"Nibble "+ 
			"4 "+ 
			"Nibble "+ 
			"3 "+ 
			"Nibble "+ 
			"2 "+ 
			"Nibble "+ 
			"1 "+ 
			"No Warning 00000000000000000 "+ 
			"Warning Present 100000000XXXXXXXX "+ 
			"Paper-near-end Sensor "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXXXX8 "+ 
			"ac "+ 
			"Replace Printhead 100000000XXXXXXX4 "+ 
			"Clean Printhead 100000000XXXXXXX2 "+ 
			"Need to Calibrate Media 100000000XXXXXXX1 "+ 
			"Sensor 1 (Paper before head) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXXX1 "+ 
			"ac "+ 
			"X "+ 
			"Sensor 2 (Black mark) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXXX2 "+ 
			"ac "+ 
			"X "+ 
			"Sensor 3 (Paper after head) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXXX4 "+ 
			"ac "+ 
			"X "+ 
			"Sensor 4 (loop ready) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXXX8 "+ 
			"ac "+ 
			"X "+ 
			"Sensor 5 (presenter) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXX1 "+ 
			"ac "+ 
			"XX "+ 
			"Sensor 6 (retract ready) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXX2 "+ 
			"ac "+ 
			"XX "+ 
			"Sensor 7 (in retract) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXX4 "+ 
			"ac "+ 
			"XX "+ 
			"Sensor 8 (at bin) "+ 
			"ac "+ 
			"1 "+ 
			"ac "+ 
			"00000000XXXXX8 "+ 
			"ac "+ 
			"XX "+ 
			"ac.This error flag is supported only on KR403 printers. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~WQ "+ 
			"332 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"This illustration identifies the printer status definitions: "+ 
			"Example 1: This example shows how to request the printer’s status. "+ 
			"1. To request the printer’s status, type ~WQES "+ 
			"A label similar to this prints out: "+ 
			"In this example, the Printer Status resolves to these conditions: "+ 
			"• The cover/printhead is open (value = 4). "+ 
			"• Media is out or not loaded into the printer (value = 1). "+ 
			"• The printhead needs to be cleaned (value = 2). "+ 
			"• Error nibble 1 is equal to 5 when the error status values are added together (4+1). "+ 
			"1 "+ 
			"Flag "+ 
			"2 "+ 
			"Nibble 16-9 "+ 
			"3 "+ 
			"Nibble 8-4 "+ 
			"4 "+ 
			"Nibble 3 "+ 
			"5 "+ 
			"Nibble 2 "+ 
			"6 "+ 
			"Nibble 1 "+ 
			"Example 2: This example shows how to request the printer’s status. "+ 
			"1. To request the printer’s status, type ~WQES "+ 
			"A label similar to this prints out: "+ 
			"In the example shown above, the Printer Status resolves to the following conditions: "+ 
			"• The cutter has a fault. (value = 8). "+ 
			"• Ribbon is out or not loaded into the printer (value = 2). "+ 
			"• Media is out or not loaded into the printer (value = 1). "+ 
			"• Error byte 1 is equal to B when the error status values are added together "+ 
			"( "+ 
			"8 + 2 + 1 = hexadecimal B). "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"5 "+ 
			"6 "+ 
			" "+ 
			"333 "+ 
			"ZPL Commands "+ 
			"~WQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"This illustration identifies the printhead test field definitions: "+ 
			"Example 3: This is an example of how to print the hardware address of the internal wired "+ 
			"print server. "+ 
			"1. To print the hardware address of the internal wired print server, type ~WQHA "+ 
			"A label similar to this prints out: "+ 
			"Example 4: This is an example of how to print a summary of the printer’s printhead test "+ 
			"results. "+ 
			"The ^JT command is used to initiate printhead testing, set the testing interval, and set the element "+ 
			"range to be tested. For more details see, ^JT on page 245. "+ 
			"1. To request a summary of the printer’s printhead test, type ~WQJT "+ 
			"A label similar to this prints out: "+ 
			"When the printer has printed enough labels to trigger a printhead test, the initial data "+ 
			"changes. "+ 
			"1. To request a summary of the printer’s printhead test, type ~WQJT "+ 
			"A label similar to this prints out: "+ 
			"1 "+ 
			"Element failure "+ 
			"2 "+ 
			"Manual (M) or automatic (A) range "+ 
			"3 "+ 
			"First test element "+ 
			"4 "+ 
			"Last test element "+ 
			"5 "+ 
			"Failure count "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"5 "+ 
			" "+ 
			"ZPL Commands "+ 
			"~WQ "+ 
			"334 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example 5: This is an example of how to print the maintenance alert query for the ~WQ "+ 
			"command. "+ 
			"1. To get the current settings, type ~WQMA "+ 
			"A label similar to this prints out: "+ 
			"Example 6: This is an example of how to use the odometer query for the ~WQ command. Note "+ 
			"that the units of measure are controlled by the "+ 
			"^MA command. Also, if the 'Early Warning "+ 
			"Maintenance State' is turned 'ON' the printer response would also list LAST CLEANED and "+ 
			"CURRENT PRINTHEAD LIFE counters. "+ 
			"1. To get the current settings, type ~WQOD "+ 
			"A label similar to this prints out: "+ 
			"The units of measure are set to inches. "+ 
			"1. To change the units of measure to centimeters, type: "+ 
			"^XA^MA,,,,C "+ 
			"^XZ "+ 
			"The units of measure are set to centimeters. "+ 
			"2. To check the settings, type ~WQOD. "+ 
			"A label similar to this prints out: "+ 
			"Example 7: This is an example of how to print the maintenance information query for the "+ 
			"~WQ command. Note that the message is controlled by the ^MI command. "+ 
			"1. To get the current settings, type ~WQMI "+ 
			"A label similar to this prints out: "+ 
			" "+ 
			"335 "+ 
			"ZPL Commands "+ 
			"~WQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example 8: This is an example of how to print the printhead life query for the ~WQ command. "+ 
			"Note that the units of measure are controlled by the "+ 
			"^MA command. "+ 
			"1. To get the current settings, type ~WQPH "+ 
			"A label similar to this prints out: "+ 
			"1 "+ 
			"The current life of the print head. "+ 
			"2 "+ 
			"Line items 2 through 10 (the example only shows 2 through 3) "+ 
			"tracks the measurement for each time the print head is "+ 
			"changed. "+ 
			"Example 9: This is an example of how to print the printer’s Plug and Play string. "+ 
			"1. To print the printer’s Plug and Play string, type ~WQPP "+ 
			"A label similar to this prints out: "+ 
			"Example 10: This is an example of how to print the printer’s serial number. "+ 
			"1. To get the printer’s serial number, type ~WQSN "+ 
			"A label similar to this prints out: "+ 
			"Example 11: This is an example of how to print the printer’s USB product ID and BCD release "+ 
			"version. "+ 
			"1. To print the printer’s USB product ID and BCD release version, type ~WQUI "+ 
			"A label similar to this prints out: "+ 
			"1 "+ 
			"2 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^XA "+ 
			"336 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
