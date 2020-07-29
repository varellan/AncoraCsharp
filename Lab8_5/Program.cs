using System;

namespace Lab8_5
{
    class Tvshows
    {
        public string FirstName;
        public string LastName;
        public string DateOfBirth;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public string PhoneNumber;
        public string Email;
        public bool isSubmitted;
        public bool isAccepted;


        public Tvshows(string FirstName, string LastName, string DateOfBirth, string Address, string City, string State, int ZipCode,
               string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            isSubmitted = false;
            isAccepted = false;

        }
        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been Submitted.");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application has been Accepted.");
        }


                class DreamHouseHunters : Tvshows
        {
            public string JobTitle;
            public int CurrentAnnualIncome;
            public int WhentoBuyHouse;
            public int NumberOfBedrooms;
            public int NumberOfBathrooms;


            public DreamHouseHunters(string JobTitle, int CurrentAnnualIncome, int WhentoBuyHouse, int NumberOfBedrooms, int NumberOfBathrooms,
                   string FirstName, string LastName, string DateOfBirth, string Address, string City, string State, int ZipCode,
                   string phoneNumber, string email) : base(FirstName, LastName, DateOfBirth, Address, City, State, ZipCode, phoneNumber, email)

            {

                this.JobTitle = JobTitle;
                this.CurrentAnnualIncome = CurrentAnnualIncome;
                this.WhentoBuyHouse = WhentoBuyHouse;
                this.NumberOfBedrooms = NumberOfBedrooms;
                this.NumberOfBathrooms = NumberOfBathrooms;
            }

            public void Submit()
            {
                isSubmitted = true;
                Console.WriteLine("Application has been Submitted.");
            }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You Have Been Accepted To Dream House Hunters.");
            }


            class ParadiseIsland : Tvshows
            {


                public string Gender;
                public string NameOfSignificatOther;
                public int YearsDating;

                public ParadiseIsland(string Gender, string NameOfSignificatOther, int YearsDating,
                   string FirstName, string LastName, string DateOfBirth, string Address, string City, string State, int ZipCode,
                   string phoneNumber, string email) : base(FirstName, LastName, DateOfBirth, Address, City, State, ZipCode, phoneNumber, email)
                {

                    this.Gender = Gender;
                    this.NameOfSignificatOther = NameOfSignificatOther;
                    this.YearsDating = YearsDating;
                }
            

                public void Submit()
                {
                    isSubmitted = true;
                    Console.WriteLine("Application has been Submitted.");
                }

                public override void Accept()
                {
                    base.Accept();
                    Console.WriteLine("You Have Been Accepted To Paradise Island.");
                }


                class AboveDeck : Tvshows
                {
                    public int yearsExperience;
                    public string nationality;

                    public AboveDeck(int yearsExperience, string nationality,
                         string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
                         string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
                    {

                        this.yearsExperience = yearsExperience;
                        this.nationality = nationality;
                    }

                    public void Submit()
                    {
                        isSubmitted = true;
                        Console.WriteLine("Application has been Submitted.");
                    }

                    public override void Accept()
                    {
                        base.Accept();
                        Console.WriteLine("You've Been Excepted To Above Deck.");
                    }



                        class Program
                    {
                        static void Main(string[] args)
                        {
                            DreamHouseHunters hhContestant = new DreamHouseHunters("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                               "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

                            ParadiseIsland piContestant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles",
                                "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

                            AboveDeck adContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
                            "California", 90001, "711-333-1234", "captian@gmail.com");

                            hhContestant.Submit();
                            hhContestant.Accept();

                            piContestant.Submit();
                            piContestant.Accept();

                            adContestant.Submit();
                            adContestant.Accept();
                        }
                        }
                        
                }
            }
            }
        }
    } 
