using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagMatchDecember
{
    class Dog: QuizScore
    {
        public string Name { get; set; }
        public string ShelterAssignedID { get; set; } //how shelter identifies animals
        public string Breed { get; set; }
        public int ShelterID { get; set; } //shelter animal is housed at
        public decimal Age { get; set; }
        public int AgeCategory { get; set; }
        public string Gender { get; set; }
        public int Weight { get; set; }
        public string ImageLink { get; set; }
        public string VideoLink { get; set; }
        public string ZipCode { get; set; }
        public decimal Compatibility { get; set; }



        public void getDogQuizResults()
        #region quiz
        {
            Console.WriteLine("Now we will assess your dog's personality with a few questions.");
            bool Question1Check = false;
            Console.WriteLine("\nPlease rate the dog on a scale of 1 to 3.");
            do
            {
                Console.WriteLine("Level of Affection");
                Console.WriteLine("1 = Reserved \n2 = Moderately Affectionate \n3 = Great Kisser");
                var Question1Answer = Console.ReadLine();
                if (Question1Answer == "1")
                {

                    this.Affection = this.Affection + 1;
                    Question1Check = true;
                }
                else if (Question1Answer == "2")
                {
                    this.Affection = this.Affection + 2;
                    Question1Check = true;
                }
                else if (Question1Answer == "3")
                {
                    this.Affection = this.Affection + 3;
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
                Console.Write("");
                Console.WriteLine("\nEnergy Level");
                Console.WriteLine("1 = Couch Potato \n2 = Moderately Active \n3 = Marathon Buddy");
                var Question2Answer = Console.ReadLine();
                if (Question2Answer == "1")
                {

                    this.Energy = this.Energy + 1;
                    Question2Check = true;
                }
                else if (Question2Answer == "2")
                {
                    this.Energy = this.Energy + 2;
                    Question2Check = true;
                }
                else if (Question2Answer == "3")
                {
                    this.Energy = this.Energy + 3;
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
                Console.Write("");
                Console.WriteLine("\nTrainability");
                Console.WriteLine("1 = Needs More Practice \n2 = Average Trainability \n3 = One and Done");
                var Question3Answer = Console.ReadLine();
                if (Question3Answer == "1")
                {

                    this.Trainability = this.Trainability + 1;
                    Question3Check = true;
                }
                else if (Question3Answer == "2")
                {
                    this.Trainability = this.Trainability + 2;
                    Question3Check = true;
                }
                else if (Question3Answer == "3")
                {
                    this.Trainability = this.Trainability + 3;
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
                Console.Write("");
                Console.WriteLine("\nSocial Skills with People");
                Console.WriteLine("1 = The fewer people the better \n2 = Average social skills with people \n3 = Loves people");
                var Question4Answer = Console.ReadLine();
                if (Question4Answer == "1")
                {

                    this.HumanSocialability = this.HumanSocialability + 1;
                    Question4Check = true;
                }
                else if (Question4Answer == "2")
                {
                    this.HumanSocialability = this.HumanSocialability + 2;
                    Question4Check = true;
                }
                else if (Question4Answer == "3")
                {
                    this.HumanSocialability = this.HumanSocialability + 3;
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
                Console.Write("");
                Console.WriteLine("\nSocial skills with other animals");
                Console.WriteLine("1 = Lone wolf \n2 = Tolerates other animals \n3 = Your pet's new BFF");
                var Question5Answer = Console.ReadLine();
                if (Question5Answer == "1")
                {

                    this.AnimalSocialability = this.AnimalSocialability + 1;
                    Question5Check = true;
                }
                else if (Question5Answer == "2")
                {
                    this.AnimalSocialability = this.AnimalSocialability + 2;
                    Question5Check = true;
                }
                else if (Question5Answer == "3")
                {
                    this.AnimalSocialability = this.AnimalSocialability + 3;
                    Question5Check = true;
                }
                else
                {
                    Console.WriteLine("I don't understand your response.");
                    Question5Check = false;
                }
            }
            while (Question5Check == false);



        }
        #endregion quiz
    }
}
