using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raport
{
	class Connection
	{
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XcMixYUmudgztyGv4WtsjraPLds7bvlQNN3LBIxG",
            BasePath = "https://raport-84888.firebaseio.com/"
        };
        /*create client object to interact with firebase*/
       public  IFirebaseClient client;

        public Connection()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                Console.Write("There is no internet connection!");
            }
        }
    }
}
