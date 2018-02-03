using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightTest
{
    public partial class Form1 : Form
    {
        List<Location> warehouseLocation = new List<Location>();
        bool fileUpload = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportLocations_Click(object sender, EventArgs e)
        {

            try
            {
                
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Select File";
                openDialog.InitialDirectory = @"c:\";
                openDialog.Filter = "Text Document(*.txt)|*txt|All Files(*.*)|*.*";
                openDialog.RestoreDirectory = true;
                if(openDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openDialog.FileName != "")
                    {
                        string pathFile = openDialog.FileName;
                       
                        
                        List<string> lines = File.ReadAllLines(@pathFile).ToList();

                        foreach(var line in lines)
                        {
                            string[] entries = line.Split(',');

                            Location newLocation = new Location();

                            newLocation.X = entries[0];
                            newLocation.Y = entries[1];

                            warehouseLocation.Add(newLocation);
                        }
                        MessageBox.Show("Locations Imported!");
                        fileUpload = true;
                    }
                    else
                    {
                        MessageBox.Show("Chose Doc path ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCalculateDistances_Click(object sender, EventArgs e)
        {
            if(txtX.Text == "")
            {
                MessageBox.Show("Please enter coordinate X!");
            }else if(txtY.Text == "")
            {
                MessageBox.Show("Please enter coordinate Y!");
            }else if(fileUpload == false)
            {
                MessageBox.Show("Please Import Locations!");
            }
            else
            {
                foreach (var location in warehouseLocation)
                {
                    try
                    {
                        int x1 = Int32.Parse(txtX.Text);
                        int y1 = Int32.Parse(txtY.Text);

                        int x2 = Int32.Parse($"{location.X}");
                        int y2 = Int32.Parse($"{location.Y}");

                        

                        DistanceCalc distance = new DistanceCalc();

                        ListViewItem lvi = new ListViewItem($"{location.X}");
                        lvi.SubItems.Add($"{location.Y}");
                        lvi.SubItems.Add(distance.Calcule(x1,y1,x2,y2));
                        lvwWarehouseLocations.Items.Add(lvi);

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }


           
        }
    }
 
}
