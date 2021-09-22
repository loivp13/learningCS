using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class InheritenceExcercise
    {
    }
    class Cars
    {
        //public property
        public int HP { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }


        //has a relationship
        protected CarIdInfo carIdInfo = new CarIdInfo();

        public void SetCarIDinfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIDinfo()
        {
            Console.WriteLine($"The car has the Id {carIdInfo.IDNum} and {carIdInfo.Owner} ");
        }

        public Cars(int hp, string color, string model)
        {
            HP = hp;
            Color = color;
            Model = "Default";
        }
        public virtual void ShowDetails()
        {

            Console.WriteLine($"{Model} has{HP} horsepower, {Color} color");
        }
        public virtual void Repair()
        {
            Console.WriteLine($"{Model} was repaired");
        }
        
    }
    class BMW : Cars
    {
        private string Brand = "BMW";

        public BMW(int hp, string color, string model) : base(
            hp, color,model)
        {
            Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"{Brand} model {Model} is {Color} and has {HP} horsepower");
        }
        public override void Repair()
        {
            Console.WriteLine($"{Brand} {Model} has been repaired");
        }
    }
    class Audi : Cars
    {
        private string Brand = "Audi";

        public Audi(int hp, string color, string model) : base(hp, color,model)
        {
        Model= model;

        }

        public override void ShowDetails()
        {
            Console.WriteLine($"{Brand} {Model} is {Color} and has {HP} horsepower");
        }
        public override void Repair()
        {
            Console.WriteLine($"{Brand} {Model} has been repaired");
        }
    }
    class CarIdInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "has no owner";


    }
}
