// Task from 1 lection. Dog & Friends
int count = 0;
double distance = 10000;
int firstFriendSpeed = 2, secondFriendSpeed = 2, dogSpeed =5;
int friend =2;
double time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
        //Console.Write("1 frind time: "); //****************
        //Console.WriteLine(time); //*********************
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
       // Console.Write("2 frind time: "); //****************
       // Console.WriteLine(time); //***********************
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    //Console.Write("remaining distance: "); //****************
    //Console.WriteLine(distance); //*************************
    count++;
    //Console.Write("counter:  "); //****************
   // Console.WriteLine(count);//**************************
}
Console.WriteLine(count);