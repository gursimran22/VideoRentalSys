using System;
using System.Data;
using System.Windows.Forms;

namespace VideoRentalSys
{
    public partial class MainForm : Form
    {
        // Global object of the Class which is used in the Main Class of the Video Rental System
        Database data_base = new Database();

        Rental rental_obj = new Rental();
        // Private varaible used in the Class for better understanding 
        private int err = 0, RentID = 0, CustID = 0, MovID = 0, Video_Cost = 0, VideoCopies = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        // user define method that is used to check the emptyness of the Video Record
        public int chkVideo()
        {
            if (title.Text.ToString().Equals(""))
            {
                error.SetError(title, "Enter Title of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Year.Text.ToString().Equals(""))
            {
                error.SetError(Year, "Enter Year of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Ratting.Text.ToString().Equals(""))
            {
                error.SetError(Ratting, "Enter Ratting of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Cost.Text.ToString().Equals(""))
            {
                error.SetError(Cost, "Enter Cost of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Copies.Text.ToString().Equals(""))
            {
                error.SetError(Copies, "Enter Cost of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Plot.Text.ToString().Equals(""))
            {
                error.SetError(Plot, "Enter Plot of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Genre.Text.ToString().Equals(""))
            {
                error.SetError(Genre, "Enter Genre of the Video");
                err++;
            }
            else
            {
                error.Clear();
            }


            if (err == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        //another User define method used to check the empty ness of the customer Record
        public int chkCustomer()
        {
            if (FirstName.Text.ToString().Equals(""))
            {
                error.SetError(FirstName, "Enter First Name of Customer");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (LastName.Text.ToString().Equals(""))
            {
                error.SetError(LastName, "Enter Last Name of the Customer");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (MobileNo.Text.ToString().Equals(""))
            {
                error.SetError(MobileNo, "Enter Mobile No of the Customer");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (Address.Text.ToString().Equals(""))
            {
                error.SetError(Address, "Enter Address of the Customer");
                err++;
            }
            else
            {
                error.Clear();
            }



            if (err == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        // check emptyness of the rental record
        public int chkRental()
        {
            if (customerID.Text.ToString().Equals(""))
            {
                error.SetError(customerID, "Select Customer ID ");
                err++;
            }
            else
            {
                error.Clear();
            }

            if (movieID.Text.ToString().Equals(""))
            {
                error.SetError(movieID, "Select Movie ID");
                err++;
            }
            else
            {
                error.Clear();
            }





            if (err == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        // method to insert the record in the table of the video

        private void AddVideo_Click(object sender, EventArgs e)
        {
            //condition to check the record is filled or not 
            if (chkVideo() == 1)
            {

                // insert the query 
                String query = "insert into Video_Record(Video_Title,Video_Ratting,Video_Year,Video_Cost,Video_Copies,Video_Plot,Video_Genre) values('" + title.Text.ToString() + "','" + Ratting.Text.ToString() + "'," + Convert.ToInt32(Year.Text.ToString()) + "," + Convert.ToInt32(Cost.Text.ToString()) + "," + Convert.ToInt32(Copies.Text.ToString()) + ",'" + Plot.Text.ToString() + "','" + Genre.Text.ToString() + "')";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Video Record is Saved");
                //refresh all text box after inserting the record in the table
                title.Text = "";
                Year.Text = "";
                Ratting.Text = "";
                Cost.Text = "";
                Copies.Text = "";
                Plot.Text = "";
                Genre.Text = "";
                query = "select * from Video_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                //display the error 
                MessageBox.Show("Fill the Record Properly ");
            }
            err = 0;

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (chkCustomer() == 1)
            {
                //record to insert the record in the table
                String query = "insert into Customer_Record(Customer_FirstName,Customer_LastName,Customer_Mobile,Customer_Address)values('" + FirstName.Text.ToString() + "','" + LastName.Text.ToString() + "','" + MobileNo.Text.ToString() + "','" + Address.Text.ToString() + "')";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Customer Record is Saved");
                // refresh the data grid view
                query = "select * from Customer_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Fill all the Record of the Customer");
            }
            err = 0;
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";

        }

        //user define method that is used to count the no of video is send on rent and count the customer who is getting the video on rent 
        public void Video_Cunt()
        {
            int Count = 0;
            DataTable recrdtbl = new DataTable();

            String query = "select * from Video_Cunt where MovieID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
            recrdtbl = data_base.Srch(query);
            if (recrdtbl.Rows.Count > 0)
            {
                Count = Convert.ToInt32(recrdtbl.Rows[0]["CountNo"].ToString());
                query = "";
                Count++;
                query = "Update Video_Cunt set CountNo=" + Count + " where MovieID=" + Convert.ToInt32(movieID.Text.ToString()) + " ";
                data_base.InsDelUpdt(query);


            }
            else
            {
                query = "insert into Video_Cunt(MovieID,CountNo) values(" + Convert.ToInt32(movieID.Text.ToString()) + ",1)";
                data_base.InsDelUpdt(query);

            }

            //MessageBox.Show("ok1");
            DataTable recrdtbl1 = new DataTable();

            query = "";

            query = "select * from Customer_Cunt where CustomerID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
            recrdtbl1 = data_base.Srch(query);
            //MessageBox.Show("ok1"+recrdtbl1.Rows.Count);

            if (recrdtbl1.Rows.Count > 0)
            {
                Count = 0;
                query = "";
                Count = Convert.ToInt32(recrdtbl1.Rows[0]["CountNo"].ToString());
                query = "";
                Count++;
                query = "update Customer_Cunt set CountNo=" + Count + " where CustomerID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);


            }
            else
            {
                query = "insert into Customer_Cunt(CustomerID,CountNo)values(" + Convert.ToInt32(customerID.Text.ToString()) + ",1)";
                data_base.InsDelUpdt(query);

            }



        }
        private void rentalIssue_Click(object sender, EventArgs e)
        {
            if (chkRental() == 1)
            {
                DataTable recrdtbl = new DataTable();
                DataTable recrdtbl1 = new DataTable();

                String query = "select * from Rental_Record where Customer_ID='" + customerID.Text.ToString() + "' and Return_Date='Issued On Rent'";

                recrdtbl = data_base.Srch(query);


                int cnt = recrdtbl.Rows.Count;



                String query1 = "select * from Rental_Record where Movie_ID='" + movieID.Text.ToString() + "' and Return_Date='Issued On Rent'";

                recrdtbl1 = data_base.Srch(query1);


                int cnt1 = recrdtbl1.Rows.Count;
                int a = 0;
                if (cnt < 2)
                {
                    a++;
                }
                else
                {
                    MessageBox.Show("Your Limit is over to buy more video on rent first return the last movie then you can buy more ");
                }

                if (cnt1 < VideoCopies)
                {
                    a++;
                }
                else
                {
                    MessageBox.Show("no more Videos is available now all are issued on rent ");
                }




                if (a == 2)
                {
                    // issue the movie on rent 
                    query = "insert into Rental_Record(Customer_ID,Movie_ID,Rental_Date,Return_Date) values('" + customerID.Text.ToString() + "','" + movieID.Text.ToString() + "','" + Issue.Value.Date.ToString() + "','Issued On Rent')";
                    data_base.InsDelUpdt(query);

                    MessageBox.Show("Video is Issued on Rent ");
                    query = "select * from Rental_Record";
                    DataTable recordTbl = new DataTable();
                    recordTbl = data_base.Srch(query);
                    data.DataSource = recordTbl;
                    Video_Cunt();
                }








            }
            else
            {
                MessageBox.Show("Enter Proper Details");
            }
            err = 0;
            customerID.Text = "";
            movieID.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";


        }

        private void Copies_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //dislay the cost of the price of the video after adding the year of the video
                DateTime date = DateTime.Now;

                int year = date.Year;

                int diff = year - Convert.ToInt32(Year.Text.ToString());
                // MessageBox.Show(diff.ToString());
                int charge = rental_obj.year(diff);
                Cost.Text = charge.ToString();

            }
            catch (Exception es)
            {


            }

        }


        private void DataVideo_Click(object sender, EventArgs e)
        {
            // get the whole record of the videos and display in the data grid view
            MovID = 1;
            String query = "select * from Video_Record";
            DataTable recordTbl = new DataTable();
            recordTbl = data_base.Srch(query);
            data.DataSource = recordTbl;
            CustID = 0;
            RentID = 0;


        }

        private void updateVideo_Click(object sender, EventArgs e)
        {
            //update the video data after updating the record
            if (!movieID.Text.Equals(""))
            {
                string query = "update Video_Record set Video_Title='" + title.Text.ToString() + "',Video_Ratting='" + Ratting.Text.ToString() + "',Video_Year=" + Convert.ToInt32(Year.Text.ToString()) + ",Video_Cost=" + Convert.ToInt32(Cost.Text.ToString()) + ",Video_Copies=" + Convert.ToInt32(Copies.Text.ToString()) + ",Video_Plot='" + Plot.Text.ToString() + "',Video_Genre='" + Genre.Text.ToString() + "' where Video_ID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Record is Updated");
                query = "select * from Video_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Video First");
            }

            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";
            movieID.Text = "";


        }

        private void delVideo_Click(object sender, EventArgs e)
        {
            String query = "";

            //del the video after verifying it
            if (!movieID.Text.Equals(""))
            {

                DataTable recrdtbl1 = new DataTable();
                String query1 = "select * from Rental_Record where Movie_ID='" + movieID.Text.ToString() + "' and Return_Date='Issued On Rent'";

                recrdtbl1 = data_base.Srch(query1);


                int cnt1 = recrdtbl1.Rows.Count;
                if (cnt1 == 0)
                {


                    query = "delete from Video_Record  where Video_ID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
                    data_base.InsDelUpdt(query);
                    MessageBox.Show("Record is Deleted");
                }
                else
                {
                    MessageBox.Show("Video is issued on rent so can't be delete now ");

                }
                query = "select * from Video_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Video First");
            }

            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";
            movieID.Text = "";



        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            //delete the customer record after double cliking on the data grid view
            if (!customerID.Text.ToString().Equals(""))
            {

                DataTable recrdtbl = new DataTable();


                String query = "select * from Rental_Record where Customer_ID='" + customerID.Text.ToString() + "' and Return_Date='Issued On Rent'";

                recrdtbl = data_base.Srch(query);


                int cnt = recrdtbl.Rows.Count;

                if (cnt == 0)
                {

                    query = "delete from Customer_Record where Customer_ID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
                    data_base.InsDelUpdt(query);
                    MessageBox.Show("Customer Record is Deleted");
                }
                else
                {
                    MessageBox.Show("You have to return the movie first");

                }


                query = "select * from Customer_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Customer Record ");
            }
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            customerID.Text = "";

        }

        private void DataRental_Click(object sender, EventArgs e)
        {
            //display the whole record of the rental videos in the data grid view
            RentID = 1;
            String query = "select * from Rental_Record";
            DataTable recordTbl = new DataTable();
            recordTbl = data_base.Srch(query);
            data.DataSource = recordTbl;
            CustID = 0;
            MovID = 0;

        }

        private void data_DoubleClick(object sender, EventArgs e)
        {
            //display the record after double cliking on the data grid view
            try
            {

                if (MovID == 1)
                {
                    movieID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    title.Text = data.CurrentRow.Cells[1].Value.ToString();
                    Ratting.Text = data.CurrentRow.Cells[2].Value.ToString();
                    Year.Text = data.CurrentRow.Cells[3].Value.ToString();
                    Cost.Text = data.CurrentRow.Cells[4].Value.ToString();

                    Video_Cost = Convert.ToInt32(data.CurrentRow.Cells[4].Value.ToString());

                    Copies.Text = data.CurrentRow.Cells[5].Value.ToString();
                    VideoCopies = Convert.ToInt32(data.CurrentRow.Cells[5].Value.ToString());

                    Plot.Text = data.CurrentRow.Cells[6].Value.ToString();
                    Genre.Text = data.CurrentRow.Cells[7].Value.ToString();

                    // MovID = 0;
                    //CustID = 0;
                    //RentID = 0;
                }

                if (CustID == 1)
                {

                    customerID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    FirstName.Text = data.CurrentRow.Cells[1].Value.ToString();
                    LastName.Text = data.CurrentRow.Cells[2].Value.ToString();
                    MobileNo.Text = data.CurrentRow.Cells[3].Value.ToString();
                    Address.Text = data.CurrentRow.Cells[4].Value.ToString();

                    //CustID = 0;
                    //MovID = 0;
                    //RentID = 0;

                }

                if (RentID == 1)
                {
                    RentalID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    customerID.Text = data.CurrentRow.Cells[1].Value.ToString();
                    movieID.Text = data.CurrentRow.Cells[2].Value.ToString();
                    Issue.Text = data.CurrentRow.Cells[3].Value.ToString();

                    //RentID = 0;
                    //MovID = 0;
                    // CustID = 0;

                }


            }
            catch (Exception es)
            {

            }




        }

        private void MovieRatting_Click(object sender, EventArgs e)
        {
            //find the video which is top most rented

            String query = "select * from Video_Cunt ORDER BY CountNo DESC";
            DataTable recrdTbl = data_base.Srch(query);
            MessageBox.Show("Top Most Viewed Movie ID is==" + recrdTbl.Rows[0]["MovieID"]);




        }

        private void CustomerRatting_Click(object sender, EventArgs e)
        {
            // find the customer who get the video on rent top most
            String query = "select * from Customer_Cunt ORDER BY CountNo DESC";
            DataTable recrdTbl = data_base.Srch(query);
            MessageBox.Show("Most Video Rented By Customer ID is==" + recrdTbl.Rows[0]["CustomerID"]);

        }

        private void data_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MovID == 1)
                {
                    movieID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    title.Text = data.CurrentRow.Cells[1].Value.ToString();
                    Ratting.Text = data.CurrentRow.Cells[2].Value.ToString();
                    Year.Text = data.CurrentRow.Cells[3].Value.ToString();
                    Cost.Text = data.CurrentRow.Cells[4].Value.ToString();

                    Video_Cost = Convert.ToInt32(data.CurrentRow.Cells[4].Value.ToString());

                    Copies.Text = data.CurrentRow.Cells[5].Value.ToString();
                    VideoCopies = Convert.ToInt32(data.CurrentRow.Cells[5].Value.ToString());

                    Plot.Text = data.CurrentRow.Cells[6].Value.ToString();
                    Genre.Text = data.CurrentRow.Cells[7].Value.ToString();

                    // MovID = 0;
                    //CustID = 0;
                    //RentID = 0;
                }

                if (CustID == 1)
                {

                    customerID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    FirstName.Text = data.CurrentRow.Cells[1].Value.ToString();
                    LastName.Text = data.CurrentRow.Cells[2].Value.ToString();
                    MobileNo.Text = data.CurrentRow.Cells[3].Value.ToString();
                    Address.Text = data.CurrentRow.Cells[4].Value.ToString();

                    //CustID = 0;
                    //MovID = 0;
                    //RentID = 0;

                }

                if (RentID == 1)
                {
                    RentalID.Text = data.CurrentRow.Cells[0].Value.ToString();
                    customerID.Text = data.CurrentRow.Cells[1].Value.ToString();
                    movieID.Text = data.CurrentRow.Cells[2].Value.ToString();
                    Issue.Text = data.CurrentRow.Cells[3].Value.ToString();

                    //RentID = 0;
                    //MovID = 0;
                    // CustID = 0;

                }


            }
            catch (Exception es)
            {

            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //closing the Desktop Application
            Close();
            System.Windows.Forms.Application.Exit();
        }

        private void rentalDelete_Click(object sender, EventArgs e)
        {
            //delete the rental movie record ony if it is returned 
            if (!RentalID.Text.ToString().Equals(""))
            {
                DataTable recordtbl = new DataTable();

                String query = "select * from Rental_Record where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                recordtbl = data_base.Srch(query);

                if (recordtbl.Rows[0]["Return_Date"].ToString().Contains("Rent"))
                {
                    MessageBox.Show("Video is Issued on Rent You Can't Delete the Record ");
                }
                else
                {
                    query = "delete from Rental_Record where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                    data_base.InsDelUpdt(query);
                    MessageBox.Show("Record Is Deleted");
                    query = "select * from Rental_Record";
                    DataTable recordTbl = new DataTable();
                    recordTbl = data_base.Srch(query);
                    data.DataSource = recordTbl;


                }

            }
            customerID.Text = "";
            movieID.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            //update the customer recrod after verifing 
            if (!customerID.Text.ToString().Equals(""))

            {
                String query = "Update Customer_Record set Customer_FirstName='" + FirstName.Text.ToString() + "',Customer_LastName='" + LastName.Text.ToString() + "',Customer_Mobile='" + MobileNo.Text.ToString() + "',Customer_Address='" + Address.Text.ToString() + "' where Customer_ID=" + Convert.ToInt32(customerID.Text.ToString()) + "";
                data_base.InsDelUpdt(query);
                MessageBox.Show("Customer Record is Updated");
                query = "select * from Customer_Record";
                DataTable recordTbl = new DataTable();
                recordTbl = data_base.Srch(query);
                data.DataSource = recordTbl;

            }
            else
            {
                MessageBox.Show("Select the Customer Record ");
            }

            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            customerID.Text = "";



        }

        private void dataCustomer_Click(object sender, EventArgs e)
        {
            //get the whole record of the cutomer from the table and pass to the data grid view
            CustID = 1;
            String query = "select * from Customer_Record";
            DataTable recordTbl = new DataTable();
            recordTbl = data_base.Srch(query);
            data.DataSource = recordTbl;
            MovID = 0;
            RentID = 0;


        }

        private void rentalReturn_Click(object sender, EventArgs e)
        {

            //return the movie after double cliking in the data grid view and display the charges of the customer
            if (chkRental() == 1)
            {

                DataTable recordtbl = new DataTable();


                String query = "select * from Rental_Record where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                recordtbl = data_base.Srch(query);


                if (recordtbl.Rows[0]["Return_Date"].ToString().Contains("Rent"))
                {

                    query = "select * from Video_Record where Video_ID=" + Convert.ToInt32(movieID.Text.ToString()) + "";
                    DataTable recordtbl1 = new DataTable();

                    recordtbl1 = data_base.Srch(query);

                    Video_Cost = Convert.ToInt32(recordtbl1.Rows[0]["Video_Cost"].ToString());



                    Video_Cost = rental_obj.rentalCost(Video_Cost, Issue.Value.ToString(), Return.Value.ToString());

                    query = "Update  Rental_Record set Customer_ID='" + customerID.Text.ToString() + "',Movie_ID='" + movieID.Text.ToString() + "',Rental_Date='" + Issue.Value.Date.ToString() + "',Return_Date='" + Return.Value.Date.ToString() + "' where Rental_ID=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
                    data_base.InsDelUpdt(query);

                    MessageBox.Show("Video is returned and Charges is==$" + Video_Cost);

                    query = "select * from Rental_Record";
                    DataTable recordTbl = new DataTable();
                    recordTbl = data_base.Srch(query);
                    data.DataSource = recordTbl;


                }
                else
                {
                    MessageBox.Show("Video is already Returned");
                }




            }
            else
            {
                MessageBox.Show("Enter Proper Details");
            }
            err = 0;
            customerID.Text = "";
            movieID.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";
            title.Text = "";
            Year.Text = "";
            Ratting.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";

        }
    }
}
