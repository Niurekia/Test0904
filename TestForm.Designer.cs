namespace _01BASIC
{
    partial class winform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sunText = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.US_Text = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PortNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.PortNumber.Location = new System.Drawing.Point(6, 20);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(93, 20);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged);
            // 
            // conn_btn
            // 
            this.conn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(141)))));
            this.conn_btn.Location = new System.Drawing.Point(114, 20);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 23);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = false;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // textArea
            // 
            this.textArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.textArea.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(22)))), ((int)(((byte)(201)))));
            this.textArea.Location = new System.Drawing.Point(6, 20);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textArea.Size = new System.Drawing.Size(236, 338);
            this.textArea.TabIndex = 2;
            this.textArea.Text = "💜_💜\r\n";
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Controls.Add(this.PortNumber);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(24, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Controller";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(141)))));
            this.button2.Location = new System.Drawing.Point(114, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(141)))));
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textArea);
            this.groupBox3.Location = new System.Drawing.Point(242, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 364);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Log";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TempBox);
            this.groupBox4.Location = new System.Drawing.Point(24, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 52);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Temperature Sensor";
            // 
            // TempBox
            // 
            this.TempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.TempBox.Enabled = false;
            this.TempBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TempBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(90)))), ((int)(((byte)(235)))));
            this.TempBox.Location = new System.Drawing.Point(6, 20);
            this.TempBox.Name = "TempBox";
            this.TempBox.Size = new System.Drawing.Size(188, 26);
            this.TempBox.TabIndex = 7;
            this.TempBox.Text = "온도";
            this.TempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sunText);
            this.groupBox5.Location = new System.Drawing.Point(24, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 54);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Light Sensor";
            // 
            // sunText
            // 
            this.sunText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.sunText.Enabled = false;
            this.sunText.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sunText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(90)))), ((int)(((byte)(235)))));
            this.sunText.Location = new System.Drawing.Point(6, 20);
            this.sunText.Name = "sunText";
            this.sunText.Size = new System.Drawing.Size(188, 26);
            this.sunText.TabIndex = 8;
            this.sunText.Text = "조도";
            this.sunText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.US_Text);
            this.groupBox6.Location = new System.Drawing.Point(24, 343);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 52);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ultrasonic Sensor";
            // 
            // US_Text
            // 
            this.US_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.US_Text.Enabled = false;
            this.US_Text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.US_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(90)))), ((int)(((byte)(235)))));
            this.US_Text.HideSelection = false;
            this.US_Text.Location = new System.Drawing.Point(6, 17);
            this.US_Text.Name = "US_Text";
            this.US_Text.Size = new System.Drawing.Size(188, 26);
            this.US_Text.TabIndex = 0;
            this.US_Text.Text = "초음파";
            this.US_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(512, 428);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "winform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ">_<";
            this.Load += new System.EventHandler(this.winform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox sunText;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox US_Text;
    }
}