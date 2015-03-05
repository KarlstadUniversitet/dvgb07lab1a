using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottoprogram
{
    public partial class LottoForm : Form
    {
        public LottoForm()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            String[] lottoRow = {textBox_lottoRow1.Text, textBox_lottoRow2.Text, textBox_lottoRow3.Text, textBox_lottoRow4.Text, textBox_lottoRow5.Text, textBox_lottoRow6.Text, textBox_lottoRow7.Text};
            String lottoDraws = textBox_numDraws.Text;
            logic = new Logic(lottoRow, lottoDraws);

            if (!logic.correctInput())
            {
                label_error.Text = "Check input. Something is wrong!\n !OBS! Everything needs to be integer 1-35";
                return;
            }
            else { label_error.Text = "";  }

            logic.startLotto();

            label_fiveRightAnswer.Text = "" + logic.numTimesRight[4] + "";
            label_sixRightAnswer.Text = "" + logic.numTimesRight[5] + "";
            label_sevenRightAnswer.Text = "" + logic.numTimesRight[6] + "";
        }


    }
}
