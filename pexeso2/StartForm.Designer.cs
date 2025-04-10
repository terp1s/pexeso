namespace pexeso2
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            start_btn = new Button();
            SuspendLayout();
            // 
            // start_btn
            // 
            start_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            start_btn.BackColor = Color.Transparent;
            start_btn.BackgroundImage = (Image)resources.GetObject("start_btn.BackgroundImage");
            start_btn.BackgroundImageLayout = ImageLayout.Stretch;
            start_btn.FlatAppearance.BorderSize = 0;
            start_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            start_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            start_btn.FlatStyle = FlatStyle.Flat;
            start_btn.ForeColor = Color.Transparent;
            start_btn.Location = new Point(503, 243);
            start_btn.Margin = new Padding(0);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(241, 166);
            start_btn.TabIndex = 0;
            start_btn.UseVisualStyleBackColor = false;
            start_btn.Click += start_btn_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(start_btn);
            Name = "StartForm";
            Text = "Pexeso";
            WindowState = FormWindowState.Maximized;
            Resize += StartForm_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button start_btn;
    }
}