//
Dictionary<string, string> perfil = new Dictionary<string, string>();
perfil.Add("Nombre", "Alex");
perfil.Add("Apellido", "Miller");
perfil.Add("Edad", "25");
perfil.Add("Curso", "C#/.NET");
//Seleccionar solo un elemento en base al atributo
Console.WriteLine(perfil["Edad"]);
//mostrar elementos del diccionarion
foreach (var perfiles in perfil)
{
    Console.WriteLine(perfiles.Key + " - " + perfiles.Value);
}
//
foreach (KeyValuePair<string, string> renglon in perfil)
{
    Console.WriteLine(renglon.Key + " - " + renglon.Value);
}