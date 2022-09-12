/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine( "Введите число: " );
int num = Convert.ToInt32( Console.ReadLine() );

int GetSum( int n ){

    int sum = 0;
    int i = n;

    while( i !=0 ){

        sum += i % 10;
        i = i / 10;
    }
    /* for( int i = n; i != 0; i = i / 10 ){
        
        sum += i % 10;
           
    } */
    return sum;
}

Console.WriteLine( $"Сумма цифр числа равна: { GetSum( num ) }" );

