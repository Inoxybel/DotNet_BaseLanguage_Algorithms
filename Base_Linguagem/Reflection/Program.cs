using Base_Linguagem.Reflection.DTOs;
using Base_Linguagem.Reflection.Enumerator;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.InteropServices;


TesteDTO testeDTO = new TesteDTO();
testeDTO.FirstName = "Thiago";
testeDTO.LastName = "Matos";
testeDTO.Email = "ab@cd.com";
testeDTO.CellPhone = null; //nulo explícito
testeDTO.Status = EParticipantStatus.verified;
testeDTO.BirthDate = DateTime.Now.Date;
testeDTO.Id = "123";

AnotherTesteDTO anotherTesteDTO = new AnotherTesteDTO();
anotherTesteDTO.FirstName = "Thiago";
anotherTesteDTO.LastName = "Mattos";
anotherTesteDTO.Email = "abc@cd.com";
anotherTesteDTO.CellPhone = "11945343471"; //nulo explícito
anotherTesteDTO.Status = EParticipantStatus.verified;
anotherTesteDTO.BirthDate = DateTime.Now.Date;
anotherTesteDTO.Id = "123";

PropertyInfo[] propInfos = testeDTO.GetType().GetProperties();
Type t1 = typeof(TesteDTO);
Type t2 = typeof(AnotherTesteDTO);

Console.WriteLine(String.Format("{0,12}| {1,22} | {2,22} | {3,5}", "Property Name", "DTO1", "DTO2", "Is Equal?"));
Console.WriteLine("-----------------------------------------------------------------------");

foreach (var propInfo in propInfos)
{
    var value1 = t1.GetProperty(propInfo.Name).GetValue(testeDTO, null);
    var value2 = t2.GetProperty(propInfo.Name).GetValue(anotherTesteDTO, null);

    if (value1 is not null && value2 is not null)
        Console.WriteLine(String.Format("{0,12} | {1,22} | {2,22} | {3,5}", propInfo.Name, value1, value2, value1.ToString() == value2.ToString()));
}
t2.GetProperty("LastName").SetValue(anotherTesteDTO, "Matos");
Console.WriteLine(t2.GetProperty("LastName").GetValue(anotherTesteDTO));