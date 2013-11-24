using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChessService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChessServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ChessServiceImpl.svc or ChessServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class ChessServiceImpl : IChessService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /*
        public bool RegisterNewPlayer(ChessPlayer player)
        {
            Console.WriteLine("Registering a new player. NOT IMPLEMENTED YET!");
            return false;
        }
        */ 
    }
}
