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
    public class zpl_cmd_c_FM : zpl_command{   //Multiple Field Origin Locations
        public string x                                                            = String.Empty;
        public    int y                                                            = 0;
                                        
        public zpl_cmd_c_FM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FM";                   
            description="Multiple Field Origin Locations";                   
            data_format="x1,y1,x2,y2,,,, ";                   
            example    ="^XA"+
			            "^FM100,100,100,600,100,1200"+
			            "^BY2,3"+
			            "^B7N,5,5,9,83,N"+
			            "^FDZebra Technologies"+
			            "Corporation strives to be"+
			            "the expert supplier of"+
			            "innovative solutions to"+
			            "specialty demand labeling"+
			            "and ticketing problems of"+
			            "business and government."+
			            "We will attract and retain"+
			            "the best people who will"+
			            "understand our customer's"+
			            "needs and provide them with"+
			            "systems, hardware, software,"+
			            "consumables and service"+
			            "offering the best value,"+
			            "high quality, and reliable"+
			            "performance, all delivered"+
			            "in a timely manner"+
			            "…"+
			            "^FS^XZ";                   
            x                                                           =(string)argument(0,data,"s","                   ",""," ");
            y                                                           =(   int)argument(1,data,"i","                   ",""," ");
                                    
  /*************************************************  
	x1 =x //
0 to 32000 e = exclude this bar code from printing  //a value must be specified y
	y1 =y //
0 to 32000 e = exclude this bar code from printing  //a value must be specified x
	x2 =x //
0 to 32000 e = exclude this bar code from printing  //a value must be specified y
	y2 =y //
0 to 32000 e = exclude this bar code from printing  //a value must be specified 
	
… =continuation_of // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^FM – Multiple Field Origin Locations "+ 
			"The ^FM command allows you to control the placement of bar code symbols. "+ 
			"It designates field locations for the PDF417 ( "+ 
			"^B7) and MicroPDF417 (^BF) bar codes when the "+ 
			"structured append capabilities are used. This allows printing multiple bar codes from the same set of "+ 
			"text information. "+ 
			"The structured append capability is a way of extending the text printing capacity of both bar codes. If "+ 
			"a string extends beyond what the data limitations of the bar code are, it can be printed as a series: 1 "+ 
			"of 3, 2 of 3, 3 of 3. Scanners read the information and reconcile it into the original, unsegmented text. "+ 
			"The "+ 
			"^FM command triggers multiple bar code printing on the same label with ^B7 and ^BF only. "+ 
			"When used with any other commands, it is ignored. "+ 
			"Format: ^FMx1,y1,x2,y2,... "+ 
			"Parameters Details "+ 
			"x1 = x-axis location "+ 
			"of first symbol "+ 
			"(in dots) "+ 
			"Values: "+ 
			"0 to 32000 "+ 
			"e = "+ 
			"exclude this bar code from printing "+ 
			"Default: a value must be specified "+ 
			"y1 = y-axis location "+ 
			"of first symbol "+ 
			"(in dots) "+ 
			"Values: "+ 
			"0 to 32000 "+ 
			"e = "+ 
			"exclude this bar code from printing "+ 
			"Default: a value must be specified "+ 
			"x2 = x-axis location "+ 
			"of second symbol "+ 
			"(in dots) "+ 
			"Values: "+ 
			"0 to 32000 "+ 
			"e = "+ 
			"exclude this bar code from printing "+ 
			"Default: a value must be specified "+ 
			"y2 = y-axis location "+ 
			"of second symbol "+ 
			"(in dots) "+ 
			"Values: "+ 
			"0 to 32000 "+ 
			"e = "+ 
			"exclude this bar code from printing "+ 
			"Default: a value must be specified "+ 
			"… = continuation of "+ 
			"X,Y pairs "+ 
			"Maximum number of pairs: 60 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FM "+ 
			"170 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This example shows you how to generate three bar codes with the text “Zebra "+ 
			"Technologies Corporation strives to be…” would need to be repeated seven times, which includes "+ 
			"2870 characters of data (including spaces) between "+ 
			"^FD and ^FS: "+ 
			"1 "+ 
			"The ellipse is not part of the code. It indicates that the text needs to be repeated "+ 
			"seven times, as mentioned in the example description. "+ 
			"^XA "+ 
			"^FM100,100,100,600,100,1200 "+ 
			"^BY2,3 "+ 
			"^B7N,5,5,9,83,N "+ 
			"^FDZebra Technologies "+ 
			"Corporation strives to be "+ 
			"the expert supplier of "+ 
			"innovative solutions to "+ 
			"specialty demand labeling "+ 
			"and ticketing problems of "+ 
			"business and government. "+ 
			"We will attract and retain "+ 
			"the best people who will "+ 
			"understand our customer's "+ 
			"needs and provide them with "+ 
			"systems, hardware, software, "+ 
			"consumables and service "+ 
			"offering the best value, "+ 
			"high quality, and reliable "+ 
			"performance, all delivered "+ 
			"in a timely manner "+ 
			"… "+ 
			"^FS^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"1 "+ 
			" "+ 
			"171 "+ 
			"ZPL Commands "+ 
			"^FM "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments Subsequent bar codes print once the data limitations of the previous bar code "+ 
			"have been exceeded. For example, bar code 2 of 3 prints once 1 of 3 has reached the "+ 
			"maximum amount of data it can hold. Specifying three fields does not ensure that three bar "+ 
			"codes print; enough field data to fill three bar code fields has to be provided. "+ 
			"The number of the x,y pairs can exceed the number of bar codes generated. However, if too few "+ 
			"are designated, no symbols print. "+ 
			"Example: This example assumes a maximum of three bar codes, with bar code 2 of 3 omitted: "+ 
			"1 "+ 
			"The ellipse is not part of the code. It indicates that the text needs to be repeated "+ 
			"seven times, as mentioned in the example description. "+ 
			"^XA "+ 
			"^FM100,100,e,e,100,1200 "+ 
			"^BY2,3 "+ 
			"^B7N,5,5,9,83,N "+ 
			"^FDZebra Technologies "+ 
			"Corporation strives to be "+ 
			"the expert supplier of "+ 
			"innovative solutions to "+ 
			"specialty demand labeling "+ 
			"and ticketing problems of "+ 
			"business and government. "+ 
			"We will attract and retain "+ 
			"the best people who will "+ 
			"understand our customer's "+ 
			"needs and provide them with "+ 
			"systems, hardware, software, "+ 
			"consumables and service "+ 
			"offering the best value, "+ 
			"high quality, and reliable "+ 
			"performance, all delivered "+ 
			"in a timely manner "+ 
			"… "+ 
			"^FS^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"1 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FN "+ 
			"172 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
