using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsLoadImage
{
    public partial class MyForm : Form
    {
        public Button btnLoad;
        private PictureBox pboxPhoto;
        public MyForm()
        {
            this.Text = "Hello Form";
            this.MinimumSize = new Size(500, 500);

            btnLoad = new Button();
            btnLoad.Text = "&Load";
            btnLoad.Left = 10;
            btnLoad.Top = 10;
            btnLoad.Click += new System.EventHandler(this.OnClickLoad);
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            pboxPhoto = new PictureBox();
            pboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pboxPhoto.Width = this.Width / 2;
            pboxPhoto.Height = this.Height / 2;
            pboxPhoto.Left = (this.Width - pboxPhoto.Width) / 2;
            pboxPhoto.Top = (this.Height - pboxPhoto.Height) / 2;
            pboxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(btnLoad);
            this.Controls.Add(pboxPhoto);
        }

        private void OnClickLoad(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Photo";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pboxPhoto.Image = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose(); 
        }
    }
}
