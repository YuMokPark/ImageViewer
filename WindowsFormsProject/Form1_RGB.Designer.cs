namespace WindowsFormsProject
{
    partial class Form1_RGB
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
            this.but_Black = new System.Windows.Forms.Button();
            this.but_MRad = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_MGreen = new System.Windows.Forms.Button();
            this.btn_Gray = new System.Windows.Forms.Button();
            this.btn_Color_Change = new System.Windows.Forms.Button();
            this.btn_MBlue = new System.Windows.Forms.Button();
            this.but_Blow = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Turn = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Position = new System.Windows.Forms.Label();
            this.UpDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Black
            // 
            this.but_Black.Location = new System.Drawing.Point(188, 381);
            this.but_Black.Name = "but_Black";
            this.but_Black.Size = new System.Drawing.Size(145, 35);
            this.but_Black.TabIndex = 1;
            this.but_Black.Text = "흑백 변환";
            this.but_Black.UseVisualStyleBackColor = true;
            this.but_Black.Click += new System.EventHandler(this.but_Black_Click);
            // 
            // but_MRad
            // 
            this.but_MRad.Location = new System.Drawing.Point(358, 381);
            this.but_MRad.Name = "but_MRad";
            this.but_MRad.Size = new System.Drawing.Size(160, 35);
            this.but_MRad.TabIndex = 2;
            this.but_MRad.Text = "R 계열이 강한 색만 보기";
            this.but_MRad.UseVisualStyleBackColor = true;
            this.but_MRad.Click += new System.EventHandler(this.but_MRad_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(36, 520);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(525, 35);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "원상 복구";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_MGreen
            // 
            this.btn_MGreen.Location = new System.Drawing.Point(358, 431);
            this.btn_MGreen.Name = "btn_MGreen";
            this.btn_MGreen.Size = new System.Drawing.Size(160, 35);
            this.btn_MGreen.TabIndex = 6;
            this.btn_MGreen.Text = "G 계열이 강한 색만 보기";
            this.btn_MGreen.UseVisualStyleBackColor = true;
            this.btn_MGreen.Click += new System.EventHandler(this.btn_MGreen_Click);
            // 
            // btn_Gray
            // 
            this.btn_Gray.Location = new System.Drawing.Point(188, 431);
            this.btn_Gray.Name = "btn_Gray";
            this.btn_Gray.Size = new System.Drawing.Size(145, 35);
            this.btn_Gray.TabIndex = 7;
            this.btn_Gray.Text = "그레이 변환";
            this.btn_Gray.UseVisualStyleBackColor = true;
            this.btn_Gray.Click += new System.EventHandler(this.btn_Gray_Click);
            // 
            // btn_Color_Change
            // 
            this.btn_Color_Change.Location = new System.Drawing.Point(188, 479);
            this.btn_Color_Change.Name = "btn_Color_Change";
            this.btn_Color_Change.Size = new System.Drawing.Size(145, 35);
            this.btn_Color_Change.TabIndex = 8;
            this.btn_Color_Change.Text = "색상 변환";
            this.btn_Color_Change.UseVisualStyleBackColor = true;
            this.btn_Color_Change.Click += new System.EventHandler(this.btn_Color_Change_Click);
            // 
            // btn_MBlue
            // 
            this.btn_MBlue.Location = new System.Drawing.Point(358, 479);
            this.btn_MBlue.Name = "btn_MBlue";
            this.btn_MBlue.Size = new System.Drawing.Size(160, 35);
            this.btn_MBlue.TabIndex = 9;
            this.btn_MBlue.Text = "B 계열이 강한 색만 보기";
            this.btn_MBlue.UseVisualStyleBackColor = true;
            this.btn_MBlue.Click += new System.EventHandler(this.btn_MBlue_Click);
            // 
            // but_Blow
            // 
            this.but_Blow.Location = new System.Drawing.Point(21, 381);
            this.but_Blow.Name = "but_Blow";
            this.but_Blow.Size = new System.Drawing.Size(145, 35);
            this.but_Blow.TabIndex = 11;
            this.but_Blow.Text = "가져오기";
            this.but_Blow.UseVisualStyleBackColor = true;
            this.but_Blow.Click += new System.EventHandler(this.but_Blow_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Turn
            // 
            this.btn_Turn.Location = new System.Drawing.Point(21, 431);
            this.btn_Turn.Name = "btn_Turn";
            this.btn_Turn.Size = new System.Drawing.Size(145, 35);
            this.btn_Turn.TabIndex = 12;
            this.btn_Turn.Text = "회전";
            this.btn_Turn.UseVisualStyleBackColor = true;
            this.btn_Turn.Click += new System.EventHandler(this.btn_Turn_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(21, 322);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(596, 21);
            this.hScrollBar1.TabIndex = 13;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(620, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(25, 319);
            this.vScrollBar1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(537, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(658, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 279);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 279);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(537, 443);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(160, 23);
            this.Position.TabIndex = 15;
            this.Position.Text = "label1";
            // 
            // UpDown
            // 
            this.UpDown.Location = new System.Drawing.Point(537, 392);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(223, 23);
            this.UpDown.TabIndex = 18;
            this.UpDown.Text = "label1";
            // 
            // Form1_RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 577);
            this.Controls.Add(this.UpDown);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btn_Turn);
            this.Controls.Add(this.but_Blow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_MBlue);
            this.Controls.Add(this.btn_Color_Change);
            this.Controls.Add(this.btn_Gray);
            this.Controls.Add(this.btn_MGreen);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.but_MRad);
            this.Controls.Add(this.but_Black);
            this.Name = "Form1_RGB";
            this.Text = "Form1_RGB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button but_Black;
        private System.Windows.Forms.Button but_MRad;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_MGreen;
        private System.Windows.Forms.Button btn_Gray;
        private System.Windows.Forms.Button btn_Color_Change;
        private System.Windows.Forms.Button btn_MBlue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_Blow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Turn;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label UpDown;
    }
}