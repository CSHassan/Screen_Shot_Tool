using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
     



        public Form1()
        {

            InitializeComponent();


        }      

        //whole screen
        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap screenshot = new Bitmap(SystemInformation.VirtualScreen.Width,
                                SystemInformation.VirtualScreen.Height,
                                PixelFormat.Format32bppArgb);
            Graphics screenGraph = Graphics.FromImage(screenshot);
            screenGraph.CopyFromScreen(SystemInformation.VirtualScreen.X,
                                       SystemInformation.VirtualScreen.Y,
                                       0,
                                       0,
                                       SystemInformation.VirtualScreen.Size,
                                       CopyPixelOperation.SourceCopy);

            screenshot.Save("C:\\Users\\hassan\\Desktop\\Whole_screen.jpg", System.Drawing.Imaging.ImageFormat.Png);
           
        }

        //Drag Screen Shot
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            //Hide the Form
            this.Hide();
            System.Threading.Thread.Sleep(5000);


            
            Rectangle bounds = this.Bounds;

            using (Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format64bppPArgb))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
Screen.PrimaryScreen.Bounds.Y, Cursor.Position.X, Cursor.Position.Y, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                }
                bitmap.Save("C:\\Users\\hassan\\Desktop\\Drag_screen.jpg", ImageFormat.Jpeg);
            }





            //Show Form
            this.Show();
            //Cross Cursor
            Cursor.Current = Cursors.Default;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Current window screen shot
        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);

            //Rectangle bounds = this.Bounds;
            //using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            //{
            //    using (Graphics g = Graphics.FromImage(bitmap))
            //    {
            //        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            //    }
            //    bitmap.Save("C:\\Users\\hassan\\Desktop\\Current_screen.jpg", ImageFormat.Jpeg);
            //}


            SendKeys.Send("{PRTSC}");
            Image myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;
            myImage.Save("C:\\Users\\hassan\\Desktop\\Current_screen.jpg", ImageFormat.Jpeg)
            //Show Form
            this.Show();
        }
         

    }




}
