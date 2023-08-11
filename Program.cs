// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using MsSqlDriverBug;

Console.WriteLine("This is GC test for Microsoft.Data.SqlClient");


using (var context = new GarbageDbContext())
{
    Console.WriteLine("Querying 10 rows 1 by 1");

    for (int i = 0; i < 10; i++)
    {
        await context.Garbages.AsNoTracking().FirstOrDefaultAsync(x => x.ID == i);
    }

    Console.WriteLine("Finished!");

    Console.ReadKey();
}
