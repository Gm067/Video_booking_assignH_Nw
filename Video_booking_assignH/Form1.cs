using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_booking_assignH
{
    public partial class Form1 : Form
    {
        int RID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_cs_btn_Click(object sender, EventArgs e)
        {
            if (cname.Text.Equals("") && cAge.Text.Equals("") && cPhone.Text.Equals("") && caddress.Text.Equals(""))
            {
                MessageBox.Show("You must need to fill all details ");
            }
            else {
                Controller.DatabaseClass dbClient = new Controller.DatabaseClass();
                if (dbClient.addClient(cname.Text, cAge.Text, cPhone.Text, caddress.Text))
                {
                    MessageBox.Show("Client is registered ");

                    cname.Text = "";
                    rental_cs_name.Text = "";
                    cAge.Text = "";
                    cPhone.Text = "";
                    caddress.Text = "";
                }
                else {
                    MessageBox.Show("check the details once ");
                }
            }
        }

        private void update_cs_btn_Click(object sender, EventArgs e)
        {
            if (rental_cs_name.Text.Equals("") && cname.Text.Equals("") && cAge.Text.Equals("") && cPhone.Text.Equals("") && caddress.Text.Equals(""))
            {
                MessageBox.Show("You must need to fill all details ");
            }
            else
            {
                Controller.DatabaseClass dbClient = new Controller.DatabaseClass();
                if (dbClient.editClient(Convert.ToInt32(rental_cs_name.Text),cname.Text, cAge.Text, cPhone.Text, caddress.Text))
                {
                    MessageBox.Show("Client record is updated ");

                    cname.Text = "";
                    rental_cs_name.Text = "";
                    cAge.Text = "";
                    cPhone.Text = "";
                    caddress.Text = "";
                }
                else
                {
                    MessageBox.Show("check the details once ");
                }
            }
        }

        private void del_cs_btn_Click(object sender, EventArgs e)
        {
            if (rental_cs_name.Text.Equals("") && cname.Text.Equals("") && cAge.Text.Equals("") && cPhone.Text.Equals("") && caddress.Text.Equals(""))
            {
                MessageBox.Show("You must need to fill all details ");
            }
            else
            {
                Controller.DatabaseClass dbClient = new Controller.DatabaseClass();
                if (dbClient.delClient(Convert.ToInt32(rental_cs_name.Text)))
                {
                    MessageBox.Show("Client record is deleted ");
                    cname.Text = "";
                    rental_cs_name.Text = "";
                    cAge.Text = "";
                    cPhone.Text = "";
                    caddress.Text = "";
                }
                else
                {
                    MessageBox.Show("check the details once ");
                }
            }

        }

        private void add_mov_Click(object sender, EventArgs e)
        {
            if (vName.Text.Equals("") && rating.Text.Equals("") && year.Text.Equals("") && plot.Text.Equals("") && Cost_txt.Text.Equals("") && copies.Text.Equals("") && genre.Text.Equals(""))
            {
                MessageBox.Show("Must need to fill the details ");
            }
            else {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                if (db.addVideo(vName.Text,rating.Text,year.Text,plot.Text,Cost_txt.Text,copies.Text,genre.Text)) {
                    MessageBox.Show("Video is record ");

                    vName.Text = "";
                    year.Text = "";
                    plot.Text = "";
                    Cost_txt.Text = "";
                    copies.Text = "";
                    genre.Text = "";
                    rating.Text = "";

                } else{
                    MessageBox.Show("Check the Video ");
                }
            }
        }

        private void update_vd_Click(object sender, EventArgs e)
        {
            if (rental_mov_name.Text.Equals("") && vName.Text.Equals("") && rating.Text.Equals("") && year.Text.Equals("") && plot.Text.Equals("") && Cost_txt.Text.Equals("") && copies.Text.Equals("") && genre.Text.Equals(""))
            {
                MessageBox.Show("Must need to fill the details ");
            }
            else
            {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                if (db.UpdateVideo(Convert.ToInt32(rental_mov_name.Text),vName.Text, rating.Text, year.Text, plot.Text, Cost_txt.Text, copies.Text, genre.Text))
                {
                    MessageBox.Show("Video recoord is Updated ");
                    rental_mov_name.Text = "";
                    vName.Text = "";
                    year.Text = "";
                    plot.Text = "";
                    Cost_txt.Text = "";
                    copies.Text = "";
                    genre.Text = "";
                    rating.Text = "";

                }
                else
                {
                    MessageBox.Show("Check the Video ");
                }
            }
        }

        private void del_mov_Click(object sender, EventArgs e)
        {
            if (rental_mov_name.Text.Equals("") && vName.Text.Equals("") && rating.Text.Equals("") && year.Text.Equals("") && plot.Text.Equals("") && Cost_txt.Text.Equals("") && copies.Text.Equals("") && genre.Text.Equals(""))
            {
                MessageBox.Show("Must need to fill the details ");
            }
            else
            {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                if (db.delVideo(Convert.ToInt32(rental_mov_name.Text)))
                {
                    MessageBox.Show("Video recoord is deleted ");
                    rental_mov_name.Text = "";
                    vName.Text = "";
                    year.Text = "";
                    plot.Text = "";
                    Cost_txt.Text = "";
                    copies.Text = "";
                    genre.Text = "";
                    rating.Text = "";

                }
                else
                {
                    MessageBox.Show("Check the Video ");
                }
            }

        }

        private void Issue_btn_Click(object sender, EventArgs e)
        {
            if (rental_mov_name.Text.Equals("") && rental_cs_name.Text.Equals(""))
            {
                MessageBox.Show("Must need to select the video and Customer");


            }
            else {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                if (db.bookVideo(Convert.ToInt32(rental_mov_name.Text), Convert.ToInt32(rental_cs_name.Text), dateTimePicker1.Text.ToString()))
                {
                    MessageBox.Show("video is booked ");
                    RID = 0;
                    cname.Text = "";
                    rental_cs_name.Text = "";
                    cAge.Text = "";
                    cPhone.Text = "";
                    caddress.Text = "";

                    rental_mov_name.Text = "";
                    vName.Text = "";
                    year.Text = "";
                    plot.Text = "";
                    Cost_txt.Text = "";
                    copies.Text = "";
                    genre.Text = "";
                    rating.Text = "";

                }
                else {
                    MessageBox.Show("Must select the data ");
                }
            }

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (RID>0 && rental_mov_name.Text.Equals("") && rental_cs_name.Text.Equals(""))
            {
                MessageBox.Show("Must need to select the video and Customer");


            }
            else
            {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                if (db.returnVideo(RID,Convert.ToInt32(rental_mov_name.Text), Convert.ToInt32(rental_cs_name.Text), dateTimePicker1.Text.ToString(),dateTimePicker2.Text.ToString()))
                {
                    DataTable tbl = new DataTable();
                    tbl = db.SelectQuery("select * from Video where id="+Convert.ToInt32(rental_mov_name.Text)+"");
                    int Cost = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());

                    DataTable tbl1 = new DataTable();
                    tbl1 = db.SelectQuery("select * from Rental where id="+RID+"");
                    String olDate = tbl1.Rows[0]["BookDate"].ToString();




                    DateTime current_date = DateTime.Now;

                    //convert the old date from string to Date fromat
                    DateTime prev_date = Convert.ToDateTime(olDate);


                    //get the difference in the days fromat
                    String Daysdiff = (current_date - prev_date).TotalDays.ToString();


                    // calculate the round off value 
                    Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                    int Bill = Cost * Convert.ToInt32(DaysInterval);




                    MessageBox.Show("video is returned and bill is $"+Bill);
                    RID = 0;
                    cname.Text = "";
                    rental_cs_name.Text = "";
                    cAge.Text = "";
                    cPhone.Text = "";
                    caddress.Text = "";

                    rental_mov_name.Text = "";
                    vName.Text = "";
                    year.Text = "";
                    plot.Text = "";
                    Cost_txt.Text = "";
                    copies.Text = "";
                    genre.Text = "";
                    rating.Text = "";

                }
                else
                {
                    MessageBox.Show("Must select the data ");
                }
            }


        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (RID > 0 && rental_mov_name.Text.Equals("") && rental_cs_name.Text.Equals(""))
            {
                MessageBox.Show("Must need to select the video and Customer");


            }
            else
            {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                if (db.delRentalVideo(RID))
                {
                    MessageBox.Show("rental video is deleted ");
                    RID = 0;
                    cname.Text = "";
                    rental_cs_name.Text = "";
                    cAge.Text = "";
                    cPhone.Text = "";
                    caddress.Text = "";

                    rental_mov_name.Text = "";
                    vName.Text = "";
                    year.Text = "";
                    plot.Text = "";
                    Cost_txt.Text = "";
                    copies.Text = "";
                    genre.Text = "";
                    rating.Text = "";

                }
                else
                {
                    MessageBox.Show("Must select the data ");
                }
            }


        }

        private void all_customers_CheckedChanged(object sender, EventArgs e)
        {
            if (all_customers.Checked==true) {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                DataTable tbl = new DataTable();
                tbl = db.SelectQuery("select * from Client");
                dataGridView1.DataSource = tbl;
            }
        }

        private void allmovies_CheckedChanged(object sender, EventArgs e)
        {
            if (allmovies.Checked == true)
            {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                DataTable tbl = new DataTable();
                tbl = db.SelectQuery("select * from Video");
                dataGridView1.DataSource = tbl;
            }
        }

        private void allrented_CheckedChanged(object sender, EventArgs e)
        {
            if (allrented.Checked == true)
            {
                Controller.DatabaseClass db = new Controller.DatabaseClass();
                DataTable tbl = new DataTable();
                tbl = db.SelectQuery("select * from Rental");
                dataGridView1.DataSource = tbl;
            }
        }

        private void year_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(year.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                Cost_txt.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (all_customers.Checked == true) {
                rental_cs_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cAge.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                caddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            } else if (allrented.Checked == true) {

                RID =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                rental_mov_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                rental_cs_name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            } else if (allmovies.Checked==true) {
                rental_mov_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                rating.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                year.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                plot.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Cost_txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                copies.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
        }

        private void Pop_mov_CheckedChanged(object sender, EventArgs e)
        {
            if (Pop_mov.Checked == true)
            {


                Controller.DatabaseClass db = new Controller.DatabaseClass();
                DataTable tbl = new DataTable();

                tbl = db.SelectQuery("select * from Video");
                int x = 0, y = 0, cunt = 0;
                String Title = "";
                for (x = 0; x < tbl.Rows.Count; x++)
                {
                    DataTable tblData1 = new DataTable();
                    tblData1 = db.SelectQuery("select * from rental where V_ID='" + tbl.Rows[x]["id"].ToString() + "'");

                    if (tblData1.Rows.Count > cunt)
                    {
                        Title = tbl.Rows[x]["title"].ToString();
                        cunt = tblData1.Rows.Count;
                    }

                }
                MessageBox.Show("Popular Video is " + Title);
            }

        }

        private void pop_cs_CheckedChanged(object sender, EventArgs e)
        {
            if (pop_cs.Checked==true) {

                Controller.DatabaseClass db = new Controller.DatabaseClass();
                DataTable tbl = new DataTable();

                tbl = db.SelectQuery("select * from Client");
                int x = 0, y = 0, cunt = 0;
                String Title = "";
                for (x = 0; x < tbl.Rows.Count; x++)
                {
                    DataTable tblData1 = new DataTable();
                    tblData1 = db.SelectQuery("select * from rental where C_ID='" + tbl.Rows[x]["id"].ToString() + "'");

                    if (tblData1.Rows.Count > cunt)
                    {
                        Title = tbl.Rows[x]["Name"].ToString();
                        cunt = tblData1.Rows.Count;
                    }

                }
                MessageBox.Show("Popular Video is " + Title);

            }
        }
    }
}
