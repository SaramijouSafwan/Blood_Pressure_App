using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blood_Pressure_Tracker_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUSER" in both code and config file together.
    [ServiceContract]
    public interface IUSER
    {
        [OperationContract(IsOneWay = true)]
        void signUp(string _ssn, string _name, string _password, string _age, string _gender, string _weight);

        [OperationContract(IsOneWay = false)]
        string signIn(string _name, string _password);

        [OperationContract(IsOneWay = false)]
        List<string> findUser(string _ssn);

        [OperationContract(IsOneWay = true)]
        void updateUser(string _ssn, string _name, string _password, string _age, string _gender, string _weight);
    }
}
