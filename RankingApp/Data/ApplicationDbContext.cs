using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RankingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

//엔티티 프레임워크 디비 연동
namespace RankingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GameResult> GameResults { get; set; }// DB에서 모델링을 이용해 갱신
        //public DbSet<Test1> TestResults { get; set; }// DB에서 모델링을 이용해 갱신

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
