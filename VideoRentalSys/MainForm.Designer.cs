namespace VideoRentalSys
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.TextBox();
            this.Copies = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Ratting = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MovieRatting = new System.Windows.Forms.Button();
            this.delCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CustomerRatting = new System.Windows.Forms.Button();
            this.RentalID = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.DateTimePicker();
            this.Issue = new System.Windows.Forms.DateTimePicker();
            this.rentalDelete = new System.Windows.Forms.Button();
            this.rentalReturn = new System.Windows.Forms.Button();
            this.rentalIssue = new System.Windows.Forms.Button();
            this.movieID = new System.Windows.Forms.TextBox();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.DataVideo = new System.Windows.Forms.Button();
            this.DataRental = new System.Windows.Forms.Button();
            this.dataCustomer = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delVideo);
            this.groupBox1.Controls.Add(this.updateVideo);
            this.groupBox1.Controls.Add(this.AddVideo);
            this.groupBox1.Controls.Add(this.Genre);
            this.groupBox1.Controls.Add(this.Plot);
            this.groupBox1.Controls.Add(this.Copies);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.Year);
            this.groupBox1.Controls.Add(this.Ratting);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(409, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Video";
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(251, 382);
            this.delVideo.Margin = new System.Windows.Forms.Padding(4);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(113, 39);
            this.delVideo.TabIndex = 16;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(129, 382);
            this.updateVideo.Margin = new System.Windows.Forms.Padding(4);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(113, 39);
            this.updateVideo.TabIndex = 15;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(8, 382);
            this.AddVideo.Margin = new System.Windows.Forms.Padding(4);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(113, 39);
            this.AddVideo.TabIndex = 14;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(165, 313);
            this.Genre.Margin = new System.Windows.Forms.Padding(4);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(204, 38);
            this.Genre.TabIndex = 13;
            // 
            // Plot
            // 
            this.Plot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plot.Location = new System.Drawing.Point(165, 266);
            this.Plot.Margin = new System.Windows.Forms.Padding(4);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(204, 38);
            this.Plot.TabIndex = 12;
            // 
            // Copies
            // 
            this.Copies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copies.Location = new System.Drawing.Point(165, 222);
            this.Copies.Margin = new System.Windows.Forms.Padding(4);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(204, 38);
            this.Copies.TabIndex = 11;
            this.Copies.TextChanged += new System.EventHandler(this.Copies_TextChanged);
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(165, 177);
            this.Cost.Margin = new System.Windows.Forms.Padding(4);
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Size = new System.Drawing.Size(204, 38);
            this.Cost.TabIndex = 10;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(165, 130);
            this.Year.Margin = new System.Windows.Forms.Padding(4);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(204, 38);
            this.Year.TabIndex = 9;
            // 
            // Ratting
            // 
            this.Ratting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratting.Location = new System.Drawing.Point(165, 84);
            this.Ratting.Margin = new System.Windows.Forms.Padding(4);
            this.Ratting.Name = "Ratting";
            this.Ratting.Size = new System.Drawing.Size(204, 38);
            this.Ratting.TabIndex = 8;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(165, 37);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(204, 38);
            this.title.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ratting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MovieRatting);
            this.groupBox2.Controls.Add(this.delCustomer);
            this.groupBox2.Controls.Add(this.updateCustomer);
            this.groupBox2.Controls.Add(this.addCustomer);
            this.groupBox2.Controls.Add(this.Address);
            this.groupBox2.Controls.Add(this.MobileNo);
            this.groupBox2.Controls.Add(this.LastName);
            this.groupBox2.Controls.Add(this.FirstName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(433, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(439, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Record";
            // 
            // MovieRatting
            // 
            this.MovieRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieRatting.Location = new System.Drawing.Point(28, 331);
            this.MovieRatting.Margin = new System.Windows.Forms.Padding(4);
            this.MovieRatting.Name = "MovieRatting";
            this.MovieRatting.Size = new System.Drawing.Size(368, 90);
            this.MovieRatting.TabIndex = 21;
            this.MovieRatting.Text = "Video Ratting";
            this.MovieRatting.UseVisualStyleBackColor = true;
            this.MovieRatting.Click += new System.EventHandler(this.MovieRatting_Click);
            // 
            // delCustomer
            // 
            this.delCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.Location = new System.Drawing.Point(31, 278);
            this.delCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(365, 46);
            this.delCustomer.TabIndex = 20;
            this.delCustomer.Text = "Delete";
            this.delCustomer.UseVisualStyleBackColor = true;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(191, 231);
            this.updateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(205, 39);
            this.updateCustomer.TabIndex = 19;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(28, 231);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(135, 39);
            this.addCustomer.TabIndex = 17;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(191, 177);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(204, 38);
            this.Address.TabIndex = 18;
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(191, 129);
            this.MobileNo.Margin = new System.Windows.Forms.Padding(4);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(204, 38);
            this.MobileNo.TabIndex = 17;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(191, 84);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(204, 38);
            this.LastName.TabIndex = 16;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(191, 37);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(204, 38);
            this.FirstName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 32);
            this.label11.TabIndex = 11;
            this.label11.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CustomerRatting);
            this.groupBox3.Controls.Add(this.RentalID);
            this.groupBox3.Controls.Add(this.Return);
            this.groupBox3.Controls.Add(this.Issue);
            this.groupBox3.Controls.Add(this.rentalDelete);
            this.groupBox3.Controls.Add(this.rentalReturn);
            this.groupBox3.Controls.Add(this.rentalIssue);
            this.groupBox3.Controls.Add(this.movieID);
            this.groupBox3.Controls.Add(this.customerID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(880, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(439, 441);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental Record";
            // 
            // CustomerRatting
            // 
            this.CustomerRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerRatting.Location = new System.Drawing.Point(28, 334);
            this.CustomerRatting.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerRatting.Name = "CustomerRatting";
            this.CustomerRatting.Size = new System.Drawing.Size(368, 90);
            this.CustomerRatting.TabIndex = 24;
            this.CustomerRatting.Text = "Customer Ranking";
            this.CustomerRatting.UseVisualStyleBackColor = true;
            this.CustomerRatting.Click += new System.EventHandler(this.CustomerRatting_Click);
            // 
            // RentalID
            // 
            this.RentalID.AutoSize = true;
            this.RentalID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalID.Location = new System.Drawing.Point(37, 327);
            this.RentalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RentalID.Name = "RentalID";
            this.RentalID.Size = new System.Drawing.Size(0, 32);
            this.RentalID.TabIndex = 23;
            this.RentalID.Visible = false;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Return.Location = new System.Drawing.Point(208, 182);
            this.Return.Margin = new System.Windows.Forms.Padding(4);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(204, 38);
            this.Return.TabIndex = 22;
            // 
            // Issue
            // 
            this.Issue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Issue.Location = new System.Drawing.Point(208, 137);
            this.Issue.Margin = new System.Windows.Forms.Padding(4);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(204, 38);
            this.Issue.TabIndex = 21;
            // 
            // rentalDelete
            // 
            this.rentalDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDelete.Location = new System.Drawing.Point(31, 278);
            this.rentalDelete.Margin = new System.Windows.Forms.Padding(4);
            this.rentalDelete.Name = "rentalDelete";
            this.rentalDelete.Size = new System.Drawing.Size(365, 46);
            this.rentalDelete.TabIndex = 20;
            this.rentalDelete.Text = "Delete";
            this.rentalDelete.UseVisualStyleBackColor = true;
            this.rentalDelete.Click += new System.EventHandler(this.rentalDelete_Click);
            // 
            // rentalReturn
            // 
            this.rentalReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturn.Location = new System.Drawing.Point(191, 231);
            this.rentalReturn.Margin = new System.Windows.Forms.Padding(4);
            this.rentalReturn.Name = "rentalReturn";
            this.rentalReturn.Size = new System.Drawing.Size(205, 39);
            this.rentalReturn.TabIndex = 19;
            this.rentalReturn.Text = "Return";
            this.rentalReturn.UseVisualStyleBackColor = true;
            this.rentalReturn.Click += new System.EventHandler(this.rentalReturn_Click);
            // 
            // rentalIssue
            // 
            this.rentalIssue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalIssue.Location = new System.Drawing.Point(28, 231);
            this.rentalIssue.Margin = new System.Windows.Forms.Padding(4);
            this.rentalIssue.Name = "rentalIssue";
            this.rentalIssue.Size = new System.Drawing.Size(135, 39);
            this.rentalIssue.TabIndex = 17;
            this.rentalIssue.Text = "Issue";
            this.rentalIssue.UseVisualStyleBackColor = true;
            this.rentalIssue.Click += new System.EventHandler(this.rentalIssue_Click);
            // 
            // movieID
            // 
            this.movieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieID.Location = new System.Drawing.Point(208, 86);
            this.movieID.Margin = new System.Windows.Forms.Padding(4);
            this.movieID.Name = "movieID";
            this.movieID.ReadOnly = true;
            this.movieID.Size = new System.Drawing.Size(204, 38);
            this.movieID.TabIndex = 16;
            // 
            // customerID
            // 
            this.customerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(208, 37);
            this.customerID.Margin = new System.Windows.Forms.Padding(4);
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Size = new System.Drawing.Size(204, 38);
            this.customerID.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 32);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 32);
            this.label14.TabIndex = 12;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 32);
            this.label15.TabIndex = 11;
            this.label15.Text = "Customer ID";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(16, 508);
            this.data.Margin = new System.Windows.Forms.Padding(4);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.Size = new System.Drawing.Size(1303, 306);
            this.data.TabIndex = 21;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DoubleClick);
            this.data.DoubleClick += new System.EventHandler(this.data_DoubleClick);
            // 
            // DataVideo
            // 
            this.DataVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataVideo.Location = new System.Drawing.Point(16, 470);
            this.DataVideo.Margin = new System.Windows.Forms.Padding(4);
            this.DataVideo.Name = "DataVideo";
            this.DataVideo.Size = new System.Drawing.Size(113, 39);
            this.DataVideo.TabIndex = 17;
            this.DataVideo.Text = "Video";
            this.DataVideo.UseVisualStyleBackColor = true;
            this.DataVideo.Click += new System.EventHandler(this.DataVideo_Click);
            // 
            // DataRental
            // 
            this.DataRental.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRental.Location = new System.Drawing.Point(281, 470);
            this.DataRental.Margin = new System.Windows.Forms.Padding(4);
            this.DataRental.Name = "DataRental";
            this.DataRental.Size = new System.Drawing.Size(113, 39);
            this.DataRental.TabIndex = 22;
            this.DataRental.Text = "Rental";
            this.DataRental.UseVisualStyleBackColor = true;
            this.DataRental.Click += new System.EventHandler(this.DataRental_Click);
            // 
            // dataCustomer
            // 
            this.dataCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCustomer.Location = new System.Drawing.Point(131, 470);
            this.dataCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.Size = new System.Drawing.Size(149, 39);
            this.dataCustomer.TabIndex = 23;
            this.dataCustomer.Text = "Customer";
            this.dataCustomer.UseVisualStyleBackColor = true;
            this.dataCustomer.Click += new System.EventHandler(this.dataCustomer_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(501, 457);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(232, 48);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1360, 830);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataCustomer);
            this.Controls.Add(this.DataRental);
            this.Controls.Add(this.DataVideo);
            this.Controls.Add(this.data);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Video Rental System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Plot;
        private System.Windows.Forms.TextBox Copies;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Ratting;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rentalDelete;
        private System.Windows.Forms.Button rentalReturn;
        private System.Windows.Forms.Button rentalIssue;
        private System.Windows.Forms.TextBox movieID;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker Return;
        private System.Windows.Forms.DateTimePicker Issue;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button DataVideo;
        private System.Windows.Forms.Button dataCustomer;
        private System.Windows.Forms.Button DataRental;
        private System.Windows.Forms.Label RentalID;
        private System.Windows.Forms.Button MovieRatting;
        private System.Windows.Forms.Button CustomerRatting;
        private System.Windows.Forms.Button Exit;
    }
}