using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL {
    public class maxicode {
        public class maxicode_data {
            //internal    bool         field_hexadecimal_replacment   =false;
            internal    char         field_hexadecimal_indicator    ='_';


            public string Ship_To                         ="";  //Postal Code 5 or 9 digits in the USA, up to 6 alphanumeric characters in other countries.
            public string Ship_To_Country_Code            ="";  //3 digits (840 for USA)
            public string Class                           ="";  //of Service 3 digits
            public string Tracking                        ="";  //Number 10-character alphanumeric
            public string UPS_Standard_Carrier_Alpha_Code ="";  // “UPSN”
            public string UPS_Shipper_Number              ="";  //6-character alphanumeric
            public string Julian_Day_of_Pickup            ="";  //3 digits
            public string Shipment_ID_Number              ="";  //1-30 character alphanumeric
            public string Package_In_Shipment             ="";  //(package N of X total packages) 1-4 digits “/” 1-4 digits
            public string Weight_in_pounds                ="";  //1-5 digits
            public string Address_Validation              ="";  //"Y" or "N"
            public string Ship_To_Address                 ="";  //1-35 alphanumeric
            public string Ship_To_City                    ="";  //1-35 alphanumeric
            public string Ship_To_State                   ="";  //2-character alpha
            
            //internal    string       maxicode_data                  ="";  //actual maxi code data...
            public      List<string> error                          =new List<string>();
            public      bool         valid                          =true;
            public      int          mode                           =2;
            public      string       data                           ="";

            internal const byte rs   =0x1E;
            internal const byte gs   =0x1D;
            internal const byte eot1 =0x04;
            internal const byte eot2 =0x37;

            internal string record_start;
            internal string record_header;
            internal string record_seperator;
            internal string group_seperator;
            internal string record_end;
                
            public maxicode_data(int mode,string data,char field_hexadecimal_indicator,bool field_hexadecimal_replacment) {
                this.field_hexadecimal_indicator=field_hexadecimal_indicator;
                //this.field_hexadecimal_replacment=field_hexadecimal_replacment;
                
                //test override
                //if(mode==2) data="[)>_1E01_1D96336091062_1D840_1D002_1D1Z14647438_1DUPSN_1D410E1W_1D195_1D_1D1/1_1D_1DY_1D135Reo_1DTAMPA_1DFL_1E_04";
                //if(mode==3) data="[)>_1E01_1D96336091062_1D840_1D002_1E_04[)>_1E01_1D96_1D1Z14647438_1DUPSN_1D410E1W_1D195_1D_1D1/1_1D_1DY_1D135Reo_1DTAMPA_1DFL_1E_04";
                this.field_hexadecimal_indicator='_';

                this.mode=mode;
                this.data=data;

                record_start     =string.Format("[)>{0}{1:X2}"       ,this.field_hexadecimal_indicator,rs);
                record_header    =string.Format("01{0}{1:X2}96"      ,this.field_hexadecimal_indicator,gs);
                record_seperator =string.Format("{0}{1:X2}"          ,this.field_hexadecimal_indicator,rs);
                group_seperator  =string.Format("{0}{1:X2}"          ,this.field_hexadecimal_indicator,gs);
                record_end       =string.Format("{0}{1:X2}{0}{2:X2}" ,this.field_hexadecimal_indicator,rs,eot1);


                if(mode==2) { decode(); }                   //1 message for mode 2
                if(mode==3) {
                    decode();
                    decode();
                }         //2 messages for mode 3
                validate_data();
            }

            private int data_index=0;
            private int group_index=0;
            public void decode() {
                List<byte>  record              =new List<byte>();
                bool        inHex               =false;
                string      hex                 ="";
                int         hex_index           =0;
                int         record_start_index  =data.IndexOf(record_start+record_header, data_index);
                
                int header_length=record_start.Length+record_header.Length;

                for (int i=record_start_index+header_length+1;i<data.Length;i++){
                    char c=data[i];
                    if(c==field_hexadecimal_indicator) {
                        inHex=true;
                        hex="";
                        hex_index=0;
                        continue;
                    }
                    if(!inHex) {
                        record.Add((byte)c);
                    } else {
                        hex_index++;
                        hex=hex+c;
                        if(hex_index==2) {
                            byte byte_c=Convert.ToByte(hex.Substring(0, 2), 16);
                            switch(byte_c) {
                                case rs  :  //break;                                                                            //the only time we will encounter a RS is at the end of a record, and there is no GS, so we process whats in the array and move on...
                                case gs  :  group_index++;
                                            string extracted_data=System.Text.Encoding.ASCII.GetString(record.ToArray());
                                            record.Clear();
                                            switch(group_index) {
                                                case 1:  Ship_To                         =extracted_data; break;  
                                                case 2:  Ship_To_Country_Code            =extracted_data; break;  
                                                case 3:  Class                           =extracted_data; break;  
                                                case 4:  Tracking                        =extracted_data; break;  
                                                case 5:  UPS_Standard_Carrier_Alpha_Code =extracted_data; break;  
                                                case 6:  UPS_Shipper_Number              =extracted_data; break;  
                                                case 7:  Julian_Day_of_Pickup            =extracted_data; break;  
                                                case 8:  Shipment_ID_Number              =extracted_data; break;  
                                                case 9:  Package_In_Shipment             =extracted_data; break;  
                                                case 10: Weight_in_pounds                =extracted_data; break;  
                                                case 11: Address_Validation              =extracted_data; break;
                                                case 12: Ship_To_Address                 =extracted_data; break;
                                                case 13: Ship_To_City                    =extracted_data; break;
                                                case 14: Ship_To_State                   =extracted_data; break;                                       
                                            }
                                            break;
                                case eot1:
                                case eot2: data_index=i; return;       
                                default: record.Add(byte_c); break;             //maybe we are adding a hex value thats not a command or structure?
                            }//end switch
                            inHex=false;
                        }//end in hex
                    }// end else
                }//end for
                data_index=data.Length;                                             //you should never get here otherwise its bad jo jo
                return;
            }//end function decode

            public bool validate_data() {
                //at this point all the fields have been filled out, lets check them for validity
                int postal=0;
                if(Ship_To.Length>9                                     ) error.Add("1  Ship_To                         exceeds maximum length");
                if(Ship_To_Country_Code.Length>3                        ) error.Add("2  Ship_To_Country_Code            exceeds maximum length");
                if(Class.Length>3                                       ) error.Add("3  Class                           exceeds maximum length");
                if(Tracking.Length>10                                   ) error.Add("4  Tracking                        exceeds maximum length");
                if(UPS_Standard_Carrier_Alpha_Code.Length>4             ) error.Add("5  UPS_Standard_Carrier_Alpha_Code exceeds maximum length");
                if(UPS_Shipper_Number.Length>6                          ) error.Add("6  UPS_Shipper_Number              exceeds maximum length");
                if(Julian_Day_of_Pickup.Length>3                        ) error.Add("7  Julian_Day_of_Pickup            exceeds maximum length");
                if(Shipment_ID_Number.Length>30                         ) error.Add("8  Shipment_ID_Number              exceeds maximum length");
                if(Package_In_Shipment.Length>4                         ) error.Add("9  Package_In_Shipment             exceeds maximum length");
                if(Weight_in_pounds.Length>5                            ) error.Add("10 Weight_in_pounds                exceeds maximum length");
                if(Address_Validation.Length>1                          ) error.Add("11 Address_Validation              exceeds maximum length");
                if(Ship_To_Address.Length>35                            ) error.Add("12 Ship_To_Address                 exceeds maximum length");
                if(Ship_To_City.Length>35                               ) error.Add("13 Ship_To_City                    exceeds maximum length");
                if(Ship_To_State.Length>2                               ) error.Add("14 Ship_To_State                   exceeds maximum length");                                
                if(string.IsNullOrEmpty(Ship_To                        )) error.Add("Ship_To                            is a required field");
                if(string.IsNullOrEmpty(Ship_To_Country_Code           )) error.Add("Ship_To_Country_Code               is a required field");
                if(string.IsNullOrEmpty(Class                          )) error.Add("Class                              is a required field");
                if(string.IsNullOrEmpty(Tracking                       )) error.Add("Tracking                           is a required field");
                if(string.IsNullOrEmpty(UPS_Standard_Carrier_Alpha_Code)) error.Add("UPS_Standard_Carrier_Alpha_Code    is a required field");
                if(mode==2 && !Int32.TryParse(Ship_To,out postal))        error.Add("Non numeric ShipTo, not a mode 2. Mode 3 For alpha Numeric/International");
                            
                if(error.Count>0) valid=false;
                return valid;
            }
            public string encode() {
                StringBuilder data=new StringBuilder();
             
                if(mode==2) {
                    data.Append(record_start);
                    data.Append(record_header);
                    data.Append(Ship_To);                               data.Append(group_seperator);
                    data.Append(Ship_To_Country_Code);                  data.Append(group_seperator);
                    data.Append(Class);                                 data.Append(group_seperator);
                    data.Append(Tracking);                              data.Append(group_seperator);
                    data.Append(UPS_Standard_Carrier_Alpha_Code);       data.Append(group_seperator);
                    data.Append(UPS_Shipper_Number);                    data.Append(group_seperator);
                    data.Append(Julian_Day_of_Pickup);                  data.Append(group_seperator);
                    data.Append(Shipment_ID_Number);                    data.Append(group_seperator);
                    data.Append(Package_In_Shipment);                   data.Append(group_seperator);
                    data.Append(Weight_in_pounds);                      data.Append(group_seperator);
                    data.Append(Address_Validation);                    data.Append(group_seperator);
                    data.Append(Ship_To_Address);                       data.Append(group_seperator);
                    data.Append(Ship_To_City);                          data.Append(group_seperator);
                    data.Append(Ship_To_State);                         
                    data.Append(record_end);
                    return data.ToString();
                }
                if(mode==3) {
                    data.Append(record_start);
                    data.Append(record_header);
                    data.Append(Ship_To);                               data.Append(group_seperator);
                    data.Append(Ship_To_Country_Code);                  data.Append(group_seperator);
                    data.Append(Class);                                 data.Append(group_seperator);
                    data.Append(record_end);
                    
                    data.Append(record_start);                          data.Append(group_seperator);
                    data.Append(Tracking);                              data.Append(group_seperator);
                    data.Append(UPS_Standard_Carrier_Alpha_Code);       data.Append(group_seperator);
                    data.Append(UPS_Shipper_Number);                    data.Append(group_seperator);
                    data.Append(Julian_Day_of_Pickup);                  data.Append(group_seperator);
                    data.Append(Shipment_ID_Number);                    data.Append(group_seperator);
                    data.Append(Package_In_Shipment);                   data.Append(group_seperator);
                    data.Append(Weight_in_pounds);                      data.Append(group_seperator);
                    data.Append(Address_Validation);                    data.Append(group_seperator);
                    data.Append(Ship_To_Address);                       data.Append(group_seperator);
                    data.Append(Ship_To_City);                          data.Append(group_seperator);
                    data.Append(Ship_To_State);                         
                    data.Append(record_end);
                    return data.ToString();
                }
                return "Not Supported";
            }
            public string get_primary() {
                StringBuilder data=new StringBuilder();
                data.Append(Ship_To.PadRight(9,'0')); 
                data.Append(Ship_To_Country_Code.PadLeft(3,'0'));                  
                data.Append(Class.PadLeft(3,'0'));                                 
                return data.ToString();
            }


            public string get_secondary() {
                StringBuilder data=new StringBuilder();
                return data.ToString();
            }

            public string get_data() {
                if(mode==2) {
                            
                    string ret=string.Format("[)><RS>01<GS>96"+
                                                "{0}<GS>" +
                                                "{1}<GS>" +
                                                "{2}<GS>" +
                                                "{3}<GS>" +
                                                "{4}<GS>" +
                                                "{5}<GS>" +
                                                "{6}<GS>" +
                                                "{7}<GS>" +
                                                "{8}<GS>" +
                                                "{9}<GS>" +
                                                "{10}<GS>"+
                                                "{11}<GS>"+
                                                "{12}<GS>"+
                                                "{13}<GS><RS><EOT>",
                    
                                        Ship_To.PadRight(9,'0'),     
                                        Ship_To_Country_Code.PadLeft(3,'0'),
                                        Class.PadLeft(3,'0'),
                                        Tracking,
                                        UPS_Standard_Carrier_Alpha_Code,
                                        UPS_Shipper_Number,
                                        Julian_Day_of_Pickup,
                                        Shipment_ID_Number,
                                        Package_In_Shipment,
                                        Weight_in_pounds,              
                                        Address_Validation,
                                        "", //Not using the address
                                        Ship_To_City,
                                        Ship_To_State);
                    ret=ret.Replace("<EOT>",eot1.ToString());
                    ret=ret.Replace("<RS>",rs.ToString());
                    ret=ret.Replace("<GS>",gs.ToString());
                    ret=ret.Replace("<GS>",gs.ToString());
                    return ret;
                }
                if(mode==3) {
                    string ret=string.Format("[)><RS>01<GS>96"+
                                                "{0}<GS>" +
                                                "{1}<GS>" +
                                                "{2}<RS><EOT>" +
                                                "[)><RS>01<GS>96"+
                                                "{3}<GS>" +
                                                "{4}<GS>" +
                                                "{5}<GS>" +
                                                "{6}<GS>" +
                                                "{7}<GS>" +
                                                "{8}<GS>" +
                                                "{9}<GS>" +
                                                "{10}<GS>"+
                                                "{11}<GS>"+
                                                "{12}<GS>"+
                                                "{13}<RS><EOT>",
                    
                                        Ship_To.PadRight(9,'0'),     
                                        Ship_To_Country_Code.PadLeft(3,'0'),
                                        Class.PadLeft(3,'0'),
                                        Tracking,
                                        UPS_Standard_Carrier_Alpha_Code,
                                        UPS_Shipper_Number,
                                        Julian_Day_of_Pickup,
                                        Shipment_ID_Number,
                                        Package_In_Shipment,
                                        Weight_in_pounds,              
                                        Address_Validation,
                                        "", //Not using the address
                                        Ship_To_City,
                                        Ship_To_State);
                    return ret;
                }
                return "";
            }
        }

        internal        bool            field_hexadecimal_replacment   =false;
        internal        char            field_hexadecimal_indicator    ='_';
        public          string          pre_maxi_code                  ="";
        public          int             mode                           =2;
        public          maxicode_data   data;
        public maxicode(int mode,string data,char field_hexadecimal_indicator,bool field_hexadecimal_replacment) {
            this.field_hexadecimal_indicator=field_hexadecimal_indicator;
            this.field_hexadecimal_replacment=field_hexadecimal_replacment;
            this.mode=mode;
            this.data=new maxicode_data(3,data,field_hexadecimal_indicator,field_hexadecimal_replacment);
            
        }
    }
}
