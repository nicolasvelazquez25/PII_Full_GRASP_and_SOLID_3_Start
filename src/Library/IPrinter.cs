namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter

    /* 
        FilePrinter y ConsolePrinter implementan el patron SRP porque la unica responsabilidad
        que tienen es imprimir las órdenes que son enviadas desde las clases colaboradoras.
        Asimismo, la interfaz IPrinter cumple con el patrón OCP, ya que si en un futuro se desea
        modificar la forma en que se imprime, no se requiere modificar el resto del código, 
        no va a depender como antes dependía de la clase AllInOnePrinter. 
        */
        
    {
        void PrintRecipe(Recipe recipe);  
    }
}

