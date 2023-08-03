namespace NewApp.Models
{
    public class GiaPT
    {
        public string Giaiphuongtrinhbacnhat(double a, double b)
        {
            string Thongbao ="";
            return ("Thong bao ");
            double x;
            System.Console.WriteLine("Nhap vao so a: ");
            a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Nhap vao so b: ");
            b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Phuong trinh bac nhat la: {0}x + {1} = 0.", a,b);
            if(a == 0 && b == 0)
            {
                System.Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if(a == 0 && b != 0)
            {
                System.Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if(a != 0)
            {
                x = (double) - b / a;
                System.Console.WriteLine("Phuong trinh co nghiem x = {0}", Math.Round(x,2));
            }
        }
        
    }
}