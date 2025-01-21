using Shuler_MasterPol.Models;
using Shuler_MasterPol.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuler_MasterPol.AppForms
{

    public partial class HistoryForm : ParentForm
    {
        private Partner _partners;
        public HistoryForm(Partner partners)
        {
            InitializeComponent();
            _partners = partners;
            UserExperienceManager.SetTitle(this, $"История продаж компании \"{_partners.PartnerName}\"");
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shuler_MasterPolDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.shuler_MasterPolDataSet.Product);

             partnerProductBindingSource.DataSource = Program.context.PartnerProduct.
                Where(p=>p.PartnerId==_partners.IdPartner).OrderByDescending(p=>p.Date).ToList();

            UserExperienceManager.CustomizeControls(splitContainer.Panel1.Controls);
        }

    }
}
