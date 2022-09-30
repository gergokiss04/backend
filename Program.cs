using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mysqlDBConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connect c = new Connect();
            Queries q = new Queries();
            q.dbSelect();

            Console.WriteLine("Szeretne Id-t törölni (igen/nem)?");
            string i = Console.ReadLine();

            if (i=="igen")
            {
            Console.WriteLine("Kérem az azonosítót amit törölni szeretne:");
            int id =Convert.ToInt32(Console.ReadLine());
            q.dbDelete(id);
            }
            else
            {
            Console.WriteLine("Szeretne új rekordot felvinni az adatbázisba (igen/nem)?");
            string ii=Console.ReadLine();
                if (ii == "igen")
                {
                    Console.WriteLine("Kérem adja meg a felhasználó nevet:");
                    string username = Console.ReadLine();

                    Console.WriteLine("Kérem adja meg a email címét:");
                    string email = Console.ReadLine();


                    q.dbinsertinto(username, email);
                    q.dbSelect();

                }
                else
                {
                    Console.WriteLine("Szeretne felfrissíteni egy rekordot az adatbázisba (igen/nem)?");
                    string yes = Console.ReadLine();
                    if (yes == "igen")
                    {
                        Console.WriteLine("Kérem adja meg a ID-t amelyik rekordon akar módosítani:");
                        int iii = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Kérem adja meg a felhasználó nevet:");
                        string usern = Console.ReadLine();

                        Console.WriteLine("Kérem adja meg a email címét:");
                        string mail = Console.ReadLine();


                        q.update(usern, mail, iii);
                        q.dbSelect();

                    }
                    else
                    {
                        Console.WriteLine("Viszlát!");
                    }
                }
            }


            

           


            Console.ReadKey();
        }
    }
}
