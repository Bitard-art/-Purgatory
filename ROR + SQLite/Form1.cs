using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROR
{
    public partial class Form1 : Form
    {
        private List<DATA.User> _list;

        public Form1()
        {
            InitializeComponent();

            _list = new List<DATA.User>();
            bsUser.DataSource = _list;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Обновить_Click(object sender, EventArgs e)
        {
            _list.Clear();

            List<DATA.User> list = DATA.SQLite_помошничек.GetUsers();
            if(list != null && list.Count > 0)
            {
                _list.AddRange(list);
                bsUser.ResetBindings(false);
            }
        }
    }
}
