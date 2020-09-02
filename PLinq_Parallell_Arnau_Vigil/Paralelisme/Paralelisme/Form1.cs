using Json.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paralelisme
{
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();

        string nombre;
        string dni;
        string email;

        public Form1() {
            InitializeComponent();
        }


        private void toList() {
            ListViewItem _list = new ListViewItem(dni);
            _list.SubItems.Add(nombre);
            _list.SubItems.Add(email);

            listViewUserParalel.Items.Add(_list);
        }


        private void LoadJSON(bool _parallel, ListView lvId, Label label) {
            string jsonDades = File.ReadAllText("people.json");
            List<Usuari> Users = JsonConvert.DeserializeObject<List<Usuari>>(jsonDades);

            ListViewItem List;

            bool parallel = _parallel;

            if (parallel == true) {

                foreach (Usuari user in Users){
                    Parallel.Invoke(() =>
                    {
                        bool dni_empty = user.comprova_dni();
                        if (!dni_empty)
                        {
                            dni = "El DNI no es correcto";
                        }
                        else
                        {
                            dni = user.dni;
                        }
                    },
                    () =>
                    {
                        bool name_empty = user.comprova_nom();
                        if (!name_empty)
                        {
                            nombre = "No hay ningun Nombre";
                        }
                        else
                        {
                            nombre = user.name;
                        }
                    },
                    () =>
                    {
                        bool email_empty = user.comprova_mail();
                        if (!email_empty)
                        {
                            email = "El Email esta mal escrito";
                        }
                        else
                        {
                            email = user.email;
                        }
                    }
                    );
                    toList();
                }

                timer2.Text = sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff");
            }

            else if (parallel == false) {

                foreach (Usuari user in Users) {

                    bool dni_empty = user.comprova_dni();
                    if (!dni_empty) {
                        List = new ListViewItem("El DNI no es correcto");
                    }
                    else {
                        List = new ListViewItem(user.dni);
                    }

                    bool name_empty = user.comprova_nom();
                    if (!name_empty) {
                        List.SubItems.Add("No hay ningun Nombre");
                    }
                    else {
                        List.SubItems.Add(user.name);
                    }

                    bool email_empty = user.comprova_mail();
                    if (!email_empty) {
                        List.SubItems.Add("El Email esta mal escrito");
                    }
                    else {
                        List.SubItems.Add(user.email);
                    }

                    listViewUser.Items.Add(List);
                }
                label.Text = sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff");
            }
  
        }    

        private void btnCargar_Click(object sender, EventArgs e) {
          
            sw.Start();
            LoadJSON(false, listViewUser, timer1);
            sw.Stop();

            sw.Reset();

            sw.Start();
            LoadJSON(true, listViewUserParalel, timer2);
            sw.Stop();
        }

        private void listViewUserParalel_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
