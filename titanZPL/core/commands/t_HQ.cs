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
    public class zpl_cmd_t_HQ : zpl_command{   //Host Query
        public string query_type                                                   = String.Empty;
                                        
        public zpl_cmd_t_HQ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~HQ";                   
            description="Host Query";                   
            data_format="query-type ";                   
            example    ="";                   
            query_type                                                  =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~HQ – Host Query "+ 
			"The ~HQ command group causes the printer to send information back to the host. "+ 
			"Supported Devices "+ 
			"• Xi4, RXi4 "+ 
			"• ZM400/ZM600 with v53.17.1Z or later, RZ400/RZ600 "+ 
			"• S4M with v53.17.1Z or later "+ 
			"• G-Series with v56.16.5 or later "+ 
			"or "+ 
			"G-Series with v61.16.5 or later "+ 
			"Format: ~HQquery-type "+ 
			"Comments The response to the ~HQ command starts with STX, a CR LF is inserted between "+ 
			"each line, and the response ends with ETX. "+ 
			"Parameter Details "+ 
			"query-type For detailed examples of these parameters, see ~HQ Examples on page 199. "+ 
			"Values: "+ 
			"ES = requests the printer’s status - see Table 14 on page 198 and Table 15 "+ 
			"on page 199 "+ 
			"HA = hardware address of the internal wired print server "+ 
			"JT = requests a summary of the printer’s printhead test results "+ 
			"MA = maintenance alert settings "+ 
			"MI = maintenance information "+ 
			"OD = odometer "+ 
			"PH = printhead life history "+ 
			"PP = printer’s Plug and Play string "+ 
			"SN = printer’s serial number "+ 
			"UI = USB product ID and BDC release version "+ 
			"Default: must be an accepted value or the command is ignored "+ 
			"Table 14 • Error Flags (~HQES) "+ 
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
			"g. This error flag is supported only on KR403 printers. "+ 
			" "+ 
			"199 "+ 
			"ZPL Commands "+ 
			"~HQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"~HQ Examples "+ 
			"This section provides detail examples of all the available parameters. "+ 
			"Cutter Fault 100000000XXXXXXX8 "+ 
			"Head Open 100000000XXXXXXX4 "+ 
			"Ribbon Out 100000000XXXXXXX2 "+ 
			"Media Out 100000000XXXXXXX1 "+ 
			"Clear Paper Path Failed "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000XXXX8 "+ 
			"g "+ 
			"XXX "+ 
			"Paper Feed Error "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000XXXX4 "+ 
			"g "+ 
			"XXX "+ 
			"Presenter Not Running "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000XXXX2 "+ 
			"g "+ 
			"XXX "+ 
			"Paper Jam during Retract "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000XXXX1 "+ 
			"g "+ 
			"XXX "+ 
			"Black Mark not Found "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000 X X X 8 "+ 
			"g "+ 
			"XXXX "+ 
			"Black Mark Calabrate Error "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000 X X X 4 "+ 
			"g "+ 
			"XXXX "+ 
			"Retract Function timed out "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000 X X X 2 "+ 
			"g "+ 
			"XXXX "+ 
			"Paused "+ 
			"g "+ 
			"1 "+ 
			"g "+ 
			"00000000 X X X 1 "+ 
			"g "+ 
			"XXXX "+ 
			"Table 14 • Error Flags (~HQES) "+ 
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
			"g. This error flag is supported only on KR403 printers. "+ 
			"Table 15 • Warning Flags (~HQES) "+ 
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
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXXXX8 "+ 
			"h "+ 
			"Replace Printhead 100000000XXXXXXX4 "+ 
			"Clean Printhead 100000000XXXXXXX2 "+ 
			"Need to Calibrate Media 100000000XXXXXXX1 "+ 
			"Sensor 1 (Paper before head) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXXX1 "+ 
			"h "+ 
			"X "+ 
			"Sensor 2 (Black mark) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXXX2 "+ 
			"h "+ 
			"X "+ 
			"Sensor 3 (Paper after head) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXXX4 "+ 
			"h "+ 
			"X "+ 
			"Sensor 4 (loop ready) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXXX8 "+ 
			"h "+ 
			"X "+ 
			"Sensor 5 (presenter) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXX1 "+ 
			"h "+ 
			"XX "+ 
			"Sensor 6 (retract ready) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXX2 "+ 
			"h "+ 
			"XX "+ 
			"Sensor 7 (in retract) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXX4 "+ 
			"h "+ 
			"XX "+ 
			"Sensor 8 (at bin) "+ 
			"h "+ 
			"1 "+ 
			"h "+ 
			"00000000XXXXX8 "+ 
			"h "+ 
			"XX "+ 
			"h. This error flag is supported only on KR403 printers. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HQ "+ 
			"200 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"This illustration identifies the printer status definitions: "+ 
			"Example 1: This example shows how to request the printer’s status. "+ 
			"a. To request the printer’s status, type ~HQES "+ 
			"The printer responds with data similar to this: "+ 
			"PRINTER STATUS "+ 
			"ERRORS: 1 00000000 00000005 "+ 
			"WARNINGS: 1 00000000 00000002 "+ 
			"In this example, the Printer Status resolves to these conditions: "+ 
			"• The cover/printhead is open (value = 4). "+ 
			"• Media is out or not loaded into the printer (value = 1). "+ 
			"• The printhead needs to be cleaned (value = 2). "+ 
			"• Error nibble 1 is equal to 5 when the error status values are added together (4 + 1). "+ 
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
			"Example 2: This example shows how the printer responds when the printer receives the "+ 
			"~HQES command: "+ 
			"a. To see how the printer responds, type ~HQES "+ 
			"The printer responds with data similar to this: "+ 
			"PRINTER STATUS "+ 
			"ERRORS: 1 00000000 0000000B "+ 
			"WARNINGS: 0 00000000 00000000 "+ 
			"In this example, the printer status resolves to the following conditions: "+ 
			"• The cutter has a fault (value = 8). "+ 
			"• Ribbon is out or not loaded into the printer (value = 2). "+ 
			"• Media is out or not loaded into the printer (value = 1). "+ 
			"• Error byte 1 is equal to B when the error status values are added together "+ 
			"( "+ 
			"8 + 2 + 1 = hexadecimal B). "+ 
			"PRINTER STATUS "+ 
			"ERRORS: 1 00000000 00000005 "+ 
			"WARNINGS: 1 00000000 00000002 "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"5 "+ 
			"6 "+ 
			" "+ 
			"201 "+ 
			"ZPL Commands "+ 
			"~HQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"This illustration identifies the printhead test field definitions: "+ 
			"Example 3: This is an example of how to retrieve the hardware address of the internal wired "+ 
			"print server. "+ 
			"a. To get the hardware address of the internal wired print server, type ~HQHA "+ 
			"The printer responds with data similar to this: "+ 
			"MAC ADDRESS "+ 
			"00:07:4d:2c:e0:7a "+ 
			"Example 4: This is an example of how to request a summary of the printer’s printhead test "+ 
			"results. "+ 
			"The ^JT command is used to initiate printhead testing, set the testing interval, and set the element "+ 
			"range to be tested. For more details see, ^JT on page 245. "+ 
			"a. To request a summary of the printer’s printhead test, type ~HQJT "+ 
			"The printer responds with data similar to this: "+ 
			"PRINT HEAD TEST RESULTS "+ 
			"0,A,0000,0000,0000 "+ 
			"When the printer has printed enough labels to trigger a printhead test, the initial data "+ 
			"changes. "+ 
			"b. To request a summary of the printer’s printhead test, type ~HQJT "+ 
			"The printer responds with data similar to this: "+ 
			"PRINT HEAD TEST RESULTS: "+ 
			"0,A,0015,0367,0000 "+ 
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
			"0,A,0000,0000,0000 "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"4 "+ 
			"5 "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HQ "+ 
			"202 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example 5: This is an example of how to use the maintenance alert query for the ~HQ "+ 
			"command. "+ 
			"a. To get the current settings, type ~HQMA "+ 
			"The printer responds with data similar to this: "+ 
			"~HQMA "+ 
			"MAINTENANCE ALERT SETTINGS "+ 
			"HEAD REPLACEMENT INTERVAL: 1 km "+ 
			"HEAD REPLACEMENT FREQUENCY: 0 M "+ 
			"HEAD CLEANING INTERVAL: 0 M "+ 
			"HEAD CLEANING FREQUENCY: 0 M "+ 
			"PRINT REPLACEMENT ALERT: NO "+ 
			"PRINT CLEANING ALERT: NO "+ 
			"UNITS: C "+ 
			"Example 6: This is an example of how to use the maintenance information query for the "+ 
			"~HQ "+ 
			"command. Note that the message is controlled by the "+ 
			"^MI command. "+ 
			"a. To get the current settings, type ~HQMI "+ 
			"The printer responds with data similar to this: "+ 
			"MAINTENANCE ALERT MESSAGES "+ 
			"CLEAN: PLEASE CLEAN PRINT HEAD "+ 
			"REPLACE: PLEASE REPLACE PRINT HEAD "+ 
			"Example 7: This is an example of how to use the odometer query for the "+ 
			"~HQ command. Note "+ 
			"that the units of measure are controlled by the "+ 
			"^MA command. Also, if the 'Early Warning "+ 
			"Maintenance State' is turned 'ON' the printer response would also list LAST CLEANED and "+ 
			"CURRENT PRINTHEAD LIFE counters. "+ 
			"a. To get the current settings, type ~HQOD "+ 
			"The printer responds with data similar to this: "+ 
			"PRINT METERS "+ 
			"TOTAL NONRESETTABLE: 8560 ' "+ 
			"USER RESETTABLE CNTR1: 9 ' "+ 
			"USER RESETTABLE CNTR2: 8560 ' "+ 
			"The units of measure are set to inches. "+ 
			"b. To change the units of measure to centimeters, type: "+ 
			"^XA^MA,,,,C "+ 
			"^XZ "+ 
			"The units of measure are set to centimeters. "+ 
			"c. To check the settings, type ~HQOD "+ 
			"The printer responds with data similar to this: "+ 
			"PRINT METERS "+ 
			"TOTAL NONRESETTABLE: 21744 cm "+ 
			"USER RESETTABLE CNTR1: 24 cm "+ 
			"USER RESETTABLE CNTR2: 21744 cm "+ 
			" "+ 
			"203 "+ 
			"ZPL Commands "+ 
			"~HQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example 8: This is an example of how to use the printhead life query for the ~HQ command. "+ 
			"Note that the units of measure are controlled by the "+ 
			"^MA command. "+ 
			"a. To get the current settings, type ~HQPH "+ 
			"The printer responds with data similar to this: "+ 
			"1 "+ 
			"The current life of the print head. "+ 
			"2 "+ 
			"Line items 2 through 10 (the example only shows 2 through 3) "+ 
			"tracks the measurement for each time the print head is "+ 
			"changed. "+ 
			"Example 9: This is an example of how to request the printer’s Plug and Play string. "+ 
			"a. To request the printer’s Plug and Play string, type ~HQPP "+ 
			"The printer responds with data similar to this: "+ 
			"PLUG AND PLAY MESSAGES "+ 
			"MFG: Zebra Technologies "+ 
			"CMD: ZPL "+ 
			"MDL: GX420t "+ 
			"Example 10: This is an example of how to retrieve the printer’s serial number. "+ 
			"a. To get the printer’s serial number, type ~HQSN "+ 
			"The printer responds with data similar to this: "+ 
			"SERIAL NUMBER "+ 
			"41A06440023 "+ 
			"Example 11: This is an example of how to retrieve the printer’s USB product ID and BCD "+ 
			"release version. "+ 
			"a. To get the printer’s USB product ID and BCD release version, type ~HQUI "+ 
			"The printer responds with data similar to this: "+ 
			"USB INFORMATION "+ 
			"PID: 0085 "+ 
			"RELEASE VERSION: 15.01 "+ 
			"LAST CLEANED: 257 ' "+ 
			"HEAD LIFE HISTORY "+ 
			"# DISTANCE "+ 
			"1: 257 ' "+ 
			"2: 1489 ' "+ 
			"3: 7070 ' "+ 
			"1 "+ 
			"2 "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HS "+ 
			"204 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
