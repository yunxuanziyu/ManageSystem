using System;
using System.Collections.Generic;
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
            using (var cargoService = new CargoService())
            {
                _ = cargoService.SaveCargos(cargos);
            }
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            var cargo = cargos.CreateNewEntity();
            using(var cargoService = new CargoService())
            {
                var lst = cargoService.GetCargoList(textBoxExCode.Text).Result;
                if (lst.Count > 0)
                {
                    MessageForm.ShowErrorMessage("该货物代码已存在，请重新输入！");
                    return;
                }
            }
            ucBaseControl1.ReadData<Cargo>(cargo);
            dataGridViewX1.DataSource = cargos.ToDataTable();
            ClearText();
        }

        

        private void ClearText()
        {
            textBoxExCode.Text = "";
            textBoxExName.Text = "";
            textBoxExAliasName.Text = "";
            textBoxExUnit.Text = "";
            textBoxExUnitPrice.Text = "";
            textBoxExSpecifications.Text = "";
        }
    }
}
