using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagMatchDecember
{
    class Person : QuizScore
    {
        public string Name { get; set; }
        public Int64 Phone { get; set; }
        public Int32 ZipCode { get; set; }
        public string Email { get; set; }


        public Person()
        {
            Console.WriteLine("Please register to find your Wag Mate!\n");
            Console.Write("Please enter your first and last name: ");
            var Name = Console.ReadLine();
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


        public void getPersonQuizResults() //was QuizScore, changed to void
        {
            Console.Clear();
            Console.WriteLine("Time for the personality quiz! This is how we will find your new companion matches.");


            bool Question1Check = false;
            do
            {
                Console.Write("\nIs this your first dog? Yes or No: ");
                var Question1Answer = Console.ReadLine().ToUpper();
                if (Question1Answer == "YES")
                {

                    this.Trainability = this.Trainability + 3;
                    this.Affection = this.Affection + 3;
                    Question1Check = true;
                }
                else if (Question1Answer == "NO")
                {

                    this.Trainability = this.Trainability + 2;
                    this.Affection = this.Affection + 2;
                    Question1Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question1Check = false;
                }
            }
            while (Question1Check == false);

            bool Question2Check = false;
            do
            {
                Console.Write("\nDo you live with other animals? Yes or No: ");
                var Question2Answer = Console.ReadLine().ToUpper();
                if (Question2Answer == "YES")
                {

                    this.AnimalSocialability = this.AnimalSocialability + 3;
                    Question2Check = true;
                }
                else if (Question2Answer == "NO")
                {

                    this.AnimalSocialability = this.AnimalSocialability + 1;
                    Question2Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question2Check = false;
                }
            }
            while (Question2Check == false);

            bool Question3Check = false;
            do
            {
                Console.Write("\nDo you live with children? Yes or No: ");
                var Question3Answer = Console.ReadLine().ToUpper();
                if (Question3Answer == "YES")
                {

                    this.HumanSocialability = this.HumanSocialability + 3;
                    this.Trainability = this.Trainability + 3;
                    this.Affection = this.Affection + 3;
                    Question3Check = true;
                }
                else if (Question3Answer == "NO")
                {

                    this.HumanSocialability = this.HumanSocialability + 2;
                    this.Trainability = this.Trainability + 2;
                    this.Affection = this.Affection + 2;
                    Question3Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question3Check = false;
                }
            }
            while (Question3Check == false);

            bool Question4Check = false;
            do
            {
                Console.WriteLine("\nWhat is your living situation? " +
                    "\nA = Apartment \nB = House");
                Console.Write("Your answer: ");
                var Question4Answer = Console.ReadLine().ToUpper();
                if (Question4Answer == "A")
                {

                    this.Energy = this.Energy + 1;
                    Question4Check = true;
                }
                else if (Question4Answer == "B")
                {

                    this.Energy = this.Energy + 2;
                    Question4Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question4Check = false;
                }
            }
            while (Question4Check == false);

            bool Question5Check = false;
            do
            {
                Console.WriteLine("\nDo you have a yard or accessible courtyard for the dog to go outside?");
                Console.WriteLine("A = Yes.");
                Console.WriteLine("B = Yes, but with a leash.");
                Console.WriteLine("C = No, I do not have a yard or courtyard.");
                Console.Write("Your answer: ");
                var Question5Answer = Console.ReadLine().ToUpper();
                if (Question5Answer == "A")
                {

                    this.Energy = this.Energy + 3;
                    Question5Check = true;
                }
                else if (Question5Answer == "B")
                {

                    this.Energy = this.Energy + 2;
                    Question5Check = true;
                }
                else if (Question5Answer == "C")
                {
                    this.Energy = this.Energy + 1;
                    Question5Check = true;

                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question5Check = false;
                }
            }
            while (Question5Check == false);

            bool Question6Check = false;
            do
            {
                Console.WriteLine("\nWould you rather have an active dog who wants to join you on a run, or a sedentary dog who would rather lay on the couch and watch movies?");
                Console.WriteLine("A = Active dog.");
                Console.WriteLine("B = Sedentary dog.");
                Console.WriteLine("C = I'm indifferent.");
                Console.Write("Your answer: ");
                var Question6Answer = Console.ReadLine().ToUpper();
                if (Question6Answer == "A")
                {

                    this.Energy = this.Energy + 3;
                    Question6Check = true;
                }
                else if (Question6Answer == "B")
                {

                    this.Energy = this.Energy + 1;
                    Question6Check = true;
                }
                else if (Question6Answer == "C")
                {
                    this.Energy = this.Energy + 2;
                    Question6Check = true;

                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question6Check = false;
                }
            }
            while (Question6Check == false);

            bool Question7Check = false;
            do
            {
                Console.WriteLine("\nHow appealing is it to you to adopt a dog who presents a bit of a challenge i.e. a dog with social anxiety or other particular needs?");
                Console.WriteLine("A = I would be able to work with a pet who needs extra time and attention.");
                Console.WriteLine("B = Not at all appealing.");
                Console.Write("Your Answer: ");
                var Question7Answer = Console.ReadLine().ToUpper();
                if (Question7Answer == "A")
                {

                    this.Trainability = this.Trainability + 1;
                    this.Affection = this.Affection + 1;
                    this.HumanSocialability = this.HumanSocialability + 1;
                    Question7Check = true;
                }
                else if (Question7Answer == "B")
                {

                    this.Trainability = this.Trainability + 2;
                    this.Affection = this.Affection + 2;
                    this.HumanSocialability = this.HumanSocialability + 2;
                    Question7Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question7Check = false;
                }
            }
            while (Question7Check == false);

            bool Question8Check = false;
            do
            {
                Console.WriteLine("\nWould a dog who is easier to train be appealing to you? Or are you comfortable with taking on the challenge of the dog who needs a little more time and practice?");
                Console.WriteLine("A = I would prefer an easy train.");
                Console.WriteLine("B = I'll take on a challenge.");
                Console.Write("Your Answer: ");
                var Question8Answer = Console.ReadLine().ToUpper();
                if (Question8Answer == "A")
                {

                    this.Trainability = this.Trainability + 2;
                    Question8Check = true;
                }
                else if (Question8Answer == "B")
                {

                    this.Trainability = this.Trainability + 1;
                    Question8Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question8Check = false;
                }
            }
            while (Question8Check == false);

            bool Question9Check = false;
            do
            {
                Console.WriteLine("\nHow important is it to you to have a dog who will socialize well with many different people?");
                Console.WriteLine("A = Extremely important.");
                Console.WriteLine("B = Not important.");
                Console.Write("Your Answer: ");
                var Question9Answer = Console.ReadLine().ToUpper();
                if (Question9Answer == "A")
                {

                    this.HumanSocialability = this.HumanSocialability + 3;
                    Question9Check = true;
                }
                else if (Question9Answer == "B")
                {

                    this.HumanSocialability = this.HumanSocialability + 1;
                    Question9Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question9Check = false;
                }
            }
            while (Question9Check == false);

            bool Question10Check = false;
            do
            {
                Console.Write("\nWill your new dog need to be comfortable interacting with other animals? Yes or No: ");

                var Question10Answer = Console.ReadLine().ToUpper();
                if (Question10Answer == "YES")
                {

                    this.AnimalSocialability = this.AnimalSocialability + 3;
                    Question10Check = true;
                }
                else if (Question10Answer == "NO")
                {

                    this.AnimalSocialability = this.AnimalSocialability + 1;
                    Question10Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question10Check = false;
                }
            }
            while (Question10Check == false);

            this.AnimalSocialability = this.AnimalSocialability / 2;
            this.Trainability = this.Trainability / 4;
            this.Affection = this.Affection / 3;
            this.HumanSocialability = this.HumanSocialability / 3;
            this.Energy = this.Energy / 3;


            Console.ReadLine();
        }

        public void MatchMaker(Person person, List<Dog> dogList)
        {
            foreach (var dog in dogList)
            {
                decimal c = 0; //compatibility score
                {

                    if (person.Affection == dog.Affection)
                    {
                        c = c + 1;
                    }
                    if (person.AnimalSocialability == dog.AnimalSocialability)
                    {
                        c = c + 1;
                    }
                    if (person.HumanSocialability == dog.HumanSocialability)
                    {
                        c = c + 1;
                    }
                    if (person.Energy == dog.Energy)
                    {
                        c = c + 1;
                    }
                    if (person.Trainability == dog.Trainability)
                    {
                        c = c + 1;
                    }
                }

                dog.Compatibility = (c / 5 * 100);
            };

            List<Dog> matchList = new List<Dog>();
            matchList = dogList.OrderByDescending(x => x.Compatibility).Take(5).ToList();

            Console.WriteLine("Congratulations! Your Top 5 Wag Mates are: \n");

            foreach (var dog in matchList)
            {
                Console.WriteLine("{0}  \n{1} \n{2} \n{3:%%} \n", dog.Name, dog.Breed, dog.Gender, dog.Compatibility + "% Compatibility");
            }

            Console.ReadLine();
        }
    }
} 
