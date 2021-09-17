
namespace Manhattan
{
    public class Point
    {
        public int _X;
        public int _Y;
        public Point(int x, int y)
        {
            _X = x;
            _Y = y;
        }
        public int ContrastX(Point point)
        {
            var px = System.Math.Abs(_X - point._X);
            return px;
        }
        public int ConstrastY(Point point)
        {
            var py= System.Math.Abs(_Y - point._Y);
            return py;
        }
    }
}
