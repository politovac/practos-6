//. Дано натуральное число. Определить: а) количество цифр 3 в нем; б) сколько
//раз в нем встречается последняя цифра; в) количество четных цифр в нем. 
int Kol = 0,
value,dublicateValue;
value = dublicateValue = Convert.ToInt32(Console.ReadLine());
while ( dublicateValue != 0 )
{
    if (dublicateValue % 10 == 3)
    {
        Kol++;
        dublicateValue /= 10;
    }

if ((dublicateValue % 10) % 2 == 0)
 { 
           Kol++;
            dublicateValue = dublicateValue % 10;     
 }
}
Console.WriteLine($"Кол-во цифр 3 в числе будет {value} будет {Kol}");