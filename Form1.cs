using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LastOne
{
    public partial class Form1 : Form
    {
        private Game game = new Game(new int[] { });
        private Dictionary<PlayerStatus, System.Drawing.Bitmap> statusBitmaps = new Dictionary<PlayerStatus, Bitmap>() 
        { 
            { PlayerStatus.Normal, global::LastOne.Properties.Resources.portrait1 },
            { PlayerStatus.Submit, global::LastOne.Properties.Resources.portrait2 },
            { PlayerStatus.Waiting, global::LastOne.Properties.Resources.portrait6 },
            { PlayerStatus.Win, global::LastOne.Properties.Resources.win },
            { PlayerStatus.Lose, global::LastOne.Properties.Resources.lose }
        };
        private string[] names = { "Player1", "Player2" };

        private int size = 100;
        private int margin = 10;

        private Control waitingStart = null;

        public Form1()
        {
            InitializeComponent();

            #region init form

            waitingStart = panel1.Controls["label5"];

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Player1");

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            initGame();

            foreach (Control ctrl in this.Controls.OfType<Control>().Where(x => x.Enabled && (x is TextBox || x is ComboBox || (x.Name.ToLower().Equals("button3")))))
            {
                ctrl.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.reset();

            foreach (Control ctrl in this.Controls.OfType<Control>().Where(x => x is TextBox || x is ComboBox || (x.Name.ToLower().Equals("button3"))))
            {
                ctrl.Enabled = true;
            }

            panel1.Controls.Clear();
            panel1.Controls.Add(waitingStart);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (sender as PictureBox);

            picture.Tag = !((bool)picture.Tag);
            picture.Image = drawPictureImage(picture.Size.Width, picture.Size.Height, (((bool)picture.Tag) ? Color.Gray : Color.DimGray));

            game.CurrentPlayer.pickup(picture.Name);

            if (panel1.Controls.OfType<PictureBox>().Count(x => x.Name.StartsWith(picture.Name.Split(new char[]{'_'},2).First()) && ((bool)x.Tag) == true) < 1)
            {
                panel1.Controls.OfType<PictureBox>().Where(x => !x.Enabled).ToList().ForEach((pic) =>
                {
                    pic.Image = drawPictureImage(pic.Size.Width, pic.Size.Height, Color.DimGray);
                    pic.Enabled = true;
                });
            }
            else
            {
                panel1.Controls.OfType<PictureBox>().Where(x => x.Enabled == true && !x.Name.StartsWith((sender as Control).Name.Split(new char[] { '_' }, 2).First())).ToList().ForEach((pic) =>
                {
                    pic.Image = drawPictureImage(pic.Size.Width, pic.Size.Height, Color.LightGray);
                    pic.Enabled = false;
                });
            }
        }

        private void Player_Submit(object sender, EventArgs e) 
        {
            game.CurrentPlayer.submit();
        }

        public void initGame()
        {
            int[] countForRow = { };
            int[] eachTimeCanTake = { };

            try
            {
                countForRow = textBox1.Text.Trim().Split(new char[] { ',', '|' }).Select(x => int.Parse(x)).ToArray();
            }
            catch (Exception ex1)
            {
                countForRow = new int[] { 3, 5, 7 };
            }

            try
            {
                eachTimeCanTake = textBox2.Text.Trim().Split(new char[] { ',', '|' }).Select(x => int.Parse(x)).ToArray();
            }
            catch (Exception ex2)
            {
                eachTimeCanTake = new int[] { };
            }

            size = ((int)Math.Floor(double.Parse((panel1.Width - (margin * (countForRow.Max() + 1))).ToString()) / double.Parse(countForRow.Max().ToString())));

            game = new Game(countForRow);
            game.GameStatusChanged += new GameEvent((obj, args) =>
            {
                drawScene(((int[])((object[])args.Result).First()), (((object[])args.Result).Last() as IEnumerable<Player>));
            });

            game.addPlayer(new Player(names.First(), PlayerStatus.Waiting) { CountForTakes = eachTimeCanTake }, comboBox1.SelectedIndex == 0 ? true : false);
            game.addPlayer(new Player(names.Last(), PlayerStatus.Waiting) { CountForTakes = eachTimeCanTake }, comboBox1.SelectedIndex == 1 ? true : false);

            game.start();
        }

        public void drawScene(int[] matrix,IEnumerable<Player> players)
        {
            var container = panel1;

            if (container.Controls.Count > 0)
                (container as ScrollableControl).Controls.Clear();

            matrix.Select((x, i) => new { Index = i, Value = x }).ToList().ForEach((i) =>
            {
                int pos = 0;

                while (pos < i.Value)
                {
                    PictureBox pic = new PictureBox();
                    pic.Click += PictureBox_Click;
                    pic.Size = new Size(size, size);
                    pic.Cursor = Cursors.Hand;
                    pic.Tag = false;
                    pic.Image = drawPictureImage(size, size, Color.DimGray);
                    pic.Name = string.Format("pic{0}_{1}_{2}", i.Index, pos, i.Value);
                    pic.Location = new Point((margin + size) * pos + margin, (margin + size) * i.Index + margin);
                    container.Controls.Add(pic);

                    pos++;
                }
            });
            
            foreach (Player player in players)
            {
                foreach (Control ctrl in panel2.Controls.OfType<Control>().Concat(panel3.Controls.OfType<Control>()).Where(x => x.Name.ToLower().StartsWith(player.Name.ToLower())))
                {
                    if (ctrl is PictureBox)
                        (ctrl as PictureBox).Image = statusBitmaps[player.Status];

                    if (ctrl is Button)
                    {
                        ctrl.Enabled = player.Status.Equals(PlayerStatus.Submit);
                        ctrl.Visible = player.Status == PlayerStatus.Submit || player.Status == PlayerStatus.Waiting;

                        (ctrl as Button).Text = player.Status.ToString();
                    }

                    if (ctrl is Label)
                        ctrl.Text = player.Name;
                }
            }
        }

        internal static Image drawPictureImage(int width, int height, Color color) 
        {
            var img = new Bitmap(width, height);
            
            Graphics g = Graphics.FromImage(img);
            Rectangle rect = new Rectangle(0, 0, width - 1, height - 1);
            Pen pen = new Pen(color);
            Brush brush = new SolidBrush(color);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawEllipse(pen, rect);
            g.FillEllipse(brush, rect);

            return img;
        }
    }
}
