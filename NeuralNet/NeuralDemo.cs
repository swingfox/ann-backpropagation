using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Backprop;

namespace NeuralNet
{
    public partial class NeuralDemo : Form
    {
        private Dictionary<string, List<string>> card = new Dictionary<string, List<string>>();
        private Neural neural;
        private int INPUT = 30000;
        private int HIDDEN = 100;
        private int OUTPUT = 4;
        public NeuralDemo()
        {
            InitializeComponent();
            neural = new Neural(INPUT, HIDDEN, OUTPUT);

            LoadXMLFiles();
            lblEpoch.Text = string.Empty;
            lblCardName.Text = string.Empty;
        }

        private void LoadXMLFiles()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;

            FileStream fs = new FileStream("cards.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Collection");
            for (i = 0; i < xmlnode.Count; i++)
            {
                for (int cards = 0; cards < xmlnode[i].ChildNodes.Count; cards++)
                {
                    List<string> info = new List<string>();
                    XmlNodeList childNodeList = xmlnode[i].ChildNodes.Item(cards).ChildNodes;
                    string name = childNodeList.Item(0).InnerText.Trim();
                    string filename = childNodeList.Item(1).InnerText.Trim();
                    string output = childNodeList.Item(2).InnerText.Trim();
                    info.Add(name);
                    info.Add(output[0].ToString());
                    info.Add(output[1].ToString());
                    info.Add(output[2].ToString());
                    info.Add(output[3].ToString());
                    card.Add(filename, info);
                }
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
            }
        }

