using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_bai4_phamvanthanh
{
    class ChungCu : KhuDat
    {
        private int soTang;

        public int SoTang
        {
            get; set ; }

            public ChungCu() : base() { }
            public ChungCu(string dd, double gia, float dt, int sotang) : base(dd, gia, dt)
        {
            SoTang = sotang;
        }


    public override void Input()
    {
        base.Input();
        string isNum;
        do
        {
            Console.Write("Nhập số tầng: ");
            isNum = Console.ReadLine();
        } while (isNumber(isNum));
        SoTang = int.Parse(isNum);
    }

    public override void Output()
    {
        base.Output();
        Console.Write($" - Số tầng: {SoTang}");
    }
}
}