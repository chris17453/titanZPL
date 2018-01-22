using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace titanZPL.commands {
public class zpl_cmd_c_BD : zpl_command {      //UPS MaxiCode Bar Code
        private static string bytescout_registrationName = "support@enroutecorp.com";
        private static string bytescout_registrationKey =  "072B-5309-38F6-F150-8F4";

		public int mode          = 0;
		public int symbol_number = 0;
		public int symbol_total  = 0;
		public zpl_cmd_c_BD(string data) {
			cmd = "^BD";
			description = "UPS MaxiCode Bar Code";
			data_format = "m,n,t";
			mode            = (int)argument(0, data, "i", "2-6", "", "2");
			symbol_number   = (int)argument(1, data, "i", "1-8", "", "1");
			symbol_total    = (int)argument(2, data, "i", "1-8", "", "1");
            example=@"^XA^FO50,50
                    ^CVY
                    ^BD^FH^FD001840152382802
                    [)>_1E01_1D961Z00004951_1DUPSN_
                    1D_06X610_1D159_1D1234567_1D1/1_
                    1D_1DY_1D634 ALPHA DR_
                    1DPITTSBURGH_1DPA_1E_04^FS
                    ^FO30,300^A0,30,30^FDMode2^FS
                    ^XZ";
		}//end init function

        public void render() {
            //string data=get_field_data(cmd);
            //maxicode mc=new maxicode(maxi_code_mode,cmd.data,field_hexadecimal_indicator,field_hexadecimal_replacment);
            /*
            BarcodeLib.Barcode bc=new BarcodeLib.Barcode();
            //string data=mc.data.encode();
            bc.BarWidth=barcode_default_width;
            bc.Height=barcode_height;
            bc.Width=barcode_default_width;
            
            zint.Symbology s=new zint.Symbology();
            s.Option1 = maxi_code_mode;
            s.Option2 = 0;
            s.Option3 = 0;
            s.InputMode = 0;
            s.Scale=1f;

            string primary=mc.data.get_primary();
            string secondary=mc.data.get_secondary();
            string full= mc.data.get_data();
            if (maxi_code_mode == 3){
                s.Primary=primary;
            }else{
                s.Primary=primary;
            }
            s.Symbol=zint.BarcodeTypes.MAXICODE;
            Bitmap image =s.Render(full);
            */
            /*

            Barcode barcode = new Barcode();
			barcode.RegistrationName = bytescout_registrationName;
			barcode.RegistrationKey  = bytescout_registrationKey;

			barcode.Symbology = SymbologyType.MaxiCode;
			barcode.Options.MaxiCodeMode = 2; // 2 or 3 depending on the postal code
			barcode.NarrowBarWidth = 6;

            string mode23Signature = "[)>" + '\x1E' + "01" + '\x1D' + "96";
			char separator = '\x1D';
			string endingSignature = "\x1E" + '\x04';

            string postalCode                   = mc.data.Ship_To;
			string countryCode                  = mc.data.Ship_To_Country_Code;
			string classOfService               = mc.data.Class;
			string trackingNumber               = mc.data.Tracking;
			string upsStandardCarrierAlphaCode  = mc.data.UPS_Standard_Carrier_Alpha_Code;
            string upsShipperNumber             = mc.data.UPS_Shipper_Number;
			string julianDayOfPickup            = mc.data.Julian_Day_of_Pickup;
			string shipmentIdNumber             = mc.data.Shipment_ID_Number;
			string packageInShipment            = mc.data.Package_In_Shipment;
			string weightInPounds               = mc.data.Weight_in_pounds;
			string addressValidation            = mc.data.Address_Validation;
			string shipToAddress                = mc.data.Ship_To_Address;
			string shipToCity                   = mc.data.Ship_To_City;
			string shipToState                  = mc.data.Ship_To_State;
            */
/*
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

            /*

			string fullValue = mode23Signature +
			                   postalCode + separator +
			                   countryCode + separator +
			                   classOfService + separator +
			                   trackingNumber + separator +
			                   upsStandardCarrierAlphaCode + separator +
			                   upsShipperNumber + separator +
			                   julianDayOfPickup + separator +
			                   shipmentIdNumber + separator +
			                   packageInShipment + separator +
			                   weightInPounds + separator +
			                   addressValidation + separator +
			                   shipToAddress + separator +
			                   shipToCity + separator +
			                   shipToState +
			                   endingSignature;

			barcode.Value = fullValue;
            Image barcode_img=barcode.GetImage();
            curent_zpl_command.image=(Bitmap)barcode_img;
            curent_zpl_command.baseline=barcode_img.Height;*/
        }
        /*
         ^BD – UPS MaxiCode Bar Code
The ^BD command creates a two-dimensional, optically read (not scanned) code. This symbology
was developed by UPS (United Parcel Service).
Notice that there are no additional parameters for this code and it does not generate an
interpretation line. The ^BY command has no effect on the UPS MaxiCode bar code. However, the
^CV command can be activated.
Format:

^BDm,n,t

Parameters

Details

m = mode

Values:

n = symbol number

Values: 1 to 8 can be added in a structured document

2 = structured carrier message: numeric postal code (U.S.)
3 = structured carrier message: alphanumeric postal code (non-U.S.)
4 = standard symbol, secretary
5 = full EEC
6 = reader program, secretary
Default: 2
Default: 1

t = total number of
symbols

Values: 1 to 8, representing the total number of symbols in this sequence
Default: 1

Example: This is an example of UPS MAXICODE - MODE 2 bar code:

ZPL II CODE
^XA
^FO50,50
^CVY
^BD^FH^FD001840152382802
[)>_1E01_1D961Z00004951_1DUPSN_
1D_06X610_1D159_1D1234567_1D1/1_
1D_1DY_1D634 ALPHA DR_
1DPITTSBURGH_1DPA_1E_04^FS
^FO30,300^A0,30,30^FDMode2^FS
^XZ

UPS MAXICODE - MODE 2

Special Considerations for ^FD when Using ^BD
The ^FD statement is divided into two parts: a high priority message (hpm) and a low priority
message (lpm). There are two types of high priority messages. One is for a U.S. Style Postal Code;
the other is for a non-U.S. Style Postal Code. The syntax for either of these high priority messages
must be exactly as shown or an error message is generated.
Format:

P1012728-011

^FD <hpm><lpm>

Zebra Programming Guide

11/21/16

ZPL Commands
^BD

Parameters

Details

<hpm> = high priority
message
(applicable only
in Modes 2 and
3)

Values: 0 to 9, except where noted
U.S. Style Postal Code (Mode 2)
<hpm> = aaabbbcccccdddd
aaa = three-digit class of service
bbb = three-digit country zip code
ccccc = five-digit zip code
dddd = four-digit zip code extension (if none exists, four zeros (0000) must be
entered)

non-U.S. Style Postal Code (Mode 3)
<hpm>
aaa
bbb
ccccc
<lpm> = low priority
message (only
applicable in
Modes 2 and 3)

= aaabbbcccccc
= three-digit class of service
= three-digit country zip code
= six-digit zip code (A through Z or 0 to 9)

GS is used to separate fields in a message (0x1D). RS is used to separate format
types (0x1E). EOT is the end of transmission characters.
Message Header [)>RS
Transportation Data
Format Header01GS96
Tracking Number*<tracking number>
SCAC*GS<SCAC>
UPS Shipper NumberGS<shipper number>
Julian Day of PickupGS<day of pickup>
Shipment ID NumberGS<shipment ID number>
Package n/xGS<n/x>
Package WeightGS<weight>
Address ValidationGS<validation>
Ship to Street AddressGS<street address>
Ship to CityGS<city>
Ship to StateGS<state>
RSRS
End of MessageEOT
(* Mandatory Data for UPS)

Comments
• The formatting of <hpm> and <lpm> apply only when using Modes 2 and 3.
Mode 4, for example, takes whatever data is defined in the ^FD command and places it in the
symbol.
• UPS requires that certain data be present in a defined manner. When formatting MaxiCode data
for UPS, always use uppercase characters. When filling in the fields in the <lpm> for UPS,
follow the data size and types specified in Guide to Bar Coding with UPS.
• If you do not choose a mode, the default is Mode 2. If you use non-U.S. Postal Codes, you
probably get an error message (invalid character or message too short). When using non-U.S.
codes, use Mode 3.
• ZPL II doesn’t automatically change your mode based on the zip code format.
• When using special characters, such as GS, RS, or EOT, use the ^FH command to tell ZPL II to
use the hexadecimal value following the underscore character ( _ ).

         
         */
	}//end class
	
}//end namespace