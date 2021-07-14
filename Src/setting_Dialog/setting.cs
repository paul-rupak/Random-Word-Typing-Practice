using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;



namespace Typing_Practice
{
    public partial class setting : Form
    {

        private const string pathSettingJSON = "D:\\favourite.json";
        public setting()
        {
            InitializeComponent();
        }

        public class favourite
        {
            public string name { get; set; }

            public List<string> selected_chars { get; set; }
        }

        public List<Button> buttons = new List<Button>();

        public List<favourite> favourites = new List<favourite>();

        public ComboBox favourite_box = new ComboBox();

        private void setting_Load(object sender, EventArgs e)
        {
            
            for (char c = '!'; c <= '}'; c++)
            {
                Button testbutton = new Button();
                testbutton.Text = c.ToString();
                testbutton.Location = new Point(70 + 50 * (buttons.Count % 15), (buttons.Count / 15) * 50 + 110);
                testbutton.Size = new Size(45, 45);
                testbutton.BackColor = Color.White;
                testbutton.Visible = true;
                testbutton.BringToFront();
                this.Controls.Add(testbutton);
                testbutton.Click += new EventHandler(key_btn_Click);

                buttons.Add(testbutton);
            }

            

            favourite_box.Location = new Point(150, 50);
            favourite_box.Size = new Size(100, 30);
            favourite_box.Text = "select favourite";
            favourite_box.BringToFront();
            this.Controls.Add(favourite_box);
            favourite_box.Visible = true;
            favourite_box.SelectedIndexChanged += new EventHandler(fav_box_SelectedIndexChanged);


            var settingJSON = File.ReadAllText(@pathSettingJSON);
            favourites = JsonConvert.DeserializeObject<List<favourite>>(settingJSON);

            foreach (var favourite in favourites)
            {
                    favourite_box.Items.Add(favourite.name);
            }

        }

        private void key_btn_Click(object sender, EventArgs e)
        {
            Button clicked_button = (Button)sender;
            if (clicked_button.BackColor == Color.White)
            {
                clicked_button.BackColor = Color.Green;
                clicked_button.ForeColor = Color.White;
            }

            else
            {
                clicked_button.BackColor = Color.White;
                clicked_button.ForeColor = Color.Black;

            }
        }

        
        private void set_btn_Click(object sender, EventArgs e)
        {

            var settingJSON = File.ReadAllText(@pathSettingJSON);
            favourites = JsonConvert.DeserializeObject<List<favourite>>(settingJSON);

            favourite temp = favourites.Find(i => i.name == "current_setting");
            temp.selected_chars.Clear();

            foreach (var button in buttons)
            {
                if (button.BackColor == Color.Green)
                {
                    temp.selected_chars.Add(button.Text);
                }
            }

            string json = JsonConvert.SerializeObject(favourites.ToArray());

            //write string to file
            File.WriteAllText(@pathSettingJSON, json);


        }

        private void add_fav_btn_Click(object sender, EventArgs e)
        {
            var myform = new Enter_fav_name(this);
            myform.Show();
        }

        private void fav_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var favourite in favourites)
            {
                if (favourite.name.Equals(((ComboBox)sender).SelectedItem))
                {
                    foreach (var btn in buttons)
                    {
                        var temp = favourite.selected_chars.Find(i => i == btn.Text);

                        if (temp != null)
                        {
                            btn.BackColor = Color.Green;
                            btn.ForeColor = Color.White;
                        }

                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.Black;
                        }
                    }

                    break;
                }
            }
        }

        private void del_fav_btn_Click(object sender, EventArgs e)
        {
            if (favourite_box.SelectedIndex < 0)
            {
                MessageBox.Show("no item selected");
                return;
            }

            if (favourite_box.SelectedItem.Equals("current_setting"))
            {
                MessageBox.Show("current setting can't be deleted");
                return;
            }

            else
            {
                favourites.Remove(favourites.Find(i => i.name.Equals(favourite_box.SelectedItem)));

                favourite_box.Items.Remove(favourite_box.SelectedItem);


                string json = JsonConvert.SerializeObject(favourites.ToArray());

                //write string to file
                File.WriteAllText(@pathSettingJSON, json);
            }
        }
    }
}
