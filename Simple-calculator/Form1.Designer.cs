namespace Simple_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.equals_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.positive_button = new System.Windows.Forms.Button();
            this.negative_button = new System.Windows.Forms.Button();
            this.star_button = new System.Windows.Forms.Button();
            this.backslash_button = new System.Windows.Forms.Button();
            this.number_0_button = new System.Windows.Forms.Button();
            this.number_3_button = new System.Windows.Forms.Button();
            this.number_2_button = new System.Windows.Forms.Button();
            this.number_1_button = new System.Windows.Forms.Button();
            this.number_6_button = new System.Windows.Forms.Button();
            this.number_5_button = new System.Windows.Forms.Button();
            this.number_4_button = new System.Windows.Forms.Button();
            this.number_9_button = new System.Windows.Forms.Button();
            this.number_8_button = new System.Windows.Forms.Button();
            this.number_7_button = new System.Windows.Forms.Button();
            this.screen_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equals_button
            // 
            this.equals_button.BackColor = System.Drawing.Color.DimGray;
            this.equals_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.equals_button.Location = new System.Drawing.Point(366, 345);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(80, 175);
            this.equals_button.TabIndex = 66;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = false;
            this.equals_button.Click += new System.EventHandler(this.equals_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DimGray;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear_button.Location = new System.Drawing.Point(366, 154);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(80, 175);
            this.clear_button.TabIndex = 65;
            this.clear_button.Text = "C";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // positive_button
            // 
            this.positive_button.BackColor = System.Drawing.Color.DimGray;
            this.positive_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.positive_button.Location = new System.Drawing.Point(280, 440);
            this.positive_button.Name = "positive_button";
            this.positive_button.Size = new System.Drawing.Size(80, 80);
            this.positive_button.TabIndex = 64;
            this.positive_button.Text = "+";
            this.positive_button.UseVisualStyleBackColor = false;
            this.positive_button.Click += new System.EventHandler(this.positive_button_Click);
            // 
            // negative_button
            // 
            this.negative_button.BackColor = System.Drawing.Color.DimGray;
            this.negative_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.negative_button.Location = new System.Drawing.Point(280, 345);
            this.negative_button.Name = "negative_button";
            this.negative_button.Size = new System.Drawing.Size(80, 80);
            this.negative_button.TabIndex = 63;
            this.negative_button.Text = "-";
            this.negative_button.UseVisualStyleBackColor = false;
            this.negative_button.Click += new System.EventHandler(this.negative_button_Click);
            // 
            // star_button
            // 
            this.star_button.BackColor = System.Drawing.Color.DimGray;
            this.star_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.star_button.Location = new System.Drawing.Point(280, 249);
            this.star_button.Name = "star_button";
            this.star_button.Size = new System.Drawing.Size(80, 80);
            this.star_button.TabIndex = 62;
            this.star_button.Text = "*";
            this.star_button.UseVisualStyleBackColor = false;
            this.star_button.Click += new System.EventHandler(this.star_button_Click);
            // 
            // backslash_button
            // 
            this.backslash_button.BackColor = System.Drawing.Color.DimGray;
            this.backslash_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backslash_button.Location = new System.Drawing.Point(280, 154);
            this.backslash_button.Name = "backslash_button";
            this.backslash_button.Size = new System.Drawing.Size(80, 80);
            this.backslash_button.TabIndex = 61;
            this.backslash_button.Text = "/";
            this.backslash_button.UseVisualStyleBackColor = false;
            this.backslash_button.Click += new System.EventHandler(this.backslash_button_Click);
            // 
            // number_0_button
            // 
            this.number_0_button.BackColor = System.Drawing.Color.DimGray;
            this.number_0_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_0_button.Location = new System.Drawing.Point(43, 440);
            this.number_0_button.Name = "number_0_button";
            this.number_0_button.Size = new System.Drawing.Size(175, 80);
            this.number_0_button.TabIndex = 60;
            this.number_0_button.Text = "0";
            this.number_0_button.UseVisualStyleBackColor = false;
            this.number_0_button.Click += new System.EventHandler(this.number_0_button_Click);
            // 
            // number_3_button
            // 
            this.number_3_button.BackColor = System.Drawing.Color.DimGray;
            this.number_3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_3_button.Location = new System.Drawing.Point(185, 345);
            this.number_3_button.Name = "number_3_button";
            this.number_3_button.Size = new System.Drawing.Size(80, 80);
            this.number_3_button.TabIndex = 59;
            this.number_3_button.Text = "3";
            this.number_3_button.UseVisualStyleBackColor = false;
            this.number_3_button.Click += new System.EventHandler(this.number_3_button_Click);
            // 
            // number_2_button
            // 
            this.number_2_button.BackColor = System.Drawing.Color.DimGray;
            this.number_2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_2_button.Location = new System.Drawing.Point(98, 345);
            this.number_2_button.Name = "number_2_button";
            this.number_2_button.Size = new System.Drawing.Size(80, 80);
            this.number_2_button.TabIndex = 58;
            this.number_2_button.Text = "2";
            this.number_2_button.UseVisualStyleBackColor = false;
            this.number_2_button.Click += new System.EventHandler(this.number_2_button_Click);
            // 
            // number_1_button
            // 
            this.number_1_button.BackColor = System.Drawing.Color.DimGray;
            this.number_1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_1_button.Location = new System.Drawing.Point(12, 345);
            this.number_1_button.Name = "number_1_button";
            this.number_1_button.Size = new System.Drawing.Size(80, 80);
            this.number_1_button.TabIndex = 57;
            this.number_1_button.Text = "1";
            this.number_1_button.UseVisualStyleBackColor = false;
            this.number_1_button.Click += new System.EventHandler(this.number_1_button_Click);
            // 
            // number_6_button
            // 
            this.number_6_button.BackColor = System.Drawing.Color.DimGray;
            this.number_6_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_6_button.Location = new System.Drawing.Point(184, 249);
            this.number_6_button.Name = "number_6_button";
            this.number_6_button.Size = new System.Drawing.Size(80, 80);
            this.number_6_button.TabIndex = 56;
            this.number_6_button.Text = "6";
            this.number_6_button.UseVisualStyleBackColor = false;
            this.number_6_button.Click += new System.EventHandler(this.number_6_button_Click);
            // 
            // number_5_button
            // 
            this.number_5_button.BackColor = System.Drawing.Color.DimGray;
            this.number_5_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_5_button.Location = new System.Drawing.Point(98, 249);
            this.number_5_button.Name = "number_5_button";
            this.number_5_button.Size = new System.Drawing.Size(80, 80);
            this.number_5_button.TabIndex = 55;
            this.number_5_button.Text = "5";
            this.number_5_button.UseVisualStyleBackColor = false;
            this.number_5_button.Click += new System.EventHandler(this.number_5_button_Click);
            // 
            // number_4_button
            // 
            this.number_4_button.BackColor = System.Drawing.Color.DimGray;
            this.number_4_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_4_button.Location = new System.Drawing.Point(12, 249);
            this.number_4_button.Name = "number_4_button";
            this.number_4_button.Size = new System.Drawing.Size(80, 80);
            this.number_4_button.TabIndex = 54;
            this.number_4_button.Text = "4";
            this.number_4_button.UseVisualStyleBackColor = false;
            this.number_4_button.Click += new System.EventHandler(this.number_4_button_Click);
            // 
            // number_9_button
            // 
            this.number_9_button.BackColor = System.Drawing.Color.DimGray;
            this.number_9_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_9_button.Location = new System.Drawing.Point(184, 154);
            this.number_9_button.Name = "number_9_button";
            this.number_9_button.Size = new System.Drawing.Size(80, 80);
            this.number_9_button.TabIndex = 53;
            this.number_9_button.Text = "9";
            this.number_9_button.UseVisualStyleBackColor = false;
            this.number_9_button.Click += new System.EventHandler(this.number_9_button_Click);
            // 
            // number_8_button
            // 
            this.number_8_button.BackColor = System.Drawing.Color.DimGray;
            this.number_8_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_8_button.Location = new System.Drawing.Point(98, 154);
            this.number_8_button.Name = "number_8_button";
            this.number_8_button.Size = new System.Drawing.Size(80, 80);
            this.number_8_button.TabIndex = 52;
            this.number_8_button.Text = "8";
            this.number_8_button.UseVisualStyleBackColor = false;
            this.number_8_button.Click += new System.EventHandler(this.number_8_button_Click);
            // 
            // number_7_button
            // 
            this.number_7_button.BackColor = System.Drawing.Color.DimGray;
            this.number_7_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_7_button.Location = new System.Drawing.Point(12, 154);
            this.number_7_button.Name = "number_7_button";
            this.number_7_button.Size = new System.Drawing.Size(80, 80);
            this.number_7_button.TabIndex = 51;
            this.number_7_button.Text = "7";
            this.number_7_button.UseVisualStyleBackColor = false;
            this.number_7_button.Click += new System.EventHandler(this.number_7_button_Click);
            // 
            // screen_label
            // 
            this.screen_label.BackColor = System.Drawing.Color.DimGray;
            this.screen_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.screen_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen_label.Location = new System.Drawing.Point(12, 26);
            this.screen_label.Name = "screen_label";
            this.screen_label.Size = new System.Drawing.Size(434, 89);
            this.screen_label.TabIndex = 50;
            this.screen_label.Text = "0";
            this.screen_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(459, 601);
            this.Controls.Add(this.equals_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.positive_button);
            this.Controls.Add(this.negative_button);
            this.Controls.Add(this.star_button);
            this.Controls.Add(this.backslash_button);
            this.Controls.Add(this.number_0_button);
            this.Controls.Add(this.number_3_button);
            this.Controls.Add(this.number_2_button);
            this.Controls.Add(this.number_1_button);
            this.Controls.Add(this.number_6_button);
            this.Controls.Add(this.number_5_button);
            this.Controls.Add(this.number_4_button);
            this.Controls.Add(this.number_9_button);
            this.Controls.Add(this.number_8_button);
            this.Controls.Add(this.number_7_button);
            this.Controls.Add(this.screen_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button equals_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button positive_button;
        private System.Windows.Forms.Button negative_button;
        private System.Windows.Forms.Button star_button;
        private System.Windows.Forms.Button backslash_button;
        private System.Windows.Forms.Button number_0_button;
        private System.Windows.Forms.Button number_3_button;
        private System.Windows.Forms.Button number_2_button;
        private System.Windows.Forms.Button number_1_button;
        private System.Windows.Forms.Button number_6_button;
        private System.Windows.Forms.Button number_5_button;
        private System.Windows.Forms.Button number_4_button;
        private System.Windows.Forms.Button number_9_button;
        private System.Windows.Forms.Button number_8_button;
        private System.Windows.Forms.Button number_7_button;
        private System.Windows.Forms.Label screen_label;
    }
}

