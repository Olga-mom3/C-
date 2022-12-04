//  задача про 3 точки/ 
// есть 3 точки, возмем две из них найдем середину между и поставим точку.
// выберим случайно точку и и найдем середину между предыдущей нашей точкой ,
// поставим новую и так n раз 

 Console.Clear ();

 int xa = 40;
 int ya = 1;
 int xb = 1;
 int yb = 30;
 int xc = 80;
 int yc = 30;

 Console.SetCursorPosition (xa,ya);
 Console.Write ("+");
 Console.SetCursorPosition (xb,yb);
 Console.Write ("+");
 Console.SetCursorPosition (xc,yc);
 Console.Write ("+");

int x=xa, y=yb;
int count = 0 ;
while ( count < 100000 )
 {  

int what = new Random().Next(0,3);  
if (what == 0 )
   {
    x = (x+xa)/2;
    y = (y+ya)/2;
       }
if (what == 1 )
   {
    x = (x+xb)/2;
    y = (y+yb)/2;
       }
if (what == 2 )
   {
    x = (x+xc)/2;
    y = (y+yc)/2;
       }
Console.SetCursorPosition (x,y);
Console.Write ("+");
count = count + 1 ;


 } ;