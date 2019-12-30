namespace GettingStarted
{
    internal class Customer
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string FullName => $"{FirstName} {LastName}";

        public string Save() => FullName + "Saved";
     }
}