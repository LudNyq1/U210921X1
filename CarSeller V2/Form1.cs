using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSeller_V2
{
    
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            Cars = new List<Car>();
            InitializeComponent();
            initializeProgramMethods(); //Adds existing cars and sorts them in alphabetical order inside listBox_Cars


        }


        public void initializeProgramMethods() //List of existing cars, fills listbox and combobox with related content
        {
            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });

            foreach (Car c in Cars.OrderBy(x => x.Make)) //Adds all Car objects in cars sorted in alphabetical order to listBox Cars
            {
                listBox_Cars.Items.Add(c);
            }

            foreach (string c in Cars.Select(x => x.Color).Distinct()) //Adds all the uniqe colors to comboBoxColors
            {
                comboBoxColors.Items.Add(c);
            }
        }

        private void listBox_Cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selectedCar = (sender as ListBox).SelectedItem as Car; //Konverterrar 
            textBox_ID.Text = (selectedCar.Id).ToString();
            textBox_Make.Text = selectedCar.Make;
            textBox_Model.Text = selectedCar.Model;
            textBox_Color.Text = selectedCar.Color;
            textBox_Km.Text = (selectedCar.Km).ToString();
            textBox_Price.Text = $"{(selectedCar.Price)}kr";
            textBox_Year.Text = (selectedCar.Year).ToString();
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxColors.Items.Clear();
            string selectedColor = (sender as ComboBox).SelectedItem.ToString();

            foreach (Car c in Cars) //Only adds the cars that have the color selectedColor as attribute, to listBoxColors
            {
                if (c.Color == selectedColor)
                {
                    listBoxColors.Items.Add(c);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int i = findCar();

            Cars[i].Price = int.Parse(textBox_Price.Text);
            Cars[i].Km = int.Parse(textBox_Km.Text);
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Cars.RemoveAt(findCar());
            refreshListBox();
            clearTextBox(this);
        }
        public int findCar() //Finds the index of the Cars-object with user-entered id
        {
            return Cars.FindIndex(x => x.Id == int.Parse(textBox_ID.Text));
        }

        public void refreshListBox()
        {
            listBox_Cars.Items.Clear();
            comboBoxColors.Items.Clear();

            foreach (Car c in Cars.OrderBy(x => x.Make)) //Adds all Car objects in cars sorted in alphabetical order to listBox Cars
            {
                listBox_Cars.Items.Add(c);
            }

            foreach (string c in Cars.Select(x => x.Color).Distinct()) //Adds all the uniqe colors to comboBoxColors
            {
                comboBoxColors.Items.Add(c);
            }
        }

        public void clearTextBox(Control con) //Clear all the textboxes under "Car properties" section
        {

            foreach (Control c in con.Controls) //This code clear the textboxes
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    clearTextBox(c);
                }
            }
            textBox_ID.Clear();
            textBox_Make.Clear();
            textBox_Model.Clear();
            textBox_Color.Clear();
            textBox_Km.Clear();
            textBox_Price.Clear();
            textBox_Year.Clear();
        }
    }
}