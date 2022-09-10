using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_bai4_phamvanthanh
{
    class Program
    {
        static List<KhuDat> listKhuDat = new List<KhuDat>();
        static List<ChungCu> listChungCu = new List<ChungCu>();
        static List<NhaPho> listNhaPho = new List<NhaPho>();
        //Hàm main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }

        private static void Menu()
        {
            int chon;
           
            do
            {
                Console.Clear();
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1. Nhập danh sách khu đất.");
                Console.WriteLine("2. Nhập danh sách chung cư.");
                Console.WriteLine("3. Nhập danh sách nhà phố.");
                Console.WriteLine("4. Xuất danh sách khu đất.");
                Console.WriteLine("5. Xuất danh sách chung cư.");
                Console.WriteLine("6. Xuất danh sách nhà phố.");
                Console.WriteLine("7. Tổng giá bán của 3 loại .");
                
                Console.Write("Chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
            } while (chon > 12 && chon < 0);

            switch (chon)
            {
                case 1:
                    NhapDSKD(listKhuDat);
                    break;
                case 2:

                    NhapDSCC(listChungCu);
                    break;
                case 3:
                    NhapDSNP(listNhaPho);
                    break;
                case 4:
                    Console.WriteLine("\n=======Xuất Danh sách Khu đất=======");
                    XuatDSKD(listKhuDat);
                    break;
                case 5:
                    Console.WriteLine("\n=======Xuất Danh sách Chung cư=======");
                    XuatDSCC(listChungCu);
                    break;
                case 6:
                    Console.WriteLine("\n=======Xuất Danh sách Nhà phố=======");
                    XuatDSNP(listNhaPho);
                    break;

                case 7:
                    TongGiaBan(listKhuDat, listChungCu, listNhaPho);
                    break;

            }
            int temp;
            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("1.Nhập 1 để tiếp tục....!");
                Console.WriteLine("2. Thoát.");
                Console.Write("Mời chọn chức năng: ");
                temp = Convert.ToInt32(Console.ReadLine());
            } while (temp > 2 || temp <= 0);
            switch (temp)
            {
                case 1:
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Press any key to turn off...");
                    Console.ReadKey();
                    return;
                default:
                    break;
            }

        }

 
        private static List<KhuDat> NhapDSKD(List<KhuDat> listKhuDats)
        {
            Console.Write("Nhập so khu dat N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Khu đất=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n - Nhập khu đất {i + 1}");
                KhuDat temp = new KhuDat();
                temp.Input();
                listKhuDats.Add(temp);
            }
            return listKhuDats;
        }

       
        private static void XuatDSKD(List<KhuDat> listKhuDat)
        {
            foreach (KhuDat kd in listKhuDat)
            {
                kd.Output();
                Console.Write("\n");
            }
        }

        //Nhập danh sách chung cư
        private static List<ChungCu> NhapDSCC(List<ChungCu> listChungcus)
        {
            Console.Write("Nhập so chung cu N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Chung cư=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n - Nhập chung cư {i + 1}");
                ChungCu temp = new ChungCu();
                temp.Input();
                listChungcus.Add(temp);
            }
            return listChungcus;
        }

  
        private static void XuatDSCC(List<ChungCu> listChungCu)
        {
            foreach (ChungCu cc in listChungCu)
            {
                cc.Output();
                Console.Write("\n");
            }
        }

       
        private static List<NhaPho> NhapDSNP(List<NhaPho> listNhaPhos)
        {
            Console.Write("Nhập số nhà phố N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Nhà phố=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n - Nhập nhà thứ {i + 1}");
                NhaPho temp = new NhaPho();
                temp.Input();
                listNhaPhos.Add(temp);
            }
            return listNhaPhos;
        }


        private static void XuatDSNP(List<NhaPho> listNhaPho)
        {
            foreach (NhaPho np in listNhaPho)
            {
                np.Output();
            }
        }
        private static void TongGiaBan(List<KhuDat> khuDats, List<ChungCu> chungCus, List<NhaPho> nhaPhos)
        {
            double sumKD = 0, sumCC = 0, sumNP = 0;
            foreach (var item in khuDats)
                sumKD += item.GiaBan;

            foreach (var item in chungCus)
                sumCC += item.GiaBan;

            foreach (var item in nhaPhos)
                sumNP += item.GiaBan;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Tổng giá bán của khu đất: {sumKD}");
            Console.WriteLine($"Tổng giá bán của chung cư: {sumCC}");
            Console.WriteLine($"Tổng giá bán của nhà phố: {sumNP}");
        }
    }
}

