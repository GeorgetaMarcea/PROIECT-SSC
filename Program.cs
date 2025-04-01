using System;
using System.Data.SqlClient; //biblioteca necesara pentru SQL Server

namespace SSC
{
    class Program
    {
        private static readonly string connectionString = "Server=localhost;Database=SSCdatabase;Trusted_Connection=True;";
        //private -> apartine doar clasei Program
        /*static -> apartine unei clase, nu a unei instante a unei clase
                 -> daca avem static, atunci variabila este stocata intr o zona de memorie speciala*/
        //readonly -> variabila nu poate fii modificata 
        //Server=localhost -> Serverul SQL e instalat pe acelasi calculator
        /*Trusted_Connection=True -> folosim autentificarea Windows
                                  -> putem sa folosim si autentificare cu user si parola: User Id=utilizator; Password=parola */
        static void Main()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("M am conectat la baza de date din SQL Server!!!");
                    
                    //adaugam un utilizator: id, nume, email si parola
                    //WriteLine -> adauga new line
                    //Write -> nu adauga new line

                    Console.WriteLine("Adaugati un nou utilizator:");
                    Console.Write("Introduceti numele utilizatorului:");
                    string name = Console.ReadLine();

                    Console.Write("Introduceti email-ul:");
                    string email = Console.ReadLine();

                    Console.Write("Introduceti parola:");
                    string password = Console.ReadLine();

                    //pentru parola trebuie sa o criptam/decriptam, inca nu stiu cum sa fac asta 


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la conectarea la baza de date!!!");
                }

            }
        }
    }
}
