using PlayerUI.ServicioAntecedentesPenalesSWJavita;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Controller
{
    class ControllerAntecedentesPenales
    {
        private static ControllerAntecedentesPenales controller;
        private ServicioAntecedentesPenalesClient servicioAntecedentesPenales = new ServicioAntecedentesPenalesClient();

        private ControllerAntecedentesPenales()
        {
            ServicioAntecedentesPenalesClient servicioAntecedentesPenales = new ServicioAntecedentesPenalesClient();
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
            return servicioAntecedentesPenales.eliminarCiudadano(cedula);
        }

        public bool agregarCiudadano(String cedula, int tipoDocumento, String nombre, String apellido, DateTime fechaNacimiento, bool genero)
        {

            ciudadano ciudadano = new ciudadano();
            ciudadano.cedula=cedula;
            ciudadano.tipoDocumento=tipoDocumento;
            ciudadano.nombre=nombre;
            ciudadano.apellido=apellido;
            ciudadano.genero=genero;
            try
            {
                ciudadano.fechaNacimiento = fechaNacimiento;
                ciudadano.fechaNacimientoSpecified = true;
                ciudadano.tipoDocumentoSpecified = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return servicioAntecedentesPenales.agregarCiudadano(ciudadano);
        }

        public ciudadano darCiudadanoPorCedula(String cedula)
        {
            return servicioAntecedentesPenales.darCiudadanoPorCedula(cedula);
        }

        public List<ciudadano> darCiudadanos()
        {
            ciudadano[] ciudadanosList = servicioAntecedentesPenales.darCiudadanos();
            List<ciudadano> ciudadanos = new List<ciudadano>();
            for (int i = 0; i < ciudadanosList.Length; i++)
            {
                ciudadanos.Add(ciudadanosList[i]);
            }
            return ciudadanos;
        }

        public bool actualizarCiudadano(String cedula, int tipoDocumento, String nombre, String apellido, DateTime fechaNacimiento, bool genero)
        {
            ciudadano ciudadano = new ciudadano();
            ciudadano.cedula = cedula;
            ciudadano.tipoDocumento = tipoDocumento;
            ciudadano.nombre = nombre;
            ciudadano.apellido = apellido;
            ciudadano.genero = genero;
            try
            {
                ciudadano.fechaNacimiento = fechaNacimiento;
                ciudadano.fechaNacimientoSpecified = true;
                ciudadano.tipoDocumentoSpecified = true;
            }
            catch (Exception e)
            {
                //Error XD
            }
            return servicioAntecedentesPenales.actualizarCiudadano(ciudadano);
        }

        //----------------------------Delito----------------------------
        public delito darDelitoPorCodigo(int codigo)
        {
            return servicioAntecedentesPenales.darDelitoPorCodigo(codigo);
        }

        public List<delito> darDelitos()
        {
            delito[] delitosList = servicioAntecedentesPenales.darDelitos();
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
            antecedente[] antecedentesList = servicioAntecedentesPenales.darAntecedentes();
            List<antecedente> antecedentes = new List<antecedente>();
            for (int i = 0; i < antecedentesList.Length; i++)
            {
                antecedentes.Add(antecedentesList[i]);
            }
            return antecedentes;
        }

        public bool agregarAntecedente(String ciudadanoDi, int delitoCodigo, String ciudad, DateTime fechaDelito, int sentencia, String estado)
        {
            antecedente antecedente = new antecedente();
            antecedente.ciudadanoDi=ciudadanoDi;
            antecedente.delitoCodigo=delitoCodigo;
            antecedente.ciudad=ciudad;
            try
            {
                antecedente.fechaDelito = fechaDelito;
                antecedente.fechaDelitoSpecified = true;
            }
            catch (Exception e)
            {
                //ERROR XD
            }
            antecedente.sentencia=sentencia;
            antecedente.estado=estado;
            return servicioAntecedentesPenales.agregarAntecedente(antecedente);
        }

        public antecedente darAntecedentePorId(int id)
        {
            return servicioAntecedentesPenales.darAntecedentePorId(id);
        }

        public bool actualizarAntecedente(int id, String ciudadanoDi, int delitoCodigo, String ciudad, DateTime fechaDelito, int sentencia, String estado)
        {
            antecedente antecedente = new antecedente();
            antecedente.id = id;
            antecedente.ciudadanoDi = ciudadanoDi;
            antecedente.delitoCodigo = delitoCodigo;
            antecedente.ciudad = ciudad;
            try
            {
                antecedente.fechaDelito = fechaDelito;
                antecedente.fechaDelitoSpecified = true;
            }
            catch (Exception e)
            {
                //ERROR XD
            }
            antecedente.sentencia = sentencia;
            antecedente.estado = estado;
            return servicioAntecedentesPenales.actualizarAntecedente(antecedente);
        }

        public bool eliminarAntecedente(int id)
        {
            return servicioAntecedentesPenales.eliminarAntecedente(id);
        }

        public int darSentenciaTotalPorCiudadano(String ciudadanoDi)
        {
            return servicioAntecedentesPenales.darSentenciaTotalPorCiudadano(ciudadanoDi);
        }

        ////--------------------------Filtros------------------------------////

        public List<antecedente> darAntecedentesPorCiudadano(String ciudadanoDi)
        {
            antecedente[] antecedentesList = servicioAntecedentesPenales.darAntecedentesPorCiudadano(ciudadanoDi);
            List<antecedente> antecedentes = new List<antecedente>();
            for (int i = 0; i < antecedentesList.Length; i++)
            {
                antecedentes.Add(antecedentesList[i]);
            }
            return antecedentes;
        }

        public List<antecedente> darAntecedentesPorDelito(int delitoCodigo)
        {
            antecedente[] antecedentesList = servicioAntecedentesPenales.darAntecedentesPorDelito(delitoCodigo);
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
            antecedente[] antecedentesList = servicioAntecedentesPenales.darAntecedentesPorCiudadanoYDelito(ciudadanoDi, delitoCodigo);
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
            return servicioAntecedentesPenales.darTipoDocumentoPorCodigo(codigo);
        }

        public List<tipoDocumento> darTipoDocumentos()
        {
            tipoDocumento[] tipoDocumentosList = servicioAntecedentesPenales.darTipoDocumentos();
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
