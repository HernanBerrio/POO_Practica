namespace POO_Practica
{
    public class BaseCommissionEmploye : CommissionEmployee
    {
        // ---------------1. Crear propiedades (prop tab tab)----------------------------------------
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tBase.................: {$"{Base:C2}",15}";
        }
    }
}
