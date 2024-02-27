using api.Data;
using api.Dtos.Stack;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace api.Repoitory
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _contex;
        public StockRepository(ApplicationDBContext context)
        {
            _contex = context;
        }

        public async Task<Stock> CreateAsync(Stock stockModel)
        {
            await _contex.Stocks.AddAsync(stockModel);
            await _contex.SaveChangesAsync();
            return stockModel;
        }

        public async Task<Stock?> DeleteAsync(int id)
        {
            var stockModel = await _contex.Stocks.FirstOrDefaultAsync(x => x.Id == id);

            if (stockModel != null)
            {
                return null;
            }

            _contex.Stocks.Remove(stockModel);
            await _contex.SaveChangesAsync();
            return stockModel;

        }

        public async Task<List<Stock>> GetAllAsync()
        {
            return await _contex.Stocks.ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
            return  await _contex.Stocks.FindAsync(id);
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto updateDto)
        {
            var stockModel = await _contex.Stocks.FirstOrDefaultAsync(x=> x.Id == id);

            if(stockModel == null)
            {
                return null;
            }
            stockModel.Symbol = updateDto.Symbol;
            stockModel.CompanyName = updateDto.CompanyName;
            stockModel.Purchase = updateDto.Purchase;
            stockModel.LastDiv = updateDto.LastDiv;
            stockModel.MarketCap = updateDto.MarketCap;
            stockModel.Industry = updateDto.Industry;

            await _contex.SaveChangesAsync();
            return stockModel;
        }
    }
}
