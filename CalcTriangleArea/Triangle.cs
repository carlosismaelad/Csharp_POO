namespace IntroAClasses
{
    public class Triangle
    {
        public double A { get ; set;}
        public double B { get ; set;}
        public double C { get ; set;}

        public double CalcArea(){
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

         
    }


}