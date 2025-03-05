using System;

namespace ConsoleApp3
{
    
    public sealed class SecuritySystem
    {
        public string SystemID { get; set; }
        public string AccessLevel { get; set; }

        public SecuritySystem(string systemID, string accessLevel)
        {
            SystemID = systemID;
            AccessLevel = accessLevel;
        }

        public void Authenticate()
        {
            Console.WriteLine($"🔒 Security System {SystemID} authenticated with {AccessLevel} access.");
        }
    }

    
}
