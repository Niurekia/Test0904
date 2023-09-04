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
            this.groupBox_conn = new System.Windows.Forms.GroupBox();
            this.groupBox_LED = new System.Windows.Forms.GroupBox();
            this.Led_Off_btn = new System.Windows.Forms.Button();
            this.Led_On_btn = new System.Windows.Forms.Button();
            this.groupBox_log = new System.Windows.Forms.GroupBox();
            this.groupBox_tmp_sns = new System.Windows.Forms.GroupBox();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.groupBox_light_sns = new System.Windows.Forms.GroupBox();
            this.sunText = new System.Windows.Forms.TextBox();
            this.groupBox_us_sns = new System.Windows.Forms.GroupBox();
            this.US_Text = new System.Windows.Forms.TextBox();
            this.groupBox_conn.SuspendLayout();
            this.groupBox_LED.SuspendLayout();
            this.groupBox_log.SuspendLayout();
            this.groupBox_tmp_sns.SuspendLayout();
            this.groupBox_light_sns.SuspendLayout();
            this.groupBox_us_sns.SuspendLayout();
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
            // groupBox_conn
            // 
            this.groupBox_conn.Controls.Add(this.conn_btn);
            this.groupBox_conn.Controls.Add(this.PortNumber);
            this.groupBox_conn.Location = new System.Drawing.Point(24, 31);
            this.groupBox_conn.Name = "groupBox_conn";
            this.groupBox_conn.Size = new System.Drawing.Size(200, 55);
            this.groupBox_conn.TabIndex = 3;
            this.groupBox_conn.TabStop = false;
            this.groupBox_conn.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox_LED
            // 
            this.groupBox_LED.Controls.Add(this.Led_Off_btn);
            this.groupBox_LED.Controls.Add(this.Led_On_btn);
            this.groupBox_LED.Location = new System.Drawing.Point(24, 102);
            this.groupBox_LED.Name = "groupBox_LED";
            this.groupBox_LED.Size = new System.Drawing.Size(200, 100);
            this.groupBox_LED.TabIndex = 4;
            this.groupBox_LED.TabStop = false;
            this.groupBox_LED.Text = "LED Controller";
            // 
            // Led_Off_btn
            // 
            this.Led_Off_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(141)))));
            this.Led_Off_btn.Location = new System.Drawing.Point(114, 31);
            this.Led_Off_btn.Name = "Led_Off_btn";
            this.Led_Off_btn.Size = new System.Drawing.Size(80, 60);
            this.Led_Off_btn.TabIndex = 1;
            this.Led_Off_btn.Text = "OFF";
            this.Led_Off_btn.UseVisualStyleBackColor = false;
            this.Led_Off_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Led_On_btn
            // 
            this.Led_On_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(141)))));
            this.Led_On_btn.Location = new System.Drawing.Point(6, 31);
            this.Led_On_btn.Name = "Led_On_btn";
            this.Led_On_btn.Size = new System.Drawing.Size(80, 60);
            this.Led_On_btn.TabIndex = 0;
            this.Led_On_btn.Text = "ON";
            this.Led_On_btn.UseVisualStyleBackColor = false;
            this.Led_On_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_log
            // 
            this.groupBox_log.Controls.Add(this.textArea);
            this.groupBox_log.Location = new System.Drawing.Point(242, 31);
            this.groupBox_log.Name = "groupBox_log";
            this.groupBox_log.Size = new System.Drawing.Size(248, 364);
            this.groupBox_log.TabIndex = 5;
            this.groupBox_log.TabStop = false;
            this.groupBox_log.Text = "Event Log";
            // 
            // groupBox_tmp_sns
            // 
            this.groupBox_tmp_sns.Controls.Add(this.TempBox);
            this.groupBox_tmp_sns.Location = new System.Drawing.Point(24, 225);
            this.groupBox_tmp_sns.Name = "groupBox_tmp_sns";
            this.groupBox_tmp_sns.Size = new System.Drawing.Size(200, 52);
            this.groupBox_tmp_sns.TabIndex = 6;
            this.groupBox_tmp_sns.TabStop = false;
            this.groupBox_tmp_sns.Text = "Temperature Sensor";
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
            // groupBox_light_sns
            // 
            this.groupBox_light_sns.Controls.Add(this.sunText);
            this.groupBox_light_sns.Location = new System.Drawing.Point(24, 283);
            this.groupBox_light_sns.Name = "groupBox_light_sns";
            this.groupBox_light_sns.Size = new System.Drawing.Size(200, 54);
            this.groupBox_light_sns.TabIndex = 7;
            this.groupBox_light_sns.TabStop = false;
            this.groupBox_light_sns.Text = "Light Sensor";
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
            // groupBox_us_sns
            // 
            this.groupBox_us_sns.Controls.Add(this.US_Text);
            this.groupBox_us_sns.Location = new System.Drawing.Point(24, 343);
            this.groupBox_us_sns.Name = "groupBox_us_sns";
            this.groupBox_us_sns.Size = new System.Drawing.Size(200, 52);
            this.groupBox_us_sns.TabIndex = 8;
            this.groupBox_us_sns.TabStop = false;
            this.groupBox_us_sns.Text = "Ultrasonic Sensor";
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
            this.Controls.Add(this.groupBox_us_sns);
            this.Controls.Add(this.groupBox_light_sns);
            this.Controls.Add(this.groupBox_tmp_sns);
            this.Controls.Add(this.groupBox_log);
            this.Controls.Add(this.groupBox_LED);
            this.Controls.Add(this.groupBox_conn);
            this.Name = "winform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ">_<";
            this.Load += new System.EventHandler(this.winform_Load);
            this.groupBox_conn.ResumeLayout(false);
            this.groupBox_LED.ResumeLayout(false);
            this.groupBox_log.ResumeLayout(false);
            this.groupBox_log.PerformLayout();
            this.groupBox_tmp_sns.ResumeLayout(false);
            this.groupBox_tmp_sns.PerformLayout();
            this.groupBox_light_sns.ResumeLayout(false);
            this.groupBox_light_sns.PerformLayout();
            this.groupBox_us_sns.ResumeLayout(false);
            this.groupBox_us_sns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.GroupBox groupBox_conn;
        private System.Windows.Forms.GroupBox groupBox_LED;
        private System.Windows.Forms.Button Led_Off_btn;
        private System.Windows.Forms.Button Led_On_btn;
        private System.Windows.Forms.GroupBox groupBox_log;
        private System.Windows.Forms.GroupBox groupBox_tmp_sns;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.GroupBox groupBox_light_sns;
        private System.Windows.Forms.TextBox sunText;
        private System.Windows.Forms.GroupBox groupBox_us_sns;
        private System.Windows.Forms.TextBox US_Text;
    }
}