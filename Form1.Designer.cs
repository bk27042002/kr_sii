
namespace kr_sii
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.textBoxPsi = new System.Windows.Forms.TextBox();
            this.textBoxTeta = new System.Windows.Forms.TextBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.labelPsi = new System.Windows.Forms.Label();
            this.labelTeta = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.chartImage = new System.Windows.Forms.PictureBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelBayes = new System.Windows.Forms.Label();
            this.textBoxBayes = new System.Windows.Forms.TextBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.textBoxShortliff = new System.Windows.Forms.TextBox();
            this.labelShortliff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(13, 435);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(114, 34);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // textBoxPsi
            // 
            this.textBoxPsi.Location = new System.Drawing.Point(494, 382);
            this.textBoxPsi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPsi.Name = "textBoxPsi";
            this.textBoxPsi.Size = new System.Drawing.Size(89, 23);
            this.textBoxPsi.TabIndex = 5;
            // 
            // textBoxTeta
            // 
            this.textBoxTeta.Location = new System.Drawing.Point(494, 351);
            this.textBoxTeta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeta.Name = "textBoxTeta";
            this.textBoxTeta.Size = new System.Drawing.Size(89, 23);
            this.textBoxTeta.TabIndex = 4;
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(494, 320);
            this.textBoxAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(89, 23);
            this.textBoxAngle.TabIndex = 3;
            // 
            // labelPsi
            // 
            this.labelPsi.AutoSize = true;
            this.labelPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPsi.Location = new System.Drawing.Point(440, 385);
            this.labelPsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPsi.Name = "labelPsi";
            this.labelPsi.Size = new System.Drawing.Size(37, 17);
            this.labelPsi.TabIndex = 2;
            this.labelPsi.Text = "Пси:";
            // 
            // labelTeta
            // 
            this.labelTeta.AutoSize = true;
            this.labelTeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTeta.Location = new System.Drawing.Point(432, 354);
            this.labelTeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeta.Name = "labelTeta";
            this.labelTeta.Size = new System.Drawing.Size(44, 17);
            this.labelTeta.TabIndex = 1;
            this.labelTeta.Text = "Тета:";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAngle.Location = new System.Drawing.Point(433, 323);
            this.labelAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(42, 17);
            this.labelAngle.TabIndex = 0;
            this.labelAngle.Text = "Угол:";
            // 
            // chartImage
            // 
            this.chartImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartImage.Image = global::kr_sii.Properties.Resources.Image;
            this.chartImage.Location = new System.Drawing.Point(13, 13);
            this.chartImage.Margin = new System.Windows.Forms.Padding(4);
            this.chartImage.Name = "chartImage";
            this.chartImage.Size = new System.Drawing.Size(570, 299);
            this.chartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chartImage.TabIndex = 0;
            this.chartImage.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 323);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(79, 17);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Тип качки:";
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxType.Location = new System.Drawing.Point(115, 320);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(194, 23);
            this.textBoxType.TabIndex = 13;
            // 
            // labelBayes
            // 
            this.labelBayes.AutoSize = true;
            this.labelBayes.Location = new System.Drawing.Point(12, 355);
            this.labelBayes.Name = "labelBayes";
            this.labelBayes.Size = new System.Drawing.Size(52, 17);
            this.labelBayes.TabIndex = 14;
            this.labelBayes.Text = "Байес:";
            // 
            // textBoxBayes
            // 
            this.textBoxBayes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBayes.Location = new System.Drawing.Point(83, 352);
            this.textBoxBayes.Name = "textBoxBayes";
            this.textBoxBayes.Size = new System.Drawing.Size(113, 23);
            this.textBoxBayes.TabIndex = 15;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxColor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxColor.Location = new System.Drawing.Point(316, 323);
            this.pictureBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(21, 20);
            this.pictureBoxColor.TabIndex = 16;
            this.pictureBoxColor.TabStop = false;
            // 
            // textBoxShortliff
            // 
            this.textBoxShortliff.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxShortliff.Location = new System.Drawing.Point(128, 384);
            this.textBoxShortliff.Name = "textBoxShortliff";
            this.textBoxShortliff.Size = new System.Drawing.Size(113, 23);
            this.textBoxShortliff.TabIndex = 18;
            // 
            // labelShortliff
            // 
            this.labelShortliff.AutoSize = true;
            this.labelShortliff.Location = new System.Drawing.Point(12, 387);
            this.labelShortliff.Name = "labelShortliff";
            this.labelShortliff.Size = new System.Drawing.Size(84, 17);
            this.labelShortliff.TabIndex = 17;
            this.labelShortliff.Text = "Шортлифф:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(596, 482);
            this.Controls.Add(this.textBoxShortliff);
            this.Controls.Add(this.labelShortliff);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.textBoxBayes);
            this.Controls.Add(this.labelBayes);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.textBoxPsi);
            this.Controls.Add(this.textBoxTeta);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.labelPsi);
            this.Controls.Add(this.labelTeta);
            this.Controls.Add(this.chartImage);
            this.Controls.Add(this.labelAngle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(612, 470);
            this.Name = "Form1";
            this.Text = "Программа";
            ((System.ComponentModel.ISupportInitialize)(this.chartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chartImage;
        private System.Windows.Forms.Label labelPsi;
        private System.Windows.Forms.Label labelTeta;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.TextBox textBoxPsi;
        private System.Windows.Forms.TextBox textBoxTeta;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelBayes;
        private System.Windows.Forms.TextBox textBoxBayes;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.TextBox textBoxShortliff;
        private System.Windows.Forms.Label labelShortliff;
    }
}

