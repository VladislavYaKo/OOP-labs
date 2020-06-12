using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopLabs.MyForms
{
    public partial class TrailerForm : Form
    {
        MainForm.UpdateMethod ReqUpdateMethod;
        int IndexInListView;
        public TrailerForm(MainForm.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();

            txtPersonsNum.Enabled = false;
            txtMaxWeightCapacity.Enabled = true;
            if (obj != null)
            {
                txtName.Text = (obj as Trailer).Name;
                txtWheelsNum.Text = (obj as Trailer).WheelsNum.ToString();
                txtPrice.Text = (obj as Trailer).Price.ToString();
                txtMaxWeightCapacity.Text = (obj as Trailer).MaxWeightCapacity.ToString();
                chkbxIsResidential.Checked = (obj as Trailer).IsResidential;                

                txtPersonsNum.Text = (obj as Trailer).PersonsNum.ToString();
                if (chkbxIsResidential.Checked)
                    txtPersonsNum.Enabled = true;
                else
                    txtMaxWeightCapacity.Enabled = true;
            }

            ReqUpdateMethod = method;
            IndexInListView = index;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int personsNum = 0;
            int maxWeightCapacity = 0;
            if (chkbxIsResidential.Checked)
            {
                try
                {
                    personsNum = Int32.Parse(txtPersonsNum.Text);
                }
                catch
                {
                    MessageBox.Show("Введите количество жилых мест");
                    return;
                }
            }
            else
            {
                try
                {
                    maxWeightCapacity = Int32.Parse(txtMaxWeightCapacity.Text);
                }
                catch
                {
                    MessageBox.Show("Введите максимальную нагрузку");
                    return;
                }
            }

            object[] commonText = MainForm.CheckNGetCommonData(txtName, txtWheelsNum, txtPrice);
            if (commonText != null)
            {
                Trailer newTrailer = new Trailer(maxWeightCapacity, chkbxIsResidential.Checked, personsNum, (string)commonText[0], (int)commonText[1], (double)commonText[2]);
                ReqUpdateMethod(newTrailer, IndexInListView);
                this.Close();
            }
        }

        private void chkbxIsResidential_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxIsResidential.Checked)
            {
                txtPersonsNum.Enabled = true;
                txtMaxWeightCapacity.Enabled = false;
            }
            else
            {
                txtPersonsNum.Enabled = false;
                txtMaxWeightCapacity.Enabled = true;
            }
        }
    }
}
