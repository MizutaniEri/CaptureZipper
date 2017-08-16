using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureZipper
{
    public partial class Form1 : Form
    {
        private readonly long quality = 100;
        private EncoderParameters eps;
        private EncoderParameter ep;
        private ImageCodecInfo ici;

        public Form1()
        {
            InitializeComponent();
            JpegQualitySetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "zip";
            saveDialog.Filter = "ZIP File|*.zip";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveDialog.FileName;
            }
        }

        private void JpegQualitySetting()
        {
            //EncoderParameterオブジェクトを1つ格納できる
            //EncoderParametersクラスの新しいインスタンスを初期化
            //ここでは品質のみ指定するため1つだけ用意する
            eps = new EncoderParameters(1);
            //品質を指定
            ep = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)quality);
            //EncoderParametersにセットする
            eps.Param[0] = ep;
            //イメージエンコーダに関する情報を取得する
            ici = GetEncoderInfo("image/jpeg");
        }
        //MimeTypeで指定されたImageCodecInfoを探して返す
        private static ImageCodecInfo GetEncoderInfo(string mineType)
        {
            //GDI+ に組み込まれたイメージ エンコーダに関する情報をすべて取得
            return ImageCodecInfo.GetImageEncoders().ToList().Find(enc => enc.MimeType == mineType);
        }

        //ImageFormatで指定されたImageCodecInfoを探して返す
        private static ImageCodecInfo GetEncoderInfo(System.Drawing.Imaging.ImageFormat f)
        {
            return ImageCodecInfo.GetImageEncoders().ToList().Find(enc => enc.FormatID == f.Guid);
        }
        private void saveZipFile(string FileName)
        {
            Hide();
            Thread.Sleep(100);
            using (var zto = new FileStream(FileName, FileMode.Create))
            {
                using (var zipArc = new ZipArchive(zto, ZipArchiveMode.Create))
                {
                    Enumerable.Range(1, (int)numericUpDown6.Value).ToList().ForEach(number =>
                    {
                        new SoundPlayer(@"C:\Windows\Media\Windows Error.wav").PlaySync();
                        Thread.Sleep((int)numericUpDown5.Value);
                        var imageFileName = BaseNameTextBox.Text + number.ToString("D2") + ".jpg";
                        var entry = zipArc.CreateEntry(imageFileName);
                        using (var writer = entry.Open())
                        {
                            var memStream = new MemoryStream();
                            //var iformat = ImageFormat.Jpeg;
                            // 画像をメモリストリームに保存する(指定の画像形式で)
                            int width = (int)(numericUpDown3.Value - numericUpDown1.Value);
                            int height = (int)(numericUpDown4.Value - numericUpDown2.Value);
                            var img = new Bitmap(width, height);
                            var grp = Graphics.FromImage(img);
                            int leftX = (int)numericUpDown1.Value;
                            int leftY = (int)numericUpDown2.Value;
                            grp.CopyFromScreen(new Point(leftX, leftY), new Point(leftX, leftY), img.Size);
                            grp.Dispose();
                            //img.Save(memStream, iformat);
                            img.Save(memStream, ici, eps);
                            long len = memStream.Length;
                            int baseSize = int.MaxValue;
                            int offset = 0;
                            var buf = memStream.ToArray();
                            while (len > 0)
                            {
                                int wlen = len > baseSize ? baseSize : (int)len;
                                writer.Write(buf, offset, wlen);
                                len -= wlen;
                                offset += wlen;
                            }
                            //new SoundPlayer(@"C:\Windows\Media\Windows Exclamation.wav").PlaySync();
                            //Thread.Sleep((int)numericUpDown5.Value/2);
                            SendKeys.SendWait("{LEFT}");
                        }
                    });
                }
            }
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveZipFile(textBox1.Text);
        }
    }
}
