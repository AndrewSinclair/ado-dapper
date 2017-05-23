using System;
using System.Data.SqlClient;

namespace Ado_Dapepr
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(local);database=AndrewEdu;Integrated Security=SSPI"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Person", conn);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Guid id = (Guid)rdr["Id"];
                        string name = (string)rdr["Name"];
                        ContactInfo contactInfo = null;
                        var contactInfoId = rdr["ContactInformation_Id"];

                        contactInfo = (object)contactInfoId != DBNull.Value ? new ContactInfo((Guid)contactInfoId) : null;

                        Person person = new Person(id, name, contactInfo);

                        Console.WriteLine(person.ToString());
                    }
                }
            }

            Console.WriteLine("End of Program");
        }
    }
}
