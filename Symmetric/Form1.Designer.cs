
namespace Symmetric
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.progressBarDesEcb = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.desEcbProc = new System.Windows.Forms.Label();
            this.desEcb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarDesCbc = new System.Windows.Forms.ProgressBar();
            this.progressBarDesCfb = new System.Windows.Forms.ProgressBar();
            this.desCbcProc = new System.Windows.Forms.Label();
            this.desCfbProc = new System.Windows.Forms.Label();
            this.desCbc = new System.Windows.Forms.Label();
            this.desCfb = new System.Windows.Forms.Label();
            this.progressBarRijndaelCbc = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.rijndaelCbcProc = new System.Windows.Forms.Label();
            this.cbcRijndael = new System.Windows.Forms.Label();
            this.progressBarRijndaelEcb = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.rijndaelEcbProc = new System.Windows.Forms.Label();
            this.ecbRijndael = new System.Windows.Forms.Label();
            this.progressBarRijndaelCfb = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.rijndaelCfbProc = new System.Windows.Forms.Label();
            this.cfbRijndael = new System.Windows.Forms.Label();
            this.progressBarRc2Ecb = new System.Windows.Forms.ProgressBar();
            this.progressBarRc2Cbc = new System.Windows.Forms.ProgressBar();
            this.progressBarRc2Cfb = new System.Windows.Forms.ProgressBar();
            this.rc2EcbProc = new System.Windows.Forms.Label();
            this.rc2CbcProc = new System.Windows.Forms.Label();
            this.rc2CfbProc = new System.Windows.Forms.Label();
            this.ecbRc2 = new System.Windows.Forms.Label();
            this.cbcRc2 = new System.Windows.Forms.Label();
            this.cfbRc2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.progressBarTdesEcb = new System.Windows.Forms.ProgressBar();
            this.progressBarTdesCbc = new System.Windows.Forms.ProgressBar();
            this.progressBarTdesCfb = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tDesEcbProc = new System.Windows.Forms.Label();
            this.tDesCbcProc = new System.Windows.Forms.Label();
            this.tDesCfbProc = new System.Windows.Forms.Label();
            this.ecbTdes = new System.Windows.Forms.Label();
            this.cbcTdes = new System.Windows.Forms.Label();
            this.cfbTdes = new System.Windows.Forms.Label();
            this.progressBarAesEcb = new System.Windows.Forms.ProgressBar();
            this.progressBarAesCbc = new System.Windows.Forms.ProgressBar();
            this.progressBarAesCfb = new System.Windows.Forms.ProgressBar();
            this.aesEcbProc = new System.Windows.Forms.Label();
            this.aesCbcProc = new System.Windows.Forms.Label();
            this.aesCfbProc = new System.Windows.Forms.Label();
            this.ecbAes = new System.Windows.Forms.Label();
            this.cbcAes = new System.Windows.Forms.Label();
            this.cfbAes = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл:";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(137, 9);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(357, 22);
            this.url.TabIndex = 1;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(500, 3);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(161, 35);
            this.download.TabIndex = 2;
            this.download.Text = "Загрузить";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(610, 429);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(178, 57);
            this.start.TabIndex = 3;
            this.start.Text = "Начать тестирование";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // progressBarDesEcb
            // 
            this.progressBarDesEcb.Location = new System.Drawing.Point(137, 62);
            this.progressBarDesEcb.Name = "progressBarDesEcb";
            this.progressBarDesEcb.Size = new System.Drawing.Size(357, 17);
            this.progressBarDesEcb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DES.ECB";
            // 
            // desEcbProc
            // 
            this.desEcbProc.AutoSize = true;
            this.desEcbProc.Location = new System.Drawing.Point(500, 62);
            this.desEcbProc.Name = "desEcbProc";
            this.desEcbProc.Size = new System.Drawing.Size(28, 17);
            this.desEcbProc.TabIndex = 6;
            this.desEcbProc.Text = "0%";
            // 
            // desEcb
            // 
            this.desEcb.AutoSize = true;
            this.desEcb.Location = new System.Drawing.Point(543, 62);
            this.desEcb.Name = "desEcb";
            this.desEcb.Size = new System.Drawing.Size(16, 17);
            this.desEcb.TabIndex = 8;
            this.desEcb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "DES.CFB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "DES.CBC";
            // 
            // progressBarDesCbc
            // 
            this.progressBarDesCbc.Location = new System.Drawing.Point(137, 85);
            this.progressBarDesCbc.Name = "progressBarDesCbc";
            this.progressBarDesCbc.Size = new System.Drawing.Size(357, 17);
            this.progressBarDesCbc.TabIndex = 11;
            // 
            // progressBarDesCfb
            // 
            this.progressBarDesCfb.Location = new System.Drawing.Point(137, 108);
            this.progressBarDesCfb.Name = "progressBarDesCfb";
            this.progressBarDesCfb.Size = new System.Drawing.Size(357, 17);
            this.progressBarDesCfb.TabIndex = 12;
            // 
            // desCbcProc
            // 
            this.desCbcProc.AutoSize = true;
            this.desCbcProc.Location = new System.Drawing.Point(500, 85);
            this.desCbcProc.Name = "desCbcProc";
            this.desCbcProc.Size = new System.Drawing.Size(28, 17);
            this.desCbcProc.TabIndex = 13;
            this.desCbcProc.Text = "0%";
            // 
            // desCfbProc
            // 
            this.desCfbProc.AutoSize = true;
            this.desCfbProc.Location = new System.Drawing.Point(500, 108);
            this.desCfbProc.Name = "desCfbProc";
            this.desCfbProc.Size = new System.Drawing.Size(28, 17);
            this.desCfbProc.TabIndex = 14;
            this.desCfbProc.Text = "0%";
            // 
            // desCbc
            // 
            this.desCbc.AutoSize = true;
            this.desCbc.Location = new System.Drawing.Point(543, 85);
            this.desCbc.Name = "desCbc";
            this.desCbc.Size = new System.Drawing.Size(16, 17);
            this.desCbc.TabIndex = 15;
            this.desCbc.Text = "0";
            // 
            // desCfb
            // 
            this.desCfb.AutoSize = true;
            this.desCfb.Location = new System.Drawing.Point(543, 108);
            this.desCfb.Name = "desCfb";
            this.desCfb.Size = new System.Drawing.Size(16, 17);
            this.desCfb.TabIndex = 16;
            this.desCfb.Text = "0";
            // 
            // progressBarRijndaelCbc
            // 
            this.progressBarRijndaelCbc.Location = new System.Drawing.Point(137, 131);
            this.progressBarRijndaelCbc.Name = "progressBarRijndaelCbc";
            this.progressBarRijndaelCbc.Size = new System.Drawing.Size(357, 17);
            this.progressBarRijndaelCbc.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Rijndael.CBC";
            // 
            // rijndaelCbcProc
            // 
            this.rijndaelCbcProc.AutoSize = true;
            this.rijndaelCbcProc.Location = new System.Drawing.Point(500, 131);
            this.rijndaelCbcProc.Name = "rijndaelCbcProc";
            this.rijndaelCbcProc.Size = new System.Drawing.Size(28, 17);
            this.rijndaelCbcProc.TabIndex = 19;
            this.rijndaelCbcProc.Text = "0%";
            // 
            // cbcRijndael
            // 
            this.cbcRijndael.AutoSize = true;
            this.cbcRijndael.Location = new System.Drawing.Point(543, 131);
            this.cbcRijndael.Name = "cbcRijndael";
            this.cbcRijndael.Size = new System.Drawing.Size(16, 17);
            this.cbcRijndael.TabIndex = 20;
            this.cbcRijndael.Text = "0";
            // 
            // progressBarRijndaelEcb
            // 
            this.progressBarRijndaelEcb.Location = new System.Drawing.Point(137, 154);
            this.progressBarRijndaelEcb.Name = "progressBarRijndaelEcb";
            this.progressBarRijndaelEcb.Size = new System.Drawing.Size(357, 17);
            this.progressBarRijndaelEcb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rijndael.ECB";
            // 
            // rijndaelEcbProc
            // 
            this.rijndaelEcbProc.AutoSize = true;
            this.rijndaelEcbProc.Location = new System.Drawing.Point(500, 154);
            this.rijndaelEcbProc.Name = "rijndaelEcbProc";
            this.rijndaelEcbProc.Size = new System.Drawing.Size(28, 17);
            this.rijndaelEcbProc.TabIndex = 23;
            this.rijndaelEcbProc.Text = "0%";
            // 
            // ecbRijndael
            // 
            this.ecbRijndael.AutoSize = true;
            this.ecbRijndael.Location = new System.Drawing.Point(543, 154);
            this.ecbRijndael.Name = "ecbRijndael";
            this.ecbRijndael.Size = new System.Drawing.Size(16, 17);
            this.ecbRijndael.TabIndex = 24;
            this.ecbRijndael.Text = "0";
            // 
            // progressBarRijndaelCfb
            // 
            this.progressBarRijndaelCfb.Location = new System.Drawing.Point(137, 177);
            this.progressBarRijndaelCfb.Name = "progressBarRijndaelCfb";
            this.progressBarRijndaelCfb.Size = new System.Drawing.Size(357, 17);
            this.progressBarRijndaelCfb.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rijndael.CFB";
            // 
            // rijndaelCfbProc
            // 
            this.rijndaelCfbProc.AutoSize = true;
            this.rijndaelCfbProc.Location = new System.Drawing.Point(500, 177);
            this.rijndaelCfbProc.Name = "rijndaelCfbProc";
            this.rijndaelCfbProc.Size = new System.Drawing.Size(28, 17);
            this.rijndaelCfbProc.TabIndex = 27;
            this.rijndaelCfbProc.Text = "0%";
            // 
            // cfbRijndael
            // 
            this.cfbRijndael.AutoSize = true;
            this.cfbRijndael.Location = new System.Drawing.Point(543, 177);
            this.cfbRijndael.Name = "cfbRijndael";
            this.cfbRijndael.Size = new System.Drawing.Size(16, 17);
            this.cfbRijndael.TabIndex = 28;
            this.cfbRijndael.Text = "0";
            // 
            // progressBarRc2Ecb
            // 
            this.progressBarRc2Ecb.Location = new System.Drawing.Point(137, 200);
            this.progressBarRc2Ecb.Name = "progressBarRc2Ecb";
            this.progressBarRc2Ecb.Size = new System.Drawing.Size(357, 17);
            this.progressBarRc2Ecb.TabIndex = 29;
            // 
            // progressBarRc2Cbc
            // 
            this.progressBarRc2Cbc.Location = new System.Drawing.Point(137, 223);
            this.progressBarRc2Cbc.Name = "progressBarRc2Cbc";
            this.progressBarRc2Cbc.Size = new System.Drawing.Size(357, 17);
            this.progressBarRc2Cbc.TabIndex = 30;
            // 
            // progressBarRc2Cfb
            // 
            this.progressBarRc2Cfb.Location = new System.Drawing.Point(137, 246);
            this.progressBarRc2Cfb.Name = "progressBarRc2Cfb";
            this.progressBarRc2Cfb.Size = new System.Drawing.Size(357, 17);
            this.progressBarRc2Cfb.TabIndex = 31;
            // 
            // rc2EcbProc
            // 
            this.rc2EcbProc.AutoSize = true;
            this.rc2EcbProc.Location = new System.Drawing.Point(500, 200);
            this.rc2EcbProc.Name = "rc2EcbProc";
            this.rc2EcbProc.Size = new System.Drawing.Size(28, 17);
            this.rc2EcbProc.TabIndex = 32;
            this.rc2EcbProc.Text = "0%";
            // 
            // rc2CbcProc
            // 
            this.rc2CbcProc.AutoSize = true;
            this.rc2CbcProc.Location = new System.Drawing.Point(500, 223);
            this.rc2CbcProc.Name = "rc2CbcProc";
            this.rc2CbcProc.Size = new System.Drawing.Size(28, 17);
            this.rc2CbcProc.TabIndex = 33;
            this.rc2CbcProc.Text = "0%";
            // 
            // rc2CfbProc
            // 
            this.rc2CfbProc.AutoSize = true;
            this.rc2CfbProc.Location = new System.Drawing.Point(500, 246);
            this.rc2CfbProc.Name = "rc2CfbProc";
            this.rc2CfbProc.Size = new System.Drawing.Size(28, 17);
            this.rc2CfbProc.TabIndex = 34;
            this.rc2CfbProc.Text = "0%";
            // 
            // ecbRc2
            // 
            this.ecbRc2.AutoSize = true;
            this.ecbRc2.Location = new System.Drawing.Point(543, 200);
            this.ecbRc2.Name = "ecbRc2";
            this.ecbRc2.Size = new System.Drawing.Size(16, 17);
            this.ecbRc2.TabIndex = 35;
            this.ecbRc2.Text = "0";
            // 
            // cbcRc2
            // 
            this.cbcRc2.AutoSize = true;
            this.cbcRc2.Location = new System.Drawing.Point(543, 223);
            this.cbcRc2.Name = "cbcRc2";
            this.cbcRc2.Size = new System.Drawing.Size(16, 17);
            this.cbcRc2.TabIndex = 36;
            this.cbcRc2.Text = "0";
            // 
            // cfbRc2
            // 
            this.cfbRc2.AutoSize = true;
            this.cfbRc2.Location = new System.Drawing.Point(543, 246);
            this.cfbRc2.Name = "cfbRc2";
            this.cfbRc2.Size = new System.Drawing.Size(16, 17);
            this.cfbRc2.TabIndex = 37;
            this.cfbRc2.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "RC2.ECB";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "RC2.CFB";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "RC2.CBC";
            // 
            // progressBarTdesEcb
            // 
            this.progressBarTdesEcb.Location = new System.Drawing.Point(137, 269);
            this.progressBarTdesEcb.Name = "progressBarTdesEcb";
            this.progressBarTdesEcb.Size = new System.Drawing.Size(357, 17);
            this.progressBarTdesEcb.TabIndex = 41;
            // 
            // progressBarTdesCbc
            // 
            this.progressBarTdesCbc.Location = new System.Drawing.Point(137, 292);
            this.progressBarTdesCbc.Name = "progressBarTdesCbc";
            this.progressBarTdesCbc.Size = new System.Drawing.Size(357, 17);
            this.progressBarTdesCbc.TabIndex = 42;
            // 
            // progressBarTdesCfb
            // 
            this.progressBarTdesCfb.Location = new System.Drawing.Point(137, 315);
            this.progressBarTdesCfb.Name = "progressBarTdesCfb";
            this.progressBarTdesCfb.Size = new System.Drawing.Size(357, 17);
            this.progressBarTdesCfb.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "TripleDES.ECB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "TripleDES.CBC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "TripleDES.CFB";
            // 
            // tDesEcbProc
            // 
            this.tDesEcbProc.AutoSize = true;
            this.tDesEcbProc.Location = new System.Drawing.Point(500, 269);
            this.tDesEcbProc.Name = "tDesEcbProc";
            this.tDesEcbProc.Size = new System.Drawing.Size(28, 17);
            this.tDesEcbProc.TabIndex = 47;
            this.tDesEcbProc.Text = "0%";
            // 
            // tDesCbcProc
            // 
            this.tDesCbcProc.AutoSize = true;
            this.tDesCbcProc.Location = new System.Drawing.Point(500, 292);
            this.tDesCbcProc.Name = "tDesCbcProc";
            this.tDesCbcProc.Size = new System.Drawing.Size(28, 17);
            this.tDesCbcProc.TabIndex = 48;
            this.tDesCbcProc.Text = "0%";
            // 
            // tDesCfbProc
            // 
            this.tDesCfbProc.AutoSize = true;
            this.tDesCfbProc.Location = new System.Drawing.Point(500, 315);
            this.tDesCfbProc.Name = "tDesCfbProc";
            this.tDesCfbProc.Size = new System.Drawing.Size(28, 17);
            this.tDesCfbProc.TabIndex = 49;
            this.tDesCfbProc.Text = "0%";
            // 
            // ecbTdes
            // 
            this.ecbTdes.AutoSize = true;
            this.ecbTdes.Location = new System.Drawing.Point(543, 269);
            this.ecbTdes.Name = "ecbTdes";
            this.ecbTdes.Size = new System.Drawing.Size(16, 17);
            this.ecbTdes.TabIndex = 50;
            this.ecbTdes.Text = "0";
            // 
            // cbcTdes
            // 
            this.cbcTdes.AutoSize = true;
            this.cbcTdes.Location = new System.Drawing.Point(543, 292);
            this.cbcTdes.Name = "cbcTdes";
            this.cbcTdes.Size = new System.Drawing.Size(16, 17);
            this.cbcTdes.TabIndex = 51;
            this.cbcTdes.Text = "0";
            // 
            // cfbTdes
            // 
            this.cfbTdes.AutoSize = true;
            this.cfbTdes.Location = new System.Drawing.Point(543, 315);
            this.cfbTdes.Name = "cfbTdes";
            this.cfbTdes.Size = new System.Drawing.Size(16, 17);
            this.cfbTdes.TabIndex = 52;
            this.cfbTdes.Text = "0";
            // 
            // progressBarAesEcb
            // 
            this.progressBarAesEcb.Location = new System.Drawing.Point(137, 338);
            this.progressBarAesEcb.Name = "progressBarAesEcb";
            this.progressBarAesEcb.Size = new System.Drawing.Size(357, 17);
            this.progressBarAesEcb.TabIndex = 53;
            // 
            // progressBarAesCbc
            // 
            this.progressBarAesCbc.Location = new System.Drawing.Point(137, 361);
            this.progressBarAesCbc.Name = "progressBarAesCbc";
            this.progressBarAesCbc.Size = new System.Drawing.Size(357, 17);
            this.progressBarAesCbc.TabIndex = 54;
            // 
            // progressBarAesCfb
            // 
            this.progressBarAesCfb.Location = new System.Drawing.Point(137, 384);
            this.progressBarAesCfb.Name = "progressBarAesCfb";
            this.progressBarAesCfb.Size = new System.Drawing.Size(357, 17);
            this.progressBarAesCfb.TabIndex = 55;
            // 
            // aesEcbProc
            // 
            this.aesEcbProc.AutoSize = true;
            this.aesEcbProc.Location = new System.Drawing.Point(500, 338);
            this.aesEcbProc.Name = "aesEcbProc";
            this.aesEcbProc.Size = new System.Drawing.Size(28, 17);
            this.aesEcbProc.TabIndex = 56;
            this.aesEcbProc.Text = "0%";
            // 
            // aesCbcProc
            // 
            this.aesCbcProc.AutoSize = true;
            this.aesCbcProc.Location = new System.Drawing.Point(500, 361);
            this.aesCbcProc.Name = "aesCbcProc";
            this.aesCbcProc.Size = new System.Drawing.Size(28, 17);
            this.aesCbcProc.TabIndex = 57;
            this.aesCbcProc.Text = "0%";
            // 
            // aesCfbProc
            // 
            this.aesCfbProc.AutoSize = true;
            this.aesCfbProc.Location = new System.Drawing.Point(500, 384);
            this.aesCfbProc.Name = "aesCfbProc";
            this.aesCfbProc.Size = new System.Drawing.Size(28, 17);
            this.aesCfbProc.TabIndex = 58;
            this.aesCfbProc.Text = "0%";
            // 
            // ecbAes
            // 
            this.ecbAes.AutoSize = true;
            this.ecbAes.Location = new System.Drawing.Point(543, 338);
            this.ecbAes.Name = "ecbAes";
            this.ecbAes.Size = new System.Drawing.Size(16, 17);
            this.ecbAes.TabIndex = 59;
            this.ecbAes.Text = "0";
            // 
            // cbcAes
            // 
            this.cbcAes.AutoSize = true;
            this.cbcAes.Location = new System.Drawing.Point(543, 361);
            this.cbcAes.Name = "cbcAes";
            this.cbcAes.Size = new System.Drawing.Size(16, 17);
            this.cbcAes.TabIndex = 60;
            this.cbcAes.Text = "0";
            // 
            // cfbAes
            // 
            this.cfbAes.AutoSize = true;
            this.cfbAes.Location = new System.Drawing.Point(543, 384);
            this.cfbAes.Name = "cfbAes";
            this.cfbAes.Size = new System.Drawing.Size(16, 17);
            this.cfbAes.TabIndex = 61;
            this.cfbAes.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(65, 338);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 62;
            this.label20.Text = "Aes.ECB";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(65, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 63;
            this.label21.Text = "Aes.CBC";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(65, 384);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 17);
            this.label22.TabIndex = 64;
            this.label22.Text = "Aes.CFB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cfbAes);
            this.Controls.Add(this.cbcAes);
            this.Controls.Add(this.ecbAes);
            this.Controls.Add(this.aesCfbProc);
            this.Controls.Add(this.aesCbcProc);
            this.Controls.Add(this.aesEcbProc);
            this.Controls.Add(this.progressBarAesCfb);
            this.Controls.Add(this.progressBarAesCbc);
            this.Controls.Add(this.progressBarAesEcb);
            this.Controls.Add(this.cfbTdes);
            this.Controls.Add(this.cbcTdes);
            this.Controls.Add(this.ecbTdes);
            this.Controls.Add(this.tDesCfbProc);
            this.Controls.Add(this.tDesCbcProc);
            this.Controls.Add(this.tDesEcbProc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBarTdesCfb);
            this.Controls.Add(this.progressBarTdesCbc);
            this.Controls.Add(this.progressBarTdesEcb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cfbRc2);
            this.Controls.Add(this.cbcRc2);
            this.Controls.Add(this.ecbRc2);
            this.Controls.Add(this.rc2CfbProc);
            this.Controls.Add(this.rc2CbcProc);
            this.Controls.Add(this.rc2EcbProc);
            this.Controls.Add(this.progressBarRc2Cfb);
            this.Controls.Add(this.progressBarRc2Cbc);
            this.Controls.Add(this.progressBarRc2Ecb);
            this.Controls.Add(this.cfbRijndael);
            this.Controls.Add(this.rijndaelCfbProc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBarRijndaelCfb);
            this.Controls.Add(this.ecbRijndael);
            this.Controls.Add(this.rijndaelEcbProc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBarRijndaelEcb);
            this.Controls.Add(this.cbcRijndael);
            this.Controls.Add(this.rijndaelCbcProc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarRijndaelCbc);
            this.Controls.Add(this.desCfb);
            this.Controls.Add(this.desCbc);
            this.Controls.Add(this.desCfbProc);
            this.Controls.Add(this.desCbcProc);
            this.Controls.Add(this.progressBarDesCfb);
            this.Controls.Add(this.progressBarDesCbc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desEcb);
            this.Controls.Add(this.desEcbProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarDesEcb);
            this.Controls.Add(this.start);
            this.Controls.Add(this.download);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ProgressBar progressBarDesEcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label desEcbProc;
        private System.Windows.Forms.Label desEcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarDesCbc;
        private System.Windows.Forms.ProgressBar progressBarDesCfb;
        private System.Windows.Forms.Label desCbcProc;
        private System.Windows.Forms.Label desCfbProc;
        private System.Windows.Forms.Label desCbc;
        private System.Windows.Forms.Label desCfb;
        private System.Windows.Forms.ProgressBar progressBarRijndaelCbc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rijndaelCbcProc;
        private System.Windows.Forms.Label cbcRijndael;
        private System.Windows.Forms.ProgressBar progressBarRijndaelEcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rijndaelEcbProc;
        private System.Windows.Forms.Label ecbRijndael;
        private System.Windows.Forms.ProgressBar progressBarRijndaelCfb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rijndaelCfbProc;
        private System.Windows.Forms.Label cfbRijndael;
        private System.Windows.Forms.ProgressBar progressBarRc2Ecb;
        private System.Windows.Forms.ProgressBar progressBarRc2Cbc;
        private System.Windows.Forms.ProgressBar progressBarRc2Cfb;
        private System.Windows.Forms.Label rc2EcbProc;
        private System.Windows.Forms.Label rc2CbcProc;
        private System.Windows.Forms.Label rc2CfbProc;
        private System.Windows.Forms.Label ecbRc2;
        private System.Windows.Forms.Label cbcRc2;
        private System.Windows.Forms.Label cfbRc2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar progressBarTdesEcb;
        private System.Windows.Forms.ProgressBar progressBarTdesCbc;
        private System.Windows.Forms.ProgressBar progressBarTdesCfb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tDesEcbProc;
        private System.Windows.Forms.Label tDesCbcProc;
        private System.Windows.Forms.Label tDesCfbProc;
        private System.Windows.Forms.Label ecbTdes;
        private System.Windows.Forms.Label cbcTdes;
        private System.Windows.Forms.Label cfbTdes;
        private System.Windows.Forms.ProgressBar progressBarAesEcb;
        private System.Windows.Forms.ProgressBar progressBarAesCbc;
        private System.Windows.Forms.ProgressBar progressBarAesCfb;
        private System.Windows.Forms.Label aesEcbProc;
        private System.Windows.Forms.Label aesCbcProc;
        private System.Windows.Forms.Label aesCfbProc;
        private System.Windows.Forms.Label ecbAes;
        private System.Windows.Forms.Label cbcAes;
        private System.Windows.Forms.Label cfbAes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

