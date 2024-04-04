using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class stonesmanager
{
    Stones[] stoneses = new Stones[3];
    public stonesmanager() 
    {
        Stones stones1 = new Stones();
        stones1.Name = "Kil";
        stones1.Id = 1;
        stones1.Shape = "Üçgen";
        stones1.Color = "Kahverengi";
        stones1.Price = 10;

        Stones stones2 = new Stones();
        stones2.Name = "Altın";
        stones2.Id = 2;
        stones2.Shape = "Kare";
        stones2.Color = "Sarı";
        stones2.Price = 150;

        Stones stones3 = new Stones();
        stones3.Name = "Mermer";
        stones3.Id = 3;
        stones3.Shape = "Dikdörtgen";
        stones3.Color = "Bej";
        stones3.Price = 75;

        stoneses[0] = stones1;
        stoneses[1] = stones2;
        stoneses[2] = stones3;
    }
    public Stones[] GetAll()
    {
        return stoneses;
    }

}
