using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment2.Models
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {

                // CLIENTS
                if (context.Client.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var clients = new List<Client>
                {
                    new Client { ClientFName="Jimmie", ClientLName="Ramos", Company="ACME", Email="jramos@acme.com", PhoneNumber="555-555-5555" },
                    new Client { ClientFName="Kristy", ClientLName="Miles", Company="World Wide Industries", Email="kmiles@wwi.com", PhoneNumber="555-555-5555" },
                    new Client { ClientFName="Shelley", ClientLName="Walker", Company="Big Money Inc", Email="swalker@bigmoneyinc.com", PhoneNumber="555-555-5555" }
                };
                context.AddRange(clients);
                context.SaveChanges();


                // CLIENTS
                if (context.Member.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var members = new List<Member>
                {
                    new Member { MemberFName="John", MemberLName="Cunningham", Major="CIS", Email="jcunnignham@buffs.wtamu.edu", PhoneNumber="555-555-5555" },
                    new Member { MemberFName="Michael", MemberLName="Matthews", Major="CIS", Email="mmathews@buffs.wtamu.edu", PhoneNumber="555-555-5555" },
                    new Member { MemberFName="Mara", MemberLName="Kiniff", Major="CIS", Email="mkinoff@buffs.wtamu.edu", PhoneNumber="555-555-5555" },
                    new Member { MemberFName="Amy", MemberLName="Saysouriyosack", Major="CIS", Email="asaysouriyosack@buffs.wtamu.edu", PhoneNumber="555-555-5555" },
                    new Member { MemberFName= "Vanessa", MemberLName="Valenzuela", Major="CIS", Email="vvalenzuela@buffs.wtamu.edu", PhoneNumber="555-555-5555" },
                    new Member { MemberFName="Claudia", MemberLName="Silva", Major="CIS", Email="csilva@buffs.wtamu.edu", PhoneNumber="555-555-5555" },
                    new Member { MemberFName="Kayla", MemberLName="Washington", Major="CIS", Email="kwashington@buffs.wtamu.edu", PhoneNumber="555-555-5555" }
                };
                context.AddRange(members);
                context.SaveChanges();
            }
        }
    }
}