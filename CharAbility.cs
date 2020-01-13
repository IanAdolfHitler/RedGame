using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Game_Client
{
    class CharAbility
    {
        //S select C champion P picturebox I index
        public int SCI;
        public CharAbility(int sci)
        {
            SCI = sci;
        }
        public void SCP(Control control)
        {
            try
            {
                ResourceManager rm = new ResourceManager(typeof(Red_Game_Client.Properties.Resources));
                switch (SCI)
                {
                    case 0:
                        control.BackgroundImage = rm.GetObject("ghost") as Image;
                        control.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case 1:
                        control.BackgroundImage = rm.GetObject("UAN") as Image;
                        control.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                }
            }
            catch
            {

            }
        }
        public void SkillPic(List<PictureBox> P)
        {
            ResourceManager rm = new ResourceManager(typeof(Red_Game_Client.Properties.Resources));
            switch (SCI)
            {
                case 0:
                    P[0].BackgroundImage = rm.GetObject("Haunt") as Image;
                    P[0].BackgroundImageLayout = ImageLayout.Stretch;
                    P[1].BackgroundImage = rm.GetObject("HakkaSpirit") as Image;
                    P[1].BackgroundImageLayout = ImageLayout.Stretch;
                    P[0].Tag = "Haunt";
                    P[1].Tag = "HakkaSpirit";
                    break;
                case 1:
                    P[0].BackgroundImage = rm.GetObject("AbabaHonda") as Image;
                    P[0].BackgroundImageLayout = ImageLayout.Stretch;
                    P[1].BackgroundImage = rm.GetObject("Wine") as Image;
                    P[1].BackgroundImageLayout = ImageLayout.Stretch;
                    P[0].Tag = "AbabaHonda";
                    P[1].Tag = "Wine";

                    break;
            }
        }
     

    }
}
