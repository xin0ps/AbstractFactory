using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface Chair
    {
        public void hasLegs();
        public void sitOn();
    }


    public interface CoffeeTable
    {
        public void hasLegs();
      
    }

    public interface Sofa
    {
        public void hasLegs();
        public void sitOn();

    }



    public class ModernCoffeeTable : CoffeeTable
    {
        public void hasLegs()
        {
            throw new NotImplementedException();
        }
    }

    public class VictorianCoffeeTable : CoffeeTable
    {
        public void hasLegs()
        {
            throw new NotImplementedException();
        }
    }


    public class ModernSofa : Sofa
    {
        public void hasLegs()
        {
            throw new NotImplementedException();
        }

        public void sitOn()
        {
            throw new NotImplementedException();
        }
    }
    public class VictorianSofa : Sofa
    {
        public void hasLegs()
        {
            throw new NotImplementedException();
        }

        public void sitOn()
        {
            throw new NotImplementedException();
        }
    }


    public class VictorianChair : Chair
    {
        public void hasLegs()
        {
            throw new NotImplementedException();
        }

        public void sitOn()
        {
            throw new NotImplementedException();
        }
    }

    public class ModernChair : Chair
    {
        public void hasLegs()
        {
            throw new NotImplementedException();
        }

        public void sitOn()
        {
            throw new NotImplementedException();
        }
    }



    public interface FurnitureFactory
    {
        public Chair createChair();

        public CoffeeTable createOffeeTable();

        public Sofa createSofa();
    }


    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            throw new NotImplementedException();
        }

        public CoffeeTable createOffeeTable()
        {
            throw new NotImplementedException();
        }

        public Sofa createSofa()
        {
            throw new NotImplementedException();
        }
    }

    public class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            throw new NotImplementedException();
        }

        public CoffeeTable createOffeeTable()
        {
            throw new NotImplementedException();
        }

        public Sofa createSofa()
        {
            throw new NotImplementedException();
        }
    }

}
