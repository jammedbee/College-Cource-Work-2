using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyWinForms
{
    public partial class WindowHotelActions : Form
    {
        private byte[] ImageToByte(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }

        private Image ByteToImage(byte[] image)
        {
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(image, 0, image.Length);
            Bitmap bitmap = new Bitmap(memoryStream);
            return bitmap;
        }

        private SqlConnection ActiveConnection { get; set; }

        private delegate void Del();

        private int HotelID { get; set; }

        private int CityID { get; set; }

        public WindowHotelActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        public WindowHotelActions(SqlConnection connection,
            int hotelID,
            string hotelName,
            string hotelAddress,
            int hotelRating,
            decimal hotelNightCost,
            int hotelFoodType,
            byte[] hotelPhoto,
            int cityID)
        {
            InitializeComponent();
            ActiveConnection = connection;
            HotelID = hotelID;
            CityID = cityID;
            Del del = () =>
            {
                textBoxName.Text = hotelName;
                textBoxAddress.Text = hotelAddress;
                numericUpDownRating.Value = hotelRating;
                numericUpDownNightCost.Value = hotelNightCost;
                comboBoxFoodType.SelectedValue = hotelFoodType;
                pictureBoxPhoto.Image = ByteToImage(hotelPhoto);
            };
            del();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void GetDataFromServer()
        {
            SqlCommand sqlCommand = new SqlCommand("EXEC AllFoodTypes", ActiveConnection);

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            comboBoxFoodType.DataSource = dataSet.Tables[0];
            comboBoxFoodType.ValueMember = "#";
            comboBoxFoodType.DisplayMember = "Название";
            comboBoxFoodType.SelectedIndex = HotelID;

            sqlCommand.CommandText = "EXEC AllCities";
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter.Fill(dataSet1);
            comboBoxCity.DataSource = dataSet1.Tables[0];
            comboBoxCity.ValueMember = "#";
            comboBoxCity.DisplayMember = "Название";
            comboBoxCity.SelectedIndex = CityID;
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBoxPhoto.Image = Image.FromFile(imagePath);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] image = ImageToByte(pictureBoxPhoto.Image);

            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"NewHotel",
                Connection = ActiveConnection,
                CommandType = CommandType.StoredProcedure
            };

            sqlCommand.Parameters.Add("@hotelName", SqlDbType.NChar);
            sqlCommand.Parameters.Add("@hotelAddress", SqlDbType.NChar);
            sqlCommand.Parameters.Add("@hotelRating", SqlDbType.SmallInt);
            sqlCommand.Parameters.Add("@hotelNightCost", SqlDbType.Money);
            sqlCommand.Parameters.Add("@hotelFoodTypeID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@hotelPhoto", SqlDbType.VarBinary);
            sqlCommand.Parameters.Add("@hotelCityID", SqlDbType.Int);

            sqlCommand.Parameters["@hotelName"].Value = textBoxName.Text;
            sqlCommand.Parameters["@hotelAddress"].Value = textBoxAddress.Text;
            sqlCommand.Parameters["@hotelRating"].Value = numericUpDownRating.Value;
            sqlCommand.Parameters["@hotelNightCost"].Value = numericUpDownNightCost.Value;
            sqlCommand.Parameters["@hotelFoodTypeID"].Value = comboBoxFoodType.SelectedIndex;
            sqlCommand.Parameters["@hotelPhoto"].Value = image;
            sqlCommand.Parameters["@hotelCityID"].Value = comboBoxCity.SelectedIndex; 

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Close();
                Owner.Activate();
            }
            else
            {
                MessageBox.Show("Не удалось добавить запись :(", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void WindowHotelActions_Load(object sender, EventArgs e)
        {
            GetDataFromServer();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            byte[] image = ImageToByte(pictureBoxPhoto.Image);

            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"UpdateHotel",
                Connection = ActiveConnection,
                CommandType = CommandType.StoredProcedure
            };

            sqlCommand.Parameters.Add("@hotelID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@hotelName", SqlDbType.NChar);
            sqlCommand.Parameters.Add("@hotelAddress", SqlDbType.NChar);
            sqlCommand.Parameters.Add("@hotelRating", SqlDbType.SmallInt);
            sqlCommand.Parameters.Add("@hotelNightCost", SqlDbType.Money);
            sqlCommand.Parameters.Add("@hotelFoodTypeID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@hotelPhoto", SqlDbType.VarBinary);
            sqlCommand.Parameters.Add("@hotelCityID", SqlDbType.Int);

            sqlCommand.Parameters["@hotelID"].Value = HotelID;
            sqlCommand.Parameters["@hotelName"].Value = textBoxName.Text;
            sqlCommand.Parameters["@hotelAddress"].Value = textBoxAddress.Text;
            sqlCommand.Parameters["@hotelRating"].Value = numericUpDownRating.Value;
            sqlCommand.Parameters["@hotelNightCost"].Value = numericUpDownNightCost.Value;
            sqlCommand.Parameters["@hotelFoodTypeID"].Value = comboBoxFoodType.SelectedIndex;
            sqlCommand.Parameters["@hotelPhoto"].Value = image;
            sqlCommand.Parameters["@hotelCityID"].Value = comboBoxCity.SelectedIndex;

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Close();
                Owner.Activate();
            }
            else
            {
                MessageBox.Show("Не удалось обновить запись :(", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
