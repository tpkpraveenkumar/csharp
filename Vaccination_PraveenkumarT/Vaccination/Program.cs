using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    
    class Program
    {
       
        private static List<Beneficiary> UserDetails = new List<Beneficiary>();
        static void Main(string[] args)
        {
            string choice;
            Program p = new Program();
           
            
            //pr.Dosage = int.Parse(Console.ReadLine());
            UserDetails.Add(new Beneficiary("praveen", 7598395683, "cheenai", 21, (Gender)1));
            UserDetails.Add(new Beneficiary("yuvaraj", 5465465654, "cheenai", 21, (Gender)1));
            UserDetails.Add(new Beneficiary("Ajay", 5465465654, "cheenai", 21, (Gender)1));
            do
            {
                Console.WriteLine("Application For Vaccination Drive");
                Console.WriteLine("1.Beneficiary Registration \n2.Vaccination \n3.Exit");
                Console.WriteLine("Choose the option-->>");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        p.BeneficiaryRegistration();
                       
                        break;
                    case 2:
                        p.Vaccin();
                       
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;

                }
                Console.WriteLine("Do you want continue (yes/no)? ");
                choice = Console.ReadLine();
            } while (choice == "yes");

        }
        public void BeneficiaryRegistration()
        {

            Console.WriteLine("name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Phono:");
            long PhoneNo = long.Parse(Console.ReadLine());
            Console.WriteLine("City:");
            string City = Console.ReadLine();
            Console.WriteLine("Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Male \n2.Female \n3.Transgender");
            Gender Gender =(Gender)int.Parse(Console.ReadLine());
            Beneficiary add = new Beneficiary(Name, PhoneNo, City, Age, Gender);
            UserDetails.Add(add);
            Console.WriteLine("Registration Successfully");
            Console.WriteLine("Your Registration ID: " + add.RegisterNo);
        }
        public void Vaccin()
        {
            string choice;
            Console.WriteLine("Enter the Registratin ID:");
            int id = int.Parse(Console.ReadLine());
           
            foreach (Beneficiary data in UserDetails)
            {
                if (id == data.RegisterNo)
                {
                    do
                    {

                        Console.WriteLine("1.Take Vaccination \n2.Vaccination History \n3.Next Due Date \n4.Exit");
                        Console.Write("Choose option-->");
                        
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("1.Covid-Shield \n2.Covaccin \n3.sputnic");
                                Console.WriteLine("Which Dose you want?");
                                VaccinType vacType = (VaccinType)int.Parse(Console.ReadLine());

                                Vaccination user = new Vaccination(vacType, DateTime.Now);
                                if (data.VaccineDetails == null)
                                {

                                    data.VaccineDetails = new List<Vaccination>();
                                }
                                data.VaccineDetails.Add(user);
                                
                                Console.WriteLine("Successfully vaccinated!...");

                                break;
                            case 2:
                                foreach (Beneficiary history in UserDetails)
                                {
                                    if (history.VaccineDetails != null)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"RegisterNo: {history.RegisterNo} \nName: {history.Name} \nVaccinated Dose: {history.VaccineDetails[0].Vtype}");
                                    }
                                }

                                break;
                            case 3:
                                foreach (Beneficiary Duedate in UserDetails)
                                {
                                    if (Duedate.VaccineDetails != null)                                       
                                    {
                                        if (Duedate.VaccineDetails.Count == 1)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("You are vaccinated by "+Duedate.VaccineDetails[0].Vtype);
                                            Console.WriteLine("Your next Due Date: "+Duedate.VaccineDetails[0].VaccinatedDate.AddDays(30));
                                        }
                                        else if (Duedate.VaccineDetails.Count == 2)
                                        {
                                            Console.WriteLine("You have completed the vaccination course. Thanks for your participation in the vaccination drive.");
                                        }
                                    }
                                    
                                }
                                break;
                            case 4:
                               
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("Please Choose Correct option.....!");
                                break;

                        }
                        Console.WriteLine("Do you want continue (yes/no)? ");
                        choice = Console.ReadLine();

                    } while (choice == "yes");
                    
                }
               

            }
           
            
        }
       /* public void Details()
        {
            foreach (Beneficiary d in UserDetails)
            {
                if (d.VaccineDetails != null)
                {
                    Console.WriteLine(d.VaccineDetails[0].Vtype);
                    Console.WriteLine(d.VaccineDetails[0].VaccinatedDate.AddDays(30));
                }
            }

        }*/


    }
}
