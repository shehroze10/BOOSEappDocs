using BOOSE;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BOOSEapp
{
    /// <summary>
    /// Main Windows Form that serves as the BOOSE drawing environment.
    /// Allows users to write and execute BOOSE programs that render shapes.
    /// </summary>
    public partial class Form1 : Form
    {
        private AppCanvas canvas;
        private AppCommandFactory factory;
        private StoredProgram program;
        private IParser parser;

        /// <summary>
        /// Initializes the Form and configures the BOOSE environment components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            Debug.WriteLine(AboutBOOSE.about());

            canvas = new AppCanvas(600, 400);
            factory = new AppCommandFactory();
            program = new StoredProgram(canvas);
            parser = new Parser(factory, program);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = (Bitmap)canvas.getBitmap();
        }

        /// <summary>
        /// Handles the Run button click event to execute BOOSE code from the text box.
        /// </summary>
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtProgram.Text;

                parser.ParseProgram(code);
                program.Run();

                pictureBox1.Image = (Bitmap)canvas.getBitmap();
                pictureBox1.Refresh();

                Debug.WriteLine("Program executed successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Run Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears the canvas and refreshes the display.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                canvas.Clear();
                pictureBox1.Image = (Bitmap)canvas.getBitmap();
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while clearing canvas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
