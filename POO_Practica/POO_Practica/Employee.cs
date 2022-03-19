namespace POO_Practica
{
    //Definir Clase Abstracta------------------------------------------------------------------------
    public abstract  class Employee :Ipay 
    {
        // ---------------1. Crear propiedades (prop tab tab)----------------------------------------
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        //Crear Metodo Abstracto Get ValueToPay-----------Decimal representa dinero-------------------
        public abstract decimal GetValueToPay();

        //Sobreescribir el metodo ToString()----------------------------------------------------------
        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth : {BirthDate}, " +
                $"Hiring : {HiringDate}, " +
                $"Is Active : {IsActive}";
        }


    }
}
