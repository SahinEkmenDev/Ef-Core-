// See https://aka.ms/new-console-template for more information
using EF_Core_CodeFirst;
using EF_Core_CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;


Initializer.Build();
using (var _context = new AppDBContext())
{

    var  products= await _context.Products.ToListAsync();


    //products.ForEach(p =>
    //{

    //    p.stock += 100;





    //});
    _context.ChangeTracker.Entries().ToList().ForEach(e =>
    {


        if (e.Entity is Product p)
        {


            
            Console.WriteLine($"{p.Id}: {p.Name }- {p.Price} -{p.stock}- {p.barcode} ");

        }

    });






    _context.SaveChanges();













    //var product =await _context.Products.FirstAsync();
    //Console.WriteLine($"ilk satate :{_context.Entry(product).State}");
    //_context.Remove(product);
    //Console.WriteLine($"son state :{_context.Entry(product).State}");

    //await _context.SaveChangesAsync();
    //Console.WriteLine($"savechages:{_context.Entry(product).State}");

    //var newProduct = new Product { Name = "kalem200", Price = 200, stock = 200, barcode = 3333 };

    //Console.WriteLine($"ilk satate :{ _context.Entry(newProduct).State }"  );

    //await _context.AddAsync(newProduct);

    //Console.WriteLine($"son state :{_context.Entry(newProduct).State}");



    //await _context.SaveChangesAsync();

    //Console.WriteLine($"savechages:{_context.Entry(newProduct).State}");





    //var products = await _context.Products.ToListAsync();
    //products.ForEach(p =>
    //{
    //   var state=_context.Entry(p);
    //   Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}- {p.stock} state:{state} ");



    //});
}
