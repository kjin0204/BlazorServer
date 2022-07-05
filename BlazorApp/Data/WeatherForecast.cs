using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Need TemperatureC!")] // 빈칸으로 입력하면 에러 남
        [Range(typeof(int), "-100", "100")] //int 입력 범위
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required(ErrorMessage = "Need Summary!")] // 빈칸으로 입력하면 에러 남
        [StringLength(10, MinimumLength = 2, ErrorMessage = "2~10")] //string 입력 범위
        public string Summary { get; set; }
    }
}
