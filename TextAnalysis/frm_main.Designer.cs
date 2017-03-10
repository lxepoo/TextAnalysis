namespace TextAnalysis
{
    partial class frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pannel_text = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_read = new System.Windows.Forms.Button();
            this.lab_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tip_text = new System.Windows.Forms.ToolTip(this.components);
            this.lab_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pannel_text
            // 
            this.pannel_text.AutoScroll = true;
            this.pannel_text.Location = new System.Drawing.Point(13, 91);
            this.pannel_text.Name = "pannel_text";
            this.pannel_text.Size = new System.Drawing.Size(894, 496);
            this.pannel_text.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_read.Location = new System.Drawing.Point(761, 12);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(139, 55);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "从剪切板\r\n载入字符串";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(10, 24);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(138, 28);
            this.lab_title.TabIndex = 3;
            this.lab_title.Text = "字符串分析器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(725, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "注：工具的用途主要是用来分析字符串，找出隐藏字符，查看编码等功能，为了效率只支持1000个字符的处理，超出部分不做任何操作。";
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_count.ForeColor = System.Drawing.Color.Red;
            this.lab_count.Location = new System.Drawing.Point(14, 597);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(0, 20);
            this.lab_count.TabIndex = 5;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 662);
            this.Controls.Add(this.lab_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.pannel_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(935, 700);
            this.MinimumSize = new System.Drawing.Size(935, 700);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符分析器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pannel_text;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tip_text;
        private System.Windows.Forms.Label lab_count;
    }
}

