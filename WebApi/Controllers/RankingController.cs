using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedData.Models;
using WebApi.Data;

namespace WebApi.Controllers
{
    // REST (Representational State Transfer
    //공싱 표준 스펙은 아님
    //원래 있던 HTTP통신에서 기능을 '재사용'해서 데이터 송수신 규칙을 만든 것
    //CRUD

    //Create(POST)
    ///api/ranking
    //생성 Body에 실제정보 전송

    //Read(GET)
    // /api/ranking
    //모든 아이템을 주세요
    // /api/ranking/1
    //아이디가 1번인 데이터를 주세요

    //Update(Put)
    //웹에서는 보안상 문제로 사용 하지 않음.
    //바디에 실제정보를 전송

    //Delete(DELETE)
    //DELETE도 보안 문제로 잘 사용 하지 않음.


    // ApiController 특징
    // C# 객체를 반환해도 된다.
    //null값을 반환 하면 204 Reponse 반환
    //string -> text/plain
    //나머지 (int, bool) -> application/json 형태로 반환

    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        ApplicationDbContext _context;

        public RankingController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Create

        //Read

        [HttpGet]
        public List<GameResult>GetGameResults()
        {
            List<GameResult> results = _context.GameResults
                                    .OrderByDescending(k => k.Score)
                                    .ToList();
            return results;
        }



        [HttpGet("{id}")]
        public GameResult GetGameResults(int id)
        {
            GameResult result = _context.GameResults
                                    .Where(k => k.Id == id)
                                    .FirstOrDefault();
            return result;
        }


        //Update

        //Delete
    }
}
