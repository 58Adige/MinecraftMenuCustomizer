using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        private string targetFile;
        private string minecraftPath;
        public Form1()
        {
            InitializeComponent();
            string appPath = Application.StartupPath;
            targetFile = Path.Combine(appPath, "background.jpg");
            string userName = Environment.UserName;
            minecraftPath = $@"C:\Users\{userName}\AppData\Roaming\.minecraft\versions\1.12.2-forge-14.23.5.2860\resources\custommainmenu\textures";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Your Background picture";
            ofd.Filter = "Picture Files (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(ofd.FileName, targetFile, true);
                    if (this.BackgroundImage != null)
                    {
                        this.BackgroundImage.Dispose();
                        this.BackgroundImage = null;
                    }
                    using (FileStream fs = new FileStream(targetFile, FileMode.Open, FileAccess.Read))
                    {
                        Image img = Image.FromStream(fs);
                        this.BackgroundImage = new Bitmap(img);
                    }
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    MessageBox.Show("Görsel baþarýyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(targetFile))
                {
                    MessageBox.Show("Önce bir görsel seçmelisiniz.");
                    return;
                }
                if (!Directory.Exists(minecraftPath))
                    Directory.CreateDirectory(minecraftPath);
                string hedefMinecraftDosyasi = Path.Combine(minecraftPath, "background.jpg");
                if (File.Exists(hedefMinecraftDosyasi))
                {
                    File.Delete(hedefMinecraftDosyasi);
                }
                File.Copy(targetFile, hedefMinecraftDosyasi, true);
                MessageBox.Show("Minecraft dizinine baþarýyla kopyalandý.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kopyalama sýrasýnda hata oluþtu: " + ex.Message);
            }
        }
    }
}
