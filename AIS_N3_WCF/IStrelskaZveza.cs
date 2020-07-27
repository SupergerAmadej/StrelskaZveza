using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AIS_N3_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStrelskaZveza
    {
        // --------------------

        [OperationContract]
        bool AddKlub(Klub k, out int id);
        [OperationContract]
        bool AddStrelec(Strelec s, out int id);

        [OperationContract]
        bool UpdateKlub(Klub k);
        [OperationContract]
        bool UpdateStrelec(Strelec k);
        [OperationContract]
        bool UpdateSVK(StrelecVKlubu svk);
        [OperationContract]
        bool DodajStrelcaVklub(Strelec s, string kid, out int id);


        [OperationContract]
        bool DeleteKlub(string id);
        [OperationContract]
        bool DeleteStrelec(string id);
        [OperationContract]
        bool DeleteSVK(string id);


        [OperationContract]
        IEnumerable<Klub> ReturnKlubi();
        [OperationContract]
        IEnumerable<Strelec> ReturnStrelci();
        [OperationContract]
        IEnumerable<StrelecVKlubu> ReturnStrelecVKlubus();
        [OperationContract]
        IEnumerable<User> ReturnUseri();

        [OperationContract]
        Klub GetKlub(string id);

        [OperationContract]
        Strelec GetStrelec(string id);


        [OperationContract]
        IEnumerable<Strelec> StrelciInKlub(string id);
        [OperationContract]
        IEnumerable<Klub> KlubiOdStrelca(string id, out int[] trenutnoAktivni);

        [OperationContract]
        bool CheckUser(User u, out bool admin);


    }

}
