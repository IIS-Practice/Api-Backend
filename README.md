IIS API

### Domain

   - Entities - Сущности
   - Abstractions - интерфейсы репозиториев

### Application
   - Services - сервисы к каждой сущности (т.е. папка, например, UserService. В ней интерфейс, реализация и валидация)

### Infrastructure
   - Repositories - реализация интерфейсов репозиториев
   - Data/Seeders - данные для заполнения базы данных по умолчанию
   - Data/EntityConfigurations - конфигурация сущностей через FluentAPI

### Presentation
   - Common/Middlewares - МИДЛВАААРЫ
   - Common/Swagger - какой-то файл
   - Common/Mapper - не факт, что надо
   - Comtrollers - контроллеры
