namespace Editor_de_Texto
{
    partial class frmEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            menuEditor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            rtbEditor = new RichTextBox();
            saveFileDialogEditor = new SaveFileDialog();
            openFileDialogEditor = new OpenFileDialog();
            menuEditor.SuspendLayout();
            SuspendLayout();
            // 
            // menuEditor
            // 
            menuEditor.ImageScalingSize = new Size(20, 20);
            menuEditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuEditor.Location = new Point(0, 0);
            menuEditor.Name = "menuEditor";
            menuEditor.Size = new Size(800, 28);
            menuEditor.TabIndex = 0;
            menuEditor.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(187, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(187, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(187, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(187, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(187, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // rtbEditor
            // 
            rtbEditor.Dock = DockStyle.Fill;
            rtbEditor.Location = new Point(0, 28);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 422);
            rtbEditor.TabIndex = 1;
            rtbEditor.Text = "";
            rtbEditor.TextChanged += rtbEditor_TextChanged;
            // 
            // saveFileDialogEditor
            // 
            saveFileDialogEditor.Filter = "Archivo de Texto|*.txt";
            // 
            // openFileDialogEditor
            // 
            openFileDialogEditor.FileName = "openFileDialog1";
            openFileDialogEditor.Filter = "Archivo de Texto|*.txt";
            openFileDialogEditor.FileOk += openFileDialogEditor_FileOk;
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbEditor);
            Controls.Add(menuEditor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuEditor;
            Name = "frmEditor";
            Text = "Editor de Texto";
            Load += Form1_Load;
            menuEditor.ResumeLayout(false);
            menuEditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuEditor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private RichTextBox rtbEditor;
        private SaveFileDialog saveFileDialogEditor;
        private OpenFileDialog openFileDialogEditor;
    }
}
