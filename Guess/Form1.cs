using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Guess
{

    public partial class FormMain : Form
    {
        private Thread trd;
        private bool bTrdRun;
            
        const ulong WIN = 0;
        const ulong LOSE = 1;
        const ulong DRAW = 2;

        private ulong ulPc;
        const ulong BAOZI = 0;
        const ulong JIANZI = 1;
        const ulong CHUI = 2;
        string strPath;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //获取可执行文件路径及可执行文件名称
            string strApppath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            //获取可执行文件路径所在的文件夹
            strPath = new FileInfo(strApppath).DirectoryName;

            /* 程序启动，电脑再变 */
            bTrdRun = true;
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();

        }

        public void ThreadTask()
        {
            while (true)
            {
                if (bTrdRun == true)
                {
                    DelegateTxtChg();
                }
                Thread.Sleep(100);
            }
        }

        private delegate void MyDelegateTxtChg();

        public void DelegateTxtChg()
        {
            this.BeginInvoke(new MyDelegateTxtChg(TxtChg));
        }

        private void TxtChg()
        {
            /* Get Rn */

            Random rnNum = new Random();
            int intRn = 0;
            intRn = rnNum.Next();
            if (intRn % 3 == 0)
            {
                pbPc.Image = Image.FromHbitmap(new Bitmap(strPath + @"\jianzi.jpg").GetHbitmap());
                ulPc = JIANZI;
            }
            else if (intRn % 3 == 1)
            {
                pbPc.Image = Image.FromHbitmap(new Bitmap(strPath + @"\baozi.jpg").GetHbitmap());
                ulPc = BAOZI;
            }
            else if (intRn % 3 == 2)
            {
                pbPc.Image = Image.FromHbitmap(new Bitmap(strPath + @"\chui.jpg").GetHbitmap());
                ulPc = CHUI;
            }
            else
            {
                /* debug */
                //lbPc.Text = "出错";
            }

       }

        private ulong GetResult(string strPC, string strHum)
        {
            if (strPC == "剪子" && strHum == "剪子")
            {
                return DRAW;
            }
            else if (strPC == "剪子" && strHum == "包袱")
            {
                return LOSE;
            }
            else if (strPC == "剪子" && strHum == "锤")
            {
                return WIN;
            }
            else if (strPC == "包袱" && strHum == "剪子")
            {
                return WIN;
            }
            else if (strPC == "包袱" && strHum == "包袱")
            {
                return DRAW;
            }
            else if (strPC == "包袱" && strHum == "锤")
            {
                return LOSE;
            }
            else if (strPC == "锤" && strHum == "剪子")
            {
                return LOSE;
            }
            else if (strPC == "锤" && strHum == "包袱")
            {
                return WIN;
            }
            else if (strPC == "锤" && strHum == "锤")
            {
                return DRAW;
            }
            else
            {
                /* Debug */
                return DRAW;
            }
        }

        private void HumClick(string strHum)
        {
            /* Stop trd */
            bTrdRun = false;
            pbHum.Visible = true;

            string strPc = "";
            if (ulPc == BAOZI)
            {
                strPc = "包袱";
            }
            else if (ulPc == JIANZI)
            {
                strPc = "剪子";
            }
            else if (ulPc == CHUI)
            {
                strPc = "锤";
            }
            else
            {
                /*Debug*/
            }

            if (WIN == GetResult(strPc, strHum))
            {
                lbResult.Text = "恭喜你，你赢了";
            }
            else if (LOSE == GetResult(strPc, strHum))
            {
                lbResult.Text = "很遗憾，你输了";
            }
            else if (DRAW == GetResult(strPc, strHum))
            {
                lbResult.Text = "平手";
            }

            lbResult.Visible = true;

            bnAg.Visible = true;
            bnBu.Enabled = false;
            bnSsc.Enabled = false;
            bnHmm.Enabled = false;

        }

        private void bnAg_Click(object sender, EventArgs e)
        {
            bTrdRun = true;
            lbResult.Visible = false;

            bnAg.Visible = false;
            bnBu.Enabled = true;
            bnSsc.Enabled = true;
            bnHmm.Enabled = true;
            pbHum.Visible = false;
        }

        private void bnHmm_Click(object sender, EventArgs e)
        {
                HumClick("锤");
                pbHum.Image = Image.FromHbitmap(new Bitmap(strPath + @"\chui.jpg").GetHbitmap());
        }

        private void bnSsc_Click(object sender, EventArgs e)
        {
                HumClick("剪子");
                pbHum.Image = Image.FromHbitmap(new Bitmap(strPath + @"\jianzi.jpg").GetHbitmap());
        }

        private void bnBu_Click(object sender, EventArgs e)
        {
                HumClick("包袱");
                pbHum.Image = Image.FromHbitmap(new Bitmap(strPath + @"\baozi.jpg").GetHbitmap());
        }
    }
}