        private Thread training;
        private void btnTrain_Click(object sender, EventArgs e)
        {

            training = new Thread(() =>
            {
                for (int iter = 0; iter < 1000; iter++)
                {
                    foreach (KeyValuePair<string, List<string>> entry in card)
                    {
                        Image bm = Bitmap.FromFile(entry.Key);
                        Bitmap bitmap = new Bitmap(bm);
                        BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                        int stride = bmData.Stride;
                        System.IntPtr Scan0 = bmData.Scan0;
                        unsafe
                        {
                            byte* p = (byte*)(void*)Scan0;

                            int nOffset = stride - bitmap.Width * 3;

                            byte red, green, blue;

                            int input = 0;

                            for (int y = 0; y < bitmap.Height; ++y)
                            {
                                for (int x = 0; x < bitmap.Width; ++x)
                                {
                                    blue = p[0];
                                    green = p[1];
                                    red = p[2];

                                    neural.setInputs(input++, red);
                                    neural.setInputs(input++, green);
                                    neural.setInputs(input++, blue);
                                    p += 3;
                                }
                                p += nOffset;
                            }

                            List<string> c = card[entry.Key];
                            for (int i = 1; i < c.Count; i++)
                            {
                                neural.setDesiredOutput(i - 1, Convert.ToDouble(c[i]));
                            }
                            neural.learn();
                            bitmap.UnlockBits(bmData);
                            pictureCard.Image = bitmap;
                            Invoke((MethodInvoker)delegate
                            {
                                txtOutput1.Text = "" + neural.getOuputData(0);
                                txtOutput2.Text = "" + neural.getOuputData(1);
                                txtOutput3.Text = "" + neural.getOuputData(2);
                                txtOutput4.Text = "" + neural.getOuputData(3);
                                lblEpoch.Text = iter + "";
                                lblCardName.Text = "" + card[entry.Key][0];
                                Refresh();
                            });

                            
                        }
                    }
                    if (exitThread)
                        break;
                }
                MessageBox.Show("Training Finished!");
            });

            if(btnTrain.Text.Equals("TRAIN"))
            {
                training.Start();
                btnTrain.Text = "STOP TRAIN";
                exitThread = false;
            }
            else
            {
                training.Abort();
                btnTrain.Text = "TRAIN";
                exitThread = true;
            }
        }
        bool exitThread = false;
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openImage.ShowDialog();
            if (result == DialogResult.OK && pictureClassify.Image != null)
            {
                Bitmap bitmap = new Bitmap(pictureClassify.Image);
                int counter = 0;
                try
                {
                    BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                    int stride = bmData.Stride;
                    System.IntPtr Scan0 = bmData.Scan0;
                    unsafe
                    {
                        byte* p = (byte*)(void*)Scan0;

                        int nOffset = stride - bitmap.Width * 3;

                        byte red, green, blue;

                        for (int y = 0; y < bitmap.Height; ++y)
                        {
                            for (int x = 0; x < bitmap.Width; ++x)
                            {
                                blue = p[0];
                                green = p[1];
                                red = p[2];

                                neural.setInputs(counter++, red);
                                neural.setInputs(counter++, green);
                                neural.setInputs(counter++, blue);
                                p += 3;
                            }
                            p += nOffset;
                        }
                        neural.run();
                    }
                    List<string> output = new List<string>();

                    for(int i = 0; i < 4; i++)
                    {
                        double outputData = neural.getOuputData(i);
                        output.Add(NormalizeOutput(outputData));
                    }
                    string cardName = string.Empty;

                    foreach (KeyValuePair<string, List<string>> entry in card)
                    {
                        List<string> list = entry.Value;
                        bool isFound = true;
                        for(int i = 1; i < list.Count; i++)
                        {
                            if (!output[i - 1].Equals(list[i]))
                            {
                                isFound = false;
                                break;
                            }
                        }
                        if (isFound)
                        {
                            cardName = list[0];
                            break;
                        }
                    }

                    txtOutput1.Text = output[0];
                    txtOutput2.Text = output[1];
                    txtOutput3.Text = output[2];
                    txtOutput4.Text = output[3];
                    lblCardName.Text = cardName;
                }

                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private string NormalizeOutput(double outputData)
        {
            return outputData > 0.8 ? "1" : "0";
        }

        private void openImage_FileOk(object sender, CancelEventArgs e)
        {
            pictureClassify.Image = new Bitmap(openImage.FileName);
        }

        private const string inputWeightsFile = "input_weights.txt";
        private const string hiddenWeightsFile = "hidden_weights.txt";
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(inputWeightsFile))
            {
                INeuron[] inputNeuron = neural.InputNeurons;
                for(int i = 0; i < inputNeuron.Length; i++)
                {
                    INeuron neuron = inputNeuron[i];
                    double[] weights = neuron.Weights;
                    for (int j = 0; j < weights.Length; j++)
                    {
                        writer.WriteLine(weights[j]);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(hiddenWeightsFile))
            {
                HNeuron[] hiddenNeuron = neural.HiddenNeurons;
                for (int i = 0; i < hiddenNeuron.Length; i++)
                {
                    HNeuron neuron = hiddenNeuron[i];
                    double[] weights = neuron.Weights;
                    for (int j = 0; j < weights.Length; j++)
                    {
                        writer.WriteLine(weights[j]);
                    }
                }
            }

            MessageBox.Show("Weights Saved!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            neural = new Neural(INPUT, HIDDEN, OUTPUT);

            using (StreamReader reader = new StreamReader(inputWeightsFile))
            {
                INeuron[] inputNeuron = neural.InputNeurons;
                for (int i = 0; i < inputNeuron.Length; i++)
                {
                    double[] weights = new double[HIDDEN];
                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] = Convert.ToDouble(reader.ReadLine());
                    }
                    inputNeuron[i].LoadWeights(weights);
                }
            }

            using (StreamReader reader = new StreamReader(hiddenWeightsFile))
            {
                HNeuron[] hiddenNeuron = neural.HiddenNeurons;
                for (int i = 0; i < hiddenNeuron.Length; i++)
                {
                    double[] weights = new double[OUTPUT];
                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] = Convert.ToDouble(reader.ReadLine());
                    }
                    hiddenNeuron[i].LoadWeights(weights);
                }
            }

            MessageBox.Show("Weights Loaded!");
        }

        private void NeuralDemo_Load(object sender, EventArgs e)
        {

        }

        private void NeuralDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(training != null && training.ThreadState == ThreadState.Running)
            {
                training.Abort();
            }
        }
    }
}
