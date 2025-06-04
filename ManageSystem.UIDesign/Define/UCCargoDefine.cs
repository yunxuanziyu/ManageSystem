using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.DataManage.Model;
using ManageSystem.BusinessManage;
using ManageSystem.Extensions;
using DevComponents.DotNetBar.Controls;

namespace ManageSystem.UIDesign
{
    public partial class UCCargoDefine: UCBaseControl
    {
        List<Cargo> cargos = new List<Cargo>();
        public UCCargoDefine()
        {
            InitializeComponent();
        }

        private void UCCargoDefine_Load(object sender, EventArgs e)
        {

        }

        private void buttonXSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cargoService = new CargoService())
                {
                    _ = cargoService.SaveCargos(cargos);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            if (cargos.Where(x => x.Code == textBoxExCode.Text).Count() > 0)
            {
                MessageForm.ShowErrorMessage("该[货物编码]列表中已存在，请重新输入！");
                return;
            }
            using (var cargoService = new CargoService())
            {
                var lst = cargoService.GetCargoList(textBoxExCode.Text).Result;
                if (lst.Count > 0)
                {
                    MessageForm.ShowErrorMessage("该[货物编码]数据库中已存在，请重新输入！");
                    return;
                }
            }
            var cargo = cargos.CreateNewEntity();
            ucBaseControl1.ReadData<Cargo>(cargo);
            dataGridViewX1.DataSource = new BindingList<Cargo>(cargos);
            ClearText();
        }

        private bool Valildate()
        {
            return true;
        }

        private void ClearText()
        {
            textBoxExCode.Text = "";
            textBoxExName.Text = "";
            textBoxExAliasName.Text = "";
            textBoxExUnit.Text = "";
            doubleInputXUnitPrice.ValueObject = null;
            textBoxExSpecifications.Text = "";
        }
    }
}
