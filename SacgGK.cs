using System;
class SachGK():SachSV()
{
 private string tinhTrang;
 private thanhtien;
 private int number;
    
 public SachGk(){
     base();
 }
 public SachGk(string tinhTrang, int number){
 base();
 this.tinhTrang=tinhTrang;
 this.number=number;
 }
 public string gettTinhTrang(){
     return tinhTrang;
 }
 public void setTinhTrang(string tinhTrang){
     this.tinhTrang=tinhTrang;
 }
 public int getNumber() {
		return number;
	}


	public void setNumber(int number) {
		this.number = number;
	}

	public String tinhTrangSach(int x) {
		switch (number) {
			case 0:
				tinhTrang = "cu";
				break;
			case 1:
				tinhTrang = "m?i";
				break;
			default:
				break;
		}
		return tinhTrang;
	}
	public new void Nhap(){
	    base.Nhap();
	    Console.WriteLine("Nhp trinh trang sach (0 - cu/1 - m?i: "+this.number);
	}
	public thanhtien(){
	    if(this.number="M?i")
	    thanhtien = this.soluong*this.dongia;
	    else if(this.number="Cu")
	    thanhtien = this.soluong*this.dongia*50%;
	    return thanhtien;
	    public new void In(){
	        Console.WriteLine("Tình tr?ng Sách : {0} || Thành Ti?n : {1}", this.number,this.thanhtien);
	    }
}
public static void Main( string [] args){
    SachGk str = new SachGk;
    str.Nhap();
    str.In();
    str.thanhtien();
    Console.ReadLine();
}
