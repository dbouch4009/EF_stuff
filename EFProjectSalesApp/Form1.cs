using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProjectSalesApp.Data;

namespace EFProjectSalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLists();
        }

        private void cbSalesPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetLists()
        {
            //Sales contexts are not retained for the lifetime of the application - using statement
            using (var context = new SalesContext())
            {
                salesPersonBindingSource.DataSource = context.SalesPeople
                    .Where(ent => ent.IsActive)
                    .OrderBy(ent => ent.FirstName)
                    .ThenBy(ent => ent.LastName)
                    .ToList();

                salesRegionBindingSource.DataSource = context.SalesRegions
                .Where(ent => ent.IsActive)
                .OrderBy(ent => ent.Name)
                .ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var personId = (int)cbSalesPeople.SelectedValue;
            var regionId = (int)cbSalesRegion.SelectedValue;
            using (var context = new SalesContext())
            {
                salesPersonBindingSource.DataSource = context.Sales
                    .Where(ent => ent.PersonId == personId && ent.RegionId == regionId)
                    .OrderBy(s => s.Date)
                    .ToList();
            }
        }
    }
}
