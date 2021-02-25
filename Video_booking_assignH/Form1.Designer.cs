
namespace Video_booking_assignH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.all_customers = new System.Windows.Forms.RadioButton();
            this.allmovies = new System.Windows.Forms.RadioButton();
            this.allrented = new System.Windows.Forms.RadioButton();
            this.Movies = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.rentals = new System.Windows.Forms.Button();
            this.vName = new System.Windows.Forms.TextBox();
            this.cAge = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.copies = new System.Windows.Forms.TextBox();
            this.Cost_txt = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.rental_cs_name = new System.Windows.Forms.TextBox();
            this.rental_mov_name = new System.Windows.Forms.TextBox();
            this.caddress = new System.Windows.Forms.TextBox();
            this.cPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.add_mov = new System.Windows.Forms.Button();
            this.update_vd = new System.Windows.Forms.Button();
            this.del_mov = new System.Windows.Forms.Button();
            this.add_cs_btn = new System.Windows.Forms.Button();
            this.update_cs_btn = new System.Windows.Forms.Button();
            this.del_cs_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Issue_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Pop_mov = new System.Windows.Forms.RadioButton();
            this.pop_cs = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // all_customers
            // 
            this.all_customers.AutoSize = true;
            this.all_customers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_customers.Location = new System.Drawing.Point(17, 29);
            this.all_customers.Name = "all_customers";
            this.all_customers.Size = new System.Drawing.Size(137, 26);
            this.all_customers.TabIndex = 1;
            this.all_customers.TabStop = true;
            this.all_customers.Text = "All Customers";
            this.all_customers.UseVisualStyleBackColor = true;
            this.all_customers.CheckedChanged += new System.EventHandler(this.all_customers_CheckedChanged);
            // 
            // allmovies
            // 
            this.allmovies.AutoSize = true;
            this.allmovies.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allmovies.Location = new System.Drawing.Point(176, 29);
            this.allmovies.Name = "allmovies";
            this.allmovies.Size = new System.Drawing.Size(114, 26);
            this.allmovies.TabIndex = 2;
            this.allmovies.TabStop = true;
            this.allmovies.Text = "All Movies";
            this.allmovies.UseVisualStyleBackColor = true;
            this.allmovies.CheckedChanged += new System.EventHandler(this.allmovies_CheckedChanged);
            // 
            // allrented
            // 
            this.allrented.AutoSize = true;
            this.allrented.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allrented.Location = new System.Drawing.Point(296, 29);
            this.allrented.Name = "allrented";
            this.allrented.Size = new System.Drawing.Size(173, 26);
            this.allrented.TabIndex = 3;
            this.allrented.TabStop = true;
            this.allrented.Text = "All Rented Movies";
            this.allrented.UseVisualStyleBackColor = true;
            this.allrented.CheckedChanged += new System.EventHandler(this.allrented_CheckedChanged);
            // 
            // Movies
            // 
            this.Movies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Movies.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Movies.Location = new System.Drawing.Point(65, 300);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(135, 61);
            this.Movies.TabIndex = 4;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = false;
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customers.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customers.Location = new System.Drawing.Point(490, 300);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(135, 61);
            this.customers.TabIndex = 5;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = false;
            // 
            // rentals
            // 
            this.rentals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentals.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rentals.Location = new System.Drawing.Point(808, 300);
            this.rentals.Name = "rentals";
            this.rentals.Size = new System.Drawing.Size(135, 61);
            this.rentals.TabIndex = 6;
            this.rentals.Text = "Rentals";
            this.rentals.UseVisualStyleBackColor = false;
            // 
            // vName
            // 
            this.vName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.vName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vName.ForeColor = System.Drawing.SystemColors.Window;
            this.vName.Location = new System.Drawing.Point(153, 387);
            this.vName.Name = "vName";
            this.vName.Size = new System.Drawing.Size(126, 30);
            this.vName.TabIndex = 7;
            // 
            // cAge
            // 
            this.cAge.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cAge.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAge.ForeColor = System.Drawing.SystemColors.Info;
            this.cAge.Location = new System.Drawing.Point(534, 427);
            this.cAge.Name = "cAge";
            this.cAge.Size = new System.Drawing.Size(126, 30);
            this.cAge.TabIndex = 8;
            // 
            // cname
            // 
            this.cname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cname.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.ForeColor = System.Drawing.SystemColors.Info;
            this.cname.Location = new System.Drawing.Point(534, 378);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(126, 30);
            this.cname.TabIndex = 9;
            // 
            // copies
            // 
            this.copies.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.copies.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies.ForeColor = System.Drawing.SystemColors.Info;
            this.copies.Location = new System.Drawing.Point(153, 631);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(126, 30);
            this.copies.TabIndex = 10;
            // 
            // Cost_txt
            // 
            this.Cost_txt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Cost_txt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_txt.ForeColor = System.Drawing.SystemColors.Info;
            this.Cost_txt.Location = new System.Drawing.Point(153, 584);
            this.Cost_txt.Name = "Cost_txt";
            this.Cost_txt.Size = new System.Drawing.Size(126, 30);
            this.Cost_txt.TabIndex = 11;
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plot.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.ForeColor = System.Drawing.SystemColors.Info;
            this.plot.Location = new System.Drawing.Point(153, 538);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(126, 30);
            this.plot.TabIndex = 12;
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.year.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.SystemColors.Info;
            this.year.Location = new System.Drawing.Point(153, 490);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(126, 30);
            this.year.TabIndex = 13;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rating.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.SystemColors.Info;
            this.rating.Location = new System.Drawing.Point(153, 438);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(126, 30);
            this.rating.TabIndex = 14;
            // 
            // rental_cs_name
            // 
            this.rental_cs_name.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rental_cs_name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_cs_name.ForeColor = System.Drawing.SystemColors.Menu;
            this.rental_cs_name.Location = new System.Drawing.Point(851, 438);
            this.rental_cs_name.Name = "rental_cs_name";
            this.rental_cs_name.Size = new System.Drawing.Size(126, 30);
            this.rental_cs_name.TabIndex = 16;
            // 
            // rental_mov_name
            // 
            this.rental_mov_name.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rental_mov_name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_mov_name.ForeColor = System.Drawing.SystemColors.Window;
            this.rental_mov_name.Location = new System.Drawing.Point(850, 384);
            this.rental_mov_name.Name = "rental_mov_name";
            this.rental_mov_name.Size = new System.Drawing.Size(126, 30);
            this.rental_mov_name.TabIndex = 17;
            // 
            // caddress
            // 
            this.caddress.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.caddress.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caddress.ForeColor = System.Drawing.SystemColors.Info;
            this.caddress.Location = new System.Drawing.Point(534, 557);
            this.caddress.Name = "caddress";
            this.caddress.Size = new System.Drawing.Size(126, 30);
            this.caddress.TabIndex = 18;
            // 
            // cPhone
            // 
            this.cPhone.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cPhone.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhone.ForeColor = System.Drawing.SystemColors.Info;
            this.cPhone.Location = new System.Drawing.Point(534, 490);
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(126, 30);
            this.cPhone.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ratting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Plot";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genre.Location = new System.Drawing.Point(26, 587);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(43, 24);
            this.genre.TabIndex = 24;
            this.genre.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(26, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Copies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(442, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(442, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(442, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(442, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(708, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Movie ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(707, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "customer ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(708, 496);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(708, 496);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 24);
            this.label14.TabIndex = 33;
            this.label14.Text = "Issue Date";
            // 
            // add_mov
            // 
            this.add_mov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_mov.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_mov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_mov.Location = new System.Drawing.Point(302, 414);
            this.add_mov.Name = "add_mov";
            this.add_mov.Size = new System.Drawing.Size(114, 40);
            this.add_mov.TabIndex = 34;
            this.add_mov.Text = "ADD";
            this.add_mov.UseVisualStyleBackColor = false;
            this.add_mov.Click += new System.EventHandler(this.add_mov_Click);
            // 
            // update_vd
            // 
            this.update_vd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_vd.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_vd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_vd.Location = new System.Drawing.Point(302, 469);
            this.update_vd.Name = "update_vd";
            this.update_vd.Size = new System.Drawing.Size(113, 45);
            this.update_vd.TabIndex = 35;
            this.update_vd.Text = "UPDATE";
            this.update_vd.UseVisualStyleBackColor = false;
            this.update_vd.Click += new System.EventHandler(this.update_vd_Click);
            // 
            // del_mov
            // 
            this.del_mov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_mov.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_mov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_mov.Location = new System.Drawing.Point(302, 523);
            this.del_mov.Name = "del_mov";
            this.del_mov.Size = new System.Drawing.Size(114, 42);
            this.del_mov.TabIndex = 36;
            this.del_mov.Text = "DELETE";
            this.del_mov.UseVisualStyleBackColor = false;
            this.del_mov.Click += new System.EventHandler(this.del_mov_Click);
            // 
            // add_cs_btn
            // 
            this.add_cs_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_cs_btn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cs_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_cs_btn.Location = new System.Drawing.Point(434, 611);
            this.add_cs_btn.Name = "add_cs_btn";
            this.add_cs_btn.Size = new System.Drawing.Size(70, 39);
            this.add_cs_btn.TabIndex = 37;
            this.add_cs_btn.Text = "ADD";
            this.add_cs_btn.UseVisualStyleBackColor = false;
            this.add_cs_btn.Click += new System.EventHandler(this.add_cs_btn_Click);
            // 
            // update_cs_btn
            // 
            this.update_cs_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_cs_btn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cs_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_cs_btn.Location = new System.Drawing.Point(510, 611);
            this.update_cs_btn.Name = "update_cs_btn";
            this.update_cs_btn.Size = new System.Drawing.Size(100, 39);
            this.update_cs_btn.TabIndex = 38;
            this.update_cs_btn.Text = "UPDATE";
            this.update_cs_btn.UseVisualStyleBackColor = false;
            this.update_cs_btn.Click += new System.EventHandler(this.update_cs_btn_Click);
            // 
            // del_cs_btn
            // 
            this.del_cs_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_cs_btn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_cs_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_cs_btn.Location = new System.Drawing.Point(600, 611);
            this.del_cs_btn.Name = "del_cs_btn";
            this.del_cs_btn.Size = new System.Drawing.Size(96, 39);
            this.del_cs_btn.TabIndex = 39;
            this.del_cs_btn.Text = "DELETE";
            this.del_cs_btn.UseVisualStyleBackColor = false;
            this.del_cs_btn.Click += new System.EventHandler(this.del_cs_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(828, 496);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(828, 543);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // Issue_btn
            // 
            this.Issue_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Issue_btn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Issue_btn.Location = new System.Drawing.Point(712, 611);
            this.Issue_btn.Name = "Issue_btn";
            this.Issue_btn.Size = new System.Drawing.Size(80, 39);
            this.Issue_btn.TabIndex = 42;
            this.Issue_btn.Text = "Issue";
            this.Issue_btn.UseVisualStyleBackColor = false;
            this.Issue_btn.Click += new System.EventHandler(this.Issue_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.return_btn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.return_btn.Location = new System.Drawing.Point(798, 611);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(104, 39);
            this.return_btn.TabIndex = 43;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_btn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_btn.Location = new System.Drawing.Point(896, 611);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(80, 39);
            this.del_btn.TabIndex = 44;
            this.del_btn.Text = "del";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(418, 312);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(10, 349);
            this.button10.TabIndex = 45;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(691, 303);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(10, 358);
            this.button11.TabIndex = 46;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(708, 539);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 24);
            this.label15.TabIndex = 47;
            this.label15.Text = "Return date";
            // 
            // Pop_mov
            // 
            this.Pop_mov.AutoSize = true;
            this.Pop_mov.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pop_mov.Location = new System.Drawing.Point(472, 29);
            this.Pop_mov.Name = "Pop_mov";
            this.Pop_mov.Size = new System.Drawing.Size(143, 26);
            this.Pop_mov.TabIndex = 48;
            this.Pop_mov.TabStop = true;
            this.Pop_mov.Text = "Popular Movie";
            this.Pop_mov.UseVisualStyleBackColor = true;
            this.Pop_mov.CheckedChanged += new System.EventHandler(this.Pop_mov_CheckedChanged);
            // 
            // pop_cs
            // 
            this.pop_cs.AutoSize = true;
            this.pop_cs.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop_cs.Location = new System.Drawing.Point(621, 29);
            this.pop_cs.Name = "pop_cs";
            this.pop_cs.Size = new System.Drawing.Size(166, 26);
            this.pop_cs.TabIndex = 49;
            this.pop_cs.TabStop = true;
            this.pop_cs.Text = "Popular Customer";
            this.pop_cs.UseVisualStyleBackColor = true;
            this.pop_cs.CheckedChanged += new System.EventHandler(this.pop_cs_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.all_customers);
            this.groupBox1.Controls.Add(this.pop_cs);
            this.groupBox1.Controls.Add(this.allmovies);
            this.groupBox1.Controls.Add(this.Pop_mov);
            this.groupBox1.Controls.Add(this.allrented);
            this.groupBox1.Location = new System.Drawing.Point(52, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 72);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.Issue_btn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.del_cs_btn);
            this.Controls.Add(this.update_cs_btn);
            this.Controls.Add(this.add_cs_btn);
            this.Controls.Add(this.del_mov);
            this.Controls.Add(this.update_vd);
            this.Controls.Add(this.add_mov);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cPhone);
            this.Controls.Add(this.caddress);
            this.Controls.Add(this.rental_mov_name);
            this.Controls.Add(this.rental_cs_name);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.year);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.Cost_txt);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.cAge);
            this.Controls.Add(this.vName);
            this.Controls.Add(this.rentals);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton all_customers;
        private System.Windows.Forms.RadioButton allmovies;
        private System.Windows.Forms.RadioButton allrented;
        private System.Windows.Forms.Button Movies;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button rentals;
        private System.Windows.Forms.TextBox vName;
        private System.Windows.Forms.TextBox cAge;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.TextBox Cost_txt;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.TextBox rental_cs_name;
        private System.Windows.Forms.TextBox rental_mov_name;
        private System.Windows.Forms.TextBox caddress;
        private System.Windows.Forms.TextBox cPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button add_mov;
        private System.Windows.Forms.Button update_vd;
        private System.Windows.Forms.Button del_mov;
        private System.Windows.Forms.Button add_cs_btn;
        private System.Windows.Forms.Button update_cs_btn;
        private System.Windows.Forms.Button del_cs_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Issue_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton Pop_mov;
        private System.Windows.Forms.RadioButton pop_cs;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

