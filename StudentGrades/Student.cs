using System.Globalization;

namespace StudentGrades
{
    public class Student
    {
        public string Name;
        public double Nota1, Nota2, Nota3;


        public double FinalGrade(){
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aproved(){
            if (FinalGrade() >= 60.0){
                return true;
            } else {
                return false;
            }           

        }

        public double MissingNote(){
            if (Aproved()){
                return 0.0;
            }
            else {
                return 60.0 - FinalGrade();
            }
        }
    }
}