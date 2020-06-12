using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLabs
{
    [Serializable]
    public class CatalogItem
    {
        public enum TCategories { Bicycle, Trailer, LightCar, Track, Motorcycle}
        public string Name;
        public TCategories Category;
        public int WheelsNum;
        public double Price;

        public CatalogItem(string name, int wheelsNum, double price)
        {
            this.Name = name;
            this.WheelsNum = wheelsNum;
            this.Price = price;
        }
    }

    [Serializable]
    public class Bicycle : CatalogItem
    {
        public int GearsNum;
        public int WheelsDiameter;
        public enum BrakeType { Shoe, Disc, Hydro };
        public BrakeType brakeType;

        public Bicycle(int gearsNum, int wheelsDiameter, BrakeType brakeType, 
            string name, int wheelsNum, double price) : base(name, wheelsNum, price)
        {
            this.GearsNum = gearsNum;
            this.WheelsDiameter = wheelsDiameter;
            this.brakeType = brakeType;
            this.Category = TCategories.Bicycle;
        }
    }

    [Serializable]
    public class Trailer : CatalogItem
    {
        public int MaxWeightCapacity;
        public bool IsResidential;
        public int PersonsNum;

        public Trailer(int maxWeightCapacity, bool isResidential, int personsNum, 
            string name, int wheelsNum, double price) : base(name, wheelsNum, price)
        {
            this.MaxWeightCapacity = maxWeightCapacity;
            this.IsResidential = isResidential;
            this.PersonsNum = personsNum;
            this.Category = TCategories.Trailer;
        }
    }

    [Serializable]
    public class Car : CatalogItem
    {
        public int EnginePower;
        public int MaxSpeed;
        public int ReleaseYear;


        public Car(int enginePower, int maxSpeed, int releaseYear, 
            string name, int wheelsNum, double price) : base(name, wheelsNum, price)
        {
            this.EnginePower = enginePower;
            this.MaxSpeed = maxSpeed;
            this.ReleaseYear = releaseYear;
        }
    }

    [Serializable]
    public class LightCar : Car
    {
        public enum TMark { Audi, BMW, Renault };
        public TMark mark;

        public int PassengersNum;       

        public LightCar(TMark mark,  int passengersNum, 
            int enginePower, int maxSpeed, int releaseYear, string name, int wheelsNum, double price) : base(enginePower, maxSpeed, releaseYear, name, wheelsNum, price)
        {
            this.mark = mark;
            this.PassengersNum = passengersNum;
            this.Category = TCategories.LightCar;
        }
    }

    [Serializable]
    public  class Track : Car
    {
        public enum TMark { Kamaz, MAN, LDV};
        public TMark mark;
        public bool HasTrailer;
        public Trailer trailer;
        public int MaxWeightCarrying;

        public Track(TMark mark, bool hasTrailer, Trailer trailer, int maxWeightCarrying,
            int enginePower, int maxSpeed, int releaseYear, string name, int wheelsNum, double price) : base(enginePower, maxSpeed, releaseYear, name, wheelsNum, price)
        {
            this.mark = mark;
            this.HasTrailer = hasTrailer;
            this.trailer = trailer;
            this.MaxWeightCarrying = maxWeightCarrying;
            this.Category = TCategories.Track;
        }
    }

    [Serializable]
    public class Motorcycle : Car
    {
        public enum TMark { Suzuki, Kawasaki, Yamaha};
        public TMark mark;
        public enum TShellType { Classic, Sport, Dragster};
        public TShellType shellType;
        public bool CanHavePram;

        public Motorcycle(TMark mark, TShellType shellType, bool canHavePram,
            int enginePower, int maxSpeed, int releaseYear, string name, int wheelsNum, double price) : base(enginePower, maxSpeed, releaseYear, name, wheelsNum, price)
        {
            this.mark = mark;
            this.shellType = shellType;
            this.CanHavePram = canHavePram;
            this.Category = TCategories.Motorcycle;
        }
    }
}
