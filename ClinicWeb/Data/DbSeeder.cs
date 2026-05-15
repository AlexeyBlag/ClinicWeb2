using Microsoft.EntityFrameworkCore;
using  ClinicWeb.Models;

namespace  ClinicWeb.Data
{

    public static class DbSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
 
            if (context.Clients.Any())
            {
                return; 
            }


            var clients = new List<Client>
            {
                new Client { FullName = "Иванов Иван Иванович", Phone = "+7 (999) 123-45-67", Email = "ivanov@mail.ru" },
                new Client { FullName = "Петрова Мария Сергеевна", Phone = "+7 (999) 234-56-78", Email = "petrova@mail.ru" },
                new Client { FullName = "Сидоров Алексей Петрович", Phone = "+7 (999) 345-67-89", Email = "sidorov@mail.ru" },
                new Client { FullName = "Козлова Елена Владимировна", Phone = "+7 (999) 456-78-90", Email = "kozlova@mail.ru" },
                new Client { FullName = "Новиков Дмитрий Александрович", Phone = "+7 (999) 567-89-01", Email = "novikov@mail.ru" },
                new Client { FullName = "Морозова Анна Игоревна", Phone = "+7 (999) 678-90-12", Email = "morozova@mail.ru" },
                new Client { FullName = "Волков Сергей Михайлович", Phone = "+7 (999) 789-01-23", Email = "volkov@mail.ru" },
                new Client { FullName = "Лебедева Ольга Николаевна", Phone = "+7 (999) 890-12-34", Email = "lebedeva@mail.ru" },
                new Client { FullName = "Соколов Павел Андреевич", Phone = "+7 (999) 901-23-45", Email = "sokolov@mail.ru" },
                new Client { FullName = "Кузнецова Татьяна Викторовна", Phone = "+7 (999) 012-34-56", Email = "kuznetsova@mail.ru" },
                new Client { FullName = "Попов Игорь Сергеевич", Phone = "+7 (998) 123-45-67", Email = "popov@mail.ru" },
                new Client { FullName = "Васильева Светлана Павловна", Phone = "+7 (998) 234-56-78", Email = "vasilieva@mail.ru" },
                new Client { FullName = "Смирнов Андрей Владимирович", Phone = "+7 (998) 345-67-89", Email = "smirnov@mail.ru" },
                new Client { FullName = "Ковалёва Ирина Александровна", Phone = "+7 (998) 456-78-90", Email = "kovaleva@mail.ru" },
                new Client { FullName = "Михайлов Николай Петрович", Phone = "+7 (998) 567-89-01", Email = "mikhailov@mail.ru" },
                new Client { FullName = "Федорова Юлия Сергеевна", Phone = "+7 (998) 678-90-12", Email = "fedorova@mail.ru" },
                new Client { FullName = "Павлов Виктор Иванович", Phone = "+7 (998) 789-01-23", Email = "pavlov@mail.ru" },
                new Client { FullName = "Семенова Наталья Дмитриевна", Phone = "+7 (998) 890-12-34", Email = "semenova@mail.ru" },
                new Client { FullName = "Григорьев Максим Алексеевич", Phone = "+7 (998) 901-23-45", Email = "grigoriev@mail.ru" },
                new Client { FullName = "Александрова Екатерина Олеговна", Phone = "+7 (998) 012-34-56", Email = "aleksandrova@mail.ru" }
            };

            await context.Clients.AddRangeAsync(clients);
            await context.SaveChangesAsync();


