//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("task 19") ;
Console.Write("enter the number: ") ;
Thread? number = Console.ReadLine() ;

void CheckingNumber (line number) {
    if (number[0]==number[4] || number[1]==number[3]){
Console.WriteLine($"your number: {number} - palindrome.");
}
    else Console.WriteLine($"your number: {number} - not a palindrome.");
}

    if (number!.length == 5){
    control number (number);
}
else Console.WriteLine($"enter the correct number");
