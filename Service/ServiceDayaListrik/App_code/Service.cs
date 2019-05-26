using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double Pemakaian_PerMenit(double watt, int jumlah_menit, double tarif_perkwh)
    {
        return ((watt / 1000) * jumlah_menit / 60) * tarif_perkwh;
    }
    
    [WebMethod]
    public double Pemakaian_PerJam(double watt, int jumlah_jam, double tarif_perkwh)
    {
        return ((watt / 1000) * jumlah_jam) * tarif_perkwh;
    }
    [WebMethod]
    public double Pemakaian_PerHari(double watt, int jumlah_jam, int jumlah_menit, double tarif_perkwh ) 
    {
        return ((watt / 1000 ) * ( jumlah_jam + ( jumlah_menit/ 60))) * tarif_perkwh;
    }
    [WebMethod]
    public double Pemakaian_PerBulan(double watt, int jumlah_jam, double jumlah_menit, double tarif_perkwh, int hari)
    {
        return (((watt / 1000) * (jumlah_jam + (jumlah_menit / 60))) * tarif_perkwh) * hari;
    }
}
