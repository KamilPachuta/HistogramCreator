using Histogram.Model;
using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Histogram
{
    public partial class MainForm : Form
    {
        MainModel mainModel;

        public MainForm()
        {
            InitializeComponent();
            buttonCreate.Enabled = false;
            trackBarThreads.Value = Environment.ProcessorCount;
            radioButtonCS.Checked = true;

            //instructions below are here because Form generator deleted it from Designer file every time when something change in designer.
            formsPlotR.Plot.Style(Style.Gray1);
            formsPlotG.Plot.Style(Style.Gray1);
            formsPlotB.Plot.Style(Style.Gray1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if( openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Choose *.jp; *.jpeg; *.png; file.");
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            buttonCreate.Enabled=true;
            pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            pictureBox.Refresh();
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            mainModel = new MainModel(new Bitmap(openFileDialog.FileName), radioButtonCS.Checked, trackBarThreads.Value);
            (double[] R, double[] G, double[] B, long elapsedMiliseconds) = mainModel.getDataFromBitmap();

            formsPlotR.Plot.Clear();
            formsPlotG.Plot.Clear();
            formsPlotB.Plot.Clear();
            
            formsPlotR.Plot.AddBar(R, Color.Red);
            formsPlotR.Refresh();
            
            formsPlotG.Plot.AddBar(G, Color.Green);
            formsPlotG.Refresh();
            
            formsPlotB.Plot.AddBar(R, Color.Blue);
            formsPlotB.Refresh();

            labelTime.Text = $"{elapsedMiliseconds.ToString()} ms";
        }
    }
}