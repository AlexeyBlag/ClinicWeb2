ClinicWeb:
Веб-приложение для управления информационной базой клиентов ветеринарной клиники на ASP.NET Core 10 с использованием Blazor Server.


Описание:
ClinicWeb — это полнофункциональное веб-приложение для автоматизации учёта клиентов, питомцев и записей на приём в ветеринарной клинике. Приложение позволяет:
Регистрировать новых клиентов и их питомцев
Создавать и управлять записями на приём
Просматривать расписание ветеринаров
Вести медицинские карты
Поиск клиентов и записей


Используемые технологии:
.NET 10
ASP.NET Core
Blazor Server
Entity Framework Core 10
SQLite
Docker
CSS3 / Custom Properties


Установка и запуск приложения:
Клонирование репозитория
1.1     git clone https://github.com/AlexeyBlag/ClinicWeb.git
	cd ClinicWeb/ClinicWeb

Восстановление зависимостей
2.1     dotnet restore
Применение миграций базы данных
3.1     dotnet ef database update

4. Запуск приложения
4.1     dotnet run
4.2     Перейти по ссылке http://localhost:5110/

Запуск через Docker:
Сборка образа
1.1 docker build -t alexeyblag/clinicweb:net10 .
Запуск контейнера
2.1 docker run -d -p 8080:8080 --name clinicweb alexeyblag/clinicweb:net10

Перейти по ссылке http://localhost:8080

Сущности:
CLients - Клиенты клиники (ФИО, номер телефона, электронная почта)
Pets - Питомцы (Имя, вид, порода, дата рождения
Veterinarians - Врачи
Appointments - Записи на приём (Дата, причина, статус)
MedicalRecords - Медицинские карты (Диагноз, лечение, рекомендации)

Полезные команды:
Создание новой миграции:
dotnet ef migrations add MigrationName

Применение миграций:
dotnet ef database update

Сборка проекта:
dotnet build

Публикация:
dotnet publish -c Release -o ./publish

Очистка:
dotnet clean

Образ приложения доступен в Docker Hub: https://hub.docker.com/r/alexeyblag/clinicweb1

Структура проекта:

ClinicWeb/
├── ClinicWeb.csproj
├── Program.cs
├── appsettings.json
├── Dockerfile
├── docker-compose.yml
├── .gitignore
├── vetclinic.db
├── vetclinic.db-shm
├── vetclinic.db-wal
│
├── Connected Services/
│
├── Properties/
│
├── Зависимости/
│
├── wwwroot/
│   ├── lib/
│   ├── app.css
│   └── favicon.png
│
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor
│   │   └── ReconnectModal.razor
│   ├── Pages/
│   │   ├── Home.razor
│   │   ├── Clients.razor
│   │   ├── ClientDetails.razor
│   │   ├── CreateClient.razor
│   │   ├── Pets.razor
│   │   ├── Appointments.razor
│   │   ├── AppointmentDetails.razor
│   │   ├── CreateAppointment.razor
│   │   ├── Veterinarians.razor
│   │   ├── Error.razor
│   │   └── NotFound.razor
│   ├── _Imports.razor
│   ├── App.razor
│   └── Routes.razor
│
├── Data/
│   ├── AppDbContext.cs
│   └── DbSeeder.cs
│
├── Migrations/
│   ├── 20260507232316_RenameServiceToClinicService.cs
│   ├── 20260509211532_AddAppointmentFields.cs
│   ├── 20260509212927_AddNotesToMedicalRecord.cs
│   └── AppDbContextModelSnapshot.cs
│
├── Models/
│   ├── Appointment.cs
│   ├── AppointmentService.cs
│   ├── Clients.cs
│   ├── MedicalRecord.cs
│   ├── Pets.cs
│   ├── Service.cs
│   └── Veterinarian.cs
│
└── Services/
    ├── AppointmentRepository.cs
    ├── ClientRepository.cs
    ├── IAppointmentRepository.cs
    ├── IClientRepository.cs
    ├── IPetRepository.cs
    ├── IVeterinarianRepository.cs
    ├── PetRepository.cs
    └── VeterinarianRepository.cs

Описание основных папок:
Components/ - Blazor компоненты и страницы интерфейса
Components/Layout/ - Макеты страниц
Components/Pages/ - Razor страницы
Data/ - Контекст базы данных и сикер
Migrations/ - История изменений схемы БД
Models/ - Классы сущностей
Services/ - Репозитории для работы с данными
Validators/ - Валидаторы данных
wwwroot/ - CSS

Автор: Есин Данила Олегович
Группа: ББСО-02-24
Университет: РТУ МИРЭА, 2026
Репозиторий: https://github.com/AlexeyBlag/ClinicWeb2
Docker Hub: https://hub.docker.com/r/alexeyblag/clinicweb1
