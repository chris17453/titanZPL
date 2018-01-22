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
    public class zpl_cmd_c_SR : zpl_command{   //Set Printhead Resistance
        public    int number                                                       = 0;
                                        
        public zpl_cmd_c_SR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SR";                   
            description="Set Printhead Resistance";                   
            data_format="#### ";                   
            example    ="";                   
            number                                                      =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	## =resistance_value //0488 to 1175  //last permanently saved value Note • New printer models automatically set head resistance.  ZPL Commands ^SS 318 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^SR – Set Printhead Resistance "+ 
			"The ^SR command allows you to set the printhead resistance. "+ 
			"Format: ^SR#### "+ 
			"Comments To avoid damaging the printhead, this value should be less than or equal to the "+ 
			"value shown on the printhead being used. Setting a higher value could damage the printhead. "+ 
			"Parameters Details "+ 
			"#### = resistance "+ 
			"value (four- "+ 
			"digit numeric "+ 
			"value) "+ 
			"Values: 0488 to 1175 "+ 
			"Default: last permanently saved value "+ 
			"Note • New printer models automatically set head resistance. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SS "+ 
			"318 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
