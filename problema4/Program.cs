using Provincias;
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

List<Provincia> provincias = new List<Provincia>();
var url = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre ";
var request = (HttpWebRequest) WebRequest.Create(url);
request.Method = "GET";
request.ContentType = "application/json";
request.Accept = "application/json";

try{
    using(WebResponse respuesta = request.GetResponse()){
        using(Stream StreamReader = respuesta.GetResponseStream()){
            if (StreamReader != null)
            {
                using (StreamReader objReader = new StreamReader(StreamReader))
                {
                    string responseBody = objReader.ReadToEnd();
                    provincias = JsonSerializer.Deserialize<List<Provincia>>(responseBody);
                    foreach (Provincia provincia in provincias)
                    {
                        Console.WriteLine(provincia.Nombre);
                        Console.WriteLine(provincia.Id);
                    }
                }
            }else
            {
                Console.WriteLine("No Responde");
            }
        }
    }
            
}catch(WebException e){
        Console.WriteLine(e.Message);
}
    