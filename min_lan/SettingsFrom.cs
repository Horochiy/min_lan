using System;
using System.Windows.Forms;

namespace min_lan
{
    public partial class SettingsForm : Form
    {
        public string memory = "";
        
        // Конструктор
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Конпка "Закрыть"
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_alt;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Поддержка перемещения окна
        public void MoveVindow(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        // Универсальный обработчик нажатия на кнопку
        private void button_Click(object sender, EventArgs e)
        {
            Button memoryButton = (Button)sender;
            memory = memoryButton.Text;
            this.Hide();
        }
    }
}