using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DATOS.MODELO;
using DATOS.DAOs;
using System.Web.Script.Serialization;
/// <summary>
/// Descripción breve de WSComputadoras
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
[System.Web.Script.Services.ScriptService]
public class WSComputadoras : System.Web.Services.WebService
{

    public WSComputadoras()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    
    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
    [WebMethod]
    public string getAll()
    {
        String strJSON = "";
        try
        {
            ComputadoraDao dao = new ComputadoraDao();
            List<Computadora> lslLista = dao.getAll();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            strJSON = new JavaScriptSerializer().Serialize(lslLista);
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return strJSON;
    }

}
