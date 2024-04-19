using System.Formats.Tar;
using System.Reflection;
using System.Text.Json.Serialization;
using ClosedXML.Excel;
using Newtonsoft.Json;

namespace ConsoleAppJSONtoExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? directory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
            string? pathDownload = @"\Download\vacancy_9.json";
            string? state_rigeon_code = "5000000000000";

            string border = "***********************************************";

            Console.WriteLine("Программа начала работу. Пожалуйста, ожидайте сообщения о том, что выполнение программа полностью завершено\n");

            Console.WriteLine(border);

            string pathfileJSON = $"{directory}{pathDownload}";

            Console.WriteLine(File.Exists(pathfileJSON) ? "Скаченный файл в фзормате JSON существует." : "Файл в формате JSON не найден. Скачайте файл");
            Console.WriteLine(border);

            DateTime timeCreationJSONfile = File.GetCreationTime(pathfileJSON);

            Console.WriteLine($"Дата создания JSON файла - {timeCreationJSONfile}");

            Console.WriteLine(border);

            Console.WriteLine("Запущен процесс разбора файла, подождите...");

            RootObject? rootObject = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(pathfileJSON));

            List<VacancyDataBasedModel> dataOuts = new List<VacancyDataBasedModel>();

            for (int i = 0; i < rootObject?.vacancies?.Count; i++)
            {
                VacancyDataBasedModel vacancyDataBasedModel = new VacancyDataBasedModel();

                if (rootObject?.vacancies[i].state_region_code == state_rigeon_code)
                {

                    vacancyDataBasedModel.vacancy_name = rootObject?.vacancies[i].vacancy_name;
                    vacancyDataBasedModel.professionalSphereName = rootObject?.vacancies[i].professionalSphereName;
                    if (rootObject?.vacancies[i]?.company?.ContainsKey("inn") != false)
                    { vacancyDataBasedModel.inn = rootObject?.vacancies[i]?.company?["inn"]; }
                    if (rootObject?.vacancies[i]?.company?.ContainsKey("ogrn") != false)
                    { vacancyDataBasedModel.ogrn = rootObject?.vacancies[i]?.company?["ogrn"]; }
                    if (rootObject?.vacancies[i]?.company?.ContainsKey("kpp") != false)
                    { vacancyDataBasedModel.kpp = rootObject?.vacancies[i]?.company?["kpp"]; }
                    if (rootObject?.vacancies[i]?.company?.ContainsKey("name") != false)
                    { vacancyDataBasedModel.name = rootObject?.vacancies[i]?.company?["name"]; }
                    vacancyDataBasedModel.education = rootObject?.vacancies[i].education;
                    vacancyDataBasedModel.required_experience = rootObject?.vacancies[i]?.required_experience;
                    vacancyDataBasedModel.schedule_type = rootObject?.vacancies[i].schedule_type;
                    vacancyDataBasedModel.busy_type = rootObject?.vacancies[i].busy_type;
                    vacancyDataBasedModel.salary_min = rootObject!.vacancies[i].salary_min;
                    vacancyDataBasedModel.salary_max = rootObject.vacancies[i].salary_max;
                    vacancyDataBasedModel.vac_url = rootObject.vacancies[i].vac_url;
                    vacancyDataBasedModel.date_create = rootObject.vacancies[i].date_create;
                    vacancyDataBasedModel.code_profession = rootObject.vacancies[i].code_profession;
                    vacancyDataBasedModel.vacancy_address = rootObject.vacancies[i].vacancy_address;
                    vacancyDataBasedModel.work_places = rootObject.vacancies[i].work_places;
                    vacancyDataBasedModel.date_modify = rootObject.vacancies[i].date_modify;
                    vacancyDataBasedModel.original_source_type = rootObject.vacancies[i].original_source_type;

                    dataOuts.Add(vacancyDataBasedModel);
                }

            }

            Console.WriteLine(border);
            Console.WriteLine("Файл разобран, запущен процесс создания Excel файла, ожидайте...");

            using var workbook = new XLWorkbook();
            var worksheet = workbook.AddWorksheet();

            worksheet.Cell("A2").InsertData(dataOuts);

            string nameExcelOutFile = $"{DateTime.Now.Day}.{DateTime.Now.Month.ToString("00")}.{DateTime.Now.Year}_out.xlsx";

            workbook.SaveAs(nameExcelOutFile);
            Console.WriteLine(border);

            Console.WriteLine($"Программа полностью завершена. Файл формата Excel расположен по пути:{directory}\\{nameExcelOutFile}");
        }
    }
}
