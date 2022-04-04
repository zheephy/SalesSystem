namespace SalesSystem
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return  $"ID: {Id}\n" +
                    $"Names: {FirstName} {LastName} \n" +
                    $"Birth: {BirthDate} \n" +
                    $"Hiring: {HiringDate} \n" +
                    $"Is Active: {IsActive}";
        }
    }
}
