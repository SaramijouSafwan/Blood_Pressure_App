using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blood_Pressure_Tracker_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBLOOD_PRESSURE" in both code and config file together.
    [ServiceContract]
    public interface IBLOOD_PRESSURE
    {
        [OperationContract(IsOneWay =false)]
        string measureBloodPressure(string _ssn, float _upper, float _lower);

        [OperationContract(IsOneWay = false)]
        List<string> trackBloodPressure(string _ssn);

        [OperationContract(IsOneWay = false)]
        List<string> getDietPlan(string _bloodPressureStatus);

        [OperationContract(IsOneWay = true)]
        void notifyUser(bool notify, int timeHour);

        [OperationContract(IsOneWay = false)]
        string cheakMail();

    }
}
