using System;
using System.Collections.Generic;
using Repository.Models;
using System.Text;
using Repository;

namespace HousingQueue
{
    class HousingQueueApp
    {
        /// <summary>
        /// Starts the application and shows the menu
        /// </summary>
        public void Start()
        {
            while (true)
            {
                bool exit = false;

                int selectedMenuOption = ShowMenu();

                switch (selectedMenuOption)
                {
                    case 1:
                        CreateMember();
                        break;
                    case 2:
                        CreateResidence();
                        break;
                    case 3:
                        ShowMembers();
                        break;
                    case 4:
                        ShowResidences();
                        break;
                    case 5:
                        DeleteMember();
                        break;
                    case 6:
                        UpdateMember();
                        break;
                    case 7:
                        CreateApplication();
                        break;
                    case 8:
                        ShowApplications();
                        break;
                    default:
                        exit = true;
                        break;
                }

                if (exit)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Shows the menu to the user and lets hte user pick an option
        /// </summary>
        /// <returns>The selected option of the user</returns>
        private int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Create member");
            Console.WriteLine("2. Create residence");
            Console.WriteLine("3. Show members");
            Console.WriteLine("4. Show residences");
            Console.WriteLine("5. Delete member");
            Console.WriteLine("6. Update member");
            Console.WriteLine("7. Create application");
            Console.WriteLine("8. Show applications");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            int selectedOption = 0;
            int.TryParse(input, out selectedOption);

            return selectedOption;
        }

        /// <summary>
        /// Lets the user input member properties and saves member to database
        /// </summary>
        private void CreateMember()
        {
            Console.Clear();

            Console.WriteLine("Creating member...");

            Console.Write("Enter name: ");
            string memberName = Console.ReadLine();

            Console.Write("Enter queue points: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int queuePoints);

            Console.Write("Enter yearly salary: ");
            input = Console.ReadLine();
            int.TryParse(input, out int yearlySalary);

            Member member = new Member(memberName, queuePoints, yearlySalary);

            MemberRepository.SaveMember(member);
        }

        /// <summary>
        /// Lets the user input residence properties and saves the residence to the database
        /// </summary>
        private void CreateResidence()
        {
            Console.Clear();

            Console.WriteLine("Creating residence...");

            Console.Write("Select (a)partment or (h)ouse: ");
            string residenceType = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter living area: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int livingArea);

            Console.Write("Enter monthly cost: ");
            input = Console.ReadLine();
            int.TryParse(input, out int monthlyCost);

            if (residenceType.ToLower() == "a")
            {
                CreateApartment(address, livingArea, monthlyCost);
            }
            else if (residenceType.ToLower() == "h")
            {
                CreateHouse(address, livingArea, monthlyCost);
            }
        }

        /// <summary>
        /// Lets the user create an application
        /// </summary>
        private void CreateApplication()
        {
            Console.Clear();

            Console.WriteLine("Creating application...");

            Member applyingMember = SelectMember();

            Residence residence = SelectResidence();

            Application application = new Application(applyingMember.Id, residence.Id);

            ApplicationRepository.SaveApplication(application);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// lets the user input parameters to create a apartment
        /// </summary>
        /// <param name="address">The apartments address</param>
        /// <param name="livingArea">The apartments living area</param>
        /// <param name="monthlyCost">The cost per month of living in the apartment</param>
        private void CreateApartment(string address, int livingArea, int monthlyCost)
        {
            Console.Write("Enter floor number: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int floor);

            Console.Write("Is there an elevator? (y/n): ");
            input = Console.ReadLine();
            bool hasElevator = (input.ToLower() == "y");

            Apartment apartment = new Apartment(address, livingArea, monthlyCost, floor, hasElevator);

            ApartmentRepository.SaveApartment(apartment);
        }

        /// <summary>
        /// lets the user input parameters to create a house
        /// </summary>
        /// <param name="address">The houses address</param>
        /// <param name="livingArea">The houses living area</param>
        /// <param name="monthlyCost">The cost per month of living in the house</param>
        private void CreateHouse(string address, int livingArea, int monthlyCost)
        {
            Console.Write("Enter number of floors: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int floors);

            Console.Write("Enter plot area: ");
            input = Console.ReadLine();
            int.TryParse(input, out int plotArea);

            House house = new House(address, livingArea, monthlyCost, floors, plotArea);

            HouseRepository.SaveHouse(house);
        }

        /// <summary>
        /// Prints a list of all members
        /// </summary>
        private void ShowMembers()
        {
            Console.Clear();
            Console.WriteLine("Showing members...");

            List<Member> members = MemberRepository.GetMembers();

            Console.WriteLine("Name - Queue points - Yearly salary");
            foreach (Member member in members)
            {
                Console.WriteLine($"{member.Name} - {member.QueuePoints} - {member.YearlySalary}");
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Prints a list of all residences
        /// </summary>
        private void ShowResidences()
        {
            Console.Clear();
            Console.WriteLine("Showing residences...");

            List<House> houses = HouseRepository.GetHouses();
            List<Apartment> apartments = ApartmentRepository.GetApartments();

            Console.WriteLine("Address - Living area - Monthly cost - Floors - Plot area");
            foreach (House house in houses)
            {
                Console.WriteLine($"{house.Address} - {house.LivingArea} - {house.MonthlyCost} - {house.Floors} - {house.PlotArea}");
            }


            Console.WriteLine("\nAddress - Living area - Monthly cost - Floor - Has elevator");
            foreach (Apartment apartment in apartments)
            {
                Console.WriteLine($"{apartment.Address} - {apartment.LivingArea} - {apartment.MonthlyCost} - {apartment.Floor} - {apartment.HasElevator}");
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private void ShowApplications()
        {
            Console.Clear();
            Console.WriteLine("Showing applications");

            Residence residence = SelectResidence();

            List<Application> applications = ApplicationRepository.GetApplicationsByResidenceId(residence.Id);

            Console.WriteLine("Order applications by what?!");
            Console.Write("(Q): QueuePoints, (S): Salary, (SP): SalaryPoints: ");

            string sortParameter = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"{residence.Address} - {residence.MonthlyCost} kr/m");

            List<Member> members = new List<Member>();

            foreach (Application application in applications)
            {
                Member member = MemberRepository.GetMemberById(application.MemberId);
                members.Add(member);
            }

            members = MemberSorter.Sort(members, sortParameter);

            foreach (Member member in members)
            {
                Console.WriteLine(member.Name);
                Console.WriteLine("Queue points: " + member.QueuePoints);
                Console.WriteLine("Salary: " + member.YearlySalary);
                Console.WriteLine("SalaryPoints: " + member.GetSalaryPoints());
                Console.WriteLine();
            }

            if (applications.Count == 0)
            {
                Console.WriteLine("No applications yet...");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Lets the user select a member to delete
        /// </summary>
        private void DeleteMember()
        {
            Console.Clear();
            ShowMembers();

            Console.WriteLine("Deleteing member...");
            Console.Write("Choose member name to delete: ");
            string input = Console.ReadLine();

            MemberRepository.DeleteMemberByName(input);
        }

        /// <summary>
        /// Lets the user update a member in the db
        /// </summary>
        private void UpdateMember()
        {
            Member memberToUpdate = SelectMember();

            Console.Write("Enter name: ");
            string memberName = Console.ReadLine();

            Console.Write("Enter queue points: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int queuePoints);

            Console.Write("Enter yearly salary: ");
            input = Console.ReadLine();
            int.TryParse(input, out int yearlySalary);

            MemberRepository.UpdateMember(memberToUpdate.Id, memberName, queuePoints, yearlySalary);
        }

        /// <summary>
        /// Lets the user select a member
        /// </summary>
        /// <returns>The selected member</returns>
        private static Member SelectMember()
        {
            List<Member> members = MemberRepository.GetMembers();

            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {members[i].Name}");
            }

            Console.Write("Select member: ");
            string input = Console.ReadLine();
            int selectedNumber = int.Parse(input);
            return members[selectedNumber - 1];
        }

        /// <summary>
        /// Lets the user select a residence
        /// </summary>
        /// <returns>The selected residence</returns>
        private static Residence SelectResidence()
        {
            List<Residence> residences = new List<Residence>();
            List<House> houses = HouseRepository.GetHouses();
            List<Apartment> apartments = ApartmentRepository.GetApartments();

            residences.AddRange(houses);
            residences.AddRange(apartments);

            for (int i = 0; i < residences.Count; i++)
            {
                Console.WriteLine($"{i+1}: {residences[i].Address}");
            }

            Console.Write("Select residence: ");
            string input = Console.ReadLine();
            int selectedNumber = int.Parse(input);
            return residences[selectedNumber - 1];
        }
    }
}
