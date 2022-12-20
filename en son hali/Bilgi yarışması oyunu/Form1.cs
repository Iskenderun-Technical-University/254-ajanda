namespace Bilgi_yarışması_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        int puan = 0;
        
        private void btnbaslat_Click(object sender, EventArgs e)
        {
            
            
            sayac++;
            btnbaslat.Text = "Sonraki Soru";

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnbaslat.Enabled = false;

            btnA.BackColor=Color.Gray;
            btnB.BackColor=Color.Gray;
            btnC.BackColor=Color.Gray;
            btnD.BackColor=Color.Gray;


            if (sayac == 1) 
            {
                btnA.Text = "Sysbase";
                btnB.Text = "dataBASE";
                btnC.Text = "Informix";
                btnD.Text = "mySQL";
                sorukısmı.Text = "veri tabanı yönetim sistemlerinden biri değildir?";
                label5.Text = "Sysbase";

            }

            if (sayac == 2)
            {
                btnA.Text = "0";
                btnB.Text = "1";
                btnC.Text = "2";
                btnD.Text = "128";
                sorukısmı.Text = "dizilerde index değeri default olarak kaçtan başlar?";
                label5.Text = "0";
            }
            if (sayac == 3)
            {
                btnA.Text = "Garbage Collection";
                btnB.Text = "CLR";
                btnC.Text = "Base class library";
                btnD.Text = "CIL";
                sorukısmı.Text = "Aşağıdakilerden hangisi .NET framework içerisinde tanımlı değildir ?";
                label5.Text = "CLR";
            }
            if (sayac == 3)
            {
                btnA.Text = "Garbage Collection";
                btnB.Text = "CLR";
                btnC.Text = "Base class library";
                btnD.Text = "CIL";
                sorukısmı.Text = "Aşağıdakilerden hangisi .NET framework içerisinde tanımlı değildir ?";
                label5.Text = "CLR";
            }
            if (sayac == 4)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
            if (sayac == 5)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
            if (sayac == 6)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
            if (sayac == 7)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
            if (sayac == 8)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
            if (sayac == 9)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
            if (sayac == 10)
            {
                btnA.Text = "Sistem başlangıcında";
                btnB.Text = "Toplu bir iş akışı başlatılması(batch job)";
                btnC.Text = "Kullanıcının talebi ile proses oluşturulması ";
                btnD.Text = "Bir proses tarafından thread_create() prosedürünün çağrılması ";
                sorukısmı.Text = "Aşağıdakilerden hangisi proseslerin oluşturduğu durumlardan biri değildir";
                label5.Text = "Sistem başlangıcında";
            }
        }

        private void lblpuan_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label4.Text = btnA.Text;
            if (label4.Text == label5.Text) {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnA.BackColor= Color.Green;

            }
            else
            {
                btnA.BackColor = Color.Red;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label4.Text=btnB.Text;
            
            if (label4.Text == label5.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnB.BackColor= Color.Green;

            }
            else
            {
                btnB.BackColor = Color.Red;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label4.Text=btnC.Text;

            if (label4.Text == label5.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnC.BackColor= Color.Green;

            }
            else
            {
                btnC.BackColor = Color.Red;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label4.Text = btnD.Text;

            if (label4.Text == label5.Text)
            {
                puan = puan + 10;
                lblPuan.Text =puan.ToString();
                btnD.BackColor= Color.Green;

            }
            else
            {
                btnD.BackColor = Color.Red;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}