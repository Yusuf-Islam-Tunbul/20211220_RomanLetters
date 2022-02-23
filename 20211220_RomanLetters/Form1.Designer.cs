
namespace _20211220_RomanLetters
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
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.convert_button = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.input_textbox2 = new System.Windows.Forms.TextBox();
            this.deconvert_button = new System.Windows.Forms.Button();
            this.output_label2 = new System.Windows.Forms.Label();
            this.info_label1 = new System.Windows.Forms.Label();
            this.info_label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 35);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(136, 22);
            this.input_textbox.TabIndex = 0;
            // 
            // convert_button
            // 
            this.convert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.convert_button.Location = new System.Drawing.Point(12, 63);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(136, 23);
            this.convert_button.TabIndex = 1;
            this.convert_button.Text = "ÇEVİR";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(12, 89);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(0, 17);
            this.output_label.TabIndex = 2;
            // 
            // input_textbox2
            // 
            this.input_textbox2.Location = new System.Drawing.Point(162, 35);
            this.input_textbox2.Name = "input_textbox2";
            this.input_textbox2.Size = new System.Drawing.Size(136, 22);
            this.input_textbox2.TabIndex = 3;
            // 
            // deconvert_button
            // 
            this.deconvert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deconvert_button.Location = new System.Drawing.Point(162, 63);
            this.deconvert_button.Name = "deconvert_button";
            this.deconvert_button.Size = new System.Drawing.Size(136, 23);
            this.deconvert_button.TabIndex = 4;
            this.deconvert_button.Text = "ÇEVİR";
            this.deconvert_button.UseVisualStyleBackColor = true;
            this.deconvert_button.Click += new System.EventHandler(this.deconvert_button_Click_1);
            // 
            // output_label2
            // 
            this.output_label2.AutoSize = true;
            this.output_label2.Location = new System.Drawing.Point(159, 89);
            this.output_label2.Name = "output_label2";
            this.output_label2.Size = new System.Drawing.Size(0, 17);
            this.output_label2.TabIndex = 5;
            // 
            // info_label1
            // 
            this.info_label1.AutoSize = true;
            this.info_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info_label1.Location = new System.Drawing.Point(12, 10);
            this.info_label1.Name = "info_label1";
            this.info_label1.Size = new System.Drawing.Size(127, 20);
            this.info_label1.TabIndex = 6;
            this.info_label1.Text = "Tam sayı giriniz";
            // 
            // info_label2
            // 
            this.info_label2.AutoSize = true;
            this.info_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info_label2.Location = new System.Drawing.Point(158, 10);
            this.info_label2.Name = "info_label2";
            this.info_label2.Size = new System.Drawing.Size(158, 20);
            this.info_label2.TabIndex = 7;
            this.info_label2.Text = "Roma rakamı giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 123);
            this.Controls.Add(this.info_label2);
            this.Controls.Add(this.info_label1);
            this.Controls.Add(this.output_label2);
            this.Controls.Add(this.deconvert_button);
            this.Controls.Add(this.input_textbox2);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.input_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.TextBox input_textbox2;
        private System.Windows.Forms.Button deconvert_button;
        private System.Windows.Forms.Label output_label2;
        private System.Windows.Forms.Label info_label1;
        private System.Windows.Forms.Label info_label2;
    }
}

