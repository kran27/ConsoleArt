using AltUI.Forms;
using ImageTools;
using System.Text;
using System.Runtime.InteropServices;

namespace ConsoleArt
{
    public partial class Form1 : DarkForm
    {
        private Color[] palette;
        private Tools.DirectBitmap ogBitmap;
        private Tools.DirectBitmap procImage;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // open file dialog
            var open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() != DialogResult.OK) return;
            // display image in picture box
            ogBitmap = new Bitmap(open.FileName).ToDirectBitmap();
            procImage = ogBitmap.ResizeFit((int)numericUpDown1.Value, (int)numericUpDown2.Value * 2);
            procImage = checkBox1.Checked ? procImage.Dither(palette) : procImage.SetPalette(palette);
            pictureBox1.BackgroundImage = procImage.Bitmap;
            pictureBox1.Refresh();
            imgToCode();
        }

        private string colToConCol(Color col)
        {
            if (col == palette[0])
                return "ConsoleColor.Black";
            if (col == palette[1])
                return "ConsoleColor.DarkRed";
            if (col == palette[2])
                return "ConsoleColor.DarkGreen";
            if (col == palette[3])
                return "ConsoleColor.DarkYellow";
            if (col == palette[4])
                return "ConsoleColor.DarkBlue";
            if (col == palette[5])
                return "ConsoleColor.DarkMagenta";
            if (col == palette[6])
                return "ConsoleColor.DarkCyan";
            if (col == palette[7])
                return "ConsoleColor.Gray";
            if (col == palette[8])
                return "ConsoleColor.DarkGray";
            if (col == palette[9])
                return "ConsoleColor.Red";
            if (col == palette[10])
                return "ConsoleColor.Green";
            if (col == palette[11])
                return "ConsoleColor.Yellow";
            if (col == palette[12])
                return "ConsoleColor.Blue";
            if (col == palette[13])
                return "ConsoleColor.Magenta";
            if (col == palette[14])
                return "ConsoleColor.Cyan";
            return col == palette[15] ? "ConsoleColor.White" : "ConsoleColor.Black";
        }

        private ConsoleColor colToConCol2(Color col)
        {
            if (col == palette[0])
                return ConsoleColor.Black;
            if (col == palette[1])
                return ConsoleColor.DarkRed;
            if (col == palette[2])
                return ConsoleColor.DarkGreen;
            if (col == palette[3])
                return ConsoleColor.DarkYellow;
            if (col == palette[4])
                return ConsoleColor.DarkBlue;
            if (col == palette[5])
                return ConsoleColor.DarkMagenta;
            if (col == palette[6])
                return ConsoleColor.DarkCyan;
            if (col == palette[7])
                return ConsoleColor.Gray;
            if (col == palette[8])
                return ConsoleColor.DarkGray;
            if (col == palette[9])
                return ConsoleColor.Red;
            if (col == palette[10])
                return ConsoleColor.Green;
            if (col == palette[11])
                return ConsoleColor.Yellow;
            if (col == palette[12])
                return ConsoleColor.Blue;
            if (col == palette[13])
                return ConsoleColor.Magenta;
            if (col == palette[14])
                return ConsoleColor.Cyan;
            return col == palette[15] ? ConsoleColor.White : ConsoleColor.Black;
        }

        private void imgToCode()
        {
            // turn image into string, each row of 2 pixels becomes one row of characters, foreground is top pixel, bg is bottom
            var sb = new StringBuilder();
            sb.Append("void horribleFunction()\r\n{\r\n\tConsole.ResetColor();\r\n");
            var lfg = palette[7];
            var lbg = palette[0];
            var ly = 0;
            for (var y = 0; y < procImage.Height; y += 2)
            {
                for (var x = 0; x < procImage.Width; x++)
                {
                    var fg = procImage.GetPixel(x, y);
                    var bg = procImage.GetPixel(x, y + 1);
                    if (fg == lfg && bg == lbg)
                    {
                        if (ly == y)
                        {
                            sb.Remove(sb.Length - 5, 5);
                            sb.Append("\\u2580\");\r\n");
                        }
                        else
                            sb.Append("\tConsole.Write(\"\\u2580\");\r\n");
                    }
                    else if (fg == lfg)
                        sb.Append($"\tConsole.BackgroundColor = {colToConCol(bg)};\r\n\tConsole.Write(\"\\u2580\");\r\n");
                    else if (bg == lbg)
                        sb.Append($"\tConsole.ForegroundColor = {colToConCol(fg)};\r\n\tConsole.Write(\"\\u2580\");\r\n");
                    else
                        sb.Append($"\tConsole.ForegroundColor = {colToConCol(fg)};\r\n\tConsole.BackgroundColor = {colToConCol(bg)};\r\n\tConsole.Write(\"\\u2580\");\r\n");
                    lfg = fg;
                    lbg = bg;
                    ly = y;
                }
                sb.Append("\tConsole.WriteLine();\r\n");
            }
            sb.Remove(sb.Length - 23, 23);
            sb.Append("\tConsole.ResetColor();\r\n}");

            var code = sb.ToString();
            richTextBox1.Text = code;
        }

        private static bool IsKeyword(string word)
        {
            string[] keywords = new string[] { "using", "public", "class", "static", "void", "Main", "string", "Console", "WriteLine" };
            return Array.IndexOf(keywords, word) != -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            palette = new Color[]
            {
                Color.FromArgb(12, 12, 12),
                Color.FromArgb(197, 15, 31),
                Color.FromArgb(19, 161, 14),
                Color.FromArgb(193, 156, 0),
                Color.FromArgb(0, 55, 218),
                Color.FromArgb(136, 23, 152),
                Color.FromArgb(58, 150, 221),
                Color.FromArgb(204, 204, 204),
                Color.FromArgb(118, 118, 118),
                Color.FromArgb(231, 72, 86),
                Color.FromArgb(22, 198, 12),
                Color.FromArgb(249, 241, 165),
                Color.FromArgb(59, 120, 255),
                Color.FromArgb(180, 0, 158),
                Color.FromArgb(97, 214, 214),
                Color.FromArgb(242, 242, 242),
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procImage = ogBitmap.ResizeFit((int)numericUpDown1.Value, (int)numericUpDown2.Value * 2);
            procImage = checkBox1.Checked ? procImage.Dither(palette) : procImage.SetPalette(palette);
            pictureBox1.BackgroundImage = procImage.Bitmap;
            imgToCode();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            AllocConsole();
            
            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = false;
            //Console.WindowWidth = procImage.Width + 1;
            //Console.WindowHeight = procImage.Height / 2 + 1;
            for (var y = 0; y < procImage.Height; y += 2)
            {
                for (var x = 0; x < procImage.Width; x++)
                {
                    var fg = procImage.GetPixel(x, y);
                    var bg = procImage.GetPixel(x, y + 1);
                    Console.ForegroundColor = colToConCol2(fg);
                    Console.BackgroundColor = colToConCol2(bg);
                    Console.Write("\u2580");
                }
                //writeline if not on last line
                if (y < procImage.Height - 2)
                    Console.WriteLine();
            }
        }
    }
}