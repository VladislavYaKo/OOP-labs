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

    public partial class TrackForm : Form
    {
        MainForm.UpdateMethod ReqUpdateMethod;
        int IndexInListView;
        public TrackForm(MainForm.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();

            foreach (string typeStr in Enum.GetNames(typeof(Track.TMark)))
            {
                cmbMark.Items.Add(typeStr);
            }

            foreach(CatalogItem curCatalogItem in MainForm.Catalog)
            {
                if (curCatalogItem.Category == CatalogItem.TCategories.Trailer)
                    cmbTrailer.Items.Add(curCatalogItem.Name);
            }

            cmbTrailer.Enabled = false;
            txtMaxWeightCarrying.Enabled = false;

            if (obj != null)
            {
                txtName.Text = (obj as Track).Name;
                txtWheelsNum.Text = (obj as Track).WheelsNum.ToString();
                txtPrice.Text = (obj as Track).Price.ToString();
                txtEnginePower.Text = (obj as Track).EnginePower.ToString();
                txtMaxSpeed.Text = (obj as Track).MaxSpeed.ToString();
                txtReleaseDate.Text = (obj as Track).ReleaseYear.ToString();
                cmbMark.SelectedItem = (obj as Track).mark.ToString();
                chkbxHasTrailer.Checked = (obj as Track).HasTrailer;
                if (chkbxHasTrailer.Checked)
                {
                    cmbTrailer.Enabled = true;
                    txtMaxWeightCarrying.Enabled = true;
                    cmbTrailer.SelectedItem = (obj as Track).trailer.Name;
                    txtMaxWeightCarrying.Text = (obj as Track).MaxWeightCarrying.ToString();
                }
            }

            ReqUpdateMethod = method;
            IndexInListView = index;
        }

        private void chkbxHasTrailer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxHasTrailer.Checked)
            {
                cmbTrailer.Enabled = true;
                txtMaxWeightCarrying.Enabled = true;
            }
            else
            {
                cmbTrailer.Enabled = false;
                txtMaxWeightCarrying.Enabled = false;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Track.TMark mark;
            bool hasTrailer;
            Trailer trailer = null;
            int maxWeightCarrying = 0;
            if (cmbMark.SelectedIndex < 0)
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            else
                mark = (Track.TMark)Enum.Parse(typeof(Track.TMark), cmbMark.SelectedItem.ToString());

            hasTrailer = chkbxHasTrailer.Checked;
            if(hasTrailer)
            {
                try
                {
                    maxWeightCarrying = Int32.Parse(txtMaxWeightCarrying.Text);
                }
                catch
                {
                    MessageBox.Show("введите корректные данные");
                    return;
                }

                if (cmbTrailer.SelectedIndex < 0)
                {
                    MessageBox.Show("Введите все данные");
                    return;
                }
                else
                    trailer = (Trailer)MainForm.Catalog.Find(x => x.Name == cmbTrailer.SelectedItem.ToString() &&
                                                             x.Category == CatalogItem.TCategories.Trailer);                    
            }

            object[] CarCommonData = MainForm.CheckNGetCarCommonData(txtEnginePower, txtMaxSpeed, txtReleaseDate);
            object[] commonData = MainForm.CheckNGetCommonData(txtName, txtWheelsNum, txtPrice);
            if (CarCommonData != null && commonData != null)
            {
                Track newTrack = new Track(mark, hasTrailer, trailer, maxWeightCarrying,
                    (int)CarCommonData[0], (int)CarCommonData[1], (int)CarCommonData[2], (string)commonData[0], (int)commonData[1], (double)commonData[2]);
                ReqUpdateMethod(newTrack, IndexInListView);
                this.Close();
            }
        }
    }
}
