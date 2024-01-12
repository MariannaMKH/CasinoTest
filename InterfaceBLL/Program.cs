using System;

namespace InterfaceBLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var _blfactory = new BLFactory();
            ClientModel tmpClient = null;
            using (var bl = _blfactory.CreateClientBL())
            {
                var value = bl.LoginClient(client.ClientLogin, client.Password);
                tmpClient = Mapper.Map<ClientModel>(value);
            }
            return tmpClient;
        }
    }
}
