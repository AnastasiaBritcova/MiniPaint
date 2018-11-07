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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuUndo,
            this.MenuDo,
            this.MenuCopy,
            this.MenuPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.MenuFile.Size = new System.Drawing.Size(29, 22);
            this.MenuFile.Text = "toolStripDropDownButton1";
            this.MenuFile.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
            this.MenuUndo.Image = ((System.Drawing.Image)(resources.GetObject("MenuUndo.Image")));
            this.MenuUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuUndo.Name = "MenuUndo";
            this.MenuUndo.Size = new System.Drawing.Size(23, 22);
            this.MenuUndo.Text = "toolStripButton1";
            // 
            // MenuDo
            // 
            this.MenuDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuDo.Image = ((System.Drawing.Image)(resources.GetObject("MenuDo.Image")));
            this.MenuDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuDo.Name = "MenuDo";
            this.MenuDo.Size = new System.Drawing.Size(23, 22);
            this.MenuDo.Text = "toolStripButton1";
            // 
            // MenuCopy
            // 
            this.MenuCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuCopy.Image = ((System.Drawing.Image)(resources.GetObject("MenuCopy.Image")));
            this.MenuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.Size = new System.Drawing.Size(23, 22);
            this.MenuCopy.Text = "toolStripButton1";
            // 
            // MenuPaste
            // 
            this.MenuPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuPaste.Image = ((System.Drawing.Image)(resources.GetObject("MenuPaste.Image")));
            this.MenuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuPaste.Name = "MenuPaste";
            this.MenuPaste.Size = new System.Drawing.Size(23, 22);
            this.MenuPaste.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 612);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
    }
}

