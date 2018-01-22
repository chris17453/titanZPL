using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using titanZPL.commands;


namespace titanZPL{
    public partial class titanZPL{
        //IDE varables
        public string ide_mode                          ="hover";
        public Point highlight_select_position=new Point(0,0);

        public void highlight_top_element_at_position(int x,int y) {
            highlight_select_position=new Point(x,y);
            curent_zpl_command=null;                                    //reset curent command so we arnt draging the last selected item
            foreach(zpl_command cmd in zpl_commands) {
                if(cmd._internal.image!=null && cmd.contains_point(highlight_select_position)) {
                    cmd._internal.highlight=true;
                    curent_zpl_command=cmd;
                } else {
                    cmd._internal.highlight=false;
                    if(null!=curent_zpl_command) {
                        curent_zpl_command._internal.drag=false;
                    }
                }
            }
            foreach(zpl_command cmd in zpl_commands) {
                if(cmd!=curent_zpl_command) cmd._internal.highlight=false;      //only the top most element can be highlighted
            }
        }

        public int drag_start_x=0;
        public int drag_start_y=0;

        public void drag_start(int x,int y) {
            if(null==curent_zpl_command) return;
            curent_zpl_command._internal.drag_start_x=x;
            curent_zpl_command._internal.drag_start_y=y;
            curent_zpl_command._internal.drag_x=x;
            curent_zpl_command._internal.drag_y=y;
            curent_zpl_command._internal.drag=true;
        }
        public void drag_end() {
            if(null==curent_zpl_command) return;
            int command_index=0;
            curent_zpl_command.drag_stop();
            for(int i=0;i<zpl_commands.Count;i++) {                     //get the index of this element
                if(curent_zpl_command==zpl_commands[i]) {
                    command_index=i;
                }
            }
            for(int i=command_index;i>0; i--) {                         //walk backward to the last position element
                zpl_command cmd=zpl_commands[i];
                if(cmd.cmd=="^FT") {
                    cmd.data=string.Format("{0},{1}",curent_zpl_command._internal.x,curent_zpl_command._internal.y+curent_zpl_command._internal.baseline);
                    break;
                }
                if(cmd.cmd=="^FO") {
                    cmd.data=string.Format("{0},{1}",curent_zpl_command._internal.x,curent_zpl_command._internal.y);
                    break;
                }
            }
        }

        public void drag_element(int x,int y) {
            if(null==curent_zpl_command) return;
            curent_zpl_command._internal.drag_x=x;
            curent_zpl_command._internal.drag_y=y;
        }
    }
}
