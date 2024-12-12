using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Assignment5b
{

    public partial class MainForm : Form
    {
        private PersonContext _dbContext = new();
        private readonly IPersonDataSource _dataSource;

        public MainForm()
        {
            InitializeComponent();
            // You can toggle between memory and database
            _dataSource = new PersonListDataSource(); //memory list
            //_dataSource = new PersonContextDataSource(); //database 

            personDataGridView.DataSource = _dataSource.GetPeople();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            personDataGridView.DataSource = _dataSource.GetPeople();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _dataSource.SaveChanges();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void personDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
