using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    public enum Gender
    {
        male=1,female,transgender
    }
     
    class Beneficiary
    {
        //Vaccination vac = new Vaccination();
        
       
        private static int autoIncreament = 100;
        
        public int RegisterNo { get; set; }
        public string Name { get; set; }
        public long PhoneNo { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<Vaccination> VaccineDetails
        {
            get;set;
        }

        public Beneficiary(string name,long phoneNo,string city,int age,Gender gender)
        {
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.City = city;
            this.Age = age;
            this.Gender = gender;
            this.RegisterNo = autoIncreament++;
           
            
        }
       
       



       /* public void Details()
        {
            foreach(Beneficiary dt in UserDetails)
            {
                Console.WriteLine(dt.Name);
                Console.WriteLine(dt.RegisterNo);
            }

        }
      */




    }
   



}
