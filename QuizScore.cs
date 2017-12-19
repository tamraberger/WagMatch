using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagMatchDecember
{
    class QuizScore
    {
        private int pEnergy = 0;
        public int Energy
        {
            get { return pEnergy; }
            set { pEnergy = value; }
        }
        private int pAffection = 0;
        public int Affection
        {
            get { return pAffection; }
            set { pAffection = value; }
        }
        private int pTrainability = 0;
        public int Trainability
        {
            get { return pTrainability; }
            set { pTrainability = value; }
        }
        private int pHumanSocialability = 0;
        public int HumanSocialability
        {
            get { return pHumanSocialability; }
            set { pHumanSocialability = value; }
        }
        private int pAnimalSocialability = 0;
        public int AnimalSocialability
        {
            get { return pAnimalSocialability; }
            set { pAnimalSocialability = value; }
        }

    }
}
