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
    public class zpl_cmd_c_SS : zpl_command{   //Set Media Sensors
        public string web                                                          = String.Empty;
        public string media                                                        = String.Empty;
        public string ribbon                                                       = String.Empty;
        public string label_length                                                 = String.Empty;
        public string intensity_of_media_led                                       = String.Empty;
        public string intensity_of_ribbon_led                                      = String.Empty;
        public string mark_sensing                                                 = String.Empty;
        public string mark_media_sensing                                           = String.Empty;
        public string mark_led_sensing                                             = String.Empty;
                                        
        public zpl_cmd_c_SS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SS";                   
            description="Set Media Sensors";                   
            data_format="w,m,r,l,m2,r2,a,b,c ";                   
            example    ="";                   
            web                                                         =(string)argument(0,data,"s","                   ",""," ");
            media                                                       =(string)argument(1,data,"s","                   ",""," ");
            ribbon                                                      =(string)argument(2,data,"s","                   ",""," ");
            label_length                                                =(string)argument(3,data,"s","                   ",""," ");
            intensity_of_media_led                                      =(string)argument(4,data,"s","                   ",""," ");
            intensity_of_ribbon_led                                     =(string)argument(5,data,"s","                   ",""," ");
            mark_sensing                                                =(string)argument(6,data,"s","                   ",""," ");
            mark_media_sensing                                          =(string)argument(7,data,"s","                   ",""," ");
            mark_led_sensing                                            =(string)argument(8,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
w =web //000 to 100  //value shown on the media sensor profile or configuration label 
	
m =media //000 to 100  //value shown on the media sensor profile or configuration label 
	
r =ribbon //000 to 100  //value shown on the media sensor profile or configuration label 
	
l =label_length //0001 to 32000  //value calculated in the calibration process m
	m2 =intensity_of_media_LED //000 to 255  //value calculated in the calibration process r
	r2 =intensity_of_ribbon_LED //000 to 255  //value calculated in the calibration process 
	
a =mark_sensing //000 to 100  //value calculated in the calibration process 
	
b =mark_media_sensing //000 to 100  //value calculated in the calibration process 
	
c =mark_LED_sensing //000 to 255  //value calculated in the calibration process  319 ZPL Commands ^SS 11/21/16 Zebra Programming Guide P1012728-011 The media and sensor profiles produced vary in appearance from printer to printer. Comments The m2 and r2 parameters have no effect in Stripe ® S-300 and S-500 printers. This command is ignored on the HC100™ printer. Maximum values for parameters depend on which printer platform is being used
                                       
  **************************************************/ 
            manual=""+ 
			"^SS – Set Media Sensors "+ 
			"The ^SS command is used to change the values for media, web, ribbon, and label length set during "+ 
			"the media calibration process. The media calibration process is described in your specific printer’s "+ 
			"user’s guide. "+ 
			"Format: ^SSw,m,r,l,m2,r2,a,b,c "+ 
			"Parameters Details "+ 
			"w = web (three-digit "+ 
			"value) "+ 
			"Values: 000 to 100 "+ 
			"Default: value shown on the media sensor profile or configuration label "+ 
			"m = media (three- "+ 
			"digit value) "+ 
			"Values: 000 to 100 "+ 
			"Default: value shown on the media sensor profile or configuration label "+ 
			"r = ribbon (three- "+ 
			"digit value) "+ 
			"Values: 000 to 100 "+ 
			"Default: value shown on the media sensor profile or configuration label "+ 
			"l = label length (in "+ 
			"dots, four-digit "+ 
			"value) "+ 
			"Values: 0001 to 32000 "+ 
			"Default: value calculated in the calibration process "+ 
			"m2 = intensity of "+ 
			"media LED "+ 
			"(three-digit "+ 
			"value) "+ 
			"Values: 000 to 255 "+ 
			"Default: value calculated in the calibration process "+ 
			"r2 = intensity of "+ 
			"ribbon LED "+ 
			"(three-digit "+ 
			"value) "+ 
			"Values: 000 to 255 "+ 
			"Default: value calculated in the calibration process "+ 
			"a = mark sensing "+ 
			"(three-digit "+ 
			"value) "+ 
			"Values: 000 to 100 "+ 
			"Default: value calculated in the calibration process "+ 
			"b = mark media "+ 
			"sensing (three- "+ 
			"digit value) "+ 
			"Values: 000 to 100 "+ 
			"Default: value calculated in the calibration process "+ 
			"c = mark LED sensing "+ 
			"(three-digit "+ 
			"value) "+ 
			"Values: 000 to 255 "+ 
			"Default: value calculated in the calibration process "+ 
			" "+ 
			"319 "+ 
			"ZPL Commands "+ 
			"^SS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"The media and sensor profiles produced vary in appearance from printer to printer. "+ 
			"Comments The m2 and r2 parameters have no effect in Stripe "+ 
			"® "+ 
			"S-300 and S-500 printers. "+ 
			"This command is ignored on the HC100™ printer. "+ 
			"Maximum values for parameters depend on which printer platform is being used. "+ 
			"Example: Below is an example of a media sensor profile. Notice the numbers from 000 to 100 and "+ 
			"where the words WEB, MEDIA, and RIBBON appear in relation to those numbers. Also notice the "+ 
			"black vertical spike. This represents where the printer sensed the transition from media-to-web-to- "+ 
			"media. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^ST "+ 
			"320 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
