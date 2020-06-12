using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginsInterface;

namespace OopLabs
{
    public partial class MainForm : Form
    {
        public static MainForm window = null;
        public static List<CatalogItem> Catalog = new List<CatalogItem>();
        public delegate void UpdateMethod(object obj, int index);

        public string[] ColNames = { "Имя", "Категория", "Количество колёс", "Цена" };
        public int[] ColWidth = { 100, 100, 150, 100 };

        private string NO_PLUGINS_PREFIX = "None";

        public static Creator[] Creators = { new BicycleCreator(), new TrailerCreator(), new LightCarCreator(), new TrackCreator(), new MotorcycleCreator()};
        public static SerializerCreator[] FileCreators = { new BinSerializerCreator(), new JsonSerializerCreator(), new TextFileCreator() };
        public MainForm()
        {
            InitializeComponent();
            window = this;
            ColumnHeader header;
            for (int i = 0; i < 4; i++)
            {
                header = new ColumnHeader();
                header.Text = ColNames[i];
                header.Width = ColWidth[i];
                lvObjects.Columns.Add(header);
            }
            lvObjects.View = View.Details;
            foreach (string i in Enum.GetNames(typeof(CatalogItem.TCategories)))
            {
                cmbChooseObjType.Items.Add(i);
            }

            saveFileDialog.Filter = "Binery file|*.bin|JSON file|*.json|Text file|*.txt";
            openFileDialog.Filter = "Binery file|*.bin|JSON file|*.json|Text file|*.txt";
        }  

        void Empty(object obj, int index)
        {

        }
        
        public static object[] CheckNGetCommonData(TextBox name, TextBox wheelsNum, TextBox price)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Введите имя");
                return null;
            }

            if (wheelsNum.Text == "")
            {
                MessageBox.Show("Введите количество колёс");
                return null;
            }

            if (price.Text == "")
            {
                MessageBox.Show("Введите цену");
                return null;
            }

            object[] objArr = new object[3];
            objArr[0] = name.Text;
            try
            {
                objArr[1] = Int32.Parse(wheelsNum.Text);
                objArr[2] = Convert.ToDouble(price.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
                return null;
            }
            return objArr;
        }

        public static object[] CheckNGetCarCommonData(TextBox enginePower, TextBox maxSpeed, TextBox releaseYear)
        {
            object[] objArr = new object[3];
            try
            {
                objArr[0] = Int32.Parse(enginePower.Text);
                objArr[1] = Int32.Parse(maxSpeed.Text);
                objArr[2] = Int32.Parse(releaseYear.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                return null;
            }

            return objArr;
        }

        public void AddObject(object Obj, int ind)
        {
            if (ind == -1)
            {
                Catalog.Add((CatalogItem)Obj);
            }
            else
            {
                Catalog.RemoveAt(ind);
                Catalog.Insert(ind, (CatalogItem)Obj);
            }
            ShowListView();
        }

        private void ShowListView()
        {
            int i = 0;
            lvObjects.Items.Clear();
            foreach (CatalogItem item in Catalog)
            {
                AddLinetoListView();
                lvObjects.Items[i].SubItems[0].Text = item.Name;
                lvObjects.Items[i].SubItems[1].Text = item.Category.ToString();
                lvObjects.Items[i].SubItems[2].Text = item.WheelsNum.ToString();
                lvObjects.Items[i].SubItems[3].Text = item.Price.ToString();
                i++;                
            }
        }

