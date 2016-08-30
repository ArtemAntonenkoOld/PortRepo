using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DAL.Concrate.BaseRepositories;
using Portfolio.DAL.Concrate.AllRepositories;
using Portfolio.Entity;

namespace Portfolio.Consoles
{
    static class Program
    {
       static void Main(string[] args)
        {
            using (var ctx = new PortfolioContext())
            {
                tbLanguages stud = new tbLanguages() {cLanguage="English",cLevel="B2"};

                ctx.tbLanguage.Add(stud);
                ctx.SaveChanges();
            }
        }


    }

}