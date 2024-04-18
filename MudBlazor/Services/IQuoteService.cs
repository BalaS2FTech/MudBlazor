using Microsoft.EntityFrameworkCore;
using MudBlazor.dbcontext;
using MudBlazor.Models;

namespace MudBlazor.Services
{
    public interface IQuoteService
    {
        Task AddNewQuote(Quote quote);

        Task<List<Quote>> GetAllQuotes();
        Task UpdateQuotes(Quote quote);
        Task DeleteQuotes(Int32 id);
    }
    public class QuoteService : IQuoteService
    {
        public async  Task AddNewQuote(Quote quote)
        {
            using (var context = new AppDbContext())
            {
               await context.quotes.AddAsync(quote);
                await context.SaveChangesAsync();
            }
        }

        public async  Task<List<Quote>> GetAllQuotes()
        {
            using (var context = new AppDbContext())
            {
                return await context.quotes.ToListAsync();
            }

        }
        public async Task UpdateQuotes(Quote quote)
        {
            using (var context = new AppDbContext())
            {
                context.quotes.Update(quote);
                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteQuotes(int id)
        {
            using (var context = new AppDbContext())
            {
                var oldTask = await context.quotes.FindAsync(id);
                if (oldTask != null)
                {
                    context.quotes.Remove(oldTask);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
