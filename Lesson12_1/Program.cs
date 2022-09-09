using System.Drawing;
using static System.Console;

namespace Lesson12_1;


delegate void MyDel();
// delegate void MyDel(object sender, EventArgs args);


class Button
{
    // public event MyDel MouseUp = null!;
    // public event MyDel MouseClick = null!;
    // public event MyDel BackgroundChanged = null!;

    public event MyDel SizeChanged = null!;
    public event MyDel TextChanged = null!;
    public event MyDel LocationChanged = null!;



    private string? _text;
    public string? Text
    {
        get { return _text; }

        set
        {
            _text = value;
            TextChanged?.Invoke();
        }
    }



    private Point _location;
    public Point Location
    {
        get { return _location; }
        set
        {
            _location = value;
            LocationChanged?.Invoke();
        }
    }


    private Size _size;
    public Size Size
    {
        get { return _size; }
        set
        {
            _size = value;
            SizeChanged?.Invoke();
        }
    }
}

class Program
{

    static void Main()
    {
        Button btn = new();

        btn.Text = "File";
        btn.Size = new Size(20, 10);
        btn.Location = new Point(50, 7);


        btn.LocationChanged += () => WriteLine("LocationChanged Lambda");
        btn.LocationChanged += Btn_LocationChanged;

        btn.SizeChanged += () => WriteLine("SizeChanged");
        // btn.SizeChanged = () => { WriteLine("SizeChanged"); }; // ERROR


        btn.TextChanged += () => WriteLine("TextChanged");


        btn.Text = "New Button Name";
    }


    private static void Btn_LocationChanged()
    {
        WriteLine("Btn_LocationChanged");
    }
}