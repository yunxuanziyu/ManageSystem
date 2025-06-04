using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.DataManage.Model;
using ManageSystem.BusinessManage.Service;
using ManageSystem.Extensions;
using static ManageSystem.ControlX.ComboBoxX;

namespace ManageSystem.UIDesign
{
    public partial class UCEnumDefine: UCBaseControl
    {
        private string _CurrentEditEnumType = "";
        Extensions.List<(string, string)> enums = null;
        public UCEnumDefine()
        {
            InitializeComponent();
        }

        private void buttonXSearch_Click(object sender, EventArgs e)
        {
            listViewEx1.Items.Clear();
            enums.Where(x=>x.Item1.Contains(textBoxExType.Text) || x.Item2.Contains(textBoxExType.Text))
                .ToList().ForEach(item => listViewEx1.Items.Add(new ListViewItem($"[{item.Item1}]{item.Item2}", item.Item1)));
        }

        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewEx1.SelectedItems.Count == 0) return;
                (string, string) item = enums.Find(x => x.Item1 == listViewEx1.SelectedItems[0].ImageKey);
                textBoxExEnumType.Text = item.Item1;
                textBoxExTypeName.Text = item.Item2;
                _CurrentEditEnumType = listViewEx1.SelectedItems[0].ImageKey;
                _ = ShowEnumDetail(_CurrentEditEnumType);
            }
            catch { }
        }
        private async Task ShowEnumDetail(string Type)
        {
            using (var enumService = new EnumerationService())
            {
                var enumDetail = await enumService.GetEnumerationByType(Type);
                dataGridViewX1.DataSource = enumDetail;
            }
        }

        private void buttonXSave_Click(object sender, EventArgs e)
        {
            try
            {
                string type = textBoxExEnumType.Text;
                string name = textBoxExTypeName.Text;
                if ((enums.Where(x => x.Item1 == type && x.Item2 != name).ToList().Count > 0) ||
                    enums.Where(x => x.Item2 == name && x.Item1 != type).ToList().Count > 0)
                {
                    MessageForm.ShowErrorMessage("存在相同的枚举类型(类型名称),但类型名称(枚举类型)不同的枚举类,请重新输入！");
                    return;
                }
                if (!enums.Contains((type, name)))
                {
                    enums.Add((type, name));
                    listViewEx1.Items.Add(new ListViewItem($"[{type}]{name}", type));
                }
                var enumList = dataGridViewX1.DataSource as List<Enumeration> ?? new List<Enumeration>();
                var data = enumList?.Where(x => x.Value == textBoxExValue.Text).FirstOrDefault();
                if (data == null)
                    data = enumList.CreateNewEntity();
                else
                    data.EditState = EnumEditState.eUpdate;
                ucBaseControlDetail.ReadData<Enumeration>(data, ucBaseControlDetail);
                using (var enumService = new EnumerationService())
                {
                    _ = enumService.Update(data);
                }
                _ = ShowEnumDetail(_CurrentEditEnumType);
                textBoxExValue.Text = textBoxExName.Text = textBoxExDescription.Text = "";
            }catch { }
        }

        private void UCEnumDefine_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEnumDetail();
                comboBoxXStates.DisplayMember = "DisplayName";
                comboBoxXStates.ValueMember = "Value";
                comboBoxXStates.Items.Add(new ItemNode() { Name = "有效", Value = 1 });
                comboBoxXStates.Items.Add(new ItemNode() { Name = "无效", Value = 0 });
            }
            catch { }
        }

        private void LoadEnumDetail()
        {
            using (var enumService = new EnumerationService())
            {
                enums = enumService.GetTypesWithName(textBoxExType.Text).Result;
                listViewEx1.Columns.Add("枚举类型", listViewEx1.Width);
                enums.ForEach(item => listViewEx1.Items.Add(new ListViewItem($"[{item.Item1}]{item.Item2}", item.Item1)));
            }
        }

        private void dataGridViewX1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WriteData()
        {
            ucBaseControlDetail.WriteData<Enumeration>(dataGridViewX1.CurrentRow.DataBoundItem as Enumeration, ucBaseControlDetail);
        }
    }
}
