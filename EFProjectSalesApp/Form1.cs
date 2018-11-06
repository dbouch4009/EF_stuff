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
using EFProjectSalesApp.Model_Entity;

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
            /*
            var personId = (int)cbSalesPeople.SelectedValue;
            var regionId = (int)cbSalesRegion.SelectedValue;
            using (var context = new SalesContext())
            {
                saleBindingSource.DataSource = context.Sales
                    .Where(ent => ent.PersonId == personId && ent.RegionId == regionId)
                    .OrderBy(s => s.Date)
                    .ToList();

                var sale = context.Sales.Where(sl => sl.PersonId == personId && sl.RegionId == regionId)
                                        .FirstOrDefault();


                tbAmount.Text = sale.Amount.ToString();
                tbDate.Text = sale.Date.ToString();
                tbPerson.Text = sale.Person.ToString();
                              
            }
            */

            MessageBox.Show("Wrong Button", "Caution", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTargetSales_Click(object sender, EventArgs e)
        {
            var personId = (int)cbSalesPeople.SelectedValue;
            var regionId = (int)cbSalesRegion.SelectedValue;

            using (var context = new SalesContext())
            {
                var person = context.SalesPeople.SingleOrDefault(p => p.id == personId);

                if(person != null)
                {
                    MessageBox.Show(string.Format("{0} has a target of {1}", person.FullName, person.SalesTarget));
                }
            }
        }

        private void btnTBRefresh_Click(object sender, EventArgs e)
        {
            GetSalesRefresh();
        }

        private void newSaleButton_Click(object sender, EventArgs e)
        {
            var personId = (int)cbSalesPeople.SelectedValue;
            var regionId = (int)cbSalesRegion.SelectedValue;

            var sale = new Sale
            {
                Amount = newSaleAmountUpDown.Value,
                Date = newSaleDateTimePicker.Value,
                PersonId = personId,
                RegionId = regionId
            };

            using (var context = new SalesContext())  //create context and saving
            {
                context.Sales.Add(sale);
                var result = context.SaveChanges();

                MessageBox.Show(String.Format("{0} sale created.", result));
            }
        }
        
        private void GetSalesRefresh()
        {
            var personId = (int)cbSalesPeople.SelectedValue;
            var regionId = (int)cbSalesRegion.SelectedValue;
            using (var context = new SalesContext())
            {
                var sale = context.Sales.Where(sl => sl.PersonId == personId && sl.RegionId == regionId)
                                        .FirstOrDefault();

                var salesPerson = context.SalesPeople.Where(per => per.id == sale.PersonId).FirstOrDefault();

                tbAmount.Text = sale.Amount.ToString();
                tbDate.Text = sale.Date.ToString();
                tbSaleReadID.Text = sale.id.ToString();
                if (sale.Person.Equals(null))
                {
                    sale.Person.FirstName = "Lance Bass";
                }
                else
                {
                    tbPerson.Text = sale.Person.FullName.ToString();
                }

            }
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            using (var context = new SalesContext())
            {
                var saleId = Int32.Parse(tbUpdateID.Text);
                var salesAmount = newSaleAmountUpDown.Value;

                var saleToUpdate = context.Sales.SingleOrDefault(p => p.id == saleId);

                if(salesAmount > 0)
                {
                    saleToUpdate.Amount = salesAmount;
                    context.SaveChanges();

                    GetSalesRefresh();
                }
            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            using (var context = new SalesContext())
            {
                var saleId = Int32.Parse(tbUpdateID.Text);

                var saleToDelete = context.Sales.SingleOrDefault(p => p.id == saleId);

                context.Sales.Remove(saleToDelete);
                context.SaveChanges();
                MessageBox.Show("Sale deleted", "Notice", MessageBoxButtons.OK);
            }
        }
    }
}
