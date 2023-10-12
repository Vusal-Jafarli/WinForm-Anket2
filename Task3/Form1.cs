using System.Text.Json;
using Task2;

namespace Task3
{
    public partial class Anket : Form
    {
        List<AnketObject> anket_names = new List<AnketObject>();
        List<AnketObject> ankets_in_listbox = new List<AnketObject>();
        public Anket()
        {
            InitializeComponent();
        }


        private void save_button_Click(object sender, EventArgs e)
        {

            string? anketler_json = File.ReadAllText("..\\..\\..\\Json Files\\Anketler.json");
            List<AnketObject>? anketler = JsonSerializer.Deserialize<List<AnketObject>>(anketler_json);

            foreach (var item in ankets_in_listbox)
            {
                anketler?.Add(item);

            }
            string? json = JsonSerializer.Serialize(anketler);
            File.WriteAllText("..\\..\\..\\Json Files\\Anketler.json", json);
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();
            string? anketler_json = File.ReadAllText("..\\..\\..\\Json Files\\Anketler.json");
            List<AnketObject>? anketler = JsonSerializer.Deserialize<List<AnketObject>>(anketler_json);

            foreach (var item in anketler)
            {
                list_box.Items.Add(item);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AnketObject new_anket = new AnketObject(name_text_box.Text, surname_text_box.Text, email_text_box.Text, phone_text_box.Text, dateTimePicker1.Text);
            ankets_in_listbox.Add(new_anket);
            list_box.Items.Add(new_anket);

            name_text_box.Clear();
            surname_text_box.Clear();
            email_text_box.Clear();
            phone_text_box.Clear();

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();
            name_text_box.Clear();
            surname_text_box.Clear();
            email_text_box.Clear();
            phone_text_box.Clear();
        }

        private void list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? listbox = sender as ListBox;
            AnketObject? anket = listbox.SelectedItem as AnketObject;
            if (anket != null)
            {
                name_text_box.Text = anket.Name;
                surname_text_box.Text = anket.Surname;
                email_text_box.Text = anket.Email;
                phone_text_box.Text = anket.Phone;
                dateTimePicker1.Text = anket.Birthday;

            }
        }

        private void replace_button_Click(object sender, EventArgs e)
        {

            AnketObject? selected_anket = list_box.SelectedItem as AnketObject;
            string? anketler_json = File.ReadAllText("..\\..\\..\\Json Files\\Anketler.json");
            List<AnketObject>? anketler = JsonSerializer.Deserialize<List<AnketObject>>(anketler_json);

            foreach (var item in anketler)
            {
                if (item.Id == selected_anket.Id)
                {
                    item.Name = name_text_box.Text;
                    item.Surname = surname_text_box.Text;
                    item.Email = email_text_box.Text;
                    item.Phone = phone_text_box.Text;
                    item.Birthday = dateTimePicker1.Text;
                }

            }
            string? json = JsonSerializer.Serialize(anketler);
            File.WriteAllText("..\\..\\..\\Json Files\\Anketler.json", json);

            list_box.Items.Clear();
            foreach (var item in anketler)
            {
                list_box.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Save Ankets";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            ////Sadece anketlerin adlarini .txt file-a yazmaq ucun
            string? anketler_json = File.ReadAllText("..\\..\\..\\Json Files\\Anketler.json");
            List<AnketObject>? anketler = JsonSerializer.Deserialize<List<AnketObject>>(anketler_json);
            string data = null;
            foreach (var item in anketler)
                data = data + item.ToString() + '\n';

            var file = openFileDialog1.ShowDialog();
            if (file == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;

                ////Sadece anketlerin adlarini yazmaq ucun
                //File.WriteAllText(filename, data);

                //Json file -i birbasa .txt fayla kocurmek ucun
                File.WriteAllText(filename, anketler_json);
            }

        }
    }
}