        public static void AddLinetoListView()
        {
            ListViewItem lvItem = new ListViewItem();
            for (int i = 0; i < 4; i++)
            {
                ListViewItem.ListViewSubItem lvSubItem = new ListViewItem.ListViewSubItem();
                lvItem.SubItems.Add(lvSubItem);
            }
            window.lvObjects.Items.Add(lvItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(cmbChooseObjType.SelectedIndex != -1)
            {
                Form newForm = null;
                newForm = Creators[cmbChooseObjType.SelectedIndex].Create(AddObject, newForm, -1);
                newForm.Show();
            }
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int curInd = 0;
            foreach(CatalogItem item in Catalog)
            {
                if (lvObjects.Items[curInd].Selected)
                {
                    int i = cmbChooseObjType.Items.IndexOf(lvObjects.Items[curInd].SubItems[1].Text);
                    Form lookForm = Creators[i].Create(Empty, item, curInd);
                    lookForm.Show();
                }
                curInd++;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int curInd = 0;
            foreach (CatalogItem item in Catalog)
            {
                if (lvObjects.Items[curInd].Selected)
                {
                    int i = cmbChooseObjType.Items.IndexOf(lvObjects.Items[curInd].SubItems[1].Text);
                    Form lookForm = Creators[i].Create(AddObject, item, curInd);
                    lookForm.Show();
                }
                curInd++;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int catalogCount = Catalog.Count;
            int curInd = 0;
            for (int i = 0; i <= catalogCount - 1; i++)
            {
                if (lvObjects.Items[curInd].Selected)
                {
                    Catalog.RemoveAt(curInd);
                    lvObjects.Items.RemoveAt(curInd);                    
                }
                else
                    curInd++;
            }
        }

        private void SaveFile(object obj, int index)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            byte[] data = FileCreators[saveFileDialog.FilterIndex - 1].SerializeObj(Catalog);
            
            string pluginPrefix;
            if (index > 0)
            {
                List<IPlugin> pluginsList = (List<IPlugin>)obj;
                IPlugin reqPlugin = pluginsList[index - 1];
                pluginPrefix = "(" + reqPlugin.GetType().Name + ")";
                data = reqPlugin.Compress(data).ToArray();
            }
            else
                pluginPrefix = "(" + NO_PLUGINS_PREFIX + ")";
           
            byte[] pluginPrefixBytes = Encoding.UTF8.GetBytes(pluginPrefix);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                fs.Write(pluginPrefixBytes, 0, pluginPrefixBytes.Length);
                fs.Write(data, 0, data.Length);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<IPlugin> pluginsList = PluginLoader.RefreshPlugins();
            new ChoosePluginForm(SaveFile, pluginsList);
        }


        public void OpenFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            byte[] data = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                data = new byte[(int)fs.Length];
                fs.Read(data, 0, data.Length);
            }
            List<IPlugin> pluginsList = PluginLoader.RefreshPlugins();
            string pluginName = CutPluginName(ref data);
            if (pluginName != NO_PLUGINS_PREFIX)
            {
                bool isFound = false;
                IPlugin reqPlugin = null;
                foreach (var curPlugin in pluginsList)
                {
                    string curPluginName = curPlugin.GetType().Name;    //Debug
                    if (curPlugin.GetType().Name == pluginName)
                    {
                        reqPlugin = curPlugin;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                    data = reqPlugin.Decompress(new MemoryStream(data));
                else
                { 
                    MessageBox.Show("Не найден плагин для обработки этих данных!\nТребуемый плагин: " + pluginName);
                    return;
                }
            }
            Catalog = FileCreators[openFileDialog.FilterIndex - 1].DeserializeObj(data);
            ShowListView();
        }

        private string CutPluginName(ref byte[] reqStrBytes)
        {
            string reqStr = Encoding.UTF8.GetString(reqStrBytes);
            int index0 = reqStr.IndexOf('(');
            int index1 = reqStr.IndexOf(')');
            if (index0 == -1 || index1 == -1 || index1 < index0)
                return NO_PLUGINS_PREFIX;

            string pluginName = reqStr.Substring(index0 + 1, index1 - index0 - 1);
            Array.Copy(reqStrBytes, index1 + 1, reqStrBytes, 0, reqStrBytes.Length - (index1 - index0 + 1));
            Array.Resize(ref reqStrBytes, reqStrBytes.Length - (index1 - index0 + 1));
            return pluginName;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            OpenFile();
        }
    }
}
