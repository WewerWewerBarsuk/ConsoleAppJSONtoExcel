using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJSONtoExcel
{
    public class RootObject
    {
        public List<JsonModel>? vacancies {  get; set; }
    }

    public class VacancyDataBasedModel
    {
        public string? vacancy_name { get; set; }
        public string? professionalSphereName { get; set; }
        public string? inn { get; set; }
        public string? ogrn { get; set; }
        public string? kpp { get; set; }
        public string? name { get; set; }
        public string? education { get; set; }
        public string? required_experience { get; set; }
        public string? schedule_type { get; set; }
        public string? busy_type { get; set; }
        public int salary_min { get; set; }
        public int salary_max { get; set; }
        public string? vac_url { get; set; }
        public DateTime date_create { get; set; }
        public string? code_profession { get; set; }
        public string? vacancy_address { get; set; }
        public int work_places { get; set; }
        public DateTime date_modify { get; set; }
        public string? original_source_type { get; set; }
    }
    public class JsonModel : VacancyDataBasedModel
    {
        public Dictionary<string, string>? company { get; set; }
        public string? state_region_code { get; set; }
    }

}
