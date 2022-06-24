using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

using System.Data.SqlClient;

 

namespace Project_BD

{

    public partial class Form1 : Form

    {

        private SqlConnection cn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            fillList(0);
            fillVehicDataGrid("s");
            fillcboUserNif();
            fillcboVehicleReg();
            fillcboMechanicNif();
            fillInterventionDataGrid();
            fillUserAccountData("id");
        }



        private SqlConnection getSGBDConnection()
        { 
            // return new SqlConnection("data source= LAPTOP-HKP95RSI\\SQLEXPRESS;integrated security=true;initial catalog=MYTRANSPORT");
            return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER, 8101; Initial Catalog = p6g6; User ID = p6g6; Password = ThiagoeZeS2");

        }


        private void fillVehicDataGrid(string vType)
        {

            string vehicQuery = "SELECT * FROM VEICULO";

            /*
            v = Generic Vehicle
            s = Scooter
            p = Patinete
            b = Bike
            */

            if (vType == "s")
            {
                vehicQuery = "SELECT * FROM SCOOTER;";
            }
            else if (vType == "p")
            {
                vehicQuery = "SELECT * FROM PATINETE;";
            }
            else if (vType == "b")
            {
                vehicQuery = "SELECT * FROM BIKE;";
            }


            cn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(vehicQuery, cn);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);


            dgv1.DataSource = dtbl;

