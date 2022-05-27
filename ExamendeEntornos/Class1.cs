using System;

class Asignatura
{
    public string codigodelaAsignatura, nombredelaAsignatura; 
    public double notadelPrimertrimestre, notadelSegungoTrimestre, notadelSegungoTrimestre, notadelTercerTrimestre, notaFinaldelCurso;
    //Ya que todas estas variables son del mismo tipo y son asignadas más tarde en el constructor, las ponemos todas en la misma linea para que sea más
    //lejble y menos líneas de código.

    ///<summary>En este constructor se asignan los atributos los valores que le pasemos al crear el objeto.</summary>
    public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
    {
        codigodelaAsignatura = CodigodelaAsignatura; 
        nombredelaAsignatura = NombredelaAsignatura;                    
        notadelPrimertrimestre = NotadelPrimertrimestre;
        notadelSegungoTrimestre = NotadelSegungoTrimestre; //He cambiado el nombre de las variables para poder quitar el this, asi se ve mucho mas claro.
        notadelTercerTrimestre = NotadelTercerTrimestre;    //Además, es conveniente que el nombre de las variables siempre empiece en minuscula.
        notaFinaldelCurso = NotaFinaldelCurso;
    }
    //He puesto el constructor debajo de los atributos, es mucho mas lejible y manejable. Siempre primero properties, despues atributos,
    //despues constructor y métodos.

    ///<remarks>Se recomienda solo usar esta funcion cuando haya que introducir una nueva asignatura</remark>
    public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
    {
        CodigodelaAsignatura = Cod_de_Asignatura; NombredelaAsignatura = Nombre_de_Asignatura;
        //he quitado los .this de esta función, ya que se llaman distinto son muy innecesarios.
    }

    public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3, double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
    {
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
            var Trimestre = Console.ReadLine();
            switch (Trimestre)
            {
                case "1":
                    Console.WriteLine("Nota de las prácticas: ");
                    notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nota del examen: ");
                    notadelExamen1 = Convert.ToDouble(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("Nota de las prácticas: ");
                    notadelasPracticas2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nota del examen: ");
                    notadelExamen2 = Convert.ToDouble(Console.ReadLine());
                    break;

                case "3":
                    Console.WriteLine("Nota de las prácticas: ");
                    notadelasPracticas3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nota del examen: ");
                    notadelExamen3 = Convert.ToDouble(Console.ReadLine());
                    break;
            } //He quitado lineas en blanco y retabulado la función para que sea mucho mas lejible y entendible.
        }
    }

    ///<summary>Estas funciones calculan las notas finales de los respectivos trimestres y la media de la nota final</summary>
    ///<remark>Poner solo numeros mayores que 0, ya que si no, nos calculará la nota erróneamente.</remark>
    ///<param name="notadelExamen1">Nota del alumno sacada en el primer trimestre.</param>
    ///<param name="notadelasPracticas1">Nota del alumno sacada en el primer trimestre.</param>
    ///<returns>La nota final de los trimestres y la media de la nota final del curso.</returns>
    public double calculodelaNota1(double notaDelExamen1, double notaDeLasPracticas1)
    {
        return NotadelPrimertrimestre; = (notaDelExamen1 * 0.8) + (notaDeLasPracticas1) * 0.2;
        //Al ser una funcion tán simple, no hace falta almacenar en una variable, asi que devolvemos directamente el resultado.
        //También he cambiado las mayusculas de algunas variables para que resulten más claras.
    }
    public double calculodelaNota2(double notaDelExamen2, double notaDeLasPracticas2)
    {
        return NotadelSegungoTrimestre; = (notadelExamen2 * 0.8) + (notaDeLasPracticas2) * 0.2;
    }
    public double calculodelaNota3(double notaDelExamen3, double notaDeLasPracticas3)
    {
        return NotadelTercerTrimestre; = (notadDelExamen3 * 0.8) + (notaDeLasPracticas3) * 0.2;
    }
    public double Calculodelamedia()
    {
        return NotaFinaldelCurso = (NotadelPrimertrimestre + NotadelSegungoTrimestre + NotadelTercerTrimestre) / 3;
    }//He quitado todos los .this aqui tambien porque son innecesarios.

}