            var pets = new List<Pet>
            {
                new Pet { Name = "Зефир", Species = "Кошка", Breed = "Домашняя короткошёрстная", BirthDate = new DateTime(2018, 5, 12), ClientId = clients[0].Id },
                new Pet { Name = "Вафля", Species = "Собака", Breed = "Дворняга", BirthDate = new DateTime(2019, 3, 20), ClientId = clients[1].Id },
                new Pet { Name = "Степа", Species = "Кошка", Breed = "Сибирская", BirthDate = new DateTime(2017, 8, 15), ClientId = clients[2].Id },
                new Pet { Name = "Бобик", Species = "Собака", Breed = "Такса", BirthDate = new DateTime(2020, 1, 10), ClientId = clients[3].Id },
                new Pet { Name = "Пушок", Species = "Кот", Breed = "Персидская", BirthDate = new DateTime(2016, 11, 5), ClientId = clients[4].Id },
                new Pet { Name = "Рекс", Species = "Собака", Breed = "Немецкая овчарка", BirthDate = new DateTime(2019, 7, 22), ClientId = clients[5].Id },
                new Pet { Name = "Соня", Species = "Кошка", Breed = "Британская", BirthDate = new DateTime(2018, 4, 18), ClientId = clients[6].Id },
                new Pet { Name = "Тузик", Species = "Собака", Breed = "Лабрадор", BirthDate = new DateTime(2020, 9, 3), ClientId = clients[7].Id },
                new Pet { Name = "Васька", Species = "Кот", Breed = "Сфинкс", BirthDate = new DateTime(2019, 12, 25), ClientId = clients[8].Id },
                new Pet { Name = "Белка", Species = "Собака", Breed = "Спаниель", BirthDate = new DateTime(2017, 6, 14), ClientId = clients[9].Id },
                new Pet { Name = "Рыжик", Species = "Кошка", Breed = "Рыжая домашняя", BirthDate = new DateTime(2021, 2, 8), ClientId = clients[10].Id },
                new Pet { Name = "Джек", Species = "Собака", Breed = "Джек-рассел-терьер", BirthDate = new DateTime(2018, 10, 30), ClientId = clients[11].Id },
                new Pet { Name = "Симба", Species = "Кот", Breed = "Мейн-кун", BirthDate = new DateTime(2017, 3, 17), ClientId = clients[12].Id },
                new Pet { Name = "Лайма", Species = "Собака", Breed = "Хаски", BirthDate = new DateTime(2019, 5, 21), ClientId = clients[13].Id },
                new Pet { Name = "Багира", Species = "Кошка", Breed = "Пантера домашняя", BirthDate = new DateTime(2020, 8, 11), ClientId = clients[14].Id },
                new Pet { Name = "Тоби", Species = "Собака", Breed = "Бигль", BirthDate = new DateTime(2018, 1, 28), ClientId = clients[15].Id },
                new Pet { Name = "Луна", Species = "Кошка", Breed = "Сиамская", BirthDate = new DateTime(2019, 11, 9), ClientId = clients[16].Id },
                new Pet { Name = "Арсен", Species = "Собака", Breed = "Кавказская овчарка", BirthDate = new DateTime(2017, 4, 16), ClientId = clients[17].Id },
                new Pet { Name = "Мурзик", Species = "Кот", Breed = "Бенгальская", BirthDate = new DateTime(2020, 6, 23), ClientId = clients[18].Id },
                new Pet { Name = "Джесси", Species = "Собака", Breed = "Йоркширский терьер", BirthDate = new DateTime(2019, 9, 7), ClientId = clients[19].Id },
                new Pet { Name = "Феликс", Species = "Кот", Breed = "Шотландская вислоухая", BirthDate = new DateTime(2018, 7, 13), ClientId = clients[0].Id },
                new Pet { Name = "Бим", Species = "Собака", Breed = "Сеттер", BirthDate = new DateTime(2017, 12, 19), ClientId = clients[1].Id },
                new Pet { Name = "Нюша", Species = "Свинка", Breed = "Декоративная", BirthDate = new DateTime(2021, 3, 5), ClientId = clients[2].Id },
                new Pet { Name = "Кеша", Species = "Попугай", Breed = "Волнистый", BirthDate = new DateTime(2020, 10, 12), ClientId = clients[3].Id },
                new Pet { Name = "Гоша", Species = "Хомяк", Breed = "Сирийский", BirthDate = new DateTime(2021, 1, 20), ClientId = clients[4].Id },
                new Pet { Name = "Чип", Species = "Собака", Breed = "Чихуахуа", BirthDate = new DateTime(2019, 8, 27), ClientId = clients[5].Id },
                new Pet { Name = "Дейл", Species = "Собака", Breed = "Померанский шпиц", BirthDate = new DateTime(2020, 4, 15), ClientId = clients[6].Id },
                new Pet { Name = "Ася", Species = "Кошка", Breed = "Абиссинская", BirthDate = new DateTime(2018, 2, 9), ClientId = clients[7].Id },
                new Pet { Name = "Гарри", Species = "Попугай", Breed = "Корелла", BirthDate = new DateTime(2019, 6, 30), ClientId = clients[8].Id }
            };

            await context.Pets.AddRangeAsync(pets);
            await context.SaveChangesAsync();


            var veterinarians = new List<Veterinarian>
            {
                new Veterinarian { FullName = "Смирнов Анатолий Петрович", Specialization = "Хирург", Phone = "+7 (495) 123-45-67", Email = "smirnov@vetclinic.ru" },
                new Veterinarian { FullName = "Козлова Марина Игоревна", Specialization = "Терапевт", Phone = "+7 (495) 234-56-78", Email = "kozlova@vetclinic.ru" },
                new Veterinarian { FullName = "Волков Дмитрий Сергеевич", Specialization = "Стоматолог", Phone = "+7 (495) 345-67-89", Email = "volkov@vetclinic.ru" },
                new Veterinarian { FullName = "Лебедева Ольга Владимировна", Specialization = "Офтальмолог", Phone = "+7 (495) 456-78-90", Email = "lebedeva@vetclinic.ru" },
                new Veterinarian { FullName = "Павлов Игорь Александрович", Specialization = "Дерматолог", Phone = "+7 (495) 567-89-01", Email = "pavlov@vetclinic.ru" }
            };

