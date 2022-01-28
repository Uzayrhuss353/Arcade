using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Arcade
{

    public partial class frmMain : Form
    {


        Random rnd = new Random();

        Image[] ImageArray =
        {
            Image.FromFile(@"bag.png"), Image.FromFile(@"bag.png"), Image.FromFile(@"Book.png"), Image.FromFile(@"Book.png"),
            Image.FromFile(@"C# Logo.png"), Image.FromFile(@"C# Logo.png"), Image.FromFile(@"Computer Image.jpg"), Image.FromFile(@"Computer Image.jpg"),
            Image.FromFile(@"Keyboard.jpg"), Image.FromFile(@"Keyboard.jpg"), Image.FromFile(@"Mouse.png"), Image.FromFile(@"Mouse.png"),
            Image.FromFile(@"Paper.png"), Image.FromFile(@"Paper.png"),Image.FromFile(@"Pencil.png"),Image.FromFile(@"Pencil.png"), Image.FromFile(@"Ruler.png"), Image.FromFile(@"Ruler.png")
        };

        int RandomImage;
        PictureBox picturebox = new PictureBox();

        public frmMain()
        {
            InitializeComponent();

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                picturebox = (PictureBox)tableLayoutPanel1.Controls[i];
                RandomImage = rnd.Next(0, ImageArray.Length);
                picturebox.Image = ImageArray[RandomImage];
                ImageArray = ImageArray.Where((source, index) => index != RandomImage).ToArray();
            }
        }

        PictureBox click1;
        PictureBox click2;

        private void picture_click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //processing 
            //if ()
        }

        private void CardClicked(object sender, EventArgs e)
        {
            PictureBox ClickedCard = sender as PictureBox;

            if (click1 == null)
            {
                click1 = ClickedCard;
                click1.Visible = false;
                return;
            }
            click2 = ClickedCard;
            click2.Visible = false;
            if (click1.Image == click2.Image)
            {
                click1.Image = null;
                click2.Image = null;
                return;
            }
            if (click1.Image != click2.Image)
            {
                Thread.Sleep(1000);
                click1.Visible = true;
                click2.Visible = true;
                return;
            }
            click1 = null;
            click2 = null;
        }
    }
}
