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
using System.Collections.Generic;using System.Drawing;
using Bytescout.BarCode;
namespace titanZPL.commands  {
    public class zpl_cmd_c_BD : zpl_command{   //UPS MaxiCode Bar Code
        public zpl_cmd_c_BY by;
        public zpl_cmd_c_FH fh;
        public int mode                       = 0;
        public int symbol_number              = 0;
        public int total_number_of_symbols    = 0;
                                        
        public zpl_cmd_c_BD(string data,List<zpl_command> commands):base(commands){                    
            fh=(zpl_cmd_c_FH)find_in_field("^FH");
            by=(zpl_cmd_c_BY)find_last    ("^BY");
            cmd        ="^BD";                   
            description="UPS MaxiCode Bar Code";                   
            data_format="m,n,t ";                   
            example    ="^XA"+
			            "^FO50,50"+
			            "^CVY"+
			            "^BD^FH^FD001840152382802"+
			            "[)>_1E01_1D961Z00004951_1DUPSN_"+
			            "1D_06X610_1D159_1D1234567_1D1/1_"+
			            "1D_1DY_1D634 ALPHA DR_"+
			            "1DPITTSBURGH_1DPA_1E_04^FS"+
			            "^FO30,300^A0,30,30^FDMode2^FS"+
			            "^XZ";                   
            mode                     =(int)argument(0,data,"i","2-6","","4");
            symbol_number            =(int)argument(1,data,"i","1-8","","1");
            total_number_of_symbols  =(int)argument(2,data,"i","1-8","","1");
                                    
  /*************************************************  
	
m =mode //
2 = structured carrier message: numeric postal code (U.S.) 3 = structured carrier message: alphanumeric postal code (non-U.S.) 4 = standard symbol, secretary 5 = full EEC 6 = reader program, secretary  //2 
	
n =symbol_number //1 to 8 can be added in a structured document  //1 
	
t =total_number_of_symbols //1 to 8, representing the total number of symbols in this sequence  //
                                       
  **************************************************/ 
            manual=""+ 
			"^BD – UPS MaxiCode Bar Code "+ 
			"The ^BD command creates a two-dimensional, optically read (not scanned) code. This symbology "+ 
			"was developed by UPS (United Parcel Service). "+ 
			"Notice that there are no additional parameters for this code and it does not generate an "+ 
			"interpretation line. The "+ 
			"^BY command has no effect on the UPS MaxiCode bar code. However, the "+ 
			"^CV command can be activated. "+ 
			"Format: ^BDm,n,t "+ 
			"Special Considerations for ^FD when Using ^BD "+ 
			"The ^FD statement is divided into two parts: a high priority message (hpm) and a low priority "+ 
			"message ( "+ 
			"lpm). There are two types of high priority messages. One is for a U.S. Style Postal Code; "+ 
			"the other is for a non-U.S. Style Postal Code. The syntax for either of these high priority messages "+ 
			"must be exactly as shown or an error message is generated. "+ 
			"Format: ^FD <hpm><lpm> "+ 
			"Parameters Details "+ 
			"m = mode "+ 
			"Values: "+ 
			"2 = structured carrier message: numeric postal code (U.S.) "+ 
			"3 = structured carrier message: alphanumeric postal code (non-U.S.) "+ 
			"4 = standard symbol, secretary "+ 
			"5 = full EEC "+ 
			"6 = reader program, secretary "+ 
			"Default: 2 "+ 
			"n = symbol number "+ 
			"Values: 1 to 8 can be added in a structured document "+ 
			"Default: 1 "+ 
			"t = total number of "+ 
			"symbols "+ 
			"Values: 1 to 8, representing the total number of symbols in this sequence "+ 
			"Default: 1 "+ 
			"Example: This is an example of UPS MAXICODE - MODE 2 bar code: "+ 
			"ZPL II CODE "+ 
			"^XA "+ 
			"^FO50,50 "+ 
			"^CVY "+ 
			"^BD^FH^FD001840152382802 "+ 
			"[)>_1E01_1D961Z00004951_1DUPSN_ "+ 
			"1D_06X610_1D159_1D1234567_1D1/1_ "+ 
			"1D_1DY_1D634 ALPHA DR_ "+ 
			"1DPITTSBURGH_1DPA_1E_04^FS "+ 
			"^FO30,300^A0,30,30^FDMode2^FS "+ 
			"^XZ "+ 
			"UPS MAXICODE - MODE 2 "+ 
			" "+ 
			"85 "+ 
			"ZPL Commands "+ 
			"^BD "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments "+ 
			"• The formatting of <hpm> and <lpm> apply only when using Modes 2 and 3. "+ 
			"Mode 4, for example, takes whatever data is defined in the "+ 
			"^FD command and places it in the "+ 
			"symbol. "+ 
			"• UPS requires that certain data be present in a defined manner. When formatting MaxiCode data "+ 
			"for UPS, always use uppercase characters. When filling in the fields in the "+ 
			"<lpm> for UPS, "+ 
			"follow the data size and types specified in Guide to Bar Coding with UPS. "+ 
			"• If you do not choose a mode, the default is Mode 2. If you use non-U.S. Postal Codes, you "+ 
			"probably get an error message (invalid character or message too short). When using non-U.S. "+ 
			"codes, use Mode 3. "+ 
			"• ZPL II doesn’t automatically change your mode based on the zip code format. "+ 
			"• When using special characters, such as GS, RS, or EOT, use the "+ 
			"^FH command to tell ZPL II to "+ 
			"use the hexadecimal value following the underscore character ( _ ). "+ 
			"Parameters Details "+ 
			"<hpm> = high priority "+ 
			"message "+ 
			"(applicable only "+ 
			"in Modes 2 and "+ 
			"3) "+ 
			"Values: 0 to 9, except where noted "+ 
			"U.S. Style Postal Code (Mode 2) "+ 
			"<hpm> = aaabbbcccccdddd "+ 
			"aaa = three-digit class of service "+ 
			"bbb = three-digit country zip code "+ 
			"ccccc = five-digit zip code "+ 
			"dddd = four-digit zip code extension (if none exists, four zeros (0000) must be "+ 
			"entered) "+ 
			"non-U.S. Style Postal Code (Mode 3) "+ 
			"<hpm> = aaabbbcccccc "+ 
			"aaa = three-digit class of service "+ 
			"bbb = three-digit country zip code "+ 
			"ccccc = six-digit zip code (A through Z or 0 to 9) "+ 
			"<lpm> = low priority "+ 
			"message (only "+ 
			"applicable in "+ 
			"Modes 2 and 3) "+ 
			"GS is used to separate fields in a message (0x1D). RS is used to separate format "+ 
			"types (0x1E). EOT is the end of transmission characters. "+ 
			"Message Header [)>RS "+ 
			"Transportation Data "+ 
			"Format Header01GS96 "+ 
			"Tracking Number{tracking number> "+ 
			"SCAC*GS<SCAC> "+ 
			"UPS Shipper NumberGS<shipper number> "+ 
			"Julian Day of PickupGS<day of pickup> "+ 
			"Shipment ID NumberGS<shipment ID number> "+ 
			"Package n/xGS<n/x> "+ 
			"Package WeightGS<weight> "+ 
			"Address ValidationGS<validation> "+ 
			"Ship to Street AddressGS<street address> "+ 
			"Ship to CityGS<city> "+ 
			"Ship to StateGS<state> "+ 
			"RSRS "+ 
			"End of MessageEOT "+ 
			"(* Mandatory Data for UPS) "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BE "+ 
			"86 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function               

        public override void draw() {
            
            string data=get_field_data(fh.hexadecimal_indicator[0]);
            maxicode mc=new maxicode(mode,data,fh.hexadecimal_indicator[0],true);    
            
	        Barcode barcode = new Barcode();
			barcode.RegistrationName=bytescout_registrationName;
            barcode.RegistrationKey =bytescout_registrationKey;
            
			barcode.Symbology = SymbologyType.MaxiCode;
			barcode.Options.MaxiCodeMode = 2; // 2 or 3 depending on the postal code
			barcode.NarrowBarWidth  = by.module_width;
			string mode23Signature  = "[)>" + '\x1E' + "01" + '\x1D' + "96";
			char separator          = '\x1D';
			string endingSignature  = "\x1E" + '\x04';
            /*

			// Generate minimal postal code:

			string minimalValue = mode23Signature +
			                      postalCode + separator +
			                      countryCode + separator +
			                      classOfService + separator +
			                      trackingNumber + separator +
			                      upsStandardCarrierAlphaCode +
			                      endingSignature;

			barcode.Value = minimalValue;
			barcode.SaveImage("postal-maxicode-min.png");
            */

			// Generate full postal code:

			string fullValue = mode23Signature +
			                   mc.data.Ship_To                          + separator +
			                   mc.data.Ship_To_Country_Code             + separator +
			                   mc.data.Class                            + separator +
			                   mc.data.Tracking                         + separator +
			                   mc.data.UPS_Standard_Carrier_Alpha_Code  + separator +
			                   mc.data.UPS_Shipper_Number               + separator +
			                   mc.data.Julian_Day_of_Pickup             + separator +
			                   mc.data.Shipment_ID_Number               + separator +
			                   mc.data.Package_In_Shipment              + separator +
			                   mc.data.Weight_in_pounds                 + separator +
			                   mc.data.Address_Validation               + separator +
			                   mc.data.Ship_To_Address                  + separator +
			                   mc.data.Ship_To_City                     + separator +
			                   mc.data.Ship_To_State                    +
			                   endingSignature;

			barcode.Value = fullValue;
			
            Bitmap image=(Bitmap)barcode.GetImage();
            // Cleanup
			barcode.Dispose();


            _internal.image=image;
            _internal.baseline=image.Height;
            _internal.width =image.Width;
            _internal.height=image.Height;
        }
    }//end class                                  
}//end namespace                                  
