using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                    using (Image selectedImage = Image.FromFile(ofd.FileName))
                    {
                        string appPath = Application.StartupPath;
                        targetFile = Path.Combine(appPath, "background.png");
                        selectedImage.Save(targetFile, System.Drawing.Imaging.ImageFormat.Png);
                    }
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
                if (string.IsNullOrEmpty(targetFile) || !File.Exists(targetFile))
                {
                    MessageBox.Show("Önce bir arka plan görseli seçmelisiniz.");
                    return;
                }

                if (!Directory.Exists(minecraftPath))
                    Directory.CreateDirectory(minecraftPath);

                string hedefMinecraftDosyasi = Path.Combine(minecraftPath, "background.png");
                if (File.Exists(hedefMinecraftDosyasi))
                    File.Delete(hedefMinecraftDosyasi);
                File.Copy(targetFile, hedefMinecraftDosyasi);

                string localLogoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "minecraft.png");
                string hedefLogoDosyasi = Path.Combine(minecraftPath, "minecraft.png");

                if (File.Exists(localLogoPath))
                {
                    try
                    {
                        if (File.Exists(hedefLogoDosyasi))
                            File.Delete(hedefLogoDosyasi);
                        File.Copy(localLogoPath, hedefLogoDosyasi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Logo kopyalanýrken hata oluþtu: " + ex.Message);
                    }
                }

                string jsonPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    @".minecraft\versions\1.12.2-forge-14.23.5.2860\config\CustomMainMenu\mainmenu.json"
                );

                if (!File.Exists(jsonPath))
                {
                    MessageBox.Show("mainmenu.json dosyasý bulunamadý.");
                    return;
                }

                string jsonContent = File.ReadAllText(jsonPath);
                var jObject = JObject.Parse(jsonContent);

                if (jObject.TryGetValue("buttons", out var buttonsToken))
                {
                    var buttonsObject = buttonsToken as JObject;
                    if (buttonsObject != null)
                    {
                        if (buttonsObject.TryGetValue("singleplayer", out var singleplayerToken))
                            SetJsonText((JObject)singleplayerToken, textBoxSingleplayer.Text);

                        if (buttonsObject.TryGetValue("multiplayer", out var multiplayerToken))
                            SetJsonText((JObject)multiplayerToken, textBoxMultiplayer.Text);

                        if (buttonsObject.TryGetValue("mods", out var modsToken))
                            SetJsonText((JObject)modsToken, textBoxMods.Text);

                        if (buttonsObject.TryGetValue("options", out var optionsToken))
                            SetJsonText((JObject)optionsToken, textBoxOptions.Text);

                        if (buttonsObject.TryGetValue("quit", out var quitToken))
                            SetJsonText((JObject)quitToken, textBoxQuit.Text);
                    }
                }

                if (jObject["labels"]?["version"] is JObject versionLabel)
                {
                    SetJsonText(versionLabel, textVersion.Text);
                }

                if (jObject["labels"]?["mojang"] is JObject mojangLabel)
                {
                    SetJsonText(mojangLabel, textMojang.Text);
                    mojangLabel["hoverText"] = string.IsNullOrWhiteSpace(textMojang.Text) ? mojangLabel.Value<string>("hoverText") : textMojang.Text;
                }

                string splashTextPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    @".minecraft\versions\1.12.2-forge-14.23.5.2860\resources\custommainmenu\textures\splashes.txt"
                );

                File.WriteAllLines(splashTextPath, richTextBoxSplashes.Lines);
                File.WriteAllText(jsonPath, jObject.ToString(Formatting.Indented));

                MessageBox.Show("Minecraft dizinine ve JSON dosyasýna baþarýyla uygulandý.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kopyalama sýrasýnda hata oluþtu: " + ex.Message);
            }
        }

        private void logoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG Dosyalarý (*.png)|*.png";
                openFileDialog.Title = "Minecraft logosu seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    try
                    {
                        using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            logoButton.BackgroundImage?.Dispose();
                            logoButton.BackgroundImage = new Bitmap(Image.FromStream(fs));
                        }
                        logoButton.BackgroundImageLayout = ImageLayout.Stretch;

                        string targetDir = AppDomain.CurrentDomain.BaseDirectory;
                        string destinationPath = Path.Combine(targetDir, "minecraft.png");

                        if (File.Exists(destinationPath))
                            File.Delete(destinationPath);

                        File.Copy(selectedImagePath, destinationPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Logo seçilirken/kopyalanýrken hata oluþtu: " + ex.Message);
                    }
                }
            }
        }

        private void SetJsonText(JObject obj, string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                obj["text"] = text;
        }
    }
}
