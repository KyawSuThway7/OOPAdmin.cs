using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentforOOP
{
    class Admin:IManage
    {

       public int Years { get; set; }
        public double minutes { get; set; }
        public void CreatePost()
        {
            Console.WriteLine("\t For Admin");
            Console.WriteLine("Creation : a Poem with beautiful photo");
            Console.WriteLine("Creation : a Oscar video ");
            Console.WriteLine("Creation : a Other video");
        }
        
          public double GetMoneyFromUser(double Cost,double adveradvertisment, double AppCreater)//one minutes get 10kyats,AppCreater give 5 kyats
        {
            double result = (minutes * Cost)+adveradvertisment - minutes * AppCreater;
            return result;
        }
        
         public void YouGetMoney(double minute, double money)
        {
            Console.WriteLine($"You get {money} Kyats in {minute} minutes");
        }
        
        public double ChangeCoverphoto(int years)
        {
            double result = (years*365)/7 * 3;
            return result;
        }
        
        public  void ChangeCoverPhotoInYear(int years, double totalphoto)
        {
            Console.WriteLine($"You can change {totalphoto} photos in  {years} years  ");
        }

    }
}
