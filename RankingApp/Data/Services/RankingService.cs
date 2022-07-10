using RankingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankingApp.Data.Services
{
    public class RankingService
    {
        ApplicationDbContext _context;

        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Write
        public Task<GameResult> AddGameResult(GameResult gameResult)
        {
            _context.GameResults.Add(gameResult); // 데이터 추가
            _context.SaveChanges(); //디비에 데이터 추가

            return Task.FromResult(gameResult);
        }
        //Update
        public Task<bool> UpdateGameResult(GameResult gameResult)
        {
            var findGameResult = _context.GameResults
                                .Where(k => k.Id == gameResult.Id)
                                .FirstOrDefault();

            if (findGameResult == null)
                return Task.FromResult(false);

            findGameResult.userName = gameResult.userName;
            findGameResult.Score = gameResult.Score;

            _context.SaveChanges();

            return Task.FromResult(true);
        }

        //Delete
        public Task<bool> DeleteGameResult(GameResult gameResult)
        {
            var findGameResult = _context.GameResults
                                .Where(k => k.Id == gameResult.Id)
                                .FirstOrDefault();

            if (findGameResult == null)
                return Task.FromResult(false);

            _context.GameResults.Remove(gameResult);
            _context.SaveChanges(); // db랑 동기화;

            return Task.FromResult(true);
        }


        //Read
        public Task<List<GameResult>> GetGameResultsAsync()
        {
            List<GameResult> results = _context.GameResults
                                    .OrderByDescending(item => item.Score).ToList();

            return Task.FromResult(results);

        }
    }

}

