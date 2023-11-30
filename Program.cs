using System;

namespace Araba 
{
    public class araba {
        public double yakit;
        public int speed;

public araba( double y, int s)  /// ismi ustteki class ile ayni olmak zorunda
{
       set_Yakit(y);
       set_Speed(s);
}


public string goster(){
    return "  yakit miktari " +yakit.ToString() + " hizi  " + speed.ToString();
}

         public void set_Yakit(double y){  
            if( y>60)
            y=60;
           if(y<0)
              y=0;
            yakit=y;
         }
public double get_Yakit(){
    return yakit;  // yakitini o anda gorebiliyoruz
}
public int get_Speed(){
    return speed;  // hizini o anda gorebiliyoruz
}

          public void set_Speed(int s){   /
            if( s>260)
            s=260;
           if(s<0)
              s=40;
            speed= s;
         }

                public void yakit_Yukle(double y){   /// bu fonksiyon yakit yukleme isini yapiyor
          y= yakit+y;
          set_Yakit(y);
         }

         public void sur(){ /// hiza gore yakit azalmasi yapilacak
              if(speed <50)
              yakit -= 3;
              else if ( speed < 90)
              yakit -=1;
                 else if ( speed < 140)
              yakit -=2;
                 else if ( speed < 180)
              yakit -=3;
                 else 
              yakit -=4;

              set_Yakit(yakit);
         }
    }
    class Program{
   static void Main(string[] args)
   {
   araba nesne01 = new araba(35,20);
   Console.WriteLine(nesne01.goster());
   nesne01.sur();
 Console.WriteLine(nesne01.goster());
   nesne01.set_Speed(80);  // hizi arttirdik
    nesne01.sur();
    Console.WriteLine(nesne01.goster());
     nesne01.set_Speed(120);
      nesne01.sur();  // yeni hizdan sonra yakit azalmasi icin 
    Console.WriteLine(nesne01.goster());
       nesne01.set_Speed(240);
        nesne01.sur();
       Console.WriteLine(nesne01.goster());
       Console.WriteLine("---------------------------------------");

Console.WriteLine("Ikinci araba bilgielri");
        araba nesne02 = new araba(15,30);
   Console.WriteLine(nesne02.goster());
   nesne02.sur();
 Console.WriteLine(nesne02.goster());
   nesne02.set_Speed(100);  // hizi arttirdik
    nesne02.sur();
    Console.WriteLine(nesne02.goster());
     nesne02.set_Speed(150);
      nesne02.sur();  // yeni hizdan sonra yakit azalmasi icin 
    Console.WriteLine(nesne02.goster());
       nesne02.set_Speed(280);
        nesne02.sur();
       Console.WriteLine(nesne02.goster());
   }
    }
}