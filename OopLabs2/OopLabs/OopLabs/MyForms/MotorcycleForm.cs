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
    public partial class MotorcycleForm : Form
    {
        MainForm.UpdateMethod ReqUpdateMethod;
        int IndexInListView;
        public MotorcycleForm(MainForm.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();

            foreach (string typeStr in Enum.GetNames(typeof(Motorcycle.TMark)))
            {
                cmbMark.Items.Add(typeStr);
            }

            foreach (string typeStr in Enum.GetNames(typeof(Motorcycle.TShellType)))
            {
                cmbShellType.Items.Add(typeStr);
            }

            if (obj != null)
            {
                txtName.Text = (obj as Motorcycle).Name;
                txtWheelsNum.Text = (obj as Motorcycle).WheelsNum.ToString();
                txtPrice.Text = (obj as Motorcycle).Price.ToString();
                txtEnginePower.Text = (obj as Motorcycle).EnginePower.ToString();
                txtMaxSpeed.Text = (obj as Motorcycle).MaxSpeed.ToString();
                txtReleaseDate.Text = (obj as Motorcycle).ReleaseYear.ToString();
                cmbMark.SelectedItem = (obj as Motorcycle).mark.ToString();
                cmbShellType.SelectedItem = (obj as Motorcycle).shellType.ToString();
                chkbxCanHavePram.Checked = (obj as Motorcycle).CanHavePram;
            }

            ReqUpdateMethod = method;
            IndexInListView = index;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Motorcycle.TMark mark;
            Motorcycle.TShellType shellType;
            bool canHavePram;

            if(cmbMark.SelectedIndex >= 0 && cmbShellType.SelectedIndex >= 0)
            {
                mark = (Motorcycle.TMark)Enum.Parse(typeof(Motorcycle.TMark), cmbMark.SelectedItem.ToString());
                shellType = (Motorcycle.TShellType)Enum.Parse(typeof(Motorcycle.TShellType), cmbShellType.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            canHavePram = chkbxCanHavePram.Checked;
            object[] CarCommonData = MainForm.CheckNGetCarCommonData(txtEnginePower, txtMaxSpeed, txtReleaseDate);
            object[] commonData = MainForm.CheckNGetCommonData(txtName, txtWheelsNum, txtPrice);
            if (CarCommonData != null && commonData != null)
            {
                Motorcycle newMoto = new Motorcycle(mark, shellType, canHavePram,
                    (int)CarCommonData[0], (int)CarCommonData[1], (int)CarCommonData[2], (string)commonData[0], (int)commonData[1], (double)commonData[2]);
                ReqUpdateMethod(newMoto, IndexInListView);
                this.Close();
            }
        }
    }
}
