using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IMS
{
    public partial class Frm_Quotation : Form
    {
        public Frm_Quotation()
        {
            InitializeComponent();
        }
        String Con = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        void selecttxt(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void leavetxt(TextBox txt)
        {
            txt.BackColor = Color.White;
        }
        private void Frm_Quotation_Load(object sender, EventArgs e)
        {
            pnlclose.Width = 0;
            //String c;
            //String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //String str = "Select * from T_QUOTATION_ITEM";



            //using (SqlConnection conn = new SqlConnection(ConnString))
            //{

            //    SqlCommand comm = new SqlCommand(str, conn);
            //    //comm.Connection = conn;
            //    //comm.CommandText = str;
            //    conn.Open();

            //    SqlDataReader dr = comm.ExecuteReader();
            //    while (dr.Read())
            //    {


            //        dgvitemform.Rows.Add(dr[2].ToString(),
            //           dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
            //           dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            //        dr[1].ToString();

            //        //if (dr.[1] == false)
            //        //{
            //        //    c = "E-000001";
            //        //}
            //        //else
            //        //{
            //        //    while (dr.Read())
            //        //    {
            //        //        c = Format(Mid(dr("invoid"), 2, 6) + 1, "E00000#");
            //        //    }
            //        //}

            //        //txtquotation.Text = c;
            //    }
            //    dr.Close();
            //}
            //customer_data_in();


                }
        public void customer_data_in()
        {
            //String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //String com = "Select * from T_QUOTATION";
            //using (SqlConnection conn = new SqlConnection(ConnString))
            //{
            //    SqlCommand comm = new SqlCommand(com, conn);
            //    //comm.Connection = conn;
            //    //comm.CommandText = str;
            //    conn.Open();

            //    SqlDataReader dr = comm.ExecuteReader();
            //    while (dr.Read())
            //    {

            //        txtcustomer.Text = dr[1].ToString();
            //        txt_datetime.Value = Convert.ToDateTime(dr.GetValue(2)); /*(DateTime)dr.GetValue(2);*/
            //        txt_discount.Text = dr[3].ToString();
            //        txt_total.Text = dr[4].ToString();
            //        txtcustomer.Text = dr[5].ToString();
            //        txtcustomer.Text = dr[6].ToString();
            //        user_box.Text = dr[7].ToString();

            //    }
            //    dr.Close();
            //}
            //conn.Close();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pnlclose.Width == 311)
            {
                pnlclose.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    pnlclose.Width = pnlclose.Width - 30;

                }

            }
            else
            {
                pnlclose.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    pnlclose.Width = pnlclose.Width + 30;

                }

            }
            Timer.Stop();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnlright.Visible = true;
            pnlclose.Visible = true;
            //pnlTop.Enabled = true;


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            pnlright.Visible = false;
            pnlclose.Visible = false;
            txt_clear();
            //pnlTop.Enabled = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            add_data(txt_no.Text, txt_item.Text, txt_size.Text, txt_style.Text, txt_quantity.Text, txt_rate.Text, txt_discount.Text, txt_total.Text);
            pnlright.Visible = false;
            txt_clear();
            sum_total();
            quantity_sum();
            row_add();
        }
        public void sum_total()
        {
            Double sum = 0;
            for (int i = 0; i < dgvitemform.Rows.Count; i++)
            {
                sum += Double.Parse(dgvitemform.Rows[i].Cells[7].Value.ToString());
            }
            txt_total_sum.Text = sum.ToString();
        }
        public void quantity_sum()
        {
            Double sum = 0;
            for (int i = 0; i < dgvitemform.Rows.Count; i++)
            {
                sum += Double.Parse(dgvitemform.Rows[i].Cells[4].Value.ToString());
            }
            txt_quantity_sum.Text = sum.ToString();
        }

        public void row_add()
        {

            int i = 1;
            for (int x = 0; x < dgvitemform.Rows.Count; x++)
            {
                if (txt_no.Text == string.Empty)
                {
                    txt_no.Text = i.ToString();
                }
                else
                {
                    i = i + 1;
                    txt_no.Text = i.ToString();
                }
            }

        }


        public void add_data(string row_id, string item_name, string size, string style_name, string quantity, string rate, string discount, string total)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvitemform);
            newRow.Cells[0].Value = row_id;
            newRow.Cells[1].Value = item_name;
            newRow.Cells[2].Value = size;
            newRow.Cells[3].Value = style_name;
            newRow.Cells[4].Value = quantity;
            newRow.Cells[5].Value = rate;
            newRow.Cells[6].Value = discount;
            newRow.Cells[7].Value = total;

            dgvitemform.Rows.Add(newRow);
        }
        public void txt_clear()
        {

            txt_item.Text = "";
            txt_size.Text = "";
            txt_style.Text = "";
            txt_quantity.Text = "";
            txt_rate.Text = "";
            txt_discount.Text = "";
            txt_total.Text = "";
        }
        public void clear()
        {
            txtcustomer.Text = "";
            txtaddress.Text = "";
            txtquotation.Text = "";
            user_box.Text = "";
            dgvitemform.Rows.Clear();
            txt_no.Text = "1";
            txt_total_sum.Text = "";
            txt_quantity_sum.Text = "";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";



            string StrQuery;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {

                        comm.Connection = conn;
                        conn.Open();
                        //foreach (DataGridViewRow row in dgvitemform.Rows)
                        for (int i = 0; i < dgvitemform.Rows.Count; i++)
                        {
                            StrQuery = @"INSERT INTO [T_QUOTATION_ITEM](QUOTATION_NO,ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL,ACTIVE) VALUES ("
                              + "'" + txtquotation.Text + "',"
                              + "'" + dgvitemform.Rows[i].Cells["row_id"].Value + "', "
                              + "'" + dgvitemform.Rows[i].Cells["item_name"].Value + "' ,"
                              + "'" + dgvitemform.Rows[i].Cells["size"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["style_name"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["quantity"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["rate"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["discount"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["total"].Value + "',"
                              + "'" + "1" + "')";
                            comm.CommandText = StrQuery;
                            comm.ExecuteNonQuery();


                        }
                        // MessageBox.Show("UPLOADED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                        conn.Close();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String Query;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {

                    //comm.Connection = conn;

                    Query = @"INSERT INTO [T_QUOTATION](QUOTATION_NO,QUOTATION_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME,ACTIVE) VALUES ("
                                + "'" + txtquotation.Text + "',"
                                + "'" + txt_datetime.Value.Date + "',"
                                + "'" + txt_discount.Text + "',"
                                + "'" + txt_total_sum.Text + "',"
                                + "'" + txtcustomer.Text + "',"
                                + "'" + txtaddress.Text + "',"
                                + "'" + user_box.Text + "',"
                                + "'" + "1" + "')";


                    //comm.CommandText = StrQuery;

                    SqlCommand comm = new SqlCommand(Query, conn);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                MessageBox.Show("UPLOADED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear();
        }



        private void txt_datetime_ValueChanged(object sender, EventArgs e)
        {
            //txt_datetime. = false;
        }


        private void txt_rate_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_rate.Text != "" && txt_quantity.Text != "")
            {
                txt_total.Text = Convert.ToString(Convert.ToDouble(txt_rate.Text) * (Convert.ToDouble(txt_quantity.Text)));
            }
        }

        private void txt_discount_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_rate.Text != "" && txt_discount.Text != "")
            {
                txt_total.Text = Convert.ToString((1 - (Convert.ToDouble(txt_discount.Text)) / 100.00) * (Convert.ToDouble(txt_rate.Text)));
            }
        }

        private void dgvitemform_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvitemform.Columns[e.ColumnIndex].HeaderText == "EDIT")
            {

                DialogResult done = (MessageBox.Show("Are you sure want to Edit this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (done == DialogResult.Yes)
                {




                   

                        DataGridViewRow row = this.dgvitemform.Rows[e.RowIndex];
                        //int row = dgvitemform.SelectedCells[0].RowIndex;
                        //DataGridViewRow selectedRow = dgvitemform.Rows[row];


                        txt_no.Text = row.Cells[0].Value.ToString();
                        txt_item.Text = row.Cells[1].Value.ToString();
                        txt_size.Text = row.Cells[2].Value.ToString();
                        txt_style.Text = row.Cells[3].Value.ToString();
                        txt_quantity.Text = row.Cells[4].Value.ToString();
                        txt_rate.Text = row.Cells[5].Value.ToString();
                        txt_discount.Text = row.Cells[6].Value.ToString();
                        txt_total.Text = row.Cells[7].Value.ToString();
                        //dgvitemform.Rows.RemoveAt(row);
                        //dgvitemform.Rows.Insert(row, selectedRow);
                 




                    //DataGridViewRow newRow = new DataGridViewRow();
                    //newRow.CreateCells(dgvitemform);
                    //newRow.Cells[0].Value = row_id;
                    //newRow.Cells[1].Value = item_name;
                    //newRow.Cells[2].Value = size;
                    //newRow.Cells[3].Value = style_name;
                    //newRow.Cells[4].Value = quantity;
                    //newRow.Cells[5].Value = rate;
                    //newRow.Cells[6].Value = discount;
                    //newRow.Cells[7].Value = total;

                    pnlright.Visible = true;
                    pnlright.Enabled = true;
                    pnlclose.Visible = true;





                }
                //txt_clear();

            }


            else
            {
                if (dgvitemform.Columns[e.ColumnIndex].HeaderText == "DELETE")
                {
                    DataGridViewRow selectedRow = dgvitemform.Rows[e.RowIndex];
                    DialogResult done = (MessageBox.Show(String.Format("Are you sure want to  DELETE  this record ? ", selectedRow.Cells["row_id"].Value), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (done == DialogResult.Yes)
                    {




                        String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                        using (SqlConnection conn = new SqlConnection(ConnString))
                        {
                            try
                            {
                                using (SqlCommand command = new SqlCommand("DELETE FROM T_QUOTATION_ITEM WHERE ROW_ID= @row_id", conn))
                                {
                                    conn.Open();
                                    command.Parameters.AddWithValue("@ROW_ID ", selectedRow.Cells["row_id"].Value);
                                    command.ExecuteNonQuery();

                                }
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }
                }
            }




        }

        private void pnlclose_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtquotation_TextChanged(object sender, EventArgs e)
        {
            ////BindingSource bs = new BindingSource();
            ////bs.DataSource = dgvitemform.DataSource;
            ////bs.Filter = string.Format("CONVERT(" + .Columns[].DataPropertyName + ", System.String) like '%" + txtquotation.Text.Replace("'", "''") + "%'");
            ////dgvitemform.DataSource = bs;
            //String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //String str = "Select * from T_QUOTATION_ITEM";

            //using (SqlConnection conn = new SqlConnection(ConnString))
            //{

            //    SqlCommand comm = new SqlCommand(str, conn);
            //    //comm.Connection = conn;
            //    //comm.CommandText = str;


            //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM T_QUOTATION_ITEM WHERE QUOTATION_NO LIKE '" + this.txtquotation.Text + "%'", Con);
            //    DataTable dt = new DataTable();
            //    conn.Open();
            //    //SqlDataReader dr = comm.ExecuteReader();
            //    //while (dr.Read())
            //    //{
            //    //    dr.GetString(1);

            //    //}
            //BindingSource bs = new BindingSource();
            //bs.DataSource = comm;
            //bs.Filter = "QUOTATION_NO like '%" + txtquotation.Text + "%'";
            //    //comm.ExecuteNonQuery();
            //    conn.Close();

            //    //bs.Filter = "kView like '%" + textBox1.Text + "%'";
            //    //bs.Filter = "cView like '%" + textBox1.Text + "%'";
            //    //dgvitemform.Columns.Clear();

            //(dgvitemform.DataSource as DataTable).DefaultView.RowFilter =
            //string.Format("QUOTATION_NO LIKE '{1}%' OR QUOTATION_NO LIKE '% {1}%'", txtquotation.Text);

            //    //

            //iDataTable dt = GetDataTable();
            //DataView dv = dt.DefaultView;
            //dv.Sort = "column_name DESC";
            //DataTable sortedDt = dv.ToTable();





            String c;
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String str = "SELECT QUOTATION_NO FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            //String com = "Select * from T_QUOTATION";
            String com = "SELECT QUOTATION_NO FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            try
            {


                //if (txtquotation.Text == @"SELECT QUOTATION_NO FROM T_QUOTATION WHERE @QUOTATION_NO")
                {
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {

                        SqlCommand comm = new SqlCommand(str, conn);
                        //comm.Connection = conn;
                        //comm.CommandText = str;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        //da.SelectCommand = comm;
                       
                        SqlDataReader dr = comm.ExecuteReader();
                        //DataTable dt = new DataTable();

                        while (dr.Read())
                        {

                            //da.Fill(dt);
                            //dgvitemform.DataSource = dr;
                            DataTable dt = new DataTable();
                            dt.Load(dr);

                            dgvitemform.DataSource = dt;

                            //String[] data = new string[] { row_id, item_name, size, style_name, quantity, rate, discount, total };
                            //dgvitemform.Rows.Add(data);
                            dr.Close();



                        }
                       //
                    }
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        SqlCommand command = new SqlCommand(com, conn);
                        //comm.Connection = conn;
                        //comm.CommandText = str;
                        conn.Open();

                        SqlDataReader dr1 = command.ExecuteReader();
                        while (dr1.Read())
                        {
                            //txtcustomer.Text = dr1[1].ToString();
                            //txt_datetime.Value = Convert.ToDateTime(dr1.GetValue(2)); /*(DateTime)dr.GetValue(2);*/
                            //txt_discount.Text = dr1[3].ToString();
                            //txt_total.Text = dr1[4].ToString();
                            //txtcustomer.Text = dr1[5].ToString();
                            //txtcustomer.Text = dr1[6].ToString();
                            //user_box.Text = dr1[7].ToString();

                            DataTable dt = new DataTable();
                            dt.Load(dr1);

                            dgvitemform.DataSource = dt;
                            dr1.Close();


                        }
                        
                    }
                   //
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}


