// See added program that accepts a digit indicating the day of the week as input and checks whether this day is a weekend.;

Console.WriteLine("enter the number of the day of the week: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string  isWeekend= (dayOfWeek  >0 && dayOfWeek  <8) 
    ? (dayOfWeek == 6 || dayOfWeek == 7) ? "yes" : "no"
    : "not day of the week";

Console.WriteLine($"{dayOfWeek} -> {isWeekend}");


/*
if(dayOfWeek > 0 && dayOfWeek < 8) 
{
  if(dayOfWeek == 6 || dayOfWeek == 7) 
  {
    Console.WriteLine($"{dayOfWeek} -> yes");
  } 
  else 
  {
    Console.WriteLine($"{dayOfWeek} -> no");
  }
  else
  {
    Console.WriteLine($"{dayOfWeek} -> not day of the week");  
  }
}
*/
