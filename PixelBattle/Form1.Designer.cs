namespace PixelBattle
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
            this.components = new System.ComponentModel.Container();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ColorsConverter = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PercentageScale = new System.Windows.Forms.NumericUpDown();
            this.RewriteButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Scales = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentageScale)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBox.InitialImage = null;
            this.PicBox.Location = new System.Drawing.Point(2, 25);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(500, 403);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ColorsConverter
            // 
            this.ColorsConverter.Location = new System.Drawing.Point(314, 434);
            this.ColorsConverter.Name = "ColorsConverter";
            this.ColorsConverter.Size = new System.Drawing.Size(89, 23);
            this.ColorsConverter.TabIndex = 1;
            this.ColorsConverter.Text = "Apply coloring";
            this.ColorsConverter.UseVisualStyleBackColor = true;
            this.ColorsConverter.Click += new System.EventHandler(this.ColorsConverter_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 434);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(89, 23);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Rescale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // PercentageScale
            // 
            this.PercentageScale.Location = new System.Drawing.Point(107, 437);
            this.PercentageScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PercentageScale.Name = "PercentageScale";
            this.PercentageScale.Size = new System.Drawing.Size(120, 20);
            this.PercentageScale.TabIndex = 4;
            this.PercentageScale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RewriteButton
            // 
            this.RewriteButton.Location = new System.Drawing.Point(409, 434);
            this.RewriteButton.Name = "RewriteButton";
            this.RewriteButton.Size = new System.Drawing.Size(89, 23);
            this.RewriteButton.TabIndex = 5;
            this.RewriteButton.Text = "Rewrite";
            this.RewriteButton.UseVisualStyleBackColor = true;
            this.RewriteButton.Click += new System.EventHandler(this.RewriteButton_Click);
            // 
            // Scales
            // 
            this.Scales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scales.FormattingEnabled = true;
            this.Scales.Location = new System.Drawing.Point(2, 2);
            this.Scales.Name = "Scales";
            this.Scales.Size = new System.Drawing.Size(500, 17);
            this.Scales.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(507, 462);
            this.Controls.Add(this.Scales);
            this.Controls.Add(this.RewriteButton);
            this.Controls.Add(this.PercentageScale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.ColorsConverter);
            this.Controls.Add(this.PicBox);
            this.Name = "Form1";
            this.Text = "PixelBattle image converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentageScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ColorsConverter;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown PercentageScale;
        private System.Windows.Forms.Button RewriteButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.ListBox Scales;
    }
}

