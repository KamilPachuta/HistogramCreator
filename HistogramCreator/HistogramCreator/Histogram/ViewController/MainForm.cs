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
            radioButtonAsm.Checked = true;

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
                MessageBox.Show("Choose *.jpg; *.jpeg; *.png; file.");
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
            (double[] R, double[] G, double[] B, double totalMilliseconds) = mainModel.getDataFromBitmap();

            formsPlotR.Plot.Clear();
            formsPlotG.Plot.Clear();
            formsPlotB.Plot.Clear();
            
            formsPlotR.Plot.AddBar(R, Color.Red);
            formsPlotR.Refresh();
            
            formsPlotG.Plot.AddBar(G, Color.Green);
            formsPlotG.Refresh();
            
            formsPlotB.Plot.AddBar(R, Color.Blue);
            formsPlotB.Refresh();

            labelTime.Text = $"{totalMilliseconds} ms";

        }

        private void buttonGenerateTimes_Click(object sender, EventArgs e)
        {

            double[] iR;
            double[] iG;
            double[] iB;
            double itotalMilliseconds;
            
            string resultString = "Threads\nasm\tcs\n";
            for (int i = 1; i<64; i++)
            {
                double resultASM = 0;
                double resultCS = 0;


                //for (int j = 0; j <= 10; j++)
                //{
                    mainModel = new MainModel(new Bitmap(global::Histogram.Properties.Resources.HD_wallpaper_nissan_skyline_r34_gt_r_red_sports_coupe_black_wheels_red_nissan_skyline_r34_japanese_sports_cars_nissan), false, trackBarThreads.Value);
                    (iR, iG, iB, itotalMilliseconds) = mainModel.getDataFromBitmap();
                    //if(j != 0)
                        resultASM += itotalMilliseconds;

                    mainModel = new MainModel(new Bitmap(global::Histogram.Properties.Resources.HD_wallpaper_nissan_skyline_r34_gt_r_red_sports_coupe_black_wheels_red_nissan_skyline_r34_japanese_sports_cars_nissan), true, trackBarThreads.Value);
                    (iR, iG, iB, itotalMilliseconds) = mainModel.getDataFromBitmap();
                    //if(j != 0)
                        resultCS += itotalMilliseconds;

                //}
                resultString += $"{i}\t";
                resultString += $"{resultASM / 1}\t";
                resultString += $"{resultCS / 1}\n";
            }
            File.WriteAllText($"result.txt", resultString);


        }
    }
}