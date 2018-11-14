using System;
using System.Drawing;

namespace MiniPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процессToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUndo = new System.Windows.Forms.ToolStripButton();
            this.RedoBTN = new System.Windows.Forms.ToolStripButton();
            this.SerialBTN = new System.Windows.Forms.ToolStripButton();
            this.DeserialBTN = new System.Windows.Forms.ToolStripButton();
            this.groupBoxForTools = new System.Windows.Forms.GroupBox();
            this.WidthLineBTN = new System.Windows.Forms.Button();
            this.RubberToolsBTN = new System.Windows.Forms.Button();
            this.FillToolsBTN = new System.Windows.Forms.Button();
            this.TextToolsBTN = new System.Windows.Forms.Button();
            this.ElipseToolsBTN = new System.Windows.Forms.Button();
            this.SquardToolsBTN = new System.Windows.Forms.Button();
            this.LineToolsBTN = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.rightRBTN = new System.Windows.Forms.RadioButton();
            this.leftRBTN = new System.Windows.Forms.RadioButton();
            this.ButtonColors = new System.Windows.Forms.Button();
            this.ColorBTN8 = new System.Windows.Forms.Button();
            this.ColorBTN4 = new System.Windows.Forms.Button();
            this.ColorBTN7 = new System.Windows.Forms.Button();
            this.ColorBTN3 = new System.Windows.Forms.Button();
            this.ColorBTN6 = new System.Windows.Forms.Button();
            this.ColorBTN2 = new System.Windows.Forms.Button();
            this.ColorBTN5 = new System.Windows.Forms.Button();
            this.ColorBTN1 = new System.Windows.Forms.Button();
            this.RightChoiceBTN = new System.Windows.Forms.Button();
            this.leftChoiceBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Line1BTN = new System.Windows.Forms.Button();
            this.Line2BTN = new System.Windows.Forms.Button();
            this.Line3BTN = new System.Windows.Forms.Button();
            this.Line4BTN = new System.Windows.Forms.Button();
            this.LineBox = new System.Windows.Forms.GroupBox();
            this.RubberOptionBox = new System.Windows.Forms.GroupBox();
            this.RubberPictureBox = new System.Windows.Forms.PictureBox();
            this.RubberPlusBTN = new System.Windows.Forms.Button();
            this.RubberMinusBTN = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolStripMenu.SuspendLayout();
            this.groupBoxForTools.SuspendLayout();
            this.ColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LineBox.SuspendLayout();
            this.RubberOptionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RubberPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuUndo,
            this.RedoBTN,
            this.SerialBTN,
            this.DeserialBTN});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(975, 27);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStripMenu";
            // 
            // MenuFile
            // 
            this.MenuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(33, 24);
            this.MenuFile.Text = "Меню";
            this.MenuFile.Click += new System.EventHandler(this.MenuFile_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процессToolStripMenuItem1,
            this.файлToolStripMenuItem});
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // процессToolStripMenuItem1
            // 
            this.процессToolStripMenuItem1.Name = "процессToolStripMenuItem1";
            this.процессToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.процессToolStripMenuItem1.Text = "Процесс";
            this.процессToolStripMenuItem1.Click += new System.EventHandler(this.процессToolStripMenuItem1_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.файлToolStripMenuItem.Text = "Изображение";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процессToolStripMenuItem,
            this.изображениеToolStripMenuItem});
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // процессToolStripMenuItem
            // 
            this.процессToolStripMenuItem.Name = "процессToolStripMenuItem";
            this.процессToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.процессToolStripMenuItem.Text = "Процесс";
            this.процессToolStripMenuItem.Click += new System.EventHandler(this.процессToolStripMenuItem_Click);
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            this.изображениеToolStripMenuItem.Click += new System.EventHandler(this.изображениеToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.PrintToolStripMenuItem.Text = "Печать";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MenuUndo
            // 
            this.MenuUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuUndo.Enabled = false;
            this.MenuUndo.Image = ((System.Drawing.Image)(resources.GetObject("MenuUndo.Image")));
            this.MenuUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuUndo.Name = "MenuUndo";
            this.MenuUndo.Size = new System.Drawing.Size(24, 24);
            this.MenuUndo.Text = "Отменить";
            this.MenuUndo.Click += new System.EventHandler(this.MenuUndo_Click);
            // 
            // RedoBTN
            // 
            this.RedoBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoBTN.Enabled = false;
            this.RedoBTN.Image = ((System.Drawing.Image)(resources.GetObject("RedoBTN.Image")));
            this.RedoBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoBTN.Name = "RedoBTN";
            this.RedoBTN.Size = new System.Drawing.Size(24, 24);
            this.RedoBTN.Text = "Вернуть";
            this.RedoBTN.Click += new System.EventHandler(this.RedoBTN_Click);
            // 
            // SerialBTN
            // 
            this.SerialBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SerialBTN.Image = ((System.Drawing.Image)(resources.GetObject("SerialBTN.Image")));
            this.SerialBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SerialBTN.Name = "SerialBTN";
            this.SerialBTN.Size = new System.Drawing.Size(24, 24);
            this.SerialBTN.Text = "Сохранить процесс";
            this.SerialBTN.Click += new System.EventHandler(this.SerialBTN_Click);
            // 
            // DeserialBTN
            // 
            this.DeserialBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeserialBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeserialBTN.Image")));
            this.DeserialBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeserialBTN.Name = "DeserialBTN";
            this.DeserialBTN.Size = new System.Drawing.Size(24, 24);
            this.DeserialBTN.Text = "Возобновить процесс";
            this.DeserialBTN.Click += new System.EventHandler(this.DeserialBTN_Click);
            // 
            // groupBoxForTools
            // 
            this.groupBoxForTools.Controls.Add(this.WidthLineBTN);
            this.groupBoxForTools.Controls.Add(this.RubberToolsBTN);
            this.groupBoxForTools.Controls.Add(this.FillToolsBTN);
            this.groupBoxForTools.Controls.Add(this.TextToolsBTN);
            this.groupBoxForTools.Controls.Add(this.ElipseToolsBTN);
            this.groupBoxForTools.Controls.Add(this.SquardToolsBTN);
            this.groupBoxForTools.Controls.Add(this.LineToolsBTN);
            this.groupBoxForTools.Location = new System.Drawing.Point(491, 18);
            this.groupBoxForTools.Name = "groupBoxForTools";
            this.groupBoxForTools.Size = new System.Drawing.Size(197, 79);
            this.groupBoxForTools.TabIndex = 1;
            this.groupBoxForTools.TabStop = false;
            // 
            // WidthLineBTN
            // 
            this.WidthLineBTN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WidthLineBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WidthLineBTN.BackgroundImage")));
            this.WidthLineBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WidthLineBTN.Location = new System.Drawing.Point(118, 9);
            this.WidthLineBTN.Name = "WidthLineBTN";
            this.WidthLineBTN.Size = new System.Drawing.Size(73, 69);
            this.WidthLineBTN.TabIndex = 6;
            this.WidthLineBTN.UseVisualStyleBackColor = false;
            this.WidthLineBTN.Click += new System.EventHandler(this.WidthLineBTN_Click);
            // 
            // RubberToolsBTN
            // 
            this.RubberToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RubberToolsBTN.BackgroundImage")));
            this.RubberToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RubberToolsBTN.Location = new System.Drawing.Point(82, 44);
            this.RubberToolsBTN.Name = "RubberToolsBTN";
            this.RubberToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.RubberToolsBTN.TabIndex = 5;
            this.RubberToolsBTN.UseVisualStyleBackColor = true;
            this.RubberToolsBTN.Click += new System.EventHandler(this.RubberToolsBTN_Click);
            // 
            // FillToolsBTN
            // 
            this.FillToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FillToolsBTN.BackgroundImage")));
            this.FillToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillToolsBTN.Location = new System.Drawing.Point(44, 46);
            this.FillToolsBTN.Name = "FillToolsBTN";
            this.FillToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.FillToolsBTN.TabIndex = 4;
            this.FillToolsBTN.UseVisualStyleBackColor = true;
            this.FillToolsBTN.Click += new System.EventHandler(this.FillToolsBTN_Click);
            // 
            // TextToolsBTN
            // 
            this.TextToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextToolsBTN.BackgroundImage")));
            this.TextToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TextToolsBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextToolsBTN.Location = new System.Drawing.Point(6, 43);
            this.TextToolsBTN.Name = "TextToolsBTN";
            this.TextToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.TextToolsBTN.TabIndex = 3;
            this.TextToolsBTN.UseVisualStyleBackColor = true;
            this.TextToolsBTN.Click += new System.EventHandler(this.TextToolsBTN_Click);
            // 
            // ElipseToolsBTN
            // 
            this.ElipseToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ElipseToolsBTN.BackgroundImage")));
            this.ElipseToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ElipseToolsBTN.Location = new System.Drawing.Point(44, 10);
            this.ElipseToolsBTN.Name = "ElipseToolsBTN";
            this.ElipseToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.ElipseToolsBTN.TabIndex = 1;
            this.ElipseToolsBTN.UseVisualStyleBackColor = true;
            this.ElipseToolsBTN.Click += new System.EventHandler(this.ElipseToolsBTN_Click);
            // 
            // SquardToolsBTN
            // 
            this.SquardToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SquardToolsBTN.BackgroundImage")));
            this.SquardToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SquardToolsBTN.Location = new System.Drawing.Point(82, 10);
            this.SquardToolsBTN.Name = "SquardToolsBTN";
            this.SquardToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.SquardToolsBTN.TabIndex = 2;
            this.SquardToolsBTN.UseVisualStyleBackColor = true;
            this.SquardToolsBTN.Click += new System.EventHandler(this.SquardToolsBTN_Click);
            // 
            // LineToolsBTN
            // 
            this.LineToolsBTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LineToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineToolsBTN.BackgroundImage")));
            this.LineToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineToolsBTN.Location = new System.Drawing.Point(6, 10);
            this.LineToolsBTN.Name = "LineToolsBTN";
            this.LineToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.LineToolsBTN.TabIndex = 0;
            this.LineToolsBTN.UseVisualStyleBackColor = false;
            this.LineToolsBTN.Click += new System.EventHandler(this.LineToolsBTN_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.rightRBTN);
            this.ColorBox.Controls.Add(this.leftRBTN);
            this.ColorBox.Controls.Add(this.ButtonColors);
            this.ColorBox.Controls.Add(this.ColorBTN8);
            this.ColorBox.Controls.Add(this.ColorBTN4);
            this.ColorBox.Controls.Add(this.ColorBTN7);
            this.ColorBox.Controls.Add(this.ColorBTN3);
            this.ColorBox.Controls.Add(this.ColorBTN6);
            this.ColorBox.Controls.Add(this.ColorBTN2);
            this.ColorBox.Controls.Add(this.ColorBTN5);
            this.ColorBox.Controls.Add(this.ColorBTN1);
            this.ColorBox.Controls.Add(this.RightChoiceBTN);
            this.ColorBox.Controls.Add(this.leftChoiceBTN);
            this.ColorBox.Location = new System.Drawing.Point(694, 27);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(281, 69);
            this.ColorBox.TabIndex = 2;
            this.ColorBox.TabStop = false;
            // 
            // rightRBTN
            // 
            this.rightRBTN.AutoSize = true;
            this.rightRBTN.Location = new System.Drawing.Point(53, 46);
            this.rightRBTN.Name = "rightRBTN";
            this.rightRBTN.Size = new System.Drawing.Size(14, 13);
            this.rightRBTN.TabIndex = 12;
            this.rightRBTN.UseVisualStyleBackColor = true;
            // 
            // leftRBTN
            // 
            this.leftRBTN.AutoSize = true;
            this.leftRBTN.Checked = true;
            this.leftRBTN.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.leftRBTN.Location = new System.Drawing.Point(15, 45);
            this.leftRBTN.Name = "leftRBTN";
            this.leftRBTN.Size = new System.Drawing.Size(14, 13);
            this.leftRBTN.TabIndex = 11;
            this.leftRBTN.TabStop = true;
            this.leftRBTN.UseVisualStyleBackColor = true;
            // 
            // ButtonColors
            // 
            this.ButtonColors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonColors.BackgroundImage")));
            this.ButtonColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColors.Location = new System.Drawing.Point(226, 8);
            this.ButtonColors.Name = "ButtonColors";
            this.ButtonColors.Size = new System.Drawing.Size(49, 44);
            this.ButtonColors.TabIndex = 10;
            this.ButtonColors.UseVisualStyleBackColor = true;
            this.ButtonColors.Click += new System.EventHandler(this.ButtonColors_Click);
            // 
            // ColorBTN8
            // 
            this.ColorBTN8.BackColor = System.Drawing.Color.Aqua;
            this.ColorBTN8.Location = new System.Drawing.Point(185, 39);
            this.ColorBTN8.Name = "ColorBTN8";
            this.ColorBTN8.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN8.TabIndex = 9;
            this.ColorBTN8.UseVisualStyleBackColor = false;
            this.ColorBTN8.Click += new System.EventHandler(this.ColorBTN8_Click);
            // 
            // ColorBTN4
            // 
            this.ColorBTN4.BackColor = System.Drawing.Color.Blue;
            this.ColorBTN4.Location = new System.Drawing.Point(185, 8);
            this.ColorBTN4.Name = "ColorBTN4";
            this.ColorBTN4.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN4.TabIndex = 8;
            this.ColorBTN4.UseVisualStyleBackColor = false;
            this.ColorBTN4.Click += new System.EventHandler(this.ColorBTN4_Click);
            // 
            // ColorBTN7
            // 
            this.ColorBTN7.BackColor = System.Drawing.Color.Yellow;
            this.ColorBTN7.Location = new System.Drawing.Point(154, 39);
            this.ColorBTN7.Name = "ColorBTN7";
            this.ColorBTN7.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN7.TabIndex = 7;
            this.ColorBTN7.UseVisualStyleBackColor = false;
            this.ColorBTN7.Click += new System.EventHandler(this.ColorBTN7_Click);
            // 
            // ColorBTN3
            // 
            this.ColorBTN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColorBTN3.Location = new System.Drawing.Point(154, 8);
            this.ColorBTN3.Name = "ColorBTN3";
            this.ColorBTN3.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN3.TabIndex = 6;
            this.ColorBTN3.UseVisualStyleBackColor = false;
            this.ColorBTN3.Click += new System.EventHandler(this.ColorBTN3_Click);
            // 
            // ColorBTN6
            // 
            this.ColorBTN6.BackColor = System.Drawing.Color.Fuchsia;
            this.ColorBTN6.Location = new System.Drawing.Point(123, 38);
            this.ColorBTN6.Name = "ColorBTN6";
            this.ColorBTN6.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN6.TabIndex = 5;
            this.ColorBTN6.UseVisualStyleBackColor = false;
            this.ColorBTN6.Click += new System.EventHandler(this.ColorBTN6_Click);
            // 
            // ColorBTN2
            // 
            this.ColorBTN2.BackColor = System.Drawing.Color.Red;
            this.ColorBTN2.Location = new System.Drawing.Point(123, 8);
            this.ColorBTN2.Name = "ColorBTN2";
            this.ColorBTN2.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN2.TabIndex = 4;
            this.ColorBTN2.UseVisualStyleBackColor = false;
            this.ColorBTN2.Click += new System.EventHandler(this.ColorBTN2_Click);
            // 
            // ColorBTN5
            // 
            this.ColorBTN5.BackColor = System.Drawing.Color.Black;
            this.ColorBTN5.Location = new System.Drawing.Point(92, 38);
            this.ColorBTN5.Name = "ColorBTN5";
            this.ColorBTN5.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN5.TabIndex = 3;
            this.ColorBTN5.UseVisualStyleBackColor = false;
            this.ColorBTN5.Click += new System.EventHandler(this.ColorBTN5_Click);
            // 
            // ColorBTN1
            // 
            this.ColorBTN1.BackColor = System.Drawing.Color.White;
            this.ColorBTN1.Location = new System.Drawing.Point(92, 8);
            this.ColorBTN1.Name = "ColorBTN1";
            this.ColorBTN1.Size = new System.Drawing.Size(25, 25);
            this.ColorBTN1.TabIndex = 2;
            this.ColorBTN1.UseVisualStyleBackColor = false;
            this.ColorBTN1.Click += new System.EventHandler(this.ColorBTN1_Click);
            // 
            // RightChoiceBTN
            // 
            this.RightChoiceBTN.BackColor = System.Drawing.Color.White;
            this.RightChoiceBTN.ForeColor = System.Drawing.Color.Coral;
            this.RightChoiceBTN.Location = new System.Drawing.Point(44, 8);
            this.RightChoiceBTN.Name = "RightChoiceBTN";
            this.RightChoiceBTN.Size = new System.Drawing.Size(32, 32);
            this.RightChoiceBTN.TabIndex = 1;
            this.RightChoiceBTN.UseVisualStyleBackColor = false;
            // 
            // leftChoiceBTN
            // 
            this.leftChoiceBTN.BackColor = System.Drawing.Color.Black;
            this.leftChoiceBTN.Location = new System.Drawing.Point(6, 8);
            this.leftChoiceBTN.Name = "leftChoiceBTN";
            this.leftChoiceBTN.Size = new System.Drawing.Size(32, 32);
            this.leftChoiceBTN.TabIndex = 0;
            this.leftChoiceBTN.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 473);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.clickPictureBox);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Line1BTN
            // 
            this.Line1BTN.BackColor = System.Drawing.Color.NavajoWhite;
            this.Line1BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Line1BTN.BackgroundImage")));
            this.Line1BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Line1BTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line1BTN.Location = new System.Drawing.Point(0, 6);
            this.Line1BTN.Name = "Line1BTN";
            this.Line1BTN.Size = new System.Drawing.Size(164, 27);
            this.Line1BTN.TabIndex = 0;
            this.Line1BTN.UseVisualStyleBackColor = false;
            this.Line1BTN.Click += new System.EventHandler(this.Line1BTN_Click);
            // 
            // Line2BTN
            // 
            this.Line2BTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Line2BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Line2BTN.BackgroundImage")));
            this.Line2BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Line2BTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line2BTN.Location = new System.Drawing.Point(0, 32);
            this.Line2BTN.Name = "Line2BTN";
            this.Line2BTN.Size = new System.Drawing.Size(164, 27);
            this.Line2BTN.TabIndex = 1;
            this.Line2BTN.UseVisualStyleBackColor = false;
            this.Line2BTN.Click += new System.EventHandler(this.Line2BTN_Click);
            // 
            // Line3BTN
            // 
            this.Line3BTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Line3BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Line3BTN.BackgroundImage")));
            this.Line3BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Line3BTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line3BTN.Location = new System.Drawing.Point(0, 56);
            this.Line3BTN.Name = "Line3BTN";
            this.Line3BTN.Size = new System.Drawing.Size(164, 27);
            this.Line3BTN.TabIndex = 2;
            this.Line3BTN.UseVisualStyleBackColor = false;
            this.Line3BTN.Click += new System.EventHandler(this.Line3BTN_Click);
            // 
            // Line4BTN
            // 
            this.Line4BTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Line4BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Line4BTN.BackgroundImage")));
            this.Line4BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Line4BTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line4BTN.Location = new System.Drawing.Point(0, 78);
            this.Line4BTN.Name = "Line4BTN";
            this.Line4BTN.Size = new System.Drawing.Size(164, 27);
            this.Line4BTN.TabIndex = 3;
            this.Line4BTN.UseVisualStyleBackColor = false;
            this.Line4BTN.Click += new System.EventHandler(this.Line4BTN_Click);
            // 
            // LineBox
            // 
            this.LineBox.Controls.Add(this.Line2BTN);
            this.LineBox.Controls.Add(this.Line1BTN);
            this.LineBox.Controls.Add(this.Line3BTN);
            this.LineBox.Controls.Add(this.Line4BTN);
            this.LineBox.ForeColor = System.Drawing.Color.Coral;
            this.LineBox.Location = new System.Drawing.Point(280, 12);
            this.LineBox.Name = "LineBox";
            this.LineBox.Size = new System.Drawing.Size(163, 105);
            this.LineBox.TabIndex = 4;
            this.LineBox.TabStop = false;
            this.LineBox.Visible = false;
            // 
            // RubberOptionBox
            // 
            this.RubberOptionBox.Controls.Add(this.RubberPictureBox);
            this.RubberOptionBox.Controls.Add(this.RubberPlusBTN);
            this.RubberOptionBox.Controls.Add(this.RubberMinusBTN);
            this.RubberOptionBox.Location = new System.Drawing.Point(238, 18);
            this.RubberOptionBox.Name = "RubberOptionBox";
            this.RubberOptionBox.Size = new System.Drawing.Size(224, 109);
            this.RubberOptionBox.TabIndex = 4;
            this.RubberOptionBox.TabStop = false;
            this.RubberOptionBox.Visible = false;
            this.RubberOptionBox.Paint += new System.Windows.Forms.PaintEventHandler(this.RubberPictureBox_Paint);
            // 
            // RubberPictureBox
            // 
            this.RubberPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.RubberPictureBox.Location = new System.Drawing.Point(66, 15);
            this.RubberPictureBox.Name = "RubberPictureBox";
            this.RubberPictureBox.Size = new System.Drawing.Size(90, 90);
            this.RubberPictureBox.TabIndex = 5;
            this.RubberPictureBox.TabStop = false;
            // 
            // RubberPlusBTN
            // 
            this.RubberPlusBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RubberPlusBTN.BackgroundImage")));
            this.RubberPlusBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RubberPlusBTN.Location = new System.Drawing.Point(175, 35);
            this.RubberPlusBTN.Name = "RubberPlusBTN";
            this.RubberPlusBTN.Size = new System.Drawing.Size(40, 40);
            this.RubberPlusBTN.TabIndex = 1;
            this.RubberPlusBTN.UseVisualStyleBackColor = true;
            this.RubberPlusBTN.Click += new System.EventHandler(this.RubberPlusBTN_Click);
            // 
            // RubberMinusBTN
            // 
            this.RubberMinusBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RubberMinusBTN.BackgroundImage")));
            this.RubberMinusBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RubberMinusBTN.Location = new System.Drawing.Point(6, 35);
            this.RubberMinusBTN.Name = "RubberMinusBTN";
            this.RubberMinusBTN.Size = new System.Drawing.Size(40, 40);
            this.RubberMinusBTN.TabIndex = 0;
            this.RubberMinusBTN.UseVisualStyleBackColor = true;
            this.RubberMinusBTN.Click += new System.EventHandler(this.RubberMinusBTN_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(975, 609);
            this.Controls.Add(this.RubberOptionBox);
            this.Controls.Add(this.LineBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.groupBoxForTools);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "Form1";
            this.Text = "Mini paint";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxForTools.ResumeLayout(false);
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LineBox.ResumeLayout(false);
            this.RubberOptionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RubberPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private int NonSerialazible()
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton MenuFile;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MenuUndo;
        private System.Windows.Forms.ToolStripButton DeserialBTN;
        private System.Windows.Forms.GroupBox groupBoxForTools;
        private System.Windows.Forms.Button TextToolsBTN;
        private System.Windows.Forms.Button RubberToolsBTN;
        private System.Windows.Forms.Button FillToolsBTN;
        private System.Windows.Forms.Button ElipseToolsBTN;
        private System.Windows.Forms.Button SquardToolsBTN;
        private System.Windows.Forms.Button LineToolsBTN;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.Button leftChoiceBTN;
        private System.Windows.Forms.Button ColorBTN1;
        private System.Windows.Forms.Button RightChoiceBTN;
        private System.Windows.Forms.Button ColorBTN8;
        private System.Windows.Forms.Button ColorBTN4;
        private System.Windows.Forms.Button ColorBTN7;
        private System.Windows.Forms.Button ColorBTN3;
        private System.Windows.Forms.Button ColorBTN6;
        private System.Windows.Forms.Button ColorBTN2;
        private System.Windows.Forms.Button ColorBTN5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonColors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button WidthLineBTN;
        private System.Windows.Forms.RadioButton leftRBTN;
        private System.Windows.Forms.RadioButton rightRBTN;
        private Buffer buffer;
        private System.Windows.Forms.Button Line1BTN;
        private System.Windows.Forms.Button Line2BTN;
        private System.Windows.Forms.Button Line3BTN;
        private System.Windows.Forms.Button Line4BTN;
        private System.Windows.Forms.GroupBox LineBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox RubberOptionBox;
        private System.Windows.Forms.PictureBox RubberPictureBox;
        private System.Windows.Forms.Button RubberMinusBTN;
        private System.Windows.Forms.Button RubberPlusBTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem процессToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem процессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SerialBTN;
        private System.Windows.Forms.ToolStripButton RedoBTN;
    }
}

