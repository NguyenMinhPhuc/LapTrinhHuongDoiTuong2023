using DP1_3_BuilderPattern.VD1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_3_BuilderPattern.VD2
{
    internal class Car : IBuilder
    {
        // ConcreteBuilder: Car

        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        { //Starting with brand-name
            product.Add(string.Format("Car Model name :{0}", this.
           brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }
        public void EndOperations()
        { //Nothing in this case
        }
        public Product GetVehicle()
        {
            return product;
        }

    }
}
