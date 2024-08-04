using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPWeek4Practice
{
    public  class BaseMachine
    {
        //These are common features for Telephone and Pc
        public DateTime ProductionDate { get; private set; }
        public long SerialNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? OperatingSystem { get; set; }


        public BaseMachine() { 
        ProductionDate = DateTime.Now;
        }

        //Base Class içerisinde (BaseMakine) Üretim Tarihi, Seri Numarası,
        //Ad, Açıklama, İşletim Sistemi gibi ortak olan bilgileri yazdıran bir BilgileriYazdir()
        //metodu tanımlansın
        public virtual void DisplayAllInformation()
        {
            Console.WriteLine($"Bu ürünün adı {Name}, üretim tarihi{ProductionDate}, seri numarası: {SerialNumber}," +
                $"tanımı {Description} ve işletim sistemi {OperatingSystem}");
        }
        // ???public virtual void ProductName();
        public virtual void NameOfTheProduct()
        {
            Console.WriteLine("Ürününüzün adı: ");
        }

    }

    //BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarına miras veriniz. (Inheritance)
    public class Telephone : BaseMachine
    {
        public bool _IsTurkishLicence { get; set; }

        public virtual void NameOfTheProduct()
        {
            Console.Write("Plese enter your phone name: ");
            Name = Console.ReadLine();

            Console.WriteLine($"Your phone name: {Name}");
        }



        public void DisplayDateTime()
        {
            Console.WriteLine($"Production Date: {ProductionDate}");
        }

        //Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek
        //Base işlevinin üzerine kendilerine ait olan özelliklerinde yazdırılma işlevi eklensin.
        //(Polymorphism)
        public override void DisplayAllInformation()
        {
            Console.Write("Please enter the Serial number : ");
            SerialNumber = long.Parse(Console.ReadLine());

            Console.Write("Please describe your phone : ");
            Description = Console.ReadLine();

            Console.Write("Please enter your phone's system (İOS or Android) : ");
            OperatingSystem = Console.ReadLine();

            Console.Write("Would you like to have a Turkish licence? (true/false)   : ");
            string booleanInput = Console.ReadLine();

            if (bool.TryParse(booleanInput, out bool IsTurkishLicence))
            {
                _IsTurkishLicence = IsTurkishLicence;
            }
            else
            {
                Console.WriteLine("Invalid input. Setting default value false.");
                _IsTurkishLicence = false; // Default value if parsing fails
            }


            Console.WriteLine($"Product Serial Number: {SerialNumber} " +
                $",Described as :{Description} and operating system: {OperatingSystem}\nIs it licensed in Turkish? {(_IsTurkishLicence? "Yes" :"No")} ");

        }
    




}


    //BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarına miras veriniz. (Inheritance)
    public class Pc : BaseMachine
    {
        public bool IsBluetooth { get; set; }
        private int _NumberOfUsb;


        public virtual void NameOfTheProduct()

        {
            Console.Write("Plese enter your Pc name: ");
            Name= Console.ReadLine();

            Console.WriteLine($"Bilgisayarınızın adı: {Name}");
        }

        public void DisplayDateTime()
        {
            Console.WriteLine($"Production Date: {ProductionDate}");
        }

        public int NumberOfUsb
        {
            get { return _NumberOfUsb; }

            //Bilgisayar için Usb giriş sayısı 2 veya 4 atanabilir,
            //aksi durumda bir uyarı mesajı verilerek -1 değeri atansın. (Encapsulation)
            set
            {
                if (value == 2 || value == 4)
                {
                    _NumberOfUsb = value;
                }
                else
                {
                    Console.WriteLine("YANLIŞ USB SAYISI GİRDİNİZ!");
                    _NumberOfUsb--;

                }
            }
        }

        public override void DisplayAllInformation()
        {

            Console.Write("Please enter the Serial number : ");
            SerialNumber = long.Parse(Console.ReadLine());

            Console.Write("Please describe your Pc : ");
            Description = Console.ReadLine();

            Console.Write("Please enter your pc system (Windows or MacOs) : ");
            OperatingSystem = Console.ReadLine();

            Console.Write("Please enter the number of usb ports (2 or 4) :");
            NumberOfUsb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");


            Console.Write("Would you like to have a Bluetooth feature? (true/false): ");
            string booleanInput = Console.ReadLine();

            if (bool.TryParse(booleanInput, out bool IsTurkishLicence))
            {
                IsBluetooth = IsTurkishLicence;
            }
            else
            {
                Console.WriteLine("Invalid input. Setting default value false.");
                IsBluetooth = false; 
            }

          


            Console.WriteLine($"Product Serial Number: {SerialNumber} " +
            $",Described as :{Description} and operating system: {OperatingSystem}\n Number of usb ports :{_NumberOfUsb}" +
            $" Is there a bluetooth feature? {(IsBluetooth ? "Yes" : "No")}\n ");




        }


       

       
      


       



        //Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek
        //Base işlevinin üzerine kendilerine ait olan özelliklerinde yazdırılma işlevi eklensin.
        //(Polymorphism)
      






    }




    }




