            await context.Veterinarians.AddRangeAsync(veterinarians);
            await context.SaveChangesAsync();


            var services = new List<ClinicService>
            {
                new ClinicService { Name = "Первичный осмотр", Description = "Консультация и осмотр животного", Price = 500, DurationMinutes = 30 },
                new ClinicService { Name = "Вакцинация", Description = "Прививка от основных заболеваний", Price = 800, DurationMinutes = 20 },
                new ClinicService { Name = "Кастрация кота", Description = "Плановая операция по кастрации", Price = 2500, DurationMinutes = 60 },
                new ClinicService { Name = "Стерилизация кошки", Description = "Плановая операция по стерилизации", Price = 3500, DurationMinutes = 90 },
                new ClinicService { Name = "Чистка зубов", Description = "Профессиональная чистка зубов", Price = 1500, DurationMinutes = 45 },
                new ClinicService { Name = "Стрижка когтей", Description = "Подстригание когтей", Price = 300, DurationMinutes = 15 },
                new ClinicService { Name = "УЗИ диагностика", Description = "Ультразвуковое исследование", Price = 1200, DurationMinutes = 30 },
                new ClinicService { Name = "Рентген", Description = "Рентгеновское исследование", Price = 1000, DurationMinutes = 20 },
                new ClinicService { Name = "Анализ крови", Description = "Общий и биохимический анализ", Price = 900, DurationMinutes = 15 },
                new ClinicService { Name = "Обработка от паразитов", Description = "Обработка от блох и клещей", Price = 400, DurationMinutes = 10 }
            };

            await context.Services.AddRangeAsync(services);
            await context.SaveChangesAsync();


