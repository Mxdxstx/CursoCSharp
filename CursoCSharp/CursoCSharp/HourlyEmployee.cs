namespace CursoCSharp
{
    public class HourlyEmployee : Employee
    {

        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"\n\tHours................: {$"{Hours:N2}",18}" +
                $"\n\tHour Value................: {$"{HourValue:C3}",18}" +
                $"\n\tValue to pay.........:{$"{GetValueToPay():C2}",18}";
        }
    }
}
