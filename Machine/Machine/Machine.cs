using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    class Machine
    {    // Constant for maximum speed.
        public const int MaxSpeed = 100;

    // Machine properties.
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";

    // Is the Machine still operational?
    private bool MachineIsDead;

    // A Machine has-a radio.
    private Protection theProtectionKit = new Protection();

    // Constructors.
    public Machine() { }
    public Machine(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }

    public void CrankTunes(bool state)
    {
        // Delegate request to inner object.
        theProtectionKit.TurnOn(state);
    }

    #region Accelerate w/ exception. 
    // See if Machine has overheated.
    public void Accelerate(int delta)
    {
        if (MachineIsDead)
            Console.WriteLine("{0} is out of order...", PetName);
        else
        {
            CurrentSpeed += delta;
            if (CurrentSpeed >= MaxSpeed)
            {
                MachineIsDead = true;
                CurrentSpeed = 0;

                // We need to call the HelpLink property, thus we need
                // to create a local variable before throwing the Exception object.
                Exception ex =
                  new Exception(string.Format("{0} has overheated!", PetName));
                ex.HelpLink = "http://www.MachinesRUs.com";

                // Stuff in custom data regarding the error.
                ex.Data.Add("TimeStamp",
                  string.Format("The Machine exploded at {0}", DateTime.Now));
                ex.Data.Add("Cause", "You have a lead foot.");
                throw ex;
            }
            else
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
        }
    }
    #endregion
}
}
