using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.Controls;

namespace WoWToDo
{
    public partial class UpdatePersonage : Form
    {
        //page == 1 - Update Level
        //page == 2 - Update Name
        //page == 3 - Update Class
        //page == 4 - Update All
        public void SetPage(int page)
        {
            switch (page)
            {
                case 1:
                    pnMain.Controls.Add(new UpdatePers_Level());
                    break;
                case 2:
                    pnMain.Controls.Add(new UpdatePers_Name());
                    break;
                case 3:
                    pnMain.Controls.Add(new UpdatePers_Class());
                    break;
                case 4:
                    pnMain.Controls.Add(new UpdatePers_All());
                    break;
                default:
                    pnMain.Controls.Add(new UpdatePers_Level());
                    return;
            }
        }
        public UpdatePersonage()
        {
            InitializeComponent();
        }
    }
}
