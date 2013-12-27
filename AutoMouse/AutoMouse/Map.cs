using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMouse {

    [Serializable]
    class Map {
        /// <summary>
        /// 墙壁
        /// </summary>
        public const byte Wall = 1;

        /// <summary>
        /// 道路
        /// </summary>
        public const byte Road = 0;

        /// <summary>
        /// 曾经走过
        /// </summary>
        public const byte Pass = 2;

        /// <summary>
        /// 死角，已经探测为不能找到出口的死角
        /// </summary>
        public const byte DeadRoad = 3;

        public Map() {
            this.Rebuild(15, 15);
        }

        private int _width;

        public int Width {
            get { return _width; }
        }

        private int _height;

        public int Height {
            get { return _height; }
        }

        //_data[0] 返回第0行
        //_data[0][0] 返回第0行第0列
        //true表示是墙壁，false表示为道路。
        private byte[][] _data;

        public void Rebuild(int width, int height) {
            if (width < 3 || height < 3) {
                throw new ArgumentOutOfRangeException("width");
            }

            this._data = new byte[height][];
            for (int i = 0; i < height; i++) {
                var row = new byte[width];
                for (int j = 0; j < width; j++) {
                    row[j] = 1;
                }
                this._data[i] = row;
            }
            this._width = width;
            this._height = height;
        }

        public byte GetCell(int x, int y) {
            if (x < 0 || x >= this.Width || y < 0 || y >= this.Height) {
                return Wall;
            }
            return this._data[y][x];
        }

        public void SetCell(int x, int y, byte value) {
            this._data[y][x] = value;
        }

        private int _startX;
        private int _startY;
        private void SetStart(int x, int y) {
            if (this.GetCell(x,y) != Wall) {
                this._startX = x;
                this._startY = y;
            }
        }

        private int _endX;
        private int _endY;
        private void SetEnd(int x, int y) {
            if (this.GetCell(x, y) != Wall) {
                this._endX = x;
                this._endY = y;
            }
        }

        private System.Drawing.Point AutoSearchStartEnd(int x,int y) {

            for (int i = y; i < Height; i++) {
                for (int j = x; j < Width; j++) {
                    if ((i == 0 || j == 0 || i == this.Height -1 || j == this.Width - 1) && this.GetCell(j,i)== Road) {
                        return new System.Drawing.Point(j, i);
                    }
                }

                x = 0;
            }
            return new System.Drawing.Point(0, 0);
        }

        public void Start() {
            var s = AutoSearchStartEnd(0, 0);
            SetStart(s.X, s.Y);
            s = AutoSearchStartEnd(s.X +1 , s.Y);
            SetEnd(s.X, s.Y);

            this.SetNewLocation(this._startX, this._startY);

            do {
                if (!TryGo()) {
                    //回退
                    this.GoBack();
                }
            } while (this._currentX != _endX || this._currentY != _endY);
            
            //成功
        }

        private void GoBack() {
            this.SetCell(this._currentX, this._currentY, DeadRoad);
            var preLocation = this._stack.Pop();
            this._currentX = preLocation.X;
            this._currentY = preLocation.Y;
            this.OnChanged();
        }

        private int _currentX;

        public int CurrentX {
            get { return _currentX; }
        }
        private int _currentY;

        public int CurrentY {
            get { return _currentY; }
        }
        private Stack<System.Drawing.Point> _stack = new Stack<System.Drawing.Point>();

        private void SetNewLocation(int x, int y) {
            if (this.GetCell(x, y) == Wall) {
                throw new ArgumentOutOfRangeException("x or y");
            }
            this._currentX = x;
            this._currentY = y;
            this._stack.Push(new System.Drawing.Point(x, y));
            this.SetCell(x, y, Pass);
            this.OnChanged();
        }

        public event EventHandler Changed;
        private void OnChanged() {
            if (Changed != null) {
                this.Changed(this, EventArgs.Empty);
            }
        }

        private bool TryGo() {
            int newX;
            int newY;

            // ←
            newX = this._currentX - 1;
            newY = this._currentY;

            if (TryGo(newX,newY)){
                return true;
            }

            // 上
            newX = this._currentX;
            newY = this._currentY - 1;

            if (TryGo(newX, newY)) {
                return true;
            }

            // →
            newX = this._currentX + 1;
            newY = this._currentY;

            if (TryGo(newX, newY)) {
                return true;
            }

            // 下
            newX = this._currentX;
            newY = this._currentY + 1;

            if (TryGo(newX, newY)) {
                return true;
            }

            return false;
        }

        private bool TryGo(int x, int y) {
            if (this.GetCell(x,y) != Road) {
                return false;
            }

            this.SetNewLocation(x, y);
            return true;
        }
    }
}
