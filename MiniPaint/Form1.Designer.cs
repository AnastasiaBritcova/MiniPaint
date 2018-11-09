﻿using System.Drawing;

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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUndo = new System.Windows.Forms.ToolStripButton();
            this.MenuDo = new System.Windows.Forms.ToolStripButton();
            this.MenuCopy = new System.Windows.Forms.ToolStripButton();
            this.MenuPaste = new System.Windows.Forms.ToolStripButton();
            this.groupBoxForTools = new System.Windows.Forms.GroupBox();
            this.WeihtLineBTN = new System.Windows.Forms.Button();
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
            this.toolStripMenu.SuspendLayout();
            this.groupBoxForTools.SuspendLayout();
            this.ColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuUndo,
            this.MenuDo,
            this.MenuCopy,
            this.MenuPaste});
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
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(33, 24);
            this.MenuFile.Text = "toolStripDropDownButton1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
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
            // MenuDo
            // 
            this.MenuDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuDo.Enabled = false;
            this.MenuDo.Image = ((System.Drawing.Image)(resources.GetObject("MenuDo.Image")));
            this.MenuDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuDo.Name = "MenuDo";
            this.MenuDo.Size = new System.Drawing.Size(24, 24);
            this.MenuDo.Text = "Вернуть";
            this.MenuDo.Click += new System.EventHandler(this.MenuDo_Click);
            // 
            // MenuCopy
            // 
            this.MenuCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuCopy.Image = ((System.Drawing.Image)(resources.GetObject("MenuCopy.Image")));
            this.MenuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.Size = new System.Drawing.Size(24, 24);
            this.MenuCopy.Text = "toolStripButton1";
            // 
            // MenuPaste
            // 
            this.MenuPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuPaste.Image = ((System.Drawing.Image)(resources.GetObject("MenuPaste.Image")));
            this.MenuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuPaste.Name = "MenuPaste";
            this.MenuPaste.Size = new System.Drawing.Size(24, 24);
            this.MenuPaste.Text = "toolStripButton1";
            // 
            // groupBoxForTools
            // 
            this.groupBoxForTools.Controls.Add(this.WeihtLineBTN);
            this.groupBoxForTools.Controls.Add(this.RubberToolsBTN);
            this.groupBoxForTools.Controls.Add(this.FillToolsBTN);
            this.groupBoxForTools.Controls.Add(this.TextToolsBTN);
            this.groupBoxForTools.Controls.Add(this.ElipseToolsBTN);
            this.groupBoxForTools.Controls.Add(this.SquardToolsBTN);
            this.groupBoxForTools.Controls.Add(this.LineToolsBTN);
            this.groupBoxForTools.Location = new System.Drawing.Point(501, 18);
            this.groupBoxForTools.Name = "groupBoxForTools";
            this.groupBoxForTools.Size = new System.Drawing.Size(187, 79);
            this.groupBoxForTools.TabIndex = 1;
            this.groupBoxForTools.TabStop = false;
            // 
            // WeihtLineBTN
            // 
            this.WeihtLineBTN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WeihtLineBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WeihtLineBTN.BackgroundImage")));
            this.WeihtLineBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeihtLineBTN.Location = new System.Drawing.Point(114, 10);
            this.WeihtLineBTN.Name = "WeihtLineBTN";
            this.WeihtLineBTN.Size = new System.Drawing.Size(73, 69);
            this.WeihtLineBTN.TabIndex = 6;
            this.WeihtLineBTN.UseVisualStyleBackColor = false;
            // 
            // RubberToolsBTN
            // 
            this.RubberToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RubberToolsBTN.BackgroundImage")));
            this.RubberToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RubberToolsBTN.Location = new System.Drawing.Point(76, 47);
            this.RubberToolsBTN.Name = "RubberToolsBTN";
            this.RubberToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.RubberToolsBTN.TabIndex = 5;
            this.RubberToolsBTN.UseVisualStyleBackColor = true;
            // 
            // FillToolsBTN
            // 
            this.FillToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FillToolsBTN.BackgroundImage")));
            this.FillToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillToolsBTN.Location = new System.Drawing.Point(38, 47);
            this.FillToolsBTN.Name = "FillToolsBTN";
            this.FillToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.FillToolsBTN.TabIndex = 4;
            this.FillToolsBTN.UseVisualStyleBackColor = true;
            // 
            // TextToolsBTN
            // 
            this.TextToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextToolsBTN.BackgroundImage")));
            this.TextToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TextToolsBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextToolsBTN.Location = new System.Drawing.Point(0, 48);
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
            this.ElipseToolsBTN.Location = new System.Drawing.Point(38, 10);
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
            this.SquardToolsBTN.Location = new System.Drawing.Point(76, 10);
            this.SquardToolsBTN.Name = "SquardToolsBTN";
            this.SquardToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.SquardToolsBTN.TabIndex = 2;
            this.SquardToolsBTN.UseVisualStyleBackColor = true;
            this.SquardToolsBTN.Click += new System.EventHandler(this.SquardToolsBTN_Click);
            // 
            // LineToolsBTN
            // 
            this.LineToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineToolsBTN.BackgroundImage")));
            this.LineToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineToolsBTN.Location = new System.Drawing.Point(0, 10);
            this.LineToolsBTN.Name = "LineToolsBTN";
            this.LineToolsBTN.Size = new System.Drawing.Size(32, 32);
            this.LineToolsBTN.TabIndex = 0;
            this.LineToolsBTN.UseVisualStyleBackColor = true;
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
            this.rightRBTN.TabStop = true;
            this.rightRBTN.UseVisualStyleBackColor = true;
            this.rightRBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // leftRBTN
            // 
            this.leftRBTN.AutoSize = true;
            this.leftRBTN.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.leftRBTN.Location = new System.Drawing.Point(15, 46);
            this.leftRBTN.Name = "leftRBTN";
            this.leftRBTN.Size = new System.Drawing.Size(14, 13);
            this.leftRBTN.TabIndex = 11;
            this.leftRBTN.TabStop = true;
            this.leftRBTN.UseVisualStyleBackColor = true;
            this.leftRBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.leftChoiceBTN.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(975, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.groupBoxForTools);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "Form1";
            this.Text = "Mini paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxForTools.ResumeLayout(false);
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton MenuFile;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MenuUndo;
        private System.Windows.Forms.ToolStripButton MenuDo;
        private System.Windows.Forms.ToolStripButton MenuCopy;
        private System.Windows.Forms.ToolStripButton MenuPaste;
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
        private System.Windows.Forms.Button WeihtLineBTN;
        private System.Windows.Forms.RadioButton leftRBTN;
        private System.Windows.Forms.RadioButton rightRBTN;
        private Buffer buffer;
    }
}

