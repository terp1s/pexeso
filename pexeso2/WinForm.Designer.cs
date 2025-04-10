namespace pexeso2
{
    partial class WinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            hura = new PictureBox();
            dalsiHra = new PictureBox();
            ano = new PictureBox();
            ne = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dalsiHra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ne).BeginInit();
            SuspendLayout();
            // 
            // hura
            // 
            hura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hura.BackColor = Color.Transparent;
            hura.BackgroundImage = (Image)resources.GetObject("hura.BackgroundImage");
            hura.BackgroundImageLayout = ImageLayout.Zoom;
            hura.Location = new Point(102, 55);
            hura.Margin = new Padding(0);
            hura.Name = "hura";
            hura.Size = new Size(606, 156);
            hura.TabIndex = 0;
            hura.TabStop = false;
            // 
            // dalsiHra
            // 
            dalsiHra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dalsiHra.BackColor = Color.Transparent;
            dalsiHra.BackgroundImage = (Image)resources.GetObject("dalsiHra.BackgroundImage");
            dalsiHra.BackgroundImageLayout = ImageLayout.Zoom;
            dalsiHra.Location = new Point(192, 217);
            dalsiHra.Name = "dalsiHra";
            dalsiHra.Size = new Size(423, 66);
            dalsiHra.TabIndex = 1;
            dalsiHra.TabStop = false;
            // 
            // ano
            // 
            ano.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ano.BackColor = Color.Transparent;
            ano.BackgroundImage = (Image)resources.GetObject("ano.BackgroundImage");
            ano.BackgroundImageLayout = ImageLayout.Zoom;
            ano.Location = new Point(63, 336);
            ano.Name = "ano";
            ano.Size = new Size(219, 49);
            ano.TabIndex = 2;
            ano.TabStop = false;
            ano.Click += ano_Click;
            // 
            // ne
            // 
            ne.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ne.BackColor = Color.Transparent;
            ne.BackgroundImage = (Image)resources.GetObject("ne.BackgroundImage");
            ne.BackgroundImageLayout = ImageLayout.Zoom;
            ne.Location = new Point(523, 323);
            ne.Margin = new Padding(0);
            ne.Name = "ne";
            ne.Size = new Size(216, 62);
            ne.TabIndex = 3;
            ne.TabStop = false;
            ne.Click += ne_Click;
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ne);
            Controls.Add(ano);
            Controls.Add(dalsiHra);
            Controls.Add(hura);
            Name = "WinForm";
            Text = "WinForm";
            WindowState = FormWindowState.Maximized;
            Resize += WinForm_Resize;
            ((System.ComponentModel.ISupportInitialize)hura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dalsiHra).EndInit();
            ((System.ComponentModel.ISupportInitialize)ano).EndInit();
            ((System.ComponentModel.ISupportInitialize)ne).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox hura;
        private PictureBox dalsiHra;
        private PictureBox ano;
        private PictureBox ne;
    }
}