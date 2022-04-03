using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class Respuestas
    {
        public static string Preguntar()
        {
            var random = new Random();
            List<string> Respuestas = new List<string>();
            Respuestas.Add("Es cierto");
            Respuestas.Add("Es decididamente así");
            Respuestas.Add("Como yo lo veo, sí");
            Respuestas.Add("Lo más probable");
            Respuestas.Add("Respuesta confusa, vuelve a intentarlo");
            Respuestas.Add("Vuelve a preguntar más tarde");
            Respuestas.Add("No cuentes con ello.");
            Respuestas.Add("Mi respuesta es no");

            int index = random.Next(Respuestas.Count);
            return Respuestas[index];
        }
    }
}
