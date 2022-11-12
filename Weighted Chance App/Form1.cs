using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weighted_Chance_App
{
    public partial class Form1 : Form
    {
        public static List<Item> Items = new List<Item>();
        public static readonly int inventorySize = 27;
        public string[] listInventory = new string[inventorySize];

        List<int> InitialValues = new List<int>();

        public static Item getItem(string name)
        {
            foreach (Item i in Items)
            {
                if (i.item == name) return i;
            }

            throw new Exception("item does not exist");
        }


        public Form1()
        {
            InitializeComponent();

            this.Text = "Minecraft Chest Loot Generator";

            Items.Add(new Item("diamond", Properties.Resources.Diamond));
            Items.Add(new Item("feather", Properties.Resources.Feather));
            Items.Add(new Item("gold", Properties.Resources.GoldIngot));
            Items.Add(new Item("leather", Properties.Resources.Leather));
            Items.Add(new Item("flesh", Properties.Resources.RottenFlesh));
            Items.Add(new Item("string", Properties.Resources.String));
            Items.Add(new Item("wheat", Properties.Resources.Wheat));
            Items.Add(new Item("blank", Properties.Resources.Blank));

            InitialValues.Add((int)itemSpawnChance.Value);
            InitialValues.Add((int)diamondNum.Value);
            InitialValues.Add((int)featherNum.Value);
            InitialValues.Add((int)goldNum.Value);
            InitialValues.Add((int)leatherNum.Value);
            InitialValues.Add((int)fleshNum.Value);
            InitialValues.Add((int)stringNum.Value);
            InitialValues.Add((int)wheatNum.Value);

            numValueChanged(this, new EventArgs());

            // MC single chest je 9x3

            inventory.ColumnCount = 9;
            inventory.RowCount = 3;
            inventory.Size = new Size(784, 262);
            inventory.AutoSize = true;

            InitialChest();
        }

        void AddItemToInventory(Item item, uint position)
        {
            // Dodaj v array i updateaj tablu
            if (position > inventorySize) return;
            listInventory[position] = item.item;
        }
        void ClearListInventory()
        {
            for(int i = 0; i < inventorySize; i++)
            {
                listInventory[i] = "blank";
            }
        }
       
        void InitialChest()
        {
            ClearListInventory();

            uint i = 0;
            foreach (Item item in Items)
            {
                AddItemToInventory(item, i);
                i++;
            }

            UpdateInventory();

            itemSpawnChance.Value = InitialValues[0];
            diamondNum.Value = InitialValues[1];
            featherNum.Value = InitialValues[2];
            leatherNum.Value = InitialValues[3];
            fleshNum.Value = InitialValues[4];
            stringNum.Value = InitialValues[5];
            wheatNum.Value = InitialValues[6];
        }

        void UpdateInventory()
        {
            // Clear i onda po arrayu stvori
            inventory.Controls.Clear();

            for (int i = 0; i < inventorySize; i++)
            {
                PictureBox pb = new PictureBox
                {
                    Size = new Size(80, 80),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = getItem(listInventory[i]).resource
                };

                inventory.Controls.Add(pb);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearListInventory();

            // Generiranje chesta
            int spawnRate = (int)itemSpawnChance.Value;
            int diamonds = (int)diamondNum.Value;
            int feather = (int)featherNum.Value;
            int gold = (int)goldNum.Value;
            int leather = (int)leatherNum.Value;
            int flesh = (int)fleshNum.Value;
            int spiderString = (int)stringNum.Value;
            int wheat = (int)wheatNum.Value;

            Random ran = new Random();

            Sesir sesir = new Sesir();
            sesir.dodajUSesir(diamonds, "diamond");
            sesir.dodajUSesir(feather, "feather");
            sesir.dodajUSesir(gold, "gold");
            sesir.dodajUSesir(leather, "leather");
            sesir.dodajUSesir(flesh, "flesh");
            sesir.dodajUSesir(spiderString, "string");
            sesir.dodajUSesir(wheat, "wheat");

            for(int i = 0; i < inventorySize; i++)
            {
                // flipaj coin za stvaranje itema
                int chance = ran.Next(0, 100);
                if(chance < spawnRate)
                {
                    listInventory[i] = sesir.dajIzSesira();
                }
            }

            UpdateInventory();

            MessageBox.Show(sesir.simulirajSesir(), "Nakon 1 000 000 simulacija...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitialChest();
        }

        private void numValueChanged(object sender, EventArgs e)
        {
            int diamonds = (int)diamondNum.Value;
            int feather = (int)featherNum.Value;
            int gold = (int)goldNum.Value;
            int leather = (int)leatherNum.Value;
            int flesh = (int)fleshNum.Value;
            int spiderString = (int)stringNum.Value;
            int wheat = (int)wheatNum.Value;

            int itema = diamonds + feather + gold + leather + flesh + spiderString + wheat;

            itemiUSesiru.Text = "" + itema;

            diamondPercentage.Text = ((diamonds * 100f) / itema) + " %";
            featherPercentage.Text = ((feather * 100f) / itema) + " %";
            goldPercentage.Text = ((gold * 100f) / itema) + " %";
            leatherPercentage.Text = ((leather * 100f) / itema) + " %";
            fleshPercentage.Text = ((flesh * 100f) / itema) + " %";
            stringPercentage.Text = ((spiderString * 100f) / itema) + " %";
            wheatPercentage.Text = ((wheat * 100f) / itema) + " %";
        }
    }
}
