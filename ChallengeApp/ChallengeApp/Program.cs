using ChallengeApp;

Employee user1 = new Employee("Monika", "Ryś", 30);
Employee user2 = new Employee("Adam", "Stokowski", 32);
Employee user3 = new Employee("Tom", "Cruse", 34);
Employee user4 = new Employee("Bob", "Marley", 37);

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(4);
user1.AddScore(5);
user1.AddScore(1);

user2.AddScore(4);
user2.AddScore(8);
user2.AddScore(7);
user2.AddScore(3);
user2.AddScore(9);

user3.AddScore(6);
user3.AddScore(3);
user3.AddScore(1);
user3.AddScore(4);
user3.AddScore(5);

user4.AddScore(8);
user4.AddScore(9);
user4.AddScore(7);
user4.AddScore(1);
user4.AddScore(2);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3, user4
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach(var user in users)
{
    if(user.Resault > maxResult)
    {
        userWithMaxResult = user;
        maxResult = user.Resault;
    }
    
}
Console.WriteLine(userWithMaxResult.Name +" "+ userWithMaxResult.Surname +" "+ userWithMaxResult.Age +" lat, " + " Jego ocena była najwyższa " + userWithMaxResult.Resault );