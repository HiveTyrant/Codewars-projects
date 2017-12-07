using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ball
{
    public string ballType { get; set; }

    public Ball() : this("regular") {}

    public Ball(string ballType)
    {
        this.ballType = ballType;
    }
}
