using System.Runtime.Serialization;

namespace POO_Practica
{
    [Serializable]
    internal class MonthExcepcion : Exception
    {
        public MonthExcepcion()
        {
        }

        public MonthExcepcion(string? message) : base(message)
        {
        }

        public MonthExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}