using PlayerUI.ServicioAntecedentesPenalesSWJavita;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PlayerUI.Controller
{
    class ControllerAntecedentesPenales
    {
        private String urlGeneral = "http://192.168.16.13:7101/ServidorAntecedentesJDBCSW-ServidorAntecedentesSW-context-root/resources/model/";
        private static ControllerAntecedentesPenales controller;

        private ControllerAntecedentesPenales()
        {

        }

        public static ControllerAntecedentesPenales getInstance()
        {
            if (controller == null)
                controller = new ControllerAntecedentesPenales();
            return controller;
        }
        //----------------------------Ciudadano----------------------------
        public bool eliminarCiudadano(String cedula)
        {
            String urlRelativa = "eliminarCiudadano";
            var url = $"" + urlGeneral + urlRelativa + "?cedula=" + cedula;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                        }
                    }
                }
                return true;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error! " + ex);
                return false;
            }
        }

        public bool agregarCiudadano(String cedula, int tipoDocumento, String nombre, String apellido, DateTime fechaNacimiento, bool genero)
        {

            /*  EXAMPLE
{
        "tipoDocumento" : 1,
        "nombre" : "Juancho",
        "apellido" : "PERRALES",
        "fechaNacimiento" : "2020-08-02",
        "genero" : true,
        "cedula" : "147258"
}
             */
            bool respuesta = false;
            String urlRelativa = "agregarCiudadano";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"tipoDocumento\":{tipoDocumento},\"nombre\":\"{nombre}\",\"apellido\":\"{apellido}\",\"fechaNacimiento\":\"{fechaNacimiento.ToString("yyyy-MM-dd")}\",\"genero\":{genero.ToString().ToLower()},\"cedula\":\"{cedula}\"}}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            respuesta = JsonConvert.DeserializeObject<bool>(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error! " + ex);
            }

            return respuesta;
        }

        public ciudadano darCiudadanoPorCedula(String cedula)
        {
            ciudadano ciudadano = null;
            String urlRelativa = "darCiudadano";
            var url = $"" + urlGeneral + urlRelativa + "?cedula=" + cedula;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return ciudadano;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ciudadano = JsonConvert.DeserializeObject<ciudadano>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return ciudadano;
        }

        public List<ciudadano> darCiudadanos()
        {
            ciudadano[] ciudadanosList = null;
            String urlRelativa = "darCiudadanos";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ciudadanosList = JsonConvert.DeserializeObject<ciudadano[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<ciudadano> ciudadanos = new List<ciudadano>();
            for (int i = 0; i < ciudadanosList.Length; i++)
            {
                ciudadanos.Add(ciudadanosList[i]);
            }
            return ciudadanos;
        }

        public bool actualizarCiudadano(String cedula, int tipoDocumento, String nombre, String apellido, DateTime fechaNacimiento, bool genero)
        {
            bool respuesta = false;
            String urlRelativa = "actualizarCiudadano";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"tipoDocumento\":{tipoDocumento},\"nombre\":\"{nombre}\",\"apellido\":\"{apellido}\",\"fechaNacimiento\":\"{fechaNacimiento.ToString("yyyy-MM-dd")}\",\"genero\":{genero.ToString().ToLower()},\"cedula\":\"{cedula}\"}}";
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            respuesta = JsonConvert.DeserializeObject<bool>(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error! " + ex);
            }

            return respuesta;
        }

        //----------------------------Delito----------------------------
        public delito darDelitoPorCodigo(int codigo)
        {
            delito antecedente = null;
            String urlRelativa = "darDelito";
            var url = $"" + urlGeneral + urlRelativa + "?codigo=" + codigo;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return antecedente;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedente = JsonConvert.DeserializeObject<delito>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return antecedente;
        }

        public List<delito> darDelitos()
        {
            delito[] delitosList = null;
            String urlRelativa = "darDelitos";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            delitosList = JsonConvert.DeserializeObject<delito[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<delito> delitos = new List<delito>();
            for (int i = 0; i < delitosList.Length; i++)
            {
                delitos.Add(delitosList[i]);
            }
            return delitos;
        }
        //----------------------------Antecedente----------------------------
        public List<antecedente> darAntecedentes()
        {
            antecedente[] antecedentesList = null;
            String urlRelativa = "darCiudadanos";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedentesList = JsonConvert.DeserializeObject<antecedente[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<antecedente> antecedentes = new List<antecedente>();
            for (int i = 0; i < antecedentesList.Length; i++)
            {
                antecedentes.Add(antecedentesList[i]);
            }
            return antecedentes;
        }

        public bool agregarAntecedente(String ciudadanoDi, int delitoCodigo, String ciudad, DateTime fechaDelito, int sentencia, String estado)
        {

            /* EXAMPLE
{
        "id" : 20,
        "ciudadanoDi" : "1237894560",
        "delitoCodigo" : 5,
        "ciudad" : "cali",
        "fechaDelito" : "2020-08-04",
        "sentencia" : 12,
        "estado" : "Activo    "
}
             */
            bool respuesta = false;
            String urlRelativa = "AgregarAntecedente";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"id\":{0},\"ciudadanoDi\":\"{ciudadanoDi}\",\"delitoCodigo\":{delitoCodigo},\"ciudad\":\"{ciudad}\",\"fechaDelito\":\"{fechaDelito.ToString("yyyy-MM-dd")}\",\"sentencia\":{sentencia},\"estado\":\"{estado}\"}}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            respuesta = JsonConvert.DeserializeObject<bool>(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error! " + ex);
            }

            return respuesta;
        }

        public antecedente darAntecedentePorId(int id)
        {
            antecedente antecedente = null;
            String urlRelativa = "darAntecedente";
            var url = $"" + urlGeneral + urlRelativa + "?id=" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return antecedente;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedente = JsonConvert.DeserializeObject<antecedente>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return antecedente;
        }

        public bool actualizarAntecedente(int id, String ciudadanoDi, int delitoCodigo, String ciudad, DateTime fechaDelito, int sentencia, String estado)
        {
            bool respuesta = false;
            String urlRelativa = "actualizarAntecedente";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"id\":{id},\"ciudadanoDi\":\"{ciudadanoDi}\",\"delitoCodigo\":{delitoCodigo},\"ciudad\":\"{ciudad}\",\"fechaDelito\":\"{fechaDelito.ToString("yyyy-MM-dd")}\",\"sentencia\":{sentencia},\"estado\":\"{estado}\"}}";
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            respuesta = JsonConvert.DeserializeObject<bool>(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error! " + ex);
            }

            return respuesta;
        }

        public bool eliminarAntecedente(int id)
        {
            String urlRelativa = "eliminarAntecedente";
            var url = $"" + urlGeneral + urlRelativa + "?id=" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                        }
                    }
                }
                return true;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error! " + ex);
                return false;
            }
        }

        public int darSentenciaTotalPorCiudadano(String ciudadanoDi)
        {
            int resultado = 0;
            String urlRelativa = "darSentenciaTotal";
            var url = $"" + urlGeneral + urlRelativa + "?" + "ciudadanoDi=" + ciudadanoDi;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return 0;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            resultado = JsonConvert.DeserializeObject<int>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return resultado;
        }

        ////--------------------------Filtros------------------------------////

        public List<antecedente> darAntecedentesPorCiudadano(String ciudadanoDi)
        {
            //darAntecedentesCiudadano?ciudadanoDi=1111
            antecedente[] antecedentesList = null;
            String urlRelativa = "darAntecedentesCiudadano";
            var url = $"" + urlGeneral + urlRelativa + "?" + "ciudadanoDi=" + ciudadanoDi;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedentesList = JsonConvert.DeserializeObject<antecedente[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<antecedente> antecedentes = new List<antecedente>();
            for (int i = 0; i < antecedentesList.Length; i++)
            {
                antecedentes.Add(antecedentesList[i]);
            }
            return antecedentes;
        }

        public List<antecedente> darAntecedentesPorDelito(int delitoCodigo)
        {
            //darAntecedentesDelito?delitoCodigo=111
            antecedente[] antecedentesList = null;
            String urlRelativa = "darAntecedentesDelito";
            var url = $"" + urlGeneral + urlRelativa + "?" + "delitoCodigo=" + delitoCodigo;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedentesList = JsonConvert.DeserializeObject<antecedente[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<antecedente> antecedentes = new List<antecedente>();
            if (antecedentesList != null)
            {
                for (int i = 0; i < antecedentesList.Length; i++)
                {
                    antecedentes.Add(antecedentesList[i]);
                }
            }
            return antecedentes;
        }

        public List<antecedente> darAntecedentesPorCiudadanoYDelito(String ciudadanoDi, int delitoCodigo)
        {
            //darAntecedentesCiudadanoDelito?delitoCodigo=1111&ciudadanoDi=aaaa
            antecedente[] antecedentesList = null;
            String urlRelativa = "darAntecedentesCiudadanoDelito";
            var url = $"" + urlGeneral + urlRelativa + "?" + "delitoCodigo=" + delitoCodigo + "&ciudadanoDi=" + ciudadanoDi;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedentesList = JsonConvert.DeserializeObject<antecedente[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<antecedente> antecedentes = new List<antecedente>();
            for (int i = 0; i < antecedentesList.Length; i++)
            {
                antecedentes.Add(antecedentesList[i]);
            }
            return antecedentes;
        }
        //----------------------------TipoDocumento----------------------------
        public tipoDocumento darTipoDocumentoPorCodigo(int codigo)
        {
            tipoDocumento antecedente = null;
            String urlRelativa = "darTipoDocumento";
            var url = $"" + urlGeneral + urlRelativa + "?codigo=" + codigo;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return antecedente;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            antecedente = JsonConvert.DeserializeObject<tipoDocumento>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return antecedente;
        }

        public List<tipoDocumento> darTipoDocumentos()
        {
            tipoDocumento[] tipoDocumentosList = null;
            String urlRelativa = "darTipoDocumentos";
            var url = $"" + urlGeneral + urlRelativa;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            tipoDocumentosList = JsonConvert.DeserializeObject<tipoDocumento[]>(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            List<tipoDocumento> tipoDocumentos = new List<tipoDocumento>();
            for (int i = 0; i < tipoDocumentosList.Length; i++)
            {
                tipoDocumentos.Add(tipoDocumentosList[i]);
            }
            return tipoDocumentos;
        }
        ////-------------------------Otros------------------------------/////

    }
}