            var appointments = new List<Appointment>
            {
                new Appointment { AppointmentDate = new DateTime(2024, 5, 10, 10, 0, 0), Reason = "Плановый осмотр", Status = "Завершено", Notes = "Животное здорово", ClientId = clients[0].Id, PetId = pets[0].Id, VeterinarianId = veterinarians[0].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 11, 11, 30, 0), Reason = "Вакцинация", Status = "Завершено", Notes = "Прививка сделана", ClientId = clients[1].Id, PetId = pets[1].Id, VeterinarianId = veterinarians[1].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 12, 14, 0, 0), Reason = "Кастрация", Status = "Завершено", Notes = "Операция прошла успешно", ClientId = clients[2].Id, PetId = pets[2].Id, VeterinarianId = veterinarians[0].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 13, 9, 0, 0), Reason = "Чистка зубов", Status = "Завершено", Notes = "Зубы очищены", ClientId = clients[3].Id, PetId = pets[3].Id, VeterinarianId = veterinarians[2].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 14, 15, 30, 0), Reason = "УЗИ", Status = "Завершено", Notes = "Патологий не выявлено", ClientId = clients[4].Id, PetId = pets[4].Id, VeterinarianId = veterinarians[3].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 15, 10, 0, 0), Reason = "Стрижка когтей", Status = "Завершено", Notes = "Когти подстрижены", ClientId = clients[5].Id, PetId = pets[5].Id, VeterinarianId = veterinarians[1].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 16, 12, 0, 0), Reason = "Анализ крови", Status = "Завершено", Notes = "Анализы в норме", ClientId = clients[6].Id, PetId = pets[6].Id, VeterinarianId = veterinarians[1].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 17, 16, 0, 0), Reason = "Обработка от паразитов", Status = "Завершено", Notes = "Обработка проведена", ClientId = clients[7].Id, PetId = pets[7].Id, VeterinarianId = veterinarians[4].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 18, 11, 0, 0), Reason = "Рентген", Status = "Завершено", Notes = "Переломов нет", ClientId = clients[8].Id, PetId = pets[8].Id, VeterinarianId = veterinarians[0].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 19, 13, 30, 0), Reason = "Стерилизация", Status = "Завершено", Notes = "Операция успешна", ClientId = clients[9].Id, PetId = pets[9].Id, VeterinarianId = veterinarians[0].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 20, 10, 30, 0), Reason = "Повторный осмотр", Status = "Запланировано", Notes = "", ClientId = clients[10].Id, PetId = pets[10].Id, VeterinarianId = veterinarians[1].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 21, 14, 30, 0), Reason = "Вакцинация", Status = "Запланировано", Notes = "", ClientId = clients[11].Id, PetId = pets[11].Id, VeterinarianId = veterinarians[1].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 22, 9, 30, 0), Reason = "Консультация", Status = "Запланировано", Notes = "", ClientId = clients[12].Id, PetId = pets[12].Id, VeterinarianId = veterinarians[2].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 23, 15, 0, 0), Reason = "Чистка ушей", Status = "Запланировано", Notes = "", ClientId = clients[13].Id, PetId = pets[13].Id, VeterinarianId = veterinarians[4].Id },
                new Appointment { AppointmentDate = new DateTime(2024, 5, 24, 11, 30, 0), Reason = "Осмотр кожи", Status = "Запланировано", Notes = "", ClientId = clients[14].Id, PetId = pets[14].Id, VeterinarianId = veterinarians[4].Id }
            };

            await context.Appointments.AddRangeAsync(appointments);
            await context.SaveChangesAsync();

 
            var medicalRecords = new List<MedicalRecord>
            {
                new MedicalRecord { Diagnosis = "Здоров", Treatment = "Не требуется", Recommendations = "Продолжать кормление по режиму", RecordDate = appointments[0].AppointmentDate, AppointmentId = appointments[0].Id },
                new MedicalRecord { Diagnosis = "Здоров, готов к вакцинации", Treatment = "Вакцина Nobivac", Recommendations = "Карантин 2 недели", RecordDate = appointments[1].AppointmentDate, AppointmentId = appointments[1].Id },
                new MedicalRecord { Diagnosis = "Плановая кастрация", Treatment = "Хирургическое вмешательство", Recommendations = "Покой 3 дня, обработка шва", RecordDate = appointments[2].AppointmentDate, AppointmentId = appointments[2].Id },
                new MedicalRecord { Diagnosis = "Зубной камень", Treatment = "Чистка под наркозом", Recommendations = "Чистить зубы специальной щёткой", RecordDate = appointments[3].AppointmentDate, AppointmentId = appointments[3].Id },
                new MedicalRecord { Diagnosis = "Беременность 30 дней", Treatment = "Не требуется", Recommendations = "Увеличить рацион, витамины", RecordDate = appointments[4].AppointmentDate, AppointmentId = appointments[4].Id },
                new MedicalRecord { Diagnosis = "Здоров", Treatment = "Профилактика", Recommendations = "Стричь когти раз в месяц", RecordDate = appointments[5].AppointmentDate, AppointmentId = appointments[5].Id },
                new MedicalRecord { Diagnosis = "Анемия лёгкой степени", Treatment = "Препараты железа", Recommendations = "Добавить в рацион мясо, печень", RecordDate = appointments[6].AppointmentDate, AppointmentId = appointments[6].Id },
                new MedicalRecord { Diagnosis = "Блохи", Treatment = "Обработка каплями Advantix", Recommendations = "Повторить через 3 недели", RecordDate = appointments[7].AppointmentDate, AppointmentId = appointments[7].Id },
                new MedicalRecord { Diagnosis = "Здоров", Treatment = "Не требуется", Recommendations = "Активные прогулки", RecordDate = appointments[8].AppointmentDate, AppointmentId = appointments[8].Id },
                new MedicalRecord { Diagnosis = "Плановая стерилизация", Treatment = "Хирургическое вмешательство", Recommendations = "Швы снимать через 10 дней", RecordDate = appointments[9].AppointmentDate, AppointmentId = appointments[9].Id }
            };

            await context.MedicalRecords.AddRangeAsync(medicalRecords);
            await context.SaveChangesAsync();


            var appointmentServices = new List<AppointmentService>
            {
                new AppointmentService { AppointmentId = appointments[0].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[1].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[1].Id, ServiceId = services[1].Id },
                new AppointmentService { AppointmentId = appointments[2].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[2].Id, ServiceId = services[2].Id },
                new AppointmentService { AppointmentId = appointments[3].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[3].Id, ServiceId = services[4].Id },
                new AppointmentService { AppointmentId = appointments[4].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[4].Id, ServiceId = services[6].Id },
                new AppointmentService { AppointmentId = appointments[5].Id, ServiceId = services[5].Id },
                new AppointmentService { AppointmentId = appointments[6].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[6].Id, ServiceId = services[8].Id },
                new AppointmentService { AppointmentId = appointments[7].Id, ServiceId = services[9].Id },
                new AppointmentService { AppointmentId = appointments[8].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[8].Id, ServiceId = services[7].Id },
                new AppointmentService { AppointmentId = appointments[9].Id, ServiceId = services[0].Id },
                new AppointmentService { AppointmentId = appointments[9].Id, ServiceId = services[3].Id }
            };

            await context.AppointmentServices.AddRangeAsync(appointmentServices);
            await context.SaveChangesAsync();
        }
    }
}