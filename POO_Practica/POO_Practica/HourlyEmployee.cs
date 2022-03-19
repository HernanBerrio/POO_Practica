namespace POO_Practica
{
    public class HourlyEmployee : Employee
    {
        // ---------------1. Crear propiedades (prop tab tab)----------------------------------------
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (Decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours...............: {$"{Hours:N2}",15}" +
                $"\n\tHours Value.........: {$"{HourValue:C2}",15}" +
                $"\n\tValue to pay........: {$"{Hours:N2}",15}";



        }
    }
}
