/*internal class Program 
{
// tính căn bậc hai
    /*static double squareRoot(int number)
        {
            double temp;
            double sr = number / 2;
 
            do
            {
                temp = sr;
                sr = (temp + (number / temp)) / 2;
            } while ((temp - sr) != 0);
            return sr;
        }*/
    /*private static void Main(string [] args)
    {
        //khai báo một biến a là số cần tính
            int a;
            //yêu cầu người dùng nhập vào số a
            Console.Write("\n Nhap vao so can tinh: ");
            a = Convert.ToInt32(Console.ReadLine());
            //gọi hàm squareRoot() đã tạo ở trên để tính căn bậc hai và hiển thị kết quả ra màn hình.
            //Kêt quả được làm trong tới 3 chữu sô thập phân
            Console.WriteLine("\n Can bac hai cua so {0} sau khi lam tron la: {1}", a , Math.Round(squareRoot(a), 3));

    }*/

        //Khai báo và gán giá trị cho 2 biến số kiểu string và int, sau đó in ra màn hình:
        /*string hoTen = "Le Thi Hoa";
        int maSV = 1921050251;
        Console.WriteLine("Sinh Vien {0} - {1} maSV", hoTen, maSV);*/

        //sử dụng để đọc 1 chuỗi ký tự nhập vào từ bàn phím và trả về chuỗi ký tự đó.
       /* Console.Write("Ho va Ten: ");
        string str = Console.ReadLine();
        Console.WriteLine("Sinh vien: " + str);*/
       
        //Khai báo và gán giá trị cho 2 hằng số kiểu string và int, sau đó in ra màn hình
        /*const string hoTen = "Le thi hoa";
        const int maSV = 1921050251;
        Console.WriteLine("Sinh vien {0} - Ma sinh vien {1}", hoTen, maSV);*/

//tính bình phương
    /// Tính bình phương của số thực double
        
       /* static void Main(string[] args)
        {
            int ketqua;
            Console.Write("\n Nhap vao so can tinh: ");
            ketqua = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bình phương là: " + ketqua);
        }

        static double BinhPhuong(double number)
        {
            double ketqua = number * number;
            return ketqua;
        }*/

using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        //Cấu trúc để tạo ra một Object từ một Class:
        //tạo ra 1 đối tượng tên là ps1 từ khuôn mẫu (class) Person
        //khơir tạo hai đối tượng từ class person
        Person ps1 = new Person();
        Person ps2 = new Person();
        Student std = new Student();
        //gán giá trị cho thuộc tính đối tượng ps1

        ps1.Name = "Nguyan Van A";
        ps1.Address = "ha noi";
        ps1.Age = 18;
        //gọi phương thưcs hiển thịthoong tin

        ps1.HienThi();

        std.StudentName = "Nguyen van b";
        std.StudentID = 123456;

        std.In();

        Person ps = new Person();
        string str = "Nguyen Van C";
        int a = 23;
        ps.HienThi2(str, a);
        Console.WriteLine("{0} nam sinh {1}", str,ps.GetYearOfBirth(a));

        GiaPT gpt = new GiaPT();
//giải phương trình bậc nhất k xây dựng class gpt
        static void Main(string[] args)
        {
            //khai báo hai biến a và b là hai cơ số mà người dùng nhập vào
            int a, b;
            //khai báo biến x là nghiệm của phương trình
            double x;
            //yêu cầu người dùng nhập vào hai số a và b
            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //hiển thị phương trình bậc nhất mà người dùng vừa nhập dưới dạng ax + b = 0
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x + {1} = 0.", a, b);
            //kiểm tra a = 0
            if(a == 0)
            {
                //nếu a = 0 và b = 0 thì phương trình vô số nghiệm
                if(b == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                }
                //nếu a = 0 và b != 0 thì phương trình vô nghiệm
                else
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
            }
            //trường hợp a != 0 thì ta tính theo công thức x = -b/a
            else
            {
                x = (double)-b / a;
                //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Math.Round(x,2));
            }
 
            
        }
    }
    



    
}

