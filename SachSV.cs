using System;
class SachSV  {
  int Ma;
  string NgayNhap;
  int dongia;
  int soluong;
  public Main(){
      this.Ma="C01";
      this.NgayNhap="11/10/2018";
      this.dongia="100000";
      this.soluong="2";
  }
  public void Nhap(){
      Console.WriteLine("Nhap Ma: ");
      this.Ma=int.parse(Console.ReadLine());
      Console.WriteLine("Ngay Nhap: ")'
      this.NgayNhap=string.parse(Console.ReadLine());
      Console.WriteLine("Don Gia: ");
      this.dongia=int.parse(Console.ReadLine());
      Console.WriteLine("So luong: ");
      this.soluong=int.parse(Console.ReadLine());
  }
  public void In(){
      Console.WriteLine("Ma là {0} NgayNhap la {1} DonGia là {2} SoLuong la {3}",this.Ma,this.NgayNhap,this.dongia,this.soluong);
  }
}
 public static void Main(string [] args){
     SachSV st = new SachSV();
     st.Nhap();
     st.In();
     Console.ReadLine();
 }
