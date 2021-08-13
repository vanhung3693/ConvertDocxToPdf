
namespace ConvertDocxToPdf
{
    partial class Convert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnChooseIn = new System.Windows.Forms.Button();
            this.btnChooseOut = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.progressBarConvert = new System.Windows.Forms.ProgressBar();
            this.lblFileConvert = new System.Windows.Forms.Label();
            this.btnToImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Docx sang PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Convert Docx sang PDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thư mục chứa file docx:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(141, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(324, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnChooseIn
            // 
            this.btnChooseIn.Location = new System.Drawing.Point(464, 42);
            this.btnChooseIn.Name = "btnChooseIn";
            this.btnChooseIn.Size = new System.Drawing.Size(75, 23);
            this.btnChooseIn.TabIndex = 3;
            this.btnChooseIn.Text = "Chọn";
            this.btnChooseIn.UseVisualStyleBackColor = true;
            this.btnChooseIn.Click += new System.EventHandler(this.btnChooseIn_Click);
            // 
            // btnChooseOut
            // 
            this.btnChooseOut.Location = new System.Drawing.Point(464, 74);
            this.btnChooseOut.Name = "btnChooseOut";
            this.btnChooseOut.Size = new System.Drawing.Size(75, 23);
            this.btnChooseOut.TabIndex = 6;
            this.btnChooseOut.Text = "Chọn";
            this.btnChooseOut.UseVisualStyleBackColor = true;
            this.btnChooseOut.Click += new System.EventHandler(this.btnChooseOut_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(141, 75);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(324, 20);
            this.txtOutPut.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thư mục lưu file pdf:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(235, 115);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Bắt Đầu";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // progressBarConvert
            // 
            this.progressBarConvert.Location = new System.Drawing.Point(16, 145);
            this.progressBarConvert.Name = "progressBarConvert";
            this.progressBarConvert.Size = new System.Drawing.Size(523, 5);
            this.progressBarConvert.TabIndex = 8;
            this.progressBarConvert.Visible = false;
            // 
            // lblFileConvert
            // 
            this.lblFileConvert.AutoSize = true;
            this.lblFileConvert.Location = new System.Drawing.Point(16, 158);
            this.lblFileConvert.Name = "lblFileConvert";
            this.lblFileConvert.Size = new System.Drawing.Size(0, 13);
            this.lblFileConvert.TabIndex = 9;
            // 
            // btnToImage
            // 
            this.btnToImage.Location = new System.Drawing.Point(329, 115);
            this.btnToImage.Name = "btnToImage";
            this.btnToImage.Size = new System.Drawing.Size(75, 23);
            this.btnToImage.TabIndex = 10;
            this.btnToImage.Text = "To Image";
            this.btnToImage.UseVisualStyleBackColor = true;
            this.btnToImage.Click += new System.EventHandler(this.btnToImage_Click);
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 176);
            this.Controls.Add(this.btnToImage);
            this.Controls.Add(this.lblFileConvert);
            this.Controls.Add(this.progressBarConvert);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnChooseOut);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChooseIn);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Convert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnChooseIn;
        private System.Windows.Forms.Button btnChooseOut;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ProgressBar progressBarConvert;
        private System.Windows.Forms.Label lblFileConvert;
        private System.Windows.Forms.Button btnToImage;
    }
}