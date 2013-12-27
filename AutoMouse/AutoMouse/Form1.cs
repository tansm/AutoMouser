using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoMouse {
    public partial class Form1 : Form {
        private Map _map;
        private const int CellWidth = 50;

        public Form1() {

            InitializeComponent();
            this._map = new Map();
            this._map.Changed += _map_Changed;
        }

        void _map_Changed(object sender, EventArgs e) {
            if (chkStepByStep.Checked) {
                this.panMap.Invalidate();
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }
        }

        private void panMap_Paint(object sender, PaintEventArgs e) {
            if (this._map == null) {
                return;
            }

            for (int y = 0; y < _map.Height; y++) {
                for (int x = 0; x < _map.Width; x++) {
                    Rectangle rect = new Rectangle(x * CellWidth, y * CellWidth, CellWidth, CellWidth);
                    var p = _map.GetCell(x, y);
                    
                    if (p == Map.Wall) {
                        e.Graphics.FillRectangle(Brushes.MediumVioletRed, rect);
                    }
                    else {
                        if (x == _map.CurrentX && y == _map.CurrentY) {
                            e.Graphics.FillRectangle(Brushes.YellowGreen, rect);
                        }
                        else {
                            e.Graphics.FillRectangle(Brushes.White, rect);
                        }
                    }
                    e.Graphics.DrawString(x.ToString() + "." + y.ToString(), this.Font, Brushes.Black, rect.X, rect.Y);
                }
            }
        }

        private void panMap_MouseMove(object sender, MouseEventArgs e) {
            //按下left
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                var x = e.X / CellWidth;
                var y = e.Y / CellWidth;
                byte newValue = (this.rbnWall.Checked ? (byte)1 :(byte)0);

                if (x >= 0 && x < this._map.Width && y >=0 && y < this._map.Height) {
                    if (this._map.GetCell(x,y) != newValue) {
                        this._map.SetCell(x, y, newValue);
                        var rect = new Rectangle(e.X - CellWidth, e.Y - CellWidth, CellWidth * 2, CellWidth * 2);
                        this.panMap.Invalidate(rect);
                        //this.panMap.Refresh();
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            var w = 0;
            var h = 0;
            if (int.TryParse(txtWidth.Text,out w) && int.TryParse(txtHeigth.Text,out h)
                && w > 3 && h > 3) {
                    this._map.Rebuild(w, h);
                    this.panMap.Refresh();
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            this._map.Start();
            watch.Stop();
            MessageBox.Show(string.Format("耗时：{0}", watch.Elapsed), "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRead_Click(object sender, EventArgs e) {
            this._map.Changed -= _map_Changed;

            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (var steam = System.IO.File.OpenRead(System.Environment.CurrentDirectory + @"\map.data")) {
                this._map = (Map)bf.Deserialize( steam);
                this._map.Changed += _map_Changed;
            }
            this.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (var steam = System.IO.File.OpenWrite(System.Environment.CurrentDirectory + @"\map.data")) {
                bf.Serialize(steam, this._map);
            }
        }
    }
}