            cn.Close();

        }


        private void fillUserAccountData(string uasortType)
        {

            string uaQuery = "SELECT * FROM user_account;";

            /*
            nome
            id
            nif
            */



            if (uasortType == "nome")
            {
                uaQuery = "SELECT * FROM user_account order by nome;";
            }
            else if (uasortType == "id")
            {
                uaQuery = "SELECT * FROM user_account order by id_conta";
            }
            else if (uasortType == "nif")
            {
                uaQuery = "SELECT * FROM user_account order by nif_usuario";
            }


            cn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(uaQuery, cn);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);


            dttUsAcc.DataSource = dtbl;

            cn.Close();
        }

        private void fillInterventionDataGrid()
        {
            string intervQuery = "SELECT * FROM INTERVENCOES;"; 

            cn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(intervQuery, cn);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);


            dtgInterv.DataSource = dtbl;

            cn.Close();
        }


        private void fillList(int listOrder)
        {

            string queryString = "select nome from usuario order by nome";

            if (listOrder == 1)
            {
                queryString = "select nome from usuario order by nome desc ;";
            }


            SqlCommand cmd = new SqlCommand(queryString, cn);

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            
            lb1.Items.Clear();
            while (reader.Read())
            {
                lb1.Items.Add(String.Format("{0}",
                    reader[0]));
            }
            lb1.Refresh();

            cn.Close();


        }




        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            else if (txbName.Text.Length > 15)
            {
                MessageBox.Show("Name must not exceeed 15 characters");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbNif.Text))
            {
                MessageBox.Show("NIF field is empty");
                return;
            }
            else if (txbNif.Text.Length != 9)
            {
                MessageBox.Show("NIF must have 9 numbers");
                return;
            }


            string gender = "";
            if (rdbM.Checked)
                gender = "M";
            else if (rdbF.Checked)
                gender = "F";
            else if (rdbNot.Checked)
                gender = "N";
            else
            {
                MessageBox.Show("Please select a Gender");
                return;
            }


            MessageBox.Show($"ADDED Usuario\nName: {txbName.Text} \nNif: {txbNif.Text}\n" +
                $"Date of Birth: {dtpUsuario.Value.ToShortDateString()}\n" +
                $"Gender: {gender}");


            /////////////////////////////////////


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queryString = 
                "INSERT INTO Usuario (NIF, Nome, Sexo, Data_Nasc)" +
                $"VALUES ({txbNif.Text}, \'{txbName.Text}\', \'{gender}\', " +
                $"DATEADD(year, 0, \'{dtpUsuario.Value.Year}/{dtpUsuario.Value.Month}/{dtpUsuario.Value.Day}\'))";

            System.Diagnostics.Debug.WriteLine(queryString);

            command = new SqlCommand(queryString, cn);

            cn.Open();

            adapter.InsertCommand = new SqlCommand(queryString, cn);
            adapter.InsertCommand.ExecuteNonQuery();

            System.Diagnostics.Debug.WriteLine("ABRIU A CONNECTION E FEZ INSERT");

            command.Dispose();
            cn.Close();

            fillList(0);


            /////////////////////////////////////////////

        }


        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSort.Text == "Reverse name")
            {
                fillList(1);
            }

            if (cboSort.Text == "Name")
            {
                fillList(0);
            }

        }

        private void cboVtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVtype.Text == "Bike")
            {
                fillVehicDataGrid("b");
            }
            else if (cboVtype.Text == "Scooter")
            {
                fillVehicDataGrid("s");
            }
            else if (cboVtype.Text == "Patinete")
            {
                fillVehicDataGrid("p");
            }
            else if (cboVtype.Text == "Vehicle")
            {
                fillVehicDataGrid("v");
            }

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtbMatricula.Text))
            {
                MessageBox.Show("Matricula field is empty");
                return;
            }
            else if (!int.TryParse(txtbMatricula.Text, out int n))
            {
                MessageBox.Show("Matricula must be a numeric value");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtbKm.Text))
            {
                MessageBox.Show("KM field is empty");
                return;
            }
            else if (!int.TryParse(txtbKm.Text, out int n2))
            {
                MessageBox.Show("Km must be a numeric value");
                return;
            }


            string typeVehicle = "";
            if (rbtHonda.Checked)
                typeVehicle = "Honda";
            else if (rbtNissan.Checked)
                typeVehicle = "Nissan";
            else if (rbtFiat.Checked)
                typeVehicle = "Fiat";
            else
            {
                MessageBox.Show("Please select a Vehicle Type");
                return;
            }




            //////////   INSERT   /////////////

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queryString =
                "INSERT INTO VEICULO (NOME, Matricula, KM)" +
                $"VALUES (\'{typeVehicle.ToUpper()}\', {txtbMatricula.Text}, {txtbKm.Text})";


            System.Diagnostics.Debug.WriteLine(queryString);

            command = new SqlCommand(queryString, cn);

            cn.Open();

            adapter.InsertCommand = new SqlCommand(queryString, cn);
            adapter.InsertCommand.ExecuteNonQuery();

            System.Diagnostics.Debug.WriteLine("ABRIU A CONNECTION E FEZ INSERT");

            MessageBox.Show($"ADDED Vehicle\nMatricula: {txtbMatricula.Text} \nKm: {txtbKm.Text}\n" +
                $"Type: {typeVehicle}");

            command.Dispose();
            cn.Close();


        }


        private void btnNifDelete_Click(object sender, EventArgs e)
        {
            string userNif = txtbNifDelete.Text;


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queryString =

                $"DELETE FROM USUARIO WHERE NIF={userNif};";


            System.Diagnostics.Debug.WriteLine(queryString);

            command = new SqlCommand(queryString, cn);

            cn.Open();

            adapter.InsertCommand = new SqlCommand(queryString, cn);
            int queryReturn = adapter.InsertCommand.ExecuteNonQuery();

            System.Diagnostics.Debug.WriteLine("ABRIU A CONNECTION E FEZ INSERT");

            MessageBox.Show($"Rows affected {queryReturn}");

            command.Dispose();
            cn.Close();

        }


        private void fillcboUserNif()
        {

            string queryString = "select nif from usuario;";

            SqlCommand cmd = new SqlCommand(queryString, cn);

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            cboUserNif.Items.Clear();
            while (reader.Read())
            {
                cboUserNif.Items.Add(String.Format("{0}",
                    reader[0]));
            }
            cboUserNif.Refresh();

            cn.Close();


        }


        private void fillcboMechanicNif()
        {

            string queryString = "select nif from mecanico;";

            SqlCommand cmd = new SqlCommand(queryString, cn);

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            cboNifMecanico.Items.Clear();
            while (reader.Read())
            {
                cboNifMecanico.Items.Add(String.Format("{0}",
                    reader[0]));
            }
            cboNifMecanico.Refresh();

            cn.Close();


        }


        private void fillcboVehicleReg()
        {

            string queryString = "select matricula from veiculo;";

            SqlCommand cmd = new SqlCommand(queryString, cn);

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            cboVehicleReg.Items.Clear();
            cboVehicleReg2.Items.Clear();
            while (reader.Read())
            {
                cboVehicleReg.Items.Add(String.Format("{0}",
                    reader[0]));
                cboVehicleReg2.Items.Add(String.Format("{0}",
                    reader[0]));
            }
            cboVehicleReg.Refresh();
            cboVehicleReg2.Refresh();

            cn.Close();


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            string VehicleReg = cboVehicleReg.Text;
            string userNif = cboUserNif.Text;


            if (string.IsNullOrEmpty(VehicleReg))
            {
                MessageBox.Show("Please select Vehicle");
                return;
            }
            else if (string.IsNullOrEmpty(userNif))
            {
                MessageBox.Show("Please select User NIF");
                return;
            }


            // GET PEDIDOS

            string queryString = "select top 1 id from pedido order by id desc;";

            SqlCommand cmd = new SqlCommand(queryString, cn);

            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string lastPedido = reader.GetValue(0).ToString();
            cn.Close();
            ///////// end GET PEDIDOS


            /// GET User Account

            string queryString2 = $"SELECT ID_CONTA FROM CONTA WHERE NIF_USUARIO = {userNif};";
            System.Diagnostics.Debug.WriteLine($"NIF DO USUARIO: {userNif}");

            SqlCommand cmd2 = new SqlCommand(queryString2, cn);

            cn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            string userAccountId = reader2.GetValue(0).ToString();
            cn.Close();


            ///////// end GET User Account


            // INSERT INTO PEDIDO(ID, DESCRICAO, DATA_P, ID_CONTA, MATRICULA)
            // VALUES(366669, 'BLABALLBAL', GETDATE(), 66666999, 454545);

            int newId = int.Parse(lastPedido) + 1;

            string queryString3 =
                "INSERT INTO PEDIDO (ID, DESCRICAO, ID_CONTA, MATRICULA)" +
                $" VALUES ({newId}, \'{txtbDescription.Text} \', {userAccountId}, {VehicleReg})";


            SqlCommand command = new SqlCommand(queryString3, cn);
            try
            {
                cn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("INSERIO O PEDIDO:\nID " + newId);
                cn.Close();
            }
            catch (SqlException err)
            {
                System.Diagnostics.Debug.WriteLine("ERROR DETAILS: " + e.ToString());
            }

            // MessageBox.Show($"ADDED Vehicle\nMatricula: {txtbMatricula.Text} \nKm: {txtbKm.Text}\n" +
            //    $"Type: {typeVehicle}");

        }



        private void btnRegMechanic_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbNameMechanic.Text))
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            else if (txbName.Text.Length > 15)
            {
                MessageBox.Show("Name must not exceeed 15 characters");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtbNifMechanic.Text))
            {
                MessageBox.Show("NIF field is empty");
                return;
            }
            else if (txtbNifMechanic.Text.Length != 9)
            {
                MessageBox.Show("NIF must have 9 numbers");
                return;
            }
            else if (!int.TryParse(txtbNifMechanic.Text, out int n2))
            {
                MessageBox.Show("NIF must be a numeric value");
                return;
            }


            string gender = "";
            if (rdoMMechanic.Checked)
                gender = "M";
            else if (rdoFMechanic.Checked)
                gender = "F";
            else if (rdoOMechanic.Checked)
                gender = "O";
            else
            {
                MessageBox.Show("Please select a Gender");
                return;
            }




            /////////////////////////////////////


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queryString =
                "INSERT INTO MECANICO (NIF, Nome, Sexo, Data_Nasc)" +
                $"VALUES ({txtbNifMechanic.Text}, \'{txtbNameMechanic.Text}\', \'{gender}\', " +
                $"DATEADD(year, 0, \'{dttMechanic.Value.Year}/{dttMechanic.Value.Month}/{dttMechanic.Value.Day}\'))";

            System.Diagnostics.Debug.WriteLine(queryString);

            command = new SqlCommand(queryString, cn);

            cn.Open();

            adapter.InsertCommand = new SqlCommand(queryString, cn);
            adapter.InsertCommand.ExecuteNonQuery();

            System.Diagnostics.Debug.WriteLine("ABRIU A CONNECTION E FEZ INSERT");

            MessageBox.Show($"ADDED Mecanico\nName: {txtbNameMechanic.Text} \nNif: {txtbNifMechanic.Text}\n" +
                $"Date of Birth: {dttMechanic.Value.ToShortDateString()}\n" +
                $"Gender: {gender}");

            command.Dispose();
            cn.Close();


            /////////////////////////////////////////////

        }

        private void btnRequestInterv_Click(object sender, EventArgs e)
        {
            string VehicleReg = cboVehicleReg2.Text;
            string mecanicoNif = cboNifMecanico.Text;


            if (string.IsNullOrEmpty(VehicleReg))
            {
                MessageBox.Show("Please select Vehicle");
                return;
            }
            else if (string.IsNullOrEmpty(mecanicoNif))
            {
                MessageBox.Show("Please select Mecanico NIF");
                return;
            }

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("addInterven", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = 
                cmd.Parameters.AddWithValue("@MATRI_VEI", SqlDbType.Int).Value = VehicleReg;
                cmd.Parameters.AddWithValue("@MECA_NIF", SqlDbType.Int).Value = mecanicoNif;
                cmd.Parameters.AddWithValue("@DESCRI", SqlDbType.VarChar).Value = txtbDescriptionInterv.Text;
                Random rnd = new Random();
                cmd.Parameters.AddWithValue("@PRECO", SqlDbType.Decimal).Value = rnd.Next(8,250);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention SP runned");
                cn.Close();
            }
            catch(SqlException err)
            {
                System.Diagnostics.Debug.WriteLine("ERROR DETAILS: " + e.ToString());
                MessageBox.Show("ERROR DETAILS: " + err.ToString());
            }


            // GET PEDIDOS

            //string queryString = "select top 1 id from intervencoes order by id desc;";

            //SqlCommand cmd = new SqlCommand(queryString, cn);

            //cn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read();
            //string lastInterv = reader.GetValue(0).ToString();
            //cn.Close();
            ///////// end GET PEDIDOS


            // INSERT INTO INTERVENCOES(ID, MATRI_VEICULO, MECA_NIF, PRECO, DESCRICAO, DATA_INTERVENCAO) 
            // VALUES(16, 120168816, 29112336, 44, 'Motor quebrado', GETDATE());

            //int newInterv = int.Parse(lastInterv) + 1;

            //Random rnd = new Random();

            //string queryString3 =
            //    "INSERT INTO INTERVENCOES (ID, MATRI_VEICULO, MECA_NIF, PRECO, DESCRICAO, DATA_INTERVENCAO)" +
            //    $" VALUES ({newInterv}, {VehicleReg}, {mecanicoNif}, {rnd.Next(8, 280)}, {txtbDescriptionInterv.Text}, GETDATE())";


            //SqlCommand command = new SqlCommand(queryString3, cn);
            //cn.Open();
            //command.ExecuteNonQuery();
            //try
            //{
            //    MessageBox.Show("INSERIU A INTERVENCAO:\nID " + newInterv);
            //    cn.Close();
            //}
            //catch (SqlException err)
            //{
            //    System.Diagnostics.Debug.WriteLine("ERROR DETAILS: " + e.ToString());
            //    MessageBox.Show("ERROR DETAILS: " + e.ToString());
            //}

            // MessageBox.Show($"ADDED Vehicle\nMatricula: {txtbMatricula.Text} \nKm: {txtbKm.Text}\n" +
            //    $"Type: {typeVehicle}");

        }

        private void cboSortUsAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSortUsAcc.Text == "Nome")
            {
                fillUserAccountData("nome");
            }
            else if (cboSortUsAcc.Text == "Account ID")
            {
                fillUserAccountData("id");
            }
            else if (cboSortUsAcc.Text == "NIF")
            {
                fillUserAccountData("nif");
            }
        }
    }



        //private bool verifySGBDConnection()
        //{
        //    if (cn == null)
        //        cn = getSGBDConnection();

        //    if (cn.State != ConnectionState.Open)
        //        cn.Open();

        //    return cn.State == ConnectionState.Open;
        //}


    

} 

