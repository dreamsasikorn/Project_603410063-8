using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_603410063_8
{
    public partial class คำนวณค่าห้อง : Form
    {
        public คำนวณค่าห้อง()
        {
            InitializeComponent();
        }
        int difwater, diffire;//กำหนดให้ difwater,diffire มาเก็บค่าผลต่างของค่าน้ำและค่าไฟ
        int presentwater,pastwater;//สร้างตัวแปรpresentwater,pastwater มาเก็บค่ามาตรวัดน้ำ 
        int presentfire,pastfire; //สร้างตัวแปรpresentfire,pastfire มาเก็บค่ามาตรวัดไฟ
        int calwater = 0;//กำหนดให้calwater ที่ใช้ในการเก็บค่าน้ำเท่ากับศูนย์ 
        int calfire = 0;//กำหนดให้calfire ที่ใช้ในการเก็บค่าไฟเท่ากับศูนย์ 
        int sumnormal = 0,sumair = 0;//กำหนดให้ sumnormal,sumair=0;
        int Receipts=0;//กำหนดให้ตัวแปรReceiptsที่ใช้ในการเก็บใบเสร็จเท่ากับศูนย์

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (room.Text == "ห้องธรรมดา(2300บาท)")//ถ้าcomboboxเท่ากับ"ห้องธรรมดา(2300บาท)"
            {
                difwater = 0;diffire = 0;//ผลต่างของค่าน้ำ ค่าไฟ กำหนดค่าเริ่มต้นเป็นศูนย์
                bool checkpresentwater = int.TryParse(wtmeter1.Text,out presentwater);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                bool checkpastwater = int.TryParse(wtmeter2.Text,out pastwater);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                bool checkpresentfire = int.TryParse(Firegauge1.Text,out presentfire);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                bool checkpastfire = int.TryParse(Firegauge2.Text,out pastfire);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                calwater = 0;//กำหนดให้ค่าน้ำเท่ากับศูนย์
                calfire = 0;//กำหนดให้ค่าไฟเท่ากับศูนย์
                sumnormal = 0;//ให้ผลรวมห้องธรรมดาทั้งหมดเท่ากับศูนย์ (ค่าห้อง + ค่าน้ำ + ค่าไฟ)
                
                //ค่าน้ำ
                    if (presentwater - pastwater >=0 && presentwater - pastwater < 4)//ถ้ามาตรวัดครั้งปัจจุบัน-ครั้งก่อนแล้วมากกว่าหรือเท่ากับ0 และ น้อยกว่า4
                    {
                        difwater = 0;//ผลต่างของค่าน้ำเท่ากับศูนย์
                    }
                    else if (presentwater - pastwater > 3)//ถ้ามาตรวัดครั้งปัจจุบัน-ครั้งก่อน แล้ว>3 ให้เข้าสูตร
                    {
                        difwater = presentwater - pastwater; //สูตรการหาผลต่างของค่าน้ำ คือ ผลต่างของค่าน้ำ = มาตรวัดครั้งปัจจุบัน- มาตรวัดครั้งก่อน
                    }
                    else if(presentwater - pastwater < 0)//ถ้ามาตรวัดครั้งปัจจุบัน-มาตรวัดครั้งก่อน แล้ว<0 ให้
                    {
                        //MessageBox.Show("น้ำติดลบ");//MessageBox แสดงคำว่า น้ำติดลบ
                    }
               
                //ค่าไฟ
                    if (presentfire - pastwater >= 0)//ถ้ามาตรวัดครั้งปัจจุบัน-ครั้งก่อน แล้ว>3 ให้เข้าสูตร
                    {
                        diffire = presentfire - pastfire;//สูตรการหาผลต่างของค่าไฟ คือ ผลต่างของค่าไฟ = มาตรวัดครั้งปัจจุบัน- มาตรวัดครั้งก่อน
                    }
                    else if ( presentfire - pastfire < 0)//ถ้ามาตรวัดครั้งปัจจุบัน-มาตรวัดครั้งก่อน แล้ว<0 ให้
                    {
                        //MessageBox.Show("ไฟติดลบ");//MessageBox แสดงคำว่า ไฟติดลบ
                    }
                    if (checkpresentwater == false || checkpresentfire == false//ตรวจสอบว่าถ้าค่าที่ป้อนเข้าไปในช่องของมาตรวัดน้ำไม่ถูกต้อง หรือ
                        || checkpastwater == false || checkpastfire == false //ตรวจสอบว่าถ้าค่าที่ป้อนเข้าไปในช่องมาตรวัดไฟไม่ถูกต้อง หรือ
                        || presentwater - pastwater < 0 || presentfire - pastfire < 0)//มาตรวัดน้ำ และ มาตรวัดไฟ ครั้งปัจจุบัน-ครั้งก่อน <0
                    {
                        MessageBox.Show("ค่าไม่ถูกต้อง กรุณาป้อนค่าใหม่");//ให้ MessageBox แสดงคำว่า "ค่าไม่ถูกต้อง กรุณาป้อนค่าใหม่"
                    }
                else//นอกเหนือเงื่อนไข
                {
                    calwater = difwater * 10;//ให้ ค่าน้ำ = ผลต่างของค่าน้ำ *10
                    calfire = diffire * 8;//ให้ ค่าไฟ = ผลต่างของค่าไฟ*8
                    sumwater.Text = calwater.ToString();//เก็บผลค่าน้ำและแปลงเป็นตัวอักษรมาแสดงผลในช่อง sumwater
                    sumFire.Text = calfire.ToString();//เก็บผลค่าไฟและแปลงเป็นตัวอักษรมาแสดงผลในช่อง sumFire
                    sumnormal = calwater + calfire + 2300;//ห้องธรรมดา=ค่าน้ำ+ค่าไฟ+2300
                    totalRoom.Text = sumnormal.ToString();//เก็บผลค่าห้องธรรมดาและแปลงเป็นตัวอักษรมาแสดงผลในช่อง totalRoom
                }
            }
            //ห้องแอร์
            else if (room.Text == "ห้องแอร์(2700บาท)")
            {
                difwater = 0;
                diffire = 0;//ผลต่างของค่าน้ำ ค่าไฟ กำหนดค่าเริ่มต้นเป็นศูนย์
                bool checkpresentwater = int.TryParse(wtmeter1.Text, out presentwater);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                bool checkpastwater = int.TryParse(wtmeter2.Text, out pastwater);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                bool checkpresentfire = int.TryParse(Firegauge1.Text, out presentfire);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                bool checkpastfire = int.TryParse(Firegauge2.Text, out pastfire);//แปลงตัวอักษรเป็นตัวเลข แลัวตรวจว่าถูกต้องไหม ถ้าถูกจะถูกส่งไปที่ textbox
                calwater = 0;calfire = 0; sumair = 0;//กำหนดให้ค่าน้ำ ค่าไฟเท่ากับศูนย์ ให้ผลรวมห้องแอร์ทั้งหมดเท่ากับศูนย์ (ค่าห้อง + ค่าน้ำ + ค่าไฟ)
                //ค่าน้ำ
                    if (presentwater - pastwater >= 0 && presentwater - pastwater < 4)//ถ้ามาตรวัดครั้งปัจจุบัน-ครั้งก่อนแล้วมากกว่าหรือเท่ากับ0 และ น้อยกว่า4
                    {
                        difwater = 0;//ผลต่างของค่าน้ำเท่ากับศูนย์
                    }
                    else if (presentwater - pastwater > 3)//ถ้ามาตรวัดครั้งปัจจุบัน-ครั้งก่อน แล้ว>3 ให้เข้าสูตร
                    {
                        difwater = presentwater - pastwater;//สูตรการหาผลต่างของค่าน้ำ คือ ผลต่างของค่าน้ำ = มาตรวัดครั้งปัจจุบัน- มาตรวัดครั้งก่อน
                    }
                    else//นอกเหนือเงื่อนไข
                    {
                    //   MessageBox.Show("หน่วยมาตรวัดต้องไม่ติดลบ กรุณาป้อนข้อมูลใหม่");// ให้MessageBoxแสดงคำว่า หน่วยมาตรวัดต้องไม่ติดลบ กรุณาป้อนข้อมูลใหม่
                    }
                //ค่าไฟ
                    if (presentfire - pastwater >= 0)//ถ้ามาตรวัดครั้งปัจจุบัน-ครั้งก่อน แล้ว>3 ให้เข้าสูตร
                    {
                        diffire = presentfire - pastfire;//สูตรการหาผลต่างของค่าไฟ คือ ผลต่างของค่าไฟ = มาตรวัดครั้งปัจจุบัน- มาตรวัดครั้งก่อน
                    }
                    else//นอกเหนือเงื่อนไข
                    {
                    //   MessageBox.Show("หน่วยมาตรวัดต้องไม่ติดลบ กรุณาป้อนข้อมูลใหม่");// ให้MessageBoxแสดงคำว่า หน่วยมาตรวัดต้องไม่ติดลบ กรุณาป้อนข้อมูลใหม่
                    }
                    if (checkpresentwater == false || checkpresentfire == false //ตรวจสอบว่าถ้าค่าที่ป้อนเข้าไปในช่องของมาตรวัดน้ำไม่ถูกต้อง หรือ
                    || checkpastwater == false || checkpastfire == false //ตรวจสอบว่าถ้าค่าที่ป้อนเข้าไปในช่องมาตรวัดไฟไม่ถูกต้อง หรือ
                    || presentwater - pastwater < 0 || presentfire - pastfire < 0)//มาตรวัดน้ำ และ มาตรวัดไฟ ครั้งปัจจุบัน-ครั้งก่อน <0
                    {
                        MessageBox.Show("ค่าไม่ถุกต้อง กรุณาป้อนค่าใหม่");//ให้ MessageBox แสดงคำว่า "ค่าไม่ถูกต้อง กรุณาป้อนค่าใหม่"
                    }
                else
                {
                    calwater = difwater * 10;//ให้ ค่าน้ำ = ผลต่างของค่าน้ำ *10
                    calfire = diffire * 8;//ให้ ค่าไฟ = ผลต่างของค่าไฟ*8
                    sumwater.Text = calwater.ToString();//เก็บผลค่าน้ำและแปลงเป็นตัวอักษรมาแสดงผลในช่อง sumwater
                    sumFire.Text = calfire.ToString();//เก็บผลค่าไฟและแปลงเป็นตัวอักษรมาแสดงผลในช่อง sumFire
                    sumair = calwater + calfire + 2700;//ห้องแอร์=ค่าน้ำ+ค่าไฟ+2700
                    totalRoom.Text = sumair.ToString();//เก็บผลค่าห้องแอร์และแปลงเป็นตัวอักษรมาแสดงผลในช่อง totalRoom
                }

            }
            else//นอกเหนือเงื่อนไข
            {
                MessageBox.Show("อย่าลืมเลือกห้อง กับ กรอกตัวเลข");//ให้MessageBox แสดงคำว่าอย่าลืมเลือกห้อง กับ กรอกตัวเลข
            }
            if (totalRoom.Text == string.Empty)//ถ้าช่องtotalRoom ว่าง
            {
                filebill.Enabled = false;//ให้ปุ่มfilebillกดไม่ได้ 
            }
            else//นอกเหนือเงื่อนไข
            {
                filebill.Enabled = true;//ให้ปุ่มfilebill กดได้
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

            wtmeter1.Text = string.Empty;//ลบข้อความในwtmeter1 โดยใช้คำสั่งstring.Empty
            wtmeter2.Text = string.Empty;//ลบข้อความในwtmeter2 โดยใช้คำสั่งstring.Empty
            sumwater.Text = string.Empty;//ลบข้อความในsumwater โดยใช้คำสั่งstring.Empty
            Firegauge1.Text = string.Empty;//ลบข้อความในFiregauge1 โดยใช้คำสั่งstring.Empty
            Firegauge2.Text = string.Empty;//ลบข้อความในFiregauge2 โดยใช้คำสั่งstring.Empty
            sumFire.Text = string.Empty;//ลบข้อความในsumFire โดยใช้คำสั่งstring.Empty
            totalRoom.Text = string.Empty;//ลบข้อความในtotalRoom โดยใช้คำสั่งstring.Empty
            room.Text = "-";//ให้combobox = "-"
            if (totalRoom.Text == string.Empty)//ถ้าช่องtotalRoom ว่าง
            {
                filebill.Enabled = false;//ให้ปุ่มfilebillกดไม่ได้ 
            }
            else//นอกเหนือเงื่อนไข
            {
                filebill.Enabled = true;//ให้ปุ่มfilebill กดได้
            }
        }

        private void คำนวณค่าห้อง_Load(object sender, EventArgs e)
        {

        }

        private void wtmeter2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Firegauge1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Firegauge2_TextChanged(object sender, EventArgs e)
        {

        }

        private void wtmeter1_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void filebill_Click(object sender, EventArgs e)
        {
            Receipts = Receipts + 1;//ให้จำนวนใบเสร็จเพิ่มขึ้นทีละ1
            string filename = "bill-" + Receipts + ".txt";//ให้ชื่อใบเสร็จ เท่ากับ คำว่า bill + จำนวนใบเสร็จ+ด้วยนามสกุล .txt
            if (room.Text == "ห้องธรรมดา(2300บาท)")//ถ้าcombobox =ห้องธรรมดา(2300บาท)
            {
                string bill = "ใบเสร็จหอพัก"//ให้ bill = "ใบเสร็จหอพัก"
                    + Environment.NewLine + "======================="//ขึ้นบรรทัดใหม่ + "======================="
                    + Environment.NewLine + "ค่าห้อง\t\t2300"//+ขึ้นบรรทัดใหม่ + "ค่าห้อง"+"2300"
                    + Environment.NewLine + "ค่าน้ำ\t\t" + calwater//ขึ้นบรรทัดใหม่ + ค่าน้ำ
                    + Environment.NewLine + "ค่าไฟ\t\t" + calfire//ขึ้นบรรทัดใหม่ + ค่าไฟ
                    + Environment.NewLine + "======================="//ขึ้นบรรทัดใหม่ + "======================="
                    + Environment.NewLine + "รวม\t\t" + sumnormal;//ขึ้นบรรทัดใหม่ +รวมค่าห้องทั้งหมด
                File.WriteAllText(filename, bill);//สร้างไฟล์ใบเสร็จขึ้นมา
            }
            else //นอกเหนือเงื่อนไข
            {
                string bill = "ใบเสร็จหอพัก"//ให้ bill = "ใบเสร็จหอพัก"
                    + Environment.NewLine + "======================="//+ขึ้นบรรทัดใหม่ + "======================="
                    + Environment.NewLine + "ค่าห้อง\t\t2700"//+ขึ้นบรรทัดใหม่ + "ค่าห้อง"+"2700"
                    + Environment.NewLine + "ค่าน้ำ\t\t" + calwater//ขึ้นบรรทัดใหม่ + ค่าน้ำ
                    + Environment.NewLine + "ค่าไฟ\t\t" + calfire//ขึ้นบรรทัดใหม่ + ค่าไฟ
                    + Environment.NewLine + "======================="//ขึ้นบรรทัดใหม่ + "======================="
                    + Environment.NewLine + "รวม\t\t" + sumair;//ขึ้นบรรทัดใหม่ +รวมค่าห้องทั้งหมด
                File.WriteAllText(filename, bill);//สร้างไฟล์ใบเสร็จขึ้นมา
            }

        }
    }
}
