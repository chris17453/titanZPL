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
    public class zpl_cmd_c_MN : zpl_command{   //Media Tracking
        public string media_being_used                                             = String.Empty;
        public string black_mark_offset_in_dots_this_sets_the_expected_location_of_the_media_mark_relative_to_the_point_of_separation_between_documents = String.Empty;
                                        
        public zpl_cmd_c_MN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MN";                   
            description="Media Tracking";                   
            data_format="a,b ";                   
            example    ="";                   
            media_being_used                                            =(string)argument(0,data,"s","                   ",""," ");
            black_mark_offset_in_dots_this_sets_the_expected_location_of_the_media_mark_relative_to_the_point_of_separation_between_documents=(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =media_being_used //
N = continuous media Y = non-continuous media web sensing q, r W = non-continuous media web sensing q, r M = non-continuous media mark sensing A = auto-detects the type of media during calibration q, s V = continuous media, variable length t  //a value must be entered or the command is ignored 
	
b =black_mark_offset_in_dots_This_sets_the_expected_location_of_the_media_mark_relative_to_the_point_of_separation_between_documents //
-80 to 283 for direct-thermal only printers -240 to 566 for 600 dpi printers -75 to 283 for KR403 printers -120 to 283 for all other printers  //0 q. Provides the same result. r. This value is not supported on the KR403 printer. s. This parameter is supported only on G-series printers. t. This parameter is supported only on the KR403 printer.  275 ZPL Commands ^MP 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^MN – Media Tracking "+ 
			"This command specifies the media type being used and the black mark offset in dots. "+ 
			"This bulleted list shows the types of media associated with this command: "+ 
			"• Continuous Media – this media has no physical characteristic (such as a web, notch, "+ 
			"perforation, black mark) to separate labels. Label length is determined by the "+ 
			"^LL command. "+ 
			"• Continuous Media, variable length – same as Continuous Media, but if portions of the printed "+ 
			"label fall outside of the defined label length, the label size will automatically be extended to "+ 
			"contain them. This label length extension applies only to the current label. Note that ^MNV still "+ 
			"requires the use of the ^LL command to define the initial desired label length. "+ 
			"• Non-continuous Media – this media has some type of physical characteristic (such as web, "+ 
			"notch, perforation, black mark) to separate the labels. "+ 
			"Format: ^MNa,b "+ 
			"Comments This command is ignored on the HC100™ printer. "+ 
			"Parameters Details "+ 
			"a = media being used "+ 
			"Values: "+ 
			"N = continuous media "+ 
			"Y = non-continuous media web sensing "+ 
			"q, r "+ 
			"W = non-continuous media web sensing "+ 
			"q, r "+ 
			"M = non-continuous media mark sensing "+ 
			"A = auto-detects the type of media during calibration "+ 
			"q, s "+ 
			"V = continuous media, variable length "+ 
			"t "+ 
			"Default: a value must be entered or the command is ignored "+ 
			"b = black mark offset "+ 
			"in dots "+ 
			"This sets the expected location of the media mark relative to the point of separation "+ 
			"between documents. If set to 0, the media mark is expected to be found at the point "+ 
			"of separation. (i.e., the perforation, cut point, etc.) "+ 
			"All values are listed in dots. This parameter is ignored unless the a parameter is set "+ 
			"to M. If this parameter is missing, the default value is used. "+ 
			"Values: "+ 
			"-80 to 283 for direct-thermal only printers "+ 
			"-240 to 566 for 600 dpi printers "+ 
			"-75 to 283 for KR403 printers "+ 
			"-120 to 283 for all other printers "+ 
			"Default: 0 "+ 
			"q. Provides the same result. "+ 
			"r. This value is not supported on the KR403 printer. "+ 
			"s. This parameter is supported only on G-series printers. "+ 
			"t. This parameter is supported only on the KR403 printer. "+ 
			" "+ 
			"275 "+ 
			"ZPL Commands "+ 
			"^MP "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
