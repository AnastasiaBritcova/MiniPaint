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
            this.toolStripMenu.Size = new System.Drawing.Size(1300, 27);
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
            this.MenuFile.Size = new System.Drawing.Size(34, 24);
            this.MenuFile.Text = "toolStripDropDownButton1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
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
            this.groupBoxForTools.Location = new System.Drawing.Point(668, 22);
            this.groupBoxForTools.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxForTools.Name = "groupBoxForTools";
            this.groupBoxForTools.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxForTools.Size = new System.Drawing.Size(249, 97);
            this.groupBoxForTools.TabIndex = 1;
            this.groupBoxForTools.TabStop = false;
            // 
            // WeihtLineBTN
            // 
            this.WeihtLineBTN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WeihtLineBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WeihtLineBTN.BackgroundImage")));
            this.WeihtLineBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeihtLineBTN.Location = new System.Drawing.Point(152, 12);
            this.WeihtLineBTN.Margin = new System.Windows.Forms.Padding(4);
            this.WeihtLineBTN.Name = "WeihtLineBTN";
            this.WeihtLineBTN.Size = new System.Drawing.Size(97, 85);
            this.WeihtLineBTN.TabIndex = 6;
            this.WeihtLineBTN.UseVisualStyleBackColor = false;
            // 
            // RubberToolsBTN
            // 
            this.RubberToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RubberToolsBTN.BackgroundImage")));
            this.RubberToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RubberToolsBTN.Location = new System.Drawing.Point(101, 58);
            this.RubberToolsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.RubberToolsBTN.Name = "RubberToolsBTN";
            this.RubberToolsBTN.Size = new System.Drawing.Size(43, 39);
            this.RubberToolsBTN.TabIndex = 5;
            this.RubberToolsBTN.UseVisualStyleBackColor = true;
            // 
            // FillToolsBTN
            // 
            this.FillToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FillToolsBTN.BackgroundImage")));
            this.FillToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillToolsBTN.Location = new System.Drawing.Point(51, 58);
            this.FillToolsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.FillToolsBTN.Name = "FillToolsBTN";
            this.FillToolsBTN.Size = new System.Drawing.Size(43, 39);
            this.FillToolsBTN.TabIndex = 4;
            this.FillToolsBTN.UseVisualStyleBackColor = true;
            // 
            // TextToolsBTN
            // 
            this.TextToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextToolsBTN.BackgroundImage")));
            this.TextToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TextToolsBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextToolsBTN.Location = new System.Drawing.Point(0, 58);
            this.TextToolsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.TextToolsBTN.Name = "TextToolsBTN";
            this.TextToolsBTN.Size = new System.Drawing.Size(43, 39);
            this.TextToolsBTN.TabIndex = 0;
            this.TextToolsBTN.UseVisualStyleBackColor = true;
            // 
            // ElipseToolsBTN
            // 
            this.ElipseToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ElipseToolsBTN.BackgroundImage")));
            this.ElipseToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ElipseToolsBTN.Location = new System.Drawing.Point(0, 11);
            this.ElipseToolsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ElipseToolsBTN.Name = "ElipseToolsBTN";
            this.ElipseToolsBTN.Size = new System.Drawing.Size(43, 39);
            this.ElipseToolsBTN.TabIndex = 3;
            this.ElipseToolsBTN.UseVisualStyleBackColor = true;
            // 
            // SquardToolsBTN
            // 
            this.SquardToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SquardToolsBTN.BackgroundImage")));
            this.SquardToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SquardToolsBTN.Location = new System.Drawing.Point(101, 11);
            this.SquardToolsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SquardToolsBTN.Name = "SquardToolsBTN";
            this.SquardToolsBTN.Size = new System.Drawing.Size(43, 39);
            this.SquardToolsBTN.TabIndex = 2;
            this.SquardToolsBTN.UseVisualStyleBackColor = true;
            // 
            // LineToolsBTN
            // 
            this.LineToolsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineToolsBTN.BackgroundImage")));
            this.LineToolsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineToolsBTN.Location = new System.Drawing.Point(51, 11);
            this.LineToolsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LineToolsBTN.Name = "LineToolsBTN";
            this.LineToolsBTN.Size = new System.Drawing.Size(43, 39);
            this.LineToolsBTN.TabIndex = 1;
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
            this.ColorBox.Location = new System.Drawing.Point(925, 33);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Padding = new System.Windows.Forms.Padding(4);
            this.ColorBox.Size = new System.Drawing.Size(375, 85);
            this.ColorBox.TabIndex = 2;
            this.ColorBox.TabStop = false;
            // 
            // rightRBTN
            // 
            this.rightRBTN.AutoSize = true;
            this.rightRBTN.Location = new System.Drawing.Point(71, 57);
            this.rightRBTN.Margin = new System.Windows.Forms.Padding(4);
            this.rightRBTN.Name = "rightRBTN";
            this.rightRBTN.Size = new System.Drawing.Size(17, 16);
            this.rightRBTN.TabIndex = 12;
            this.rightRBTN.TabStop = true;
            this.rightRBTN.UseVisualStyleBackColor = true;
            this.rightRBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // leftRBTN
            // 
            this.leftRBTN.AutoSize = true;
            this.leftRBTN.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.leftRBTN.Location = new System.Drawing.Point(20, 57);
            this.leftRBTN.Margin = new System.Windows.Forms.Padding(4);
            this.leftRBTN.Name = "leftRBTN";
            this.leftRBTN.Size = new System.Drawing.Size(17, 16);
            this.leftRBTN.TabIndex = 11;
            this.leftRBTN.TabStop = true;
            this.leftRBTN.UseVisualStyleBackColor = true;
            this.leftRBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ButtonColors
            // 
            this.ButtonColors.Location = new System.Drawing.Point(301, 10);
            this.ButtonColors.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonColors.Name = "ButtonColors";
            this.ButtonColors.Size = new System.Drawing.Size(65, 54);
            this.ButtonColors.TabIndex = 10;
            this.ButtonColors.Text = "Colors";
            this.ButtonColors.UseVisualStyleBackColor = true;
            this.ButtonColors.Click += new System.EventHandler(this.ButtonColors_Click);
            // 
            // ColorBTN8
            // 
            this.ColorBTN8.BackColor = System.Drawing.Color.Aqua;
            this.ColorBTN8.Location = new System.Drawing.Point(247, 48);
            this.ColorBTN8.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN8.Name = "ColorBTN8";
            this.ColorBTN8.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN8.TabIndex = 9;
            this.ColorBTN8.UseVisualStyleBackColor = false;
            // 
            // ColorBTN4
            // 
            this.ColorBTN4.BackColor = System.Drawing.Color.Blue;
            this.ColorBTN4.Location = new System.Drawing.Point(247, 10);
            this.ColorBTN4.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN4.Name = "ColorBTN4";
            this.ColorBTN4.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN4.TabIndex = 8;
            this.ColorBTN4.UseVisualStyleBackColor = false;
            // 
            // ColorBTN7
            // 
            this.ColorBTN7.BackColor = System.Drawing.Color.Yellow;
            this.ColorBTN7.Location = new System.Drawing.Point(205, 48);
            this.ColorBTN7.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN7.Name = "ColorBTN7";
            this.ColorBTN7.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN7.TabIndex = 7;
            this.ColorBTN7.UseVisualStyleBackColor = false;
            // 
            // ColorBTN3
            // 
            this.ColorBTN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColorBTN3.Location = new System.Drawing.Point(205, 10);
            this.ColorBTN3.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN3.Name = "ColorBTN3";
            this.ColorBTN3.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN3.TabIndex = 6;
            this.ColorBTN3.UseVisualStyleBackColor = false;
            // 
            // ColorBTN6
            // 
            this.ColorBTN6.BackColor = System.Drawing.Color.Fuchsia;
            this.ColorBTN6.Location = new System.Drawing.Point(164, 47);
            this.ColorBTN6.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN6.Name = "ColorBTN6";
            this.ColorBTN6.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN6.TabIndex = 5;
            this.ColorBTN6.UseVisualStyleBackColor = false;
            // 
            // ColorBTN2
            // 
            this.ColorBTN2.BackColor = System.Drawing.Color.Red;
            this.ColorBTN2.Location = new System.Drawing.Point(164, 10);
            this.ColorBTN2.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN2.Name = "ColorBTN2";
            this.ColorBTN2.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN2.TabIndex = 4;
            this.ColorBTN2.UseVisualStyleBackColor = false;
            // 
            // ColorBTN5
            // 
            this.ColorBTN5.BackColor = System.Drawing.Color.Black;
            this.ColorBTN5.Location = new System.Drawing.Point(123, 47);
            this.ColorBTN5.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN5.Name = "ColorBTN5";
            this.ColorBTN5.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN5.TabIndex = 3;
            this.ColorBTN5.UseVisualStyleBackColor = false;
            // 
            // ColorBTN1
            // 
            this.ColorBTN1.BackColor = System.Drawing.Color.White;
            this.ColorBTN1.Location = new System.Drawing.Point(123, 10);
            this.ColorBTN1.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBTN1.Name = "ColorBTN1";
            this.ColorBTN1.Size = new System.Drawing.Size(33, 31);
            this.ColorBTN1.TabIndex = 2;
            this.ColorBTN1.UseVisualStyleBackColor = false;
            this.ColorBTN1.Click += new System.EventHandler(this.ColorBTN1_Click);
            // 
            // RightChoiceBTN
            // 
            this.RightChoiceBTN.BackColor = System.Drawing.Color.Lime;
            this.RightChoiceBTN.Location = new System.Drawing.Point(59, 10);
            this.RightChoiceBTN.Margin = new System.Windows.Forms.Padding(4);
            this.RightChoiceBTN.Name = "RightChoiceBTN";
            this.RightChoiceBTN.Size = new System.Drawing.Size(43, 39);
            this.RightChoiceBTN.TabIndex = 1;
            this.RightChoiceBTN.UseVisualStyleBackColor = false;
            // 
            // leftChoiceBTN
            // 
            this.leftChoiceBTN.BackColor = System.Drawing.Color.Red;
            this.leftChoiceBTN.Location = new System.Drawing.Point(8, 10);
            this.leftChoiceBTN.Margin = new System.Windows.Forms.Padding(4);
            this.leftChoiceBTN.Name = "leftChoiceBTN";
            this.leftChoiceBTN.Size = new System.Drawing.Size(43, 39);
            this.leftChoiceBTN.TabIndex = 0;
            this.leftChoiceBTN.UseVisualStyleBackColor = false;
            this.leftChoiceBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1131, 582);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.groupBoxForTools);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mini paint";
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

