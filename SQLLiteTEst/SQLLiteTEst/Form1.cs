using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
namespace SQLLiteTEst
{
    public partial class Form1 : Form
    {
        SQLiteConnection _Con;
        SQLiteDataAdapter _adp;
        SQLiteCommand _cmd;
        DataSet _DS;
        string SQLQUERY = @"";
        public Form1()
        {
            InitializeComponent();
            _DS = new DataSet();
            _Con = new SQLiteConnection("Data Source=_TestDb.sqlite;Version=3;");
            _cmd = new SQLiteCommand();

        }
        void GetPersonList()
        {
            _Con.Open();
            _adp = new SQLiteDataAdapter("Select PersonID,PersonFirstName,PersonLastName,datetime('now','localtime') as TarihSaat from PersonTBL", _Con);
            _DS.Clear();//
            _adp.Fill(_DS, "PersonTBL");
            _Con.Close();
            dataGridView1.DataSource = _DS;
            dataGridView1.DataMember = "PersonTBL";

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("_TestDb.sqllite"))//File(Dosyanın Olup olmadığını Kontrol Ediyor.
            {
                SQLiteConnection.CreateFile("_TestDb.sqllite");//Eğer Yoksa Oluşturyor
                SQLQUERY = @"Create Table PersonTBL(
                                  PersonID INTEGER PRIMARY KEY  AUTOINCREMENT ,
                                  PersonFirstName TEXT NOT NULL,
                                  PersonLastName TEXT NOT NULL
                                  );";//Table Oluşturuyor Yenide
                _Con.Open();
                _cmd = new SQLiteCommand(SQLQUERY, _Con);//Gerekli işlemler
                _cmd.ExecuteNonQuery();
                _Con.Close();
            }
            else
            {
            }
        }

        private void btn_PersonelInsert_Click(object sender, EventArgs e)
        {
            try
            {

                SQLQUERY = @"Insert Into PersonTBL(PersonFirstName,PersonLastName) Values (@PersonFirstName,@PersonLastName)";
                _Con.Open();
                _cmd.Connection = _Con;
                _cmd.CommandText = SQLQUERY;
                _cmd.CommandType = CommandType.Text;
                _cmd.Parameters.Add(new SQLiteParameter("@PersonFirstName", txt_PersonelName.Text));
                _cmd.Parameters.Add(new SQLiteParameter("@PersonLastName", txt_PersonelSoyadi.Text));
                int TaskResult = _cmd.ExecuteNonQuery();


                _Con.Close();
                if (TaskResult >= 1)
                {
                    GetPersonList();
                }
                else
                {
                    MessageBox.Show("fdsfs");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
    }
}