using CalculateCalories.ORM;
using System.Data;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class DetailedForm : Form
    {
        public DetailedForm() {
            InitializeComponent();
        }

        private void DetailedForm_Load(object sender, System.EventArgs e) {
            // ORMBase.DMLDatas data = new ORMBase.DMLDatas() { opType = ORMBase.OperationType.SELECT };
            
            dataGridView1.DataSource = ORMBase.Instance.GetPivotTable();
        }
    }
}
