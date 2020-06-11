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
    public partial class BicycleForm : Form
    {
        MainForm.UpdateMethod ReqUpdateMethod;
        int IndexInListView;
        public BicycleForm(MainForm.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string typeStr in Enum.GetNames(typeof(Bicycle.BrakeType)))
            {
                cmbBrakeType.Items.Add(typeStr);
            }

            if (obj != null)
            {
                txtName.Text = (obj as Bicycle).Name;
                txtWheelsNum.Text = (obj as Bicycle).WheelsNum.ToString();
                txtPrice.Text = (obj as Bicycle).Price.ToString();
                txtGearsNum.Text = (obj as Bicycle).GearsNum.ToString();
                txtWheelDiam.Text = (obj as Bicycle).WheelsDiameter.ToString();
                cmbBrakeType.SelectedItem = (obj as Bicycle).brakeType.ToString();
            }

            ReqUpdateMethod = method;
            IndexInListView = index;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {            
            if(cmbBrakeType.SelectedIndex < 0 )
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            int gearsNum;
            int wheelDiam;
            Bicycle.BrakeType brakeType;

            try
            {
                gearsNum = Int32.Parse(txtGearsNum.Text);
                wheelDiam = Int32.Parse(txtWheelDiam.Text);
                brakeType = (Bicycle.BrakeType)Enum.Parse(typeof(Bicycle.BrakeType), cmbBrakeType.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                return;
            }

            object[] CommonText = MainForm.CheckNGetCommonData(txtName, txtWheelsNum, txtPrice);
            if (CommonText != null)
            {
                Bicycle newBicycle = new Bicycle(gearsNum, wheelDiam, brakeType, (string)CommonText[0], (int)CommonText[1], (double)CommonText[2]);
                ReqUpdateMethod(newBicycle, IndexInListView);
                this.Close();
            }
        }
    }
}
