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
    public partial class LightCarForm : Form
    {
        MainForm.UpdateMethod ReqUpdateMethod;
        int IndexInListView;
        public LightCarForm(MainForm.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();

            foreach (string typeStr in Enum.GetNames(typeof(LightCar.TMark)))
            {
                cmbMark.Items.Add(typeStr);
            }

            if (obj != null)
            {
                txtName.Text = (obj as LightCar).Name;
                txtWheelsNum.Text = (obj as LightCar).WheelsNum.ToString();
                txtPrice.Text = (obj as LightCar).Price.ToString();
                txtEnginePower.Text = (obj as LightCar).EnginePower.ToString();
                txtMaxSpeed.Text = (obj as LightCar).MaxSpeed.ToString();
                txtReleaseYear.Text = (obj as LightCar).ReleaseYear.ToString();
                cmbMark.SelectedItem = (obj as LightCar).mark;
                txtPassengersNum.Text = (obj as LightCar).PassengersNum.ToString();
            }

            ReqUpdateMethod = method;
            IndexInListView = index;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int passengersNum;
            try
            {
                
                passengersNum = Int32.Parse(txtPassengersNum.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                return;
            }

            LightCar.TMark mark;
            if (cmbMark.SelectedIndex < 0)
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            mark = (LightCar.TMark)Enum.Parse(typeof(LightCar.TMark), cmbMark.SelectedItem.ToString());

            object[] CarCommonData = MainForm.CheckNGetCarCommonData(txtEnginePower, txtMaxSpeed, txtReleaseYear);
            object[] commonData = MainForm.CheckNGetCommonData(txtName, txtWheelsNum, txtPrice);
            if (CarCommonData != null && commonData != null)
            {
                LightCar newLightCar = new LightCar(mark, passengersNum,
                    (int)CarCommonData[0], (int)CarCommonData[1], (int)CarCommonData[2], (string)commonData[0], (int)commonData[1], (double)commonData[2]);
                ReqUpdateMethod(newLightCar, IndexInListView);
                this.Close();
            }
        }
    }
}
