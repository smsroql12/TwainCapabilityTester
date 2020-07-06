namespace TwainCapabilityTester
{
    partial class Form1
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
            this.rasterImageViewer1 = new Leadtools.WinForms.RasterImageViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SelectScanner = new System.Windows.Forms.Button();
            this.btn_GetValue = new System.Windows.Forms.Button();
            this.cb_GetValue = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_SetValue = new System.Windows.Forms.ComboBox();
            this.btn_SetValue = new System.Windows.Forms.Button();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rasterImageViewer1
            // 
            this.rasterImageViewer1.Location = new System.Drawing.Point(260, 9);
            this.rasterImageViewer1.Name = "rasterImageViewer1";
            this.rasterImageViewer1.Size = new System.Drawing.Size(263, 371);
            this.rasterImageViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_GetValue);
            this.groupBox1.Controls.Add(this.btn_GetValue);
            this.groupBox1.Location = new System.Drawing.Point(7, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Value";
            // 
            // btn_SelectScanner
            // 
            this.btn_SelectScanner.Location = new System.Drawing.Point(7, 9);
            this.btn_SelectScanner.Name = "btn_SelectScanner";
            this.btn_SelectScanner.Size = new System.Drawing.Size(239, 45);
            this.btn_SelectScanner.TabIndex = 2;
            this.btn_SelectScanner.Text = "스캐너 선택";
            this.btn_SelectScanner.UseVisualStyleBackColor = true;
            // 
            // btn_GetValue
            // 
            this.btn_GetValue.Location = new System.Drawing.Point(12, 69);
            this.btn_GetValue.Name = "btn_GetValue";
            this.btn_GetValue.Size = new System.Drawing.Size(213, 34);
            this.btn_GetValue.TabIndex = 0;
            this.btn_GetValue.Text = "값 가져오기";
            this.btn_GetValue.UseVisualStyleBackColor = true;
            // 
            // cb_GetValue
            // 
            this.cb_GetValue.FormattingEnabled = true;
            this.cb_GetValue.Location = new System.Drawing.Point(12, 32);
            this.cb_GetValue.Name = "cb_GetValue";
            this.cb_GetValue.Size = new System.Drawing.Size(213, 23);
            this.cb_GetValue.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_SetValue);
            this.groupBox2.Controls.Add(this.btn_SetValue);
            this.groupBox2.Location = new System.Drawing.Point(7, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Value";
            // 
            // cb_SetValue
            // 
            this.cb_SetValue.FormattingEnabled = true;
            this.cb_SetValue.Location = new System.Drawing.Point(12, 32);
            this.cb_SetValue.Name = "cb_SetValue";
            this.cb_SetValue.Size = new System.Drawing.Size(213, 23);
            this.cb_SetValue.TabIndex = 1;
            // 
            // btn_SetValue
            // 
            this.btn_SetValue.Location = new System.Drawing.Point(12, 69);
            this.btn_SetValue.Name = "btn_SetValue";
            this.btn_SetValue.Size = new System.Drawing.Size(213, 34);
            this.btn_SetValue.TabIndex = 0;
            this.btn_SetValue.Text = "값 설정";
            this.btn_SetValue.UseVisualStyleBackColor = true;
            // 
            // btn_Scan
            // 
            this.btn_Scan.Location = new System.Drawing.Point(7, 316);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(238, 63);
            this.btn_Scan.TabIndex = 3;
            this.btn_Scan.Text = "스캔";
            this.btn_Scan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 307);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_SelectScanner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rasterImageViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Leadtools.WinForms.RasterImageViewer rasterImageViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_GetValue;
        private System.Windows.Forms.Button btn_GetValue;
        private System.Windows.Forms.Button btn_SelectScanner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_SetValue;
        private System.Windows.Forms.Button btn_SetValue;
        private System.Windows.Forms.Button btn_Scan;
    }
}

