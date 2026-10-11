namespace LaptopsGUI
{
    public partial class Form1 : Form
    {
        List<Laptop> laptops = new List<Laptop>();
        static int counter = 0;
        HashSet<int> laptops_ = new HashSet<int>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            button1.Click += Button1_Click;
            listBox2.SelectedIndexChanged += ListBox2_SelectedIndexChanged;
        }

        private void ListBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
             int index = listBox2.SelectedIndex;
            if (laptops_.Add(index))
            {
                counter = laptops_.Count();
            }
            richTextBox.Text = $"Kategória \n" +
                $" \t {laptops[index].Category.CategoryName}\n" +
                $"Képátló \n" +
                $"\t{laptops[index].Screen.Split(" - ")[0]}\n" +
                $"Felbontás \n" +
                $"\t{laptops[index].Screen.Split(" - ")[1]}\n" +
                $"Processzor \n" +
                $"\t {laptops[index].CPU} \n" +
                $"RAM \n" +
                $"\t {laptops[index].RAM} GB \n" +
                $"Háttértár(ak) \n" +
                $"\t {laptops[index].Storage} \n" +
                $"Operációs rendszer \n" +
                $"\t {laptops[index].OS} \n" +
                $"Ár \n" +
                $"\t {Math.Round(laptops[index].Price * 4.12, 0)} Ft";
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
             DialogResult response = MessageBox.Show(
                 text: $"Ön {counter} termékünket tekintette meg. Visszavárjuk!",
                 caption: " ", 
                 buttons: MessageBoxButtons.OK);
            if (response == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            Write();
            var gyar = laptops.Select(x => x.Manufacturer.ManufacturerName).Distinct().Count();
            valasztek_lb.Text = $"VÁLASSZON {gyar} GYÁRTÓ {laptops.Count()} LAPTOPJA KÖZÜL!";
            listBox2.SelectedIndex = 0 ;
        }

        private void Write()
        {
            foreach (var laptop in laptops)
            {
                listBox2.Items.Add(laptop.ToString());
            }
        }

        private void Read()
        {
            using (StreamReader o = new StreamReader("../../../forras/laptops.txt"))
            {
                o.ReadLine();
                while (!o.EndOfStream)
                {
                    var xd = o.ReadLine();
                    laptops.Add(new Laptop(xd));
                }
            }
        }
    }
}
