using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symmetric
{
    public partial class Form1 : Form
    {
        private byte[] key;
        private byte[] iv;
        private byte[] cipherbytes;
        private Dictionary<string, TimeSpan> time = new Dictionary<string, TimeSpan>();
        private TimeSpan max;

        public Form1()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url.Text =  openFileDialog.FileName;                
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            time = new Dictionary<string, TimeSpan>();
            DesEcb();
            DesCbc();
            DesCfb();
            RijndaelCbc();
            RijndaelEcb();
            RijndaelCfb();
            Rc2Ecb();
            Rc2Cbc();
            Rc2Cfb();
            TripleDesEcb();
            TripleDesCbc();
            TripleDesCfb();
            AesEcb();
            AesCbc();
            AesCfb();
        }

        private void DesEcb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = DES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            desEcb.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            desEcbProc.Text = "100%";
            progressBarDesEcb.Value = 100;
            time.Add("desEcb", sw.Elapsed);
            max = sw.Elapsed;
        }
    
        private void DesCbc()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = DES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CBC;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            desCbc.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("desCbc", sw.Elapsed);
            Max("desCbc", sw.Elapsed);            
        }

        private void DesCfb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = DES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CFB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            desCfb.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("desCfb", sw.Elapsed);
            Max("desCfb", sw.Elapsed);
        }

        private void RijndaelCbc()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = Rijndael.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CBC;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cbcRijndael.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("rijndaelCbc", sw.Elapsed);
            Max("rijndaelCbc", sw.Elapsed);
        }

        private void RijndaelEcb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = Rijndael.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cfbRijndael.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("rijndaelEcb", sw.Elapsed);
            Max("rijndaelEcb", sw.Elapsed);
        }

        private void RijndaelCfb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = Rijndael.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CFB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            ecbRijndael.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("rijndaelCfb", sw.Elapsed);
            Max("rijndaelCfb", sw.Elapsed);
        }

        private void Rc2Ecb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = RC2.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            ecbRc2.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("rc2Ecb", sw.Elapsed);
            Max("rc2Ecb", sw.Elapsed);
        }

        private void Rc2Cbc()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = RC2.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CBC;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cbcRc2.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("rc2Cbc", sw.Elapsed);
            Max("rc2Cbc", sw.Elapsed);
        }

        private void Rc2Cfb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = RC2.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CFB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cfbRc2.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("rc2Cfb", sw.Elapsed);
            Max("rc2Cfb", sw.Elapsed);
        }

        private void TripleDesEcb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = TripleDES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            ecbTdes.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("tdesEcb", sw.Elapsed);
            Max("tdesEcb", sw.Elapsed);
        }

        private void TripleDesCbc()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = TripleDES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CBC;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cbcTdes.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("tdesCbc", sw.Elapsed);
            Max("tdesCbc", sw.Elapsed);
        }

        private void TripleDesCfb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = TripleDES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CFB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cfbTdes.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("tdesCfb", sw.Elapsed);
            Max("tdesCfb", sw.Elapsed);
        }

        private void AesEcb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = Aes.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            ecbAes.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("aesEcb", sw.Elapsed);
            Max("aesEcb", sw.Elapsed);
        }

        private void AesCbc()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = Aes.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CBC;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cbcAes.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("aesCbc", sw.Elapsed);
            Max("aesCbc", sw.Elapsed);
        }

        private void AesCfb()
        {
            var sw = new Stopwatch();
            sw.Start();
            SymmetricAlgorithm sa = Aes.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.GenerateIV();
            iv = sa.IV;
            sa.Mode = CipherMode.CFB;
            sa.Padding = PaddingMode.PKCS7;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    string text = "";
                    using (StreamReader reader = new StreamReader(url.Text))
                    {
                        text = reader.ReadToEnd();
                    }
                    byte[] plainbytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                }
                cipherbytes = ms.ToArray();
            }
            sw.Stop();
            cfbAes.Text = sw.Elapsed.TotalSeconds.ToString() + " сек";
            time.Add("aesCfb", sw.Elapsed);
            Max("aesCfb", sw.Elapsed);
        }


        private void Max(string key, TimeSpan swTime)
        {
            int res;
            if (max < swTime)
            {
                max = swTime;                
                foreach (var t in time)
                {
                    res = (int)(t.Value.TotalSeconds / (max.TotalSeconds / 100));
                    switch (t.Key)
                    {
                        case "desEcb":
                            desEcbProc.Text = res + "%";
                            progressBarDesEcb.Value = res;
                            break;
                        case "desCbc":
                            desCbcProc.Text = res + "%";
                            progressBarDesCbc.Value = res;
                            break;
                        case "desCfb":
                            desCfbProc.Text = res + "%";
                            progressBarDesCfb.Value = res;
                            break;
                        case "rijndaelCbc":
                            rijndaelCbcProc.Text = res + "%";
                            progressBarRijndaelCbc.Value = res;
                            break;
                        case "rijndaelEcb":
                            rijndaelEcbProc.Text = res + "%";
                            progressBarRijndaelEcb.Value = res;
                            break;
                        case "rijndaelCfb":
                            rijndaelCfbProc.Text = res + "%";
                            progressBarRijndaelCfb.Value = res;
                            break;
                        case "rc2Ecb":
                            rc2EcbProc.Text = res + "%";
                            progressBarRc2Ecb.Value = res;
                            break;
                        case "rc2Cbc":
                            rc2CbcProc.Text = res + "%";
                            progressBarRc2Cbc.Value = res;
                            break;
                        case "rc2Cfb":
                            rc2CfbProc.Text = res + "%";
                            progressBarRc2Cfb.Value = res;
                            break;
                        case "tdesEcb":
                            tDesEcbProc.Text = res + "%";
                            progressBarTdesEcb.Value = res;
                            break;
                        case "tdesCbc":
                            tDesCbcProc.Text = res + "%";
                            progressBarTdesCbc.Value = res;
                            break;
                        case "tdesCfb":
                            tDesCfbProc.Text = res + "%";
                            progressBarTdesCfb.Value = res;
                            break;
                        case "aesEcb":
                            aesEcbProc.Text = res + "%";
                            progressBarAesEcb.Value = res;
                            break;
                        case "aesCbc":
                            aesCbcProc.Text = res + "%";
                            progressBarAesCbc.Value = res;
                            break;
                        case "aesCfb":
                            aesCfbProc.Text = res + "%";
                            progressBarAesCfb.Value = res;
                            break;
                    }
                }
            }
            else
            {
                res = (int)(swTime.TotalSeconds / (max.TotalSeconds / 100));
                switch (key)
                {
                    case "desEcb":
                        desEcbProc.Text = res + "%";
                        progressBarDesEcb.Value = res;
                        break;
                    case "desCbc":
                        desCbcProc.Text = res + "%";
                        progressBarDesCbc.Value = res;
                        break;
                    case "desCfb":
                        desCfbProc.Text = res + "%";
                        progressBarDesCfb.Value = res;
                        break;
                    case "rijndaelCbc":
                        rijndaelCbcProc.Text = res + "%";
                        progressBarRijndaelCbc.Value = res;
                        break;
                    case "rijndaelEcb":
                        rijndaelEcbProc.Text = res + "%";
                        progressBarRijndaelEcb.Value = res;
                        break;
                    case "rijndaelCfb":
                        rijndaelCfbProc.Text = res + "%";
                        progressBarRijndaelCfb.Value = res;
                        break;
                    case "rc2Ecb":
                        rc2EcbProc.Text = res + "%";
                        progressBarRc2Ecb.Value = res;
                        break;
                    case "rc2Cbc":
                        rc2CbcProc.Text = res + "%";
                        progressBarRc2Cbc.Value = res;
                        break;
                    case "rc2Cfb":
                        rc2CfbProc.Text = res + "%";
                        progressBarRc2Cfb.Value = res;
                        break;
                    case "tdesEcb":
                        tDesEcbProc.Text = res + "%";
                        progressBarTdesEcb.Value = res;
                        break;
                    case "tdesCbc":
                        tDesCbcProc.Text = res + "%";
                        progressBarTdesCbc.Value = res;
                        break;
                    case "tdesCfb":
                        tDesCfbProc.Text = res + "%";
                        progressBarTdesCfb.Value = res;
                        break;
                    case "aesEcb":
                        aesEcbProc.Text = res + "%";
                        progressBarAesEcb.Value = res;
                        break;
                    case "aesCbc":
                        aesCbcProc.Text = res + "%";
                        progressBarAesCbc.Value = res;
                        break;
                    case "aesCfb":
                        aesCfbProc.Text = res + "%";
                        progressBarAesCfb.Value = res;
                        break;
                }
            }
        }
    }
}
