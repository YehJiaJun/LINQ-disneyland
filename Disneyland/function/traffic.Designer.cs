
namespace Disneyland.function
{
    partial class traffic
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.txtintroduction = new System.Windows.Forms.TextBox();
            this.txtsh = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.tp4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.tp5 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.color1 = new Disneyland.function.color();
            this.tc.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.tp4.SuspendLayout();
            this.tp5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "驅車前往";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "停車資訊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "乘坐地鐵";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "乘坐公交車";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "乘坐出租車";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp1);
            this.tc.Controls.Add(this.tp2);
            this.tc.Controls.Add(this.tp3);
            this.tc.Controls.Add(this.tp4);
            this.tc.Controls.Add(this.tp5);
            this.tc.Location = new System.Drawing.Point(111, -31);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(953, 794);
            this.tc.TabIndex = 5;
            // 
            // tp1
            // 
            this.tp1.BackColor = System.Drawing.SystemColors.Control;
            this.tp1.Controls.Add(this.button8);
            this.tp1.Controls.Add(this.txt2);
            this.tp1.Controls.Add(this.txt1);
            this.tp1.Location = new System.Drawing.Point(4, 29);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(945, 761);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "tabPage1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(837, 670);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 51);
            this.button8.TabIndex = 6;
            this.button8.Text = "保存";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Control;
            this.txt2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt2.Location = new System.Drawing.Point(6, 83);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt2.Size = new System.Drawing.Size(764, 618);
            this.txt2.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Control;
            this.txt1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt1.Location = new System.Drawing.Point(6, 6);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(764, 43);
            this.txt1.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.BackColor = System.Drawing.SystemColors.Control;
            this.tp2.Controls.Add(this.button9);
            this.tp2.Controls.Add(this.txt4);
            this.tp2.Controls.Add(this.txt3);
            this.tp2.Location = new System.Drawing.Point(4, 29);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(945, 761);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "tabPage2";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(837, 670);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 51);
            this.button9.TabIndex = 7;
            this.button9.Text = "保存";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.SystemColors.Control;
            this.txt4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt4.Location = new System.Drawing.Point(6, 83);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt4.Size = new System.Drawing.Size(764, 618);
            this.txt4.TabIndex = 3;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.Control;
            this.txt3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt3.Location = new System.Drawing.Point(6, 6);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(764, 43);
            this.txt3.TabIndex = 2;
            // 
            // tp3
            // 
            this.tp3.BackColor = System.Drawing.SystemColors.Control;
            this.tp3.Controls.Add(this.button10);
            this.tp3.Controls.Add(this.button7);
            this.tp3.Controls.Add(this.button6);
            this.tp3.Controls.Add(this.picbox);
            this.tp3.Controls.Add(this.txtintroduction);
            this.tp3.Controls.Add(this.txtsh);
            this.tp3.Controls.Add(this.txttitle);
            this.tp3.Location = new System.Drawing.Point(4, 29);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(3);
            this.tp3.Size = new System.Drawing.Size(945, 761);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "tabPage2";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(837, 670);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 51);
            this.button10.TabIndex = 8;
            this.button10.Text = "保存";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(801, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 51);
            this.button7.TabIndex = 7;
            this.button7.Text = "刪除";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(801, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 51);
            this.button6.TabIndex = 6;
            this.button6.Text = "匯入";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(388, 83);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(407, 257);
            this.picbox.TabIndex = 5;
            this.picbox.TabStop = false;
            // 
            // txtintroduction
            // 
            this.txtintroduction.BackColor = System.Drawing.SystemColors.Control;
            this.txtintroduction.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtintroduction.Location = new System.Drawing.Point(388, 346);
            this.txtintroduction.Multiline = true;
            this.txtintroduction.Name = "txtintroduction";
            this.txtintroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtintroduction.Size = new System.Drawing.Size(551, 282);
            this.txtintroduction.TabIndex = 4;
            // 
            // txtsh
            // 
            this.txtsh.BackColor = System.Drawing.SystemColors.Control;
            this.txtsh.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsh.Location = new System.Drawing.Point(6, 83);
            this.txtsh.Multiline = true;
            this.txtsh.Name = "txtsh";
            this.txtsh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsh.Size = new System.Drawing.Size(376, 618);
            this.txtsh.TabIndex = 3;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.SystemColors.Control;
            this.txttitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttitle.Location = new System.Drawing.Point(6, 6);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(764, 43);
            this.txttitle.TabIndex = 2;
            // 
            // tp4
            // 
            this.tp4.BackColor = System.Drawing.SystemColors.Control;
            this.tp4.Controls.Add(this.button11);
            this.tp4.Controls.Add(this.txt6);
            this.tp4.Controls.Add(this.txt5);
            this.tp4.Location = new System.Drawing.Point(4, 29);
            this.tp4.Name = "tp4";
            this.tp4.Padding = new System.Windows.Forms.Padding(3);
            this.tp4.Size = new System.Drawing.Size(945, 761);
            this.tp4.TabIndex = 3;
            this.tp4.Text = "tabPage2";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(837, 670);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(102, 51);
            this.button11.TabIndex = 7;
            this.button11.Text = "保存";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.SystemColors.Control;
            this.txt6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt6.Location = new System.Drawing.Point(6, 83);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt6.Size = new System.Drawing.Size(764, 618);
            this.txt6.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.SystemColors.Control;
            this.txt5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt5.Location = new System.Drawing.Point(6, 6);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(764, 43);
            this.txt5.TabIndex = 2;
            // 
            // tp5
            // 
            this.tp5.BackColor = System.Drawing.SystemColors.Control;
            this.tp5.Controls.Add(this.button12);
            this.tp5.Controls.Add(this.txt8);
            this.tp5.Controls.Add(this.txt7);
            this.tp5.Location = new System.Drawing.Point(4, 29);
            this.tp5.Name = "tp5";
            this.tp5.Padding = new System.Windows.Forms.Padding(3);
            this.tp5.Size = new System.Drawing.Size(945, 761);
            this.tp5.TabIndex = 4;
            this.tp5.Text = "tabPage2";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(837, 670);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(102, 51);
            this.button12.TabIndex = 7;
            this.button12.Text = "保存";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txt8
            // 
            this.txt8.BackColor = System.Drawing.SystemColors.Control;
            this.txt8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt8.Location = new System.Drawing.Point(6, 83);
            this.txt8.Multiline = true;
            this.txt8.Name = "txt8";
            this.txt8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt8.Size = new System.Drawing.Size(764, 618);
            this.txt8.TabIndex = 3;
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.SystemColors.Control;
            this.txt7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt7.Location = new System.Drawing.Point(6, 6);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(764, 43);
            this.txt7.TabIndex = 2;
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(110, -3);
            this.color1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(1688, 1280);
            this.color1.TabIndex = 8;
            // 
            // traffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.color1);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "traffic";
            this.Size = new System.Drawing.Size(1067, 766);
            this.tc.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.tp3.ResumeLayout(false);
            this.tp3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.tp4.ResumeLayout(false);
            this.tp4.PerformLayout();
            this.tp5.ResumeLayout(false);
            this.tp5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.TabPage tp4;
        private System.Windows.Forms.TabPage tp5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.TextBox txtintroduction;
        private System.Windows.Forms.TextBox txtsh;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private color color1;
    }
}
