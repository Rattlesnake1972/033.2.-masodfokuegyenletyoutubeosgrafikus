using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _033._2.masodfokuegyenletyoutubeosgrafikus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, x1, x2;

                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text); 
                c = double.Parse(textBox3.Text);

                if (a == 0) throw new DivideByZeroException();

                if (Math.Pow(b, 2) - 4 * a * c < 0)
                {
                    throw new ArithmeticException("Nincs valós gyök.");
                }

                if (Math.Pow(b, 2) - 4 * a * c == 0)
                {
                    x1 = -b / (2 * a);
                    MessageBox.Show("A másodfokú egyenlet megoldása: " + x1);
                }

                else
                {
                    x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                    x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                    MessageBox.Show("A másodfokú egyenlet megoldásai: x1=" + x1 + " x2=" + x2);
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Hibás adatmegadás, vagy üres valamelyik szövegdoboz!");
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Nem másodfokú az egyenlet!");
            }

            catch (ArithmeticException ar)
            {
                MessageBox.Show(ar.Message);
            }

            finally
            {
                this.ActiveControl = textBox1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";

            this.ActiveControl = textBox1;
        }
    }
}
