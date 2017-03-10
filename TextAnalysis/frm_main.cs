using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextAnalysis
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //重置标题
            lab_title.Text = "字符串分析器";

            try
            {
                //获取剪切板数据
                var text = Clipboard.GetText();
                var arr = text.ToCharArray();

                if (arr.Length == 0)
                {
                    return;
                }

                //处理一下统计
                var count = string.Format("字符串长度：{0}，字节数组长度：{1} ，其中【\\0】字符：{2} 个，【\\r】字符：{3} 个，【\\n】字符：{4} 个", text.Length, arr.Length, Regex.Matches(text, @"\0").Count, Regex.Matches(text, @"\r").Count, Regex.Matches(text, @"\n").Count);
                lab_count.Text = count;

                //清空原有的字符
                pannel_text.Controls.Clear();

                foreach (var t in arr)
                {
                    var lb = new LinkLabel();
                    lb.Text = t.ToString();
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.Size = new System.Drawing.Size(30, 30);
                    lb.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                    lb.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
                    lb.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
                    lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                    lb.Click += new System.EventHandler(TextClick);
                    pannel_text.Controls.Add(lb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误，无法获取信息，错误如下：" + ex.ToString());
            }
        }

        //处理点击后的事件
        private void TextClick(object sender, EventArgs e)
        {
            var lab = sender as LinkLabel;
            var ts = lab.Text.ToCharArray();

            var ascii = (int)ts[0];
            var unicode = "\\u" + ((int)ts[0]).ToString("x");

            var hint = string.Format("字符：【{0}】，ASCII编码：【{1}】，Unicode编码：【{2}】", lab.Text, ascii, unicode);

            //打印
            lab_title.Text = hint;
        }
    }
}

/**
特殊控制字符说明
NUL  空	VT   垂直制表	SYN  空转同步
SOH  标题开始	FF   走纸控制	ETB  信息组传送结束
STX  正文开始	CR   回车	CAN  作废
ETX  正文结束	SO   移位输出	EM   纸尽
EOY  传输结束	SI   移位输入	SUB  换置
ENQ  询问字符	DLE  空格	ESC  换码
ACK  承认	DC1  设备控制1	FS   文字分隔符
BEL  报警	DC2  设备控制2	GS   组分隔符
BS   退一格	DC3  设备控制3	RS   记录分隔符
HT   横向列表	DC4  设备控制4	US   单元分隔符
LF   换行	NAK  否定	DEL  删除
 * 
 **/
