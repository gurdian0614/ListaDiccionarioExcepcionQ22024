using System.ComponentModel;

try
{
    List<string> lista = new List<string>() {
        "Persona 4",
        "Persona 2", 
        "Persona 3"
    };

    lista.Add("Persona 1");
    lista.Add("Persona 1");
    lista.Add("Persona 1");
    lista.Sort();
    lista.RemoveAll(persona => persona != "Persona 1");

    foreach (var str in lista)
    {
        Console.WriteLine(str);
    }

    Dictionary<string, string> dic = new Dictionary<string, string>()
    {
        { "Pais", "Honduras" },
        { "Capital", "Tegucigalpa" }
    };
    dic.Add("Extension", "112,492 kms2");
    dic.Remove("Capital");
    dic["Departamento"] = "Cortes";

    foreach (var data in dic)
    {
        Console.WriteLine($"key: {data.Key}, value: {data.Value}");
    }
} catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
