

namespace ExerClassesIdade
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
               
    public static string CompareAges(Person p1, Person p2)
    {
        if (p1.Age > p2.Age){
            return $"A pessoa mais velha é {p1.Name}";
        }
        else if (p1.Age < p2.Age){
            return $"A pessoa mais velha é {p2.Name}";
        }
        else{
            return "As duas pessoas tem idades iguais";
        }
    }

    }

}