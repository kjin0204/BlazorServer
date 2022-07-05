using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorStudy.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Need TemperatureC!")] // ��ĭ���� �Է��ϸ� ���� ��
        [Range(typeof(int), "-100","100")] //�Է� �������� ����
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required(ErrorMessage = "Need Summary!")] // ��ĭ���� �Է��ϸ� ���� ��
        [StringLength(10, MinimumLength = 2, ErrorMessage = "2~10")] //�Է� �������� ����
        public string Summary { get; set; }
    }
}
