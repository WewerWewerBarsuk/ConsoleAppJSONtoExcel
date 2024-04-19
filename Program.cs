﻿using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsoleAppJSONtoExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonstring = """
                {"vacancies":[{"accommodation_capability":false,"additional_premium":30,"additional_requirements":"Квотируемое рабочее место<br/>для трудоустройства инвалидов (брожения, перегонки и ректификации)<br/>Ответственность<br/>Дисциплинированность","bonus_type":"MONTHLY","busy_type":"Полная занятость","career_perspective":false,"change_time":"2022-11-29T11:32:32+0300","code_external_system":"CZN","code_profession":"100656","code_professional_sphere":"Industry","code_professional_sphere_lc":"industry","company":{"companycode":"1077142000650","email":"zernoef@mail.ru","hr-agency":false,"inn":"7113067263","kpp":"711301001","name":"ООО \"ЗЕРНОПРОДУКТ\"","ogrn":"1077142000650","phone":"+7(48741)60144","url":"https://trudvsem.ru/company/1077142000650"},"company_business_size":"SMALL","company_code":"1077142000650","company_inn":"7113067263","contact_list":[{"contact_type":"Телефон","contact_value":"74874160266115","id_owner":"66ee0782-a01e-11ea-94f4-bf2cfe8c828d","is_moderated":true,"is_preferred":false},{"contact_type":"Эл. почта","contact_value":"nbir69@mail.ru","id_owner":"66ee0782-a01e-11ea-94f4-bf2cfe8c828d","is_moderated":true,"is_preferred":false},{"contact_type":"Мобильный телефон","id_owner":"66ee0782-a01e-11ea-94f4-bf2cfe8c828d","is_moderated":true,"is_preferred":false},{"contact_type":"Скайп","id_owner":"66ee0782-a01e-11ea-94f4-bf2cfe8c828d","is_moderated":true,"is_preferred":false},{"contact_type":"Другое","id_owner":"66ee0782-a01e-11ea-94f4-bf2cfe8c828d","is_moderated":true,"is_preferred":false}],"contact_person":"Бирюкова Надежда Борисовна","contact_source":"COMPANY","data_ids":["ed020ec0-9f5e-11ec-add7-bf2cfe8c828d","ed020ec1-9f5e-11ec-add7-bf2cfe8c828d","6358dab0-9f8f-11ec-b31b-550ed7335bbe","6358dab1-9f8f-11ec-b31b-550ed7335bbe","6358dab2-9f8f-11ec-b31b-550ed7335bbe"],"date_create":"2022-02-20T04:40:38+0300","date_modify":"2024-03-06T10:16:02+0300","deleted":false,"education":"Среднее профессиональное","federalDistrictCode":1,"full_company_name":"ОБЩЕСТВО С ОГРАНИЧЕННОЙ ОТВЕТСТВЕННОСТЬЮ \"ЗЕРНОПРОДУКТ\"","hardSkills":[],"id":"66ee0782-a01e-11ea-94f4-bf2cfe8c828d","is_mobility_program":false,"is_moderated":true,"is_quoted":true,"is_uzbekistan_recruitment":false,"languageKnowledge":[],"measure_type":"PERCENT","need_medcard":true,"original_source_type":"EMPLOYMENT_SERVICE","other_vacancy_benefit":"Социальный пакет","position_requirements":"Желателен опыт работы в пищевой промышленности. Технология бродильных производств.","position_responsibilities":"Выполнение отдельных технологических операций процесса  брожения и перегонки.","professionalSphereName":"Производство","publication_period":0,"published_date":"2024-03-06T10:16:01+0300","regionName":"Тульская область","required_drive_license":[],"required_experience":1,"retraining_grant":"нет стипендии","salary":"от 23000","salary_max":0,"salary_min":23000,"schedule_type":"Полный рабочий день","social_protected_ids":"Инвалиды","social_protected_ids_list":["инвалиды"],"softSkills":[],"source_type":"Работодатель","state_region_code":"7100000000000","status":"ACCEPTED","vac_url":"https://trudvsem.ru/vacancy/card/1077142000650/66ee0782-a01e-11ea-94f4-bf2cfe8c828d","vacancy_address":"Тульская область","vacancy_address_additional_info":"301840, г Ефремов, р-н Ефремовский, ул Московская Застава, д. 1","vacancy_address_code":"7100000000000","vacancy_address_latitude":54.221637,"vacancy_address_longitude":37.689833,"vacancy_name":"Аппаратчик 5 разряда","visibility":"VISIBLE_TO_ALL","work_places":2}]}
                """;

            RootObject? rootObject = JsonConvert.DeserializeObject<RootObject>(jsonstring);


            Console.WriteLine("It's done!");
        }
    }
}
