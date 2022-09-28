using System;
using System. Collections


namespace TestProject3_Cake


{
    public class Cake
    {
       
        public class Cake
        {
            string filling;
            string topping;
            bool bakedAndDone;
            TimeSpan bakeTime;
            double temReq;

            public bool BakedAndDone { get { return bakedAndDone; } }

            public Cake(string filling,string topping, TimeSpan bakeTime)
            {
                this.tempReq = tempReq;
                this.bakeTime = bakeTime; 
                this.filling = filling;
                this.topping = topping;
                
            }
            public bool BaketheCake(double temperature,TimeSpan bakeTime)

            {
                if (temperature>= tempReq && this.bakeTime >= bakeTime) 
                {
                    bakedAndDone = true;
                    return true;
                }
                else
                {
                    return false;
                }
                 
                        
            }
        }
    }
}