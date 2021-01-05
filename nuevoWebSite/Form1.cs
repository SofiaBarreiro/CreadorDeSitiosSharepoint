using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Navigation;
using Microsoft.SharePoint.Library;
using System.Collections.Specialized;

namespace nuevoWebSite
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
            SPSite site = new SPSite(TextBoxSite.Text);


            SPWeb web = site.OpenWeb();
            SPWebCollection subsite = web.Webs;
            SPWeb newWeb = subsite.Add(textBox5.Text, textBox1.Text, "prueba sitio creado con SOM", 1034, "STS#0", false, false);
            MessageBox.Show("sitio creado");

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPSite site = new SPSite(TextBoxSite.Text);
            SPWeb web = site.RootWeb.Webs[textBox5.Text];
            //SPNavigationNode node = new SPNavigationNode("link nuevo", "http://www.google.com.ar", true);
            //web.Navigation.QuickLaunch.AddAsLast(node);
            //web.Navigation.TopNavigationBar.AddAsLast(node);
            MessageBox.Show("Node created");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SPSite site = new SPSite(TextBoxSite.Text);
            SPWeb web = site.RootWeb.Webs[textBox5.Text];
            Guid newGuid = web.Lists.Add(parametroURLLista.Text, NombreLista.Text, SPListTemplateType.GenericList);
            SPList list = web.Lists[parametroURLLista.Text];



            //agregar columnas

            list.Fields.Add("Nombre", SPFieldType.Text, false);
            list.Fields.Add("Apellido", SPFieldType.Text, false);
            list.Fields.Add("Pais", SPFieldType.Text, false);
            list.Fields.Add("Fecha", SPFieldType.DateTime, false);

            //list.Fields.Delete("Nombre");

            //MessageBox.Show("field deleted");


            StringCollection viewFields = new StringCollection();
            viewFields.Add("Nombre");
            viewFields.Add("Apellido");
            viewFields.Add("Pais");
            viewFields.Add("Fecha");

            //MessageBox.Show("list created");


            //string query = "<Where><Eq><FieldRef Name=\"Pais\"/>" + "<Value Type=\"Text\">USA</Value></Eq></Where>";

            //list.Views.Add("Vista USA", viewFields, query, 100, true, false);
            list.Views.Add("Vista USA", viewFields, null, 100, true, false);

            //MessageBox.Show("view created");


        }

      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
