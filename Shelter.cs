using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagMatchDecember
{
    class Shelter
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Int32 ZipCode { get; set; }
        public Int64 Phone { get; set; }
        public string Email { get; set; }
        public int ShelterID { get; set; }

        public Shelter()
        {
            Console.WriteLine("Please register your shelter with Wag Match!\n");
            Console.Write("Please enter your shelter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter your address. ");
            Console.Write("Street Address: ");
            StreetAddress = Console.ReadLine();
            Console.Write("City: ");
            City = Console.ReadLine();
            Console.Write("State:");
            State = Console.ReadLine();

            #region zipcode
            bool correctzip = false;
            Console.WriteLine("Zip code:");
            var replyZip = Console.ReadLine();


            do
            {
                try
                {
                    if (replyZip.Length == 5)
                    {
                        ZipCode = Convert.ToInt32(replyZip);
                        correctzip = true;
                    }

                    else Console.WriteLine("We're sorry, we don't understand. Please be sure to enter a 6 digit zip code.");
                    correctzip = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    correctzip = false;
                }
            } while (correctzip = false);


            #endregion zipcode

            #region phoneNumber
            bool correctNumber = false;


            do
            {
                Console.Write("Please enter your telephone number: ");
                string replyNumber = Console.ReadLine();

                try
                {



                    if (replyNumber.Length == 10)
                    {
                        var number = Convert.ToInt64(replyNumber);
                        Phone = number;
                        correctNumber = true;


                    }
                    else
                    {
                        Console.WriteLine("There was an error with your phone number " +
                        "submission. Please enter your phone number in the correct format.");
                        correctNumber = false;

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    correctNumber = false;

                }


            }
            while (correctNumber == false);
            #endregion phoneNumber

            #region email
            bool email = false;
            do
            {
                Console.Write("Please enter your email address: ");
                string EmailAnswer = Console.ReadLine();


                if ((EmailAnswer.Contains("@") && EmailAnswer.Contains(".")))
                {
                    email = true;
                    Email = EmailAnswer;
                }
                else
                {
                    Console.WriteLine("There was an error with your e-mail " +
                    "submission. Please enter your email address in the correct format.");
                    email = false;

                }

            }
            while (email == false);
            #endregion email

        }



        public Dog DogRegistration(List<Dog> dogList)
        {
            Dog newDog = new Dog();
            string newDogAnswer = "YES";

            //add new dogs to list until don't want to add any more
            while (newDogAnswer == "YES")
            {
                Console.WriteLine("Please register your dog with Wag Match.");

                Console.Write("Please enter the dog's name: ");
                newDog.Name = Console.ReadLine();
                Console.Write("Please enter the dog's breed: ");
                newDog.Breed = Console.ReadLine();
                Console.Write("Please enter the dog's shelter ID: ");
                newDog.ShelterAssignedID = Console.ReadLine();
                Console.Write("Please enter the dog's weight in pounds: ");
                newDog.Weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the dog's gender: ");
                newDog.Gender = Console.ReadLine();
                Console.Write("Please enter an image url: ");
                newDog.ImageLink = Console.ReadLine();
                Console.Write("Please enter a video url: ");
                newDog.VideoLink = Console.ReadLine();

                Console.Clear();


                //Dog's quiz results
                newDog.getDogQuizResults();
                dogList.Add(newDog);

                Console.Write("");


                Console.Write("Would you like to add another dog? Yes or No: ");
                newDogAnswer = Console.ReadLine().ToUpper();
                if (newDogAnswer == "NO")
                {
                    continue;
                }
                else Console.WriteLine("Sorry, I didn't get that. Now exiting dog registration...");

            }
            Console.Write("All changes have been saved!");

            Console.Clear();

            return newDog;


        }
    }
}
