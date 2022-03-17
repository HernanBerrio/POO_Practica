namespace POO_Practica
{
    //Heredar de la clase Abstracta Employee----------------------------------------------------------
    public class SalaryEmployee : Employee
    {
        //Crear propiedad Atributo--------------------------------------------------------------------
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;

        }
        //Imrprimir desde la clase padre que hereda-------------------------------------------------
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}", 15}";
        }
    }
}





