using ControlInventario.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace ControlInventario
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon
            {
                nombre = textBox14.Text,
                municipio = textBox13.Text,
                comunidad = textBox12.Text,
                fecha = dateTimePicker2.Value,
                cp = int.Parse(textBox11.Text),
                id = int.Parse(textBox10.Text)
            };
            dataGridView2.Rows.Add(salon.nombre, salon.municipio, salon.comunidad, salon.fecha, salon.cp, salon.id);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Item articulo = new Item
            {
                sap = textBox1.Text,
                tipo = textBox2.Text,
                centroCoste = textBox3.Text,
                fecha = dateTimePicker1.Value,
                categoria = textBox4.Text,
                codigo = textBox5.Text,
                fabricante = textBox6.Text,
                caracteristicas = textBox7.Text
            };
            dataGridView1.Rows.Add(articulo.)
        }
    }
}
