using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace cloud_testing_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        public Queue<string> user = new Queue<string>();


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Queue<string> Setconnection2p(string k)
        {
            if (user.Count < 4)
            {
                user.Enqueue(k);
            }
            return user;
        }
        public Queue<string> checkPlayers()
        {
            if (user.Count == 4)
            {
                //Create game
                //Addplayer -loop
                user.Clear();
                return user;//gameplayer
            }
            return user; // null
        }
    }
}
