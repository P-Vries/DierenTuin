using Dierentuin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Dierentuin
{
    public partial class Form1 : Form
    {
        //
        //Vars
        //
        private List<Animal> dieren;
        private int monkey_counter = 1;
        private int lion_counter = 1;
        private int elephant_counter = 1;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            dieren = new List<Animal>();
            lsbAddAnimal.DataSource = new List<string>() { "Monkey", "Lion", "Elephant","Alle Dieren" };
            dgvAnimalView.AllowUserToAddRows = false;
        }

        //
        //Methods
        //
        private void dgvUpdate()
        {
            CheckDeath();
            for (int i = 0; i < dgvAnimalView.RowCount; i++)
            {
                dgvAnimalView.Rows[i].SetValues(dieren[i].Name, dieren[i].Energy);             
            }        
        }
        private void CheckDeath()
        {
            List<int> dodenDieren = new List<int>();
            foreach (var animal in dieren)
            {
                if (animal.Energy < 0)
                {
                    dodenDieren.Add(dieren.IndexOf(animal));
                }
            }
            dodenDieren.Sort();
            dodenDieren.Reverse();
            for (int i = 0; i < dodenDieren.Count; i++)
            {
                if (dieren.Count != 1)
                {
                    dieren.RemoveAt(dodenDieren[i]);
                    dgvAnimalView.Rows.RemoveAt(dodenDieren[i]);
                }
                else
                {
                    dieren.RemoveAt(0);
                    dgvAnimalView.Rows.RemoveAt(0);
                    timer.Enabled = false;
                    monkey_counter = 1;
                    lion_counter = 1;
                    elephant_counter = 1;
                }
            }
        }

        //
        //Events
        //       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            switch (lsbAddAnimal.SelectedItem)
            {
                case "Monkey":
                    Monkey monkey = new Monkey("Monkey " + monkey_counter.ToString());
                    this.dgvAnimalView.Rows.Add(monkey.Name,monkey.Energy);
                    dieren.Add(monkey);
                    monkey_counter++;
                    break;
                case "Lion":
                    Leeuw lion = new Leeuw("Lion " + lion_counter.ToString());
                    this.dgvAnimalView.Rows.Add(lion.Name, lion.Energy);
                    dieren.Add(lion);
                    lion_counter++;
                    break;
                case "Elephant":
                    Olifant elephant = new Olifant("Elephant " + elephant_counter.ToString());
                    this.dgvAnimalView.Rows.Add(elephant.Name, elephant.Energy);
                    dieren.Add(elephant);
                    elephant_counter++;
                    break;
                default:
                    MessageBox.Show("Invalid Type");
                    break;
            }
            timer.Enabled = true;
           
        }
        private void btnFeed_Click(object sender, EventArgs e)
        {
            switch (lsbAddAnimal.SelectedItem)
            {
                case "Monkey":
                    foreach (var item in dieren.OfType<Monkey>())
                    {
                        item.Eat();
                    }
                    dgvUpdate();
                    break;
                case "Lion":
                    foreach (var item in dieren.OfType<Leeuw>())
                    {
                        item.Eat();
                    }
                    dgvUpdate();
                    break;
                case "Elephant":
                    foreach (var item in dieren.OfType<Olifant>())
                    {
                        item.Eat();
                    }
                    dgvUpdate();
                    break;
                case "Alle Dieren":
                    foreach (var item in dieren)
                    {
                        item.Eat();
                    }
                    dgvUpdate();
                    break;

                default:
                    MessageBox.Show("Invalid Type");
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 500;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            foreach (Animal animal in dieren)
            {
                animal.UseEnergy();
            }
            Invoke(new Action(() => { dgvUpdate(); }));

        }
    }
}
